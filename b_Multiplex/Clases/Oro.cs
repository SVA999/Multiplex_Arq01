using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace b_Multiplex.Clases
{
    public class Oro : Espectador
    {
        
        public Oro(long id, string nombre, byte edad, long telefono) : base(id, nombre, edad, telefono)
        {
            Descuento = descuentoOro;
        }

    }
}
