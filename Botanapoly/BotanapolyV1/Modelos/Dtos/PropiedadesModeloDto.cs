﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BotanapolyV1.Modelos.Dto
{
    public class PropiedadesModeloDto
    {
        public int id { get; set; }
        public int jugador {get; set;}
        public int partida {get; set;}
        public int casilla {get; set;}
        public int nivelEdificacion {get; set;}

        public PropiedadesModeloDto()
        {
            
        }


        public PropiedadesModeloDto(int id, int jugador, int partida, int casilla, int nivelEdificacion)
        {
            this.id = id;
            this.jugador = jugador;
            this.partida = partida;
            this.casilla = casilla;
            this.nivelEdificacion = nivelEdificacion;
        }
    }
}
