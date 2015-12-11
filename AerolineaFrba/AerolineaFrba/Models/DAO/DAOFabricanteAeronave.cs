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
    class DAOFabricanteAeronave
    {

        public static List<FabricanteAeronave> retrieveAll()
        {
            SqlDataReader lector = DBAcess.GetDataReader("SELECT * FROM SQLOVERS.FABRICANTE", "T", new List<SqlParameter>());

            List<FabricanteAeronave> fabricantes = new List<FabricanteAeronave>();
            if (lector.HasRows)
            {
                while (lector.Read())
                {
                    FabricanteAeronave fabricante = new FabricanteAeronave();
                    fabricante.id = (int)(decimal)lector["fabricante_id"];
                    fabricante.nombre = (string)lector["fabricante_nombre"];
                    fabricantes.Add(fabricante);
                }
            }
            return fabricantes;
        }

    }
}
