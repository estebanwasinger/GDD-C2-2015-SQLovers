using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AerolineaFrba.Abm_Ruta.filter
{
    class NoneFilter : RutaFilter
    {
        public bool accept(Models.BO.Ruta ruta)
        {
            return true;
        }

        public string nombre
        {
            get { return "Todas las rutas"; }
        }
    }
}
