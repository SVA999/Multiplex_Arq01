using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace b_Multiplex.Clases
{
    public class Platino : Espectador
    {
        public Platino(long id, string nombre, byte edad, long telefono) : base(id, nombre, edad, telefono)
        {
            Descuento = descuentoPlatino;
        }
        
    }
}
