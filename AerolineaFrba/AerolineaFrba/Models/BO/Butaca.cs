using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AerolineaFrba.Models.BO
{
    public class Butaca : IEquatable<Butaca>
    {
        public String tipo { get; set; }
        public Int32 numero { get; set; }
        public Int32 piso { get; set; }

        public bool Equals(Butaca butaca) {
            return this.tipo.Equals(butaca.tipo) && this.piso.Equals(butaca.piso) && this.numero.Equals(butaca.numero);
        }
    }

    
}
