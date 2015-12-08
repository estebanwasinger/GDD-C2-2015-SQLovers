using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AerolineaFrba.Models.BO
{
    public class CompraAero
    {
        public int id { get; set; }
        public String tipo { get; set; }
        public int cliente { get; set; }
        public DateTime fecha { get; set; }
    }
}
