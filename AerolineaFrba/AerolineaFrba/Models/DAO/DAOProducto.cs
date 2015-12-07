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
    public partial class DAOProducto : DAOBase<Producto>
    {

        public DAOProducto()
            : base("SQLOVERS.PRODUCTOS", "producto_id")
        { }


        public static Producto getProducto(int id)
        {
            List<SqlParameter> parameterList = new List<SqlParameter>();
            parameterList.Add(new SqlParameter("@producto_id", id));
            SqlDataReader lector = DBAcess.GetDataReader("SELECT * FROM SQLOVERS.productos", "T", parameterList);

            if (lector.HasRows)
            {
                while (lector.Read())
                {
                    Producto producto = new Producto();
                    producto.id = (int)(decimal)lector["producto_id"];
                    producto.nombre = (String)lector["producto_nombre"];
                    producto.millas = (int)(decimal)lector["producto_cantMillas"];
                    producto.stock = (int)(decimal)lector["producto_stock"];

                    return producto;
                }
            }
            return new Producto();
        }

        public static List<Producto> retrieveAll()
        {
            List<Producto> productoList = new List<Producto>();
            SqlDataReader lector = DBAcess.GetDataReader("SELECT * from SQLOVERS.PRODUCTOS", "T", new List<SqlParameter>());

            if (lector.HasRows)
            {
                while (lector.Read())
                {
                    Producto producto = new Producto();
                    producto.id = (int)(decimal)lector["producto_id"];
                    producto.nombre = (string)lector["producto_nombre"];
                    producto.millas = (int)(decimal)lector["producto_cantMillas"];

                    productoList.Add(producto);
                }
            }
            return productoList;
        }
    }
}