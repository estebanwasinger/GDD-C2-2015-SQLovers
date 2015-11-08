using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AerolineaFrba.Abm_Ruta.filter
{
    class OnlyActiveFilter : RutaFilter
    {
        public bool accept(Models.BO.Ruta ruta)
        {
            return ruta.estado;
        }

        public string nombre
        {
            get { return "Solo rutas activas"; }
        }
    }
}
