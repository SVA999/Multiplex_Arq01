using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace b_Multiplex.Clases
{
    internal class Normal : Espectador
    {
        private const float descuento = 0;

        public Normal(long id, string nombre, byte edad, int telefono) : base(id, nombre, edad, telefono)
        {
        }
    }
}
