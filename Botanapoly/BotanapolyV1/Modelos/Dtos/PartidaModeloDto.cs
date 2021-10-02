using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BotanapolyV1.Modelos.Dto
{
    public class PartidaModeloDto
    {
        public int id { get; set; }
        public string nombre { get; set; }
        public int administrador { get; set; }
        public int maxJugadores { get; set; }
        public int maxTiempo { get; set; }
        public DateTime fechaInicio { get; set; }
        public string pass { get; set; }
        public int numJugadores { get; set; }
        public int turno { get; set; }
        public int estado { get; set; }
        public int tablero { get; set; }

        public PartidaModeloDto()
        { 
        
        }
        public PartidaModeloDto(int id, string nombre, int administrador, int maxJugadores, int maxTiempo,
                                DateTime fechaInicio, string pass, int numJugadores, int turno, int estado, int tablero )
        {
            this.id = id;
            this.nombre = nombre;
            this.administrador = administrador;
            this.maxJugadores = maxJugadores;
            this.maxTiempo = maxTiempo;
            this.fechaInicio = fechaInicio;
            this.pass = pass;
            this.numJugadores = numJugadores;
            this.turno = turno;
            this.estado = estado;
            this.tablero = tablero;
        }

        public PartidaModeloDto(Object[] array)
        {
            this.id = (int)array[0];
            this.nombre = (string)array[1];
            this.administrador = (int)array[2];
            this.maxJugadores = (int)array[3];
            this.maxTiempo = (int)array[4];
            this.fechaInicio = (DateTime)array[5];
            this.pass = (string)array[6];
            this.numJugadores = (int)array[7];
            this.turno = (int)array[8];
            this.estado = (int)array[9];
            this.tablero = (int)array[10];
        }
    }

    

}
