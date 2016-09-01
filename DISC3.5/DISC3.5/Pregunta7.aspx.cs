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
    public partial class Pregunta7 : System.Web.UI.Page
    {
        CEResultado_D oeresultado_d = new CEResultado_D();
        CEResultado_I oeresultado_i = new CEResultado_I();
        CEResultado_S oeresultado_s = new CEResultado_S();
        CEResultado_C oeresultado_c = new CEResultado_C();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                txtpre7_r1_d7.Focus();
            }
        }
        protected bool valTXT1()
        {
            if ((txtpre7_r1_d7.Text.Trim() == "1") || (txtpre7_r1_d7.Text.Trim() == "2") || (txtpre7_r1_d7.Text.Trim() == "3") || (txtpre7_r1_d7.Text.Trim() == "4"))
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
            if ((txtpre7_r2_i7.Text.Trim() == "1") || (txtpre7_r2_i7.Text.Trim() == "2") || (txtpre7_r2_i7.Text.Trim() == "3") || (txtpre7_r2_i7.Text.Trim() == "4"))
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
            if ((txtpre7_r3_s7.Text.Trim() == "1") || (txtpre7_r3_s7.Text.Trim() == "2") || (txtpre7_r3_s7.Text.Trim() == "3") || (txtpre7_r3_s7.Text.Trim() == "4"))
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
            if ((txtpre7_r4_c7.Text.Trim() == "1") || (txtpre7_r4_c7.Text.Trim() == "2") || (txtpre7_r4_c7.Text.Trim() == "3") || (txtpre7_r4_c7.Text.Trim() == "4"))
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
            if ((txtpre7_r1_d7.Text != "") && (valTXT1() == true))
            {
                if (txtpre7_r2_i7.Text != "" && (valTXT2() == true))
                {
                    if (txtpre7_r3_s7.Text != "" && (valTXT3() == true))
                    {
                        if (txtpre7_r4_c7.Text != "" && (valTXT4() == true))
                        {
                            Session["pre7_d7"] = Convert.ToInt32(txtpre7_r1_d7.Text);
                            Session["pre7_i7"] = Convert.ToInt32(txtpre7_r2_i7.Text);
                            Session["pre7_s7"] = Convert.ToInt32(txtpre7_r3_s7.Text);
                            Session["pre7_c7"] = Convert.ToInt32(txtpre7_r4_c7.Text);
                            Response.Redirect("pregunta8.aspx");
                        }
                        else
                        {
                            if (txtpre7_r4_c7.Text == "")
                            {
                                lblmensaje.Text = "Campo Requerido";
                                txtpre7_r4_c7.Focus();
                            }
                            else
                            {
                                lblmensaje.Text = "Solo se aceptan valores del 1 al 4";
                                txtpre7_r4_c7.Focus();
                            }
                        }
                    }
                    else
                    {
                        if (txtpre7_r3_s7.Text == "")
                        {
                            lblmensaje.Text = "Campo Requerido";
                            txtpre7_r3_s7.Focus();
                        }
                        else
                        {
                            lblmensaje.Text = "Solo se aceptan valores del 1 al 4";
                            txtpre7_r3_s7.Focus();
                        }
                    }
                }
                else
                {
                    if (txtpre7_r2_i7.Text == "")
                    {
                        lblmensaje.Text = "Campo Requerido";
                        txtpre7_r2_i7.Focus();
                    }
                    else
                    {
                        lblmensaje.Text = "Solo se aceptan valores del 1 al 4";
                        txtpre7_r2_i7.Focus();
                    }
                }
            }
            else
            {
                if (txtpre7_r1_d7.Text == "")
                {
                    lblmensaje.Text = "Campo Requerido";
                    txtpre7_r1_d7.Focus();
                }
                else
                {
                    lblmensaje.Text = "Solo se aceptan valores del 1 al 4";
                    txtpre7_r1_d7.Focus();
                }
            }
        }
    }
}