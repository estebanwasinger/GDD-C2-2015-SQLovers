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
        public Int32 tipoServicioId { get; set; }
        public String tipoServicioNombre { get; set; }
        public Int32 ciudadOrigenId { get; set; }
        public String ciudadOrigenNombre { get; set; }
        public Int32 ciudadDestinoId { get; set; }
        public String ciudadDestinoNombre { get; set; }
        public Int32 precioBasePasaje { get; set; }
        public Int32 precioBaseKg { get; set; }
        public bool estado { get; set; }

        public Ruta initialize(System.Data.DataRow _dr)
        {
            dr = _dr;
            DataColumnCollection dcc = dr.Table.Columns;

            if (dcc.Contains("ruta_id"))
                id = (dr["ruta_id"] == DBNull.Value) ? 0 : Convert.ToInt32(dr["ruta_id"]);
            if (dcc.Contains("ruta_tipo_servicio"))
                tipoServicioId = (dr["ruta_tipo_servicio"] == DBNull.Value) ? 0 : Convert.ToInt32(dr["ruta_tipo_servicio"]);
            if (dcc.Contains("ruta_ciudad_origen"))
                ciudadOrigenId = (dr["ruta_ciudad_origen"] == DBNull.Value) ? 0 : Convert.ToInt32(dr["ruta_ciudad_origen"]);
            if (dcc.Contains("[ruta_ciudad_destino]"))
                ciudadDestinoId = (dr["[ruta_ciudad_destino]"] == DBNull.Value) ? 0 : Convert.ToInt32(dr["[ruta_ciudad_destino]"]);
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

        public int getRuta(string origen, string destino) {


            DAORuta daoRuta = new DAORuta();
            List<Ruta> lRuta = new List<Ruta>();
            int ruta_id = 0;
            lRuta = daoRuta.retrieveAll();
            foreach (Ruta ruta in lRuta)
            { 
            
                if(ruta.ciudadOrigenNombre.Equals(origen) && ruta.ciudadDestinoNombre.Equals(destino)){
                    ruta_id = ruta.id;
                }
            }

            return ruta_id;
        }



    }
}