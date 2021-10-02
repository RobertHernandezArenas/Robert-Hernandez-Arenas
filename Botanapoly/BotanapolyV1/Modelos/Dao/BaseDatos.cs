using System;
using System.Collections.Generic;
using System.Data;
using Microsoft.Data.SqlClient;


namespace BotanapolyV1.Modelos.Dao
{
    public class BaseDatos
    {
        /* Sumario
         1# - Obtener conexión a la bd
         2# - Cerrar conexión bd
         3# - Insertar datos a la bd
         4# - Hacer consultas a la bd
         
         */
        public SqlConnection conexion;

        #region 1# Obtener Conexion
        public SqlConnection ObtenConexion()
        {
            conexion = new SqlConnection("" +
                "Server=tcp:localhost;" +
                "Database=botanapoly;" +
                "User ID=cr7;" +
                "Password=agua;" +
                "Encrypt=True;" +
                "TrustServerCertificate=true;" +
                "Connection Timeout=30;");

            return conexion;
        }
        #endregion FIN Obtener Conexion

        #region 2# Cerrar Conexion
        public void CierraConexion()
        {
            conexion.Close();
        }
        #endregion FIN Cerrar Conexion

        #region 3# Insertar Datos 
        public int InsertaLosDatos(String comando)
        {
            SqlCommand command = new();
            {
                command.Connection = conexion;
                command.CommandType = CommandType.Text;
                command.CommandText = comando;
            }

            return command.ExecuteNonQuery();
        }
        #endregion FIN Insertar Datos 

        #region 4# Hacer Consulta
        public List<object[]> HazLaConsulta(string comando)
        {
            List<object[]> objeto = new();

            SqlCommand command = new();
            {
                command.Connection = conexion;
                command.CommandType = CommandType.Text;
                command.CommandText = comando;

                // Mete contenido en el array
                SqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    object[] values = new object[reader.FieldCount];
                    reader.GetValues(values);

                    objeto.Add(values);
                }
            }

            return objeto;
        }
        #endregion FIN Hacer Consulta
    }
}
