using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Rnegocio;
using Entidades;

namespace DISC3._5
{
    public partial class Pregunta11 : System.Web.UI.Page
    {
        CEResultado_D oeresultado_d = new CEResultado_D();
        CEResultado_I oeresultado_i = new CEResultado_I();
        CEResultado_S oeresultado_s = new CEResultado_S();
        CEResultado_C oeresultado_c = new CEResultado_C();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                txtpre11_r1_d11.Focus();
            }
        }

        protected bool valTXT1()
        {
            if ((txtpre11_r1_d11.Text.Trim() == "1") || (txtpre11_r1_d11.Text.Trim() == "2") || (txtpre11_r1_d11.Text.Trim() == "3") || (txtpre11_r1_d11.Text.Trim() == "4"))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        protected bool valTXT2()
        {
            if ((txtpre11_r2_i11.Text.Trim() == "1") || (txtpre11_r2_i11.Text.Trim() == "2") || (txtpre11_r2_i11.Text.Trim() == "3") || (txtpre11_r2_i11.Text.Trim() == "4"))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        protected bool valTXT3()
        {
            if ((txtpre11_r3_s11.Text.Trim() == "1") || (txtpre11_r3_s11.Text.Trim() == "2") || (txtpre11_r3_s11.Text.Trim() == "3") || (txtpre11_r3_s11.Text.Trim() == "4"))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        protected bool valTXT4()
        {
            if ((txtpre11_r4_c11.Text.Trim() == "1") || (txtpre11_r4_c11.Text.Trim() == "2") || (txtpre11_r4_c11.Text.Trim() == "3") || (txtpre11_r4_c11.Text.Trim() == "4"))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        protected void btnenviar_Click(object sender, EventArgs e)
        {
            if ((txtpre11_r1_d11.Text != "") && (valTXT1() == true))
            {
                if (txtpre11_r2_i11.Text != "" && (valTXT2() == true))
                {
                    if (txtpre11_r3_s11.Text != "" && (valTXT3() == true))
                    {
                        if (txtpre11_r4_c11.Text != "" && (valTXT4() == true))
                        {
                            Session["pre11_d11"] = Convert.ToInt32(txtpre11_r1_d11.Text);
                            Session["pre11_i11"] = Convert.ToInt32(txtpre11_r2_i11.Text);
                            Session["pre11_s11"] = Convert.ToInt32(txtpre11_r3_s11.Text);
                            Session["pre11_c11"] = Convert.ToInt32(txtpre11_r4_c11.Text);
                            Response.Redirect("Pregunta12.aspx");
                        }
                        else
                        {
                            if (txtpre11_r4_c11.Text == "")
                            {
                                lblmensaje.Text = "Campo Requerido";
                                txtpre11_r4_c11.Focus();
                            }
                            else
                            {
                                lblmensaje.Text = "Solo se aceptan valores del 1 al 4";
                                txtpre11_r4_c11.Focus();
                            }
                        }
                    }
                    else
                    {
                        if (txtpre11_r3_s11.Text == "")
                        {
                            lblmensaje.Text = "Campo Requerido";
                            txtpre11_r3_s11.Focus();
                        }
                        else
                        {
                            lblmensaje.Text = "Solo se aceptan valores del 1 al 4";
                            txtpre11_r3_s11.Focus();
                        }
                    }
                }
                else
                {
                    if (txtpre11_r2_i11.Text == "")
                    {
                        lblmensaje.Text = "Campo Requerido";
                        txtpre11_r2_i11.Focus();
                    }
                    else
                    {
                        lblmensaje.Text = "Solo se aceptan valores del 1 al 4";
                        txtpre11_r2_i11.Focus();
                    }
                }
            }
            else
            {
                if (txtpre11_r1_d11.Text == "")
                {
                    lblmensaje.Text = "Campo Requerido";
                    txtpre11_r1_d11.Focus();
                }
                else
                {
                    lblmensaje.Text = "Solo se aceptan valores del 1 al 4";
                    txtpre11_r1_d11.Focus();
                }
            }
        }
    }
}