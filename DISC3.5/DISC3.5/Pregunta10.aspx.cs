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
    public partial class Pregunta10 : System.Web.UI.Page
    {
        CEResultado_D oeresultado_d = new CEResultado_D();
        CEResultado_I oeresultado_i = new CEResultado_I();
        CEResultado_S oeresultado_s = new CEResultado_S();
        CEResultado_C oeresultado_c = new CEResultado_C();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                txtpre10_r1_d10.Focus();
            }
        }
        protected bool valTXT1()
        {
            if ((txtpre10_r1_d10.Text.Trim() == "1") || (txtpre10_r1_d10.Text.Trim() == "2") || (txtpre10_r1_d10.Text.Trim() == "3") || (txtpre10_r1_d10.Text.Trim() == "4"))
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
            if ((txtpre10_r2_i10.Text.Trim() == "1") || (txtpre10_r2_i10.Text.Trim() == "2") || (txtpre10_r2_i10.Text.Trim() == "3") || (txtpre10_r2_i10.Text.Trim() == "4"))
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
            if ((txtpre10_r3_s10.Text.Trim() == "1") || (txtpre10_r3_s10.Text.Trim() == "2") || (txtpre10_r3_s10.Text.Trim() == "3") || (txtpre10_r3_s10.Text.Trim() == "4"))
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
            if ((txtpre10_r4_c10.Text.Trim() == "1") || (txtpre10_r4_c10.Text.Trim() == "2") || (txtpre10_r4_c10.Text.Trim() == "3") || (txtpre10_r4_c10.Text.Trim() == "4"))
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
            if ((txtpre10_r1_d10.Text != "") && (valTXT1() == true))
            {
                if (txtpre10_r2_i10.Text != "" && (valTXT2() == true))
                {
                    if (txtpre10_r3_s10.Text != "" && (valTXT3() == true))
                    {
                        if (txtpre10_r4_c10.Text != "" && (valTXT4() == true))
                        {
                            Session["pre10_d10"] = Convert.ToInt32(txtpre10_r1_d10.Text);
                            Session["pre10_i10"] = Convert.ToInt32(txtpre10_r2_i10.Text);
                            Session["pre10_s10"] = Convert.ToInt32(txtpre10_r3_s10.Text);
                            Session["pre10_c10"] = Convert.ToInt32(txtpre10_r4_c10.Text);
                            Response.Redirect("Pregunta11.aspx");
                        }
                        else
                        {
                            if (txtpre10_r4_c10.Text == "")
                            {
                                lblmensaje.Text = "Campo Requerido";
                                txtpre10_r4_c10.Focus();
                            }
                            else
                            {
                                lblmensaje.Text = "Solo se aceptan valores del 1 al 4";
                                txtpre10_r4_c10.Focus();
                            }
                        }
                    }
                    else
                    {
                        if (txtpre10_r3_s10.Text == "")
                        {
                            lblmensaje.Text = "Campo Requerido";
                            txtpre10_r3_s10.Focus();
                        }
                        else
                        {
                            lblmensaje.Text = "Solo se aceptan valores del 1 al 4";
                            txtpre10_r3_s10.Focus();
                        }
                    }
                }
                else
                {
                    if (txtpre10_r2_i10.Text == "")
                    {
                        lblmensaje.Text = "Campo Requerido";
                        txtpre10_r2_i10.Focus();
                    }
                    else
                    {
                        lblmensaje.Text = "Solo se aceptan valores del 1 al 4";
                        txtpre10_r2_i10.Focus();
                    }
                }
            }
            else
            {
                if (txtpre10_r1_d10.Text == "")
                {
                    lblmensaje.Text = "Campo Requerido";
                    txtpre10_r1_d10.Focus();
                }
                else
                {
                    lblmensaje.Text = "Solo se aceptan valores del 1 al 4";
                    txtpre10_r1_d10.Focus();
                }
            }
        }
    }
}