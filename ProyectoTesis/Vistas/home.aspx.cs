using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ProyectoTesis.Modelos;
using ProyectoTesis.Controlador;
using System.IO;

namespace ProyectoTesis.Vistas
{
    public partial class home1 : System.Web.UI.Page
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
                lblNombre.Text = u.Nombre;
            }
        }

        protected void PublicarActualizacion(object sender, EventArgs e)
        {
            Usuario u = (Usuario)Session["logeado"];
            string nombreArchivo; string strFilePath;
            string carpeta;
            carpeta = Server.MapPath("../media/" + u.Id + "/");

            ControladorPublicacion cp = new ControladorPublicacion();
            
            if (Archivo.Value != "" && txtContenidoPublicacion.Value.Equals(""))
            {
                nombreArchivo = Archivo.PostedFile.FileName;
                nombreArchivo = Path.GetFileName(nombreArchivo);
                if (!Directory.Exists(carpeta))
                {
                    Directory.CreateDirectory(carpeta);
                }

                // Save the uploaded file to the server.
                strFilePath = carpeta + nombreArchivo;

                if (File.Exists(strFilePath))
                {
                    lblInforArchivo.Text = nombreArchivo + " ya existe!";
                }
                else
                {
                    Archivo.PostedFile.SaveAs(strFilePath);
                    lblInforArchivo.Text = nombreArchivo + " se subio con exito.";
                }

            }
            else
            {
                if (!txtContenidoPublicacion.Value.Equals("") && Archivo.Value == "")
                {
                    string mensaje = cp.realizarActializacion(u.Id.ToString(), u.Id.ToString(), txtContenidoPublicacion.Value, DateTime.Now.ToString());
                    if (mensaje.Equals("Actualizacion realizada con exito"))
                    {
                        lblMensaje.Text = mensaje;
                    }
                    else
                    {
                        lblMensaje.Text = mensaje;
                    }
                }
            }
        }
            
       
        protected void subirarchivo(object sender, EventArgs e)
        {
            lblInforArchivo.Text = Archivo.PostedFile.FileName;
        }
    }
}