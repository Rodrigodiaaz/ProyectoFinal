using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ProyectoTesis.Controlador;
using ProyectoTesis.Modelos;

namespace ProyectoTesis.Vistas
{
    public partial class index : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["mensaje"] != null)
            {
                lblMensaje.Text = Session["mensaje"].ToString();
                Session["mensaje"] = null;
            }
        }

        protected void btnLogin_Click(object sender, EventArgs e)
        {
            ControladorUsuario cu = new ControladorUsuario();
            if (cu.loginUsuario(txtId.Text, txtPass.Text).Equals("Login Exitoso."))
            {

                lblMensaje.Text = cu.loginUsuario(txtId.Text, txtPass.Text);
                Usuario us = cu.buscarUsuario(txtId.Text);
                Session["Logeado"] = us;
                Response.Redirect("home.aspx");
            }
            else
            {
                lblMensaje.Text = cu.loginUsuario(txtId.Text, txtPass.Text);
            }
        }
    }
}