using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AerolineaFrba.Models.BO
{


    public partial class LlegadaDestino : IBO<LlegadaDestino>
    {
        public LlegadaDestino() { }

        public LlegadaDestino(System.Data.DataRow dr)
        {
            initialize(dr);
        }

        public Int32 id { get; set; }
        public string matricula { get; set; }
        public DateTime fecha_arribo { get; set; }
        public int origen_id { get; set; }
        public int destino_id { get; set; }
        public int vuelo_id { get; set; }

        public LlegadaDestino initialize(System.Data.DataRow _dr)
        {
            dr = _dr;
            DataColumnCollection dcc = dr.Table.Columns;

            if (dcc.Contains("llegada_codigo"))
                id = (dr["llegada_codigo"] == DBNull.Value) ? 0 : Convert.ToInt32(dr["llegada_codigo"]);


            if (dcc.Contains("llegada_matricula"))
                matricula = (dr["llegada_matricula"] == DBNull.Value) ? null : dr["llegada_matricula"].ToString();

            if (dcc.Contains("llegada_horaArrivo"))
                fecha_arribo = Convert.ToDateTime(dr["llegada_horaArrivo"]);

            if (dcc.Contains("llegada_origen"))
                origen_id = (dr["llegada_origen"] == DBNull.Value) ? 0 : Convert.ToInt32(dr["llegada_origen"]);


            if (dcc.Contains("llegada_destino"))
                destino_id = (dr["llegada_destino"] == DBNull.Value) ? 0 : Convert.ToInt32(dr["llegada_destino"]);

            if (dcc.Contains("llegada_vuelo_id"))
                vuelo_id = (dr["llegada_vuelo_id"] == DBNull.Value) ? 0 : Convert.ToInt32(dr["llegada_vuelo_id"]);

            return this;
        }

        private DataRow dr;

        public LlegadaDestino setData(DataRow dr)
        {
            initialize(dr);

            return this;
        }
    }


}
