using b_Multiplex.Aspectos;
using b_Multiplex.Clases;
using b_Multiplex.Interfaces;
using Castle.DynamicProxy;

namespace ConsilaMultiplex
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {

                Multiplex multiplex = new Multiplex("Cinematronico", "Calle 2 #45V");


                Multiplex.l_espectadores.Add(new Normal(12345678, "Juan", 25, 3558556456));
                Multiplex.l_espectadores.Add(new Normal(12345878, "Ana", 25, 3558556456));
                Multiplex.l_espectadores.Add(new Normal(12345978, "Pabli", 25, 3558556456));

                //Prueba de aspectos y eventos//
                //▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬//
                //▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬//
                //▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬//

                /*

                //Instancio un generador de conexiones a Proxies
                var gen_proxies = new ProxyGenerator();

                // Encontrar el producto por ID
                var espectadorEncontrado = Multiplex.l_espectadores.FirstOrDefault(p => p.Id == 1234567);

                //Crear el proxy dinamico ==> contra/conectandolo a la interface
                ICombo? proxy_Comprar = gen_proxies.CreateInterfaceProxyWithTarget(
                    typeof(ICombo), //Interface
                    espectadorEncontrado, //La clase que tiene implementada la interface
                    new InterceptorCombo()) //Proxy que intercepta las peticiones
                    as ICombo;

                Console.WriteLine("--------------------------------------");

               var consulta = from persona in Multiplex.l_espectadores
                               select persona.Nombre;

                Console.WriteLine(string.Join(", ", consulta));

                Console.WriteLine($"Puntos de cliente {espectadorEncontrado.Nombre}: {espectadorEncontrado.Puntos}");

                Console.WriteLine(proxy_Comprar.ComprarCombo(1));
                espectadorEncontrado = Multiplex.l_espectadores.FirstOrDefault(p => p.Id == 1234567);
                proxy_Comprar = gen_proxies.CreateInterfaceProxyWithTarget(
                    typeof(ICombo),
                    espectadorEncontrado,
                    new InterceptorCombo())
                    as ICombo;

                if (espectadorEncontrado is Normal)
                    Console.WriteLine($"Sigue normal {espectadorEncontrado.Puntos}");
                else if (espectadorEncontrado is Platino)
                    Console.WriteLine($"Muto Platino {espectadorEncontrado.Puntos}");
                else if (espectadorEncontrado is Oro)
                    Console.WriteLine($"Muto oro {espectadorEncontrado.Puntos}");

                Console.WriteLine("--------------------------------------");
                
                consulta = from persona in Multiplex.l_espectadores
                           select persona.Nombre;
                Console.WriteLine(string.Join(", ", consulta));

                espectadorEncontrado.Puntos = 99;
                Console.WriteLine($"Puntos de cliente {espectadorEncontrado.Nombre}: {espectadorEncontrado.Puntos}");

                Console.WriteLine(proxy_Comprar.ComprarCombo(3));
                espectadorEncontrado = Multiplex.l_espectadores.FirstOrDefault(p => p.Id == 1234567);
                proxy_Comprar = gen_proxies.CreateInterfaceProxyWithTarget(
                    typeof(ICombo),
                    espectadorEncontrado,
                    new InterceptorCombo())
                    as ICombo;

                if (espectadorEncontrado is Normal)
                    Console.WriteLine($"Sigue normal {espectadorEncontrado.Puntos}");
                else if (espectadorEncontrado is Platino)
                    Console.WriteLine($"Muto Platino {espectadorEncontrado.Puntos}");
                else if (espectadorEncontrado is Oro)
                    Console.WriteLine($"Muto oro {espectadorEncontrado.Puntos}");

                Console.WriteLine("--------------------------------------");
                consulta = from persona in Multiplex.l_espectadores
                           select persona.Nombre;
                Console.WriteLine(string.Join(", ", consulta));

                Console.WriteLine($"Puntos de cliente {espectadorEncontrado.Nombre}: {espectadorEncontrado.Puntos}");

                Console.WriteLine(proxy_Comprar.ComprarCombo(4));
                espectadorEncontrado = Multiplex.l_espectadores.FirstOrDefault(p => p.Id == 1234567);
                proxy_Comprar = gen_proxies.CreateInterfaceProxyWithTarget(
                    typeof(ICombo),
                    espectadorEncontrado,
                    new InterceptorCombo())
                    as ICombo;

                if (espectadorEncontrado is Normal)
                    Console.WriteLine($"Sigue normal {espectadorEncontrado.Puntos}");
                else if (espectadorEncontrado is Platino)
                    Console.WriteLine($"Muto Platino {espectadorEncontrado.Puntos}");
                else if (espectadorEncontrado is Oro)
                    Console.WriteLine($"Muto oro {espectadorEncontrado.Puntos}");

                Console.WriteLine("--------------------------------------");
                consulta = from persona in Multiplex.l_espectadores
                           select persona.Nombre;
                Console.WriteLine(string.Join(", ", consulta));

                espectadorEncontrado.Puntos = 149;
                Console.WriteLine($"Puntos de cliente {espectadorEncontrado.Nombre}: {espectadorEncontrado.Puntos}");

                Console.WriteLine(proxy_Comprar.ComprarCombo(4));
                espectadorEncontrado = Multiplex.l_espectadores.FirstOrDefault(p => p.Id == 1234567);
                proxy_Comprar = gen_proxies.CreateInterfaceProxyWithTarget(
                    typeof(ICombo),
                    espectadorEncontrado,
                    new InterceptorCombo())
                    as ICombo;

                if (espectadorEncontrado is Normal)
                    Console.WriteLine($"Sigue normal {espectadorEncontrado.Puntos}");
                else if (espectadorEncontrado is Platino)
                    Console.WriteLine($"Muto Platino {espectadorEncontrado.Puntos}");
                else if (espectadorEncontrado is Oro)
                    Console.WriteLine($"Muto oro {espectadorEncontrado.Puntos}");

                Console.WriteLine("--------------------------------------");
                consulta = from persona in Multiplex.l_espectadores
                           select persona.Nombre;
                Console.WriteLine(string.Join(", ", consulta));

                espectadorEncontrado.Puntos = 149;
                Console.WriteLine($"Puntos de cliente {espectadorEncontrado.Nombre}: {espectadorEncontrado.Puntos}");

                Console.WriteLine(proxy_Comprar.ComprarCombo(5));
                espectadorEncontrado = Multiplex.l_espectadores.FirstOrDefault(p => p.Id == 1234567);
                proxy_Comprar = gen_proxies.CreateInterfaceProxyWithTarget(
                    typeof(ICombo),
                    espectadorEncontrado,
                    new InterceptorCombo())
                    as ICombo;

                if (espectadorEncontrado is Normal)
                    Console.WriteLine($"Sigue normal {espectadorEncontrado.Puntos}");
                else if (espectadorEncontrado is Platino)
                    Console.WriteLine($"Muto Platino {espectadorEncontrado.Puntos}");
                else if (espectadorEncontrado is Oro)
                    Console.WriteLine($"Muto oro {espectadorEncontrado.Puntos}");*/

                //Prueba de salas//
                //▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬//
                //▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬//
                //▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬//

                var salaEncontrada = multiplex.L_salas.FirstOrDefault(p => p.Id == 1);

                Console.WriteLine($"\n--- ESTOS SON LOS ASIENTOS DE LA SALA {salaEncontrada.Id} ---\n");


                for (int i = 0; i < salaEncontrada.Sillas.GetLength(0); i++)
                {
                    for (int j = 0; j < salaEncontrada.Sillas.GetLength(1); j++)
                    {
                        Console.Write($"{salaEncontrada.Sillas[i, j].Posicion}\t");
                    }
                    Console.WriteLine();
                }

                


                //Prueba Venta de boletos//
                //▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬//
                //▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬//
                //▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬//

                Taquillero vendedor = new Taquillero("Juan",1324567890);

                multiplex.L_peliculas.Add(new Pelicula("Cargo",new TimeSpan(3,2,0),16,"Documental"));

                Funcion funcion = new Funcion(new DateTime(2024, 11, 15, 5, 30, 0), multiplex.L_salas[0], multiplex.L_peliculas[0]);

                // Encontrar el producto por ID
                var espectadorEncontrado = Multiplex.l_espectadores.FirstOrDefault(p => p.Nombre == "Juan");
                
                Console.WriteLine(vendedor.VenderBoleta(20000, funcion, espectadorEncontrado, true));


                Console.WriteLine($"\n--- ESTOS SON LOS ASIENTOS DE LA SALA {salaEncontrada.Id} ---\n");

                // Encontrar el producto por ID
                espectadorEncontrado = Multiplex.l_espectadores.FirstOrDefault(p => p.Nombre == "Ana");

                Console.WriteLine(vendedor.VenderBoleta(15000, funcion, espectadorEncontrado, true));

                // Encontrar el producto por ID
                espectadorEncontrado = Multiplex.l_espectadores.FirstOrDefault(p => p.Nombre == "Pabli");

                Console.WriteLine(vendedor.VenderBoleta(15000, funcion, espectadorEncontrado, true));

                // Encontrar el producto por ID
                espectadorEncontrado = Multiplex.l_espectadores.FirstOrDefault(p => p.Nombre == "Pabli");

                Console.WriteLine(vendedor.VenderBoleta(15000, funcion, espectadorEncontrado,"D5" , false));
                Console.WriteLine(multiplex.L_salas[0].Sillas[3,4].Ocupada);



            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }
        }
    }
}
