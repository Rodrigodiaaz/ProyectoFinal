using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ProyectoTesis.Modelos;
using ProyectoTesis.Controlador;

namespace ProyectoTesis.Vistas
{
    public partial class modificarUsuario : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["usuario"] !=  null)
            {
                Usuario u  = (Usuario) Session["usuario"];
                txtNombre.Value = u.Nombre;
                txtCorreo.Value = u.Correo;
            }
            else
            {
                Session["mensaje"] = "No tiene permisos para entrar aqui.";
                Response.Redirect("index.aspx");
            }

        }

        /*protected void btnModificar_Click(object sender, EventArgs e)
        {
            string mensaje = "";
            ControladorAlumno cu = new ControladorAlumno();
            Usuario us = (Usuario)Session["usuario"];
            us.Nombre = txtNombre.Value.ToString();
            us.Correo = txtCorreo.Value.ToString();
            us.Pass = txtContraseña.Value.ToString();
            mensaje = cu.modificarUsuario(us, txtRepetirContraseña.Value.ToString());
            if (mensaje.Equals("Usuario modificado con exito."))
            {
                lblMensaje.InnerText = mensaje;
            }
            else
            {
                lblMensaje.InnerText = mensaje;
            }
        }
        */
    }
}