using b_Multiplex.Clases;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace b_Multiplex.Interfaces
{
    internal interface IVentaConsumible : ITipoVenta
    {
        ITipoConsumible Vender(int dinero);
        ITipoConsumible Vender(int dinero, double descuento);
    }
}
