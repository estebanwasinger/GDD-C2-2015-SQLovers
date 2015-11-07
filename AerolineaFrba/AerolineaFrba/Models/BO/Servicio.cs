using System;
using System.Text;
using System.Linq;
using System.Web;
using System.Data;
using System.Collections.Generic;

using AerolineaFrba.Models.DAO;

namespace AerolineaFrba.Models.BO {
    public partial class Servicio : IBO<Servicio>{
		
        public Servicio() {}

        public Servicio(DataRow dr) {
            initialize(dr);
        }

       // public enum Monedas { Dolar = 1 };
        public int tipo_servicio_id { get; set; }
        public string tipo_servicio_nombre { get; set; }
		
        public Servicio initialize(DataRow _dr) {
			
			dr = _dr;
            DataColumnCollection dcc = dr.Table.Columns;

            if (dcc.Contains("tipo_servicio_id"))
                tipo_servicio_id = (dr["tipo_servicio_id"] == DBNull.Value) ? 0 : (int)Convert.ToInt32(dr["tipo_servicio_id"]);
            if (dcc.Contains("tipo_servicio_nombre"))
                tipo_servicio_nombre = (dr["tipo_servicio_nombre"] == DBNull.Value) ? null : dr["tipo_servicio_nombre"].ToString();
			
            return this;
        }
		
        private DataRow dr;
		
		public Servicio setData(DataRow dr) {
            initialize(dr);
			
			return this;
        }
		
       /* public void setById(object _id) {
            initialize(new DAOMoneda().retrieveBy_id(_id).dr);
        }*/
		
		public override bool Equals(object obj) {
            if (obj == null)
                return false;

            Servicio aux = obj as Servicio;
            if ((object)aux == null)
                return false;

            return aux.tipo_servicio_id == tipo_servicio_id;
		}

        public override int GetHashCode()
        {
            return base.GetHashCode();
        }

        public override string ToString()
        {
            return this.tipo_servicio_nombre;
        }
    }
}
