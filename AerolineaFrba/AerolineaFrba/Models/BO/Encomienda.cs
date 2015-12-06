using AerolineaFrba.Models.DAO;
using AerolineaFrba.Models.Utils;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AerolineaFrba.Models.BO
{
    public class Encomienda : Comprable
    {

        public int id {get; set;}
        public int kg { get; set; }
        public int dniCliente { get; set; }
        public int vueloId { get; set; }
        public int precioTotal { get; set; }

        public bool comprar()
        {
           return DAOEncomienda.create(this);
        }


        string Comprable.tipo
        {
            get { return "Encomienda"; }
        }
    }
}
