using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AerolineaFrba.Models.BO
{
    public class Millas
    {
        public Int32 id { get; set; }
        public Int32 cliente { get; set; }
        public DateTime fecha { get; set; }
        public Int32 pasaje { get; set; }
        public Int32 encomienda { get; set; }
        public Int32 cantidad { get; set; }
        public Int32 cantidadd { get; set; }
    }
}
