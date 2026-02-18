<<<<<<< HEAD
﻿using b_Multiplex.Eventos;
using b_Multiplex.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace b_Multiplex.Clases
{
    public abstract class Espectador 
    {
        private long id;
        private string nombre;
        private byte edad;
		private int telefono;
        private string correo;
        private ISuscripcion suscripcion;

        //Atributo Publisher
        internal Publisher_Ascenso publisher_ascenso;
        internal Publisher_Comprar publisher_comprar;

        //Metodo para manejar el evento
        internal void EventHandler() { }

        public Espectador(long id, string nombre, byte edad, long telefono, ISuscripcion suscripcion)
        {
            Id = id;
            Nombre = nombre;
            Edad = edad;
            Telefono = telefono;
            ISuscripcion = suscripcion;
            puntos=0;
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
        public short Puntos { get => puntos; set => puntos = value; }
        public string Categoria { get {
                if (this is Normal)
                    return "Normal";
                else if (this is Oro)
                    return "Oro";
                else if (this is Platino)
                    return "Platino";
                else return "Sin categoria";
            } 
        }

        public  float Descuento { get => descuento; set => descuento = value; }

        public string ComprarCombo(byte tipocombo)
        {
            try
            {
                if (tipocombo >= 1 || tipocombo <= 5)
                {
                    int precio;
                    //int devuelta;
                    float descuento = 1;

                    //Instanciar el evento
                    publisher_ascenso = new Publisher_Ascenso();
                    publisher_comprar = new Publisher_Comprar();

                    //Suscribirme al evento
                    publisher_ascenso.evt_ascenso += EventHandler;
                    publisher_comprar.evt_compra += EventHandler;


                    if (this is Normal)
                        descuento = descuentoNormal;
                    else if (this is Oro)
                        descuento = descuentoPlatino;
                    else if (this is Platino)
                        descuento = descuentoOro;

                    switch (tipocombo)
                    {
                        case 1:
                            precio = Multiplex.precioCombo1;
                            break;
                        case 2:
                            precio = Multiplex.precioCombo2;
                            break;
                        case 3:
                            precio = Multiplex.precioCombo3;
                            break;
                        case 4:
                            if (this is Platino || this is Oro)
                                precio = Multiplex.precioCombo4;
                            else
                                return ("El combo 4 solo está disponible para clientes Platino y Oro.");
                            break;
                        case 5:
                            if (this is Oro)
                                precio = Multiplex.precioCombo5;
                            else
                                return ("El combo 5 solo está disponible para clientes Oro.");
                            break;
                        default:
                            return ("Número de combo inválido.");
                    }

                    if (this is Normal)
                    {
                        Puntos += (byte)(precio / 10000);
                        //Invocar el evento
                        return publisher_ascenso.AscensoPlatino(this);

                    }
                    else if (this is Platino)
                    {
                        Puntos += (byte)(precio / 5000);
                        //Invocar el evento
                        return publisher_ascenso.AscensoOro(this);

                    }
                    else if (this is Oro)
                    {
                        Puntos += (byte)(precio / 2000);
                        return publisher_comprar.Compra(this);
                    }
                } else return "Numero de combo invalido";
                return "No se pudo realizar la compra";
            }
            catch (Exception ex)
            {
                throw new Exception("Error al ComprarCombo: " + ex);
            }

        } 
    }
}
=======
﻿using b_Multiplex.Eventos;
using b_Multiplex.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace b_Multiplex.Clases
{
    public abstract class Espectador : ICombo
    {
        protected long id;
        protected string nombre;
        protected byte edad;
		protected short puntos;
		protected long telefono;
        private float descuento;
        public const float descuentoNormal = 1;
        public const float descuentoPlatino = 0.9f;
        public const float descuentoOro = 0.80f;


        //Atributo Publisher
        internal Publisher_Ascenso publisher_ascenso;
        internal Publisher_Comprar publisher_comprar;

        //Metodo para manejar el evento
        internal void EventHandler() { }

        public Espectador(long id, string nombre, byte edad, long telefono)
        {
            Id = id;
            Nombre = nombre;
            Edad = edad;
            Telefono = telefono;
            puntos=0;
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
        public short Puntos { get => puntos; set => puntos = value; }
        public string Categoria { get {
                if (this is Normal)
                    return "Normal";
                else if (this is Oro)
                    return "Oro";
                else if (this is Platino)
                    return "Platino";
                else return "Sin categoria";
            } 
        }

        public  float Descuento { get => descuento; set => descuento = value; }

        public string ComprarCombo(byte tipocombo)
        {
            try
            {
                if (tipocombo >= 1 || tipocombo <= 5)
                {
                    int precio;
                    //int devuelta;
                    float descuento = 1;

                    //Instanciar el evento
                    publisher_ascenso = new Publisher_Ascenso();
                    publisher_comprar = new Publisher_Comprar();

                    //Suscribirme al evento
                    publisher_ascenso.evt_ascenso += EventHandler;
                    publisher_comprar.evt_compra += EventHandler;


                    if (this is Normal)
                        descuento = descuentoNormal;
                    else if (this is Oro)
                        descuento = descuentoPlatino;
                    else if (this is Platino)
                        descuento = descuentoOro;

                    switch (tipocombo)
                    {
                        case 1:
                            precio = Multiplex.precioCombo1;
                            break;
                        case 2:
                            precio = Multiplex.precioCombo2;
                            break;
                        case 3:
                            precio = Multiplex.precioCombo3;
                            break;
                        case 4:
                            if (this is Platino || this is Oro)
                                precio = Multiplex.precioCombo4;
                            else
                                return ("El combo 4 solo está disponible para clientes Platino y Oro.");
                            break;
                        case 5:
                            if (this is Oro)
                                precio = Multiplex.precioCombo5;
                            else
                                return ("El combo 5 solo está disponible para clientes Oro.");
                            break;
                        default:
                            return ("Número de combo inválido.");
                    }

                    if (this is Normal)
                    {
                        Puntos += (byte)(precio / 10000);
                        //Invocar el evento
                        return publisher_ascenso.AscensoPlatino(this);

                    }
                    else if (this is Platino)
                    {
                        Puntos += (byte)(precio / 5000);
                        //Invocar el evento
                        return publisher_ascenso.AscensoOro(this);

                    }
                    else if (this is Oro)
                    {
                        Puntos += (byte)(precio / 2000);
                        return publisher_comprar.Compra(this);
                    }
                } else return "Numero de combo invalido";
                return "No se pudo realizar la compra";
            }
            catch (Exception ex)
            {
                throw new Exception("Error al ComprarCombo: " + ex);
            }

        } 
    }
}
>>>>>>> d4106e1 (Limpieza profunda: aplicando .gitignore y eliminando archivos basura)
