using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AerolineaFrba.Models.BO
{
    public class TarjetaDeCredito
    {
        public Int64 numero { get; set; }
        public Int64 cod { get; set; }
        public DateTime fecha { get; set; }
        public Int64 cuotas { get; set; }
        public String tipo { get; set; }
        public Int64 compraId { get; set; }
    }
}
