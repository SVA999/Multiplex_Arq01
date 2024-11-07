using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace b_Multiplex.Clases
{
    internal class Oro : Espectador
    {
        private const float descuento = 0.20f;
        public Oro(long id, string nombre, byte edad, long telefono) : base(id, nombre, edad, telefono)
        {
        }
    }
}
