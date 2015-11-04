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
*/
        public static bool create(Ruta ruta)
        {
            try
            {
                List<SqlParameter> listaParametros = new List<SqlParameter>();

                SqlCommand sqlCommand = new SqlCommand();
                sqlCommand.Connection = DBAcess.GetConnection();
                sqlCommand.Parameters.AddWithValue("@ruta_ciudad_destino", ruta.ciudadDestinoId);
                sqlCommand.Parameters.AddWithValue("@ruta_ciudad_origen", ruta.ciudadOrigenId);
                sqlCommand.Parameters.AddWithValue("@ruta_tipo_servicio", ruta.tipoServicioId);
                sqlCommand.Parameters.AddWithValue("@ruta_precio_basepasaje", ruta.precioBasePasaje);
                sqlCommand.Parameters.AddWithValue("@ruta_precio_basekg", ruta.precioBaseKg);
                sqlCommand.CommandText = "INSERT INTO SQLOVERS.RUTA (ruta_ciudad_origen, ruta_ciudad_destino, ruta_tipo_servicio, ruta_precio_basepasaje, ruta_precio_basekg) VALUES (@ruta_ciudad_origen, @ruta_ciudad_destino, @ruta_tipo_servicio, @ruta_precio_basepasaje, @ruta_precio_basekg)";
                sqlCommand.ExecuteNonQuery();

                return true;
            }
            catch { return false; }
        }
        /*
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
            SqlDataReader lector = DBAcess.GetDataReader("SELECT ruta_id, c1.ciudad_id as ciudad_origen_id, c1.ciudad_nombre as ciudad_origen,c2.ciudad_id as ciudad_destino_id, c2.ciudad_nombre as ciudad_destino, ruta_precio_basepasaje, ruta_precio_basekg, tipo_servicio_id, tipo_servicio_nombre as ruta_tipo_servicio FROM SQLOVERS.RUTA, SQLOVERS.TIPO_SERVICIO, SQLOVERS.CIUDAD c1, SQLOVERS.CIUDAD c2" 
            + " WHERE ruta_tipo_servicio =  tipo_servicio_id AND ruta_ciudad_origen= c1.ciudad_id AND ruta_ciudad_destino=c2.ciudad_id", "T", new List<SqlParameter>());

            if (lector.HasRows)
            {
                while (lector.Read())
                {
                    Ruta ruta = new Ruta();
                    ruta.id = (int)(decimal)lector["ruta_id"];
                    ruta.tipoServicioId = (int)(decimal)lector["tipo_servicio_id"];
                    ruta.tipoServicioNombre = (String)lector["ruta_tipo_servicio"];
                    ruta.ciudadOrigenId = (int)(decimal)lector["ciudad_origen_id"];
                    ruta.ciudadOrigenNombre = (String)lector["ciudad_origen"];
                    ruta.ciudadDestinoId = (int)(decimal)lector["ciudad_destino_id"];
                    ruta.ciudadDestinoNombre = (String)lector["ciudad_destino"];
                    ruta.precioBasePasaje = (int)(decimal)lector["ruta_precio_basepasaje"];
                    ruta.precioBaseKg = (int)(decimal)lector["ruta_precio_basekg"];

                    rutaList.Add(ruta);
                }
            }
            return rutaList;
        }

    }
}
