using System;
using System.Collections;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.HtmlControls;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Xml.Linq;
using System.Data.SqlClient;
using Entidades;
using Rnegocio;
using System.IO;

namespace DISC3._5
{
    public partial class Informe : System.Web.UI.Page
    {
        CEResultado_D oeresultado_d = new CEResultado_D();
        CRResultado_D orresultado_d = new CRResultado_D();
        CEUsuario oeusuario = new CEUsuario();
        CRUsuario orusuario = new CRUsuario();
        DataSet ds1 = new DataSet();
        DataSet ds2 = new DataSet();
        DataSet ds3 = new DataSet();
        DataSet ds4 = new DataSet();
        string ident;
        int[] DISC = new int[4];
        int[] A = new int[4];
        int D, I, S, C, i, j, aux, D1, I1, S1, C1;
        CEResultado_S oeresultado_s = new CEResultado_S();
        CEResultado_C oeresultado_c = new CEResultado_C();
        CEResultado_I oeresultado_i = new CEResultado_I();
        CRRTotales ortotal = new CRRTotales();
        CRInforme oInformes = new CRInforme();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                ocultarCampos();
            }
        }

        private void llenarDDL()
        {
            DropDownList1.Items.Add("Seleccione Prueba");
            oeresultado_d.idusuario = TextBox1.Text;

            ds1 = orresultado_d.consulta_prueba(oeresultado_d);
            int np = Convert.ToInt32(ds1.Tables[0].Rows[0]["cantidad"].ToString().Trim());
            if (ds1.Tables[0].Rows.Count > 0)
            {
                for (int i = 1; i <= np; i++)
                {
                    DropDownList1.Items.Add("Prueba " + i);
                }
            }

        }

        protected void llenarGVusr()
        {
            oeusuario.idusuario = TextBox1.Text;
            ds1 = orusuario.consulta_individual_clientes(oeusuario);
            GridView1.DataSource = ds1;
            GridView1.DataBind();
            GridView1.Visible = true;
        }

        protected void btncolsultar_Click(object sender, EventArgs e)
        {
            DropDownList1.Enabled = true;
            btncolsultar.Enabled = true;
            TextBox1.Enabled = false;
            llenarDDL();
            oeresultado_d.idusuario = TextBox1.Text;
            ds1 = orresultado_d.consulta_prueba(oeresultado_d);
            int np = Convert.ToInt32(ds1.Tables[0].Rows[0]["cantidad"].ToString().Trim());
            if (np >= 1)
            {
                DropDownList1.Enabled = true;
                llenarGVusr();
                btngreporte.Visible = true;
                btncolsultar.Enabled = false;
            }
            else
            {
                lblmensaje.Text = "Este usuario no ha realizado ninguna prueba";
                btncolsultar.Enabled = false;
                DropDownList1.Enabled = false;
                btngreporte.Visible = false;
                btnlimpiar.Visible = true;
            }
        }

        protected void btngreporte_Click(object sender, EventArgs e)
        {
            if (DropDownList1.SelectedItem.Text == "Seleccione Prueba")
            {
                lblmensaje.Text = "Debe elegir el tipo de usuario";
                DropDownList1.Focus();
            }
            else
            {
                oeresultado_d.idusuario = TextBox1.Text.Trim();
                oeresultado_d.n_prueba = DropDownList1.SelectedIndex.ToString().Trim();
                ds1 = ortotal.resTotalesD(oeresultado_d);
                GridView3.DataSource = ds1;
                GridView3.DataBind();

                oeresultado_c.idusuario = TextBox1.Text.Trim();
                oeresultado_c.n_prueba = DropDownList1.SelectedIndex.ToString().Trim();
                ds2 = ortotal.resTotalesC(oeresultado_c);
                GridView2.DataSource = ds2;
                GridView2.DataBind();

                oeresultado_i.idusuario = TextBox1.Text.Trim();
                oeresultado_i.n_prueba = DropDownList1.SelectedIndex.ToString().Trim();
                ds3 = ortotal.resTotalesI(oeresultado_i);
                GridView4.DataSource = ds3;
                GridView4.DataBind();

                oeresultado_s.idusuario = TextBox1.Text.Trim();
                oeresultado_s.n_prueba = DropDownList1.SelectedIndex.ToString().Trim();
                ds4 = ortotal.resTotalesS(oeresultado_s);
                GridView5.DataSource = ds4;
                GridView5.DataBind();
                GridView2.Visible = true;
                GridView3.Visible = true;
                GridView4.Visible = true;
                GridView5.Visible = true;
                btnlimpiar.Visible = true;
                DropDownList1.Enabled = false;
                validaciones();
                btngreporte.Enabled = false;
                
                string D,I,S,C;
                D = ds1.Tables[0].Rows[0]["SumaD"].ToString();
                I = ds3.Tables[0].Rows[0]["SumaI"].ToString();
                S = ds4.Tables[0].Rows[0]["SumaS"].ToString();
                C = ds2.Tables[0].Rows[0]["SumaC"].ToString();

                txtD.Text = D;
                txtI.Text = I;
                txtS.Text = S;
                txtC.Text = C;

            }
        }

        protected void btnlimpiar_Click(object sender, EventArgs e)
        {
            TextBox1.Text = "";
            TextBox1.Enabled = true;
            btncolsultar.Enabled = true;
            DropDownList1.Items.Clear();
            DropDownList1.Enabled = false;
            ocultarCampos();
            lblmensaje.Text = "";
            ocultarDescargas();
            btngreporte.Enabled = true;
        }
        protected void ocultarCampos()
        {

            btngreporte.Visible = false;
            btnlimpiar.Visible = false;
            GridView1.Visible = false;
            GridView2.Visible = false;
            GridView3.Visible = false;
            GridView4.Visible = false;
            GridView5.Visible = false;
        }

        protected void btnregresar_Click(object sender, EventArgs e)
        {
            Response.Redirect("MenuAdm.aspx");
        }

        protected void LinkButton1_Click(object sender, EventArgs e)
        {
            string filePath = "img/dominante.pdf";
            Response.ContentType = ContentType;
            Response.AppendHeader("Content-Disposition", "attachment; filename=" + Path.GetFileName(filePath));

            Response.WriteFile(filePath);
            Response.End();
        }

        protected void LinkButton2_Click(object sender, EventArgs e)
        {
            string filePath = "img/influyente.pdf";
            Response.ContentType = ContentType;
            Response.AppendHeader("Content-Disposition", "attachment; filename=" + Path.GetFileName(filePath));

            Response.WriteFile(filePath);
            Response.End();
        }

        protected void LinkButton3_Click(object sender, EventArgs e)
        {
            string filePath = "img/solido.pdf";
            Response.ContentType = ContentType;
            Response.AppendHeader("Content-Disposition", "attachment; filename=" + Path.GetFileName(filePath));

            Response.WriteFile(filePath);
            Response.End();
        }

        protected void LinkButton4_Click(object sender, EventArgs e)
        {
            string filePath = "img/concienzudo.pdf";
            Response.ContentType = ContentType;
            Response.AppendHeader("Content-Disposition", "attachment; filename=" + Path.GetFileName(filePath));

            Response.WriteFile(filePath);
            Response.End();
        }
        protected void ocultarDescargas()
        {
            LinkButton1.Visible = false;
            LinkButton2.Visible = false;
            LinkButton3.Visible = false;
            LinkButton4.Visible = false;
        }
        protected void validaciones()
        {
            A = resultadosDISC();
            D1 = A[0];
            I1 = A[1];
            S1 = A[2];
            C1 = A[3];

            for (i = 0; i < A.Length - 1; i++)
            {
                for (j = 0; j < A.Length - i - 1; j++)
                {
                    if (A[j + 1] < A[j])
                    {
                        aux = A[j + 1];
                        A[j + 1] = A[j];
                        A[j] = aux;
                    }
                }
            }

            if (A[3] == D1)
            {
                LinkButton1.Visible = true;
            }
            else
            {
                if (A[3] == I1)
                {
                    LinkButton2.Visible = true;
                }
                else
                {
                    if (A[3] == S1)
                    {
                        LinkButton3.Visible = true;
                    }
                    else
                    {
                        if (A[3] == C1)
                        {
                            LinkButton4.Visible = true;
                        }
                    }
                }
            }
        }

        protected int[] resultadosDISC()
        {
            ident = TextBox1.Text.Trim();
            oeresultado_d.idusuario = ident;
            oeresultado_i.idusuario = ident;
            oeresultado_s.idusuario = ident;
            oeresultado_c.idusuario = ident;
            int np = Convert.ToInt32(DropDownList1.SelectedIndex.ToString().Trim());
            oeresultado_d.n_prueba = Convert.ToString(np);
            oeresultado_i.n_prueba = Convert.ToString(np);
            oeresultado_s.n_prueba = Convert.ToString(np);
            oeresultado_c.n_prueba = Convert.ToString(np);
            DataSet ds3 = new DataSet();
            ds3 = ortotal.resTotalesD(oeresultado_d);
            D = Convert.ToInt32(ds3.Tables[0].Rows[0]["SumaD"].ToString().Trim());
            DataSet ds4 = new DataSet();
            ds4 = ortotal.resTotalesI(oeresultado_i);
            I = Convert.ToInt32(ds4.Tables[0].Rows[0]["SumaI"].ToString().Trim());
            DataSet ds5 = new DataSet();
            ds5 = ortotal.resTotalesS(oeresultado_s);
            S = Convert.ToInt32(ds5.Tables[0].Rows[0]["SumaS"].ToString().Trim());
            DataSet ds6 = new DataSet();
            ds6 = ortotal.resTotalesC(oeresultado_c);
            C = Convert.ToInt32(ds6.Tables[0].Rows[0]["SumaC"].ToString().Trim());
            DISC[0] = D;
            DISC[1] = I;
            DISC[2] = S;
            DISC[3] = C;
            return DISC;
        }

    }
}