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
    public partial class Pregunta3 : System.Web.UI.Page
    {
        CEResultado_D oeresultado_d = new CEResultado_D();
        CEResultado_I oeresultado_i = new CEResultado_I();
        CEResultado_S oeresultado_s = new CEResultado_S();
        CEResultado_C oeresultado_c = new CEResultado_C();

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                txtpre3_r1_d3.Focus();
            }

        }
        protected bool valTXT1()
        {
            if ((txtpre3_r1_d3.Text.Trim() == "1") || (txtpre3_r1_d3.Text.Trim() == "2") || (txtpre3_r1_d3.Text.Trim() == "3") || (txtpre3_r1_d3.Text.Trim() == "4"))
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
            if ((txtpre3_r2_i3.Text.Trim() == "1") || (txtpre3_r2_i3.Text.Trim() == "2") || (txtpre3_r2_i3.Text.Trim() == "3") || (txtpre3_r2_i3.Text.Trim() == "4"))
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
            if ((txtpre3_r3_s3.Text.Trim() == "1") || (txtpre3_r3_s3.Text.Trim() == "2") || (txtpre3_r3_s3.Text.Trim() == "3") || (txtpre3_r3_s3.Text.Trim() == "4"))
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
            if ((txtpre3_r4_c3.Text.Trim() == "1") || (txtpre3_r4_c3.Text.Trim() == "2") || (txtpre3_r4_c3.Text.Trim() == "3") || (txtpre3_r4_c3.Text.Trim() == "4"))
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
            if ((txtpre3_r1_d3.Text != "") && (valTXT1() == true))
            {
                if (txtpre3_r2_i3.Text != "" && (valTXT2() == true))
                {
                    if (txtpre3_r3_s3.Text != "" && (valTXT3() == true))
                    {
                        if (txtpre3_r4_c3.Text != "" && (valTXT4() == true))
                        {
                            Session["pre3_d3"] = Convert.ToInt32(txtpre3_r1_d3.Text);
                            Session["pre3_i3"] = Convert.ToInt32(txtpre3_r2_i3.Text);
                            Session["pre3_s3"] = Convert.ToInt32(txtpre3_r3_s3.Text);
                            Session["pre3_c3"] = Convert.ToInt32(txtpre3_r4_c3.Text);
                            Response.Redirect("pregunta4.aspx");
                        }
                        else
                        {
                            if (txtpre3_r4_c3.Text == "")
                            {
                                lblmensaje.Text = "Campo Requerido";
                                txtpre3_r4_c3.Focus();
                            }
                            else
                            {
                                lblmensaje.Text = "Solo se aceptan valores del 1 al 4";
                                txtpre3_r4_c3.Focus();
                            }
                        }
                    }
                    else
                    {
                        if (txtpre3_r3_s3.Text == "")
                        {
                            lblmensaje.Text = "Campo Requerido";
                            txtpre3_r3_s3.Focus();
                        }
                        else
                        {
                            lblmensaje.Text = "Solo se aceptan valores del 1 al 4";
                            txtpre3_r3_s3.Focus();
                        }
                    }
                }
                else
                {
                    if (txtpre3_r2_i3.Text == "")
                    {
                        lblmensaje.Text = "Campo Requerido";
                        txtpre3_r2_i3.Focus();
                    }
                    else
                    {
                        lblmensaje.Text = "Solo se aceptan valores del 1 al 4";
                        txtpre3_r2_i3.Focus();
                    }
                }
            }
            else
            {
                if (txtpre3_r1_d3.Text == "")
                {
                    lblmensaje.Text = "Campo Requerido";
                    txtpre3_r1_d3.Focus();
                }
                else
                {
                    lblmensaje.Text = "Solo se aceptan valores del 1 al 4";
                    txtpre3_r1_d3.Focus();
                }
            }

        }
    }
}