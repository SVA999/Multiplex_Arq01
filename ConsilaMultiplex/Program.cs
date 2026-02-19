using b_Multiplex.Aspectos;
using b_Multiplex.Clases;
using b_Multiplex.Interfaces;
using Castle.DynamicProxy;

namespace ConsilaMultiplex
{
    class EventoCorporativo : ITipoEvento
    {
        public string ObtenerTipo() => "Corporativo - Conferencia Empresarial";
    }

    class Program
    {
        static void Sep(string t) =>
            Console.WriteLine($"\n===== {t} =====");

        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            Console.WriteLine("╔═══════════════════════════════════════════╗");
            Console.WriteLine("║      PRUEBA DE BIBLIOTECA MULTIPLEX       ║");
            Console.WriteLine("╚═══════════════════════════════════════════╝");

            // ─────────────────────────────────────────────
            // 1. CREAR MULTIPLEX
            // ─────────────────────────────────────────────
            Sep("1. MULTIPLEX");
            var cine = new Multiplex("CineCity Plaza", "Av. El Poblado 123, Medellín");
            Console.WriteLine($"Nombre  : {cine.Nombre}");
            Console.WriteLine($"Dirección: {cine.Direccion}");
            Console.WriteLine($"Salas   : {cine.L_salas.Count}");

            // ─────────────────────────────────────────────
            // 2. CREAR ESPECTADORES con ISuscripcion inyectada
            // ─────────────────────────────────────────────
            Sep("2. REGISTRO DE ESPECTADORES");
            var carlos = new Espectador(12345678, "Carlos Pérez",  25, 3001234567, new Normal());
            var ana    = new Espectador(87654321, "Ana García",    32, 3107654321, new Platino());
            var luis   = new Espectador(11223344, "Luis Méndez",   45, 3209876543, new Oro());

            Multiplex.l_espectadores.AddRange(new[] { carlos, ana, luis });

            Console.WriteLine($"{"Nombre",-16} {"Categoría",-10} {"Puntos",6} {"Descuento",10}");
            Console.WriteLine(new string('─', 46));
            foreach (var e in Multiplex.l_espectadores)
                Console.WriteLine($"{e.Nombre,-16} {e.Categoria,-10} {e.Puntos,6} {e.ObtenerDescuento(),9:P0}");

            // ─────────────────────────────────────────────
            // 3. MENSAJES DE SUSCRIPCIÓN
            // ─────────────────────────────────────────────
            Sep("3. SUSCRIPCIONES");
            foreach (var e in Multiplex.l_espectadores)
                Console.WriteLine($"[{e.Categoria}] → {e.Suscripcion.suscribir()}");

            // ─────────────────────────────────────────────
            // 4. COMBOS — restricciones por categoría
            // ─────────────────────────────────────────────
            Sep("4. RESTRICCIONES DE COMBOS");
            var confiteria = new Confiteria();

            Console.WriteLine($"[Normal  - Combo 4]: {confiteria.ComprarCombo(carlos, 4)}");
            Console.WriteLine($"[Normal  - Combo 5]: {confiteria.ComprarCombo(carlos, 5)}");
            Console.WriteLine($"[Platino - Combo 5]: {confiteria.ComprarCombo(ana, 5)}");
            Console.WriteLine($"[Oro     - Combo 5]: {confiteria.ComprarCombo(luis, 5)}");

            // ─────────────────────────────────────────────
            // 5. COMPRAS NORMALES con acumulación de puntos
            // ─────────────────────────────────────────────
            Sep("5. COMPRA DE COMBOS (puntos)");
            Console.WriteLine($"[Normal  - Combo 1 ($25k)]: {confiteria.ComprarCombo(carlos, 1)}");
            Console.WriteLine($"[Platino - Combo 3 ($40k)]: {confiteria.ComprarCombo(ana, 3)}");

