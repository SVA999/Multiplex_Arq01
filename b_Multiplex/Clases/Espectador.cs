using b_Multiplex.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace b_Multiplex.Clases
{
    internal class Espectador : IAscenso 
    {
        private long id;
        private string nombre;
        private byte edad;
        private int telefono;

        public Espectador(long id, string nombre, byte edad, int telefono)
        {
            Id = id;
            Nombre = nombre;
            Edad = edad;
            Telefono = telefono;
        }

        public byte Edad { get => edad; 
            set => edad = value < 0 ? value : throw new Exception("Id invalido"); }
        
        protected long Id { get => id; 
            set => id = value < 1000000 ? value : throw new Exception("Id invalido");
        }
        protected string Nombre { get => nombre;
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


        //Metodo Interfaz
        public void Asender()
        {
            //throw new NotImplementedException();
        }
    }
}
