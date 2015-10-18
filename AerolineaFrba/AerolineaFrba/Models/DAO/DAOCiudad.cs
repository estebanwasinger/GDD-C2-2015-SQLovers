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
    public partial class DAOCiudad : DAOBase<Ciudad>
    {

        public DAOCiudad()
            : base("SQLOVERS.CIUDAD", "ciudad_id")
        { }

        public int deleteCiudad(int key)
        {
            return this.deleteBase(key);
        }

        public List<Ciudad> retrieveAll()
        {
            List<Ciudad> ciudadList = new List<Ciudad>();
            SqlDataReader lector = DBAcess.GetDataReader("SELECT * from SQLOVERS.CIUDAD", "T", new List<SqlParameter>());

            if (lector.HasRows)
            {
                while (lector.Read())
                {
                    Ciudad ciudad = new Ciudad();
                    ciudad.nombre = (string)lector["ciudad_nombre"];
                    ciudad.id = (int)(decimal)lector["ciudad_id"];

                    ciudadList.Add(ciudad);
                }
            }
            return ciudadList;
        }

    }
}
