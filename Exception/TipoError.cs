using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MySqlUtilerias.Exception
{
    /// <summary>
    /// Enumeracion que contiene los errores mas comunes del lado del servidor MySql.
    /// </summary>
    public enum TipoError
    {
        /// <summary>
        /// No fue posible conectar al servidor.
        /// </summary>
        ErrorConexionServidor,

        /// <summary>
        /// Se desconoce el la causa del error.
        /// </summary>
        ErrorDesconocido,

        /// <summary>
        /// Error durante el procesamiento de solicitud.
        /// </summary>
        ErrorEnServidor,

        /// <summary>
        /// Error de acceso (permisos) o de sintaxis SQL.
        /// </summary>
        ErrorAcceso_SintaxisSQL,

        /// <summary>
        /// El error no ocurrio en el servidor.
        /// </summary>
        ErrorAjenoMySql
    }
}
