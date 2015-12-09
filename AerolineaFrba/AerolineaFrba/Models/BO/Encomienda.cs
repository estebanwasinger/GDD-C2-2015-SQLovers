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
    public class Encomienda : Comprable, IBO<Encomienda>
    {
        public Encomienda() { }

        public Encomienda(System.Data.DataRow dr)
        {
            initialize(dr);
        }

         private DataRow dr;


        public int id {get; set;}
        public int kg { get; set; }
        public int dniCliente { get; set; }
        public int vueloId { get; set; }
        public int precioTotal { get; set; }

        public int compraId { get; set; }
	public bool cancelado { get; set; }

        public Encomienda initialize(System.Data.DataRow _dr)
        {
            dr = _dr;
            
            DataColumnCollection dcc = dr.Table.Columns;

            if (dcc.Contains("encomienda_id"))
                id = (dr["encomienda_id"] == DBNull.Value) ? 0 : Convert.ToInt32(dr["encomienda_id"]);

            if (dcc.Contains("encomienda_cliente_dni"))
                dniCliente = (dr["encomienda_cliente_dni"] == DBNull.Value) ? 0 : Convert.ToInt32(dr["encomienda_cliente_dni"]);

            if (dcc.Contains("encomienda_compra_id"))
                compraId = (dr["encomienda_compra_id"] == DBNull.Value) ? 0 : Convert.ToInt32(dr["encomienda_compra_id"]);

            if (dcc.Contains("encomienda_precio_total"))
                precioTotal = (dr["encomienda_precio_total"] == DBNull.Value) ? 0 : Convert.ToInt32(dr["encomienda_precio_total"]);

            return this;
        }

         public Encomienda setData(DataRow dr)
        {
            initialize(dr);

            return this;
        }

        public bool comprar()
        {
           return DAOEncomienda.create(this);
        }


        string Comprable.tipo
        {
            get { return "Encomienda"; }
        }


        public void setCompra(int compraId)
        {
            this.compraId = compraId;
        }
    }
}
