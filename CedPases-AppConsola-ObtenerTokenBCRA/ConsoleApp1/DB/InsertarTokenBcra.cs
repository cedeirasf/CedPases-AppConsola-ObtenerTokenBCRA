using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CedPases_ObtenerTokenBCRA.DB
{
    public class InsertarTokenBcra : Base
    {
        public InsertarTokenBcra(Entidades.Sesion Sesion) : base(Sesion)
        {
        }

        public DataSet InsertarTokenBcraParm(string tokenBcra)
        {
            StringBuilder a = new StringBuilder();
            a.AppendLine("UPDATE Parm SET ValorStr = @ValorStr WHERE IdParm = 'TokenBcra'");

            SqlCommand sqlCmd = new SqlCommand(a.ToString());
            sqlCmd.Parameters.AddWithValue("@ValorStr", tokenBcra);

            return (DataSet)Ejecutar(sqlCmd, TipoRetorno.DS, Transaccion.NoAcepta);
        }
    }
}
