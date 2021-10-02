using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BotanapolyV1.Modelos.Dao;
using BotanapolyV1.Modelos.Dto;
using System.Net.Http;

namespace BotanapolyV1.Controllers
{
    [Route("api/v1/[controller]")]
    [ApiController]
    public class usuarioController : ControllerBase
    {

        // ------------------- POST: REGISTRO --------------------
        #region POST: Registro Usuario
        [HttpPost]
        [Route("registro")]
        public int Post([FromBody] UsuarioModeloDto DatosUsuario )
        {
            
            BaseDatos NuevaConexionBD = new();
            NuevaConexionBD.ObtenConexion().Open();

            int NuevoUsuario = NuevaConexionBD.InsertaLosDatos(
                $"exec registrar '{DatosUsuario.email}','{DatosUsuario.nick}', '{DatosUsuario.password}', '{DatosUsuario.fechaNacimiento}'");
            NuevaConexionBD.CierraConexion();

            return NuevoUsuario;
        }

        #endregion FIN: Registro Usuario


        // ------------------- GET: INICIAR SESION --------------------
        #region GET: Autenticacion Usuario
        [HttpGet]
        [Route("login")]
        public Object[] Get(string email, string pass)
        {
            BaseDatos NuevaConexionBD = new();
            NuevaConexionBD.ObtenConexion().Open();

            List<Object[]> AutenticacionUsuario = NuevaConexionBD.HazLaConsulta($"exec autenticar '{email}','{pass}'");
            NuevaConexionBD.CierraConexion();

            return AutenticacionUsuario[0];
        }
        #endregion FIN: Autenticacion Usuario









    }
}
