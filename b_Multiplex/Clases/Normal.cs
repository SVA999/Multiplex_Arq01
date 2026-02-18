using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using b_Multiplex.Interfaces;

namespace b_Multiplex.Clases
{
    public abstract class Normal : ISuscripcion, IBeneficios
    {

        private IBeneficios l_beneficios;



        public bool puede_ascender(Espectador espectador)
        {
            return true;
        }


        public bool puede_descender(Espectador espectador)
        {
            return false;
        }


        public string suscribir()
        {
            return "Estimado usuario, se ha suscrito a la membresía Normal. Disfrute de nuestros servicios.";
        }

        public double calcular_descuento()
        {
            
        }

        public double obtener_descuento()
        {

        }


    }
}