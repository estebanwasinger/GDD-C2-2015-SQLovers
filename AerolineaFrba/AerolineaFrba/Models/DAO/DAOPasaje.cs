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
    class DAOPasaje
    {

        public static bool create(Pasaje pasaje){
            List<SqlParameter> parameterList = new List<SqlParameter>();
            parameterList.Add(new SqlParameter("@pasaje_codigo", new Random().Next(100000)));
            parameterList.Add(new SqlParameter("@pasaje_vuelo_id", pasaje.vuelo.id));
            parameterList.Add(new SqlParameter("@cli_dni", pasaje.usuario.dni));
            parameterList.Add(new SqlParameter("@pasaje_fechacompra", DateTime.Now));
            
            return DBAcess.WriteInBase("INSERT INTO sqlovers.PASAJE (pasaje_codigo, pasaje_vuelo_id, cli_dni, pasaje_fechacompra) " + 
                                                " VALUES (@pasaje_codigo, @pasaje_vuelo_id, @cli_dni, @pasaje_fechacompra)", "T", parameterList );
        }

    }
}
