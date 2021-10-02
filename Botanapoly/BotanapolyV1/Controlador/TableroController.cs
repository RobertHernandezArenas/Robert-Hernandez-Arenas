using Microsoft.AspNetCore.Http;
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
    public class tableroController : ControllerBase
    {

        // ------------------- GET: MOSTRAR TODOS LOS TABLEROS --------------------
        #region GET: Mostrar Todos Los Tableros
        [HttpGet]
        [Route("tableros")]
        public IEnumerable<TableroModeloDto> Get()
        {
            BaseDatos NuevaConexionBD = new();
            NuevaConexionBD.ObtenConexion().Open();

            List<Object[]> Tableros = NuevaConexionBD.HazLaConsulta($"exec getTableros");
            NuevaConexionBD.CierraConexion();

            return Enumerable.Range(0, Tableros.Count).Select(index => new TableroModeloDto(Tableros[index])).ToArray();
        }
        #endregion FIN: Mostrar Tableros


        // ------------------- GET: MOSTRAR UN TABLERO --------------------
        #region GET: Mostrar UN Tablero
        [Route("tablero")]
        [HttpGet]
        public IEnumerable<CasillaModelosDto> GET(int idTablero)
        {
            BaseDatos NuevaConexionBD = new();
            NuevaConexionBD.ObtenConexion().Open();

            List<object[]> Tablero = NuevaConexionBD.HazLaConsulta($"exec getTableros '{idTablero}'");
            NuevaConexionBD.CierraConexion();

            return Enumerable.Range(0, Tablero.Count).Select(index => new CasillaModelosDto(Tablero[index])).ToArray();
        }
        #endregion FIN: Mostrar Tableros

    }
}
