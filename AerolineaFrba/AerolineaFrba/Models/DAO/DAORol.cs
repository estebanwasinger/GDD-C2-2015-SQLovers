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
    public partial class DAORol : DAOBase<Rol>
    {

        public DAORol()
            : base("SQLOVERS.ROL", "rol_id")
        { }
                public Rol getRolById(int rol_id)
        {
            Rol rol = new Rol();
            List<SqlParameter> ListaParametros = new List<SqlParameter>();
            ListaParametros.Add(new SqlParameter("@rol_id", rol_id));

            SqlDataReader lector = DBAcess.GetDataReader("SELECT rol_id,rol_name,CASE WHEN rol_activo = 1 THEN '1' ELSE '0' END AS rol_activo from SQLOVERS.ROL WHERE rol_id=@rol_id", "T", ListaParametros);

            if (lector.HasRows)
            {
                while (lector.Read())
                {
                    rol.name = (string)lector["rol_name"];
                    rol.id = (int)(decimal)lector["rol_id"];
                    rol.activo = lector["rol_activo"].ToString() == "1";
                }
            }
            return rol;
        }


        public int deleteRol(int key)
        {
            List<SqlParameter> listaParametros = new List<SqlParameter>();
            listaParametros.Add(new SqlParameter("@rol_id", key));
            listaParametros.Add(new SqlParameter("@rol_activo", false));

            return Convert.ToInt32(DBAcess.WriteInBase("update SQLOVERS.rol set rol_activo=@rol_activo where rol_id=@rol_id", "T", listaParametros));
        }

        public bool create(Rol rol)
        {
            try
            {
                List<SqlParameter> ListaParametros = new List<SqlParameter>();

                ListaParametros.Add(new SqlParameter("@rol_name", rol.name));
                ListaParametros.Add(new SqlParameter("@rol_activo", rol.activo));

                return DBAcess.WriteInBase("insert into SQLOVERS.rol (rol_name, rol_activo) VALUES(@rol_name, @rol_activo)", "T", ListaParametros);
            }
            catch { return false; }
        }

        public bool update(Rol rol)
        {
            try
            {
                List<SqlParameter> ListaParametros = new List<SqlParameter>();

                ListaParametros.Add(new SqlParameter("@rol_id", rol.id));
                ListaParametros.Add(new SqlParameter("@rol_name", rol.name));
                ListaParametros.Add(new SqlParameter("@rol_activo", rol.activo));

                return DBAcess.WriteInBase("update SQLOVERS.rol set rol_name=@rol_name, rol_activo=@rol_activo where rol_id = @rol_id ", "T", ListaParametros);
            }
            catch { return false; }
        }


        public List<Rol> retrieveAll()
        {
            List<Rol> rolList = new List<Rol>();
            SqlDataReader lector = DBAcess.GetDataReader("SELECT rol_id,rol_name,CASE WHEN rol_activo = 1 THEN '1' ELSE '0' END AS rol_activo from SQLOVERS.ROL", "T", new List<SqlParameter>());

            if (lector.HasRows)
            {
                while (lector.Read())
                {
                    Rol rol = new Rol();
                    rol.name = (string)lector["rol_name"];
                    rol.id = (int)(decimal)lector["rol_id"];
                    rol.activo = lector["rol_activo"].ToString() == "1";
                    //rol.activo = (lector["rol_activo"] as bool?) ?? false;

                    rolList.Add(rol);
                }
            }
            return rolList;
        }
         public int getLastIdRol()
        {
            int last_rol_id = 0;
            SqlDataReader lector = DBAcess.GetDataReader("SELECT @@IDENTITY AS last_rol_id", "T", new List<SqlParameter>());
            if (lector.HasRows)
                while (lector.Read())
                    last_rol_id = Convert.ToInt32(lector["last_rol_id"]);
            return last_rol_id;
        }

    }
}
