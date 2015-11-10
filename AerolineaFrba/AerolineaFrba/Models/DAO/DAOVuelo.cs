﻿using System;
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

        public bool create(Vuelo _Vuelo)
        {
            try
            {
                int bit = 0;
                string comando = "INSERT INTO SQLOVERS.VUELO(vuelo_fecha_salida, vuelo_fecha_llegada, vuelo_fecha_llegada_estimada, vuelo_aeronave_id, vuelo_ruta_id, vuelo_cancelado)"
                                    + "VALUES ({0},{1},{2},{3},{4},{5});"
                                    + "SELECT SCOPE_IDENTITY();";
                
                comando = String.Format(comando, fechaQuereable(_Vuelo.fechaSalida), fechaQuereable(_Vuelo.fechaLlegada), fechaQuereable(_Vuelo.fechaLlegada), stringQuereable(_Vuelo.aeronave),_Vuelo.ruta ,1);
                int insertado = DB.ExecuteCardinal(comando);
                return true;

            }
            catch { return false; }

        }

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

        public void cancelarVuelo(int vuelo_id) {

            string comando = "update SQLOVERS.VUELO set vuelo_cancelado = 1 where vuelo_id= " + vuelo_id;
            DB.ExecuteNonQuery(comando);
        }

        public static List<Vuelo> retrieveWithOriginDestinyAndDate(Ciudad ciudadOrigen, Ciudad ciudadDestino, DateTime fechaSalida)
        {
            List<Vuelo> l = new List<Vuelo>();
            List<SqlParameter> parameterList = new List<SqlParameter>();
            parameterList.Add(new SqlParameter("@ruta_ciudad_destino_id",ciudadDestino.id));
            parameterList.Add(new SqlParameter("@ruta_ciudad_origen_id",ciudadOrigen.id));
            parameterList.Add(new SqlParameter("@vuelo_fecha_salida", fechaSalida));
            SqlDataReader lector = DBAcess.GetDataReader("SELECT * from SQLOVERS.VUELO, SQLOVERS.RUTA where vuelo_ruta_id = ruta_id and ruta_ciudad_destino = @ruta_ciudad_destino_id and ruta_ciudad_origen = @ruta_ciudad_origen_id and CAST(vuelo_fecha_salida as date) = CAST(@vuelo_fecha_salida as date)", "T", parameterList);

            if (lector.HasRows)
            {
                while (lector.Read())
                {
                    Vuelo unCliente = new Vuelo();
                    unCliente.id = (int)(decimal)lector["vuelo_id"];
                    unCliente.aeronave = (String)lector["vuelo_aeronave_id"];
                    unCliente.ruta = (int)(decimal)lector["vuelo_ruta_id"];
                    unCliente.fechaLlegada = (DateTime)lector["vuelo_fecha_llegada"];
                    unCliente.fechaLlegadaEstimada = (DateTime)lector["vuelo_fecha_llegada_estimada"];
                    unCliente.fechaSalida = (DateTime)lector["vuelo_fecha_salida"];

                    l.Add(unCliente);
                }
            }

            return l;

        }

        public static List<Vuelo> retrieveAll()
        {
            List<Vuelo> l = new List<Vuelo>();
            SqlDataReader lector = DBAcess.GetDataReader("SELECT * from SQLOVERS.VUELO", "T", new List<SqlParameter>());

            if (lector.HasRows)
            {
                while (lector.Read())
                {
                    Vuelo unCliente = new Vuelo();
                    unCliente.id = (int)(decimal)lector["vuelo_id"];
                    unCliente.aeronave = (String)lector["vuelo_aeronave_id"];
                    unCliente.ruta = (int)(decimal)lector["vuelo_ruta_id"];
                    unCliente.fechaLlegada = (DateTime)lector["vuelo_fecha_llegada"];
                    unCliente.fechaLlegadaEstimada = (DateTime)lector["vuelo_fecha_llegada_estimada"];
                    unCliente.fechaSalida = (DateTime)lector["vuelo_fecha_salida"];

                    l.Add(unCliente);
                }
            }
            return l;
        }

      

       
    }
}