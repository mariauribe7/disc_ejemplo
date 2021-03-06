﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Data;
namespace Datos
{
    public class CExecutequery
    {
        CConexion objconexion = new CConexion();
        SqlConnection cnn = new SqlConnection();
        SqlCommand objcomando = new SqlCommand();
        public DataSet consultar(string procedimiento, SqlParameter[] pparametros)
        {
            try
            {
                cnn = objconexion.Conectar();
                objcomando = new SqlCommand(procedimiento, cnn);
                objcomando.CommandType = CommandType.StoredProcedure;
                foreach (var parametro in pparametros)
                    objcomando.Parameters.Add(parametro).Value = parametro.Value;
                SqlDataAdapter da = new SqlDataAdapter(objcomando);
                DataSet ds = new DataSet();
                da.Fill(ds);
                return ds;

            }
            catch (Exception error)
            {
                throw new Exception(error.Message);
            }
        }

        public DataSet consultar(string procedimiento)
        {
            try
            {
                cnn = objconexion.Conectar();
                objcomando = new SqlCommand(procedimiento, cnn);
                objcomando.CommandType = CommandType.StoredProcedure;
                SqlDataAdapter da = new SqlDataAdapter(objcomando);
                DataSet ds = new DataSet();
                da.Fill(ds);
                return ds;

            }
            catch (Exception error)
            {
                throw new Exception(error.Message);
            }
        }
    }
}
