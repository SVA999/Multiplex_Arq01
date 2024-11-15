using b_Multiplex.Clases;
using b_Multiplex.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace b_Multiplex.Eventos
{
    internal class Publisher_Ascenso : IAscenso
    {
        //Delegado que representar el evento
        internal delegate void delegado_ascenso();

        //Declarar un evento
        internal event delegado_ascenso evt_ascenso;

        //Atributo Publisher Compra
        internal Publisher_Comprar publisher_comprar;

		internal void EventHandler() { }

		const byte puntosPlatino = Multiplex.puntosPlatino;
        const byte puntosOro = Multiplex.puntosOro;

        public string AscensoPlatino(Espectador cliente)
        {
            try
            {
                string asenso="";

                //Verifica si el evento ha sido llamado / Esto impide que no se pueda llamar directamente
                if (evt_ascenso != null)
                {
                    evt_ascenso();

                    //EVENTO COMPRA
                    publisher_comprar = new Publisher_Comprar();

                    //Suscribirme al evento
                    publisher_comprar.evt_compra += EventHandler;

                    if (cliente is Normal && cliente.Puntos >= puntosPlatino)
                    {
                            //CAMBIO DE CATEGORIA 
                        Platino nuevoCliente = new Platino(cliente.Id, cliente.Nombre, cliente.Edad, cliente.Telefono);
                        nuevoCliente.Puntos = cliente.Puntos;                     
                        
                            //ELIMINA LA CLASE ANTERIOR 
                        Multiplex.l_espectadores.RemoveAll(p => p.Id == cliente.Id);
                        cliente = null;

                            //INTRODUCE EL CLIENTE CON SU NUEVA CATEGORIA
                        Multiplex.l_espectadores.Add(nuevoCliente);
                        asenso += $"Puntos por Combo, {publisher_comprar.Compra(nuevoCliente)}\n\n ";
                        asenso += $"FELICIDADES!! has sido ascendido a cliente Platino, {publisher_comprar.Compra(nuevoCliente)}";
                        return asenso;
                    }
                    return $"{publisher_comprar.Compra(cliente)}, " +
                        $"Te faltan {puntosPlatino - cliente.Puntos} puntos para llegar a Platino";
  
                }
                else return "Llamada al evento AscensoPlatino no valida";
            }
            catch (Exception ex)
            {
                throw new Exception("Error en AscensoPlatino: " + ex);
            }
        }

        public string AscensoOro(Espectador cliente)
        {
            try
            {
                string asenso = "";

                //Verifica si el evento ha sido llamado / Esto impide que no se pueda llamar directamente
                if (evt_ascenso != null)
                {
                    evt_ascenso();

                    //EVENTO COMPRA
                    publisher_comprar = new Publisher_Comprar();

                    //Suscribirme al evento
                    publisher_comprar.evt_compra += EventHandler;

                    if (cliente is Platino && cliente.Puntos >= puntosOro)
                    {

                        //CAMBIO DE CATEGORIA 
                        Oro nuevoCliente = new Oro(cliente.Id, cliente.Nombre, cliente.Edad, cliente.Telefono);
                        nuevoCliente.Puntos = cliente.Puntos;

                        //ELIMINA LA CLASE ANTERIOR 
                        Multiplex.l_espectadores.RemoveAll(p => p.Id == cliente.Id);
                        cliente = null;

                        //INTRODUCE EL CLIENTE CON SU NUEVA CATEGORIA
                        Multiplex.l_espectadores.Add(nuevoCliente);
                        asenso += $"Puntos por Combo, {publisher_comprar.Compra(nuevoCliente)}\n\n ";
                        asenso += $"FELICIDADES!! has sido ascendido a cliente Oro, {publisher_comprar.Compra(nuevoCliente)}";
                        return asenso;

                    }
                    return $"{publisher_comprar.Compra(cliente)}, " +
                        $"Te faltan {puntosOro - cliente.Puntos} puntos para llegar a Oro";
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
