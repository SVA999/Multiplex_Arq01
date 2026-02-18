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
            throw new NotImplementedException();
        }

        public double obtener_descuento()
        {
            return obtener_beneficio() * (porcentaje_descuento / 100);  
        }

        public double obtener_beneficio()
        {
            throw new NotImplementedException();
        }
    }
}


