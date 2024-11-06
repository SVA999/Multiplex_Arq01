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
        private byte puntos = 0;
        public Oro(long id, string nombre, byte edad, int telefono) : base(id, nombre, edad, telefono)
        {
        }
    }
}
