using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BotanapolyV1.Modelos.Dto
{
    public class CasillaModelosDto
    {
        public int tipo { get; set; }
        public int tablero {get; set;}
        public string nombre {get; set;}
        public int orden {get; set;}
        public int precioCompra {get; set;}
        public int precioVenta {get; set;}
        public int nivelEdificacion {get; set;}
        public int costeEdificacion {get; set;}
        public int precioVentaEdificacion {get; set;}
        public int Coste1 {get; set;}
        public int Coste2 {get; set;}
        public int Coste3 {get; set;}
        public int Coste4 {get; set;}
        public int Coste5 {get; set;}
        public int conjunto {get; set;}
        public int destino {get; set;}

        public CasillaModelosDto()
        {

        }

        public CasillaModelosDto(int tipo, int tablero, string nombre, int orden, int precioCompra, 
            int precioVenta, int nivelEdificacion, int costeEdificacion, int precioVentaEdificacion, 
            int Coste1, int Coste2, int Coste3, int Coste4, int Coste5, int conjunto, int destino)
        {
            this.tipo = tipo;
            this.tablero = tablero;
            this.nombre = nombre;
            this.orden = orden;
            this.precioCompra = precioCompra;
            this.precioVenta = precioVenta;
            this.nivelEdificacion = nivelEdificacion;
            this.costeEdificacion = costeEdificacion;
            this.precioVentaEdificacion = precioVentaEdificacion;
            this.Coste1 = Coste1;
            this.Coste2 = Coste2;
            this.Coste3 = Coste3;
            this.Coste4 = Coste4;
            this.Coste5 = Coste5;
            this.conjunto = conjunto;
            this.conjunto = destino;
        }

        public CasillaModelosDto(Object[] array)
        {
            this.tipo = (int)array[0];
            this.tablero = (int)array[1];
            this.nombre = (string)array[2];
            this.orden = (int)array[3];
            this.precioCompra = (int)array[4];
            this.precioVenta = (int)array[5];
            this.nivelEdificacion = (int)array[6];
            this.costeEdificacion = (int)array[7];
            this.precioVentaEdificacion = (int)array[8];
            this.Coste1 = (int)array[9];
            this.Coste2 = (int)array[10];
            this.Coste3 = (int)array[11];
            this.Coste4 = (int)array[12];
            this.Coste5 = (int)array[13];
            this.conjunto = (int)array[14];
            this.conjunto = (int)array[15];
        }

    }

    
}
