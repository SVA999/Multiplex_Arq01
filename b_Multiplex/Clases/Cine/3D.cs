using b_Multiplex.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace b_Multiplex.Clases.Cine
{
    internal class _3D : ITipoSala
    {
        private byte id;
        private string descripcion;
        private int valor;

        public _3D(byte id, string descripcion)
        {
            Id = id;
            Descripcion = descripcion;
        }

        public byte Id { get => id; set => id = value; }
        public string Descripcion { get => descripcion; set => descripcion = value; }
        public int Valor { get => valor; set => valor = value; }

        public string ObtenerTipoSala()
        {
            return GetType().Name;
        }
    }
}
