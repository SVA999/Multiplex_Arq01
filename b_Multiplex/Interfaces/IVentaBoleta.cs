using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using b_Multiplex.Clases.Ventas;

namespace b_Multiplex.Interfaces
{
    internal interface IVentaBoleta : ITipoVenta
    {
        Boleta Vender(int dinero);
        Boleta Vender(int dinero, double descuento);
    }
}
