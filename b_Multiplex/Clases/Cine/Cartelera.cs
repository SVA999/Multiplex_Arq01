using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace b_Multiplex.Clases.Cine
{
    public class Cartelera
    {
        private Pelicula l_peliculas;

        public Cartelera(Pelicula l_peliculas)
        {
            L_peliculas = l_peliculas;
        }

        public Pelicula L_peliculas { get => l_peliculas; set => l_peliculas = value; }


        //Metodo para manejar el evento
        internal void EventHandler() { }
    }
}
