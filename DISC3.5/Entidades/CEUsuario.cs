using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Entidades
{
    public class CEUsuario
    {
        private string midusuario;
        public string idusuario
        {
            get { return midusuario; }
            set { midusuario = value; }
        }

        private string mnombre;
        public string nombre
        {
            get { return mnombre; }
            set { mnombre = value; }
        }

        private string mdireccion;
        public string direccion
        {
            get { return mdireccion; }
            set { mdireccion = value; }
        }

        private string mtelefono;
        public string telefono
        {
            get { return mtelefono; }
            set { mtelefono = value; }
        }
        private string mempresa;

        public string empresa
        {
            get { return mempresa; }
            set { mempresa = value; }
        }

        private string mrol_empresa;

        public string rol_empresa
        {
            get { return mrol_empresa; }
            set { mrol_empresa = value; }
        }

        private string mrol_login;

        public string rol_login
        {
            get { return mrol_login; }
            set { mrol_login = value; }
        }
    }
}
