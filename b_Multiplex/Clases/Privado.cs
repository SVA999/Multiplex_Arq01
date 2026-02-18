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

            this.descripcion = descripcion;
        }

        public string descripcion { get => descripcion; set => descripcion = value; }

        // =========================
        // Implementación de ITipoEvento
        // =========================
        public string obtener_tipo()
        {
            return $"Evento Privado: {descripcion}";
        }
    }

}
