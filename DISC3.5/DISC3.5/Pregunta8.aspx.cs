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
    public partial class Pregunta8 : System.Web.UI.Page
    {
        CEResultado_D oeresultado_d = new CEResultado_D();
        CEResultado_I oeresultado_i = new CEResultado_I();
        CEResultado_S oeresultado_s = new CEResultado_S();
        CEResultado_C oeresultado_c = new CEResultado_C();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                txtpre8_r1_d8.Focus();
            }

        }
        protected bool valTXT1()
        {
            if ((txtpre8_r1_d8.Text.Trim() == "1") || (txtpre8_r1_d8.Text.Trim() == "2") || (txtpre8_r1_d8.Text.Trim() == "3") || (txtpre8_r1_d8.Text.Trim() == "4"))
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
            if ((txtpre8_r2_i8.Text.Trim() == "1") || (txtpre8_r2_i8.Text.Trim() == "2") || (txtpre8_r2_i8.Text.Trim() == "3") || (txtpre8_r2_i8.Text.Trim() == "4"))
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
            if ((txtpre8_r3_s8.Text.Trim() == "1") || (txtpre8_r3_s8.Text.Trim() == "2") || (txtpre8_r3_s8.Text.Trim() == "3") || (txtpre8_r3_s8.Text.Trim() == "4"))
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
            if ((txtpre8_r4_c8.Text.Trim() == "1") || (txtpre8_r4_c8.Text.Trim() == "2") || (txtpre8_r4_c8.Text.Trim() == "3") || (txtpre8_r4_c8.Text.Trim() == "4"))
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
            if ((txtpre8_r1_d8.Text != "") && (valTXT1() == true))
            {
                if (txtpre8_r2_i8.Text != "" && (valTXT2() == true))
                {
                    if (txtpre8_r3_s8.Text != "" && (valTXT3() == true))
                    {
                        if (txtpre8_r4_c8.Text != "" && (valTXT4() == true))
                        {
                            Session["pre8_d8"] = Convert.ToInt32(txtpre8_r1_d8.Text);
                            Session["pre8_i8"] = Convert.ToInt32(txtpre8_r2_i8.Text);
                            Session["pre8_s8"] = Convert.ToInt32(txtpre8_r3_s8.Text);
                            Session["pre8_c8"] = Convert.ToInt32(txtpre8_r4_c8.Text);

                            Response.Redirect("Pregunta9.aspx");

                        }
                        else
                        {
                            if (txtpre8_r4_c8.Text == "")
                            {
                                lblmensaje.Text = "Campo Requerido";
                                txtpre8_r4_c8.Focus();
                            }
                            else
                            {
                                lblmensaje.Text = "Solo se aceptan valores del 1 al 4";
                                txtpre8_r4_c8.Focus();
                            }
                        }
                    }
                    else
                    {
                        if (txtpre8_r3_s8.Text == "")
                        {
                            lblmensaje.Text = "Campo Requerido";
                            txtpre8_r3_s8.Focus();
                        }
                        else
                        {
                            lblmensaje.Text = "Solo se aceptan valores del 1 al 4";
                            txtpre8_r3_s8.Focus();
                        }
                    }
                }
                else
                {
                    if (txtpre8_r2_i8.Text == "")
                    {
                        lblmensaje.Text = "Campo Requerido";
                        txtpre8_r2_i8.Focus();
                    }
                    else
                    {
                        lblmensaje.Text = "Solo se aceptan valores del 1 al 4";
                        txtpre8_r2_i8.Focus();
                    }
                }
            }
            else
            {
                if (txtpre8_r1_d8.Text == "")
                {
                    lblmensaje.Text = "Campo Requerido";
                    txtpre8_r1_d8.Focus();
                }
                else
                {
                    lblmensaje.Text = "Solo se aceptan valores del 1 al 4";
                    txtpre8_r1_d8.Focus();
                }
            }
        }
    }
}