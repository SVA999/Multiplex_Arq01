using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace b_Multiplex.Clases
{
    public class Pelicula
    {
        public int Id { get; set; }
        private string nombre;
        private TimeSpan duracion;
        private byte edadMinima;
        private string genero;
        public Pelicula(string nombre, TimeSpan duracion, byte edadMinima, string genero)
        {
            Nombre = nombre;
            Duracion = duracion;
            EdadMinima = edadMinima;
            Genero = genero;
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
        public byte EdadMinima { get => edadMinima; set => edadMinima = value; }
        public string Genero { get => genero; set => genero = value; }
    }
}
