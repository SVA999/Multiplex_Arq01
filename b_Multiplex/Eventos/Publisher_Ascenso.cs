using b_Multiplex.Clases;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace b_Multiplex.Eventos
{
    internal class Publisher_Ascenso
    {
        //Delegado que representar el evento
        internal delegate void delegado_ascenso();

        //Declarar un evento
        internal event delegado_ascenso evt_ascenso;

        const byte puntosPlatino = 100;
        const byte puntosOro = 150;

        internal string AscensoPlatino(Normal normal)
        {
            try
            {
                //Verifica si el evento ha sido llamado / Esto impide que no se pueda llamar directamente
                if (evt_ascenso != null)
                {
                    evt_ascenso();

                    if (normal.Puntos >= puntosPlatino)
                    {
                        new Platino(normal.Id, normal.Nombre, normal.Edad, normal.Telefono);
                        normal = null;
                        return "FELICIDADES!! has sido ascendido a cliente Platino";  
                    }
                    return $"Te faltan {puntosPlatino - normal.Puntos } puntos para llegar a Platino";
                }
                else return "Llamada al evento AscensoPlatino no valida";
            }
            catch (Exception ex)
            {
                throw new Exception("Error en AscensoPlatino: " + ex);
            }
        }

        internal string AscensoOro(Platino platino)
        {
            try
            {
                //Verifica si el evento ha sido llamado / Esto impide que no se pueda llamar directamente
                if (evt_ascenso != null)
                {
                    evt_ascenso();

                    if (platino.Puntos >= puntosOro)
                    {
                        new Oro(platino.Id, platino.Nombre, platino.Edad, platino.Telefono);
                        platino = null;
                        return "FELICIDADES!! has sido ascendido a cliente Oro";
                    }
                    return $"Te faltan {puntosOro - platino.Puntos} puntos para llegar a Oro";
                }
                else return "Llamada al evento AscensoOro no valida";
            }
            catch (Exception ex)
            {
                throw new Exception("Error en AscensoOro: " + ex);
            }
        }

    }
}
