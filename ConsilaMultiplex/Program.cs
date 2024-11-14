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


                Multiplex.l_espectadores.Add(new Normal(1234567, "Juan", 25, 3558556456));
                Multiplex.l_espectadores.Add(new Normal(1234587, "Ana", 25, 3558556456));
                Multiplex.l_espectadores.Add(new Normal(1234597, "Pabli", 25, 3558556456));

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

                salaEncontrada = multiplex.L_salas.FirstOrDefault(p => p.Id == 5);

                Console.WriteLine($"\n--- ESTOS SON LOS ASIENTOS DE LA SALA {salaEncontrada.Id} ---\n");


                for (int i = 0; i < salaEncontrada.Sillas.GetLength(0); i++)
                {
                    for (int j = 0; j < salaEncontrada.Sillas.GetLength(1); j++)
                    {
                        Console.Write($"{salaEncontrada.Sillas[i, j].Posicion}\t");
                    }
                    Console.WriteLine();
                }


            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }
        }
    }
}
