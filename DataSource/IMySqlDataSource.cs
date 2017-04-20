using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MySqlUtilerias.DataSource
{
    /// <summary>
    /// Interfaz que determina las funciones de un MySqlDataSource.
    /// </summary>
    public interface IMySqlDataSource
    {
        /// <summary>
        /// Devolvera el ID del ultimo registro insertado por este MySqlDataSource.
        /// </summary>
        long ultimoIDInsertado { get; }

        /// <summary>
        /// Abre la conexion de este MySqlDataSource.
        /// </summary>
        /// <exception cref="MySqlException"></exception>
        /// <exception cref="InvalidOperationException"></exception>
        void abrirConexion();

        /// <summary>
        /// Cierra la conexion de este MySqlDataSource
        /// </summary>
        void cerrarConexion();

        /// <summary>
        /// Ejecuta la consulta a la base de datos y devuelve un MySqlDataReader.
        /// </summary>
        /// <param name="query">Consulta que se ejecutara.</param>
        /// <returns>Devuelve un MySqlDataReader vinculado a los resultados de la consulta.</returns>
        MySqlDataReader ejecutarConsulta(string query);

        /// <summary>
        /// Ejecuta la consulta a la base de datos predeterminada y devuelve el numero de filas afectadas.
        /// </summary>
        /// <param name="query">Actualización que se ejecutara.</param>
        /// <returns>Numero de filas afectadas.</returns>
        int ejecutarActualizacion(string query);
    }
}
