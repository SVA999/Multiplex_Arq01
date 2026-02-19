using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using b_Multiplex.Interfaces;

namespace b_Multiplex.Clases
{
    public class Oro : ISuscripcion
    {
        private List<IBeneficios> l_beneficios;

        public Oro()
        {
            l_beneficios = new List<IBeneficios>();
        }

        public List<IBeneficios> L_beneficios { get => l_beneficios; set => l_beneficios = value; }

        public bool puede_ascender()
        {
            return false;
        }

        public bool puede_descender()
        {
            return true;
        }

        public string suscribir()
        {
            return "Estimado usuario, se ha suscrito a la membresía Oro. Disfrute de nuestros servicios y beneficios exclusivos para este plan.";
        }

        // 10% base; extensible mediante IBeneficios en la lista
        public double obtener_descuento()
        {
            if (l_beneficios.Count > 0)
            {
                double total = 0;
                foreach (var b in l_beneficios)
                    total += b.obtener_beneficio();
                return total;
            }
            return 0.10;
        }
    }
}
