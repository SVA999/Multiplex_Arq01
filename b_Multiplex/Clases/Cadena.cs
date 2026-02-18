using b_Multiplex.Eventos;
using b_Multiplex.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;


namespace b_Multiplex.Clases
{

    public class Cadena : IServicio
    {

        private string nombre;
        private Multiplex l_multiplex;
        private IServicio l_servicios;


        // =========================
        // Constructor con inyección de dependencias
        // =========================
        public Cadena(string nombre, Multiplex multiplex, IServicio servicios)
        {

            Nombre = nombre;
            L_Multiplex = multiplex;
            L_Servicios = servicios;

        }

        public string Nombre
        {
            get => nombre;
            set => nombre = value;
        }

        public Multiplex L_Multiplex
        {
            get => l_multiplex;
            set => l_multiplex = value ?? throw new ArgumentNullException(nameof(value));
        }

        public IServicio L_Servicios
        {
            get => l_servicios;
            set => l_servicios = value ?? throw new ArgumentNullException(nameof(value));
        }

        public string ObtenerServicio()
        {
            return  GetType().Name;
        }
    }
}

