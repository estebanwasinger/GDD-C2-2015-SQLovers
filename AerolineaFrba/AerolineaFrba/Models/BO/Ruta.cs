using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using AerolineaFrba.Models.DAO;
using System.Data;

namespace AerolineaFrba.Models.BO
{
    public partial class Ruta : IBO<Ruta>
    {
        public Ruta() { }
        
        public Ruta(System.Data.DataRow dr)
        {
            initialize(dr);
        }

        public Int32 id { get; set; }
        public string tipoServicio { get; set; }
        public string ciudadOrigen { get; set; }
        public string ciudadDestino { get; set; }
        public Int32 precioBasePasaje { get; set; }
        public Int32 precioBaseKg { get; set; }

        public Ruta initialize(System.Data.DataRow _dr)
        {
            dr = _dr;
            DataColumnCollection dcc = dr.Table.Columns;

            if (dcc.Contains("ruta_id"))
                id = (dr["ruta_id"] == DBNull.Value) ? 0 : Convert.ToInt32(dr["ruta_id"]);
            if (dcc.Contains("ruta_tipo_servicio"))
                tipoServicio = (dr["ruta_tipo_servicio"] == DBNull.Value) ? null : dr["ruta_tipo_servicio"].ToString();
            if (dcc.Contains("ciudad_origen"))
                ciudadOrigen = (dr["ciudad_origen"] == DBNull.Value) ? null : dr["ciudad_origen"].ToString();
            if (dcc.Contains("ciudad_destino"))
                ciudadDestino = (dr["ciudad_destino"] == DBNull.Value) ? null : dr["ciudad_destino"].ToString();
            if (dcc.Contains("ruta_precio_basepasaje"))
                precioBasePasaje = (dr["ruta_precio_basepasaje"] == DBNull.Value) ? 0 : Convert.ToInt32(dr["ruta_precio_basepasaje"]);
            if (dcc.Contains("ruta_precio_basekg"))
                precioBaseKg = (dr["ruta_precio_basekg"] == DBNull.Value) ? 0 : Convert.ToInt32(dr["ruta_precio_basekg"]);
            return this;
        }

        private DataRow dr;

        public Ruta setData(DataRow dr)
        {
            initialize(dr);

            return this;
        }

    }
}