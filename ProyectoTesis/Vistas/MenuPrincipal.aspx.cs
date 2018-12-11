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
    public partial class MenuPrincipal : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["logeado"] != null)
            {
                Response.Write("<!DOCTYPE html>" +
"<html lang='en'>" +
"<head>" +
    "<meta charset='utf-8'>" +
    "<meta name='viewport' content='width=device-width, initial-scale=1, shrink-to-fit=no'>" +
    "<meta name='description' content=''>" +
    "<meta name='author' content=''>" +
    "<link href='/vendor/bootstrap/css/bootstrap.min.css' rel='stylesheet'>" +
    "<link href='/css/scrolling-nav.css' rel='stylesheet'>" +
    "<link href='../css/estilos.css' rel='stylesheet' />" +
    "<link rel='stylesheet' type='text/css' href='../css/w3.css'>" +
    "<script src='https://ajax.googleapis.com/ajax/libs/jquery/3.3.1/jquery.min.js'></script>" +
    "<script src='https://maxcdn.bootstrapcdn.com/bootstrap/3.3.7/js/bootstrap.min.js'></script>" +
    "<style>" +
    ".sidenav {" +
            "}" +
"#mainNav{" +
            "background:  #8B0000;" +
    "}" +
"#MainFooter{" +
        "background:  #8B0000;" +
    "}" +
  "</style>" +
"</head>" +
"<body id='page-top'> " +
                "<nav class='navbar navbar-expand-lg fixed-top' id='mainNav'>" +
            "<div class='container'>" +
                "<a class='navbar-brand js-scroll-trigger' href='#page-top'>Quality Essentials</a>" +
                "<button class='navbar-toggler' type='button' data-toggle='collapse' data-target='#navbarResponsive' aria-controls='navbarResponsive' aria-expanded='false' aria-label='Toggle navigation'>" +
                    "<span class='navbar-toggler-icon'></span>" +
                "</button>" +
                "<div class='collapse navbar-collapse' id='navbarResponsive'>" +
                    "<input class='form-control ml-5 lg-5 mr-5 lg-5 mt-lg-3 mb-lg-3' type='search' placeholder='Busqueda' aria-label='Search'>" +
          "<ul class='navbar-nav ml-auto'>" +
            "<li class='nav-item'>" +
              "<a class='nav-link js-scroll-trigger text-white' href='index.aspx'>Desconectar</a>" +
            "</li> " +
          "</ul>" +
        "</div>" +
      "</div> " +
        "</nav> " +
    "<header> " +
    "<div class='container-fluid'>" +
    "<div class='row content'>" +
    "<div class='col-lg-2 sidenav w3-card'>" +
      "<blockquote class='blockquote'>" +
        "<p class='mb-0'>Administrador</p>" +
        "<footer class='blockquote-footer'>Menu Principal<cite title='Source Title'></cite></footer>" +
        "</blockquote>" +
      "<ul class='list-group'>" +
        "<li class='list-group-item'><a href =''> Subir Tesis</a></li>" +
        "<li class='list-group-item'><a href ='ModificarUsu.aspx'> Modificar Usuario</a></li>" +
        "<li class='list-group-item'><a href ='Menu'> Crear video Conferencia</a></li>" +
        "<li class='list-group-item'><a href ='#section3'> Modificar Tesis</a></li>" +
      "</ul>" +
      "<br>" +
    "</div>" +
    "<div class='col-lg-9 w3-card'>" +
      "<h4><Strong>Publicaciones Recientes</Strong></h4>" +
      "<h5 class='EmblemaP2'>&nbsp;&nbsp;&nbsp;&nbsp;</h5>" +
      "<hr>");
                ControladorPublicacion cp = new ControladorPublicacion();
                List<Publicacion> listapublicaciones = cp.ObtenerTodasPublicaciones();
                for (int i = 0; i < 5; i++)
                {
                    Usuario logeado = (Usuario)Session["logeado"];
                    Usuario us = new Usuario();
                    Usuario u = us.buscaUnoID(listapublicaciones[i].IdEmisor);
                    ControladorComentario cm = new ControladorComentario();
                    List<Comentario> listacomentariosxpublicacion = cm.listaComentarios(listapublicaciones[i].Idpublicacion);
                    Response.Write("<span class='w3-right w3-opacity'>" + listapublicaciones[i].Fecha + "</span>" +
                                    "<h4><strong>" + u.Nombre +" " + u.Cargo +"</strong></h4>" +
                                    "<p>" + listapublicaciones[i].Texto + "</p>" +
                                    "<br><br>" +
                                    "<div><h3 data-toggle='collapse' href='#ComentarP" + i + "' role='button' aria-expanded='false' aria-controls='ComentarP" + i + "'><Strong> Comentar </Strong></h3></div>" +
                                    "<br />" +
                                    "<!--Comentario Principal -->" +
                                    "<div class='mx-auto w3-card w3-round  collapse alert-secondary' id='ComentarP" + i + "'>");
                    for (int j = 0; j < listacomentariosxpublicacion.Count; j++)
                    {
                        Usuario ucomentario = us.buscaUnoID(listacomentariosxpublicacion[j].Idemisor.ToString());
                        Response.Write("<div class='w3-padding-large alert'><h4><strong>" + ucomentario.Nombre + " Comentó</strong></h4>" +
                                    "<span class='w3-right w3-opacity'>" + listacomentariosxpublicacion[j].Fecha + "</span>" +
                                    "<br />" +
                                    "<span>" + listacomentariosxpublicacion[j].Texto + "</span>" +
                                    "<br />" +
                                    "<hr class='w3-clear'>" +
                                    "</div>");

                    }

                    Response.Write("<form role ='form'>" +
                    "<div class='form-group'>" +
                    "<textarea id='txtTextoComentario" + i + "' class='form-control' rows='3' required></textarea>" +
                    "</div>" /* se cierra div form-control*/ +
                    "&nbsp;<input type='button' value='responder' onclick='enviaComentario(" + listapublicaciones[i].Idpublicacion + ", " + i + ", " + logeado.Id + ", 1)' class='btn btn-dark col-lg-2' />" +
                    "</form>" +
                    "</div>" +
                    "<hr>"
                    );
                }



                Response.Write("</div>" +
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
            else
            {
                Session["mensaje"] = "No tiene permisos para entrar aqui.";
                Response.Redirect("index.aspx");
            }
            


           
        }
    }
}