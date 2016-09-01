using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using Entidades;
using Rnegocio;

namespace DISC3._5
{
    public partial class Pregunta1 : System.Web.UI.Page
    {
        CEResultado_D oeresultado_d = new CEResultado_D();
        CEResultado_I oeresultado_i = new CEResultado_I();
        CEResultado_S oeresultado_s = new CEResultado_S();
        CEResultado_C oeresultado_c = new CEResultado_C();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                txtpre1_r1_d1.Focus();
            }
        }

        protected bool valTXT1()
        {
            if ((txtpre1_r1_d1.Text.Trim() == "1") || (txtpre1_r1_d1.Text.Trim() == "2") || (txtpre1_r1_d1.Text.Trim() == "3") || (txtpre1_r1_d1.Text.Trim() == "4"))
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
            if ((txtpre1_r2_i1.Text.Trim() == "1") || (txtpre1_r2_i1.Text.Trim() == "2") || (txtpre1_r2_i1.Text.Trim() == "3") || (txtpre1_r2_i1.Text.Trim() == "4"))
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
            if ((txtpre1_r3_s1.Text.Trim() == "1") || (txtpre1_r3_s1.Text.Trim() == "2") || (txtpre1_r3_s1.Text.Trim() == "3") || (txtpre1_r3_s1.Text.Trim() == "4"))
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
            if ((txtpre1_r4_c1.Text.Trim() == "1") || (txtpre1_r4_c1.Text.Trim() == "2") || (txtpre1_r4_c1.Text.Trim() == "3") || (txtpre1_r4_c1.Text.Trim() == "4"))
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
            if ((txtpre1_r1_d1.Text != "") && (valTXT1() == true))
            {
                if (txtpre1_r2_i1.Text != "" && (valTXT2() == true))
                {
                    if (txtpre1_r3_s1.Text != "" && (valTXT3() == true))
                    {
                        if (txtpre1_r4_c1.Text != "" && (valTXT4() == true))
                        {
                            Session["pre1_d1"] = Convert.ToInt32(txtpre1_r1_d1.Text);
                            Session["pre1_i1"] = Convert.ToInt32(txtpre1_r2_i1.Text);
                            Session["pre1_s1"] = Convert.ToInt32(txtpre1_r3_s1.Text);
                            Session["pre1_c1"] = Convert.ToInt32(txtpre1_r4_c1.Text);

                            this.Response.Redirect("Pregunta2.aspx");
                        }
                        else
                        {
                            if (txtpre1_r4_c1.Text == "")
                            {
                                lblmensaje.Text = "Campo Requerido";
                                txtpre1_r4_c1.Focus();
                            }
                            else
                            {
                                lblmensaje.Text = "Solo se aceptan valores del 1 al 4";
                                txtpre1_r4_c1.Focus();
                            }
                        }
                    }
                    else
                    {
                        if (txtpre1_r3_s1.Text == "")
                        {
                            lblmensaje.Text = "Campo Requerido";
                            txtpre1_r3_s1.Focus();
                        }
                        else
                        {
                            lblmensaje.Text = "Solo se aceptan valores del 1 al 4";
                            txtpre1_r3_s1.Focus();
                        }
                    }
                }
                else
                {
                    if (txtpre1_r2_i1.Text == "")
                    {
                        lblmensaje.Text = "Campo Requerido";
                        txtpre1_r2_i1.Focus();
                    }
                    else
                    {
                        lblmensaje.Text = "Solo se aceptan valores del 1 al 4";
                        txtpre1_r2_i1.Focus();
                    }
                }
            }
            else
            {
                if (txtpre1_r1_d1.Text == "")
                {
                    lblmensaje.Text = "Campo Requerido";
                    txtpre1_r1_d1.Focus();
                }
                else
                {
                    lblmensaje.Text = "Solo se aceptan valores del 1 al 4";
                    txtpre1_r1_d1.Focus();
                }
            }
        }
    }
}