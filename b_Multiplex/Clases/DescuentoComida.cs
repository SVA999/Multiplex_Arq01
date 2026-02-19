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

    public class DescuentoComida : IDescuentos
    {


        public enum l_dia { lunes, martes, miercoles, jueves, viernes, sabado, domingo }
        private double porcentaje_descuento;

        private l_dia dia;
        private TimeOnly hora_inicio;
        private TimeOnly hora_fin;

        public DescuentoComida(double porcentaje_descuento, l_dia dia, TimeOnly hora_inicio, TimeOnly hora_fin)
        {
            PorcentajeDescuento = porcentaje_descuento;
            Dia = dia;
            HoraInicio = hora_inicio;
            HoraFin = hora_fin;
        }

        public double PorcentajeDescuento
        {
            get { return porcentaje_descuento; }
            set { porcentaje_descuento = value; }
        }

        public l_dia Dia
        {
            get { return dia; }
            set { dia = value; }
        }

        public TimeOnly HoraInicio
        {
            get { return hora_inicio; }
            set { hora_inicio = value; }
        }

        public TimeOnly HoraFin
        {
            get { return hora_fin; }
            set { hora_fin = value; }
        }

        public double calcular_descuento()
        {
            DateTime now = DateTime.Now;
            TimeOnly currentTime = TimeOnly.FromDateTime(now);

            l_dia diaHoy = now.DayOfWeek switch
            {
                DayOfWeek.Monday => l_dia.lunes,
                DayOfWeek.Tuesday => l_dia.martes,
                DayOfWeek.Wednesday => l_dia.miercoles,
                DayOfWeek.Thursday => l_dia.jueves,
                DayOfWeek.Friday => l_dia.viernes,
                DayOfWeek.Saturday => l_dia.sabado,
                DayOfWeek.Sunday => l_dia.domingo,
                _ => l_dia.lunes
            };

            if (diaHoy == dia && currentTime >= hora_inicio && currentTime <= hora_fin)
                return porcentaje_descuento / 100.0;

            return 0.0;
        }

        // FIX: ya no depende de obtener_beneficio() — lógica propia
        public double obtener_beneficio() => porcentaje_descuento / 100.0;
    }
}


