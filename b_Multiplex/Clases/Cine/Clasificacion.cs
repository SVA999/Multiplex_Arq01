using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using b_Multiplex.Interfaces;

namespace b_Multiplex.Clases.Cine
{
    public class Clasificacion : IClasificacionPelicula
    {
        private string etiqueta;
        private string descripcion;
        private string informacion;
        private byte edad_minima;

        public Clasificacion(string etiqueta, string descripcion, string informacion, byte edad_minima)
        {
            Etiqueta = etiqueta;
            Descripcion = descripcion;
            Informacion = informacion;
            Edad_minima = edad_minima;
        }

        public string Etiqueta { get => etiqueta; set => etiqueta = value; }
        public string Descripcion { get => descripcion; set => descripcion = value; }
        public string Informacion { get => informacion; set => informacion = value; }
        public byte Edad_minima { get => edad_minima; set => edad_minima = value; }

        public string ObtenerEtiqueta()
        {
            return Etiqueta;
        }

        // FIX 1: implementación explícita → usa el campo privado
        string IClasificacionPelicula.Informacion()
        {
            return $"[{etiqueta}] {descripcion} — Edad mínima: {(edad_minima == 0 ? "Todas las edades" : edad_minima + " años")}";
        }

        public bool ValidarEdad()
        {
            return edad_minima == 0;
        }
    }
}
