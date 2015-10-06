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
        public string nombre { get; set; }
        public bool? activo { get; set; }

        public Rol initialize(DataRow _dr)
        {

            dr = _dr;
            DataColumnCollection dcc = dr.Table.Columns;

            if (dcc.Contains("id"))
                id = (dr["id"] == DBNull.Value) ? null : (int?)Convert.ToInt32(dr["id"]);
            if (dcc.Contains("nombre"))
                nombre = (dr["nombre"] == DBNull.Value) ? null : dr["nombre"].ToString();
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

        public void setById(object _id)
        {
            initialize(new DAORol().retrieveBy_id(_id).dr);
        }

        public override bool Equals(object obj)
        {
            if (obj == null)
                return false;

            Rol aux = obj as Rol;
            if ((object)aux == null)
                return false;

            return aux.id == id;
        }

        public override int GetHashCode()
        {
            return base.GetHashCode();
        }


        #region Miembros de IBO<Rol>

        Rol IBO<Rol>.setData(DataRow dr)
        {
            throw new NotImplementedException();
        }

        #endregion
    }
}