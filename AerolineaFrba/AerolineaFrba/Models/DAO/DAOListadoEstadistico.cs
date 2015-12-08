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
                WHERE v.vuelo_fecha_salida between CONVERT(datetime, '"+ fechaIni +"', 120)" +
                " and CONVERT(datetime, '"+ fechaFin +"', 120)" +
                @" and v.vuelo_cancelado=0 and p.pasaje_cancelado=0
                GROUP BY c.ciudad_id ORDER BY cantidad_pasajes desc";
            SqlDataReader lector = DBAcess.GetDataReader(query, "T", new List<SqlParameter>());
            DataTable dt = new DataTable("listado");
            dt.Load(lector);
            return dt;
        }
        
        

        public DataTable DestAeroMasVacias(string fechaIni, string fechaFin)
        {
            string query = @"select top 5 c.ciudad_id,
				(select c2.ciudad_nombre from SQLOVERS.CIUDAD c2 where c2.ciudad_id=c.ciudad_id) as ciudad_nombre,
				count(c.ciudad_id) as cantidad_aeronaves
                from sqlovers.CIUDAD c
                inner join SQLOVERS.LLEGADA_DESTINO l on c.ciudad_id=l.llegada_destino
                inner join SQLOVERS.RUTA r on r.ruta_ciudad_destino=l.llegada_destino
                inner join SQLOVERS.VUELO v on v.vuelo_ruta_id=r.ruta_id
                inner join SQLOVERS.PASAJE p on p.pasaje_vuelo_id=v.vuelo_id
                inner join SQLOVERS.aeronave a on a.aeronave_matricula=v.vuelo_aeronave_id
                WHERE v.vuelo_fecha_salida between CONVERT(datetime, '" + fechaIni + "', 120)" +
                " and  CONVERT(datetime, '" + fechaFin + "', 120)" +
                @" and v.vuelo_cancelado=0 and p.pasaje_cancelado=0
                GROUP BY c.ciudad_id ORDER BY cantidad_aeronaves  desc";
            SqlDataReader lector = DBAcess.GetDataReader(query, "T", new List<SqlParameter>());
            DataTable dt = new DataTable("listado");
            dt.Load(lector);
            return dt;
        }

        public DataTable CliMasPtosAcum(string fechaIni, string fechaFin)
        {
            string query = @"select c1.* from SQLOVERS.cliente c1 inner join
                            (
	                            select top 5 c.cli_dni,sum(p.pasaje_precio / 10) as puntos_acum
	                            from SQLOVERS.cliente c inner join SQLOVERS.pasaje p on p.cli_dni=c.cli_dni
	                            where p.pasaje_cancelado=0 and p.pasaje_fechacompra >= dateadd(year, -1, getdate())
	                            AND p.pasaje_fechacompra BETWEEN CONVERT(datetime, '" + fechaIni + "', 120)" +
                                    " and CONVERT(datetime, '" + fechaFin + "', 120)" +
                                     @" 
	                            group by c.cli_dni
	                            order by puntos_acum desc
                            ) as c2 on c2.cli_dni=c1.cli_dni";
            SqlDataReader lector = DBAcess.GetDataReader(query, "T", new List<SqlParameter>());
            DataTable dt = new DataTable("listado");
            dt.Load(lector);
            return dt;
        }

        public DataTable DestPasCancel(string fechaIni, string fechaFin)
        {

            string query = @"SELECT TOP 5 c.ciudad_id,
				            (SELECT c2.ciudad_nombre FROM SQLOVERS.CIUDAD c2 WHERE c2.ciudad_id=c.ciudad_id) AS ciudad_nombre,
				            COUNT(c.ciudad_id) as cantidad_pasajes
                FROM SQLOVERS.CIUDAD c
                INNER JOIN SQLOVERS.LLEGADA_DESTINO l on c.ciudad_id=l.llegada_destino
                INNER JOIN SQLOVERS.RUTA r on r.ruta_ciudad_destino=l.llegada_destino
                INNER JOIN SQLOVERS.VUELO v on v.vuelo_ruta_id=r.ruta_id
                INNER JOIN SQLOVERS.PASAJE p on p.pasaje_vuelo_id=v.vuelo_id
                WHERE p.pasaje_cancelado=1 and  v.vuelo_fecha_salida between CONVERT(datetime, '" + fechaIni + "', 120)" +
                " and CONVERT(datetime, '" + fechaFin + "', 120)" +
                " GROUP BY c.ciudad_id ORDER BY cantidad_pasajes desc";
            SqlDataReader lector = DBAcess.GetDataReader(query, "T", new List<SqlParameter>());
            DataTable dt = new DataTable("listado");
            dt.Load(lector);
            return dt;
        }

        public DataTable AeroMasCantDiaFueraServ(string fechaIni, string fechaFin)
        {
            string query = @"select a1.aeronave_matricula,a1.aeronave_modelo,a2.cant_dias from SQLOVERS.aeronave a1 inner join
                            (
	                            select top 5 a.aeronave_matricula, sum(datediff(day,b.aeronave_baja_fecha_bajatecnica, b.aeronave_baja_fecha_vueltafs)) cant_dias
	                            from SQLOVERS.aeronave a inner join SQLOVERS.AERONAVE_BAJAS b on b.aeronave_matricula=a.aeronave_matricula
	                            where b.aeronave_baja_fecha_bajatecnica >= CONVERT(datetime, '" + fechaIni + "', 120) and b.aeronave_baja_fecha_vueltafs <= CONVERT(datetime, '" + fechaFin + @"', 120)
	                            group by a.aeronave_matricula
	                            order by cant_dias desc
                            ) as a2 on a2.aeronave_matricula=a1.aeronave_matricula";
            SqlDataReader lector = DBAcess.GetDataReader(query, "T", new List<SqlParameter>());
            DataTable dt = new DataTable("listado");
            dt.Load(lector);
            return dt;
        }

    }
}
