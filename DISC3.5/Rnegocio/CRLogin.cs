using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Entidades;
using Datos;
using System.Data.SqlClient;
using System.Data;


namespace Rnegocio
{
    public class CRLogin
    {
        Cexecutenonquery oenq = new Cexecutenonquery();
        CExecutequery oeq = new CExecutequery();

        public DataSet login_usr(CELogin oelogin)
        {
            try
            {
                SqlParameter[] parametros = new SqlParameter[1];
                parametros[0] = new SqlParameter("@clave", oelogin.Contraseña);
                return oeq.consultar("pa_loginusuario", parametros);
            }
            catch (Exception error)
            {
                throw new Exception(error.Message);
            }
        }

       
    }
}
