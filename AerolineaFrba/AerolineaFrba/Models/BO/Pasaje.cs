using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AerolineaFrba.Models.BO
{
    public class Pasaje
    {
        public Int32 codigo { get; set; }
        public Int32 precio { get; set; }
        public DateTime fechaCompra { get; set; }
        public Cliente usuario { get; set; }
        public Vuelo vuelo { get; set; }
    }
}
