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
    }
}
