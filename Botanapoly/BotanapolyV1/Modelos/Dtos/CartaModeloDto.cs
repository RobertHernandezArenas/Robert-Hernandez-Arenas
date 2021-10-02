using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BotanapolyV1.Modelos.Dto
{
    public class CartaModeloDto
    {

        private int id { get; set; }
        public int tablero  {get; set;}
        public int conjunto  {get; set;}
        public int tipo  {get; set;}
        public int valor  {get; set;}


        public CartaModeloDto()
        {

        }

        public CartaModeloDto(int id, int tablero, int conjunto, int tipo, int valor)
        {
            this.id = id;
            this.tablero = tablero;
            this.conjunto = conjunto;
            this.tipo = tipo;
            this.valor = valor;
        }

        public CartaModeloDto(Object [] array)
        {
            this.id = (int)array[0];
            this.tablero = (int)array[1];
            this.conjunto = (int)array[2];
            this.tipo = (int)array[3];
            this.valor = (int)array[4];
        }
    }
}
