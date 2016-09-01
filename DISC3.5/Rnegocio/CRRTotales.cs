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
    public class CRRTotales
    {
        Cexecutenonquery oenq = new Cexecutenonquery();
        CExecutequery oeq = new CExecutequery();

        public DataSet resTotales(CEResultado_D oeresultado)
        {
            try
            {
                SqlParameter[] parametros = new SqlParameter[2];
                parametros[0] = new SqlParameter("@pidusr", oeresultado.idusuario);
                parametros[1] = new SqlParameter("@pnropru", oeresultado.n_prueba);
                return oeq.consultar("pa_resultado_totales", parametros);
            }
            catch (Exception error)
            {

                throw new Exception(error.Message);
            }
        }

        
        public DataSet resTotalesC(CEResultado_C oeresultado)
        {
            try
            {
                SqlParameter[] parametros = new SqlParameter[2];
                parametros[0] = new SqlParameter("@pidusr", oeresultado.idusuario);
                parametros[1] = new SqlParameter("@npr", oeresultado.n_prueba);
                return oeq.consultar("pa_tablaCxUsrxNpr", parametros);
            }
            catch (Exception error)
            {

                throw new Exception(error.Message);
            }
        }
        public DataSet resTotalesD(CEResultado_D oeresultado)
        {
            try
            {
                SqlParameter[] parametros = new SqlParameter[2];
                parametros[0] = new SqlParameter("@pidusr", oeresultado.idusuario);
                parametros[1] = new SqlParameter("@npr", oeresultado.n_prueba);
                return oeq.consultar("pa_tablaDxUsrxNpr", parametros);
            }
            catch (Exception error)
            {

                throw new Exception(error.Message);
            }
        }
        public DataSet resTotalesI(CEResultado_I oeresultado)
        {
            try
            {
                SqlParameter[] parametros = new SqlParameter[2];
                parametros[0] = new SqlParameter("@pidusr", oeresultado.idusuario);
                parametros[1] = new SqlParameter("@npr", oeresultado.n_prueba);
                return oeq.consultar("pa_tablaIxUsrxNpr", parametros);
            }
            catch (Exception error)
            {

                throw new Exception(error.Message);
            }
        }
        public DataSet resTotalesS(CEResultado_S oeresultado)
        {
            try
            {
                SqlParameter[] parametros = new SqlParameter[2];
                parametros[0] = new SqlParameter("@pidusr", oeresultado.idusuario);
                parametros[1] = new SqlParameter("@npr", oeresultado.n_prueba);
                return oeq.consultar("pa_tablaSxUsrxNpr", parametros);
            }
            catch (Exception error)
            {

                throw new Exception(error.Message);
            }
        }
    }
}
