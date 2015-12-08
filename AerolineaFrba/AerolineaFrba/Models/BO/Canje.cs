using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AerolineaFrba.Models.BO
{
    class Canje
    {
        public Canje() { }

        public Int32 cliente { get; set; }
        public Int32 producto { get; set; }
        public DateTime fecha { get; set; }
        public Int32 cantidad { get; set; }

    }
}
