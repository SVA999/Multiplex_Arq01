using b_Multiplex.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace b_Multiplex.Clases.Ventas
{
    internal class Coleccionable : ITipoConsumible
    {
        private string descripcion;
        private int precio;
        private string coleccion = "Coleccionable";

        public Coleccionable(string descripcion, int precio)
        {
            Descripcion = descripcion;
            Precio = precio;
            Coleccion = coleccion;
        }

        public string Descripcion { get => descripcion; set => descripcion = value; }
        public int Precio { get => precio; set => precio = value; }
        public string Coleccion { get => coleccion; set => coleccion = value; }

        public int Valor { get => precio; }

        public virtual string ObtenerTipoConsumible()
        {
            return GetType().Name;
        }
    }
}
