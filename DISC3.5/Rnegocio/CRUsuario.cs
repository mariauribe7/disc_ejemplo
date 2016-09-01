using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Datos;
using Entidades;
using System.Data.SqlClient;
using System.Data;

namespace Rnegocio
{
   public class CRUsuario
    {
        Cexecutenonquery oenq = new Cexecutenonquery();
        CExecutequery oeq = new CExecutequery();

        public bool adicionar_clientes(CEUsuario oeusuario)
        {
            try
            {
                SqlParameter[] parametros = new SqlParameter[7];
                parametros[0] = new SqlParameter("@pidcliente", oeusuario.idusuario);
                parametros[1] = new SqlParameter("@pnombre", oeusuario.nombre);
                parametros[2] = new SqlParameter("@pdireccion", oeusuario.direccion);
                parametros[3] = new SqlParameter("@ptelefono", oeusuario.telefono);
                parametros[4] = new SqlParameter("@empresa", oeusuario.empresa);
                parametros[5] = new SqlParameter("@rol_empresa", oeusuario.rol_empresa);
                parametros[6] = new SqlParameter("@rol_login", oeusuario.rol_login);
                return oenq.actualizar("sp_adicionar_clientes", parametros);
            }
            catch (Exception error)
            {
                throw new Exception(error.Message);
            }
        }

        public bool modificar_clientes(CEUsuario oeusuario)
        {
            try
            {
                SqlParameter[] parametros = new SqlParameter[7];
                parametros[0] = new SqlParameter("@pidcliente", oeusuario.idusuario);
                parametros[1] = new SqlParameter("@pnombre", oeusuario.nombre);
                parametros[2] = new SqlParameter("@pdireccion", oeusuario.direccion);
                parametros[3] = new SqlParameter("@ptelefono", oeusuario.telefono);
                parametros[4] = new SqlParameter("@pempresa", oeusuario.empresa);
                parametros[5] = new SqlParameter("@prol_empresa", oeusuario.rol_empresa);
                parametros[6] = new SqlParameter("@rol_login", oeusuario.rol_login);
                return oenq.actualizar("sp_Modificar_clientes", parametros);
            }
            catch (Exception error)
            {
                throw new Exception(error.Message);
            }
        }

        public bool eliminar_clientes(CEUsuario oeusuario)
        {
            try
            {
                SqlParameter[] parametros = new SqlParameter[1];
                parametros[0] = new SqlParameter("@pidcliente", oeusuario.idusuario);
                return oenq.actualizar("sp_Eliminar_clientes", parametros);
            }
            catch (Exception error)
            {
                throw new Exception(error.Message);
            }
        }

        public DataSet consulta_individual_clientes(CEUsuario oeusuario)
        {
            try
            {
                SqlParameter[] parametros = new SqlParameter[1];
                parametros[0] = new SqlParameter("@pidsuario", oeusuario.idusuario);
                return oeq.consultar("sp_consulta_individual_usuario", parametros);
            }
            catch (Exception error)
            {
                throw new Exception(error.Message);
            }
        }

        public DataSet consulta_general_clientes()
        {
            try
            {
                return oeq.consultar("sp_consulta_general_clientes");
            }
            catch (Exception error)
            {
                throw new Exception(error.Message);
            }
        }
    }
}
