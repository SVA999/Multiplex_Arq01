using b_Multiplex.Clases.Cine;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace b_Multiplex.Clases.Ventas
{
    public class Boleta
    {
        private long id;
        private Espectador espectador;
        private Funcion funcion;
        private Silla silla;
        private int valor;

        public Boleta(long id, Espectador espectador, Funcion funcion, Silla silla, int valor)
        {
            Id = id;
            Espectador = espectador;
            Funcion = funcion;
            Silla = silla;
            Valor = valor;
        }

        public long Id { get => id; set => id = value; }
        public Espectador Espectador { get => espectador; set => espectador = value; }
        public Funcion Funcion { get => funcion; set => funcion = value; }
        public Silla Silla { get => silla; set => silla = value; }
        public int Valor { get => valor; set => valor = value; }

        public string ObtenerInfo()
        {
            return $"Boleta ID: {Id}\nEspectador: {Espectador.Nombre}\nFuncion: {Funcion.Codigo} - {Funcion.Pelicula.Nombre}\nSilla: {Silla.Posicion}\nValor: ${Valor}";
        }
    }
}
