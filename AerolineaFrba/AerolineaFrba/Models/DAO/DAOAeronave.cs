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
    public partial class DAOAeronave : DAOBase<Aeronave>
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
                string comando = "INSERT INTO SQLOVERS.AERONAVE(aeronave_matricula, aeronave_modelo, aeronave_kg_disponibles, aeronave_fecha_alta, aeronave_tipo_servicio, aeronave_but_vent, aeronave_but_pasill)"
                                    + "VALUES ({0},{1},{2},{3},{4},{5},{6})";

                comando = String.Format(comando, stringQuereable(_Aeronave.matricula), _Aeronave.modelo, _Aeronave.peso_disponible, fechaQuereable(_Aeronave.fecha_alta), _Aeronave.aeronave_tipo_servicio, _Aeronave.cant_butacas_vent, _Aeronave.cant_butacas_pas);
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

                ListaParametros.Add(new SqlParameter("@aeronave_matricula", aero.matricula));
                ListaParametros.Add(new SqlParameter("@aeronave_modelo", aero.modelo));
                ListaParametros.Add(new SqlParameter("@aeronave_kg_disponibles", (int)aero.peso_disponible));
                ListaParametros.Add(new SqlParameter("@aeronave_fabricante", aero.fabricante));
                ListaParametros.Add(new SqlParameter("@aeronave_tipo_servicio", (int)aero.aeronave_tipo_servicio));
                ListaParametros.Add(new SqlParameter("@aeronave_id", (int)aero.id));


                return DBAcess.WriteInBase("update SQLOVERS.aeronave set aeronave_matricula =@aeronave_matricula, aeronave_modelo=@aeronave_modelo, aeronave_kg_disponibles=@aeronave_kg_disponibles," +
                    "aeronave_fabricante=@aeronave_fabricante,aeronave_tipo_servicio=@aeronave_tipo_servicio WHERE aeronave_id=@aeronave_id", "T", ListaParametros);
            }
            catch { return false; }
        }

        public bool bajaDef(int id, DateTime fechaBajaDef)
        {
            List<SqlParameter> listaParametros = new List<SqlParameter>();
            listaParametros.Add(new SqlParameter("@aeronave_id", id));
            listaParametros.Add(new SqlParameter("@fecha_baja", fechaBajaDef.ToString("MM/dd/yyyy hh:mm:ss")));

            return DBAcess.WriteInBase("update SQLOVERS.AERONAVE set aeronave_estado = 2, aeronave_fecha_bajaDefinitiva = @fecha_baja where aeronave_id = @aeronave_id ", "T", listaParametros);
        }

        public int estaDisponible(string matricula)
        {

            // string comando = "select aeronave_estado from SQLOVERS.AERONAVE  where " + String.Format(" aeronave_matricula like '{0}%' ", matricula);
            //DB.ExecuteNonQuery(comando);

            int estado = DB.ExecuteCardinal(String.Format("select sqlovers.estadoAeronave('{0}%')", matricula));
            //DB.ExecuteNonQuery(String.Format("EXECUTE SQLOVERS.estadoAeronave '{0}%'", matricula));
            return estado;
        }

        public static List<Aeronave> getDisponiblesEntre(DateTime fechaInicio, DateTime fechaFin)
        {

            List<SqlParameter> ListaParametros = new List<SqlParameter>();

            ListaParametros.Add(new SqlParameter("@fecha_inicio", fechaInicio));
            ListaParametros.Add(new SqlParameter("@fecha_fin", fechaFin));

            SqlDataReader lector = DBAcess.GetDataReader("SELECT * FROM SQLOVERS.VUELO v RIGHT OUTER JOIN SQLOVERS.AERONAVE a ON v.vuelo_aeronave_id = a.aeronave_id AND v.vuelo_fecha_salida > @fecha_inicio AND V.vuelo_fecha_llegada_estimada < @fecha_fin, SQLOVERS.MODELO m , SQLOVERS.FABRICANTE f, SQLOVERS.TIPO_SERVICIO t WHERE v.vuelo_fecha_salida IS NULL AND m.modelo_fabricante = f.fabricante_id AND a.aeronave_modelo = m.modelo_id AND t.tipo_servicio_id = a.aeronave_tipo_servicio", "T", ListaParametros);

            return getAeronaveListFromLector(lector);


        }

        public void bajaFueraServicio(int id, DateTime fechaRegreso, DateTime fechaBajaFS)
        {
            List<SqlParameter> listaParametros = new List<SqlParameter>();
            listaParametros.Add(new SqlParameter("@aeronave_id", id));
            DBAcess.WriteInBase("UPDATE sqlovers.AERONAVE SET aeronave_estado = 1 WHERE aeronave_id = @aeronave_id ", "T", listaParametros);

            listaParametros = new List<SqlParameter>();
            listaParametros.Add(new SqlParameter("@aeronave_id", id));
            listaParametros.Add(new SqlParameter("@fechaRegreso", fechaRegreso.ToString("MM/dd/yyyy hh:mm:ss")));
            listaParametros.Add(new SqlParameter("@fechaBajaFS", fechaBajaFS.ToString("MM/dd/yyyy hh:mm:ss")));
            DBAcess.WriteInBase("INSERT sqlovers.AERONAVE_BAJAS (aeronave_id,aeronave_baja_fecha_vueltafs,aeronave_baja_fecha_bajatecnica) VALUES (@aeronave_id, CONVERT(DATETIME,@fechaRegreso,121), CONVERT(DATETIME,@fechaBajaFS,121)) ", "T", listaParametros);


        }

        public List<Aeronave> aeronave_servicio()
        {

            string comando = "select A.aeronave_matricula, A.aeronave_id ,TS.tipo_servicio_nombre from SQLOVERS.AERONAVE A inner join SQLOVERS.TIPO_SERVICIO TS on " +
                             " A.aeronave_tipo_servicio = TS.tipo_servicio_id";

            // string comando = "select aeronave_matricula,aeronave_tipo_servicio from SQLOVERS.AERONAVE";

            List<Aeronave> LA = DB.ExecuteReader<Aeronave>(comando);

            foreach (Aeronave aer in LA)
            {

                string command = "select TS.tipo_servicio_nombre from SQLOVERS.AERONAVE A inner join SQLOVERS.TIPO_SERVICIO TS on "
+ " A.aeronave_tipo_servicio = TS.tipo_servicio_id where " + String.Format("  A.aeronave_matricula like '{0}%' ", aer.matricula);
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

        public int retrieveButacasVentanilla(int matricula)
        {

            string command = "select count(*) from SQLOVERS.BUTACA where " + String.Format("  butaca_aeronave = {0} and butaca_tipo like 'Ventanilla' ", matricula);
            return DB.ExecuteCardinal(command);
        }

        public int retrieveButacasPasillo(int matricula)
        {

            string command = "select count(*) from SQLOVERS.BUTACA where " + String.Format("  butaca_aeronave = {0} and butaca_tipo like 'Pasillo' ", matricula);
            return DB.ExecuteCardinal(command);
        }


        public static ModeloAeronave getNombreModelo(int modelo)
        {


            List<SqlParameter> parameterList = new List<SqlParameter>();
            parameterList.Add(new SqlParameter("@modelo_id", modelo));
            SqlDataReader lector = DBAcess.GetDataReader("SELECT * from SQLOVERS.MOdelo where modelo_id=@modelo_id", "T", parameterList);

            if (lector.HasRows)
            {
                while (lector.Read())
                {
                    ModeloAeronave mA = new ModeloAeronave();
                    mA.nombre = (string)lector["modelo_nombre"];
                    mA.fabricante = (int)(decimal)lector["modelo_fabricante"];
                    return mA;
                }
            }
            return new ModeloAeronave();

        }

        public static FabricanteAeronave getNombreFabricante(int fabricante)
        {

            List<SqlParameter> parameterList = new List<SqlParameter>();
            parameterList.Add(new SqlParameter("@fabricante_id", fabricante));
            SqlDataReader lector = DBAcess.GetDataReader("SELECT * from SQLOVERS.FABRICANTE where fabricante_id=@fabricante_id", "T", parameterList);

            if (lector.HasRows)
            {
                while (lector.Read())
                {
                    FabricanteAeronave Fa = new FabricanteAeronave();
                    Fa.nombre = (string)lector["fabricante_nombre"];
                    Fa.id = (int)(decimal)lector["fabricante_id"];
                    return Fa;
                }
            }
            return new FabricanteAeronave();

        }


        public List<Aeronave> search(string matricula, string fabricante, string modelo, string peso)
        {
            List<Aeronave> lc = new List<Aeronave>();

            if (String.IsNullOrEmpty(matricula) && String.IsNullOrEmpty(fabricante) && String.IsNullOrEmpty(modelo)
                && String.IsNullOrEmpty(peso))
            {

                String query = String.Format("SELECT aeronave_id, f.fabricante_nombre, f.fabricante_id, m.modelo_nombre, [aeronave_matricula],[aeronave_modelo],[aeronave_kg_disponibles],[aeronave_fecha_alta],[aeronave_tipo_servicio],[aeronave_but_vent],[aeronave_but_pasill],[aeronave_fecha_bajadefinitiva],[aeronave_estado] FROM [GD2C2015].[SQLOVERS].[AERONAVE], SQLOVERS.MODELO m , SQLOVERS.FABRICANTE f WHERE m.modelo_id = aeronave_modelo AND m.modelo_fabricante = f.fabricante_id ");
                return DB.ExecuteReader<Aeronave>(query);
            }


            String base_query = String.Format("SELECT aeronave_id, f.fabricante_nombre, f.fabricante_id, m.modelo_nombre, [aeronave_matricula],[aeronave_modelo],[aeronave_kg_disponibles],[aeronave_fecha_alta],[aeronave_tipo_servicio],[aeronave_but_vent],[aeronave_but_pasill],[aeronave_fecha_bajadefinitiva],[aeronave_estado] FROM [GD2C2015].[SQLOVERS].[AERONAVE], SQLOVERS.MODELO m , SQLOVERS.FABRICANTE f WHERE m.modelo_id = aeronave_modelo AND m.modelo_fabricante = f.fabricante_id AND");
            if (!String.IsNullOrEmpty(matricula))
            {
                base_query += String.Format(" aeronave_matricula like '{0}%' AND", matricula);
            }

            if (!(fabricante == null))
            {
                base_query += String.Format(" f.fabricante_nombre like '{0}%' AND", fabricante);
            }

            if (!(modelo == null))
            {
                base_query += String.Format(" m.modelo_nombre LIKE '{0}%' AND", modelo);
            }

            if (!String.IsNullOrEmpty(peso))
            {
                base_query += String.Format(" aeronave_kg_disponibles = '{0}' AND", peso);
            }

            base_query = base_query.Substring(0, base_query.Length - 3);

            return DB.ExecuteReader<Aeronave>(base_query);
        }

        public List<Aeronave> retrieveAll()
        {

            SqlDataReader lector = DBAcess.GetDataReader("SELECT aeronave_id, f.fabricante_nombre, f.fabricante_id,  m.modelo_nombre, [aeronave_matricula],[aeronave_modelo],[aeronave_kg_disponibles],[aeronave_fecha_alta],[aeronave_tipo_servicio],[aeronave_but_vent],[aeronave_but_pasill],[aeronave_fecha_bajadefinitiva],[aeronave_estado] FROM [GD2C2015].[SQLOVERS].[AERONAVE], SQLOVERS.MODELO m , SQLOVERS.FABRICANTE f " +
"WHERE m.modelo_id = aeronave_modelo AND m.modelo_fabricante = f.fabricante_id ", "T", new List<SqlParameter>());

            List<Aeronave> l = getAeronaveListFromLector(lector);
            return l;
        }

        public static Aeronave getAeronaveFromMatricula(String matricula)
        {

            SqlDataReader lector = DBAcess.GetDataReader("SELECT aeronave_id, f.fabricante_nombre, f.fabricante_id,  m.modelo_nombre, [aeronave_matricula],[aeronave_modelo],[aeronave_kg_disponibles],[aeronave_fecha_alta],[aeronave_tipo_servicio],[aeronave_but_vent],[aeronave_but_pasill],[aeronave_fecha_bajadefinitiva],[aeronave_estado] FROM [GD2C2015].[SQLOVERS].[AERONAVE], SQLOVERS.MODELO m , SQLOVERS.FABRICANTE f " +
"WHERE m.modelo_id = aeronave_modelo AND m.modelo_fabricante = f.fabricante_id AND aeronave_matricula='" + matricula + "'", "T", new List<SqlParameter>());

            List<Aeronave> aeronaveList = getAeronaveListFromLector(lector);
            if (aeronaveList.Count > 0)
            {
                return aeronaveList[0];
            }
            else { return null; }
        }

        private static List<Aeronave> getAeronaveListFromLector(SqlDataReader lector)
        {
            List<Aeronave> l = new List<Aeronave>();
            if (lector.HasRows)
            {
                while (lector.Read())
                {
                    Aeronave aeRonave = new Aeronave();
                    aeRonave.id = (int)(decimal)lector["aeronave_id"];
                    aeRonave.matricula = (string)lector["aeronave_matricula"];
                    aeRonave.peso_disponible = (int)(decimal)lector["aeronave_kg_disponibles"];
                    aeRonave.modelo = (int?)(decimal)lector["aeronave_modelo"];
                    aeRonave.modeloNombre = lector["modelo_nombre"] == DBNull.Value ? null : (string)lector["modelo_nombre"];
                    aeRonave.fabricante = (int?)(decimal)lector["fabricante_id"];
                    aeRonave.fabricanteNombre = lector["fabricante_nombre"] == DBNull.Value ? null : (string)lector["fabricante_nombre"];
                    aeRonave.cant_butacas_pas = (int)(decimal)lector["aeronave_but_pasill"];
                    aeRonave.cant_butacas_vent = (int)(decimal)lector["aeronave_but_vent"];
                    aeRonave.aeronave_tipo_servicio = (int)(decimal)lector["aeronave_tipo_servicio"];
                    try { aeRonave.descripcion_tipoServicio = (string)lector["tipo_servicio_nombre"]; }
                    catch { }

                    l.Add(aeRonave);
                }
            }
            return l;
        }

        public List<Aeronave> listaAero(int? aeronave, DateTime fecha_salida)
        {

            string comando =
"DECLARE @var1 numeric(18,0);DECLARE @var2 nvarchar(30);DECLARE @var3 numeric(3,0);" +

"SELECT @var1 = aeronave_modelo, @var2=(select sqlovers.obtenerFabricante(aeronave_modelo)), @var3=aeronave_tipo_servicio " +
"FROM SQLOVERS.AERONAVE WHERE" + String.Format(" aeronave_id = {0} ", aeronave) +

"SELECT aeronave_matricula,aeronave_id,aeronave_modelo,(select sqlovers.obtenerFabricante(aeronave_modelo)) as Fabricante,aeronave_tipo_servicio from SQLOVERS.AERONAVE " +
"where aeronave_modelo=@var1 and (select sqlovers.obtenerFabricante(aeronave_modelo))=@var2 and aeronave_tipo_servicio=@var3 and  " + String.Format(" aeronave_id not like '{0}' and SQLOVERS.validar_fechaSalida(aeronave_matricula,{1}) = 1 ", aeronave, fechaQuereable(fecha_salida));

            return DB.ExecuteReader<Aeronave>(comando);
        }

        public int reemplazoAeronave(int aeronaveId, int vuelo_id)
        {
            int cant_filas_actual = DB.ExecuteNonQuery(String.Format("EXECUTE SQLOVERS.reemplazar_vuelo '{0}',{1}", aeronaveId, vuelo_id));
            return cant_filas_actual;
        }
    }
}