using AerolineaFrba.Models.BO;
using AerolineaFrba.Models.DataBase;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AerolineaFrba.Models.DAO
{
    class DAOMillas
    {
        public static int getMillasTotalesDeCliente(int idCliente)
        {

            int millasPasajes;
            int millasEncomiendas;

            List<SqlParameter> parameterList = new List<SqlParameter>();
            parameterList.Add(new SqlParameter("@idCliente", idCliente));
            SqlDataReader lector = DBAcess.GetDataReader("SELECT ISNULL(SUM(CEILING(p.pasaje_precio / 10)),0) FROM SQLOVERS.PASAJE p, SQLOVERS.VUELO v WHERE p.pasaje_cliente_id = @idCliente AND p.pasaje_vuelo_id = v.vuelo_id AND v.vuelo_fecha_llegada >= DATEADD(Year,-1,GETDATE())", "T", parameterList);
            lector.Read();
            millasPasajes = (int)(decimal)lector[0];

            parameterList = new List<SqlParameter>();
            parameterList.Add(new SqlParameter("@idCliente", idCliente));
            lector = DBAcess.GetDataReader("SELECT ISNULL(SUM(CEILING(p.encomienda_precio_total / 10)),0) FROM SQLOVERS.ENCOMIENDA p, SQLOVERS.VUELO v WHERE p.encomienda_cliente_id = @idCliente AND p.encomienda_vuelo_id = v.vuelo_id AND v.vuelo_fecha_llegada >= DATEADD(Year,-1,GETDATE())", "T", parameterList);
            lector.Read();
            millasEncomiendas = (int)lector[0];

            return millasPasajes + millasEncomiendas;
        }

        public static List<Tuple<int, int>> getPasajesConMillas(int idCliente)
        {
            List<Tuple<int, int>> list = new List<Tuple<int, int>>();
            List<SqlParameter> parameterList = new List<SqlParameter>();
            parameterList.Add(new SqlParameter("@idCliente", idCliente));
            SqlDataReader lector = DBAcess.GetDataReader("SELECT p.pasaje_codigo, CEILING(p.pasaje_precio / 10) FROM SQLOVERS.PASAJE p, SQLOVERS.VUELO v WHERE p.pasaje_cliente_id = @idCliente AND p.pasaje_vuelo_id = v.vuelo_id AND v.vuelo_fecha_llegada >= DATEADD(Year,-1,GETDATE())", "T", parameterList);
            if (lector.HasRows)
            {
                while (lector.Read())
                {
                    list.Add(new Tuple<int, int>((int)(decimal)lector[0], (int)(decimal)lector[1]));
                }
            }
            return list;
        }

        public static List<Tuple<int, int>> getEncomiendasConMillas(int idCliente)
        {
            List<Tuple<int, int>> list = new List<Tuple<int, int>>();
            List<SqlParameter> parameterList = new List<SqlParameter>();
            parameterList.Add(new SqlParameter("@idCliente", idCliente));
            SqlDataReader lector = DBAcess.GetDataReader("SELECT p.encomienda_id, CEILING(p.encomienda_precio_total / 10) FROM SQLOVERS.ENCOMIENDA p, SQLOVERS.VUELO v WHERE p.encomienda_cliente_id = @idCliente AND p.encomienda_vuelo_id = v.vuelo_id AND v.vuelo_fecha_llegada >= DATEADD(Year,-1,GETDATE())", "T", parameterList);
            if (lector.HasRows)
            {
                while (lector.Read())
                {
                    list.Add(new Tuple<int, int>(lector.GetInt32(0), lector.GetInt32(1)));
                }
            }
            return list;
        }
    }
}
