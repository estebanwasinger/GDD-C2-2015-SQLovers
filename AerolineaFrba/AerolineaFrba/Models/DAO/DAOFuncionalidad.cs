using AerolineaFrba.Models.BO;
using AerolineaFrba.Models.DataBase;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;


namespace AerolineaFrba.Models.DAO
{
    class DAOFuncionalidad : DAOBase<Funcionalidad>
    {

        public DAOFuncionalidad()
            : base("SQLOVERS.ROL", "funcionalidad_id")
        { }

        public List<Funcionalidad> retrieveAll()
        {
           
            SqlDataReader lector = DBAcess.GetDataReader("SELECT funcionalidad_id,funcionalidad_desc from SQLOVERS.FUNCIONALIDAD", "T", new List<SqlParameter>());

            return getFuncionalidadesFromLector(lector);
        }

        private static List<Funcionalidad> getFuncionalidadesFromLector(SqlDataReader lector)
        {
            List<Funcionalidad> funcList = new List<Funcionalidad>();
            if (lector.HasRows)
            {
                while (lector.Read())
                {
                    Funcionalidad func = new Funcionalidad();
                    func.name = (string)lector["funcionalidad_desc"];
                    func.id = (int)(decimal)lector["funcionalidad_id"];
                    funcList.Add(func);
                }
            }
            return funcList;
        }

        public static List<Funcionalidad> getFuncionalidadFromUsuario(String username)
        {
            List<SqlParameter> parameterList = new List<SqlParameter>();
            parameterList.Add(new SqlParameter("@username", username));
            SqlDataReader lector = DBAcess.GetDataReader(" SELECT f.funcionalidad_id, f.funcionalidad_desc FROM SQLOVERS.USUARIO u, SQLOVERS.FUNCIONALIDAD f, SQLOVERS.FUNCIONALIDAD_ROL fr WHERE u.user_rol_id = fr.rol_id AND f.funcionalidad_id = fr.funcionalidad_id AND u.user_username = @username", "T", parameterList);
            return getFuncionalidadesFromLector(lector);
        }

        public static Dictionary<Int32, String> getFuncionalidadFromUsuarioAsMap(String username) {
            Dictionary<Int32, String> map = new Dictionary<Int32, String>();

            foreach (Funcionalidad funcionalidad in getFuncionalidadFromUsuario(username)) {
                map.Add((int)funcionalidad.id, funcionalidad.name);
            }

            return map;
        }

    }
}
