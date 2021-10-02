using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BotanapolyV1.Modelos.Dto;
using BotanapolyV1.Modelos.Dao;


namespace BotanapolyV1.Controlador
{
    [Route("api/v1/[controller]")]
    [ApiController]
    public class jugadorController : ControllerBase
    {
        // ------------------- POST: AGREGAR JUGADOR --------------------
        #region POST: Agregar Jugador a Partida
        [HttpPost]
        [Route("agregar")]
        public int Post([FromBody] JugadorModeloDto DatosJugador)
        {

            BaseDatos NuevaConexionBD = new BaseDatos();
            NuevaConexionBD.ObtenConexion().Open();

            int NuevoJugadorPartida = NuevaConexionBD.InsertaLosDatos(
                $"exec anadirJugador '{DatosJugador.idUsuario}','{DatosJugador.idPartida}'");
            NuevaConexionBD.CierraConexion();

            return NuevoJugadorPartida;
        }

        #endregion FIN: Agregar Jugador a Partida

        // ------------------- POST: CREAR BOTS --------------------
        #region Crear Bots en Partida
        [HttpPost]
        [Route("bot/crear")]
        public int POST([FromBody] int nBots, int idPartida)
        {
            BaseDatos NuevaConexionBD = new BaseDatos();
            NuevaConexionBD.ObtenConexion().Open();

            int numeroBotsPartida = 0;

            for (int i = 0; i < nBots; i++)
            {
                numeroBotsPartida = NuevaConexionBD.InsertaLosDatos($"exec anadirJugador 'NULL', '{idPartida}'");
            }
            NuevaConexionBD.CierraConexion();

            return numeroBotsPartida;
        }
        #endregion Crear Bots en Partida

        
    }
}
