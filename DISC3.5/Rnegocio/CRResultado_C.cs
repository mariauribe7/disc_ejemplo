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
   public class CRResultado_C
    {
        Cexecutenonquery oenq = new Cexecutenonquery();
        CExecutequery oeq = new CExecutequery();

        public bool agregar_resultado_c(CEResultado_C oeresultado_c)
        {
            try
            {
                SqlParameter[] parametros = new SqlParameter[14];
                parametros[0] = new SqlParameter("@pidusuario", oeresultado_c.idusuario);
                parametros[1] = new SqlParameter("@n_prueba", oeresultado_c.n_prueba);
                parametros[2] = new SqlParameter("@pre1", oeresultado_c.pre1);
                parametros[3] = new SqlParameter("@pre2", oeresultado_c.pre2);
                parametros[4] = new SqlParameter("@pre3", oeresultado_c.pre3);
                parametros[5] = new SqlParameter("@pre4", oeresultado_c.pre4);
                parametros[6] = new SqlParameter("@pre5", oeresultado_c.pre5);
                parametros[7] = new SqlParameter("@pre6", oeresultado_c.pre6);
                parametros[8] = new SqlParameter("@pre7", oeresultado_c.pre7);
                parametros[9] = new SqlParameter("@pre8", oeresultado_c.pre8);
                parametros[10] = new SqlParameter("@pre9", oeresultado_c.pre9);
                parametros[11] = new SqlParameter("@pre10", oeresultado_c.pre10);
                parametros[12] = new SqlParameter("@pre11", oeresultado_c.pre11);
                parametros[13] = new SqlParameter("@pre12", oeresultado_c.pre12);
                return oenq.actualizar("pa_guardar_resultado_c", parametros);
            }
            catch (Exception error)
            {

                throw new Exception(error.Message);
            }

        }

    }
}
