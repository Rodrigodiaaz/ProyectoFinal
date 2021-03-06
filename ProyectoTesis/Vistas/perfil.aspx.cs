﻿using ProyectoTesis.Controlador;
using ProyectoTesis.Modelos;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ProyectoTesis.Vistas
{
    public partial class perfil : System.Web.UI.Page
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
                try
                {
                    string id = Request.QueryString["id"];
                    Usuario us = new Usuario();
                    Usuario u = null;
                    u = us.buscaUnoID(id);
                    if (Session["mensajeUsuario"] != null)
                    {
                        lblMensaje.Text = (string)Session["mensajeUsuario"];
                    }
                    
                    lblNombre.Text = u.Nombre;
                }
                catch (NullReferenceException)
                {
                    Response.Redirect("MenuPrincipal.aspx");
                }
                
            }
        }

        protected void PublicarActualizacion(object sender, EventArgs e)
        {
            Usuario u = (Usuario)Session["logeado"];
            string nombreArchivo; string strFilePath;
            string carpeta;
            carpeta = Server.MapPath("../media/" + u.Id + "/");

            ControladorPublicacion cp = new ControladorPublicacion();


            if (Archivo.Value != "" && txtPublicacion.Value.Equals(""))
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
                    lblMensaje.Text = nombreArchivo + " ya existe!";
                }
                else
                {
                    Archivo.PostedFile.SaveAs(strFilePath);
                    lblMensaje.Text = nombreArchivo + " se subio con exito.";
                }

            }
            else
            {
                if (!txtPublicacion.Value.Equals("") && Archivo.Value == "")
                {
                    string mensaje = cp.realizarActializacion(u.Id.ToString(), u.Id.ToString(), txtPublicacion.Value, DateTime.Now.ToString());
                    if (mensaje.Equals("Comentario realizado con exito"))
                    {
                        Session["mensajeUsuario"] = mensaje;
                        Response.Redirect(Request.Url.AbsoluteUri);

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
            lblMensaje.Text = Archivo.PostedFile.FileName;
        }
    }
}