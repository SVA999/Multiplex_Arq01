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
    public class Espectador 
    {
        private long id;
        private string nombre;
        private byte edad;
		private long telefono;
        private string correo;
        private ISuscripcion suscripcion;

        //Atributo Publisher
        internal Publisher_Ascenso publisher_ascenso;
        internal Publisher_Comprar publisher_comprar;

        //Metodo para manejar el evento
        //internal void EventHandler() { }

        public Espectador(long id, string nombre, byte edad, long telefono, ISuscripcion suscripcion)
        {
            Id = id;
            Nombre = nombre;
            Edad = edad;
            Telefono = telefono;
            Suscripcion = suscripcion;
        }


        public long Id { get => id; 
            set => id = value > 10000000 && value < 100000000 ? value : throw new Exception("Id invalido, debe tener 8 digitos");
        }

        public string Nombre { get => nombre;
            set
            {
                if (!string.IsNullOrEmpty(value) || !string.IsNullOrWhiteSpace(value))
                    nombre = value;
                else throw new Exception("Nombre nulo o vacio");
            }
        }
        public byte Edad
        {
            get => edad;
            set => edad = value > 0 ? value : throw new Exception("Edad invalida");
        }

        public long Telefono { get => telefono; 
            set => telefono = value > 1000000000 && value < 10000000000 ? value : throw new Exception("Telefono invalido, debe tener 10 digitos"); 
        }

        public string Categoria
        {
            get
            {
                if (suscripcion is Normal) return "Normal";
                if (suscripcion is Platino) return "Platino";
                if (suscripcion is Oro) return "Oro";
                return "Sin categoría";
            }
        }


        public ISuscripcion Suscripcion
        {
            get => suscripcion;
            set => suscripcion = value ?? throw new ArgumentNullException(nameof(value));
        }

        // Delegado al tipo de suscripcion actual — usado por Confiteria
        public double ObtenerDescuento()
        {
            if (suscripcion is Normal n) return n.obtener_descuento();
            if (suscripcion is Platino p) return p.obtener_descuento();
            if (suscripcion is Oro o) return o.obtener_descuento();
            return 0.0;
        }

        // ASCENSO: simplificado — solo cambia la suscripcion inyectada
        public void Ascender()
        {
            if (suscripcion is Normal && suscripcion.puede_ascender())
                Suscripcion = new Platino();
            else if (suscripcion is Platino && suscripcion.puede_ascender())
                Suscripcion = new Oro();
        }


    }
}

