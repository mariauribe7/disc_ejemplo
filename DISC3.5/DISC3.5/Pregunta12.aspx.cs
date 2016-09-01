using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Net;
using System.Web.UI;
using System.Web.UI.WebControls;
using Rnegocio;
using Entidades;
using System.Data;
using System.IO;

namespace DISC3._5
{
    public partial class Pregunta12 : System.Web.UI.Page
    {
        CEResultado_D oeresultado_d = new CEResultado_D();
        CEResultado_S oeresultado_s = new CEResultado_S();
        CEResultado_C oeresultado_c = new CEResultado_C();
        CEResultado_I oeresultado_i = new CEResultado_I();

        CRResultado_D orresultado_d = new CRResultado_D();
        CRResultado_I orresultado_i = new CRResultado_I();
        CRResultado_S orresultado_s = new CRResultado_S();
        CRResultado_C orresultado_c = new CRResultado_C();
        CRRTotales ortotal = new CRRTotales();
        string ident;
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                txtpre12_r1_d12.Focus();

            }
        }
        protected bool valTXT1()
        {
            if ((txtpre12_r1_d12.Text.Trim() == "1") || (txtpre12_r1_d12.Text.Trim() == "2") || (txtpre12_r1_d12.Text.Trim() == "3") || (txtpre12_r1_d12.Text.Trim() == "4"))
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
            if ((txtpre12_r2_i12.Text.Trim() == "1") || (txtpre12_r2_i12.Text.Trim() == "2") || (txtpre12_r2_i12.Text.Trim() == "3") || (txtpre12_r2_i12.Text.Trim() == "4"))
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
            if ((txtpre12_r3_s12.Text.Trim() == "1") || (txtpre12_r3_s12.Text.Trim() == "2") || (txtpre12_r3_s12.Text.Trim() == "3") || (txtpre12_r3_s12.Text.Trim() == "4"))
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
            if ((txtpre12_r4_c12.Text.Trim() == "1") || (txtpre12_r4_c12.Text.Trim() == "2") || (txtpre12_r4_c12.Text.Trim() == "3") || (txtpre12_r4_c12.Text.Trim() == "4"))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        protected void otrasPreg()
        {
            oeresultado_d.pre1 = (int)Session["pre1_d1"];
            oeresultado_d.pre2 = (int)Session["pre2_d2"];
            oeresultado_d.pre3 = (int)Session["pre3_d3"];
            oeresultado_d.pre4 = (int)Session["pre4_d4"];
            oeresultado_d.pre5 = (int)Session["pre5_d5"];
            oeresultado_d.pre6 = (int)Session["pre6_d6"];
            oeresultado_d.pre7 = (int)Session["pre7_d7"];
            oeresultado_d.pre8 = (int)Session["pre8_d8"];
            oeresultado_d.pre9 = (int)Session["pre9_d9"];
            oeresultado_d.pre10 = (int)Session["pre10_d10"];
            oeresultado_d.pre11 = (int)Session["pre11_d11"];


            oeresultado_i.pre1 = (int)Session["pre1_i1"];
            oeresultado_i.pre2 = (int)Session["pre2_i2"];
            oeresultado_i.pre3 = (int)Session["pre3_i3"];
            oeresultado_i.pre4 = (int)Session["pre4_i4"];
            oeresultado_i.pre5 = (int)Session["pre5_i5"];
            oeresultado_i.pre6 = (int)Session["pre6_i6"];
            oeresultado_i.pre7 = (int)Session["pre7_i7"];
            oeresultado_i.pre8 = (int)Session["pre8_i8"];
            oeresultado_i.pre9 = (int)Session["pre9_i9"];
            oeresultado_i.pre10 = (int)Session["pre10_i10"];
            oeresultado_i.pre11 = (int)Session["pre11_i11"];


            oeresultado_s.pre1 = (int)Session["pre1_s1"];
            oeresultado_s.pre2 = (int)Session["pre2_s2"];
            oeresultado_s.pre3 = (int)Session["pre3_s3"];
            oeresultado_s.pre4 = (int)Session["pre4_s4"];
            oeresultado_s.pre5 = (int)Session["pre5_s5"];
            oeresultado_s.pre6 = (int)Session["pre6_s6"];
            oeresultado_s.pre7 = (int)Session["pre7_s7"];
            oeresultado_s.pre8 = (int)Session["pre8_s8"];
            oeresultado_s.pre9 = (int)Session["pre9_s9"];
            oeresultado_s.pre10 = (int)Session["pre10_s10"];
            oeresultado_s.pre11 = (int)Session["pre11_s11"];


            oeresultado_c.pre1 = (int)Session["pre1_c1"];
            oeresultado_c.pre2 = (int)Session["pre2_c2"];
            oeresultado_c.pre3 = (int)Session["pre3_c3"];
            oeresultado_c.pre4 = (int)Session["pre4_c4"];
            oeresultado_c.pre5 = (int)Session["pre5_c5"];
            oeresultado_c.pre6 = (int)Session["pre6_c6"];
            oeresultado_c.pre7 = (int)Session["pre7_c7"];
            oeresultado_c.pre8 = (int)Session["pre8_c8"];
            oeresultado_c.pre9 = (int)Session["pre9_c9"];
            oeresultado_c.pre10 = (int)Session["pre10_c10"];
            oeresultado_c.pre11 = (int)Session["pre11_c11"];
        }

        protected void btnenviar_Click(object sender, EventArgs e)
        {
            try
            {
                if ((txtpre12_r1_d12.Text != "") && (valTXT1() == true))
                {
                    if (txtpre12_r2_i12.Text != "" && (valTXT2() == true))
                    {
                        if (txtpre12_r3_s12.Text != "" && (valTXT3() == true))
                        {
                            if (txtpre12_r4_c12.Text != "" && (valTXT4() == true))
                            {
                                ident = Session["usuario"].ToString();
                                oeresultado_d.idusuario = ident;
                                oeresultado_i.idusuario = ident;
                                oeresultado_s.idusuario = ident;
                                oeresultado_c.idusuario = ident;
                                DataSet ds = new DataSet();
                                ds = orresultado_d.consulta_prueba(oeresultado_d);
                                int np = Convert.ToInt32(ds.Tables[0].Rows[0]["cantidad"].ToString().Trim());

                                int nuevaPrueb = np + 1;

                                oeresultado_d.n_prueba = Convert.ToString(nuevaPrueb);
                                oeresultado_i.n_prueba = Convert.ToString(nuevaPrueb);
                                oeresultado_s.n_prueba = Convert.ToString(nuevaPrueb);
                                oeresultado_c.n_prueba = Convert.ToString(nuevaPrueb);
                                otrasPreg();
                                oeresultado_d.pre12 = Convert.ToInt32(txtpre12_r1_d12.Text);
                                oeresultado_i.pre12 = Convert.ToInt32(txtpre12_r2_i12.Text);
                                oeresultado_s.pre12 = Convert.ToInt32(txtpre12_r3_s12.Text);
                                oeresultado_c.pre12 = Convert.ToInt32(txtpre12_r4_c12.Text);

                                orresultado_d.agregar_resultado_d(oeresultado_d);
                                orresultado_i.agregar_resultado_i(oeresultado_i);
                                orresultado_s.agregar_resultado_s(oeresultado_s);
                                orresultado_c.agregar_resultado_c(oeresultado_c);

                                Response.Redirect("FinalUsr.aspx");

                            }
                            else
                            {
                                if (txtpre12_r4_c12.Text == "")
                                {
                                    lblmensaje.Text = "Campo Requerido";
                                    txtpre12_r4_c12.Focus();
                                }
                                else
                                {
                                    lblmensaje.Text = "Solo se aceptan valores del 1 al 4";
                                    txtpre12_r4_c12.Focus();
                                }
                            }
                        }
                        else
                        {
                            if (txtpre12_r3_s12.Text == "")
                            {
                                lblmensaje.Text = "Campo Requerido";
                                txtpre12_r3_s12.Focus();
                            }
                            else
                            {
                                lblmensaje.Text = "Solo se aceptan valores del 1 al 4";
                                txtpre12_r3_s12.Focus();
                            }
                        }
                    }
                    else
                    {
                        if (txtpre12_r2_i12.Text == "")
                        {
                            lblmensaje.Text = "Campo Requerido";
                            txtpre12_r2_i12.Focus();
                        }
                        else
                        {
                            lblmensaje.Text = "Solo se aceptan valores del 1 al 4";
                            txtpre12_r2_i12.Focus();
                        }
                    }
                }
                else
                {
                    if (txtpre12_r1_d12.Text == "")
                    {
                        lblmensaje.Text = "Campo Requerido";
                        txtpre12_r1_d12.Focus();
                    }
                    else
                    {
                        lblmensaje.Text = "Solo se aceptan valores del 1 al 4";
                        txtpre12_r1_d12.Focus();
                    }
                }
            }
            catch (Exception ex)
            {

            }

        }
    }
}