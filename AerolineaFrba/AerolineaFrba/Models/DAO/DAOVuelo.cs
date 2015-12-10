using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

using AerolineaFrba.Models;
using AerolineaFrba.Models.BO;
using AerolineaFrba.Models.Utils;
using System.Data.SqlClient;
using AerolineaFrba.Models.DataBase;
using System.Windows;

namespace AerolineaFrba.Models.DAO
{
    public partial class DAOVuelo: DAOBase<Vuelo>
    {
        public DAOVuelo()
            : base("SQLOVERS.VUELO", "vuelo_id")
        {
        }

        private string stringQuereable(string cadena)
        {
            return "'" + cadena + "'";
        }

        public bool create(Vuelo _Vuelo)
        {
            try
            {
                int bit = 0;
                string comando = "INSERT INTO SQLOVERS.VUELO(vuelo_fecha_salida, vuelo_fecha_llegada, vuelo_fecha_llegada_estimada, vuelo_aeronave_id, vuelo_ruta_id, vuelo_cancelado)"
                                    + "VALUES ({0},{1},{2},{3},{4},{5});"
                                    + "SELECT SCOPE_IDENTITY();";
                
                comando = String.Format(comando, fechaQuereable(_Vuelo.fechaSalida), fechaQuereable(_Vuelo.fechaLlegada), fechaQuereable(_Vuelo.fechaLlegada), stringQuereable(_Vuelo.aeronave),_Vuelo.ruta ,0);
                int insertado = DB.ExecuteCardinal(comando);
                return true;

            }
            catch { return false; }

        }

        public int existe_vuelo(Vuelo vuelo) {

            string comando = String.Format("select SQLOVERS.existe_vuelo({0},{1})", fechaQuereable(vuelo.fechaSalida), stringQuereable(vuelo.aeronave));
            int existe = DB.ExecuteCardinal(comando);
            return existe;

        }

        public void darBaja(int vueloId){

            List<SqlParameter> parameterList = new List<SqlParameter>();
            parameterList.Add(new SqlParameter("@vueloId", vueloId));

            DBAcess.WriteInBase("UPDATE SQLOVERS.PASAJE SET pasaje_cancelado = 1 FROM SQLOVERS.VUELO WHERE pasaje_vuelo_id = @vueloId AND vuelo_fecha_salida > GETDATE()", "T", parameterList);
            DBAcess.WriteInBase("UPDATE SQLOVERS.VUELO SET vuelo_cancelado = 1 WHERE vuelo_id = @vueloId AND vuelo_fecha_salida > GETDATE()", "T", parameterList);
        }

        public List<Vuelo> search(string matricula) {
            List<Vuelo> lc = new List<Vuelo>();

            if (String.IsNullOrEmpty(matricula)) {
                String query = String.Format("select * from sqlovers.vuelo");
                return DB.ExecuteReader<Vuelo>(query);
            }


            String base_query = String.Format("select * from sqlovers.vuelo WHERE");
            if (!String.IsNullOrEmpty(matricula))
            {
                base_query += String.Format(" vuelo_aeronave_id like '{0}%' AND vuelo_cancelado = {1}", matricula,0);
            }

            base_query = base_query.Substring(0, base_query.Length - 0);

            return DB.ExecuteReader<Vuelo>(base_query);
        }



        public int cancelarVuelo(int vuelo_id) {

            string comando = "update SQLOVERS.VUELO set vuelo_cancelado = 1 where vuelo_id= " + vuelo_id;
            int cant_filas_afectadas = DB.ExecuteNonQuery(comando);
            return cant_filas_afectadas;
        }

