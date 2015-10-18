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
            List<SqlParameter> listaParametros = new List<SqlParameter>();
            listaParametros.Add(new SqlParameter("@ciudad_id", key));
            listaParametros.Add(new SqlParameter("@ciudad_estado", false));
           
            return Convert.ToInt32(DBAcess.WriteInBase("update SQLOVERS.ciudad set ciudad_estado=@ciudad_estado where ciudad_id=@ciudad_id","T", listaParametros));
        }

        public bool create(Ciudad ciudad) 
        {
            try
            {
                List<SqlParameter> ListaParametros = new List<SqlParameter>();

                ListaParametros.Add(new SqlParameter("@ciudad_nombre", ciudad.nombre));
                ListaParametros.Add(new SqlParameter("@ciudad_estado", ciudad.estado));

                return DBAcess.WriteInBase("insert into SQLOVERS.ciudad (ciudad_nombre, ciudad_estado) VALUES(@ciudad_nombre, @ciudad_estado)", "T", ListaParametros);
            }
            catch { return false; }
        }

        public bool update(Ciudad ciudad)
        {
            try
            {
                List<SqlParameter> ListaParametros = new List<SqlParameter>();

                ListaParametros.Add(new SqlParameter("@ciudad_id", ciudad.id));
                ListaParametros.Add(new SqlParameter("@ciudad_nombre", ciudad.nombre));
                ListaParametros.Add(new SqlParameter("@ciudad_estado", ciudad.estado));

                return DBAcess.WriteInBase("update SQLOVERS.ciudad set ciudad_nombre=@ciudad_nombre, ciudad_estado=@ciudad_estado where ciudad_id = @ciudad_id ", "T", ListaParametros);
            }
            catch { return false; }
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
                    ciudad.estado = (Boolean)lector["ciudad_estado"];

                    ciudadList.Add(ciudad);
                }
            }
            return ciudadList;
        }

    }
}
