using b_Multiplex.Clases;
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
        Combo Vender(Espectador cliente, byte numero_combo);
        Combo Vender(Espectador cliente, byte numero_combo, double descuento);

    }
}
