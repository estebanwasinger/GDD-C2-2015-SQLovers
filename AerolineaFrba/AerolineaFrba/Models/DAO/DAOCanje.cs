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
    class DAOCanje
    {
        public static bool create(Canje canje)
        {
            List<SqlParameter> parameterList = new List<SqlParameter>();
            parameterList.Add(new SqlParameter("@canje_cliente", canje.cliente));
            parameterList.Add(new SqlParameter("@canje_fecha", canje.fecha));
            parameterList.Add(new SqlParameter("@canje_producto", canje.producto));
            parameterList.Add(new SqlParameter("@canje_cantidad", canje.cantidad));

            return DBAcess.WriteInBase("INSERT INTO sqlovers.CANJE (canje_cliente, canje_fecha, canje_producto, canje_cantidad) " +
                                                " VALUES (@canje_cliente, @canje_fecha, @canje_producto, @canje_cantidad)", "T", parameterList);
        }


        public static int getMillasGastadas(int dniCliente) {
            List<SqlParameter> parameterList = new List<SqlParameter>();
            parameterList.Add(new SqlParameter("@dniCliente", dniCliente));
            SqlDataReader lector = DBAcess.GetDataReader("SELECT SUM(c.canje_cantidad * p.producto_cantMillas) FROM  SQLOVERS.CANJE c, SQLOVERS.productos p WHERE c.canje_producto = p.producto_id AND c.canje_cliente = @dniCliente", "T", parameterList);

            lector.Read();

            return lector[0] == DBNull.Value ? 0 : (int)(decimal)lector[0];
        }

        public static List<Canje> getCanjes(int dniCliente)
        {
            List<SqlParameter> parameterList = new List<SqlParameter>();
            parameterList.Add(new SqlParameter("@dniCliente", dniCliente));
            SqlDataReader lector = DBAcess.GetDataReader("  SELECT c.canje_cantidad, c.canje_cliente, c.canje_fecha, c.canje_id, c.canje_producto, p.producto_cantMillas * c.canje_cantidad AS canje_precio FROM SQLOVERS.CANJE c, SQLOVERS.productos p" +
            " WHERE c.canje_cliente=@dniCliente AND c.canje_producto = p.producto_id", "T", parameterList);

            List<Canje> compraList = new List<Canje>();
            if (lector.HasRows)
            {
                while (lector.Read())
                {
                    Canje canje = new Canje();
                    canje.producto = (int)(decimal)lector["canje_producto"];
                    canje.cliente = (int)(decimal)lector["canje_cliente"];
                    canje.fecha = (DateTime)lector["canje_fecha"];
                    canje.precio = (int)(decimal)lector["canje_precio"];
                    canje.cantidad = (int)(decimal)lector["canje_cantidad"];

                    compraList.Add(canje);
                }
            }
            return compraList;

        }
         
    }
}
