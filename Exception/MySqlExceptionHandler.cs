using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MySqlUtilerias.Exception
{
    /// <summary>
    /// Clase de uso static que provee herramientas para el manejo de MySqlExceptions.
    /// </summary>
    public class MySqlExceptionHandler
    {
        /// <summary>
        /// Devuelve el tipo de error, basandonos en el numero de error del servidor.
        /// </summary>
        /// <param name="e">Excepcion a analizar.</param>
        /// <returns>Devuelve el tipo de error del lado del servidor.</returns>
        public static TipoError obtenerTipoError(MySqlException e)
        {
            switch (e.Number)
            {
                // Sintaxis SQL o Permisos
                case 1044:
                case 1049:
                case 1050:
                case 1051:
                case 1054:
                case 1055:
                case 1056:
                case 1057:
                case 1059:
                case 1060:
                case 1061:
                case 1063:
                case 1064:
                case 1065:
                case 1066:
                case 1067:
                case 1068:
                case 1069:
                case 1070:
                case 1071:
                case 1072:
                case 1073:
                case 1074:
                case 1075:
                case 1082:
                case 1083:
                case 1084:
                case 1090:
                case 1091:
                case 1101:
                case 1102:
                case 1103:
                case 1104:
                case 1106:
                case 1107:
                case 1109:
                case 1110:
                case 1112:
                case 1113:
                case 1115:
                case 1118:
                case 1120:
                case 1121:
                case 1131:
                case 1132:
                case 1133:
                case 1139:
                case 1140:
                case 1141:
                case 1142:
                case 1143:
                case 1144:
                case 1145:
                case 1146:
                case 1147:
                case 1148:
                case 1149:
                case 1162:
                case 1163:
                case 1164:
                case 1166:
                case 1167:
                case 1170:
                case 1171:
                case 1172:
                case 1173:
                case 1176:
                case 1177:
                case 1178:
                case 1203:
                case 1211:
                case 1226:
                case 1227:
                case 1230:
                case 1231:
                case 1232:
                case 1234:
                case 1235:
                case 1239:
                case 1247:
                case 1248:
                case 1250:
                case 1252:
                case 1253:
                case 1280:
                case 1281:
                case 1286:
                case 1304:
                case 1305:
                case 1308:
                case 1309:
                case 1310:
                case 1313:
                case 1315:
                case 1316:
                case 1318:
                case 1319:
                case 1320:
                case 1322:
                case 1323:
                case 1324:
                case 1327:
                case 1330:
                case 1331:
                case 1332:
                case 1333:
                case 1337:
                case 1338:
                case 1370:
                case 1403:
                case 1407:
                case 1410:
                case 1413:
                case 1414:
                case 1425:
                case 1426:
                case 1427:
                case 1437:
                case 1439:
                case 1453:
                case 1458:
                case 1460:
                case 1461:
                case 1463:
                case 1582:
                case 1583:
                case 1584:
                case 1630:
                case 1641:
                case 1687:
                case 1701:
                case 3057:
                case 3061:
                case 3119:
                case 3131:
                case 3143:
                case 3148:
                case 3149:
                case 3152:
                case 3153:
                case 3154:
                case 3165:
                    return TipoError.ErrorAcceso_SintaxisSQL;

                // Error de conexion con el servidor
                case 1040:
                case 1042:
                case 1043:
                case 1047:
                case 1053:
                case 1080:
                case 1081:
                case 1152:
                case 1153:
                case 1154:
                case 1155:
                case 1156:
                case 1157:
                case 1158:
                case 1159:
                case 1160:
                case 1161:
                case 1184:
                case 1189:
                case 1190:
                case 1218:
                case 1251:
                case 3068:
                    return TipoError.ErrorConexionServidor;

                // Error desconocido en el servidor
                case 1105:
                    return TipoError.ErrorDesconocido;

                // Error ajeno a MySql
                case 0:
                    return TipoError.ErrorAjenoMySql;

                // Error en el servidor
                default:
                    return TipoError.ErrorEnServidor;
            }
        }
    }
}
