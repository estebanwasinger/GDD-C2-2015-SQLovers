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

    }
}
