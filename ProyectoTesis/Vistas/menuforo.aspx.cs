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
    public partial class menuforo : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Response.Write("<html lang='en'>" +
  "<head>" +
   "<style type = 'text/css'></style>" +
    "<meta charset = 'utf-8'>" +
    "<meta name = 'viewport' content = 'width=device-width, initial-scale=1, shrink-to-fit=no'>" +
    "<meta name = 'description' content = ''>" +
    "<meta name = 'author' content = ''>" +
    "<title> RSTSP </title>" +
    "<link href = '/vendor/bootstrap/css/bootstrap.min.css' rel = 'stylesheet'>" +
    "<link href = '/css/scrolling-nav.css' rel = 'stylesheet'>" +
    "<link href = '../css/estilos.css' rel = 'stylesheet' />" +
    "<link rel = 'stylesheet' type = 'text/css' href = '../css/w3.css'>" +
    "<script src = 'https://ajax.googleapis.com/ajax/libs/jquery/3.3.1/jquery.min.js'></script>" +
    "<script src = 'https://maxcdn.bootstrapcdn.com/bootstrap/3.3.7/js/bootstrap.min.js'></script>" +
    "<style>" +
    ".sidenav {" +
                "background - color: #f1f1f1;" +
    "}" +
    "#mainNav{" +
            "background:  #8B0000;" +
    "}" +
    "#MainFooter{" +
        "background:  #8B0000;" +
    "}" +
  "</style>" +
"</head>" +
"<body id = 'page-top'>" +
     "<!--Navigation-->" +
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
            "</li>" +
          "</ul>" +
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
        "<footer class=''> <img class='rounded img-fluid' width='50px' height='50px' src='../img/menu.jpg'>Opciones Foro</footer>" +
        "</blockquote>" +
      "<ul class='list-group'>" +
        "<li class='list-group-item'><a href = 'home.aspx'> Mis Discusiones</a></li>" +
        "<li class='list-group-item'><a href = 'MenuTesis.aspx'> Crear Discusion</a></li>" +
      "</ul>" +
      "<br />" +
      "<br />" +
      "<br />" +
      "<blockquote class='blockquote'>" +
      "<footer class=''>Otras Opciones</footer>" +
      "</blockquote>" +
      "<ul class='list-group'>" +
        "<li class='list-group-item'><a href = 'home.aspx'> Perfil </a></li>" +
        "<li class='list-group-item'><a href = 'MenuTesis.aspx'> Menu Tesis</a></li>" +
        "<li class='list-group-item'><a href = 'MenuTesis.aspx'> Video Conferencia</a></li>" +
      "</ul>" +
     "<br />" +
     "<br />" +
    "</div>" +
    "<div class='col-lg-6 w3-card'>" +
      "<div class='text-center'><h2>Menu listado de Foros</h2></div>" +
      "<h5 class='EmblemaP2'>&nbsp;&nbsp;&nbsp;&nbsp;</h5>" +
      "<br />" +
       "<table class='table'>" +
              "<thead class='thead-dark'>" +
                  "<tr>" +
                    "<th scope = 'col'> Nombre </th>" +
                    "<th scope='col'>Autor</th>" +
                    "<th scope = 'col'> Fecha </th>" +
                    "</tr>" +
                "</thead>"+
                "<tbody>");
            ControladorTopic ct = new ControladorTopic();
            List<Topic> allTopics = ct.ObetenerTodosTopics();
            if (allTopics.Count > 0)
            {
                for (int i = 0; i < allTopics.Count; i++)
                {
                    Usuario us = new Usuario();
                    Usuario autorTopic = us.buscaUnoID(allTopics[i].Id_usuario.ToString());
                    Response.Write("<tr>" +
                  "<td><a href='foro.aspx?idtopic="+allTopics[i].Id_topic+"'><p>" + allTopics[i].Titulo+"</p></a></td>" +
                  "<td><p>"+autorTopic.Nombre+"</p></td>" +
                  "<td><p>"+allTopics[i].Fecha+"</p></td>" +
                "</tr>" );
                }
                Response.Write("</tbody>" +
            "</table>"+
            "<hr class='w3-clear' />" +
      "</div>" +
       "<div class='col-lg-3 sidenav w3-card'>" +
            "<blockquote class='blockquote'>" +
        "<p class='mb-0'>Soñando</p>" +
        "<br />" +
        "<footer class='text-center'><img src = '../img/feñita.jpg'' style='width: 150px ' height:'150px' class='rounded-circle'> </footer>" +
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
                Response.Write("<tbody>" +
                "<tr>" +
                  "<td><a href='#'><p>No hay topics disponibles</p></a></td>" +
                  "<td><p>-</p></td>" +
                  "<td><p>-</p></td>" +
                "</tr>" +
              "</tbody>" +
            "</table>" +
      "<hr class='w3-clear' />" +
      "</div>" +
       "<div class='col-lg-3 sidenav w3-card'>" +
            "<blockquote class='blockquote'>" +
        "<p class='mb-0'>Soñando</p>" +
        "<br />" +
        "<footer class='text-center'><img src = '../img/feñita.jpg'' style='width: 150px ' height:'150px' class='rounded-circle'> </footer>" +
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

                
                
        }
    }
}