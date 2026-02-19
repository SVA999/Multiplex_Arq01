using b_Multiplex.Clases;
using b_Multiplex.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace b_Multiplex.Eventos
{
    internal class Publisher_Comprar : IComprar
    {
        //Delegado que representar el evento
        internal delegate void delegado_compra();

        //Declarar un evento
        internal event delegado_compra evt_compra;

        public string Compra(Espectador espectador)
        {
            try
            {
                //Verifica si el evento ha sido llamado / Esto impide que no se pueda llamar directamente
                if (evt_compra != null)
                {
                    evt_compra();

                    return $"Por la compra ahora tienes: puntos";
                }
                else return "Llamada al evento Compra no valida";
            }
            catch (Exception ex)
            {
                throw new Exception("Error en Compra: " + ex);
            }
        }
    }
}
