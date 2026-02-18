using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace b_Multiplex.Clases.Ventas
{
    public class Snack : Alimento
    {
        private string marca="Cadena";

        public Snack(long id, string descripcion, int precio) : base(id, descripcion, precio)
        {
            Marca = marca;
        }
        public string Marca { get => marca; set => marca = value; }
    }
}
