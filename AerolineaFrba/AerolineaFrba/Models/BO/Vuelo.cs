using System;

using System.Text;
using System.Linq;
using System.Web;
using System.Data;
using System.Collections.Generic;

using AerolineaFrba.Models.DAO;

namespace AerolineaFrba.Models.BO
{
    public partial class Vuelo : IBO<Vuelo>
    {

        public Vuelo() { }

        public Vuelo(DataRow dr)
        {
            initialize(dr);
        }

        public int? id { get; set; }

        public string aeronave { get; set; }   
    
        public DateTime fechaLlegada { get; set; }
        public DateTime fechaSalida { get; set; }
        public DateTime fechaLlegadaEstimada { get; set; }

        public int? ruta { get; set; }

        public Vuelo initialize(DataRow _dr)
        {

            dr = _dr;
            DataColumnCollection dcc = dr.Table.Columns;

            if (dcc.Contains("vuelo_aeronave_id"))
                aeronave = (dr["vuelo_aeronave_id"] == DBNull.Value) ? null : dr["vuelo_aeronave_id"].ToString();


            if (dcc.Contains("vuelo_id"))
                id = (dr["vuelo_id"] == DBNull.Value) ? null : (int?)Convert.ToInt32(dr["vuelo_id"]);
           
      

            if (dcc.Contains("vuelo_ruta_id"))
                ruta = (dr["vuelo_ruta_id"] == DBNull.Value) ? null : (int?)Convert.ToInt32(dr["vuelo_ruta_id"]);

            if (dcc.Contains("vuelo_fecha_salida"))
                fechaSalida = Convert.ToDateTime(dr["vuelo_fecha_salida"]);

            if (dcc.Contains("vuelo_fecha_llegada"))
                fechaLlegada = Convert.ToDateTime(dr["vuelo_fecha_llegada"]);

            return this;
        }

        private DataRow dr;

        public Vuelo setData(DataRow dr)
        {
            initialize(dr);

            return this;
        }



        /*public string get_service()
        {
            DAOServicio daoServ = new DAOServicio();
            Servicio serv = daoServ.retrieveBy_id_serv(this.aeronave_tipo_servicio);
            return serv.tipo_servicio_nombre;
        }*/

       /* public List<Tarjeta> get_tarjetas()
        {
            DAOTarjeta dao = new DAOTarjeta();
            List<Tarjeta> tarjetas = dao.retrieveByClientId(this.id);
            return tarjetas;
        }*/

       /* public void setById(object _id)
        {
            initialize(new DAOCliente().retrieveBy_id(_id).dr);
        }*/

      /*  public override bool Equals(object obj)
        {
            if (obj == null)
                return false;

            Aeronave aux = obj as Aeronave;
            if ((object)aux == null)
                return false;
        
            return aux.matricula == matricula;
        }*/

        public override int GetHashCode()
        {
            return base.GetHashCode();
        }

    }
}