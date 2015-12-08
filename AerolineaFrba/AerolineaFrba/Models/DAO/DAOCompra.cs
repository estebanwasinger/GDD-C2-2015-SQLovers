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
    class DAOCompra
    {
        public static List<CompraAero> retrieveAll() {
            return null;
        }

        public static bool create(CompraAero compra){

            List<SqlParameter> parameterList = new List<SqlParameter>();
            parameterList.Add(new SqlParameter("@compra_tipo", compra.tipo));
            parameterList.Add(new SqlParameter("@compra_fecha", compra.fecha));
            parameterList.Add(new SqlParameter("@compra_cliente", compra.cliente));
            
            return DBAcess.WriteInBase("INSERT INTO sqlovers.COMPRA (compra_tipo, compra_fecha, compra_cliente) " +
                                                " VALUES (@compra_tipo, @compra_fecha, @compra_cliente)", "T", parameterList);
        
        }

        public static CompraAero getCompra(int dniCliente, DateTime fechaCompra) {
            List < SqlParameter > parameterList = new List<SqlParameter>();
            parameterList.Add(new SqlParameter("@compra_cliente", dniCliente));
            parameterList.Add(new SqlParameter("@compra_fecha", fechaCompra));
            SqlDataReader lector = DBAcess.GetDataReader("SELECT * from SQLOVERS.COMPRA WHERE compra_cliente=@compra_cliente AND compra_fecha=@compra_fecha", "T", parameterList);
            List<CompraAero> compraList = getCompraList(lector);

            if (compraList.Count > 0) { return compraList[0]; } else { return null; }
        }

        private static List<CompraAero> getCompraList(SqlDataReader lector)
        {

            List<CompraAero> compraList = new List<CompraAero>();
            if (lector.HasRows)
            {
                while (lector.Read())
                {
                    CompraAero compra = new CompraAero();
                    compra.id = (int)(decimal)lector["compra_id"];
                    compra.cliente = (int)(decimal)lector["compra_cliente"];
                    compra.fecha = (DateTime)lector["compra_fecha"];
                    compra.tipo = (string)lector["compra_tipo"];

                    compraList.Add(compra);
                }
            }
            return compraList;
        }
    }
}
