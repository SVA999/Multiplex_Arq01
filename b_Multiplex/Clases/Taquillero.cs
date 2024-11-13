using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace b_Multiplex.Clases
{
    public class Taquillero
    {
        private long id;
        private string nombre;
        private long telefono;
        private const float descuento = 0;

        public Taquillero(long id, string nombre, long telefono)
        {
            Id = id;
            Nombre = nombre;
            Telefono = telefono;
        }

        public long Id { get => id;
            set => id = value < 1000000 && value > 10000000 ? value : throw new Exception("Id invalido");
        }
        public string Nombre{ get => nombre;
            set
            {
                if (!string.IsNullOrEmpty(value) || !string.IsNullOrWhiteSpace(value))
                    nombre = value;
                else 
                    throw new Exception("Nombre nulo o vacio");
            }
        }
        public long Telefono { get => telefono;
            set => telefono = value < 1000000000 && value > 10000000000 ? value : throw new Exception("Telefono invalido");
        }
    }
}
