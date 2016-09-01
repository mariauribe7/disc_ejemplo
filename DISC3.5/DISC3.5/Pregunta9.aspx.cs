using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Entidades;
using Rnegocio;

namespace DISC3._5
{
    public partial class Pregunta9 : System.Web.UI.Page
    {
        CEResultado_D oeresultado_d = new CEResultado_D();
        CEResultado_I oeresultado_i = new CEResultado_I();
        CEResultado_S oeresultado_s = new CEResultado_S();
        CEResultado_C oeresultado_c = new CEResultado_C();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                txtpre9_r1_d9.Focus();
            }
        }
        protected bool valTXT1()
        {
            if ((txtpre9_r1_d9.Text.Trim() == "1") || (txtpre9_r1_d9.Text.Trim() == "2") || (txtpre9_r1_d9.Text.Trim() == "3") || (txtpre9_r1_d9.Text.Trim() == "4"))
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
            if ((txtpre9_r2_i9.Text.Trim() == "1") || (txtpre9_r2_i9.Text.Trim() == "2") || (txtpre9_r2_i9.Text.Trim() == "3") || (txtpre9_r2_i9.Text.Trim() == "4"))
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
            if ((txtpre9_r3_s9.Text.Trim() == "1") || (txtpre9_r3_s9.Text.Trim() == "2") || (txtpre9_r3_s9.Text.Trim() == "3") || (txtpre9_r3_s9.Text.Trim() == "4"))
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
            if ((txtpre9_r4_c9.Text.Trim() == "1") || (txtpre9_r4_c9.Text.Trim() == "2") || (txtpre9_r4_c9.Text.Trim() == "3") || (txtpre9_r4_c9.Text.Trim() == "4"))
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
            if ((txtpre9_r1_d9.Text != "") && (valTXT1() == true))
            {
                if (txtpre9_r2_i9.Text != "" && (valTXT2() == true))
                {
                    if (txtpre9_r3_s9.Text != "" && (valTXT3() == true))
                    {
                        if (txtpre9_r4_c9.Text != "" && (valTXT4() == true))
                        {
                            Session["pre9_d9"] = Convert.ToInt32(txtpre9_r1_d9.Text);
                            Session["pre9_i9"] = Convert.ToInt32(txtpre9_r2_i9.Text);
                            Session["pre9_s9"] = Convert.ToInt32(txtpre9_r3_s9.Text);
                            Session["pre9_c9"] = Convert.ToInt32(txtpre9_r4_c9.Text);
                            Response.Redirect("Pregunta10.aspx");

                        }
                        else
                        {
                            if (txtpre9_r4_c9.Text == "")
                            {
                                lblmensaje.Text = "Campo Requerido";
                                txtpre9_r4_c9.Focus();
                            }
                            else
                            {
                                lblmensaje.Text = "Solo se aceptan valores del 1 al 4";
                                txtpre9_r4_c9.Focus();
                            }
                        }
                    }
                    else
                    {
                        if (txtpre9_r3_s9.Text == "")
                        {
                            lblmensaje.Text = "Campo Requerido";
                            txtpre9_r3_s9.Focus();
                        }
                        else
                        {
                            lblmensaje.Text = "Solo se aceptan valores del 1 al 4";
                            txtpre9_r3_s9.Focus();
                        }
                    }
                }
                else
                {
                    if (txtpre9_r2_i9.Text == "")
                    {
                        lblmensaje.Text = "Campo Requerido";
                        txtpre9_r2_i9.Focus();
                    }
                    else
                    {
                        lblmensaje.Text = "Solo se aceptan valores del 1 al 4";
                        txtpre9_r2_i9.Focus();
                    }
                }
            }
            else
            {
                if (txtpre9_r1_d9.Text == "")
                {
                    lblmensaje.Text = "Campo Requerido";
                    txtpre9_r1_d9.Focus();
                }
                else
                {
                    lblmensaje.Text = "Solo se aceptan valores del 1 al 4";
                    txtpre9_r1_d9.Focus();
                }
            }
        }
    }
}