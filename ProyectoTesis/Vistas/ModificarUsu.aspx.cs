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
    public partial class ModificarUsu : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["logeado"] == null)
            {
                Session["mensaje"] = "No tiene permisos para acceder aqui.";
                Response.Redirect("index.aspx");
            }
            else
            {
                Usuario u = (Usuario)Session["logeado"];
                lblNombreactual.Text = u.Nombre;
                lblCorreoActual.Text = u.Correo;
                if (Session["mensaje"] != null)
                {
                    lblMensaje.Text = (string)Session["mensaje"];
                }
                
            }
        }

        protected void btnModificarcorreo_Click(object sender, EventArgs e)
        {
            ControladorUsuario cu = new ControladorUsuario();
            Usuario u = (Usuario)Session["logeado"];
            u.Correo = txtCorreoNuevo.Value;
            string mensaje = cu.modificarUsuario(u, u.Pass);
            if (mensaje.Equals("Usuario modificado con exito."))
            {
                Session["mensaje"] = mensaje;
                Response.Redirect(Request.Url.AbsoluteUri);
            }
            else
            {
                lblMensaje.Text = mensaje;
            }
        }

        protected void btnCambiarNombre_Click(object sender, EventArgs e)
        {
            ControladorUsuario cu = new ControladorUsuario();
            Usuario u = (Usuario)Session["logeado"];
            u.Nombre = txtNombreNuevo.Value;
            string mensaje = cu.modificarUsuario(u, u.Pass);
            if (mensaje.Equals("Usuario modificado con exito."))
            {
                Session["mensaje"] = mensaje;
                Response.Redirect(Request.Url.AbsoluteUri);
            }
            else
            {
                lblMensaje.Text = mensaje;
            }
        }

        protected void btnModificarcontraseña_Click(object sender, EventArgs e)
        {
            ControladorUsuario cu = new ControladorUsuario();
            Usuario u = (Usuario)Session["logeado"];
            if (txtOldPass.Value.Equals(u.Pass))
            {
                u.Pass = txtNewPass.Value;
                string mensaje = cu.modificarUsuario(u, txtConfirmaPass.Value);
                if (mensaje.Equals("Usuario modificado con exito."))
                {
                    u = null;
                    Session["mensaje"] = mensaje;
                    Response.Redirect(Request.Url.AbsoluteUri);
                }
                else
                {
                    u = null;
                    lblMensaje.Text = mensaje;
                }
            }
            else
            {
                u = null;
                lblMensaje.Text = "La contraseña actual es incorrecta.";
            }
            
        }
    }
}