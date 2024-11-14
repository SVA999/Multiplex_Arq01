using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace b_Multiplex.Clases
{
    internal class Vip : Silla
    {
        public Vip(string posicion) : base(posicion)
        {
            Valor = Multiplex.valorSillaVip;
        }
    }
}
