using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AerolineaFrba.Models.BO
{
    public class Cliente
    {


        public Cliente() { }

        public String nombre { get; set; }
        public String apellido { get; set; }
        public String direccion { get; set; }
        public String mail { get; set; }
        public DateTime fechaNacimiento { get; set; }
        public String username { get; set; }
        public Int32 telefono { get; set; }
        public Int32 dni { get; set; }



    }
}
