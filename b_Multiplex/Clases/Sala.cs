using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace b_Multiplex.Clases
{
    internal class Sala
    {
        private const byte cantSillasVip=32;
        private const byte cantSillasGeneral=96;


        private byte numero;
        private string[,] sillas;
        

        public Sala()
        {
            Numero = Multiplex.numeroSala;
            Multiplex.numeroSala++;

            sillas = new string[16,8];
        }

        public byte Numero { get => numero; set => numero = value; }
        public string[,] Sillas { get => sillas; set => sillas = value; }
    }
}
