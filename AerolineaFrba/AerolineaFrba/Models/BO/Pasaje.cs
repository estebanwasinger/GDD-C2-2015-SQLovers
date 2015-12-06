using AerolineaFrba.Models.DAO;
using AerolineaFrba.Models.Utils;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AerolineaFrba.Models.BO
{
    public class Pasaje : Comprable
    {
        public Int32 codigo { get; set; }
        public Int32 precio { get; set; }
        public DateTime fechaCompra { get; set; }
        public Cliente usuario { get; set; }
        public Vuelo vuelo { get; set; }
        public Butaca butaca { get; set; }

        public bool comprar()
        {
            return DAOPasaje.create(this);
        }

        string Comprable.tipo
        {
            get { return "Pasaje"; }
        }

        int Comprable.precioTotal
        {
            get { return precio; }
        }
    }
}
