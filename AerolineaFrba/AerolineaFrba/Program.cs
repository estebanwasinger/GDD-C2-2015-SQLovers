using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using AerolineaFrba.Registro_de_Usuario;
using AerolineaFrba.Abm_Aeronave;
using AerolineaFrba.Models.BO;
using AerolineaFrba.Abm_Ruta;
using AerolineaFrba.Models;
using AerolineaFrba.Generacion_Viaje;
using AerolineaFrba.Registro_Llegada_Destino;

namespace AerolineaFrba
{
    static class Program
    {
        /// <summary>
        /// Punto de entrada principal para la aplicación.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Aeronave aeronave = new Aeronave();
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
           

            //Application.Run(new RegistrarLlegada());
            Application.Run(new Inicio());

             Application.Run(new GenerarViaje());
            Application.Run(new RegistrarLlegada());
                
        }
    }
}
