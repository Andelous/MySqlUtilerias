using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MySqlUtilerias.DataSource
{
    /// <summary>
    /// Crea una instancia de MySqlDataSource para el entorno especificado.
    /// </summary>
    public class MySqlDataSourceGeneric : IMySqlDataSource
    {
        // Private properties
        private string host { get; set; }
        private uint puerto { get; set; }
        private string usuario { get; set; }
        private string contrasena { get; set; }
        private string db { get; set; }

        private MySqlConnectionStringBuilder csb { get; set; }
        
        private MySqlCommand instruccion { get; set; }
        private MySqlConnection conexion { get; set; }
        
        /// <summary>
        /// Crea una instancia de MySqlDataSource que se conectará al host especificado, y trabajará sobre la base de datos especificada.
        /// </summary>
        /// <param name="host">Host de conexión.</param>
        /// <param name="puerto">Puerto de MySQL.</param>
        /// <param name="usuario">Usuario del host.</param>
        /// <param name="contrasena">Contraseña del usuario.</param>
        /// <param name="db">Nombre de la base de datos a trabajar.</param>
        public MySqlDataSourceGeneric(string host, uint puerto, string usuario, string contrasena, string db)
        {
            this.host = host;
            this.puerto = puerto;
            this.usuario = usuario;
            this.contrasena = contrasena;
            this.db = db;

            csb = new MySqlConnectionStringBuilder();

            csb.Server = host;
            csb.Port = puerto;
            csb.UserID = usuario;
            csb.Password = contrasena;
            csb.Database = db;
        }

        /// <summary>
        /// Devuelve el ultimo ID insertado por este MySqlDataSource.
        /// </summary>
        public long ultimoIDInsertado
        {
            get
            {
                return instruccion.LastInsertedId;
            }
        }

        /// <summary>
        /// Abre la conexion de este MySqlDataSource.
        /// </summary>
        public void abrirConexion()
        {
            if (conexion != null) { conexion.Close(); }
            else { conexion = new MySqlConnection(csb.ToString()); }

            conexion.Open();
            instruccion = conexion.CreateCommand();
        }

        /// <summary>
        /// Cierra la conexion de este MySqlDataSource.
        /// </summary>
        public void cerrarConexion()
        {
            if (conexion != null) { conexion.Close(); }
        }

        /// <summary>
        /// Ejecuta la consulta a la base de datos predeterminada y devuelve un MySqlDataReader.
        /// </summary>
        /// <param name="query">Consulta que se ejecutara.</param>
        /// <returns>MySqlDataReader vinculado a los resultados de la consulta.</returns>
        public MySqlDataReader ejecutarConsulta(string query)
        {
            MySqlDataReader dr = null;

            abrirConexion();

            instruccion.CommandText = query;
            dr = instruccion.ExecuteReader();

            return dr;
        }

        /// <summary>
        /// Ejecuta la consulta a la base de datos predeterminada y devuelve el numero de filas afectadas.
        /// </summary>
        /// <param name="query">Actualización que se ejecutara.</param>
        /// <returns>Numero de filas afectadas.</returns>
        public int ejecutarActualizacion(string query)
        {
            int filasAfectadas = 0;

            abrirConexion();

            instruccion.CommandText = query;
            filasAfectadas = instruccion.ExecuteNonQuery();

            return filasAfectadas;
        }
    }
}
