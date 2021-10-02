using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BotanapolyV1.Modelos.Dto
{
    public class TableroModeloDto
    {
        public int id { get; set; }
        public string Description { get; set; }
        public int Importe { get; set; }
        public int NumeroCasilla { get; set; }


        public TableroModeloDto()
        {

        }

        public TableroModeloDto(int id, string Description, int Importe, int NumeroCasila)
        {
            this.id = id;
            this.Description = Description;
            this.Importe = Importe;
            this.NumeroCasilla = NumeroCasila;
        }

        public TableroModeloDto(Object[] array)
        {
            this.id = (int)array[0];
            this.Description = (string)array[1];
            this.Importe = (int)array[2];
            this.NumeroCasilla = (int)array[3];
        }
    }
}
