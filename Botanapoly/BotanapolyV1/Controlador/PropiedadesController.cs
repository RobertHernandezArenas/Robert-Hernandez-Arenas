using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BotanapolyV1.Modelos.Dao;
using BotanapolyV1.Modelos.Dto;

namespace BotanapolyV1.Controlador
{
    [Route("api/v1/[controller]")]
    [ApiController]
    public class propiedadesController : ControllerBase
    {
        // ------------------- POST: COMPRAR PROPIEDAD --------------------
        #region Comprar Propiedad
        [Route("comprar")]
        [HttpGet]
        public object[] GET(int idJugador)
        {
            BaseDatos NuevaConexionBD = new();
            NuevaConexionBD.ObtenConexion().Open();

            List<object[]> listaObjetos = NuevaConexionBD.HazLaConsulta("exec comprar " + idJugador + "");
            NuevaConexionBD.CierraConexion();
            return listaObjetos[0];
        }
        #endregion FIN: Comprar Propiedad


        // ------------------- GET: VENDER PROPIEDAD --------------------
        #region Vender Propiedad
        [Route("vender")]
        [HttpGet]
        public object[] GET(int idJugador, int casilla)
        {
            BaseDatos NuevaConexionBD = new();
            NuevaConexionBD.ObtenConexion().Open();

            List<object[]> Casilla = NuevaConexionBD.HazLaConsulta($"exec comprar '{idJugador}','{casilla}'");
            NuevaConexionBD.CierraConexion();

            return Casilla[0];
        }
        #endregion Vender Propiedad


        // ------------------- POST: ACTUALIZAR NIVEL CONSTRUCCION --------------------
        #region PUT: Actualizar Nivel Construccion
        /*
        [HttpPut]
        [Route("construccion/actualizar")]
        public Object[] PUT([FromBody] PropiedadesModeloDto ActualizarNivelConstruccion, CasillaModeloDto Casilla)
        {
            BaseDatos NuevaConexionBD = new BaseDatos();
            NuevaConexionBD.ObtenConexion().Open();

            List<object[]> PropiedadActualizada = NuevaConexionBD.InsertaLosDatos(
                $"exec actualizarNivelConstruccion '{ActualizarNivelConstruccion.jugador}', '{ActualizarNivelConstruccion.tipo}','{ActualizarNivelConstruccion.ti}','{}','{}'");
            NuevaConexionBD.CierraConexion();

            return PropiedadActualizada[0];
        }
        */
        #endregion FIN: Actualizar Nivel Construccion

    }
}
