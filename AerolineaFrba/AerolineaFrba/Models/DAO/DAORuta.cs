using AerolineaFrba.Models.BO;
using AerolineaFrba.Models.DataBase;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AerolineaFrba.Models.DAO
{
    public partial class DAORuta : DAOBase<Ruta>
    {

        public DAORuta()
            : base("SQLOVERS.RUTA", "ruta_id")
        { }

        /*  public int deleteRuta(int key)
          {
              List<SqlParameter> listaParametros = new List<SqlParameter>();
              listaParametros.Add(new SqlParameter("@ciudad_id", key));
              listaParametros.Add(new SqlParameter("@ciudad_estado", false));

              return Convert.ToInt32(DBAcess.WriteInBase("update SQLOVERS.ciudad set ciudad_estado=@ciudad_estado where ciudad_id=@ciudad_id", "T", listaParametros));
          }

          public bool create(Ciudad ciudad)
          {
              try
              {
                  List<SqlParameter> ListaParametros = new List<SqlParameter>();

                  ListaParametros.Add(new SqlParameter("@ciudad_nombre", ciudad.nombre));
                  ListaParametros.Add(new SqlParameter("@ciudad_estado", ciudad.estado));

                  return DBAcess.WriteInBase("insert into SQLOVERS.ciudad (ciudad_nombre, ciudad_estado) VALUES(@ciudad_nombre, @ciudad_estado)", "T", ListaParametros);
              }
              catch { return false; }
          }

          public bool update(Ciudad ciudad)
          {
              try
              {
                  List<SqlParameter> ListaParametros = new List<SqlParameter>();

                  ListaParametros.Add(new SqlParameter("@ciudad_id", ciudad.id));
                  ListaParametros.Add(new SqlParameter("@ciudad_nombre", ciudad.nombre));
                  ListaParametros.Add(new SqlParameter("@ciudad_estado", ciudad.estado));

                  return DBAcess.WriteInBase("update SQLOVERS.ciudad set ciudad_nombre=@ciudad_nombre, ciudad_estado=@ciudad_estado where ciudad_id = @ciudad_id ", "T", ListaParametros);
              }
              catch { return false; }
          }*/


          public List<Ruta> retrieveAll()
          {
              List<Ruta> rutaList = new List<Ruta>();
              SqlDataReader lector = DBAcess.GetDataReader("SELECT ruta_id, c1.ciudad_nombre as ciudad_origen, c2.ciudad_nombre as ciudad_destino, ruta_precio_basepasaje, ruta_precio_basekg, tipo_servicio_nombre as ruta_tipo_servicio FROM SQLOVERS.RUTA, SQLOVERS.TIPO_SERVICIO, SQLOVERS.CIUDAD c1, SQLOVERS.CIUDAD c2 WHERE ruta_tipo_servicio =  tipo_servicio_id AND ruta_ciudad_origen= c1.ciudad_id AND ruta_ciudad_destino=c2.ciudad_id", "T", new List<SqlParameter>());

              if (lector.HasRows)
              {
                  while (lector.Read())
                  {
                      Ruta ruta = new Ruta();
                      ruta.id = (int)(decimal)lector["ruta_id"];
                      ruta.tipoServicio = (String)lector["ruta_tipo_servicio"];
                      ruta.ciudadOrigen = (string)lector["ciudad_origen"];
                      ruta.ciudadDestino = (string)lector["ciudad_destino"];
                      ruta.precioBasePasaje = (int)(decimal)lector["ruta_precio_basepasaje"];
                      ruta.precioBaseKg = (int)(decimal)lector["ruta_precio_basekg"];

                      rutaList.Add(ruta);
                  }
              }
              return rutaList;
          }

    }
}
