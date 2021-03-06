﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AerolineaFrba.Models.BO;
using AerolineaFrba.Models.DataBase;
using System.Data.SqlClient;
using AerolineaFrba.Models.Utils;

namespace AerolineaFrba.Models.DAO
{
    public partial class DAOLlegadaDestino : DAOBase<LlegadaDestino>
    {

        public DAOLlegadaDestino()
            : base("SQLOVERS.LLEGADA_DESTINO", "llegada_codigo")
        { }

     

        public bool create(LlegadaDestino LlDestino)
        {
            try
            {
                List<SqlParameter> ListaParametros = new List<SqlParameter>();

                ListaParametros.Add(new SqlParameter("@llegada_matricula", LlDestino.matricula));
                ListaParametros.Add(new SqlParameter("@llegada_horaArrivo", LlDestino.fecha_arribo));
                ListaParametros.Add(new SqlParameter("@llegada_origen", LlDestino.origen_id));
                ListaParametros.Add(new SqlParameter("@llegada_destino", LlDestino.destino_id));
                ListaParametros.Add(new SqlParameter("@llegada_vuelo_id", LlDestino.vuelo_id));


                return DBAcess.WriteInBase("insert into SQLOVERS.LLEGADA_DESTINO (llegada_matricula, llegada_horaArrivo, llegada_origen,llegada_destino,llegada_vuelo_id) VALUES(@llegada_matricula, @llegada_horaArrivo,@llegada_origen,@llegada_destino,@llegada_vuelo_id)", "T", ListaParametros);
            }
            catch { return false; }
        }

        public int registrarLlegada(LlegadaDestino LlDestino)
        {

            string comando = String.Format("update SQLOVERS.vuelo set vuelo_fecha_llegada = '{0}' ,vuelo_ciudad_de_llegada={1} where vuelo_id ={2}", LlDestino.fecha_arribo,LlDestino.destino_id,LlDestino.vuelo_id);
            //Console.WriteLine(DB.ExecuteCardinal(comando));
            return DB.ExecuteCardinal(comando);
        }


      /*  public List<Ciudad> retrieveAll()
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
        }*/
    }
}
