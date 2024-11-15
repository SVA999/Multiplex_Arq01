using b_Multiplex.Clases;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace b_Multiplex.Eventos
{
    public class Publisher_CambioCartelera
    {
        //Delegado que representar el evento
        public delegate void delegado_cambioCartelera();

        //Declarar un evento
        public event delegado_cambioCartelera evt_cambioCartelera;

        public string CabioCartelera()
        {
            try
            {
                //Verifica si el evento ha sido llamado / Esto impide que no se pueda llamar directamente
                if (evt_cambioCartelera != null)
                {
                    evt_cambioCartelera();

                    return $"La cartelera se ha actualizado!! mira las nuevas peliculas en pantalla";
                }
                else return "Llamada al evento CabioCartelera no valida";
            }
            catch (Exception ex)
            {
                throw new Exception("Error en evento CabioCartelera: " + ex);
            }
        }


    }
}
