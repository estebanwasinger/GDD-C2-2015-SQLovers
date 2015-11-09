using AerolineaFrba.Models.BO;
using AerolineaFrba.Models.DataBase;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AerolineaFrba.Models.DAO
{
    class DAOCliente
    {

        public static List<Cliente> retrieveAll()
        {
            List<Cliente> clienteList = new List<Cliente>();
            SqlDataReader lector = DBAcess.GetDataReader("SELECT * from SQLOVERS.CLIENTE", "T", new List<SqlParameter>());

            if (lector.HasRows)
            {
                while (lector.Read())
                {
                    Cliente cliente = new Cliente();
                    cliente.nombre = (string)lector["cli_nombre"];
                    cliente.apellido = (string)lector["cli_apellido"];
                    cliente.apellido = (string)lector["cli_apellido"];
                    cliente.direccion = (string)lector["cli_dir"];
                    cliente.mail = (string)lector["cli_mail"];
                    cliente.username = (string)lector["cli_username"];
                    cliente.dni = (int)(decimal)lector["cli_dni"];
                    cliente.telefono = (int)(decimal)lector["cli_telefono"];
                    cliente.fechaNacimiento = (DateTime)lector["cli_fecha_nac"];

                    clienteList.Add(cliente);
                }
            }
            return clienteList;
        }
    }
}
