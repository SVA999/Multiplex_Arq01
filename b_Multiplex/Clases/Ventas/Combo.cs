using b_Multiplex.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace b_Multiplex.Clases.Ventas
{
    internal class Combo
    {
        private string descricion;
        private int valor;
        private List<ITipoConsumible> l_consumibles;

        public Combo(string descricion, int valor, List<ITipoConsumible> l_consumibles)
        {
            Descricion = descricion;
            Valor = valor;
            L_consumibles = l_consumibles;
        }

        public string Descricion { get => descricion; set => descricion = value; }
        public int Valor { get => valor; set => valor = value; }
        public List<ITipoConsumible> L_consumibles { get => l_consumibles; set => l_consumibles = value; }
    }
}
