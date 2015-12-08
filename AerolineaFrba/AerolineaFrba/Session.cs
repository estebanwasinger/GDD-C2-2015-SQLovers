using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AerolineaFrba
{
    class Session
    {
        private static Session instance;
        public bool admin;

        private Session(bool admin) {
            this.admin = admin;
        }

        public static Session Instance(bool admin)
        {
            if (instance == null)
            {
                instance = new Session(admin);
            }
            return instance;
        }

        public static Session Instance() { return instance; }
    }
}
