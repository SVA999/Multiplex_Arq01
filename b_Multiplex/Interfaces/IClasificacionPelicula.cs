using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace b_Multiplex.Interfaces
{
    public interface IClasificacionPelicula
    {
        public string ObtenerEtiqueta();
        public string Informacion();
        public  bool ValidarEdad();
    }
}
