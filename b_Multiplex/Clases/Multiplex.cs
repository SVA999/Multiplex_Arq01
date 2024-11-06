using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace b_Multiplex.Clases
{
    internal class Multiplex
    {
        public static byte numeroSala = 1; 
        private const byte numTotalSalas = 5;

        private string nombre;
        private string direccion;
        List<Sala> l_salas;

        public Multiplex(string nombre, string direccion)
        {
            Nombre = nombre;
            Direccion = direccion;

            l_salas = Enumerable.Range(0, numTotalSalas).Select(_ => new Sala()).ToList();
        }

        public string Nombre { get => nombre; 
            set
            {
                if (!string.IsNullOrEmpty(value) || !string.IsNullOrWhiteSpace(value)) 
                    nombre = value;
                else throw new Exception("Nombre nulo o vacio");
            } 
        }
        public string Direccion { get => direccion; 
            set
            {
                if (!string.IsNullOrEmpty(value) || !string.IsNullOrWhiteSpace(value))
                    direccion = value;
                else throw new Exception("Direccion nula o vacia");
            }
        }
        internal List<Sala> L_salas { get => l_salas;
            set
            {
                if (l_salas.Count() > numTotalSalas)
                    throw new Exception("Numero maximo de salas ");
                else l_salas = value;
            }
        }
    }
}
