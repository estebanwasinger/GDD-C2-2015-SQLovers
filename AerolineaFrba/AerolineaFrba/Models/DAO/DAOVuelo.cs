using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

using AerolineaFrba.Models;
using AerolineaFrba.Models.BO;
using AerolineaFrba.Models.Utils;
using System.Data.SqlClient;
using AerolineaFrba.Models.DataBase;
using System.Windows;

namespace AerolineaFrba.Models.DAO
{
    public partial class DAOVuelo: DAOBase<Vuelo>
    {
        public DAOVuelo()
            : base("SQLOVERS.VUELO", "vuelo_id")
        {
        }

        private string stringQuereable(string cadena)
        {
            return "'" + cadena + "'";
        }

       /* public bool create(Vuelo _Vuelo)
        {
            try
            {
                int bit = 0;
                string comando = "INSERT INTO VIDA_ESTATICA.Cliente(nombre, apellido, documento, dom_calle, dom_nro, dom_piso, dom_dpto, fecha_nac, mail, nacionalidad, tipo_documento, usuario, activo)"
                                    + "VALUES ({0},{1},{2},{3},{4},{5},{6},{7},{8},{9},{10},{11},{12});"
                                    + "SELECT SCOPE_IDENTITY();";
                if (_Vuelo.usuario == null || _Vuelo.usuario == "")
                {
                    _Vuelo.usuario = "NULL";
                }
                else
                {
                    if (!existsUser(_Vuelo.usuario)) { MessageBox.Show("Usuario ingresado incorrecto"); return false;};
                    _Vuelo.usuario = stringQuereable(_Vuelo.usuario);
                }

                if (_Vuelo.activo == true)
                {
                    bit = 1;
                }
                comando = String.Format(comando, stringQuereable(_Vuelo.nombre), stringQuereable(_Vuelo.apellido), _Vuelo.documento, stringQuereable(_Vuelo.dom_calle), _Vuelo.dom_nro, _Vuelo.dom_piso, stringQuereable(_Vuelo.dom_dpto), fechaQuereable(_Vuelo.fecha_nac), stringQuereable(_Vuelo.mail), _Vuelo.nacionalidad, _Vuelo.tipo_documento, _Vuelo.usuario, bit);
                int insertado = DB.ExecuteCardinal(comando);
                return true;

            }
            catch { return false; }

        }*/

       /* public bool update(Cliente cliente)
        {
            try
            {                
                List<SqlParameter> ListaParametros = new List<SqlParameter>();
                ListaParametros.Add(new SqlParameter("@id", (int)cliente.id));
                ListaParametros.Add(new SqlParameter("@nombre", cliente.nombre));
                ListaParametros.Add(new SqlParameter("@apellido", cliente.apellido));                
                ListaParametros.Add(new SqlParameter("@documento", cliente.documento));
                ListaParametros.Add(new SqlParameter("@dom_calle", cliente.dom_calle));                
                ListaParametros.Add(new SqlParameter("@dom_nro", cliente.dom_nro));
                ListaParametros.Add(new SqlParameter("@dom_piso", cliente.dom_piso));
                ListaParametros.Add(new SqlParameter("@dom_dpto", cliente.dom_dpto));
                ListaParametros.Add(new SqlParameter("@fecha_nac", cliente.fecha_nac));
                ListaParametros.Add(new SqlParameter("@mail", cliente.mail));
                ListaParametros.Add(new SqlParameter("@nacionalidad", cliente.nacionalidad));
                ListaParametros.Add(new SqlParameter("@tipo_documento", cliente.tipo_documento));
                ListaParametros.Add(new SqlParameter("@activo", cliente.activo));
              
                
                return DBAcess.WriteInBase("update VIDA_ESTATICA.Cliente set nombre =@nombre, apellido=@apellido, documento=@documento," +
                    "dom_calle=@dom_calle,dom_nro=@dom_nro,dom_piso=@dom_piso,dom_dpto=@dom_dpto,fecha_nac=@fecha_nac," +
                    "mail=@mail, nacionalidad=@nacionalidad, activo=@activo where id=@id", "T", ListaParametros);
            }
            catch { return false; }
        }*/

