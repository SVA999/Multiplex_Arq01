using b_Multiplex.Clases.Ventas;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace b_Multiplex.Interfaces
{
    internal interface IVentaCombo
    {
        Combo Vender(int dinero);
        Combo Vender(int dinero, double descuento);

    }
}