            Console.WriteLine($"\n  Carlos puntos: {carlos.Puntos}");
            Console.WriteLine($"  Ana    puntos: {ana.Puntos}");
            Console.WriteLine($"  Luis   puntos: {luis.Puntos}");

            // ─────────────────────────────────────────────
            // 6. ASCENSO Normal → Platino
            // ─────────────────────────────────────────────
            Sep("6. ASCENSO: Normal → Platino");
            carlos.Puntos = 97;
            Console.WriteLine($"Puntos antes     : {carlos.Puntos}");
            Console.WriteLine($"Comprando Combo 2 (+3 pts)...");
            Console.WriteLine($"Resultado        : {confiteria.ComprarCombo(carlos, 2)}");
            Console.WriteLine($"Nueva categoría  : [{carlos.Categoria}] — {carlos.Puntos} pts");
            Console.WriteLine($"Nuevo descuento  : {carlos.ObtenerDescuento():P0}");

            // ─────────────────────────────────────────────
            // 7. ASCENSO Platino → Oro
            // ─────────────────────────────────────────────
            Sep("7. ASCENSO: Platino → Oro");
            ana.Puntos = 140;
            Console.WriteLine($"Puntos antes     : {ana.Puntos}");
            Console.WriteLine($"Comprando Combo 4 (+10 pts)...");
            Console.WriteLine($"Resultado        : {confiteria.ComprarCombo(ana, 4)}");
            Console.WriteLine($"Nueva categoría  : [{ana.Categoria}] — {ana.Puntos} pts");
            Console.WriteLine($"Nuevo descuento  : {ana.ObtenerDescuento():P0}");

            // ─────────────────────────────────────────────
            // 8. DESCUENTOS DE COMIDA (DescuentoComida)
            // ─────────────────────────────────────────────
            Sep("8. DESCUENTO DE COMIDA");
            var descComida = new DescuentoComida(
                15,
                DescuentoComida.l_dia.miercoles,
                new TimeOnly(14, 0),
                new TimeOnly(18, 0)
            );
            Console.WriteLine($"Descuento configurado  : {descComida.obtener_descuento():P0}");
            Console.WriteLine($"Descuento activo ahora : {descComida.calcular_descuento():P0}");

            // ─────────────────────────────────────────────
            // 9. DESCUENTO BOLETO (DescuentoBoleto)
            // ─────────────────────────────────────────────
            Sep("9. DESCUENTO DE BOLETA");
            var descBoleta = new DescuentoBoleto(
                20,
                DescuentoBoleto.l_dia.miercoles,
                new TimeOnly(10, 0),
                new TimeOnly(23, 0)
            );
            Console.WriteLine($"Descuento configurado  : {descBoleta.obtener_descuento():P0}");
            Console.WriteLine($"Descuento activo ahora : {descBoleta.calcular_descuento():P0}");

            // ─────────────────────────────────────────────
            // 10. ALQUILER DE SALA
            // ─────────────────────────────────────────────
            Sep("10. ALQUILER DE SALA");
            var alquiler = new Alquiler(
                new EventoCorporativo(),
                2_500_000,
                cine.L_salas[0],
                DateTime.Now,
                DateTime.Now.AddDays(2)
            );
            Console.WriteLine(alquiler.ObtenerServicio());

            // ─────────────────────────────────────────────
            // 11. ESTADO FINAL
            // ─────────────────────────────────────────────
            Sep("11. ESTADO FINAL DE ESPECTADORES");
            Console.WriteLine($"{"Nombre",-16} {"Categoría",-10} {"Puntos",6} {"Descuento",10}");
            Console.WriteLine(new string('─', 46));
            foreach (var e in Multiplex.l_espectadores)
                Console.WriteLine($"{e.Nombre,-16} {e.Categoria,-10} {e.Puntos,6} {e.ObtenerDescuento(),9:P0}");

            Console.WriteLine("\n[PRUEBAS COMPLETADAS] Presiona cualquier tecla...");
            Console.ReadKey();
        }
    }
}
