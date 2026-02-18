using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using b_Multiplex.Interfaces;

namespace b_Multiplex.Clases
{
    public class Platino : ISuscripcion, IBeneficios
    {

        private IBeneficios l_beneficios;



        public bool puede_ascender(Espectador espectador)
        {
            return true;
        }


        public bool puede_descender(Espectador espectador)
        {
            return true;
        }


        public string suscribir()
        {
            return "Estimado usuario, se ha suscrito a la membresía Platino. Disfrute de nuestros servicios y beneficios exclusivos para este plan.";
        }

        public double calcular_descuento()
        {

        }

        public double obtener_descuento()
        {

        }

    }
}
