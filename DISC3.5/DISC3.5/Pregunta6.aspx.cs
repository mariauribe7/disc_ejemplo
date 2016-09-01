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
    public partial class Pregunta6 : System.Web.UI.Page
    {
        CEResultado_D oeresultado_d = new CEResultado_D();
        CEResultado_I oeresultado_i = new CEResultado_I();
        CEResultado_S oeresultado_s = new CEResultado_S();
        CEResultado_C oeresultado_c = new CEResultado_C();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                txtpre6_r1_d6.Focus();
            }
        }
        protected bool valTXT1()
        {
            if ((txtpre6_r1_d6.Text.Trim() == "1") || (txtpre6_r1_d6.Text.Trim() == "2") || (txtpre6_r1_d6.Text.Trim() == "3") || (txtpre6_r1_d6.Text.Trim() == "4"))
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
            if ((txtpre6_r2_i6.Text.Trim() == "1") || (txtpre6_r2_i6.Text.Trim() == "2") || (txtpre6_r2_i6.Text.Trim() == "3") || (txtpre6_r2_i6.Text.Trim() == "4"))
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
            if ((txtpre6_r3_s6.Text.Trim() == "1") || (txtpre6_r3_s6.Text.Trim() == "2") || (txtpre6_r3_s6.Text.Trim() == "3") || (txtpre6_r3_s6.Text.Trim() == "4"))
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
            if ((txtpre6_r4_c6.Text.Trim() == "1") || (txtpre6_r4_c6.Text.Trim() == "2") || (txtpre6_r4_c6.Text.Trim() == "3") || (txtpre6_r4_c6.Text.Trim() == "4"))
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
            if ((txtpre6_r1_d6.Text != "") && (valTXT1() == true))
            {
                if (txtpre6_r2_i6.Text != "" && (valTXT2() == true))
                {
                    if (txtpre6_r3_s6.Text != "" && (valTXT3() == true))
                    {
                        if (txtpre6_r4_c6.Text != "" && (valTXT4() == true))
                        {
                            Session["pre6_d6"] = Convert.ToInt32(txtpre6_r1_d6.Text);
                            Session["pre6_i6"] = Convert.ToInt32(txtpre6_r2_i6.Text);
                            Session["pre6_s6"] = Convert.ToInt32(txtpre6_r3_s6.Text);
                            Session["pre6_c6"] = Convert.ToInt32(txtpre6_r4_c6.Text);
                            Response.Redirect("Pregunta7.aspx");
                        }
                        else
                        {
                            if (txtpre6_r4_c6.Text == "")
                            {
                                lblmensaje.Text = "Campo Requerido";
                                txtpre6_r4_c6.Focus();
                            }
                            else
                            {
                                lblmensaje.Text = "Solo se aceptan valores del 1 al 4";
                                txtpre6_r4_c6.Focus();
                            }
                        }
                    }
                    else
                    {
                        if (txtpre6_r3_s6.Text == "")
                        {
                            lblmensaje.Text = "Campo Requerido";
                            txtpre6_r3_s6.Focus();
                        }
                        else
                        {
                            lblmensaje.Text = "Solo se aceptan valores del 1 al 4";
                            txtpre6_r3_s6.Focus();
                        }
                    }
                }
                else
                {
                    if (txtpre6_r2_i6.Text == "")
                    {
                        lblmensaje.Text = "Campo Requerido";
                        txtpre6_r2_i6.Focus();
                    }
                    else
                    {
                        lblmensaje.Text = "Solo se aceptan valores del 1 al 4";
                        txtpre6_r2_i6.Focus();
                    }
                }
            }
            else
            {
                if (txtpre6_r1_d6.Text == "")
                {
                    lblmensaje.Text = "Campo Requerido";
                    txtpre6_r1_d6.Focus();
                }
                else
                {
                    lblmensaje.Text = "Solo se aceptan valores del 1 al 4";
                    txtpre6_r1_d6.Focus();
                }
            }
        }
    }
}