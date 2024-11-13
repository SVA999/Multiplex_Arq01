using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace b_Multiplex.Clases
{
    public class Sala
    {
        private const byte cantSillasVip=32;
        private const byte cantSillasGeneral=96;


        private byte id;
        private Silla[,] sillas;


        public Sala()
        {
            Id = Multiplex.numeroSala;
            Multiplex.numeroSala++;

            
            Sillas = new Silla[16,8];
        }

        public byte Id { get => id; set => id = value; }
        internal Silla[,] Sillas { get => sillas; set => sillas = value; }
    }
}
