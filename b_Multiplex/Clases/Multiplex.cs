using b_Multiplex.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using b_Multiplex.Clases;
using b_Multiplex.Clases.Cine;
using b_Multiplex.Clases.Ventas;

namespace b_Multiplex.Clases
{
    public class Multiplex 
    {
        //Combos
        public const int precioCombo1 = 25000;
        public const int precioCombo2 = 30000;
        public const int precioCombo3 = 40000;
        public const int precioCombo4 = 50000;
        public const int precioCombo5 = 60000;

        //Salas
        public static byte numeroSala = 1; 
        private const byte numTotalSalas = 4;
        private const byte filasSalas = 16;
        private const byte columnasSalas = 10;

        //Sillas
        public const int valorSillaVip = 15000;
        public const int valorSillaGeneral = 10000;

        //Categoria
        public const byte puntosPlatino = 100;
        public const byte puntosOro = 150;

        //Taquilleros
        public const byte totalTaquilleros = 4;
        public static byte contTaquilleros = 1;


        public int Id { get; set; }
        private string nombre;
        private string direccion;
        
        public static List<Espectador> l_espectadores = new List<Espectador>();
        private List<Funcion> l_funciones;
        private List<Sala> l_salas = new List<Sala>();
        private List<Pelicula> l_peliculas;
        private List<Pelicula> l_peliculasActivas;
        private Cartelera cartelera;
        private Registro registro;
        private string rutaArchivoClientes;
        private string rutaArchivoTaquilleros;
        private string rutaArchivoFunciones;
        private string rutaArchivoPeliculas;

