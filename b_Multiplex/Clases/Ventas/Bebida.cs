using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace b_Multiplex.Clases.Ventas
{
    internal class Bebida : Alimento
    {
        private l_tamano tamano;
        private string marca;
        public Bebida(long id, string descripcion, int precio, l_tamano tamano, string marca) : base(id, descripcion, precio)
        {
            Tamano = tamano;
            Marca = marca;
        }

        public l_tamano Tamano { get => tamano; set => tamano = value; }
        public string Marca { get => marca; set => marca = value; }

        public override string ObtenerTipoConsumible()
        {
            return $"{GetType().Name} ({Tamano})";
        }
    }
}