        /*public void delete(int Cliente_id)
        {
            string update = String.Format("UPDATE " + tabla + " SET activo = 0 WHERE id = {0}", Cliente_id);
            DB.ExecuteNonQuery(update);
        }*/

        /*public Cliente retrieveBy_id(object _value)
        {
            return DB.ExecuteReaderSingle<Cliente>("SELECT * FROM " + tabla + " WHERE id = @1", _value);
        }*/

        /*public List<Cliente> retrieveByInfo(string id, string numeroDoc, string nombre, string apellido)
        {

            if (String.IsNullOrEmpty(id) && String.IsNullOrEmpty(nombre) &&
                String.IsNullOrEmpty(numeroDoc) && String.IsNullOrEmpty(apellido))
            {
                return retrieveBase();
            }

            string baseQuery = String.Format("SELECT * FROM {0} WHERE", tabla);

            if (!String.IsNullOrEmpty(id))
            {
                baseQuery += String.Format(" id = {0} AND", id);
            }
            if (!String.IsNullOrEmpty(numeroDoc))
            {
                baseQuery += String.Format(" documento = {0} AND", numeroDoc);
            }
            if (!String.IsNullOrEmpty(nombre))
            {
                baseQuery += String.Format(" nombre LIKE '{0}%' AND", nombre);
            }
            if (!String.IsNullOrEmpty(apellido))
            {
                baseQuery += String.Format(" apellido LIKE '{0}%'", apellido);
            }

            baseQuery = baseQuery.Substring(0, baseQuery.Length - 3);
            
            return DB.ExecuteReader<Cliente>(baseQuery);
        }*/


        /*public bool existsUser(string userId)
        {
            List<Cliente> cl = DB.ExecuteReader<Cliente>("SELECT DISTINCT usuario FROM " + tabla);
            List<string> users = new List<string>();
            foreach (Cliente c in cl)
            {
                users.Add(c.usuario);
            }
            if (users.Contains(userId))
            {
                return true;
            }
            else
            {
                return false;
            }
        }*/
        public List<Vuelo> search(string matricula) {
            List<Vuelo> lc = new List<Vuelo>();

            if (String.IsNullOrEmpty(matricula)) {
                String query = String.Format("select * from sqlovers.vuelo");
                return DB.ExecuteReader<Vuelo>(query);
            }


            String base_query = String.Format("select * from sqlovers.vuelo WHERE");
            if (!String.IsNullOrEmpty(matricula))
            {
                base_query += String.Format(" vuelo_aeronave_id like '{0}%' AND", matricula);
            }

            base_query = base_query.Substring(0, base_query.Length - 3);

            return DB.ExecuteReader<Vuelo>(base_query);
        }

        /*public List<Cliente> retrieveAll()
        {
            List<Cliente> l = new List<Cliente>();
            SqlDataReader lector = DBAcess.GetDataReader("SELECT * from VIDA_ESTATICA.Cliente", "T", new List<SqlParameter>());

            if (lector.HasRows)
            {
                while (lector.Read())
                {
                    Cliente unCliente = new Cliente();
                    unCliente.nombre = (string)lector["nombre"];
                    unCliente.id = (int)(decimal)lector["id"];
                    unCliente.apellido = (string)lector["apellido"];
                    unCliente.documento = (int)(decimal)lector["documento"];
                    unCliente.dom_calle = (string)lector["dom_calle"];
                    unCliente.dom_dpto = (string)lector["dom_dpto"];
                    unCliente.dom_nro = (int)(decimal)lector["dom_nro"];
                    unCliente.dom_piso = (int)(decimal)lector["dom_piso"];
                    unCliente.mail = (string)lector["mail"];
                    unCliente.nacionalidad = (int)(decimal)lector["nacionalidad"];
                    unCliente.fecha_nac = (DateTime?)lector["fecha_nac"];
                    unCliente.activo = (bool?)lector["activo"];
                    try
                    {
                        unCliente.usuario = (string)lector["usuario"];
                    }
                    catch
                    {
                        unCliente.usuario = "";
                    }
                    unCliente.tipo_documento = (int)(decimal)lector["tipo_documento"];
                    l.Add(unCliente);
                }
            }
            return l;
        }*/

      

       
    }
}