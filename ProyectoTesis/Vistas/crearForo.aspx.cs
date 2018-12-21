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
    public partial class crearForo : System.Web.UI.Page
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
                if (Session["mensaje"] != null)
                {
                    lblMensaje.Text = (string)Session["mensaje"];
                    Session["mensaje"] = null;
                }
            }

        }

        protected void btnCrearDiscusion_Click(object sender, EventArgs e)
        {
            Usuario u = (Usuario)Session["logeado"];
            ControladorTopic ct = new ControladorTopic();
            if (rdoTsocial.Checked == false && rdoPsico.Checked == false && rdoTraducion.Checked == false)
            {
                lblMensaje.Text = "Seleccione un area.";
            }
            else
            {
                if (rdoTsocial.Checked)
                {
                    string mensaje = ct.publicarTopic(u.Id, txtTitulo.Text, txtTexto.Value, 1);
                    if (mensaje.Equals("Discusión creada con exito."))
                    {
                        Session["mensaje"] = mensaje;
                        Response.Redirect(Request.Url.AbsoluteUri);
                    }
                    else
                    {         
                 
                        lblMensaje.Text = mensaje;
                    }
                }
              
                else 
                {
                    if (rdoTraducion.Checked == true)
                    {
                        string mensaje = ct.publicarTopic(u.Id, txtTitulo.Text, txtTexto.Value, 3);
                        if (mensaje.Equals("Discusión creada con exito."))
                        {
                            Session["mensaje"] = mensaje;
                            Response.Redirect(Request.Url.AbsoluteUri);
                        }
                        else
                        {
                            lblMensaje.Text = mensaje;
                        }
                    }
                    else
                    {
                        string mensaje = ct.publicarTopic(u.Id, txtTitulo.Text, txtTexto.Value, 2);
                        if (mensaje.Equals("Discusión creada con exito."))
                        {
                            Session["mensaje"] = mensaje;
                            Response.Redirect(Request.Url.AbsoluteUri);
                        }
                        else
                        {
                            lblMensaje.Text = mensaje;
                        }
                    }

                    
                }
            }
        }
    }
}