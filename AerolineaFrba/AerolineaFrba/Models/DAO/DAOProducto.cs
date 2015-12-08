using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

using AerolineaFrba.Models;
using AerolineaFrba.Models.BO;
using AerolineaFrba.Models.Utils;
using System.Data.SqlClient;
using AerolineaFrba.Models.DataBase;
using System.Windows;

namespace AerolineaFrba.Models.DAO
{
    public class DAOProducto
    {

        public static bool actualizarStock(int id, int stock) {
            List<SqlParameter> parameterList = new List<SqlParameter>();
            parameterList.Add(new SqlParameter("@producto_id", id));
            parameterList.Add(new SqlParameter("@producto_stock", stock));
            return DBAcess.WriteInBase("UPDATE SQLOVERS.PRODUCTOS SET producto_stock=@producto_stock WHERE producto_id=@producto_id", "T", parameterList);
        }

        public static List<Producto> retrieveAll()
        {
            List<Producto> productoList = new List<Producto>();
            SqlDataReader lector = DBAcess.GetDataReader("SELECT * from SQLOVERS.PRODUCTOS WHERE producto_stock>0", "T", new List<SqlParameter>());

            if (lector.HasRows)
            {
                while (lector.Read())
                {
                    Producto producto = new Producto();
                    producto.id = (int)(decimal)lector["producto_id"];
                    producto.nombre = (string)lector["producto_nombre"];
                    producto.millas = (int)(decimal)lector["producto_cantMillas"];
                    producto.stock = (int)(decimal)lector["producto_stock"];

                    productoList.Add(producto);
                }
            }
            return productoList;
        }
    }
}