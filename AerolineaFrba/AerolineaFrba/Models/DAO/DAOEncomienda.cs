using AerolineaFrba.Models.BO;
using AerolineaFrba.Models.DataBase;
using AerolineaFrba.Models.Utils;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AerolineaFrba.Models.DAO
{
    class DAOEncomienda : DAOBase<Encomienda>
    {

        public DAOEncomienda()
            : base("SQLOVERS.ENCOMIENDA", "encomienda_id")
        {
        }

        private string stringQuereable(string cadena)
        {
            return "'" + cadena + "'";
        }


        public static bool create(Encomienda encomienda)
        {
            try
            {
                List<SqlParameter> listaParametros = new List<SqlParameter>();

                SqlCommand sqlCommand = new SqlCommand();
                sqlCommand.Connection = DBAcess.GetConnection();
                sqlCommand.Parameters.AddWithValue("@vuelo_id", encomienda.vueloId);
                sqlCommand.Parameters.AddWithValue("@precio_total", encomienda.precioTotal);
                sqlCommand.Parameters.AddWithValue("@kg", encomienda.kg);
                sqlCommand.Parameters.AddWithValue("@encomienda_cliente_id", encomienda.idCliente);
                sqlCommand.Parameters.AddWithValue("@compraId", encomienda.compraId);
                sqlCommand.CommandText = "INSERT INTO SQLOVERS.ENCOMIENDA (encomienda_kg, encomienda_cliente_id, encomienda_vuelo_id, encomienda_precio_total, encomienda_compra_id) VALUES "
                    + "(@kg, @encomienda_cliente_id, @vuelo_id, @precio_total, @compraId)";
                sqlCommand.ExecuteNonQuery();

                return true;
            }
            catch { return false; }
        }


        public List<Encomienda> getEncomienda()
        {

            //string comando = String.Format("select encomienda_id, encomienda_cliente_dni from sqlovers.encomienda");
            string comando = String.Format("select * from sqlovers.encomienda");
            List<Encomienda> LEncomiendas = DB.ExecuteReader<Encomienda>(comando);

            return LEncomiendas;
        }

        public List<Encomienda> buscarEncomienda(string codigoCompra)
        {

            string comando = String.Format("select *  from sqlovers.ENCOMIENDA where encomienda_compra_id ={0}", codigoCompra);

            List<Encomienda> Lenco = DB.ExecuteReader<Encomienda>(comando);

            return Lenco;
        }



        internal static List<Encomienda> getFromVuelo(int vueloId)
        {
            List<SqlParameter> parameterList = new List<SqlParameter>();
            parameterList.Add(new SqlParameter("@vueloId", vueloId));
            SqlDataReader lector = DBAcess.GetDataReader("SELECT * FROM SQLOVERS.Encomienda WHERE encomienda_vuelo_id = @vueloId", "T", parameterList);
            return createEncomiendaListFromQuery(lector);
        }

        public static List<Encomienda> retrieveAll()
        {
            SqlDataReader lector = DBAcess.GetDataReader("SELECT * from SQLOVERS.Encomienda", "T", new List<SqlParameter>());
            return createEncomiendaListFromQuery(lector);
        }

        private static List<Encomienda> createEncomiendaListFromQuery(SqlDataReader lector)
        {
            List<Encomienda> clienteList = new List<Encomienda>();
            if (lector.HasRows)
            {
                while (lector.Read())
                {
                    Encomienda encomienda = new Encomienda();
                    encomienda.id = (int)lector["encomienda_id"];
                    encomienda.cancelado = (bool)lector["encomienda_cancelado"];
                    // pasaje.butaca = (int)lector["cli_apellido"];
                    encomienda.compraId = (int)(lector["encomienda_compra_id"] == DBNull.Value ? 0 : lector["encomienda_compra_id"]);
                    encomienda.precioTotal = (int)lector["encomienda_precio_total"];
                    encomienda.vueloId = (int)(decimal)lector["encomienda_vuelo_id"];
                    encomienda.idCliente = (int)(decimal)lector["encomienda_cliente_id"];
                    //pasaje.vuelo = DAOVuelo.getVuelo();

                    clienteList.Add(encomienda);
                }
            }
            return clienteList;
        }


    }
}
