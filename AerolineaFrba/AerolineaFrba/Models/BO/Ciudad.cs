using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using AerolineaFrba.Models.DAO;
using System.Data;

namespace AerolineaFrba.Models.BO
{
    public partial class Ciudad : IBO<Ciudad>
    {
        public Ciudad() { }

        public Ciudad(System.Data.DataRow dr)
        {
            initialize(dr);
        }

        public Int32 id { get; set; }
        public string nombre { get; set; }  

        public Ciudad initialize(System.Data.DataRow _dr)
        {
            dr = _dr;
            DataColumnCollection dcc = dr.Table.Columns;

            if (dcc.Contains("ciudad_id"))
                id = (dr["ciudad_id"] == DBNull.Value) ? 0 : Convert.ToInt32(dr["ciudad_id"]);
            if (dcc.Contains("ciudad_nombre"))
                nombre = (dr["ciudad_nombre"] == DBNull.Value) ? null : dr["ciudad_nombre"].ToString();
            return this;
        }

        private DataRow dr;

        public Ciudad setData(DataRow dr)
        {
            initialize(dr);

            return this;
        }
    }
}
