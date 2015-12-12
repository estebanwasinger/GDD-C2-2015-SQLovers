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
    class DAOPasaje : DAOBase<Pasaje>
    {

        public DAOPasaje()
            : base("SQLOVERS.PASAJE", "pasaje_codigo")
        {
        }

        private string stringQuereable(string cadena)
        {
            return "'" + cadena + "'";
        }

        public static bool create(Pasaje pasaje){
            List<SqlParameter> parameterList = new List<SqlParameter>();
            parameterList.Add(new SqlParameter("@pasaje_vuelo_id", pasaje.vuelo.id));
            parameterList.Add(new SqlParameter("@pasaje_cliente_id", pasaje.usuario.id));
            parameterList.Add(new SqlParameter("@pasaje_precio", pasaje.precio));
            parameterList.Add(new SqlParameter("@pasaje_butaca_nro", pasaje.butaca.numero));
            parameterList.Add(new SqlParameter("@pasaje_fechacompra", pasaje.fechaCompra));
            parameterList.Add(new SqlParameter("@pasaje_compra_id", pasaje.compraId));
            return DBAcess.WriteInBase("INSERT INTO sqlovers.PASAJE (pasaje_vuelo_id, pasaje_cliente_id, pasaje_fechacompra, pasaje_precio, pasaje_butaca_nro, pasaje_cancelado, pasaje_compra_id) " +
                                                " VALUES (@pasaje_vuelo_id, @pasaje_cliente_id, @pasaje_fechacompra, @pasaje_precio, @pasaje_butaca_nro, 0, @pasaje_compra_id)", "T", parameterList);
        }



        public List<Pasaje> getPasajes()
        {

//          string comando = String.Format("select pasaje_codigo, cli_dni from sqlovers.pasaje");
            string comando = String.Format("select * from sqlovers.pasaje");

            List<Pasaje> LPasajes = DB.ExecuteReader<Pasaje>(comando);

            return LPasajes;
        }

        public List<Pasaje> buscarPasaje(string codigoCompra)
        {
            string comando = String.Format("select * from sqlovers.pasaje where pasaje_compra_id = {0}", codigoCompra);

            List<Pasaje> LPasajes = DB.ExecuteReader<Pasaje>(comando);

            return LPasajes;
        }
            
        internal static List<Pasaje> getFromVuelo(int vueloId)
        {
            List<SqlParameter> parameterList = new List<SqlParameter>();
            parameterList.Add(new SqlParameter("@vueloId", vueloId));
            SqlDataReader lector = DBAcess.GetDataReader("SELECT * FROM SQLOVERS.PASAJE WHERE pasaje_vuelo_id = @vueloId", "T", parameterList);
            return createPasajeListFromQuery(lector);
        }

        public static List<Pasaje> retrieveAll()
        {
            SqlDataReader lector = DBAcess.GetDataReader("SELECT * from SQLOVERS.PASAJE", "T", new List<SqlParameter>());
            return createPasajeListFromQuery(lector);
        }

        private static List<Pasaje> createPasajeListFromQuery(SqlDataReader lector)
        {
            List<Pasaje> clienteList = new List<Pasaje>();
            if (lector.HasRows)
            {
                while (lector.Read())
                {
                    Pasaje pasaje = new Pasaje();
                    pasaje.codigo = (int)(decimal)lector["pasaje_codigo"];
                    pasaje.cancelado = (bool)lector["pasaje_cancelado"];
                   // pasaje.butaca = (int)lector["cli_apellido"];
                    pasaje.compraId = (int)(lector["pasaje_compra_id"] == DBNull.Value ? 0 : lector["pasaje_compra_id"]);
                    pasaje.fechaCompra = (DateTime)lector["pasaje_fechacompra"];
                    pasaje.precio = (float)(decimal)lector["pasaje_precio"];
                    pasaje.usuario = DAOCliente.getClienteWithID((int)(decimal)lector["pasaje_cliente_id"]);
                    //pasaje.vuelo = DAOVuelo.getVuelo();

                    clienteList.Add(pasaje);
                }
            }
            return clienteList;

        }
    }
}
