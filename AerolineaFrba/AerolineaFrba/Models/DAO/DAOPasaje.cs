﻿using AerolineaFrba.Models.BO;
using AerolineaFrba.Models.DataBase;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AerolineaFrba.Models.DAO
{
    class DAOPasaje
    {

        public static bool create(Pasaje pasaje){
            List<SqlParameter> parameterList = new List<SqlParameter>();
            parameterList.Add(new SqlParameter("@pasaje_vuelo_id", pasaje.vuelo.id));
            parameterList.Add(new SqlParameter("@cli_dni", pasaje.usuario.dni));
            parameterList.Add(new SqlParameter("@pasaje_precio", pasaje.precio));
            parameterList.Add(new SqlParameter("@pasaje_butaca_nro", pasaje.butaca.numero));
            parameterList.Add(new SqlParameter("@pasaje_fechacompra", pasaje.fechaCompra));
            parameterList.Add(new SqlParameter("@pasaje_compra_id", pasaje.compraId));
            return DBAcess.WriteInBase("INSERT INTO sqlovers.PASAJE (pasaje_vuelo_id, cli_dni, pasaje_fechacompra, pasaje_precio, pasaje_butaca_nro, pasaje_cancelado, pasaje_compra_id) " +
                                                " VALUES (@pasaje_vuelo_id, @cli_dni, @pasaje_fechacompra, @pasaje_precio, @pasaje_butaca_nro, 0, @pasaje_compra_id)", "T", parameterList);
        }

    }
}
