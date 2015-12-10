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
    class DAOButaca
    {
        public static List<Butaca> getButacasDisponibles(Int32 vueloId)
        {
            List<Butaca> butacaList = new List<Butaca>();
            List<SqlParameter> parameterList = new List<SqlParameter>();
            parameterList.Add(new SqlParameter("@vueloId",vueloId));
            SqlDataReader lector = DBAcess.GetDataReader("SELECT * FROM SQLOVERS.Butacasdisponibles(@vueloId)", "T", parameterList);

            if (lector.HasRows)
            {
                while (lector.Read())
                {
                    Butaca butaca = new Butaca();
                    butaca.numero = (int)(decimal)lector["butaca_nro"];
                    butaca.tipo = (String)lector["butaca_tipo"];
                    butaca.piso = (int)(decimal)lector["butaca_piso"];

                    butacaList.Add(butaca);
                }
            }
            return butacaList;
        }


        internal static void createButacas(int? butacasPasillo, int? butacasVentana, string matricula)
        {
            string query = "INSERT INTO SQLOVERS.BUTACA (butaca_nro, butaca_tipo, butaca_piso, butaca_aeronave) VALUES ";

            for (int i = 1; i <= butacasPasillo; i++)
            {
                query = String.Concat(query,"("+i+",'Pasillo',1,'"+matricula+"'),");
            }

            for (int i = (int) butacasPasillo + 1; i <= (butacasPasillo + butacasVentana + 1); i++)
            {
                query = String.Concat(query,"("+i+",'Ventana',1,'"+matricula+"'),");
            }

            query = query.Remove(query.Length - 1);

            DBAcess.WriteInBase(query, "T", new List<SqlParameter>());
        }
    }
}
