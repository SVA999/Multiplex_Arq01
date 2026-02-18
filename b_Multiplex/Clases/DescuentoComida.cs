using b_Multiplex.Eventos;
using b_Multiplex.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;


namespace b_Multiplex.Clases

public class DescuentoComida: IDescuentos
{
   

        public enum l_dia { lunes, martes, miercoles, jueves, viernes, sabado, domingo }
    private double porcentaje_descuento;
		
		private l_dia dia;
	private Time hora_inicio;
	private Time hora_fin;

    public DescuentoComida(double porcentaje_descuento, l_dia dia, Time hora_inicio, Time hora_fin)
          {
                this.porcentaje_descuento = porcentaje_descuento;
                this.dia = dia;
                this.hora_inicio = hora_inicio;
                this.hora_fin = hora_fin;
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

    public Time HoraInicio
    {
        get { return hora_inicio; }
        set { hora_inicio = value; }
    }

    public Time HoraFin
    {
        get { return hora_fin; }
        set { hora_fin = value; }
    }

    public double calcular_descuento(ITipoConsumible consumible)
	{

	}

	public double obtener_descuento()
	{

	}

	}


