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
    public partial class MenuTesis : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            string tema = Request.QueryString["tema"];
            try
            {
                if (tema.Equals("t") || tema.Equals("p") || tema.Equals("ts"))
                {
                    if (Session["logeado"] != null)
                    {
                        Usuario log = (Usuario)Session["logeado"];
                        Response.Write("<!DOCTYPE html>" +
           "<html lang='en'>" +

            "<head>" +
              "<style type='text/css'></style>" +
              "<meta charset='utf-8'>" +
              "<meta name='viewport' content='width=device-width, initial-scale=1, shrink-to-fit=no'>" +
              "<meta name='description' content=''>" +
              "<meta name='author' content=''>" +
              "<title>RSTSP</title>" +
              "<link href='/vendor/bootstrap/css/bootstrap.min.css' rel='stylesheet'>" +
              "<link href='/css/scrolling-nav.css' rel='stylesheet'>" +
              "<link href='../css/estilos.css' rel='stylesheet' />" +
              "<link rel='stylesheet' type='text/css' href='../css/w3.css'>" +
              "<script src='https://ajax.googleapis.com/ajax/libs/jquery/3.3.1/jquery.min.js'></script>" +
              "<script src='https://maxcdn.bootstrapcdn.com/bootstrap/3.3.7/js/bootstrap.min.js'></script>" +
              "<style>" +
              ".sidenav {" +
                  "background-color: #f1f1f1;" +
              "}" +
              "#mainNav{" +
                "background:  #8B0000;" +
              "}" +
              "#MainFooter{" +
                  "background:  #8B0000;" +
              "}" +
            "</style>" +

           "</head>" +

           "<body id='page-top'>" +
               "<!-- Navigation -->" +
                  "<nav class='navbar navbar-expand-lg  fixed-top' id='mainNav'>" +
                      "<div class='container'>" +
                          "<p class='navbar-brand js-scroll-trigger' href='#page-top'><img class='rounded img - fluid' width='105px' height='85px' src='../img/logo2.jpg'></p>" +
                          "<button class='navbar-toggler' type='button' data-toggle='collapse' data-target='#navbarResponsive' aria-controls='navbarResponsive' aria-expanded='false' aria-label='Toggle navigation'>" +

                              "<span class='navbar-toggler-icon'></span>" +
                          "</button>" +


                          "<div class='collapse navbar-collapse' id='navbarResponsive'>" +


                              "<input class='form-control ml-5 lg-5 mr-5 lg-5 mt-lg-3 mb-lg-3' type='search' placeholder='Busqueda' aria-label='Search'>" +
                          "</div>" +
                      "</div>" +
                  "</nav>" +
           "<header>" +
           "<div class='container-fluid'>" +
            "<div class='row content'>" +
              "<div class='col-lg-3 sidenav w3-card'>" +
                "<blockquote class='blockquote'>" +
                  "<p class='mb-0'>Administrador o Usuario</p>" +
                  "<br />" +
                  "<footer class=''> <img class='rounded img-fluid' width='50px' height='50px' src='../img/menu.jpg'>Menu</footer>" +
                  "</blockquote>" +
                "<ul class='list-group'>");
                        if (log.Tipoperfil.Equals("Alumno"))
                        {
                            Response.Write("<li class='list-group-item'><a href='home.aspx'>Perfil</a></li>" +
                "<li class='list-group-item'><a href='temaforo.aspx'>Foros</a></li>" +
                "<li class='list-group-item'><a href='videoconferencia.aspx'>Ver Video Conferencia</a></li>" +
                "<li class='list-group-item'><a href='tematesis.aspx'>Menu Tesis</a></li>" +
                "<li class='list-group-item'><a href='crearForo.aspx'>Crear Foro</a></li>" +
                "<li class='list-group-item'><a href='modificarusu.aspx'>Modificar Usuario</a></li>");
                        }
                        else
                        {
                            Response.Write("<li class='list-group-item'><a href='home.aspx'>Perfil</a></li>" +
                "<li class='list-group-item'><a href='menuforo.aspx'>Menu Foros</a></li>" +
                "<li class='list-group-item'><a href='videoconferencia.aspx'>Video Conferencia</a></li>" +
                "<li class='list-group-item'><a href='subirTesis.aspx'>Subir Tesis</a></li>" +
                "<li class='list-group-item'><a href='menutesis.aspx'>Menu Tesis</a></li>" +
                "<li class='list-group-item'><a href='crearForo.aspx'>Crear Foro</a></li>" +
                "<li class='list-group-item'><a href='modificarusu.aspx'>Modificar Usuario</a></li>");
                        }
                        Response.Write("</ul>" +
                  "<br />" +
                  "<br />" +
                "</div>" +
                "<div class='col-lg-6 w3-card'>" +
                  "<div class='text-center'><h2>Menu listado de Tesis</h2></div>" +
                  "<h5 class='EmblemaP2'>&nbsp;&nbsp;&nbsp;&nbsp;</h5>");
                        if (Session["mensajetesis"] != null)
                        {
                            Response.Write((string)Session["mensajetesis"]);
                            Session["mensajetesis"] = null;
                        }
                        Response.Write("<br />" +
                   "<table class='table'>" +
                          "<thead class='thead-dark'>" +
                              "<tr>" +
                                "<th scope='col'>Nombre de Tesis</th>" +
                                "<th scope='col'>Profesor</th>" +
                                "<th scope='col'>Autor</th>");
                        if (log.Tipoperfil.Equals("Administrativo"))
                        {
                            Response.Write("<th scope='col'>Accion</th>");
                        }

                        // "<th scope='col'>Eliminar</th>" +
                        Response.Write("</tr>" +
                            "</thead>" +
                            "<tbody>");
                        if (tema.Equals("p"))
                        {
                            ControladorTesis ct = new ControladorTesis();
                            List<Tesis> alltesis = ct.ObtenerporTema(2);
                            if (alltesis.Count > 0)
                            {
                                for (int i = 0; i < alltesis.Count; i++)
                                {
                                    Usuario us = new Usuario();
                                    Tesis ts = new Tesis();
                                    Usuario autor = us.buscaUnoID(alltesis[i].Idtesis.ToString());

                                    Response.Write("<tr>" +
                                  "<td><a href='tesis.aspx?idtesis=" + alltesis[i].Idtesis + "'><p>" + alltesis[i].Titulo + "</p></a></td>" +
                                  "<td><p>" + alltesis[i].Profesor_guia + "</p></td>" +
                                  "<td><p>" + alltesis[i].Autor + "</p></td>");
                                    if (log.Tipoperfil.Equals("Administrativo"))
                                    {
                                        Response.Write("<td><a href='../Controlador/cTesis.aspx?idtesis="+alltesis[i].Idtesis+"&tema="+tema+"'>Eliminar tesis</a></td>");
                                    }



                                    Response.Write("</tr>");
                                }
                                Response.Write(
                                  "</tbody>" +
                                "</table>" +
                          "<hr class='w3-clear' />" +
                          "</div>" +
                           "<div class='col-lg-3 sidenav w3-card'>" +
                                "<blockquote class='blockquote'>" +
                            "<p class='mb-0'>Soñando</p>" +
                            "<br />" +
                            "<footer class='text-center'><img src = '../img/perfil.jpg'' style='width: 150px ' height:'150px' class='rounded-circle'> </footer>" +
                            "</blockquote>" +
                          "<ul class='list-group'>" +
                            "<li class='list-group-item'>" +
                            "<p><em>'idea es generar un espacio abierto a la reflexión, discusión, el compartir y construir diversas estrategias y acciones para y desde las Ciencias Sociales. Donde logren converger actores estratégicos como son egresad@s, alumn@s, instituciones y la propia comunidad." +
                            "Nuestro sentido se plasma en entregar servicios digitales gratuitos, los cuales logren facilitar el constante perfeccionamiento e innovación socio-profesional, y desde allí soñar y construir en conjunto.'</em></p></li>" +
                          "</ul>" +
                          "<br />" +
                          "<br />" +
                          "<br />" +
                          "<br />" +
                        "</div> " +
                         "</div>     " +
                    "</div>" +
                    "</header>       " +
                            "<!-- Footer -->" +
                            "<footer class='py-lg-5 py-5' id='MainFooter'>" +
                                "<div class='container'>" +
                                    "<p class='m-0 text-center text-white'>Copyright &copy; Quality Essentials 2018</p>" +
                                "</div>" +
                                "<!-- /.container -->" +
                            "</footer>");

                            }
                            else
                            {
                                Response.Write("</tbody>" +
                                "<tr>" +
                                "<th><a href='#'><p>No hay tesis disponibles</p></a></th>" +
                                "<th scope='col'></th>" +
                                "<th scope='col'></th>" +
                                "</tr>" +
                            "<tbody>" +
                        "</table>" +
                  "<hr class='w3-clear' />" +
                  "</div>" +
                   "<div class='col-lg-3 sidenav w3-card'>" +
                    "<blockquote class='blockquote'>" +
                    "<p class='mb-0'>Soñando</p>" +
                    "<br />" +
                    "<footer class='text-center'><img src='../img/perfil.jpg'' style='width: 150px ' height:'150px' class='rounded-circle'> </footer>" +
                    "</blockquote>" +
                  "<ul class='list-group'>" +
                    "<li class='list-group-item'>" +

                    "<p><em>'idea es generar un espacio abierto a la reflexión, discusión, el compartir y construir diversas estrategias y acciones para y desde las Ciencias Sociales. Donde logren converger actores estratégicos como son egresad@s, alumn@s, instituciones y la propia comunidad." +
                    "Nuestro sentido se plasma en entregar servicios digitales gratuitos, los cuales logren facilitar el constante perfeccionamiento e innovación socio-profesional, y desde allí soñar y construir en conjunto.'</em></p></li>" +
                  "</ul>" +
                  "<br />" +
                  "<br />" +
                  "<br />" +
                  "<br />" +

                "</div>" +

                 "</div>" +

             "</div>" +
             "</header>" +

                    "<!-- Footer -->" +
                    "<footer class='py-lg-5 py-5' id='MainFooter'>" +
                        "<div class='container'>" +
                            "<p class='m-0 text-center text-white'>Copyright &copy; Quality Essentials 2018</p>" +

                        "</div>" +
                        "<!-- /.container -->" +
                    "</footer>");

                            }
                        }
                        else
                        {
                            if (tema.Equals("ts"))
                            {
                                ControladorTesis ct = new ControladorTesis();
                                List<Tesis> alltesis = ct.ObtenerporTema(1);
                                if (alltesis.Count > 0)
                                {
                                    for (int i = 0; i < alltesis.Count; i++)
                                    {
                                        Usuario us = new Usuario();
                                        Usuario autor = us.buscaUnoID(alltesis[i].Idtesis.ToString());
                                        Response.Write("<tr>" +
                                      "<td><a href='tesis.aspx?idtesis=" + alltesis[i].Idtesis + "'><p>" + alltesis[i].Titulo + "</p></a></td>" +
                                      "<td><p>" + alltesis[i].Profesor_guia + "</p></td>" +
                                      "<td><p>" + alltesis[i].Autor + "</p></td>");
                                        if (log.Tipoperfil.Equals("Administrativo"))
                                        {
                                            Response.Write("<td><a href='../Controlador/cTesis.aspx?idtesis=" + alltesis[i].Idtesis + "&tema=" + tema + "'>Eliminar tesis</a></td>");
                                        }



                                        Response.Write("</tr>");
                                    }
                                    Response.Write(
                                      "</tbody>" +
                                    "</table>" +
                              "<hr class='w3-clear' />" +
                              "</div>" +
                               "<div class='col-lg-3 sidenav w3-card'>" +
                                    "<blockquote class='blockquote'>" +
                                "<p class='mb-0'>Soñando</p>" +
                                "<br />" +
                                "<footer class='text-center'><img src = '../img/perfil.jpg'' style='width: 150px ' height:'150px' class='rounded-circle'> </footer>" +
                                "</blockquote>" +
                              "<ul class='list-group'>" +
                                "<li class='list-group-item'>" +
                                "<p><em>'idea es generar un espacio abierto a la reflexión, discusión, el compartir y construir diversas estrategias y acciones para y desde las Ciencias Sociales. Donde logren converger actores estratégicos como son egresad@s, alumn@s, instituciones y la propia comunidad." +
                                "Nuestro sentido se plasma en entregar servicios digitales gratuitos, los cuales logren facilitar el constante perfeccionamiento e innovación socio-profesional, y desde allí soñar y construir en conjunto.'</em></p></li>" +
                              "</ul>" +
                              "<br />" +
                              "<br />" +
                              "<br />" +
                              "<br />" +
                            "</div> " +
                             "</div>     " +
                        "</div>" +
                        "</header>       " +
                                "<!-- Footer -->" +
                                "<footer class='py-lg-5 py-5' id='MainFooter'>" +
                                    "<div class='container'>" +
                                        "<p class='m-0 text-center text-white'>Copyright &copy; Quality Essentials 2018</p>" +
                                    "</div>" +
                                    "<!-- /.container -->" +
                                "</footer>");

                                }
                                else
                                {
                                    Response.Write("</tbody>" +
                                    "<tr>" +
                                    "<th><a href='#'><p>No hay tesis disponibles</p></a></th>" +
                                    "<th scope='col'></th>" +
                                    "<th scope='col'></th>" +
                                    "</tr>" +
                                "<tbody>" +
                            "</table>" +
                      "<hr class='w3-clear' />" +
                      "</div>" +
                       "<div class='col-lg-3 sidenav w3-card'>" +
                        "<blockquote class='blockquote'>" +
                        "<p class='mb-0'>Soñando</p>" +
                        "<br />" +
                        "<footer class='text-center'><img src='../img/perfil.jpg'' style='width: 150px ' height:'150px' class='rounded-circle'> </footer>" +
                        "</blockquote>" +
                      "<ul class='list-group'>" +
                        "<li class='list-group-item'>" +

                        "<p><em>'idea es generar un espacio abierto a la reflexión, discusión, el compartir y construir diversas estrategias y acciones para y desde las Ciencias Sociales. Donde logren converger actores estratégicos como son egresad@s, alumn@s, instituciones y la propia comunidad." +
                        "Nuestro sentido se plasma en entregar servicios digitales gratuitos, los cuales logren facilitar el constante perfeccionamiento e innovación socio-profesional, y desde allí soñar y construir en conjunto.'</em></p></li>" +
                      "</ul>" +
                      "<br />" +
                      "<br />" +
                      "<br />" +
                      "<br />" +

                    "</div>" +

                     "</div>" +

                 "</div>" +
                 "</header>" +

                        "<!-- Footer -->" +
                        "<footer class='py-lg-5 py-5' id='MainFooter'>" +
                            "<div class='container'>" +
                                "<p class='m-0 text-center text-white'>Copyright &copy; Quality Essentials 2018</p>" +

                            "</div>" +
                            "<!-- /.container -->" +
                        "</footer>");
                                }
                            }
                            else
                            {
                                ControladorTesis ct = new ControladorTesis();
                                List<Tesis> alltesis = ct.ObtenerporTema(3);
                                if (alltesis.Count > 0)
                                {
                                    for (int i = 0; i < alltesis.Count; i++)
                                    {
                                        Usuario us = new Usuario();
                                        Usuario autor = us.buscaUnoID(alltesis[i].Idtesis.ToString());
                                        Response.Write("<tr>" +
                                      "<td><a href='tesis.aspx?idtesis=" + alltesis[i].Idtesis + "'><p>" + alltesis[i].Titulo + "</p></a></td>" +
                                      "<td><p>" + alltesis[i].Profesor_guia + "</p></td>" +
                                      "<td><p>" + alltesis[i].Autor + "</p></td>");
                                        if (log.Tipoperfil.Equals("Administrativo"))
                                        {
                                            Response.Write("<td><a href='../Controlador/cTesis.aspx?idtesis=" + alltesis[i].Idtesis + "&tema=" + tema + "'>Eliminar tesis</a></td>");
                                        }



                                        Response.Write("</tr>");
                                    }
                                    Response.Write(
                                      "</tbody>" +
                                    "</table>" +
                              "<hr class='w3-clear' />" +
                              "</div>" +
                               "<div class='col-lg-3 sidenav w3-card'>" +
                                    "<blockquote class='blockquote'>" +
                                "<p class='mb-0'>Soñando</p>" +
                                "<br />" +
                                "<footer class='text-center'><img src = '../img/perfil.jpg'' style='width: 150px ' height:'150px' class='rounded-circle'> </footer>" +
                                "</blockquote>" +
                              "<ul class='list-group'>" +
                                "<li class='list-group-item'>" +
                                "<p><em>'idea es generar un espacio abierto a la reflexión, discusión, el compartir y construir diversas estrategias y acciones para y desde las Ciencias Sociales. Donde logren converger actores estratégicos como son egresad@s, alumn@s, instituciones y la propia comunidad." +
                                "Nuestro sentido se plasma en entregar servicios digitales gratuitos, los cuales logren facilitar el constante perfeccionamiento e innovación socio-profesional, y desde allí soñar y construir en conjunto.'</em></p></li>" +
                              "</ul>" +
                              "<br />" +
                              "<br />" +
                              "<br />" +
                              "<br />" +
                            "</div> " +
                             "</div>     " +
                        "</div>" +
                        "</header>       " +
                                "<!-- Footer -->" +
                                "<footer class='py-lg-5 py-5' id='MainFooter'>" +
                                    "<div class='container'>" +
                                        "<p class='m-0 text-center text-white'>Copyright &copy; Quality Essentials 2018</p>" +
                                    "</div>" +
                                    "<!-- /.container -->" +
                                "</footer>");
                                }
                                else
                                {
                                    Response.Write("</tbody>" +
                                   "<tr>" +
                                   "<th><a href='#'><p>No hay tesis disponibles</p></a></th>" +
                                   "<th scope='col'></th>" +
                                   "<th scope='col'></th>" +
                                   "</tr>" +
                               "<tbody>" +
                           "</table>" +
                     "<hr class='w3-clear' />" +
                     "</div>" +
                      "<div class='col-lg-3 sidenav w3-card'>" +
                       "<blockquote class='blockquote'>" +
                       "<p class='mb-0'>Soñando</p>" +
                       "<br />" +
                       "<footer class='text-center'><img src='../img/perfil.jpg'' style='width: 150px ' height:'150px' class='rounded-circle'> </footer>" +
                       "</blockquote>" +
                     "<ul class='list-group'>" +
                       "<li class='list-group-item'>" +

                       "<p><em>'idea es generar un espacio abierto a la reflexión, discusión, el compartir y construir diversas estrategias y acciones para y desde las Ciencias Sociales. Donde logren converger actores estratégicos como son egresad@s, alumn@s, instituciones y la propia comunidad." +
                       "Nuestro sentido se plasma en entregar servicios digitales gratuitos, los cuales logren facilitar el constante perfeccionamiento e innovación socio-profesional, y desde allí soñar y construir en conjunto.'</em></p></li>" +
                     "</ul>" +
                     "<br />" +
                     "<br />" +
                     "<br />" +
                     "<br />" +

                   "</div>" +

                    "</div>" +

                "</div>" +
                "</header>" +

                       "<!-- Footer -->" +
                       "<footer class='py-lg-5 py-5' id='MainFooter'>" +
                           "<div class='container'>" +
                               "<p class='m-0 text-center text-white'>Copyright &copy; Quality Essentials 2018</p>" +

                           "</div>" +
                           "<!-- /.container -->" +
                       "</footer>");
                                }
                            }

                        }
                     }
                    else
                    {
                        Response.Redirect("index.aspx");
                    }
                }
                else
                {
                    Response.Redirect("temaTesis.aspx");
                }
            }
            catch (NullReferenceException)
            {
             Response.Redirect("temaTesis.aspx");
            }
        }
    }
}