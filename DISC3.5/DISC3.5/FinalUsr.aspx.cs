using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Rnegocio;
using Entidades;
using System.Data;
using System.IO;

namespace DISC3._5
{
    public partial class FinalUsr : System.Web.UI.Page
    {
        int[] A = new int[4];
        int D, I, S, C, i, j, aux;
        string ident;
        CEResultado_D oeresultado_d = new CEResultado_D();
        CEResultado_S oeresultado_s = new CEResultado_S();
        CEResultado_C oeresultado_c = new CEResultado_C();
        CEResultado_I oeresultado_i = new CEResultado_I();
        CRResultado_D orresultado_d = new CRResultado_D();
        CRResultado_I orresultado_i = new CRResultado_I();
        CRResultado_S orresultado_s = new CRResultado_S();
        CRResultado_C orresultado_c = new CRResultado_C();
        CRRTotales ortotal = new CRRTotales();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                //validaciones();
            }
        }

        protected void btnsalir_Click(object sender, EventArgs e)
        {
            Response.Redirect("Login.aspx");
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
        public int[] sumas()
        {
            ident = Session["usuario"].ToString();
            oeresultado_d.idusuario = ident;
            oeresultado_i.idusuario = ident;
            oeresultado_s.idusuario = ident;
            oeresultado_c.idusuario = ident;
            DataSet ds = new DataSet();
            ds = orresultado_d.consulta_prueba(oeresultado_d);
            int np = Convert.ToInt32(ds.Tables[0].Rows[0]["cantidad"].ToString().Trim());
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
            A[0] = D;
            A[1] = I;
            A[2] = S;
            A[3] = C;

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

            return A;

        }

        //public void validaciones()
        //{
        //    A = sumas();
        //    ident = Session["usuario"].ToString();
        //    oeresultado_d.idusuario = ident;
        //    oeresultado_i.idusuario = ident;
        //    oeresultado_s.idusuario = ident;
        //    oeresultado_c.idusuario = ident;
        //    DataSet ds = new DataSet();
        //    ds = orresultado_d.consulta_prueba(oeresultado_d);
        //    int np = Convert.ToInt32(ds.Tables[0].Rows[0]["cantidad"].ToString().Trim());
        //    oeresultado_d.n_prueba = Convert.ToString(np);
        //    oeresultado_i.n_prueba = Convert.ToString(np);
        //    oeresultado_s.n_prueba = Convert.ToString(np);
        //    oeresultado_c.n_prueba = Convert.ToString(np);
        //    DataSet ds3 = new DataSet();
        //    ds3 = ortotal.resTotalesD(oeresultado_d);
        //    D = Convert.ToInt32(ds3.Tables[0].Rows[0]["SumaD"].ToString().Trim());
        //    DataSet ds4 = new DataSet();
        //    ds4 = ortotal.resTotalesI(oeresultado_i);
        //    I = Convert.ToInt32(ds4.Tables[0].Rows[0]["SumaI"].ToString().Trim());
        //    DataSet ds5 = new DataSet();
        //    ds5 = ortotal.resTotalesS(oeresultado_s);
        //    S = Convert.ToInt32(ds5.Tables[0].Rows[0]["SumaS"].ToString().Trim());
        //    DataSet ds6 = new DataSet();
        //    ds6 = ortotal.resTotalesC(oeresultado_c);
        //    C = Convert.ToInt32(ds6.Tables[0].Rows[0]["SumaC"].ToString().Trim());

        //    if (A[3] == D)
        //    {
        //        LinkButton1.Visible = true;
        //    }
        //    else
        //    {
        //        if (A[3] == I)
        //        {
        //            LinkButton2.Visible = true;
        //        }
        //        else
        //        {
        //            if (A[3] == S)
        //            {
        //                LinkButton3.Visible = true;
        //            }
        //            else
        //            {
        //                if (A[3] == C)
        //                {
        //                    LinkButton4.Visible = true;
        //                }
        //            }
        //        }
        //    }


        //}
    }
}