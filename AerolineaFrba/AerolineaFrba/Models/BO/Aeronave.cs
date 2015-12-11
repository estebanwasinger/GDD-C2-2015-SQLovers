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

        public int? id { get; set; }
        public string matricula { get; set; }
        public int? modelo { get; set; }
        public DateTime? fecha_alta { get; set; }
        public DateTime? fecha_vueltaFS { get; set; }

        public int? peso_disponible { get; set; }
        public int? cant_butacas_vent { get; set; }
        public int? cant_butacas_pas { get; set; }

        public int? fabricante { get; set; }
        public bool? activo { get; set; }
        public int? aeronave_tipo_servicio { get; set; }

        public string descripcion_tipoServicio { get; set; }


        public Aeronave initialize(DataRow _dr)
        {

            dr = _dr;
            DataColumnCollection dcc = dr.Table.Columns;

            if (dcc.Contains("aeronave_matricula"))
                matricula = (dr["aeronave_matricula"] == DBNull.Value) ? null : dr["aeronave_matricula"].ToString();

            if (dcc.Contains("aeronave_id"))
                id = (dr["aeronave_id"] == DBNull.Value) ? null : (int?)(decimal)dr["aeronave_id"];

            if (dcc.Contains("aeronave_modelo"))
                modelo = (dr["aeronave_modelo"] == DBNull.Value) ? null : (int?)(decimal)dr["aeronave_modelo"];

            if (dcc.Contains("fabricante_nombre"))
                fabricanteNombre = (dr["fabricante_nombre"] == DBNull.Value) ? null : (string)dr["fabricante_nombre"];

            if (dcc.Contains("modelo_nombre"))
                modeloNombre = (dr["modelo_nombre"] == DBNull.Value) ? null : (string)dr["modelo_nombre"];

            if (dcc.Contains("fabricante_id"))
                fabricante = (dr["fabricante_id"] == DBNull.Value) ? null : (int?)(decimal)dr["fabricante_id"];

            if (dcc.Contains("aeronave_kg_disponibles"))
                peso_disponible = (dr["aeronave_kg_disponibles"] == DBNull.Value) ? null : (int?)Convert.ToInt32(dr["aeronave_kg_disponibles"]);

            if (dcc.Contains("aeronave_but_vent"))
                cant_butacas_vent = (dr["aeronave_but_vent"] == DBNull.Value) ? null : (int?)Convert.ToInt32(dr["aeronave_but_vent"]);

            if (dcc.Contains("aeronave_but_pasill"))
                cant_butacas_pas = (dr["aeronave_but_pasill"] == DBNull.Value) ? null : (int?)Convert.ToInt32(dr["aeronave_but_pasill"]);

            if (dcc.Contains("aeronave_fabricante"))
                fabricante = (dr["aeronave_fabricante"] == DBNull.Value) ? null : (int?)dr["aeronave_fabricante"];

            if (dcc.Contains("aeronave_tipo_servicio"))
                aeronave_tipo_servicio = (dr["aeronave_tipo_servicio"] == DBNull.Value) ? null : (int?)Convert.ToInt32(dr["aeronave_tipo_servicio"]);

            if (dcc.Contains("aeronave_fecha_alta"))
                fecha_alta = (dr["aeronave_fecha_alta"] == DBNull.Value) ? null : (DateTime?)Convert.ToDateTime(dr["aeronave_fecha_alta"]);

            if (dcc.Contains("aeronave_fecha_vueltaFS"))
                fecha_vueltaFS = (dr["aeronave_fecha_vueltaFS"] == DBNull.Value) ? null : (DateTime?)Convert.ToDateTime(dr["aeronave_fecha_vueltaFS"]);
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

        public int getCantidadButacasPasillo()
        {

            DAOAeronave daoAer = new DAOAeronave();
            int cant_butacas_totales;
            cant_butacas_totales = daoAer.retrieveButacasPasillo(this.matricula);
            return (int)cant_butacas_totales;

        }

        public int getCantidadButacasVentanilla()
        {

            DAOAeronave daoAer = new DAOAeronave();
            int cant_butacas_totales;
            cant_butacas_totales = daoAer.retrieveButacasVentanilla(this.matricula);
            return (int)cant_butacas_totales;

        }

        public bool estaDisponible(DateTime fecha_sal)
        {

            bool disponible = true;
            int aviones_con_misma_fsalida = 0;

            DAOVuelo daoVuelo = new DAOVuelo();
            List<Vuelo> LsVuelos = new List<Vuelo>();

            LsVuelos = daoVuelo.search(DAOAeronave.getAeronaveFromMatricula(this.matricula).id);

            foreach (Vuelo velo in LsVuelos)
            {


                if (velo.fechaSalida.Equals(fecha_sal))
                {
                    System.Console.WriteLine("la fecha de la tabla vuelo es:" + velo.fechaSalida);
                    disponible = false;
                    aviones_con_misma_fsalida++;
                }
            }
            return disponible;
        }

        public override int GetHashCode()
        {
            return base.GetHashCode();
        }


        public string fabricanteNombre { get; set; }
        public string modeloNombre { get; set; }
    }
}