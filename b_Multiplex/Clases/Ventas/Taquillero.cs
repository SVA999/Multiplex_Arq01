using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using b_Multiplex.Eventos;

namespace b_Multiplex.Clases.Ventas
{
    public class Taquillero
    {

        public long Id { get; set; }
        private string nombre;
        private long telefono;
        private const float descuento = 0;

        //Atributo Publisher Compra
        internal Publisher_Comprar publisher_comprar;

        internal void EventHandler() { }

        public Taquillero(string nombre, long telefono)
        {
            Id = Multiplex.contTaquilleros;
            Multiplex.contTaquilleros++;

            Nombre = nombre;
            Telefono = telefono;
        }

        public string Nombre{ get => nombre;
            set
            {
                if (!string.IsNullOrEmpty(value) || !string.IsNullOrWhiteSpace(value))
                    nombre = value;
                else 
                    throw new Exception("Nombre nulo o vacio");
            }
        }
        public long Telefono { get => telefono; 
            set => telefono = value > 1000000000 && value < 10000000000 ? value : throw new Exception("Telefono invalido, debe tener 10 digitos");
        }

        public string VenderBoleta(Funcion funcion, Espectador espectador, bool vip)
        {
            try
            {
                string sReturn = "";

                //EVENTO COMPRA
                publisher_comprar = new Publisher_Comprar();

                //Suscribirme al evento
                publisher_comprar.evt_compra += EventHandler;

                int precio = vip ? Multiplex.valorSillaVip : Multiplex.valorSillaGeneral;

                var sillaDisponible = funcion.Sala.Sillas.OfType<Silla>().Where(s => (vip && s is Vip || !vip && s is General) && !s.Ocupada)
                                                     .FirstOrDefault();

                if (sillaDisponible != null)
                {
                    sillaDisponible.Ocupada = true;

                    sReturn += publisher_comprar.Compra(espectador);
                    sReturn += $"\n\nSeñor/a {espectador.Nombre}, su silla en la sala {funcion.SalaId}, para la función {funcion.Codigo} con fecha {funcion.Hora}, que presenta la pelicula {funcion.Pelicula.Nombre} es: {sillaDisponible.Posicion}.";
                    return sReturn;
                }
                else
                {
                    return $"Lo siento, {espectador.Nombre}. No hay sillas {(vip ? "VIP" : "Generales")} disponibles para esta función.";
                }
            }
            catch (Exception e)
            {

                throw new Exception("Exception: " + e);
            }
        }

        public string VenderBoleta(Funcion funcion, Espectador espectador, string ubicacion, bool vip)
        {
            try
            {
                string sReturn = "";

                int precio = vip ? Multiplex.valorSillaVip : Multiplex.valorSillaGeneral;

                ubicacion.ToUpper();

                int fila = ubicacion[0] - 'A'; // Convierte 'A' en 0, 'B' en 1, etc.
                int columna = int.Parse(ubicacion.Substring(1)) - 1; // Convierte la parte numérica y ajusta a índice 0

                // Validar que la fila y columna estén dentro del rango de la matriz
                if (fila < 0 || fila >= funcion.Sala.Sillas.GetLength(0) || columna < 0 || columna >= funcion.Sala.Sillas.GetLength(1))
                {
                    return $"La ubicación {ubicacion} está fuera del rango de asientos.";
                }

                // Obtener la silla de la matriz
                var silla = funcion.Sala.Sillas[fila, columna];

                // Verificar el tipo de silla (VIP o General) y disponibilidad
                if ((vip && silla is Vip || !vip && silla is General) && !silla.Ocupada)
                {
                    // Marcar la silla como ocupada
                    silla.Ocupada = true;

                    sReturn += publisher_comprar.Compra(espectador);
                    sReturn += $"\n\nSeñor/a {espectador.Nombre}, su silla en la sala {funcion.SalaId}, para la función {funcion.Codigo} con fecha {funcion.Hora}, que presenta la pelicula {funcion.Pelicula.Nombre} es: {ubicacion}.";


                    return sReturn;
                }
                else if (silla.Ocupada)
                {
                    return $"Lo siento, {espectador.Nombre}. La silla {ubicacion} ya está ocupada.";
                }
                else
                {
                    return $"Lo siento, {espectador.Nombre}. La silla {ubicacion} no corresponde al tipo {(vip ? "VIP" : "General")}.";
                }
            }
            catch
            {
                return $"La ubicación {ubicacion} no es válida. Use el formato correcto, por ejemplo, 'A1' o 'B3'.";
            }
        }


    }
}
