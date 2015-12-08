using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AerolineaFrba.Models.BO;
using System.Data.SqlClient;
using AerolineaFrba.Models.DataBase;
using AerolineaFrba.Models.Utils;

namespace AerolineaFrba.Models.DAO
{
    class DAODevolucion : DAOBase<Devolver>
    {

        public DAODevolucion()
            : base("SQLOVERS.Devolucion", "devolucion_id")
        {
        }

        private string stringQuereable(string cadena)
        {
            return "'" + cadena + "'";
        }

        public void guardar(DateTime fechaDEV, string detalle, List<Pasaje> lstPasajes, List<Encomienda> lstEncom)
        {
            
                List<SqlParameter> ListaParametros = new List<SqlParameter>();

                ListaParametros.Add(new SqlParameter("@devolucion_fecha", fechaDEV));
                ListaParametros.Add(new SqlParameter("@devolucion_detalle", detalle));

                /*ListaParametros.Add(new SqlParameter("@llegada_origen", LlDestino.origen_id));
                ListaParametros.Add(new SqlParameter("@llegada_destino", LlDestino.destino_id));
                ListaParametros.Add(new SqlParameter("@llegada_vuelo_id", LlDestino.vuelo_id));*/


                 DBAcess.WriteInBase("insert into SQLOVERS.DEVOLUCION (devolucion_fecha, devolucion_detalle) VALUES(@devolucion_fecha, @devolucion_detalle)", "T", ListaParametros);

                 string command = String.Format(" select * from sqlovers.devolucion where devolucion_fecha = '{0}' ", fechaDEV);

                 Devolver dev= DB.ExecuteReaderSingle<Devolver>(command);


                 foreach (Pasaje pasaje in lstPasajes)
                 {
                     List<SqlParameter> ListaParametros_dos = new List<SqlParameter>();
                     ListaParametros_dos.Add(new SqlParameter("@devolucion", dev.id));

                     ListaParametros_dos.Add(new SqlParameter("@pasaje", pasaje.codigo));
                     DBAcess.WriteInBase("insert into SQLOVERS.DEV_PASAJE (devolucion, pasaje) VALUES(@devolucion, @pasaje)", "T", ListaParametros_dos);
                 }

                 foreach (Encomienda encomienda in lstEncom)
                 {
                     List<SqlParameter> ListaParametros_tres = new List<SqlParameter>();
                     ListaParametros_tres.Add(new SqlParameter("@devolucion", dev.id));

                     ListaParametros_tres.Add(new SqlParameter("@encomienda", encomienda.id));
                     DBAcess.WriteInBase("insert into SQLOVERS.DEV_ENCOMIENDA (devolucion, encomienda) VALUES(@devolucion, @encomienda)", "T", ListaParametros_tres);
                 }


        }


    }
}
