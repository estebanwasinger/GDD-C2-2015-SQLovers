using AerolineaFrba.Models.BO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;

namespace AerolineaFrba.Models.DAO
{
    public partial class Producto
    {
        public Producto() { }

        public Int32 id { get; set; }
        public string nombre { get; set; }
        public Int32 millas { get; set; }
        public int stock { get; set; }
    }
}
