using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace b_Multiplex.Clases
{
    internal class Taquillero
    {
        private long id;
        private string nombre;
        private int telefono;

        public Taquillero(long id, string nombre, int telefono)
        {
            Id = id;
            Nombre = nombre;
            Telefono = telefono;
        }

        protected long Id { get => id;
            set => id = value < 1000000 ? value : throw new Exception("Id invalido");
        }
        protected string Nombre{ get => nombre;
            set
            {
                if (!string.IsNullOrEmpty(value) || !string.IsNullOrWhiteSpace(value))
                    nombre = value;
                else throw new Exception("Nombre nulo o vacio");
            }
        }
        protected int Telefono { get => telefono;
            set => telefono = value < 1000000000 ? value : throw new Exception("Telefono invalido");
        }
    }
}
