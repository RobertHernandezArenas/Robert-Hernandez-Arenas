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
    public class casillaController : Controller
    {
        // ------------------- GET: MOSTRAR INFO CASILLA(null, idCasilla), CASILLA EN EL TABLERO (idTablero, null) --------------------
        #region GET: Mostrar info Jugadores
        [Route("/")]
        [HttpGet]
        public IEnumerable<CasillaModelosDto> GET(int idTablero,int idCasilla)
        {
            try {
                BaseDatos NuevaConexionBD = new();
                NuevaConexionBD.ObtenConexion().Open();

                List<object[]> InfoCasilla = NuevaConexionBD.HazLaConsulta($"exec getCasillas '{idTablero}', '{idTablero}'");
                NuevaConexionBD.CierraConexion();

                return Enumerable.Range(0, InfoCasilla.Count).Select(index => new CasillaModelosDto(InfoCasilla[index])).ToArray();

            }
            catch(Exception)
            {
                throw;
            }
        }
        #endregion FIN: Mostrar Tableros
    }
}
