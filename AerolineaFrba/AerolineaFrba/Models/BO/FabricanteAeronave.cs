using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AerolineaFrba.Models.BO
{
    public partial class FabricanteAeronave : IBO<FabricanteAeronave>
    {
        public FabricanteAeronave() { }

        public FabricanteAeronave(System.Data.DataRow dr)
        {
            initialize(dr);
        }

        public int id { get; set; }
        public string nombre { get; set; }

        public FabricanteAeronave initialize(System.Data.DataRow _dr)
        {
            dr = _dr;
            DataColumnCollection dcc = dr.Table.Columns;

            if (dcc.Contains("fabricante_id"))
                id = (dr["fabricante_id"] == DBNull.Value) ? 0 : Convert.ToInt32(dr["fabricante_id"]);
            if (dcc.Contains("fabricante_nombre"))
                nombre = (dr["fabricante_nombre"] == DBNull.Value) ? null : dr["fabricante_nombre"].ToString();
            return this;
        }


        private DataRow dr;

        public FabricanteAeronave setData(DataRow dr)
        {
            initialize(dr);

            return this;
        }

    }
}
