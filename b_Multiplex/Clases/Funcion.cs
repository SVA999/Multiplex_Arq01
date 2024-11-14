    using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace b_Multiplex.Clases
{
    public class Funcion
    {
        private static int numCodigo=1;

        private string codigo;
        private DateTime hora;
        private Sala sala;
        private Pelicula pelicula;
        List<Espectador> l_espectadores;

        public Funcion()
        {

        }

        public Funcion(DateTime hora, Sala sala, Pelicula pelicula)
        {
            //Asignar codigo consecutivo a la funcion
            codigo = $"000{numCodigo}";
            numCodigo++;

            Hora = hora;
            Sala = sala;
            Pelicula = pelicula;
            l_espectadores = new List<Espectador>();
        }

        public string Codigo { get => codigo;}
        public DateTime Hora { get => hora; set => hora = value; }
        public Sala Sala { get => sala; set => sala = value; }
        public Pelicula Pelicula { get => pelicula; set => pelicula = value; }
        public List<Espectador> L_espectadores { get => l_espectadores; set => l_espectadores = value; }
    }
}
