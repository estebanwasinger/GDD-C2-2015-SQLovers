using System;

using System.Text;
using System.Linq;
using System.Web;
using System.Data;
using System.Collections.Generic;

using AerolineaFrba.Models.DAO;

namespace AerolineaFrba.Models.BO
{
    public partial class Aeronave : IBO<Aeronave>
    {

        public Aeronave() { }

        public Aeronave(DataRow dr)
        {
            initialize(dr);
        }

        public string matricula { get; set; }
        public string modelo { get; set; }       
        public DateTime? fecha_alta { get; set; }
        public int? peso_disponible { get; set; }
        public int? cant_butacas_vent { get; set; }
        public int? cant_butacas_pas { get; set; }

        public string fabricante { get; set; }
        public bool? activo { get; set; }
        public int? aeronave_tipo_servicio { get; set; }

        public string descripcion_tipoServicio { get; set; }
        

        public Aeronave initialize(DataRow _dr)
        {

            dr = _dr;
            DataColumnCollection dcc = dr.Table.Columns;

            if (dcc.Contains("aeronave_matricula"))
                matricula = (dr["aeronave_matricula"] == DBNull.Value) ? null : dr["aeronave_matricula"].ToString();
            if (dcc.Contains("aeronave_modelo"))
                modelo = (dr["aeronave_modelo"] == DBNull.Value) ? null : dr["aeronave_modelo"].ToString();
            
            if (dcc.Contains("aeronave_kg_disponibles"))
                peso_disponible = (dr["aeronave_kg_disponibles"] == DBNull.Value) ? null : (int?)Convert.ToInt32(dr["aeronave_kg_disponibles"]);

            if (dcc.Contains("aeronave_but_vent"))
                cant_butacas_vent = (dr["aeronave_but_vent"] == DBNull.Value) ? null : (int?)Convert.ToInt32(dr["aeronave_but_vent"]);

            if (dcc.Contains("aeronave_but_pasill"))
                cant_butacas_pas = (dr["aeronave_but_pasill"] == DBNull.Value) ? null : (int?)Convert.ToInt32(dr["aeronave_but_pasill"]);
           

            if (dcc.Contains("aeronave_fabricante"))
                fabricante = (dr["aeronave_fabricante"] == DBNull.Value) ? null : dr["aeronave_fabricante"].ToString();

            if (dcc.Contains("aeronave_tipo_servicio"))
                aeronave_tipo_servicio = (dr["aeronave_tipo_servicio"] == DBNull.Value) ? null : (int?)Convert.ToInt32(dr["aeronave_tipo_servicio"]);

            if (dcc.Contains("aeronave_fecha_alta"))
                fecha_alta = (dr["aeronave_fecha_alta"] == DBNull.Value) ? null : (DateTime?)Convert.ToDateTime(dr["aeronave_fecha_alta"]);

            return this;
        }

        private DataRow dr;

        public Aeronave setData(DataRow dr)
        {
            initialize(dr);

            return this;
        }



        public string get_service()
        {
            DAOServicio daoServ = new DAOServicio();
            Servicio serv = daoServ.retrieveBy_id_serv(this.aeronave_tipo_servicio);
            return serv.tipo_servicio_nombre;
        }

        public int getCantidadButacas() {

            DAOAeronave daoAer = new DAOAeronave();
            int cant_butacas_totales;
            cant_butacas_totales = daoAer.retrieveButacas(this.matricula);
            return (int)cant_butacas_totales;
        
        }

        public bool estaDisponible(DateTime fecha_sal) {

            bool disponible = true;
            int aviones_con_misma_fsalida = 0;

            DAOVuelo daoVuelo = new DAOVuelo();
            List<Vuelo> LsVuelos = new List<Vuelo>();

            LsVuelos = daoVuelo.search(this.matricula);
             
            foreach(Vuelo velo in LsVuelos){


                if (velo.fechaSalida.Equals(fecha_sal))
                {
                        System.Console.WriteLine("la fecha de la tabla vuelo es:" + velo.fechaSalida);
                        disponible = false;
                        aviones_con_misma_fsalida++;
                    }
            }
            return disponible;   
        }


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