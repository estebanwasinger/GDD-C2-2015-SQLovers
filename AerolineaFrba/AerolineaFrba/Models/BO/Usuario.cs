using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using AerolineaFrba.Models.DataBase;
//using AerolineaFrba.Models.BO;

namespace AerolineaFrba.Models
{
    public class Usuario
    {
        public string Name { get; set; }
        public string Password { get; set; }
        public bool Activo { get; set; }
        public decimal CantFallidos { get; set; }
        public decimal Rol_id { get; set; }

        public Usuario() { }

        public Usuario(string userName)
        {
            List<SqlParameter> paramList = new List<SqlParameter>();
            paramList.Add(new SqlParameter("@userName", userName));

            SqlDataReader lector = DBAcess.GetDataReader("SELECT * FROM SQLOVERS.Usuario WHERE user_username=@userName", "T", paramList);
            if (lector.HasRows)
            {
                lector.Read();
                Name = userName;
                Password = ((string)lector["user_password"]).ToUpper();
                Activo = (bool)lector["user_estado"];
                CantFallidos = (decimal)lector["user_nro_intentos"];
                Rol_id = (decimal)lector["user_rol_id"];

            }
        }

        public void ActualizarFallidos()
        {
            List<SqlParameter> paramList = new List<SqlParameter>();
            paramList.Add(new SqlParameter("@intentos_login", CantFallidos + 1));
            paramList.Add(new SqlParameter("@nombre", Name));

          //  paramList.Add(new SqlParameter("@ret", 1)); //agrego este parametro para el store procedure

            DBAcess.ExecStoredProcedure("SQLOVERS.updateIntentos", paramList);

            
           // return DBAcess.ExecStoredProcedure("SQLOVERS.updateIntentos", paramList);
        }

        public void ReiniciarFallidos()
        {
            List<SqlParameter> paramList = new List<SqlParameter>();
            paramList.Add(new SqlParameter("@nombre", Name));
            DBAcess.WriteInBase("UPDATE SQLOVERS.Usuario SET user_nro_intentos=0 WHERE user_username=@nombre", "T", paramList);
        }


      /*  public static List<Rol> ObtenerRoles(Usuario user)
        {
            List<Rol> l = new List<Rol>();

            List<SqlParameter> lParameters = new List<SqlParameter>();
            lParameters.Add(new SqlParameter("@nombre", user.Name));
            SqlDataReader lector = DBAcess.GetDataReader("SELECT * from VIDA_ESTATICA.roles_usuario(@nombre)", "T", lParameters);

            if (lector.HasRows)
            {
                while (lector.Read())
                {
                    Rol unRol = new Rol();
                    unRol.nombre = (string)lector["nombre"];
                    unRol.id = (int)lector["rol"];
                    unRol.activo = true;
                    l.Add(unRol);
                }
            }
            return l;
        }*/
    }
}
