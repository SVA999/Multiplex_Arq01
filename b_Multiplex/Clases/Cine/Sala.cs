using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using b_Multiplex.Interfaces;

namespace b_Multiplex.Clases.Cine
{
    public class Sala
    {
        public static byte idTipoSala = 1;

        private byte id;

        private char[] letras = { 'A', 'B', 'C', 'D', 'E', 'F', 'G', 'H' };
        
        private ISilla[,] m_sillas;
        private ITipoSala tipoSala;


        public Sala(byte filas, byte columnas, ITipoSala tipoSala)
        {
            Id = Multiplex.numeroSala;
            Multiplex.numeroSala++;
            TipoSala = tipoSala;


            Sillas = new ISilla[filas, columnas];
            LimpiarSala();

        }

        public Sala(byte filas, byte columnas)
        {
            Id = Multiplex.numeroSala;
            Multiplex.numeroSala++;
            TipoSala = new _2D(idTipoSala++, "Sala 2D");


            Sillas = new ISilla[filas, columnas];
            LimpiarSala();

        }

        public byte Id { get => id; set => id = value; }
        public ISilla[,] Sillas { get => m_sillas; set => m_sillas = value; }
        internal ITipoSala TipoSala { get => tipoSala; set => tipoSala = value; }

        public void LimpiarSala()
        {
            try
            {
                for (int fila = 0; fila < 6; fila++)
                {
                    for (int columna = 0; columna < 12; columna++)
                    {
                        Sillas[fila, columna] = new General($"{letras[fila]}",(byte)(columna + 1), Multiplex.valorSillaGeneral, new Estado());
            }
                }
                for (int fila = 6; fila < 8; fila++)
                {
                    for (int columna = 0; columna < 12; columna++)
                    {
                        Sillas[fila, columna] = new Vip($"{letras[fila]}", (byte)(columna + 1), Multiplex.valorSillaVip, new Estado());
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
