using AerolineaFrba.Models.BO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;

namespace AerolineaFrba.Models.DAO
{
    public partial class Producto : IBO<Producto>
    {
        public Producto() { }

        public Producto(System.Data.DataRow dr)
        {
            initialize(dr);
        }

        public Int32 id { get; set; }
        public string nombre { get; set; }
        public Int32 millas { get; set; }

        public Producto initialize(System.Data.DataRow _dr)
        {
            dr = _dr;
            DataColumnCollection dcc = dr.Table.Columns;

            if (dcc.Contains("producto_id"))
                id = (dr["producto_id"] == DBNull.Value) ? 0 : Convert.ToInt32(dr["producto_id"]);
            if (dcc.Contains("producto_nombre"))
                nombre = (dr["producto_nombre"] == DBNull.Value) ? null : dr["producto_nombre"].ToString();
            if (dcc.Contains("producto_cantMillas"))
                millas = (dr["producto_cantMillas"] == DBNull.Value) ? 0 : Convert.ToInt32(dr["producto_cantMillas"]);
            return this;
        }

        private DataRow dr;

        public Producto setData(DataRow dr)
        {
            initialize(dr);

            return this;
        }
    }
}
