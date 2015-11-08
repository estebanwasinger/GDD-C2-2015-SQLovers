using AerolineaFrba.Models.BO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AerolineaFrba.Abm_Ruta.filter
{
    interface RutaFilter
    {
        String nombre { get; }

        bool accept(Ruta ruta);
    }
}
