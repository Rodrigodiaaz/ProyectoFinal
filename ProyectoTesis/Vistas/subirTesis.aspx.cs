using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.IO;
using ProyectoTesis.Controlador;

namespace ProyectoTesis.Vistas
{
    public partial class subirTesis : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["mensaje"] != null)
            {
                lblMensaje.Text = (string)Session["mensaje"];
            }

        }

        protected void btnSubirTesis_Click(object sender, EventArgs e)
        {
            string nombreArchivo; string strFilePath;
            string carpeta;
            carpeta = Server.MapPath("../pdf/");

            ControladorPublicacion cp = new ControladorPublicacion();


            if (fileTesis.PostedFile.FileName != "")
            {
                nombreArchivo = fileTesis.PostedFile.FileName;
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

                    ControladorTesis ct = new ControladorTesis();
                    if (rdoTsocial.Checked == false && rdoPsico.Checked == false && rdoTraducion.Checked == false)
                    {
                        lblMensaje.Text = "Seleccione un area.";
                    }
                    else
                    {
                        if (rdoTsocial.Checked)
                        {
                            string mensaje = ct.insertaTesis(txtAutores.Text, txtDescripcion.Value, txtProfeGuia.Text, nombreArchivo, txtTitulo.Text, 1);
                            if (mensaje.Equals("Tesis subida con exito."))
                            {
                                fileTesis.PostedFile.SaveAs(strFilePath);
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
                            if (rdoPsico.Checked == true)
                            {
                                string mensaje = ct.insertaTesis(txtAutores.Text, txtDescripcion.Value, txtProfeGuia.Text, nombreArchivo, txtTitulo.Text, 2);
                                if (mensaje.Equals("Tesis subida con exito."))
                                {
                                    fileTesis.PostedFile.SaveAs(strFilePath);
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
                                string mensaje = ct.insertaTesis(txtAutores.Text, txtDescripcion.Value, txtProfeGuia.Text, nombreArchivo, txtTitulo.Text, 3);
                                if (mensaje.Equals("Tesis subida con exito."))
                                {
                                    fileTesis.PostedFile.SaveAs(strFilePath);
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
    }
}