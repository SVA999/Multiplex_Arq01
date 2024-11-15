using b_Multiplex.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace b_Multiplex.Clases
{
    public class Multiplex : IArchivos
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
        private List<Taquillero> l_taquilleros;
        private List<Funcion> l_funciones;
        private List<Sala> l_salas = new List<Sala>();
        private List<Pelicula> l_peliculas;
        private List<Pelicula> l_peliculasActivas;
        private string rutaArchivoClientes;
        private string rutaArchivoTaquilleros;
        private string rutaArchivoFunciones;
        private string rutaArchivoPeliculas;

        public Multiplex(string nombre, string direccion)
        {
            Nombre = nombre;
            Direccion = direccion;

            l_salas = new List<Sala>();
            L_salas = Enumerable.Range(0, numTotalSalas).Select(_ => new Sala()).ToList();
            l_taquilleros = new List<Taquillero>();
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

        public List<Taquillero> L_taquilleros { get => l_taquilleros; 
            set
            {
                if (l_taquilleros.Count() > totalTaquilleros)
                    throw new Exception("Numero maximo de taquilleros ");
                else l_taquilleros = value;
            }
        }

        public List<Funcion> L_funciones { get => l_funciones; set => l_funciones = value; }
        public List<Pelicula> L_peliculas { get => l_peliculas; set => l_peliculas = value; }
        public List<Pelicula> L_peliculasActivas { get => l_peliculasActivas; set => l_peliculasActivas = value; }

        public string RutaArchivoClientes { get => rutaArchivoClientes; set => rutaArchivoClientes = value; }
        
        public string RutaArchivoFunciones { get => rutaArchivoFunciones; set => rutaArchivoFunciones = value; }
        public string RutaArchivoPeliculas { get => rutaArchivoPeliculas; set => rutaArchivoPeliculas = value; }
        public string RutaArchivoTaquilleros { get => rutaArchivoTaquilleros; set => rutaArchivoTaquilleros = value; }
        


        //Cliente
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

                        if (short.Parse(particion[4]) < puntosPlatino)
                        {
                            Normal espectador = new Normal(long.Parse(particion[0]), particion[1], byte.Parse(particion[2]), long.Parse(particion[3]));
                            espectador.Puntos = short.Parse(particion[4]);
                            l_espectadores.Add(espectador);
                        }
                        else if (short.Parse(particion[4]) >= puntosPlatino && short.Parse(particion[4]) < puntosOro)
                        {
                            Platino espectador = new Platino(long.Parse(particion[0]), particion[1], byte.Parse(particion[2]), long.Parse(particion[3]));
                            espectador.Puntos = short.Parse(particion[4]);
                            l_espectadores.Add(espectador);
                        }
                        else if (short.Parse(particion[4]) >= puntosOro)
                        {
                            Oro espectador = new Oro(long.Parse(particion[0]), particion[1], byte.Parse(particion[2]), long.Parse(particion[3]));
                            espectador.Puntos = short.Parse(particion[4]);
                            l_espectadores.Add(espectador);
                        }
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

				escritorbd.Write($"{espectador.Id};{espectador.Nombre};{espectador.Edad};{espectador.Telefono};{espectador.Puntos}\n");
				
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

                        string sduracion = particion[2];
                        TimeSpan duracion = TimeSpan.Parse(particion[2]);


                        Pelicula pelicula = new Pelicula(particion[1], duracion, byte.Parse(particion[3]), particion[4]);
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




        


    }
}
