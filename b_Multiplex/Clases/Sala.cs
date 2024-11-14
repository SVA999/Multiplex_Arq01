using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace b_Multiplex.Clases
{
    public class Sala
    {
        private const byte cantSillasVip=24;
        private const byte cantSillasGeneral=72;

        private char[] letras = { 'A', 'B', 'C', 'D', 'E', 'F', 'G', 'H' };

        private byte id;

        
        private Silla[,] m_sillas;


        public Sala()
        {
            Id = Multiplex.numeroSala;
            Multiplex.numeroSala++;

            Sillas = new Silla[8, 12];
            LimpiarSala();
        }

        public byte Id { get => id; set => id = value; }

        [NotMapped]
        public Silla[,] Sillas { get => m_sillas; set => m_sillas = value; }

        public void LimpiarSala()
        {
            try
            {
                for (int fila = 0; fila < 6; fila++)
                {
                    for (int columna = 0; columna < 12; columna++)
                    {
                        Sillas[fila, columna] = new General($"{letras[fila]}{columna+1}");
                    }
                }
                for (int fila = 6; fila < 8; fila++)
                {
                    for (int columna = 0; columna < 12; columna++)
                    {
                        Sillas[fila, columna] = new Vip($"{letras[fila]}{columna+1}");
                    }
                }
            }
            catch (Exception e)
            {
                throw new Exception("Error al LimpiarSala: " + e);
            }
        }

    }
}
