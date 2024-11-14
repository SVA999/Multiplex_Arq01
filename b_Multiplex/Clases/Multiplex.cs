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
        public static int precioCombo1 = 25000;
        public static int precioCombo2 = 30000;
        public static int precioCombo3 = 40000;
        public static int precioCombo4 = 50000;
        public static int precioCombo5 = 60000;

        //Salas
        public static byte numeroSala = 1; 
        private const byte numTotalSalas = 5;

        //Sillas
        public const int valorSillaVip = 15000;
        public const int valorSillaGeneral = 10000;


        public int Id { get; set; }
        private string nombre;
        private string direccion;
        private List<Sala> l_salas;
        public static List<Espectador> l_espectadores = new List<Espectador>();
        private string rutaArchivo;

		public Multiplex()
        {
            
        }

        public Multiplex(string nombre, string direccion)
        {
            Nombre = nombre;
            Direccion = direccion;

            l_salas = Enumerable.Range(0, numTotalSalas).Select(_ => new Sala()).ToList();
            RutaArchivo = "C:\\Users\\acer\\Documents\\Final-Paradigmas-master\\Final-Paradigmas-master\\b_Multiplex";
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

		public string RutaArchivo { get => rutaArchivo; set => rutaArchivo = value; }

		public void Leerbd()
		{
			
			try
			{
				string? line;
				StreamReader lectorbd = new StreamReader(rutaArchivo);
                string[] particion;
				line = lectorbd.ReadLine();
				
				while (line != null)
				{
					
					Console.WriteLine(line);

                    particion = line.Split(";");

                    l_espectadores.Add(new Normal(long.Parse(particion[0]), particion[1], byte.Parse(particion[2]), long.Parse(particion[4])));
					
					line = lectorbd.ReadLine();
				}
				
				lectorbd.Close();
			}
			catch (Exception e)
			{
				Console.WriteLine("Exception: " + e.Message);
			}
		}

		public void Escibirbd(Espectador espectador)
		{
			try
			{
				
				StreamWriter escritorbd = new StreamWriter(RutaArchivo, true, Encoding.ASCII);

				escritorbd.Write($"{espectador.Id};{espectador.Nombre};{espectador.Edad};{espectador.Puntos};{espectador.Telefono}\n");
				
				escritorbd.Close();
			}
			catch (Exception e)
			{
				Console.WriteLine("Exception: " + e.Message);
			}
		}
	}
}
