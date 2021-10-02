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
    public class partidaController : ControllerBase
    {

        // -------------------- POST: CREAR PARTIDA ---------------------
        #region POST: Crear Partida
        [HttpPost]
        [Route("crear")]
        public int POST([FromBody] PartidaModeloDto DatosPartida)
        {
            BaseDatos NuevaConexionBD = new BaseDatos();
            NuevaConexionBD.ObtenConexion().Open();

            int NuevaPartida = NuevaConexionBD.InsertaLosDatos(
                $"exec crearPartida '{DatosPartida.nombre}', '{DatosPartida.administrador}', '{DatosPartida.maxJugadores}', '{DatosPartida.maxTiempo}', '{DatosPartida.pass}','{DatosPartida.tablero}'");
            NuevaConexionBD.CierraConexion();

            return NuevaPartida;
        }

        #endregion FIN: Crear Partida


        // ------------------- POST: INICIAR PARTIDA --------------------
        #region POST: Iniciar Partida
        [HttpPost]
        [Route("iniciar")]
        public int POST([FromBody] int id)
        {
            BaseDatos NuevaConexionBD = new BaseDatos();
            NuevaConexionBD.ObtenConexion().Open();

            int IniciarPartida = NuevaConexionBD.InsertaLosDatos(
                $"exec ComenzarPartida '{id}'");
            NuevaConexionBD.CierraConexion();

            return IniciarPartida;
        }

        #endregion FIN: Iniciar Partida


        // --------------- GET: MOSTRAR TODOS LAS PARTIDAS ---------------
        #region GET: Mostrar Todas Las Partidas
        [HttpGet]
        [Route("partidas")]
        public IEnumerable<PartidaModeloDto> Get()
        {
            BaseDatos NuevaConexionBD = new();
            NuevaConexionBD.ObtenConexion().Open();

            List<Object[]> Partidas = NuevaConexionBD.HazLaConsulta($"exec getTableros");
            NuevaConexionBD.CierraConexion();

            return Enumerable.Range(0, Partidas.Count).Select(index => new PartidaModeloDto(Partidas[index])).ToArray();
        }
        #endregion FIN: Mostrar Todas Las Partidas


        // ------------------ GET: MOSTRAR UNA PARTIDA -------------------
        #region GET: Mostrar Una Partida
        [Route("partida")]
        [HttpGet]
        public IEnumerable<PartidaModeloDto> Get(int idPartida)
        {
            BaseDatos NuevaConexionBD = new();
            NuevaConexionBD.ObtenConexion().Open();

            List<object[]> Partida = NuevaConexionBD.HazLaConsulta($"exec getTableros '{idPartida}'");
            NuevaConexionBD.CierraConexion();

            return Enumerable.Range(0, Partida.Count).Select(index => new PartidaModeloDto(Partida[index])).ToArray();
        }
        #endregion FIN: Mostrar Una Partida
    }
}
