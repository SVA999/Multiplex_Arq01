using b_Multiplex.Clases.Cine;
using b_Multiplex.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace b_Multiplex.Clases.Ventas
{
    internal class Boleteria : IVentaBoleta
    {
        static byte id_boleteria = 1;

        private byte id;
        private List<Funcion> l_funciones;
        private delegate double delegadoDescuentos();

        public Boleteria()
        {
            Id = id_boleteria;
            id_boleteria++;

            l_funciones = new List<Funcion>();
        }

        //Accesores

        public List<Funcion> L_funciones { get => l_funciones; set => l_funciones = value; }
        public byte Id { get => id; set => id = value; }

        public string ObtenerTipoVenta()
        {
            if (this is IVentaBoleta)
                return "Venta de Boleta";
            else
                return "Tipo de venta desconocida";
        }

        public Boleta Vender(int dinero)
        {
            throw new NotImplementedException();
        }

        public Boleta Vender(int dinero, double descuento)
        {
            throw new NotImplementedException();
        }
    }
}
