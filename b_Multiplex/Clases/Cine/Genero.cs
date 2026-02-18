using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using b_Multiplex.Interfaces;

namespace b_Multiplex.Clases.Cine
{
    public class Genero : IGenero
    {
        private string descripcion;
        private string advertencia;

        public Genero(string descripcion, string advertencia)
        {
            Descripcion = descripcion;
            Advertencia = advertencia;
        }

        public string Descripcion { get => descripcion; set => descripcion = value; }
        public string Advertencia { get => advertencia; set => advertencia = value; }

        public string ObtenerAdvertenciaContenido()
        {
            return Advertencia;
        }

        public string ObtenerGenero()
        {
            return Descripcion;
        }
    }
}
