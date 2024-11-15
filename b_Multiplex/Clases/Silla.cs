using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace b_Multiplex.Clases
{
    public abstract class Silla
    {
        public int Id { get; set; }

        private string posicion;
        private int valor;
        private bool ocupada;

        public Silla(string posicion)
        {
            Posicion = posicion;
            ocupada = false;
        }

        public string Posicion { get => posicion; set => posicion = value; }
        public int Valor { get => valor; set => valor = value; }
        public bool Ocupada { get => ocupada; set => ocupada = value; }
    }
}