        public static List<Vuelo> retrieveWithOriginDestinyAndDate(Ciudad ciudadOrigen, Ciudad ciudadDestino, DateTime fechaSalida)
        {
            List<Vuelo> l = new List<Vuelo>();
            List<SqlParameter> parameterList = new List<SqlParameter>();
            parameterList.Add(new SqlParameter("@ruta_ciudad_destino_id",ciudadDestino.id));
            parameterList.Add(new SqlParameter("@ruta_ciudad_origen_id",ciudadOrigen.id));
            parameterList.Add(new SqlParameter("@vuelo_fecha_salida", fechaSalida));
            SqlDataReader lector = DBAcess.GetDataReader("SELECT * from SQLOVERS.VUELO, SQLOVERS.RUTA where vuelo_ruta_id = ruta_id and ruta_ciudad_destino = @ruta_ciudad_destino_id and ruta_ciudad_origen = @ruta_ciudad_origen_id and CAST(vuelo_fecha_salida as date) = CAST(@vuelo_fecha_salida as date)", "T", parameterList);

            if (lector.HasRows)
            {
                while (lector.Read())
                {
                    Vuelo unCliente = new Vuelo();
                    unCliente.id = (int)(decimal)lector["vuelo_id"];
                    unCliente.aeronave = (String)lector["vuelo_aeronave_id"];
                    unCliente.ruta = (int)(decimal)lector["vuelo_ruta_id"];
                    unCliente.fechaLlegada = (DateTime)lector["vuelo_fecha_llegada"];
                    unCliente.fechaLlegadaEstimada = (DateTime)lector["vuelo_fecha_llegada_estimada"];
                    unCliente.fechaSalida = (DateTime)lector["vuelo_fecha_salida"];

                    l.Add(unCliente);
                }
            }

            return l;

        }

        public static int getKgDisponibles(int vueloId)
        {
            List<SqlParameter> parameterList = new List<SqlParameter>();
            parameterList.Add(new SqlParameter("@vueloId", vueloId));
            SqlDataReader lector = DBAcess.GetDataReader("SELECT sqlovers.Cantidadkgdisponibles(@vueloId) ", "T", parameterList);

            lector.Read();

            return lector.GetInt32(0);
        }

        public static bool tieneVueloEntre(int dniCliente, DateTime fechaSalida, DateTime fechaLlegada)
        {
            List<SqlParameter> parameterList = new List<SqlParameter>();
            parameterList.Add(new SqlParameter("@dniCliente", dniCliente));
            parameterList.Add(new SqlParameter("@fechaSalida", fechaSalida));
            parameterList.Add(new SqlParameter("@fechaLlegada", fechaLlegada));
            SqlDataReader lector = DBAcess.GetDataReader("SELECT sqlovers.pasajeroYaTieneVueloEntre(@dniCliente, @fechaSalida, @fechaLlegada) ", "T", parameterList);

            lector.Read();

            return lector.GetBoolean(0);
        }

        public static List<Vuelo> retrieveAll()
        {
            SqlDataReader lector = DBAcess.GetDataReader("SELECT * from SQLOVERS.VUELO", "T", new List<SqlParameter>());
            return getVuelosFromResult(lector);
        }

        public static Vuelo getVuelo(int vueloId) {
            List<Vuelo> l = new List<Vuelo>();
            List<SqlParameter> parameterList = new List<SqlParameter>();
            parameterList.Add(new SqlParameter("@vueloId",vueloId));
            SqlDataReader lector = DBAcess.GetDataReader("SELECT * from SQLOVERS.VUELO where vuelo_id = @vueloId", "T", parameterList);

            List<Vuelo> vuelosList = getVuelosFromResult(lector);
            if (vuelosList.Count == 0)
            {
                return null;
            }
            else {
                return vuelosList[0];
            }
        }

        private static List<Vuelo> getVuelosFromResult(SqlDataReader lector)
        {
            List<Vuelo> l = new List<Vuelo>();
            if (lector.HasRows)
            {
                while (lector.Read())
                {
                    Vuelo unCliente = new Vuelo();
                    unCliente.id = (int)(decimal)lector["vuelo_id"];
                    unCliente.aeronave = (String)lector["vuelo_aeronave_id"];
                    unCliente.ruta = (int)(decimal)lector["vuelo_ruta_id"];
                    unCliente.fechaLlegada = (DateTime)lector["vuelo_fecha_llegada"];
                    unCliente.fechaLlegadaEstimada = (DateTime)lector["vuelo_fecha_llegada_estimada"];
                    unCliente.fechaSalida = (DateTime)lector["vuelo_fecha_salida"];

                    l.Add(unCliente);
                }
            }
            return l;
        }

    }
}