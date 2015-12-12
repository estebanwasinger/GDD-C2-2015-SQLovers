using AerolineaFrba.Models.BO;
using AerolineaFrba.Models.DataBase;
using AerolineaFrba.Models.Utils;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AerolineaFrba.Models.DAO
{
    public partial class DAOCiudad : DAOBase<Ciudad>
    {

        public DAOCiudad()
            : base("SQLOVERS.CIUDAD", "ciudad_id")
        { }

        public int deleteCiudad(int key)
        {
            List<SqlParameter> listaParametros = new List<SqlParameter>();
            listaParametros.Add(new SqlParameter("@ciudad_id", key));
            listaParametros.Add(new SqlParameter("@ciudad_estado", false));

            List<SqlParameter> listaParametrosRuta = new List<SqlParameter>();
            listaParametrosRuta.Add(new SqlParameter("@ciudad_id", key));
            SqlDataReader lector = DBAcess.GetDataReader("select * from SQLOVERS.RUTA where ruta_ciudad_destino = @ciudad_id or ruta_ciudad_origen = @ciudad_id", "T", listaParametrosRuta);
            if (lector.HasRows)
            {
                while (lector.Read())
                {
                    Ruta ruta = new Ruta();
                    ruta.tipoServicioId = (int)(decimal)lector["ruta_tipo_servicio"];
                    ruta.id = (int)(decimal)lector["ruta_id"];
                    ruta.estado = (Boolean)lector["ruta_estado"];
                    ruta.ciudadDestinoId = (int)(decimal)lector["ruta_ciudad_destino"];
                    ruta.ciudadOrigenId = (int)(decimal)lector["ruta_ciudad_origen"];
                    ruta.precioBaseKg = (int)(decimal)lector["ruta_precio_basekg"];
                    ruta.precioBasePasaje = (int)(decimal)lector["ruta_precio_basepasaje"];

                    DAORuta.baja(ruta);
                }
            }
            return Convert.ToInt32(DBAcess.WriteInBase("update SQLOVERS.ciudad set ciudad_estado=@ciudad_estado where ciudad_id=@ciudad_id","T", listaParametros));
        }

        public static Ciudad getCiudad(int id)
        {
            List<SqlParameter> parameterList = new List<SqlParameter>();
            parameterList.Add(new SqlParameter("@ciudad_id", id));
            SqlDataReader lector = DBAcess.GetDataReader("SELECT * from SQLOVERS.CIUDAD where ciudad_id=@ciudad_id", "T", parameterList);

            if (lector.HasRows)
            {
                while (lector.Read())
                {
                    Ciudad ciudad = new Ciudad();
                    ciudad.nombre = (string)lector["ciudad_nombre"];
                    ciudad.id = (int)(decimal)lector["ciudad_id"];
                    ciudad.estado = (Boolean)lector["ciudad_estado"];

                    return ciudad;
                }
            }
            return new Ciudad();
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
        }


        public static List<Ciudad> retrieveAll()
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
        }

        public  List<Ciudad> getOrigenes(int id) {

            List<Ciudad> ciudadList = new List<Ciudad>();

            string comando = String.Format("select ciudad_nombre from sqlovers.ciudad join  sqlovers.ruta on ruta_ciudad_origen = ciudad_id join  sqlovers.vuelo on vuelo_ruta_id = ruta_id where vuelo_aeronave_id = {0} group by ciudad_nombre", id);
            ciudadList = DB.ExecuteReader<Ciudad>(comando);

            return ciudadList;
        }

    }
}
