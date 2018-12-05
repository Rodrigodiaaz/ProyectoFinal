using ProyectoTesis.Controlador;
using ProyectoTesis.Modelos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ProyectoTesis.Vistas
{
    public partial class registro : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

       protected void Button1_Click(object sender, EventArgs e)
        {
            ControladorUsuario cu = new ControladorUsuario();
            Usuario u = new Usuario();
            u.Rut = txtRut.Text;
            u.Correo = txtEmail.Text;
            u.Nombre = txtNombres.Text + " " + txtApellidos.Text;
            u.Pass = txtPass.Text;
            u.Fecha_nacimiento = fecha_nacimiento.Value.ToString();
            u.Tipoperfil = "Alumno";
            u.Cargo = "Alumno";
            u.Estado = 0;
            string mensaje = cu.registroUsuario(u, txtPass2.Text.ToString(), txtNombres.Text, txtApellidos.Text);
            if (mensaje.Equals("Usuario Registrado correctamente."))
            {
                Session["mensaje"] = "Usuario Registrado correctamente.";
                Response.Redirect("index.aspx");
            }
            else
            {
                Session["mensaje"] = mensaje;
                lblMensaje.Text = mensaje;
                //Response.Redirect("registro.aspx");
            }
        }
        
    }
}