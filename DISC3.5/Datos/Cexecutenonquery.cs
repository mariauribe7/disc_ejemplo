using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using System.Data.SqlClient;
using System.Data;

namespace Datos
{
    public class Cexecutenonquery
    {
        CConexion objconexion = new CConexion();
        SqlConnection cnn = new SqlConnection();
        SqlCommand objcomando = new SqlCommand();

        public bool actualizar(string procedimiento, SqlParameter[] pparametros)
        {
            try
            {
                cnn = objconexion.Conectar();
                objcomando = new SqlCommand(procedimiento, cnn);
                objcomando.CommandType = CommandType.StoredProcedure;
                foreach (var parametro in pparametros)
                    objcomando.Parameters.Add(parametro).Value = parametro.Value;
                objcomando.ExecuteNonQuery();
                return true;
            }
            catch (Exception error)
            {
                throw new Exception(error.Message);
            }

        }
    }
}
