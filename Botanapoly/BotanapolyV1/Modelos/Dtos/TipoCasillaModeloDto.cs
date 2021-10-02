using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BotanapolyV1.Modelos.Dto
{
    public class TipoCasillaModeloDto
    {
        private int id { get; set; }
        private string Description { get; set; }


        public TipoCasillaModeloDto()
        {

        }

        public TipoCasillaModeloDto(int id, string Description, int Importe, int NumeroCasila)
        {
            this.id = id;
            this.Description = Description;
            
        }
    }
}
