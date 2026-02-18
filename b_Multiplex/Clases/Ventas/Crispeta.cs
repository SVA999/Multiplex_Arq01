using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace b_Multiplex.Clases.Ventas
{
    public class Crispeta : Alimento
    {
        private l_tamano tamano;
        public Crispeta(long id, string descripcion, int precio, l_tamano tamano) : base(id, descripcion, precio)
        {
            Tamano = tamano;
        }

        public l_tamano Tamano { get => tamano; set => tamano = value; }

        public override string ObtenerTipoConsumible()
        {
            return $"{GetType().Name} ({Tamano})";
        }
    }
}
