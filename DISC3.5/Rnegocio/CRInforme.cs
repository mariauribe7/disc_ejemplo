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
    public class CRInforme
    {
        CConexion oConexion = new CConexion();

        public SqlConnection Conectar()
        {
            return oConexion.Conectar();
        }
    }
}
