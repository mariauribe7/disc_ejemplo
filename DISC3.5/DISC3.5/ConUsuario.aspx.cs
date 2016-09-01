using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Rnegocio;
using Entidades;
using System.Data;

namespace DISC3._5
{
    public partial class ConUsuario : System.Web.UI.Page
    {
        CRUsuario oregcliente = new CRUsuario();
        CEUsuario oentcliente = new CEUsuario();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                txtid.Focus();
                DropDownList1.Items.Add("Tipo de Usuario");
                DropDownList1.Items.Add("Administrador");
                DropDownList1.Items.Add("Emprendedor");
                desactivar_campos();

            }

        }


        protected void limpiar_campos()
        {
            txtdir.Text = "";
            txtid.Text = "";
            txtnom.Text = "";
            txttel.Text = "";
            txtcargo.Text = "";
            txtempresa.Text = "";
            DropDownList1.SelectedIndex = 0;

        }
        protected void btnguardar_Click(object sender, EventArgs e)
        {
            if (txtnom.Text.Trim() == "")
            {
                lblmensaje.Text = "Nombre es requerido";
                txtnom.Focus();
            }
            if (txtdir.Text.Trim() == "")
            {
                lblmensaje.Text = "Direccion es requerida";
                txtdir.Focus();
            }
            if (txttel.Text.Trim() == "")
            {
                lblmensaje.Text = "Telefono es requerido";
                txttel.Focus();
            }
            if (txtempresa.Text.Trim() == "")
            {
                lblmensaje.Text = "Nombre de Empresa Requerido";
                txtempresa.Focus();
            }

            if (txtcargo.Text.Trim() == "")
            {
                lblmensaje.Text = "Cargo Rquerido";
                txtempresa.Focus();
            }
            if (DropDownList1.SelectedItem.Text == "Tipo de Usuario")
            {

                lblmensaje.Text = "Debe elegir el tipo de usuario";
                DropDownList1.Focus();

            }
            else
            {
                oentcliente.idusuario = txtid.Text;
                DataSet ds = new DataSet();
                ds = oregcliente.consulta_individual_clientes(oentcliente);
                oentcliente.nombre = txtnom.Text;
                oentcliente.direccion = txtdir.Text;
                oentcliente.telefono = txttel.Text;
                oentcliente.empresa = txtempresa.Text;
                oentcliente.rol_empresa = txtcargo.Text;
                switch (DropDownList1.SelectedValue)
                {
                    case "Emprendedor":
                        oentcliente.rol_login = "2";
                        break;
                    case "Administrador":
                        oentcliente.rol_login = "1";
                        break;
                    default:
                        oentcliente.rol_login = "2";
                        break;
                }



                if (ds.Tables[0].Rows.Count == 0)
                {
                    if (oregcliente.adicionar_clientes(oentcliente))
                    {
                        lblmensaje.Text = "Registro guardado";
                        limpiar_campos();
                        txtid.Enabled = false;
                        desactivar_campos();

                    }
                    else
                    {
                        lblmensaje.Text = "Registro no guardado";
                    }
                }
                else
                {
                    oregcliente.modificar_clientes(oentcliente);
                    lblmensaje.Text = "Registro Modificado";
                    limpiar_campos();

                    desactivar_campos();

                }

            }
        }



        protected void btnlimpiar_Click(object sender, EventArgs e)
        {
            limpiar_campos();
            txtid.Enabled = true;
            desactivar_campos();
            lblmensaje.Text = "";
        }

        protected void btncancelar_Click(object sender, EventArgs e)
        {
            Response.Redirect("MenuAdm.aspx");
        }

        protected void btnconind_Click(object sender, EventArgs e)
        {
            if (txtid.Text.Trim() == "")
            {
                lblmensaje.Text = "Digite una identificación";
            }
            else
            {
                oentcliente.idusuario = txtid.Text;
                DataSet ds = new DataSet();
                ds = oregcliente.consulta_individual_clientes(oentcliente);
                if (ds.Tables[0].Rows.Count == 0)
                {
                    lblmensaje.Text = "Usuario no registrado";
                }
                else
                {
                    lblmensaje.Text = "Cliente ya registrado";
                    txtnom.Text = ds.Tables[0].Rows[0]["nombre"].ToString();
                    txtdir.Text = ds.Tables[0].Rows[0]["direccion"].ToString();
                    txttel.Text = ds.Tables[0].Rows[0]["telefono"].ToString();
                    txtempresa.Text = ds.Tables[0].Rows[0]["empresa"].ToString();
                    txtcargo.Text = ds.Tables[0].Rows[0]["Rol_empresa"].ToString();
                    if (ds.Tables[0].Rows[0]["Rol_Login"].ToString() == "1")
                    {
                        DropDownList1.SelectedIndex = 1;
                    }
                    else
                    {
                        if (ds.Tables[0].Rows[0]["Rol_Login"].ToString() == "2")
                        {
                            DropDownList1.SelectedIndex = 2;
                        }
                    }


                }
                txtid.Enabled = false;
                txtnom.Enabled = true;
                txtdir.Enabled = true;
                txttel.Enabled = true;
                txtempresa.Enabled = true;
                txtcargo.Enabled = true;
                txtnom.Focus();
                btnguardar.Enabled = true;
                DropDownList1.Enabled = true;

            }
        }
        protected void desactivar_campos()
        {
            txttel.Enabled = false;
            txtnom.Enabled = false;
            txtdir.Enabled = false;
            txtempresa.Enabled = false;
            txtcargo.Enabled = false;
            txtid.Enabled = true;
            txtid.Focus();
            btnguardar.Enabled = false;
            DropDownList1.Enabled = false;

        }



    }
}