using System;
using System.Text;
using System.Linq;
using System.Web;
using System.Data;
using System.Collections.Generic;

using AerolineaFrba.Models.DAO;

namespace AerolineaFrba.Models.BO
{
    public partial class Rol : IBO<Rol>
    {

        public Rol() { }

        public Rol(DataRow dr)
        {
            initialize(dr);
        }

        public int? id { get; set; }
        public string name { get; set; }
        public bool? activo { get; set; }

        public Rol initialize(DataRow _dr)
        {

            dr = _dr;
            DataColumnCollection dcc = dr.Table.Columns;

            if (dcc.Contains("id"))
                id = (dr["id"] == DBNull.Value) ? null : (int?)Convert.ToInt32(dr["id"]);
            if (dcc.Contains("name"))
                name = (dr["name"] == DBNull.Value) ? null : dr["name"].ToString();
            if (dcc.Contains("activo"))
                activo = (dr["activo"] == DBNull.Value) ? null : (bool?)Convert.ToBoolean(dr["activo"]);

            return this;
        }

        private DataRow dr;

        public Rol setData(DataRow dr)
        {
            initialize(dr);

            return this;
        }

    }
}
