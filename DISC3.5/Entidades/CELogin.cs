using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Entidades
{
    public class CELogin
    {
        private string musuario;
        public string Usuario
        {
            get { return musuario; }
            set { musuario = value; }
        }
        private string mcontraseña;
        public string Contraseña
        {
            get { return mcontraseña; }
            set { mcontraseña = value; }
        }

        private string mtipo;

        public string Tipo
        {
            get { return mtipo; }
            set { mtipo = value; }
        }
    }
}
