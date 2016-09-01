using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using Rnegocio;
using Entidades;

namespace DISC3._5
{
    public partial class Pregunta2 : System.Web.UI.Page
    {
        CEResultado_D oeresultado_d = new CEResultado_D();
        CEResultado_I oeresultado_i = new CEResultado_I();
        CEResultado_S oeresultado_s = new CEResultado_S();
        CEResultado_C oeresultado_c = new CEResultado_C();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                txtpre2_r1_d2.Focus();
            }
        }
        protected bool valTXT1()
        {
            if ((txtpre2_r1_d2.Text.Trim() == "1") || (txtpre2_r1_d2.Text.Trim() == "2") || (txtpre2_r1_d2.Text.Trim() == "3") || (txtpre2_r1_d2.Text.Trim() == "4"))
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
            if ((txtpre2_r2_i2.Text.Trim() == "1") || (txtpre2_r2_i2.Text.Trim() == "2") || (txtpre2_r2_i2.Text.Trim() == "3") || (txtpre2_r2_i2.Text.Trim() == "4"))
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
            if ((txtpre2_r3_s2.Text.Trim() == "1") || (txtpre2_r3_s2.Text.Trim() == "2") || (txtpre2_r3_s2.Text.Trim() == "3") || (txtpre2_r3_s2.Text.Trim() == "4"))
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
            if ((txtpre2_r4_c2.Text.Trim() == "1") || (txtpre2_r4_c2.Text.Trim() == "2") || (txtpre2_r4_c2.Text.Trim() == "3") || (txtpre2_r4_c2.Text.Trim() == "4"))
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
            if ((txtpre2_r1_d2.Text != "") && (valTXT1() == true))
            {
                if (txtpre2_r2_i2.Text != "" && (valTXT2() == true))
                {
                    if (txtpre2_r3_s2.Text != "" && (valTXT3() == true))
                    {
                        if (txtpre2_r4_c2.Text != "" && (valTXT4() == true))
                        {

                            Session["pre2_d2"] = Convert.ToInt32(txtpre2_r1_d2.Text);
                            Session["pre2_i2"] = Convert.ToInt32(txtpre2_r2_i2.Text);
                            Session["pre2_s2"] = Convert.ToInt32(txtpre2_r3_s2.Text);
                            Session["pre2_c2"] = Convert.ToInt32(txtpre2_r4_c2.Text);
                            Response.Redirect("Pregunta3.aspx");

                        }
                        else
                        {
                            if (txtpre2_r4_c2.Text == "")
                            {
                                lblmensaje.Text = "Campo Requerido";
                                txtpre2_r4_c2.Focus();
                            }
                            else
                            {
                                lblmensaje.Text = "Solo se aceptan valores del 1 al 4";
                                txtpre2_r4_c2.Focus();
                            }
                        }
                    }
                    else
                    {
                        if (txtpre2_r3_s2.Text == "")
                        {
                            lblmensaje.Text = "Campo Requerido";
                            txtpre2_r3_s2.Focus();
                        }
                        else
                        {
                            lblmensaje.Text = "Solo se aceptan valores del 1 al 4";
                            txtpre2_r3_s2.Focus();
                        }
                    }
                }
                else
                {
                    if (txtpre2_r2_i2.Text == "")
                    {
                        lblmensaje.Text = "Campo Requerido";
                        txtpre2_r2_i2.Focus();
                    }
                    else
                    {
                        lblmensaje.Text = "Solo se aceptan valores del 1 al 4";
                        txtpre2_r2_i2.Focus();
                    }
                }
            }
            else
            {
                if (txtpre2_r1_d2.Text == "")
                {
                    lblmensaje.Text = "Campo Requerido";
                    txtpre2_r1_d2.Focus();
                }
                else
                {
                    lblmensaje.Text = "Solo se aceptan valores del 1 al 4";
                    txtpre2_r1_d2.Focus();
                }
            }
        }
    }
}