using System;
using System.Text;
using System.Linq;
using System.Web;
using System.Data;
using System.Collections.Generic;

using AerolineaFrba.Models.DAO;

namespace AerolineaFrba.Models.BO
{
    public partial class Funcionalidad : IBO<Funcionalidad>
    {

        public Funcionalidad  () { }

        public Funcionalidad(DataRow dr)
        {
            initialize(dr);
        }

        public int? id { get; set; }
        public string name { get; set; }

        public Funcionalidad initialize(DataRow _dr)
        {

            dr = _dr;
            DataColumnCollection dcc = dr.Table.Columns;

            if (dcc.Contains("id"))
                id = (dr["id"] == DBNull.Value) ? null : (int?)Convert.ToInt32(dr["id"]);
            if (dcc.Contains("name"))
                name = (dr["name"] == DBNull.Value) ? null : dr["name"].ToString();

            return this;
        }

        private DataRow dr;

        public Funcionalidad setData(DataRow dr)
        {
            initialize(dr);

            return this;
        }
    }
}
