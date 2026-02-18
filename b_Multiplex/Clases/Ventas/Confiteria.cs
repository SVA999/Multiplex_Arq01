using b_Multiplex.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace b_Multiplex.Clases.Ventas
{
    internal class Confiteria : IVentaConsumible, IVentaCombo
    {
        private static byte id_confiteria = 1;
        private byte id;
        private List<Consumible> l_consumibles;
        private List<Combo> l_combos;


        public virtual string ObtenerTipoVenta()
        {
            return GetType().Name;
        }

        Combo IVentaCombo.Vender(int dinero)
        {
            throw new NotImplementedException();
        }

        Combo IVentaCombo.Vender(int dinero, double descuento)
        {
            throw new NotImplementedException();
        }

        ITipoConsumible IVentaConsumible.Vender(int dinero)
        {
            throw new NotImplementedException();
        }

        ITipoConsumible IVentaConsumible.Vender(int dinero, double descuento)
        {
            throw new NotImplementedException();
        }
    }
}
