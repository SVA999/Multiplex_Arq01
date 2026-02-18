using b_Multiplex.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace b_Multiplex.Clases.Ventas
{
    internal class Consumible
    {
        private byte id;
        private ITipoConsumible tipoConsumible;

        public Consumible(byte id, ITipoConsumible tipoConsumible)
        {
            this.id = id;
            this.tipoConsumible = tipoConsumible;
        }

        public byte Id { get => id; set => id = value; }
        public ITipoConsumible TipoConsumible { get => tipoConsumible; set => tipoConsumible = value; }
    }
}
