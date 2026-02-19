using b_Multiplex.Clases;
using b_Multiplex.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace b_Multiplex.Eventos
{
    internal class Publisher_Ascenso : IAscenso
    {
        internal delegate void delegado_ascenso();
        internal event delegado_ascenso evt_ascenso;

        internal Publisher_Comprar publisher_comprar;
        internal void EventHandler() { }

        const byte puntosPlatino = Multiplex.puntosPlatino;
        const byte puntosOro = Multiplex.puntosOro;

        public string AscensoPlatino(Espectador cliente)
        {
            try
            {
                if (evt_ascenso == null) return "Llamada al evento AscensoPlatino no valida";

                evt_ascenso();
                publisher_comprar = new Publisher_Comprar();
                publisher_comprar.evt_compra += EventHandler;

                // CAMBIO: cliente.Suscripcion is Normal (ya no "cliente is Normal")
                if (cliente.Suscripcion is Normal)
                {
                    // CAMBIO: Ascender() solo cambia la suscripcion inyectada
                    // Ya no se crea un nuevo objeto Espectador ni se borra de la lista
                    cliente.Ascender();
                    string msg = $"Puntos por Combo, {publisher_comprar.Compra(cliente)}\n\n";
                    msg += $"FELICIDADES!! has sido ascendido a cliente Platino. {publisher_comprar.Compra(cliente)}";
                    return msg;
                }
                return $"{publisher_comprar.Compra(cliente)}, " +
                       $"Te faltan puntos para llegar a Platino";
            }
            catch (Exception ex)
            {
                throw new Exception("Error en AscensoPlatino: " + ex);
            }
        }

        public string AscensoOro(Espectador cliente)
        {
            try
            {
                if (evt_ascenso == null) return "Llamada al evento AscensoOro no valida";

                evt_ascenso();
                publisher_comprar = new Publisher_Comprar();
                publisher_comprar.evt_compra += EventHandler;

                // CAMBIO: cliente.Suscripcion is Platino (ya no "cliente is Platino")
                if (cliente.Suscripcion is Platino)
                {
                    cliente.Ascender();
                    string msg = $"Puntos por Combo, {publisher_comprar.Compra(cliente)}\n\n";
                    msg += $"FELICIDADES!! has sido ascendido a cliente Oro. {publisher_comprar.Compra(cliente)}";
                    return msg;
                }
                return $"{publisher_comprar.Compra(cliente)}, " +
                       $"Te faltan puntos para llegar a Oro";
            }
            catch (Exception ex)
            {
                throw new Exception("Error en AscensoOro: " + ex);
            }
        }
    }
}