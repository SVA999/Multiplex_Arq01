using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace b_Multiplex.Clases
{
    public class Normal : Espectador
    {
        private const float descuento = 1;

        public Normal(long id, string nombre, byte edad, long telefono) : base(id, nombre, edad, telefono)
        {
        }

        public static float Descuento => descuento;
    }
}
