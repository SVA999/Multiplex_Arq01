using b_Multiplex.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace b_Multiplex.Clases.Ventas
{
    internal class Accesorio : ITipoConsumible       
    {
        private string descripcion;
        private int precio;

        public Accesorio(string descripcion, int precio)
        {
            Descripcion = descripcion;
            Precio = precio;
        }
        public string Descripcion { get => descripcion; set => descripcion = value; }
        public int Precio { get => precio; set => precio = value; }

        public virtual string ObtenerTipoConsumible()
        {
            return GetType().Name;
        }

        
    }
}
