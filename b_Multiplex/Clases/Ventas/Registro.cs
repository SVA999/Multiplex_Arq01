using b_Multiplex.Interfaces;
using b_Multiplex.Clases.Ventas;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace b_Multiplex.Clases.Ventas
{
    public class Registro
    {
        private List<Venta> l_ventas;

        public Registro()
        {
            L_ventas = new List<Venta>();
        }

        public List<Venta> L_ventas { get => l_ventas; set => l_ventas = value; }


        public List<Boleta> ObtenerVentaBoletas()
        {
            throw new NotImplementedException();
            //return L_ventas.SelectMany(v => v.GetType().Name.Equals("Boleta")).ToList();
        }
    }
}
