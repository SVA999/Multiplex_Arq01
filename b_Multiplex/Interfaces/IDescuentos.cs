using b_Multiplex.Clases;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using b_Multiplex.Interfaces;

namespace b_Multiplex.Interfaces
{
	public interface IDescuentos : IBeneficios
    {
		double calcular_descuento();
		double obtener_descuento();
    }
}
