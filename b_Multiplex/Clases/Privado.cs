using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using b_Multiplex.Interfaces;

namespace b_Multiplex.Clases
{

    public class Privado : ITipoEvento
    {
        // =========================
        // Atributos privados
        // =========================
        private string descripcion;


        public Privado(string descripcion)
        {

            Descripcion = descripcion;
        }

        public string Descripcion { get => this.descripcion; set => this.descripcion = value; }

        // =========================
        // Implementación de ITipoEvento
        // =========================
        public string ObtenerTipo()
        {
            return $"Evento Privado: {descripcion}";
        }
    }

}
