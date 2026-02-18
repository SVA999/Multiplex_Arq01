using b_Multiplex.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace b_Multiplex.Clases.Cine
{
    public class Pelicula
    {
        public int Id { get; set; }
        public int peliculaIncremental = 1;

        private string nombre;
        private TimeSpan duracion;
        private IClasificacionPelicula clasificacion;
        private bool estado;
        private IGenero l_genero;

        public Pelicula(string nombre, TimeSpan duracion, IClasificacionPelicula clasificacion, bool estado, IGenero l_genero)
        {
            Id = peliculaIncremental;
            peliculaIncremental++;

            Nombre = nombre;
            Duracion = duracion;
            Clasificacion = clasificacion;
            Estado = estado;
            L_genero = l_genero;
        }

        public string Nombre { get => nombre;
            set
            {
                if (!string.IsNullOrEmpty(value) || !string.IsNullOrWhiteSpace(value))
                    nombre = value;
                else throw new Exception("Nombre nulo o vacio");
            }
        }

        public TimeSpan Duracion { get => duracion; set => duracion = value; }
        internal IClasificacionPelicula Clasificacion { get => clasificacion; set => clasificacion = value; }
        public bool Estado { get => estado; set => estado = value; }
        internal IGenero L_genero { get => l_genero; set => l_genero = value; }
    }
}
