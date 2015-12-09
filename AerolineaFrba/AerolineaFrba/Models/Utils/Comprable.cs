using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AerolineaFrba.Models.Utils
{
    interface Comprable
    {
       bool comprar();


       String tipo { get; }
       float precioTotal { get; }
       void setCompra(int compraId);
    }
}
