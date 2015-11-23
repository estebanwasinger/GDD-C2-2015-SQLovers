using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using AerolineaFrba.Models.BO;
using AerolineaFrba.Models.DataBase;


namespace AerolineaFrba.Models.DAO
{
    class DAORolFuncionalidad : DAOBase<RolFuncionalidad>
    {
        public DAORolFuncionalidad()
            : base("SQLOVERS.FUNCIONALIDAD_ROL", "rol_id")
        { }

        public bool create(RolFuncionalidad rol_func)
        {
            try
            {
                List<SqlParameter> ListaParametros = new List<SqlParameter>();

                ListaParametros.Add(new SqlParameter("@rol_id", rol_func.id_rol));
                ListaParametros.Add(new SqlParameter("@funcionalidad_id", rol_func.id_funcionalidad));

                return DBAcess.WriteInBase("insert into SQLOVERS.FUNCIONALIDAD_ROL (rol_id, funcionalidad_id) VALUES(@rol_id, @funcionalidad_id)", "T", ListaParametros);
            }
            catch { return false; }
        }


        public bool deleteAllFunc(int rol_id)
        {
            try
            {
                List<SqlParameter> ListaParametros = new List<SqlParameter>();

                ListaParametros.Add(new SqlParameter("@rol_id", rol_id));

                return DBAcess.WriteInBase("DELETE FROM SQLOVERS.FUNCIONALIDAD_ROL WHERE rol_id=@rol_id", "T", ListaParametros);
            }
            catch { return false; }
        }

        public bool existeRolFuncionalidad(int rol_id, int funcionalidad_id)
        {
            List<SqlParameter> ListaParametros = new List<SqlParameter>();

            ListaParametros.Add(new SqlParameter("@rol_id", rol_id));
            ListaParametros.Add(new SqlParameter("@funcionalidad_id", funcionalidad_id));

            SqlDataReader lector = DBAcess.GetDataReader("SELECT rol_id FROM SQLOVERS.FUNCIONALIDAD_ROL WHERE rol_id=@rol_id AND funcionalidad_id=@funcionalidad_id", "T", ListaParametros);

            return lector.HasRows;
        }
    }
}
