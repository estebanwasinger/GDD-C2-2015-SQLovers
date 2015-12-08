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
    public class DAOTarjetaDeCredito
    {
        public static bool create(TarjetaDeCredito tarjeta) {
            List<SqlParameter> parameterList = new List<SqlParameter>();
            parameterList.Add(new SqlParameter("@tarjeta_numero", tarjeta.numero));
            parameterList.Add(new SqlParameter("@tarjeta_fecha", tarjeta.fecha));
            parameterList.Add(new SqlParameter("@tarjeta_tipo", tarjeta.tipo));
            parameterList.Add(new SqlParameter("@tarjeta_compra", tarjeta.compraId));
            parameterList.Add(new SqlParameter("@tarjeta_cod", tarjeta.cod));
            parameterList.Add(new SqlParameter("@tarjeta_cuotas", tarjeta.cuotas));

            return DBAcess.WriteInBase("INSERT INTO sqlovers.TARJETAS_DE_CREDITO (tarjeta_numero, tarjeta_fecha, tarjeta_tipo, tarjeta_compra, tarjeta_cod, tarjeta_cuotas) " +
                                                " VALUES (@tarjeta_numero, @tarjeta_fecha, @tarjeta_tipo, @tarjeta_compra, @tarjeta_cod, @tarjeta_cuotas)", "T", parameterList);
        }
    }
}
