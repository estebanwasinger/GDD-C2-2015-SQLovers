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
            List<Funcionalidad> funcList = new List<Funcionalidad>();
            SqlDataReader lector = DBAcess.GetDataReader("SELECT funcionalidad_id,funcionalidad_desc from SQLOVERS.FUNCIONALIDAD", "T", new List<SqlParameter>());

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
    }
}
