using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace b_Multiplex.Clases
{
    internal class General : Silla
    {

        public General(string posicion) : base(posicion)
        {
            Valor = Multiplex.valorSillaGeneral;
        }

    }
}
