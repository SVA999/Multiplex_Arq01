using b_Multiplex.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace b_Multiplex.Clases.Ventas
{
    public class Venta : ITipoVenta
    {
        private ITipoVenta tipoVenta;
        private DateTime fecha;
        private int valor;
        private Espectador comprador;

        public Venta(ITipoVenta tipoVenta, int valor, Espectador comprador)
        {
            TipoVenta = tipoVenta;
            Fecha = DateTime.Now;
            Valor = valor;
            Comprador = comprador;
        }

        public ITipoVenta TipoVenta { get => tipoVenta; set => tipoVenta = value; }
        public DateTime Fecha { get => fecha; set => fecha = value; }
        public int Valor { get => valor; set => valor = value; }
        public Espectador Comprador { get => comprador; set => comprador = value; }

        public virtual string ObtenerTipoVenta()
        {
            return GetType().Name;
        }

    }
}
