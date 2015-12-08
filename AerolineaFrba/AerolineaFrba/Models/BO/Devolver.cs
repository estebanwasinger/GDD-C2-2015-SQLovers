using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AerolineaFrba.Models.BO
{
    public partial class Devolver : IBO<Devolver>
    { 
    
    public Devolver() { }

    public Devolver(System.Data.DataRow dr)
        {
            initialize(dr);
        }

        public Int32 id { get; set; }
        public DateTime fechaDev { get; set; }
        public string detalle { get; set; }
        public int item { get; set; }


        public Devolver initialize(System.Data.DataRow _dr)
        {
            dr = _dr;
            DataColumnCollection dcc = dr.Table.Columns;

            if (dcc.Contains("devolucion_id"))
                id = (dr["devolucion_id"] == DBNull.Value) ? 0 : Convert.ToInt32(dr["devolucion_id"]);
            if (dcc.Contains("devolucion_fecha"))
                fechaDev = Convert.ToDateTime(dr["devolucion_fecha"]);


            if (dcc.Contains("devolucion_detalle"))
                detalle = (dr["devolucion_detalle"] == DBNull.Value) ? null : dr["devolucion_detalle"].ToString();

            return this;
        }

        private DataRow dr;

        public Devolver setData(DataRow dr)
        {
            initialize(dr);

            return this;
        }
    
    }
}
