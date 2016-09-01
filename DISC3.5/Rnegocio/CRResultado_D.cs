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
    public class CRResultado_D
    {
        Cexecutenonquery oenq = new Cexecutenonquery();
        CExecutequery oeq = new CExecutequery();

        public bool agregar_resultado_d(CEResultado_D oeresultado_d)
        {
            try
            {
                SqlParameter[] parametros = new SqlParameter[14];
                parametros[0] = new SqlParameter("@pidusuario", oeresultado_d.idusuario);
                parametros[1] = new SqlParameter("@n_prueba", oeresultado_d.n_prueba);
                parametros[2] = new SqlParameter("@pre1", oeresultado_d.pre1);
                parametros[3] = new SqlParameter("@pre2", oeresultado_d.pre2);
                parametros[4] = new SqlParameter("@pre3", oeresultado_d.pre3);
                parametros[5] = new SqlParameter("@pre4", oeresultado_d.pre4);
                parametros[6] = new SqlParameter("@pre5", oeresultado_d.pre5);
                parametros[7] = new SqlParameter("@pre6", oeresultado_d.pre6);
                parametros[8] = new SqlParameter("@pre7", oeresultado_d.pre7);
                parametros[9] = new SqlParameter("@pre8", oeresultado_d.pre8);
                parametros[10] = new SqlParameter("@pre9", oeresultado_d.pre9);
                parametros[11] = new SqlParameter("@pre10", oeresultado_d.pre10);
                parametros[12] = new SqlParameter("@pre11", oeresultado_d.pre11);
                parametros[13] = new SqlParameter("@pre12", oeresultado_d.pre12);
                return oenq.actualizar("pa_guardar_resultado_d", parametros);
            }
            catch (Exception error)
            {

                throw new Exception(error.Message);
            }

        }

        public DataSet consulta_prueba(CEResultado_D oeresD)
        {
            try
            {
                SqlParameter[] parametros = new SqlParameter[1];
                parametros[0] = new SqlParameter("@pidusuario", oeresD.idusuario);
                return oeq.consultar("pa_cons_Nprueba", parametros);
            }
            catch (Exception error)
            {
                throw new Exception(error.Message);
            }
        }
    }
}
