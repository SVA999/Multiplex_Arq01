using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using b_Multiplex.Interfaces;

namespace b_Multiplex.Clases.Cine
{
    public class Estado : IEstado
    {

        private string descripcion;
        private bool selecionable;

        public Estado(string descripcion, bool selecionable)
        {
            Descripcion = descripcion;
            Selecionable = selecionable;
        }

        public string Descripcion { get => descripcion; set => descripcion = value; }
        public bool Selecionable { get => selecionable; set => selecionable = value; }

        public bool PuedeSeleccionarse()
        {
            return Selecionable;
        }
    }
}
