using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

using AerolineaFrba.Models;
using AerolineaFrba.Models.BO;
using AerolineaFrba.Models.Utils;
using System.Data.SqlClient;
using AerolineaFrba.Models.DataBase;

namespace AerolineaFrba.Models.DAO {
    public partial class DAOServicio: DAOBase<Servicio> {
        public DAOServicio()
            : base("SQLOVERS.TIPO_SERVICIO", "tipo_servicio_id")
        {
        }

        public Servicio update(Servicio _Servicio)
        {
			DB.ExecuteNonQuery("UPDATE");
            return DB.ExecuteReaderSingle<Servicio>("SELECT * FROM SQLOVERS.TIPO_SERVICIO WHERE tipo_servicio_id = @1", _Servicio.tipo_servicio_id);
        }

        public Servicio create(Servicio _Servicio)
        {
            if (_Servicio.tipo_servicio_id == null || _Servicio.tipo_servicio_id != 0)
            {
                int tipo_servicio_id = DB.ExecuteCastable<int>("INSERT INTO SQLOVERS.TIPO_SERVICIO () values (); SELECT SCOPE_IDENTITY();"); //FIXIT
                return DB.ExecuteReaderSingle<Servicio>("SELECT * FROM SQLOVERS.TIPO_SERVICIO WHERE tipo_servicio_id = @1", tipo_servicio_id);
			} else
				return update(_Servicio);
        }

        public static List<Servicio> retrieveAll(){
            
            {
                List<Servicio> servicioList = new List<Servicio>();
              SqlDataReader lector = DBAcess.GetDataReader("SELECT * FROM SQLOVERS.TIPO_SERVICIO", "T", new List<SqlParameter>());

              if (lector.HasRows)
              {
                  while (lector.Read())
                  {
                      Servicio servicio = new Servicio();
                      servicio.tipo_servicio_id = (int)(decimal)lector["tipo_servicio_id"];
                      servicio.tipo_servicio_nombre = (String)lector["tipo_servicio_nombre"];
                      servicio.tipo_servicio_recargo = (float)(decimal)lector["tipo_servicio_recarga"];
                      servicioList.Add(servicio);
                  }
              }
              return servicioList;
          }

        }

        public void delete(int Servicio_id)
        {
            DB.ExecuteNonQuery("DELETE FROM" + tabla + " WHERE tipo = @1", Servicio_id);
        }

        public Servicio retrieveBy_id_serv(int? _value)
        {
            return DB.ExecuteReaderSingle<Servicio>("SELECT * FROM " + tabla + " WHERE tipo_servicio_id = @1", _value);
		}
    }
}
