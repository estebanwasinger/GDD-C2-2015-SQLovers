using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AerolineaFrba.Models.DAO
{
    public partial class DAORol : DAOBase<Rol>
    {
        public DAORol()
            : base("VIDA_ESTATICA.Rol", "id")
        {
        }

        public Rol update(Rol _Rol)
        {
            DB.ExecuteNonQuery("UPDATE"); //FIXIT
            return DB.ExecuteReaderSingle<Rol>("SELECT * FROM Rol WHERE id = @1", _Rol.id);
        }

        public bool create(Rol rol, List<Funcionalidad> l)
        {
            try
            {
                List<SqlParameter> ListaParametros = new List<SqlParameter>();
                ListaParametros.Add(new SqlParameter("@nombreRol", rol.nombre));
                SqlParameter paramRet = new SqlParameter("@ret", System.Data.SqlDbType.Decimal);
                paramRet.Direction = System.Data.ParameterDirection.Output;
                ListaParametros.Add(paramRet);

                // insert rol
                int ret = (int)DBAcess.ExecStoredProcedure("VIDA_ESTATICA.agregarRol", ListaParametros);

                if (ret != -1)
                {
                    // alta de funcionalidades para ese rol
                    foreach (Funcionalidad unaFunc in l)
                        Funcionalidad.AgregarFuncionalidadEnRol(ret, unaFunc);
                    return true;
                }
                else { return false; }
            }
            catch { return false; }
        }

        public bool update(Rol rol, List<Funcionalidad> lf)
        {
            try
            {
                List<SqlParameter> lp = new List<SqlParameter>();
                lp.Add(new SqlParameter("@rol", (int)rol.id));
                bool del = DBAcess.WriteInBase("DELETE FROM VIDA_ESTATICA.Funcionalidad_Rol WHERE rol =@rol", "T", lp);
                foreach (Funcionalidad f in lf)
                {
                    bool ins = DBAcess.WriteInBase("INSERT INTO VIDA_ESTATICA.Funcionalidad_Rol(rol, funcionalidad) VALUES(" + (int)rol.id + "," + (int)f.id + ")", "T", new List<SqlParameter>());
                }
                List<SqlParameter> ListaParametros = new List<SqlParameter>();
                ListaParametros.Add(new SqlParameter("@id", (int)rol.id));
                ListaParametros.Add(new SqlParameter("@nombre", rol.nombre));
                return DBAcess.WriteInBase("update VIDA_ESTATICA.Rol set nombre =@nombre where id=@id", "T", ListaParametros);
            }
            catch { return false; }
        }

        public bool delete(int id)
        {
            try
            {
                List<SqlParameter> ListaParametros = new List<SqlParameter>();
                ListaParametros.Add(new SqlParameter("@id", id));
                return DBAcess.WriteInBase("UPDATE VIDA_ESTATICA.Rol set Activo = 0 where id=@id", "T", ListaParametros);
            }
            catch { return false; }
        }

        public Rol retrieveBy_id(object _value)
        {
            return DB.ExecuteReaderSingle<Rol>("SELECT * FROM " + tabla + " WHERE id = @1", _value);
        }


        public List<Rol> retrieve(string name, bool activo)
        {
            List<Rol> l = new List<Rol>();
            int act = Utils.Utils.mapBoolToBit(activo);
            SqlDataReader lector = DBAcess.GetDataReader("SELECT * FROM VIDA_ESTATICA.Rol WHERE nombre like '%" + name + "%' and activo = " + act, "T", new List<SqlParameter>());
            if (lector.HasRows)
            {
                while (lector.Read())
                {
                    Rol unRol = new Rol();
                    unRol.nombre = (string)lector["nombre"];
                    unRol.id = (int)(decimal)lector["id"];
                    unRol.activo = (bool)lector["activo"];
                    l.Add(unRol);
                }
            }
            return l;
        }

        public List<Rol> retrieveAll()
        {
            List<Rol> l = new List<Rol>();
            SqlDataReader lector = DBAcess.GetDataReader("SELECT * from VIDA_ESTATICA.Rol", "T", new List<SqlParameter>());

            if (lector.HasRows)
            {
                while (lector.Read())
                {
                    Rol unRol = new Rol();
                    unRol.nombre = (string)lector["nombre"];
                    unRol.id = (int)(decimal)lector["id"];
                    unRol.activo = (bool)lector["activo"];
                    l.Add(unRol);
                }
            }
            return l;
        }
    }
}
