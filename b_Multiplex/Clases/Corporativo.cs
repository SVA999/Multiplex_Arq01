using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using b_Multiplex.Interfaces;

namespace b_Multiplex.Clases
{

    public class Corporativo : ITipoEvento
    {

        private string descripcion;
        private string empresa;


        // =========================
        // Constructor con validaciones
        // =========================
        public Corporativo(string descripcion, string empresa)
        {

            this.descripcion = descripcion;
            this.empresa = empresa;
        }


        public string Descripcion
        {
            get => descripcion;
            set => descripcion = value;
        }

        public string Empresa
        {
            get => empresa;
            set => empresa = value;
        }


        // =========================
        // Implementación de ITipoEvento
        // =========================
        public string ObtenerTipo()
        {
            return $"Evento Corporativo: {descripcion} | Empresa: {empresa}";
        }
    }
}

