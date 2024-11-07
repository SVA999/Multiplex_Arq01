using b_Multiplex.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace b_Multiplex.Clases
{
    internal abstract class Espectador : I_Combo
    {
        protected long id;
        protected string nombre;
        protected byte edad;
        protected long telefono;
        protected short puntos;

        public Espectador(long id, string nombre, byte edad, long telefono)
        {
            Id = id;
            Nombre = nombre;
            Edad = edad;
            Telefono = telefono;
            puntos=0;

        }

        internal byte Edad { get => edad; 
            set => edad = value < 0 ? value : throw new Exception("Edad invalida"); }

        internal long Id { get => id; 
            set => id = value < 1000000 && value > 10000000 ? value : throw new Exception("Id invalido");
        }
        internal string Nombre { get => nombre;
            set
            {
                if (!string.IsNullOrEmpty(value) || !string.IsNullOrWhiteSpace(value))
                    nombre = value;
                else throw new Exception("Nombre nulo o vacio");
            }
        }
        internal long Telefono { get => telefono; 
            set => telefono = value < 1000000000 && value > 10000000000 ? value : throw new Exception("Telefono invalido"); 
        }
        internal short Puntos { get => puntos; set => puntos = value; }
    }
}
