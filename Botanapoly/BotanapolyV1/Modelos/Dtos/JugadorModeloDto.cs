using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BotanapolyV1.Modelos.Dto
{
    public class JugadorModeloDto
    {

        public int id { get; set; }
        public int idUsuario { get; set; }
        public int idPartida { get; set; }
        public int saldo { get; set; }
        public int orden { get; set; }
        public int posicion { get; set; }

        public JugadorModeloDto()
        {

        }

            public JugadorModeloDto (int id, int idUsuario, int idPartida, int saldo, int orden, int posicion)
        {
            this.id = id;
            this.idUsuario = idUsuario;
            this.idPartida = idPartida;
            this.saldo = saldo;
            this.orden = orden;
            this.posicion = posicion;
        }
        /*
        public JugadorModeloDto(object[] array)
        {   
            this.idUsuario = (int)array[0];
            this.idPartida = (int)array[1];
            this.saldo = (int)array[2];
            this.orden = (int)array[3];
            this.posicion = (int)array[4];
            this.dobles = (int)array[5];
            this.turnosDeCastigo = (int)array[6];
            this.deuda = (int)array[7];
            this.acreedor = (int)array[8];
        }*/



    }
}
