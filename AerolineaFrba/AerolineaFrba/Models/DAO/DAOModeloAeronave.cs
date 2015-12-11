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
    class DAOModeloAeronave
    {

        public static List<ModeloAeronave> getFromFabricante(int fabricante)
        {
            List<SqlParameter> parameterList = new List<SqlParameter>();
            parameterList.Add(new SqlParameter("@fabricante_id", fabricante));
            SqlDataReader lector = DBAcess.GetDataReader("SELECT * FROM SQLOVERS.MODELO WHERE modelo_fabricante=@fabricante_id", "T", parameterList);

            List<ModeloAeronave> modelos = new List<ModeloAeronave>();
            if (lector.HasRows)
            {
                while (lector.Read())
                {
                    ModeloAeronave modelo = new ModeloAeronave();
                    modelo.id = (int)(decimal)lector["modelo_id"];
                    modelo.nombre = (string)lector["modelo_nombre"];
                    modelo.fabricante = (int)(decimal)lector["modelo_fabricante"];
                    modelos.Add(modelo);
                }
            }
            return modelos;
        }

    }
}
