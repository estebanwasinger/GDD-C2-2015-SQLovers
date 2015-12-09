using AerolineaFrba.Models.DAO;
using AerolineaFrba.Models.Utils;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AerolineaFrba.Models.BO
{
    public class Pasaje : Comprable, IBO<Pasaje>
    {
         public Pasaje() { }

         public Pasaje(System.Data.DataRow dr)
        {
            initialize(dr);
        }

         private DataRow dr;

        public Int32 codigo { get; set; }
        public float precio { get; set; }
        public DateTime fechaCompra { get; set; }
        public Cliente usuario { get; set; }
        public Vuelo vuelo { get; set; }
        public Butaca butaca { get; set; }

        public Int32 CliDNI { get; set; }
        

        public int compraId { get; set; }
        public bool cancelado { get; set; }

        public Pasaje initialize(System.Data.DataRow _dr)
        {
            dr = _dr;
            usuario = new Cliente();
            DataColumnCollection dcc = dr.Table.Columns;

            if (dcc.Contains("pasaje_codigo"))
                codigo = (dr["pasaje_codigo"] == DBNull.Value) ? 0 : Convert.ToInt32(dr["pasaje_codigo"]);

            if (dcc.Contains("cli_dni"))
                CliDNI = (dr["cli_dni"] == DBNull.Value) ? 0 : Convert.ToInt32(dr["cli_dni"]);

            if (dcc.Contains("compra_id"))
                compraId = (dr["compra_id"] == DBNull.Value) ? 0 : Convert.ToInt32(dr["compra_id"]);

            if (dcc.Contains("pasaje_precio"))
                precio = (dr["pasaje_precio"] == DBNull.Value) ? 0 : Convert.ToInt32(dr["pasaje_precio"]);

            return this;
        }

        public Pasaje setData(DataRow dr)
        {
            initialize(dr);

            return this;
        }

        public bool comprar()
        {
            return DAOPasaje.create(this);
        }

        string Comprable.tipo
        {
            get { return "Pasaje"; }
        }

        float Comprable.precioTotal
        {
            get { return precio; }
        }


        public void setCompra(int compraId)
        {
            this.compraId = compraId;
        }
    }
}
