using b_Multiplex.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace b_Multiplex.Clases.Ventas
{
    public abstract class Alimento : ITipoConsumible
    {
        public enum l_tamano
        {
            Pequeño,
            Mediano,
            Grande,
            ExtraGrande
        }

        protected long id;
        protected string descripcion;
        protected int precio;

        public Alimento(long id, string descripcion, int precio)
        {
            Id = id;
            Descripcion = descripcion;
            Precio = precio;

        }
        public long Id { get => id; set => id = value; }
        public string Descripcion { get => descripcion; set => descripcion = value; }
        public int Precio { get => precio; set => precio = value; }

        public int Valor { get => precio; }

        public virtual string ObtenerTipoConsumible()
        {
            return GetType().Name;
        }
    }
}
