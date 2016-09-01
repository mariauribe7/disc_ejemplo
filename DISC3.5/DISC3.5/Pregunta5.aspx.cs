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
    public partial class Pregunta5 : System.Web.UI.Page
    {
        CEResultado_D oeresultado_d = new CEResultado_D();
        CEResultado_I oeresultado_i = new CEResultado_I();
        CEResultado_S oeresultado_s = new CEResultado_S();
        CEResultado_C oeresultado_c = new CEResultado_C();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                txtpre5_r1_d5.Focus();
            }
        }
        protected bool valTXT1()
        {
            if ((txtpre5_r1_d5.Text.Trim() == "1") || (txtpre5_r1_d5.Text.Trim() == "2") || (txtpre5_r1_d5.Text.Trim() == "3") || (txtpre5_r1_d5.Text.Trim() == "4"))
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
            if ((txtpre5_r2_i5.Text.Trim() == "1") || (txtpre5_r2_i5.Text.Trim() == "2") || (txtpre5_r2_i5.Text.Trim() == "3") || (txtpre5_r2_i5.Text.Trim() == "4"))
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
            if ((txtpre5_r3_s5.Text.Trim() == "1") || (txtpre5_r3_s5.Text.Trim() == "2") || (txtpre5_r3_s5.Text.Trim() == "3") || (txtpre5_r3_s5.Text.Trim() == "4"))
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
            if ((txtpre5_r4_c5.Text.Trim() == "1") || (txtpre5_r4_c5.Text.Trim() == "2") || (txtpre5_r4_c5.Text.Trim() == "3") || (txtpre5_r4_c5.Text.Trim() == "4"))
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
            if ((txtpre5_r1_d5.Text != "") && (valTXT1() == true))
            {
                if (txtpre5_r2_i5.Text != "" && (valTXT2() == true))
                {
                    if (txtpre5_r3_s5.Text != "" && (valTXT3() == true))
                    {
                        if (txtpre5_r4_c5.Text != "" && (valTXT4() == true))
                        {

                            Session["pre5_d5"] = Convert.ToInt32(txtpre5_r1_d5.Text);
                            Session["pre5_i5"] = Convert.ToInt32(txtpre5_r2_i5.Text);
                            Session["pre5_s5"] = Convert.ToInt32(txtpre5_r3_s5.Text);
                            Session["pre5_c5"] = Convert.ToInt32(txtpre5_r4_c5.Text);
                            Response.Redirect("Pregunta6.aspx");

                        }
                        else
                        {
                            if (txtpre5_r4_c5.Text == "")
                            {
                                lblmensaje.Text = "Campo Requerido";
                                txtpre5_r4_c5.Focus();
                            }
                            else
                            {
                                lblmensaje.Text = "Solo se aceptan valores del 1 al 4";
                                txtpre5_r4_c5.Focus();
                            }
                        }
                    }
                    else
                    {
                        if (txtpre5_r3_s5.Text == "")
                        {
                            lblmensaje.Text = "Campo Requerido";
                            txtpre5_r3_s5.Focus();
                        }
                        else
                        {
                            lblmensaje.Text = "Solo se aceptan valores del 1 al 4";
                            txtpre5_r3_s5.Focus();
                        }
                    }
                }
                else
                {
                    if (txtpre5_r2_i5.Text == "")
                    {
                        lblmensaje.Text = "Campo Requerido";
                        txtpre5_r2_i5.Focus();
                    }
                    else
                    {
                        lblmensaje.Text = "Solo se aceptan valores del 1 al 4";
                        txtpre5_r2_i5.Focus();
                    }
                }
            }
            else
            {
                if (txtpre5_r1_d5.Text == "")
                {
                    lblmensaje.Text = "Campo Requerido";
                    txtpre5_r1_d5.Focus();
                }
                else
                {
                    lblmensaje.Text = "Solo se aceptan valores del 1 al 4";
                    txtpre5_r1_d5.Focus();
                }
            }
        }
    }
}