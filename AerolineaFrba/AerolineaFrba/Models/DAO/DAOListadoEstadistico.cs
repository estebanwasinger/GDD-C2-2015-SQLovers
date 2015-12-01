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
                @" and v.vuelo_cancelado=0
                GROUP BY c.ciudad_id ORDER BY cantidad_pasajes desc";
            SqlDataReader lector = DBAcess.GetDataReader(query, "T", new List<SqlParameter>());
            DataTable dt = new DataTable("listado");
            dt.Load(lector);
            return dt;
        }
        
        

        public DataTable DestAeroMasVacias(string fechaIni, string fechaFin)
        {
            //agregar filtro pasajes no cancelados
            string query = @"select top 5 c.ciudad_id,
				(select c2.ciudad_nombre from SQLOVERS.CIUDAD c2 where c2.ciudad_id=c.ciudad_id) as ciudad_nombre,
				count(c.ciudad_id) as cantidad_aeronaves
                from sqlovers.CIUDAD c
                inner join SQLOVERS.LLEGADA_DESTINO l on c.ciudad_id=l.llegada_destino
                inner join SQLOVERS.RUTA r on r.ruta_ciudad_destino=l.llegada_destino
                inner join SQLOVERS.VUELO v on v.vuelo_ruta_id=r.ruta_id
                inner join SQLOVERS.PASAJE p on p.pasaje_vuelo_id=v.vuelo_id
                inner join SQLOVERS.aeronave a on a.aeronave_matricula=v.vuelo_aeronave_id
                WHERE v.vuelo_fecha_salida >= CONVERT(datetime, '" + fechaIni + "', 120)" +
                " and v.vuelo_fecha_salida <= CONVERT(datetime, '" + fechaFin + "', 120)" +
                @" and v.vuelo_cancelado=0
                GROUP BY c.ciudad_id ORDER BY cantidad_pasajes desc";
            SqlDataReader lector = DBAcess.GetDataReader(query, "T", new List<SqlParameter>());
            DataTable dt = new DataTable("listado");
            dt.Load(lector);
            return dt;
        }

        public DataTable CliMasPtosAcum()
        {
            //agregar filtro pasajes no cancelados
            string query = @"select c1.* from SQLOVERS.cliente c1 inner join
                            (
	                            select top 5 c.cli_dni,sum(p.pasaje_precio / 10) as puntos_acum
	                            from SQLOVERS.cliente c inner join SQLOVERS.pasaje p on p.cli_dni=c.cli_dni
	                            where p.pasaje_fechacompra >= dateadd(year, -1, getdate())
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
            //TO-DO
            string query = @"SELECT TOP 5 c.ciudad_id,
				            (SELECT c2.ciudad_nombre FROM SQLOVERS.CIUDAD c2 WHERE c2.ciudad_id=c.ciudad_id) AS ciudad_nombre,
				            COUNT(c.ciudad_id) as cantidad_pasajes
                FROM SQLOVERS.CIUDAD c
                INNER JOIN SQLOVERS.LLEGADA_DESTINO l on c.ciudad_id=l.llegada_destino
                INNER JOIN SQLOVERS.RUTA r on r.ruta_ciudad_destino=l.llegada_destino
                INNER JOIN SQLOVERS.VUELO v on v.vuelo_ruta_id=r.ruta_id
                INNER JOIN SQLOVERS.PASAJE p on p.pasaje_vuelo_id=v.vuelo_id
                WHERE v.vuelo_fecha_salida >= CONVERT(datetime, '" + fechaIni + "', 120)" +
                " and v.vuelo_fecha_salida <= CONVERT(datetime, '" + fechaFin + "', 120)" +
                " GROUP BY c.ciudad_id ORDER BY cantidad_pasajes desc";
            SqlDataReader lector = DBAcess.GetDataReader(query, "T", new List<SqlParameter>());
            DataTable dt = new DataTable("listado");
            dt.Load(lector);
            return dt;
        }

        public DataTable AeroMasCantDiaFueraServ(string fechaIni, string fechaFin)
        {
            string query = @"select top 5 a.aeronave_matricula,a.aeronave_modelo,a.aeronave_fabricante,a.aeronave_fecha_vueltafs,
			                            datediff(day,v.vuelo_fecha_llegada, a.aeronave_fecha_vueltafs) cant_dias
                            from SQLOVERS.aeronave a
                            inner join SQLOVERS.vuelo v on v.vuelo_aeronave_id=a.aeronave_matricula
                            where v.vuelo_cancelado=0
		                            and v.vuelo_fecha_llegada < a.aeronave_fecha_vueltafs
		                            and v.vuelo_id=(SELECT top 1 v2.vuelo_id
						                            from SQLOVERS.vuelo v2
						                            where v2.vuelo_aeronave_id=a.aeronave_matricula
						                            and v.vuelo_fecha_llegada < a.aeronave_fecha_vueltafs
						                            order by v2.vuelo_fecha_llegada desc
						                            )
                            order by cant_dias desc";
            SqlDataReader lector = DBAcess.GetDataReader(query, "T", new List<SqlParameter>());
            DataTable dt = new DataTable("listado");
            dt.Load(lector);
            return dt;
        }

    }
}
