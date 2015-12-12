using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AerolineaFrba.Models.BO
{
    public partial class ModeloAeronave : IBO<ModeloAeronave>
    {

         public ModeloAeronave() { }

         public ModeloAeronave(System.Data.DataRow dr)
        {
            initialize(dr);
        }
        public int id { get; set; }
        public string nombre { get; set; }
        public int fabricante { get; set; }

        public ModeloAeronave initialize(System.Data.DataRow _dr)
        {
            dr = _dr;
            DataColumnCollection dcc = dr.Table.Columns;

            if (dcc.Contains("modelo_id"))
                id = (dr["modelo_id"] == DBNull.Value) ? 0 : Convert.ToInt32(dr["modelo_id"]);
            if (dcc.Contains("modelo_nombre"))
                nombre = (dr["modelo_nombre"] == DBNull.Value) ? null : dr["modelo_nombre"].ToString();
            return this;
            }

        private DataRow dr;

        public ModeloAeronave setData(DataRow dr)
        {
            initialize(dr);

            return this;
        }

    }
}
