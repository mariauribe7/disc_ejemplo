﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Configuration;
using System.Data;


namespace Datos
{
   public class CConexion
    {
        SqlConnection cnn = new SqlConnection();
        public SqlConnection Conectar()
        {
            try
            {
                string conexion = ConfigurationManager.ConnectionStrings["oCnx"].ToString();
                SqlConnection oConexion = new SqlConnection(conexion);
                oConexion.Open();
                return oConexion;
            }
            catch (SqlException ErrorSql)
            {
                return null;
            }
            catch (Exception Errorcs)
            {

                return null;
            }
        }
    }
}
