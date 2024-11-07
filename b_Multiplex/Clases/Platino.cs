using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace b_Multiplex.Clases
{
    internal class Platino : Espectador
    {
        private const float descuento =0.10f;
        public Platino(long id, string nombre, byte edad, long telefono) : base(id, nombre, edad, telefono)
        {
        }
    }
}
