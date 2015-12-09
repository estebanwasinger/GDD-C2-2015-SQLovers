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
        public static bool create(Millas millas)
        {

            List<SqlParameter> parameterList = new List<SqlParameter>();
            parameterList.Add(new SqlParameter("@millas_pasaje_id", millas.pasaje.Equals(0) ? (object)DBNull.Value : millas.pasaje));
            parameterList.Add(new SqlParameter("@millas_encomienda_id", millas.encomienda.Equals(0) ? (object)DBNull.Value : millas.encomienda));
            parameterList.Add(new SqlParameter("@millas_cliente", millas.cliente));
            parameterList.Add(new SqlParameter("@millas_cantidad", millas.cantidad));
            parameterList.Add(new SqlParameter("@millas_fecha", millas.fecha));


            return DBAcess.WriteInBase("INSERT INTO sqlovers.MILLAS (millas_pasaje_id, millas_encomienda_id, millas_cliente, millas_cantidad, millas_fecha) " +
                                                " VALUES (@millas_pasaje_id, @millas_encomienda_id, @millas_cliente, @millas_cantidad, @millas_fecha)", "T", parameterList);

        }

        public static int getMillasTotalesDeCliente(int dniCliente) {
            List<SqlParameter> parameterList = new List<SqlParameter>();
            parameterList.Add(new SqlParameter("@dniCliente", dniCliente));
            SqlDataReader lector = DBAcess.GetDataReader("SELECT SUM(millas_cantidad) FROM SQLOVERS.MILLAS WHERE millas_cliente = @dniCliente AND millas_fecha > DATEADD(Year,-1,GETDATE()) ", "T", parameterList);

            lector.Read();

            return lector[0] == DBNull.Value ? 0 : (int)(decimal)lector[0];
        }

        public static List<Millas> getMillasDeCliente(int dniCliente)
        {
            List<SqlParameter> parameterList = new List<SqlParameter>();
            parameterList.Add(new SqlParameter("@dniCliente", dniCliente));
            SqlDataReader lector = DBAcess.GetDataReader("SELECT * FROM SQLOVERS.MILLAS WHERE millas_cliente = @dniCliente AND millas_fecha > DATEADD(Year,-1,GETDATE()) ", "T", parameterList);

            List<Millas> compraList = new List<Millas>();
            if (lector.HasRows)
            {
                while (lector.Read())
                {
                    Millas compra = new Millas();
                    compra.id = (int)(decimal)lector["millas_id"];
                    compra.cliente = (int)(decimal)lector["millas_cliente"];
                    compra.fecha = (DateTime)lector["millas_fecha"];
                    compra.encomienda = lector["millas_encomienda_id"] == DBNull.Value ? 0 : (int)(decimal)lector["millas_encomienda_id"];
                    compra.pasaje = lector["millas_pasaje_id"] == DBNull.Value ? 0 : (int)(decimal)lector["millas_pasaje_id"];
                    compra.cantidad = (int)(decimal)lector["millas_cantidad"];

                    compraList.Add(compra);
                }
            }
            return compraList;

        }

    }
}
