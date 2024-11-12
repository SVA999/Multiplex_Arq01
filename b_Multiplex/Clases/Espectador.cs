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

        public void Combo(byte tipoccombo, int dinero)
        {
            int precio;
            int devuelta;
            float descuento = 1;
            byte puntos;

            if (this is Normal)
                descuento = 1;
            else if (this is Oro)
                descuento = 0.8f;
            else if (this is Platino)
                descuento = 0.9f;

            switch (tipoccombo)
            {
                case 1:
                    precio = 25000;
                    break;
                case 2:
                    precio = 30000;
                    break;
                case 3:
                    precio = 40000;
                    break;
                case 4:
                    if (this is Platino || this is Oro)
                        precio = 50000;
                    else
                        throw new ArgumentException("El combo 4 solo está disponible para clientes Platino y Oro.");
                    break;
                case 5:
                    if (this is Oro)
                        precio = 60000;
                    else
                        throw new ArgumentException("El combo 5 solo está disponible para clientes Oro.");
                    break;
                default:
                    throw new ArgumentException("Número de combo inválido.");
            }

            if (this is Normal)
            {
                puntos = (byte)(precio / 10000);
            }
            else if (this is Platino)
            {
                puntos = (byte)(precio / 5000);
            }
            else if (this is Oro)
            {
                puntos = (byte)(precio / 2000);
            }

            devuelta = (int)(dinero - precio * descuento);
        }
    }
}
