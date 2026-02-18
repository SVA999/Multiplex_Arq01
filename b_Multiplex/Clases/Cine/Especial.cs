using b_Multiplex.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace b_Multiplex.Clases.Cine
{
    public class Especial : ISilla
    {
        private string fila;
        private byte numero;
        private int valor;
        private IEstado estado;

        public Especial(string fila, byte numero, int valor, IEstado estado)
        {
            Fila = fila;
            Numero = numero;
            Valor = valor;
            Estado = estado;
        }

        public string Fila { get => fila; set => fila = value; }
        public byte Numero { get => numero; set => numero = value; }
        public int Valor { get => valor; set => valor = value; }
        internal IEstado Estado { get => estado; set => estado = value; }

        public string ObtenerTipoSilla()
        {
            return GetType().Name;
        }
    }
}
