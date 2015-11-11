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

        public static bool create(Cliente cliente)
        {
            List<SqlParameter> parameterList = new List<SqlParameter>();
            parameterList.Add(new SqlParameter("@cli_nombre", cliente.nombre));
            parameterList.Add(new SqlParameter("@cli_apellido", cliente.apellido));
            parameterList.Add(new SqlParameter("@cli_dni", cliente.dni));
            parameterList.Add(new SqlParameter("@cli_dir", cliente.direccion));
            parameterList.Add(new SqlParameter("@cli_telefono", cliente.telefono));
            parameterList.Add(new SqlParameter("@cli_mail", cliente.mail));
            parameterList.Add(new SqlParameter("@cli_fecha_nac", cliente.fechaNacimiento));
            parameterList.Add(new SqlParameter("@cli_username", cliente.username));
            
            return DBAcess.WriteInBase("INSERT INTO sqlovers.CLIENTE (cli_nombre, cli_apellido, cli_dni, cli_dir, cli_telefono, cli_mail, cli_fecha_nac, cli_username) " + 
                                                " VALUES (@cli_nombre, @cli_apellido, @cli_dni, @cli_dir, @cli_telefono, @cli_mail, @cli_fecha_nac, @cli_username)", "T", parameterList );
        }
    }
}
