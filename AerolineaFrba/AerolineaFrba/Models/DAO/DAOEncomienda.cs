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
                sqlCommand.Parameters.AddWithValue("@dni_cliente", encomienda.dniCliente);
                sqlCommand.Parameters.AddWithValue("@compraId", encomienda.compraId);
                sqlCommand.CommandText = "INSERT INTO SQLOVERS.ENCOMIENDA (encomienda_kg, encomienda_cliente_dni, encomienda_vuelo_id, encomienda_precio_total, encomienda_compra_id) VALUES "
                    +"(@kg, @dni_cliente, @vuelo_id, @precio_total, @compraId)";
                sqlCommand.ExecuteNonQuery();

                return true;
            }
            catch { return false; }
        }

        public List<Encomienda> getEncomienda()
        {

            string comando = String.Format("select encomienda_id, encomienda_cliente_dni from sqlovers.encomienda");

            List<Encomienda> LEncomiendas = DB.ExecuteReader<Encomienda>(comando);

            return LEncomiendas;
        }

        public List<Encomienda> buscarEncomienda(string codigoEncomienda)
        {

            string comando = String.Format("select encomienda_id, encomienda_cliente_dni  from sqlovers.ENCOMIENDA where encomienda_id ={0}", codigoEncomienda);

            List<Encomienda> Lenco = DB.ExecuteReader<Encomienda>(comando);

            return Lenco;
        }


    }
}
