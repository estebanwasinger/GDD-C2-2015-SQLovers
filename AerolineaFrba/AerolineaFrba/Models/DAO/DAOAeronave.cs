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
    public partial class DAOAeronave: DAOBase<Aeronave>
    {
        public DAOAeronave()
            : base("SQLOVERS.AERONAVE", "aeronave_matricula")
        {
        }

        private string stringQuereable(string cadena)
        {
            return "'" + cadena + "'";
        }

        public bool create(Aeronave _Aeronave)
        {
            try
            {
                int bit = 0;
                string comando = "INSERT INTO SQLOVERS.AERONAVE(aeronave_matricula, aeronave_modelo, aeronave_kg_disponibles, aeronave_fecha_alta, aeronave_fabricante, aeronave_tipo_servicio, aeronave_but_vent, aeronave_but_pasill)"
                                    + "VALUES ({0},{1},{2},{3},{4},{5},{6},{7})";
                                   // + "SELECT SCOPE_IDENTITY();";
               /* if (_Aeronave.usuario == null || _Aeronave.usuario == "")
                {
                    _Aeronave.usuario = "NULL";
                }
                else
                {
                    if (!existsUser(_Aeronave.usuario)) { MessageBox.Show("Usuario ingresado incorrecto"); return false;};
                    _Aeronave.usuario = stringQuereable(_Aeronave.usuario);
                }

                if (_Aeronave.activo == true)
                {
                    bit = 1;
                }*/
                comando = String.Format(comando, stringQuereable(_Aeronave.matricula), stringQuereable(_Aeronave.modelo), _Aeronave.peso_disponible, fechaQuereable(_Aeronave.fecha_alta), stringQuereable(_Aeronave.fabricante), _Aeronave.aeronave_tipo_servicio, _Aeronave.cant_butacas_vent, _Aeronave.cant_butacas_pas);
                int insertado = DB.ExecuteCardinal(comando);

                Console.WriteLine(insertado);
                return true;

            }
            catch { return false; }

        }

        public bool update(Aeronave aero)
        {
            try
            {                
                List<SqlParameter> ListaParametros = new List<SqlParameter>();
              //  ListaParametros.Add(new SqlParameter("@id", (int)aero.id));

                ListaParametros.Add(new SqlParameter("@aeronave_matricula", aero.matricula));
                ListaParametros.Add(new SqlParameter("@aeronave_modelo", aero.modelo));
                ListaParametros.Add(new SqlParameter("@aeronave_kg_disponibles", (int)aero.peso_disponible));
                ListaParametros.Add(new SqlParameter("@aeronave_fabricante", aero.fabricante));
                ListaParametros.Add(new SqlParameter("@aeronave_tipo_servicio", (int)aero.aeronave_tipo_servicio));
             
                /*ListaParametros.Add(new SqlParameter("@dom_nro", aero.dom_nro));
                ListaParametros.Add(new SqlParameter("@dom_piso", aero.dom_piso));
                ListaParametros.Add(new SqlParameter("@dom_dpto", aero.dom_dpto));
                ListaParametros.Add(new SqlParameter("@fecha_nac", aero.fecha_nac));
                ListaParametros.Add(new SqlParameter("@mail", aero.mail));
                ListaParametros.Add(new SqlParameter("@nacionalidad", aero.nacionalidad));
                ListaParametros.Add(new SqlParameter("@tipo_documento", aero.tipo_documento));
                ListaParametros.Add(new SqlParameter("@activo", aero.activo));*/


                return DBAcess.WriteInBase("update SQLOVERS.aeronave set aeronave_matricula =@aeronave_matricula, aeronave_modelo=@aeronave_modelo, aeronave_kg_disponibles=@aeronave_kg_disponibles," +
                    "aeronave_fabricante=@aeronave_fabricante,aeronave_tipo_servicio=@aeronave_tipo_servicio", "T", ListaParametros);
            }
            catch { return false; }
        }

        public void bajaDef(string matricula) {

            string comando = "update SQLOVERS.AERONAVE set aeronave_baja = 1 where " + String.Format(" aeronave_matricula like '{0}%' ", matricula);
                        DB.ExecuteNonQuery(comando);
        }

        public void bajaFueraServicio(string matricula) {

            string comando = "update SQLOVERS.AERONAVE set aeronave_fuera_servicio = 1 where " + String.Format(" aeronave_matricula like '{0}%' ", matricula);
            DB.ExecuteNonQuery(comando);
        }

        public List<Aeronave> aeronave_servicio()
        {

            string comando = "select A.aeronave_matricula,TS.tipo_servicio_nombre from SQLOVERS.AERONAVE A inner join SQLOVERS.TIPO_SERVICIO TS on "+
                             " A.aeronave_tipo_servicio = TS.tipo_servicio_id";

           // string comando = "select aeronave_matricula,aeronave_tipo_servicio from SQLOVERS.AERONAVE";

            List<Aeronave> LA = DB.ExecuteReader<Aeronave>(comando);

            foreach(Aeronave aer in LA){
            
                string command = "select TS.tipo_servicio_nombre from SQLOVERS.AERONAVE A inner join SQLOVERS.TIPO_SERVICIO TS on "
+" A.aeronave_tipo_servicio = TS.tipo_servicio_id where " + String.Format("  A.aeronave_matricula like '{0}%' ", aer.matricula);
                Servicio serv = DB.ExecuteReaderSingle<Servicio>(command);
                aer.descripcion_tipoServicio = serv.tipo_servicio_nombre;

            }

            return LA;
        } 

        public void delete(int Cliente_id)
        {
            string update = String.Format("UPDATE " + tabla + " SET activo = 0 WHERE id = {0}", Cliente_id);
            DB.ExecuteNonQuery(update);
        }

        public int retrieveButacas(string matricula) {

            string command = "select count(*) from SQLOVERS.BUTACA where " + String.Format("  butaca_aeronave like '{0}%' ", matricula);
            return DB.ExecuteCardinal(command);
        }

       /* public Cliente retrieveBy_id(object _value)
        {
            return DB.ExecuteReaderSingle<Cliente>("SELECT * FROM " + tabla + " WHERE id = @1", _value);
        }*/

       /* public List<Cliente> retrieveByInfo(string id, string numeroDoc, string nombre, string apellido)
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


       /* public Cliente retrieveBy_user(string userId)
        {
            return DB.ExecuteReaderSingle<Cliente>("SELECT * FROM " + tabla + " WHERE usuario = @1", userId);
        } */

       /* public bool existsUser(string userId)
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

        public List<Aeronave> search(string matricula, string fabricante, string modelo, string peso)
        {
            List<Aeronave> lc = new List<Aeronave>();

            if (String.IsNullOrEmpty(matricula) && String.IsNullOrEmpty(fabricante) && String.IsNullOrEmpty(modelo)
                &&String.IsNullOrEmpty(peso)) {

                String query = String.Format("SELECT * FROM SQLOVERS.AERONAVE");
                    return DB.ExecuteReader<Aeronave>(query);
            }


            String base_query = String.Format("SELECT * FROM SQLOVERS.AERONAVE WHERE");
            if (!String.IsNullOrEmpty(matricula))
            {
                base_query += String.Format(" aeronave_matricula like '{0}%' AND", matricula);
            }

            if (!String.IsNullOrEmpty(fabricante))
            {
                base_query += String.Format(" aeronave_fabricante like '{0}%' AND", fabricante);
            }
                       
            if (!String.IsNullOrEmpty(modelo))
            {
                base_query += String.Format(" aeronave_modelo LIKE '{0}%' AND", modelo);
            }

            if(!String.IsNullOrEmpty(peso))
            {
                base_query += String.Format(" aeronave_kg_disponibles = '{0}' AND", peso);
            }

            base_query = base_query.Substring(0, base_query.Length -3);

            return DB.ExecuteReader<Aeronave>(base_query);
        }

        public List<Aeronave> retrieveAll()
        {
            List<Aeronave> l = new List<Aeronave>();
            SqlDataReader lector = DBAcess.GetDataReader("SELECT * from SQLOVERS.AERONAVE", "T", new List<SqlParameter>());

            if (lector.HasRows)
            {
                while (lector.Read())
                {
                    Aeronave aeRonave = new Aeronave();
                    aeRonave.matricula = (string)lector["aeronave_matricula"];
                    aeRonave.peso_disponible = (int)(decimal)lector["aeronave_kg_disponibles"];
                    aeRonave.modelo = (string)lector["aeronave_modelo"];
                    aeRonave.fabricante = (string)lector["aeronave_fabricante"];
                   
                   /* try
                    {
                        aeRonave.usuario = (string)lector["usuario"];
                    }
                    catch
                    {
                        aeRonave.usuario = "";
                    }*/
                    
                    l.Add(aeRonave);
                }
            }
            return l;
        }

        public List<Aeronave> listaAero(string aeronave)
        {

            string comando =
"DECLARE @var1 nvarchar(255);DECLARE @var2 nvarchar(30);DECLARE @var3 numeric(3,0);" +

"SELECT @var1 = aeronave_modelo, @var2=aeronave_fabricante, @var3=aeronave_tipo_servicio " +
"FROM SQLOVERS.AERONAVE WHERE" + String.Format(" aeronave_matricula like '{0}%' ", aeronave) +

"SELECT aeronave_matricula,aeronave_modelo,aeronave_fabricante,aeronave_tipo_servicio from SQLOVERS.AERONAVE " +
"where aeronave_modelo=@var1 and aeronave_fabricante=@var2 and aeronave_tipo_servicio=@var3 and "+ String.Format(" aeronave_matricula not like '{0}%' ", aeronave);

            //List<Aeronave> cl = DB.ExecuteReader<Aeronave>(comando);
            return DB.ExecuteReader<Aeronave>(comando);
           // return cl;

        }

        public void reemplazoAeronave(string matriculaReemplazo, int vuelo_id)
        {
          

            string comando = "UPDATE SQLOVERS.VUELO set " + String.Format(" vuelo_aeronave_id = '{0}' ", matriculaReemplazo) +
                "where vuelo_id = " + vuelo_id;
            DB.ExecuteNonQuery(comando);
        }

       /* public List<Cliente> topInhabilitados(int anio, int min, int max)
        {
            string comando = "SELECT TOP 5 c.id "
                                + "FROM VIDA_ESTATICA.Cliente c "
                                + "INNER JOIN VIDA_ESTATICA.Cuenta cue "
                                + "ON c.id = cue.cod_cli "
                                + "JOIN VIDA_ESTATICA.Item_Factura i_f "
                                + "ON cue.id = i_f.num_cuenta "
                                + "WHERE YEAR(i_f.fecha) = "+ anio + " "
                                + "AND MONTH(i_f.fecha) IN (" + min + "," + max + ") "
                                + "GROUP BY c.id, i_f.id_factura "
                                + "HAVING COUNT(*) > 5 "
                                + "ORDER BY COUNT(*) DESC ";
            List<Cliente> cl = DB.ExecuteReader<Cliente>(comando);   
            
            return cl;
        }*/

       /* public List<Cliente> topFacturadores(int anio, int min, int max)
        {
            string comando = "SELECT TOP 5 c.id FROM VIDA_ESTATICA.Cliente c "
                                +"INNER JOIN VIDA_ESTATICA.Cuenta cue ON cue.cod_cli = c.id "
                                +"INNER JOIN VIDA_ESTATICA.Item_Factura i_f ON cue.id = i_f.num_cuenta "
                                +"WHERE i_f.facturado = 1 "
                                +"AND YEAR(i_f.fecha) = " + anio + " "
                                +"AND MONTH(i_f.fecha) IN (" + min + "," + max + ") "
                                +"GROUP BY c.id "
                                +"ORDER BY COUNT(*) DESC ";
            List<Cliente> cl = DB.ExecuteReader<Cliente>(comando);

            return cl;
        }*/

       /* public List<Cliente> topTransaccionales(int anio, int min, int max)
        {
            string comando = "SELECT TOP 5 c.id FROM VIDA_ESTATICA.Cliente c "
                                + "INNER JOIN VIDA_ESTATICA.Cuenta cue ON cue.cod_cli = c.id "
                                + "INNER JOIN VIDA_ESTATICA.Transferencia t ON cue.id = t.cuenta_origen "
                                + "WHERE t.cuenta_destino IN (SELECT cuenta.id FROM VIDA_ESTATICA.Cuenta cuenta WHERE cuenta.cod_cli = c.id) "
                                + "AND YEAR(t.fecha) = " + anio + " "
                                + "AND MONTH(t.fecha) IN (" + min + "," + max + ") "
                                + "GROUP BY c.id "
                                + "ORDER BY COUNT(*) DESC ";
            List<Cliente> cl = DB.ExecuteReader<Cliente>(comando);

            return cl;
        }*/
    }
}