        public Multiplex(string nombre, string direccion)
        {
            Nombre = nombre;
            Direccion = direccion;

            l_salas = new List<Sala>();
            L_salas = Enumerable.Range(0, numTotalSalas).Select(_ => new Sala(filasSalas,columnasSalas)).ToList();
            L_funciones = new List<Funcion>();
            L_peliculas = new List<Pelicula>();
            L_peliculasActivas = new List<Pelicula>();


            RutaArchivoClientes = "E:\\Santiago\\Programacion\\UPB\\Proyectos\\Final-Paradigmas\\FormMultiplex\\DataBases\\DBClientes.txt";
            RutaArchivoTaquilleros = "E:\\Santiago\\Programacion\\UPB\\Proyectos\\Final-Paradigmas\\FormMultiplex\\DataBases\\DBTaquilleros.txt";
            RutaArchivoFunciones = "E:\\Santiago\\Programacion\\UPB\\Proyectos\\Final-Paradigmas\\FormMultiplex\\DataBases\\DBFunciones.txt";
            RutaArchivoPeliculas = "E:\\Santiago\\Programacion\\UPB\\Proyectos\\Final-Paradigmas\\FormMultiplex\\DataBases\\DBPeliculas.txt";
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
        public List<Sala> L_salas { get => l_salas;
            set
            {
                if (l_salas.Count() > numTotalSalas)
                    throw new Exception("Numero maximo de salas ");
                else l_salas = value;
            }
        }

        public List<Funcion> L_funciones { get => l_funciones; set => l_funciones = value; }
        public List<Pelicula> L_peliculas { get => l_peliculas; set => l_peliculas = value; }
        public List<Pelicula> L_peliculasActivas { get => l_peliculasActivas; set => l_peliculasActivas = value; }

        public string RutaArchivoClientes { get => rutaArchivoClientes; set => rutaArchivoClientes = value; }
        
        public string RutaArchivoFunciones { get => rutaArchivoFunciones; set => rutaArchivoFunciones = value; }
        public string RutaArchivoPeliculas { get => rutaArchivoPeliculas; set => rutaArchivoPeliculas = value; }
        public string RutaArchivoTaquilleros { get => rutaArchivoTaquilleros; set => rutaArchivoTaquilleros = value; }
        public Cartelera Cartelera { get => cartelera; set => cartelera = value; }



        //Cliente
        /*
        public void LeerDBCliente()
        {
            try
            {
                string? line;
                StreamReader lectorbd = new StreamReader(RutaArchivoClientes, Encoding.UTF8);
                string[] particion;
                line = lectorbd.ReadLine();

                while (line != null)
                {
                    if (line != "")
                    {
                        particion = line.Split(";");
                        short puntos = short.Parse(particion[4]);

                        // CAMBIO: ISuscripcion es inyectada según puntos
                        ISuscripcion suscripcion;
                        if (puntos < puntosPlatino)
                            suscripcion = new Normal();
                        else if (puntos < puntosOro)
                            suscripcion = new Platino();
                        else
                            suscripcion = new Oro();

                        // CAMBIO: Espectador es ahora clase concreta
                        Espectador espectador = new Espectador(
                            long.Parse(particion[0]),
                            particion[1],
                            byte.Parse(particion[2]),
                            long.Parse(particion[3]),
                            suscripcion
                        );
                        l_espectadores.Add(espectador);
                    }
                    line = lectorbd.ReadLine();
                }
                lectorbd.Close();
            }
            catch (Exception e)
            {
                throw new Exception("Error: " + e.Message);
            }
        }

        public void EscibirDBCliente(Espectador espectador)
		{
			try
			{
				StreamWriter escritorbd = new StreamWriter(RutaArchivoClientes, true, Encoding.UTF8);

				escritorbd.Write($"{espectador.Id};{espectador.Nombre};{espectador.Edad};{espectador.Telefono}\n");
				
				escritorbd.Close();
			}
			catch (Exception e)
			{
				throw new Exception("Error: " + e.Message);
			}
		}

        public void LeerDBPeliculas()
        {
            try
            {
                string? line;
                StreamReader lectorbd = new StreamReader(RutaArchivoPeliculas, Encoding.UTF8);
                string[] particion;
                line = lectorbd.ReadLine();

                while (line != null)
                {
                    if (line != "")
                    {
                        particion = line.Split(";");

                        TimeSpan duracion = TimeSpan.Parse(particion[2]);
                        bool estado = bool.Parse(particion[3]);

                        // FIX: Pelicula requiere IClasificacionPelicula y IGenero
                        // Ajusta los constructores de Clasificacion/Genero cuando los veas
                        IClasificacionPelicula clasificacion = new Clasificacion(particion[4]);
                        IGenero genero = new Genero(particion[5]);

                        Pelicula pelicula = new Pelicula(particion[1], duracion, clasificacion, estado, genero);
                        pelicula.Id = short.Parse(particion[0]);
                        L_peliculas.Add(pelicula);
                    }
                    line = lectorbd.ReadLine();
                }
                lectorbd.Close();
            }
            catch (Exception e)
            {
                throw new Exception("Error: " + e.Message);
            }
        }


        public void LeerDBTaquilleros()
        {
            try
            {
                string? line;
                StreamReader lectorbd = new StreamReader(RutaArchivoTaquilleros, Encoding.UTF8);
                string[] particion;
                line = lectorbd.ReadLine();

                while (line != null)
                {
                    if (line != "")
                    {
                        particion = line.Split(";");

                        Taquillero taquillero = new Taquillero(particion[0], long.Parse(particion[1]));
                        L_taquilleros.Add(taquillero);
                    }

                    line = lectorbd.ReadLine();
                }

                lectorbd.Close();
            }
            catch (Exception e)
            {
                throw new Exception("Error: " + e.Message);
            }
        }

        public void LeerDBFunciones()
        {
            try
            {
                string? line;
                StreamReader lectorbd = new StreamReader(RutaArchivoFunciones, Encoding.UTF8);
                string[] particion;
                line = lectorbd.ReadLine();

                while (line != null)
                {
                    if (line != "")
                    {
                        particion = line.Split(";");

                        TimeOnly hora = TimeOnly.Parse(particion[0]);
                        DateOnly diaActual = DateOnly.FromDateTime(DateTime.Now).AddDays(1);
                        DateTime fecha = new DateTime(diaActual, hora);

                        Funcion funcion = new Funcion(fecha, L_salas[int.Parse(particion[1])], L_peliculasActivas[int.Parse(particion[2])]);
                        L_funciones.Add(funcion);
                    }

                    line = lectorbd.ReadLine();
                }

                lectorbd.Close();
            }
            catch (Exception e)
            {
                throw new Exception("Error: " + e.Message);
            }
        }
        */



        


    }
}
