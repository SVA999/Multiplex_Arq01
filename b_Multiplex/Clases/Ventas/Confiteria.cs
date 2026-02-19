using b_Multiplex.Eventos;
using b_Multiplex.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace b_Multiplex.Clases.Ventas
{
    public class Confiteria : IVentaConsumible, IVentaCombo
    {
        private static byte id_confiteria = 0;
        private byte id;
        private List<Consumible> l_consumibles;
        private List<Combo> l_combos;

        internal Publisher_Comprar publisher_comprar;
        internal Publisher_Ascenso publisher_ascenso;
        internal void EventHandler() { }

        public Confiteria()
        {
            id = id_confiteria++;
            l_consumibles = new List<Consumible>();
            l_combos = new List<Combo>();
        }

        public byte Id { get => id; }
        public List<Combo> L_combos { get => l_combos; }

        public virtual string ObtenerTipoVenta()
        {
            return GetType().Name;
        }

        // ─── IVentaCombo ──────────────────────────────────────────────────────
        // FIX: firma actualizada con Espectador + índice de combo
        Combo IVentaCombo.Vender(Espectador cliente, byte numero_combo)
        {
            if (numero_combo >= l_combos.Count)
                throw new Exception($"El combo {numero_combo} no existe en el catalogo.");

            return l_combos[numero_combo];
        }

        Combo IVentaCombo.Vender(Espectador cliente, byte numero_combo, double descuento)
        {
            if (numero_combo >= l_combos.Count)
                throw new Exception($"El combo {numero_combo} no existe en el catalogo.");

            var original = l_combos[numero_combo];
            int valorDescontado = (int)(original.Valor * (1.0 - descuento));

            // Retorna copia del combo con precio descontado
            return new Combo(original.Descricion, valorDescontado, original.L_consumibles);
        }

        // ─── IVentaConsumible ─────────────────────────────────────────────────
        // FIX: Consumible no tiene Valor → usar TipoConsumible.Valor
        ITipoConsumible IVentaConsumible.Vender(int dinero)
        {
            var consumible = l_consumibles
                .FirstOrDefault(c => c.TipoConsumible.Valor <= dinero);

            return consumible?.TipoConsumible
                   ?? throw new Exception("No hay consumibles disponibles para ese presupuesto.");
        }

        ITipoConsumible IVentaConsumible.Vender(int dinero, double descuento)
        {
            int presupuesto = (int)(dinero / (1.0 - descuento));
            var consumible = l_consumibles
                .FirstOrDefault(c => c.TipoConsumible.Valor <= presupuesto);

            return consumible?.TipoConsumible
                   ?? throw new Exception("No hay consumibles con ese descuento.");
        }

        // ─── ComprarCombo ──────────────────────────────────────────────────────
        // CAMBIO: precio desde Combo.Valor (no hardcodeado), sin puntos
        public string ComprarCombo(Espectador espectador, byte numero_combo)
        {
            try
            {
                if (numero_combo >= l_combos.Count)
                    return $"El combo {numero_combo} no existe en el catalogo.";

                publisher_ascenso = new Publisher_Ascenso();
                publisher_comprar = new Publisher_Comprar();
                publisher_ascenso.evt_ascenso += EventHandler;
                publisher_comprar.evt_compra += EventHandler;

                Combo combo = l_combos[numero_combo];
                double descuento = espectador.ObtenerDescuento();
                int precioFinal = (int)(combo.Valor * (1.0 - descuento));

                // Restricciones por categoría (combos exclusivos por índice)
                if (espectador.Suscripcion is Normal && numero_combo >= 3)
                    return "Este combo es exclusivo para miembros Platino u Oro.";
                if (espectador.Suscripcion is Platino && numero_combo >= 4)
                    return "Este combo es exclusivo para miembros Oro.";

                // Disparar evento de ascenso o compra según suscripcion actual
                if (espectador.Suscripcion is Normal) return publisher_ascenso.AscensoPlatino(espectador);
                else if (espectador.Suscripcion is Platino) return publisher_ascenso.AscensoOro(espectador);
                else return publisher_comprar.Compra(espectador);
            }
            catch (Exception ex)
            {
                throw new Exception("Error en ComprarCombo: " + ex);
            }
        }
    }
}
