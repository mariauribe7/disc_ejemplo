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
    public partial class Pregunta4 : System.Web.UI.Page
    {
        CEResultado_D oeresultado_d = new CEResultado_D();
        CEResultado_I oeresultado_i = new CEResultado_I();
        CEResultado_S oeresultado_s = new CEResultado_S();
        CEResultado_C oeresultado_c = new CEResultado_C();

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                txtpre4_r1_d4.Focus();
            }
        }

        protected bool valTXT1()
        {
            if ((txtpre4_r1_d4.Text.Trim() == "1") || (txtpre4_r1_d4.Text.Trim() == "2") || (txtpre4_r1_d4.Text.Trim() == "3") || (txtpre4_r1_d4.Text.Trim() == "4"))
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
            if ((txtpre4_r2_i4.Text.Trim() == "1") || (txtpre4_r2_i4.Text.Trim() == "2") || (txtpre4_r2_i4.Text.Trim() == "3") || (txtpre4_r2_i4.Text.Trim() == "4"))
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
            if ((txtpre4_r3_s4.Text.Trim() == "1") || (txtpre4_r3_s4.Text.Trim() == "2") || (txtpre4_r3_s4.Text.Trim() == "3") || (txtpre4_r3_s4.Text.Trim() == "4"))
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
            if ((txtpre4_r4_c4.Text.Trim() == "1") || (txtpre4_r4_c4.Text.Trim() == "2") || (txtpre4_r4_c4.Text.Trim() == "3") || (txtpre4_r4_c4.Text.Trim() == "4"))
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
            if ((txtpre4_r1_d4.Text != "") && (valTXT1() == true))
            {
                if (txtpre4_r2_i4.Text != "" && (valTXT2() == true))
                {
                    if (txtpre4_r3_s4.Text != "" && (valTXT3() == true))
                    {
                        if (txtpre4_r4_c4.Text != "" && (valTXT4() == true))
                        {
                            Session["pre4_d4"] = Convert.ToInt32(txtpre4_r1_d4.Text);
                            Session["pre4_i4"] = Convert.ToInt32(txtpre4_r2_i4.Text);
                            Session["pre4_s4"] = Convert.ToInt32(txtpre4_r3_s4.Text);
                            Session["pre4_c4"] = Convert.ToInt32(txtpre4_r4_c4.Text);
                            Response.Redirect("Pregunta5.aspx");

                        }
                        else
                        {
                            if (txtpre4_r4_c4.Text == "")
                            {
                                lblmensaje.Text = "Campo Requerido";
                                txtpre4_r4_c4.Focus();
                            }
                            else
                            {
                                lblmensaje.Text = "Solo se aceptan valores del 1 al 4";
                                txtpre4_r4_c4.Focus();
                            }
                        }
                    }
                    else
                    {
                        if (txtpre4_r3_s4.Text == "")
                        {
                            lblmensaje.Text = "Campo Requerido";
                            txtpre4_r3_s4.Focus();
                        }
                        else
                        {
                            lblmensaje.Text = "Solo se aceptan valores del 1 al 4";
                            txtpre4_r3_s4.Focus();
                        }
                    }
                }
                else
                {
                    if (txtpre4_r2_i4.Text == "")
                    {
                        lblmensaje.Text = "Campo Requerido";
                        txtpre4_r2_i4.Focus();
                    }
                    else
                    {
                        lblmensaje.Text = "Solo se aceptan valores del 1 al 4";
                        txtpre4_r2_i4.Focus();
                    }
                }
            }
            else
            {
                if (txtpre4_r1_d4.Text == "")
                {
                    lblmensaje.Text = "Campo Requerido";
                    txtpre4_r1_d4.Focus();
                }
                else
                {
                    lblmensaje.Text = "Solo se aceptan valores del 1 al 4";
                    txtpre4_r1_d4.Focus();
                }
            }
        }
    }
}