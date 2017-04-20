using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MySqlUtilerias
{
    public class MySqlExceptionHandler
    {
        public static TipoExcepcion obtenerTipoExcepcion(MySqlException e)
        {
            switch (e.Number)
            {

                default:
                    return TipoExcepcion.ErrorEnServidor;
            }
        }
    }
}
