using System;
using System.Data;
using AerolineaFrba.Models.DAO;

namespace AerolineaFrba.Models.BO
{
    public partial class RolFuncionalidad : IBO<RolFuncionalidad>
    {
        public int? id_rol { get; set; }
        public int? id_funcionalidad { get; set; }
        
        public RolFuncionalidad() { }

        public RolFuncionalidad(DataRow dr)
        {
            initialize(dr);
        }

        public RolFuncionalidad initialize(DataRow _dr)
        {

            dr = _dr;
            DataColumnCollection dcc = dr.Table.Columns;

            if (dcc.Contains("id_rol"))
                id_rol = (dr["id_rol"] == DBNull.Value) ? null : (int?)Convert.ToInt32(dr["id_rol"]);
            if (dcc.Contains("id_funcionalidad"))
                id_funcionalidad = (dr["id_funcionalidad"] == DBNull.Value) ? null : (int?)Convert.ToInt32(dr["id_funcionalidad"]);
            return this;
        }

        private DataRow dr;

        public RolFuncionalidad setData(DataRow dr)
        {
            initialize(dr);

            return this;
        }

    }
}
