using System;
using System.Collections.Generic;
using AerolineaFrba.Models.DataBase;
using System.Data;
using System.Data.SqlClient;

namespace AerolineaFrba.Models.DAO
{
    class DAOListadoEstadistico
    {
        public DataTable DestMasPasajComp(string fechaIni, string fechaFin)
        {
            string query = @"SELECT TOP 5 c.ciudad_id,
				            (SELECT c2.ciudad_nombre FROM SQLOVERS.CIUDAD c2 WHERE c2.ciudad_id=c.ciudad_id) AS ciudad_nombre,
				            COUNT(c.ciudad_id) as cantidad_pasajes
                FROM SQLOVERS.CIUDAD c
                INNER JOIN SQLOVERS.LLEGADA_DESTINO l on c.ciudad_id=l.llegada_destino
                INNER JOIN SQLOVERS.RUTA r on r.ruta_ciudad_destino=l.llegada_destino
                INNER JOIN SQLOVERS.VUELO v on v.vuelo_ruta_id=r.ruta_id
                INNER JOIN SQLOVERS.PASAJE p on p.pasaje_vuelo_id=v.vuelo_id
                WHERE v.vuelo_fecha_salida >= CONVERT(datetime, '"+ fechaIni +"', 120)" +
                " and v.vuelo_fecha_salida <= CONVERT(datetime, '"+ fechaFin +"', 120)" +
                " GROUP BY c.ciudad_id ORDER BY cantidad_pasajes desc";
            SqlDataReader lector = DBAcess.GetDataReader(query, "T", new List<SqlParameter>());
            DataTable dt = new DataTable("listado");
            dt.Load(lector);
            return dt;
        }
    }
}
