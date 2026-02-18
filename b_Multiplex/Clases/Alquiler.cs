using b_Multiplex.Clases.Cine;
using b_Multiplex.Eventos;
using b_Multiplex.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;


namespace b_Multiplex.Clases
{

    public class Alquiler : IServicios
    {
        // =========================
        // Atributos privados
        // =========================
        private ITipoEvento evento;
        private int valor;
        private Sala sala;
        private DateTime fecha_inicio;
        private DateTime fecha_fin;



        // =========================
        // Constructor con inyección de dependencias
        // =========================
        public Alquiler(
            ITipoEvento evento,
            int valor,
            Sala sala,
            DateTime fechaInicio,
            DateTime fechaFin)
        {


            this.evento = evento;
            this.valor = valor;
            this.sala = sala;
            this.fecha_inicio = fechaInicio;
            this.fecha_fin = fechaFin;
        }

        public ITipoEvento Evento
        {
            get => evento;
            set => evento = value ?? throw new ArgumentNullException(nameof(value));
        }

        public int Valor
        {
            get => valor;
            set => valor = value;
        }

        public Sala Sala
        {
            get => sala;
            set => sala = value ?? throw new ArgumentNullException(nameof(value));
        }

        public DateTime FechaInicio
        {
            get => fecha_inicio;
            set => fecha_inicio = value;
        }

        public DateTime FechaFin
        {
            get => fecha_fin;
            set => fecha_fin = value;
        }


        // =========================
        // Implementación de IServicios
        // =========================
        public string ObtenerServicio()
        {
            return $"Alquiler de tipo: {evento.ObtenerTipo()} | " +
                   $"Sala: {sala.Nombre} | " +
                   $"Desde: {fecha_inicio:dd/MM/yyyy} " +
                   $"Hasta: {fecha_fin:dd/MM/yyyy} | " +
                   $"Valor: {valor}";
        }
    }
}


