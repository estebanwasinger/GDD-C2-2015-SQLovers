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
        public int? aeronave { get; set; }
        public DateTime? fechaLlegada { get; set; }
        public DateTime fechaSalida { get; set; }
        public DateTime fechaLlegadaEstimada { get; set; }

        public int? ruta { get; set; }

        public Vuelo initialize(DataRow _dr)
        {

            dr = _dr;
            DataColumnCollection dcc = dr.Table.Columns;

            if (dcc.Contains("vuelo_aeronave_id"))
                aeronave = (dr["vuelo_aeronave_id"] == DBNull.Value) ? null : (int?)(decimal)dr["vuelo_aeronave_id"];

            if (dcc.Contains("vuelo_id"))
                id = (dr["vuelo_id"] == DBNull.Value) ? null : (int?)Convert.ToInt32(dr["vuelo_id"]);

            if (dcc.Contains("vuelo_ruta_id"))
                ruta = (dr["vuelo_ruta_id"] == DBNull.Value) ? null : (int?)Convert.ToInt32(dr["vuelo_ruta_id"]);

            if (dcc.Contains("vuelo_fecha_salida"))
                fechaSalida = Convert.ToDateTime(dr["vuelo_fecha_salida"]);

            if (dcc.Contains("vuelo_fecha_llegada"))
                fechaLlegada = dr["vuelo_fecha_llegada"] == DBNull.Value ? null : (DateTime?)(dr["vuelo_fecha_llegada"]);

            if (dcc.Contains("vuelo_fecha_llegada_estimada"))
                fechaLlegadaEstimada = Convert.ToDateTime(dr["vuelo_fecha_llegada_estimada"]);


            return this;
        }

        private DataRow dr;

        public Vuelo setData(DataRow dr)
        {
            initialize(dr);

            return this;
        }

        public override int GetHashCode()
        {
            return base.GetHashCode();
        }

    }
}