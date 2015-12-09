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

        public static Ruta getRuta(int id)
        {
            List<SqlParameter> parameterList = new List<SqlParameter>();
            parameterList.Add(new SqlParameter("@ruta_id", id));
            SqlDataReader lector = DBAcess.GetDataReader("SELECT ruta_id, c1.ciudad_id as ciudad_origen_id, c1.ciudad_nombre as ciudad_origen,c2.ciudad_id as ciudad_destino_id, c2.ciudad_nombre as ciudad_destino, ruta_precio_basepasaje, ruta_precio_basekg, tipo_servicio_id, tipo_servicio_nombre as ruta_tipo_servicio, ruta_estado FROM SQLOVERS.RUTA, SQLOVERS.TIPO_SERVICIO, SQLOVERS.CIUDAD c1, SQLOVERS.CIUDAD c2"
            + " WHERE ruta_tipo_servicio =  tipo_servicio_id AND ruta_ciudad_origen= c1.ciudad_id AND ruta_ciudad_destino=c2.ciudad_id and ruta_id=@ruta_id", "T", parameterList);

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
                    ruta.estado = (bool)lector["ruta_estado"];

                    return ruta;
                }
            }
            return new Ruta();
        }
        public static void baja(Ruta ruta)
        {
            List<SqlParameter> listaParametros = new List<SqlParameter>();
            listaParametros.Add(new SqlParameter("@ruta_id", ruta.id));
            listaParametros.Add(new SqlParameter("@ruta_estado", false));

            DBAcess.WriteInBase("update SQLOVERS.ruta set ruta_estado=@ruta_estado where ruta_id=@ruta_id", "T", listaParametros);

            listaParametros = new List<SqlParameter>();
            listaParametros.Add(new SqlParameter("@ruta_id", ruta.id));

            DBAcess.WriteInBase("UPDATE SQLOVERS.PASAJE SET pasaje_cancelado = 1 FROM SQLOVERS.VUELO WHERE vuelo_ruta_id = @ruta_id AND pasaje_vuelo_id = vuelo_id", "T", listaParametros);

            listaParametros = new List<SqlParameter>();
            listaParametros.Add(new SqlParameter("@ruta_id", ruta.id));

            DBAcess.WriteInBase("UPDATE SQLOVERS.ENCOMIENDA SET encomienda_cancelado = 1 FROM SQLOVERS.VUELO WHERE vuelo_ruta_id = @ruta_id AND encomienda_vuelo_id = vuelo_id", "T", listaParametros);


            listaParametros = new List<SqlParameter>();
            listaParametros.Add(new SqlParameter("@ruta_id", ruta.id));


            DBAcess.WriteInBase("UPDATE SQLOVERS.VUELO SET vuelo_cancelado = 1  WHERE vuelo_ruta_id = @ruta_id", "T", listaParametros);

        }

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
                sqlCommand.Parameters.AddWithValue("@ruta_estado", ruta.estado);
                sqlCommand.CommandText = "INSERT INTO SQLOVERS.RUTA (ruta_ciudad_origen, ruta_ciudad_destino, ruta_tipo_servicio, ruta_precio_basepasaje, ruta_precio_basekg, ruta_estado) VALUES (@ruta_ciudad_origen, @ruta_ciudad_destino, @ruta_tipo_servicio, @ruta_precio_basepasaje, @ruta_precio_basekg, @ruta_estado)";
                sqlCommand.ExecuteNonQuery();

                return true;
            }
            catch { return false; }
        }

        public List<Ruta> retrieveAll()
        {
            List<Ruta> rutaList = new List<Ruta>();
            SqlDataReader lector = DBAcess.GetDataReader("SELECT ruta_id, c1.ciudad_id as ciudad_origen_id, c1.ciudad_nombre as ciudad_origen,c2.ciudad_id as ciudad_destino_id, c2.ciudad_nombre as ciudad_destino, ruta_precio_basepasaje, ruta_precio_basekg, tipo_servicio_id, tipo_servicio_nombre as ruta_tipo_servicio, ruta_estado FROM SQLOVERS.RUTA, SQLOVERS.TIPO_SERVICIO, SQLOVERS.CIUDAD c1, SQLOVERS.CIUDAD c2" 
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
                    ruta.estado = (bool)lector["ruta_estado"];

                    rutaList.Add(ruta);
                }
            }
            return rutaList;
        }

        public static bool exist(int ciudadOrigen, int ciudadDestino, int tipoServicio)
        {
            List<SqlParameter> parameterList = new List<SqlParameter>();
            parameterList.Add(new SqlParameter("@ciudadOrigen",ciudadOrigen));
            parameterList.Add(new SqlParameter("@ciudadDestino",ciudadDestino));
            parameterList.Add(new SqlParameter("@tipoServicio", tipoServicio));
            SqlDataReader lector = DBAcess.GetDataReader("SELECT sqlovers.Existeruta(@ciudadOrigen,@ciudadDestino,@tipoServicio) ", "T", parameterList);

            lector.Read();

            return lector.GetBoolean(0);
        }


        internal void delete(Ruta ruta)
        {
            throw new NotImplementedException();
        }

        internal static bool update(Ruta ruta)
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
                sqlCommand.Parameters.AddWithValue("@ruta_estado", ruta.estado);
                sqlCommand.Parameters.AddWithValue("@ruta_id", ruta.id);
                sqlCommand.CommandText = "UPDATE SQLOVERS.RUTA  set ruta_ciudad_origen=@ruta_ciudad_origen, ruta_ciudad_destino=@ruta_ciudad_destino, ruta_tipo_servicio=@ruta_tipo_servicio, ruta_precio_basepasaje=@ruta_precio_basepasaje, ruta_precio_basekg=@ruta_precio_basekg, ruta_estado=@ruta_estado where ruta_id=@ruta_id ";
                sqlCommand.ExecuteNonQuery();

                return true;
            }
            catch { return false; }
        }
    }
}
