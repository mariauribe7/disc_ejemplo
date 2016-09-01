using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Rnegocio;
using Entidades;
using System.Data;

namespace DISC3._5
{
    public partial class Login : System.Web.UI.Page
    {
        CRLogin oreglogin = new CRLogin();
        CELogin oentlogin = new CELogin();
        DataSet ds = new DataSet();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                Session["conteo"] = Convert.ToInt32(0);
                txtnombre.Focus();
            }
        }

        protected void btningresar_Click(object sender, EventArgs e)
        {
            lblmensaje.Text = "";
            try
            {
                Session["usuario"] = txtnombre.Text;

                if (txtnombre.Text.Trim() != "" && txtcontraseña.Text.Trim() != "")
                {
                    oentlogin.Contraseña = txtcontraseña.Text;
                    ds = oreglogin.login_usr(oentlogin);
                    oentlogin.Tipo = ds.Tables[0].Rows[0]["Rol_Login"].ToString();
                    if (oentlogin.Tipo.Trim() == "1")
                    {
                        Response.Redirect("MenuAdm.aspx"); // comando que cambia y/o redirecciona a otra pagina
                    }
                    else
                    {
                        if (oentlogin.Tipo.Trim() == "2")
                        {
                            //Session["inicio"] = txtnombre.Text;
                            Response.Redirect("MenuUsr.aspx"); // comando que cambia y/o redirecciona a otra pagina
                        }

                    }
                }

            }
            catch (Exception ex)
            {
                if (Convert.ToInt32(Session["conteo"]) == 2)
                {
                    btningresar.Enabled = false;
                    txtnombre.Enabled = false;
                    txtcontraseña.Enabled = false;
                    lblmensaje.Text = "Demasiados Intentos";
                }
                else
                {
                    string script = "MostarrMensaje('Error inesperado','" + ex.Message + "',3);";
                    ClientScript.RegisterStartupScript(this.GetType(), "MensajeUsuario", script, true);
                    lblmensaje.Text = "Usuario o contraseña errada";
                    txtnombre.Text = "";
                    txtcontraseña.Text = "";
                    Session["conteo"] = Convert.ToInt32(Session["conteo"]) + 1;
                }

            }
        }
    }
}