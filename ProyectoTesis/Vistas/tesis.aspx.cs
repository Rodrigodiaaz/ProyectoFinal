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
    public partial class tesis : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            string idtesis = Request.QueryString["idtesis"];
            ControladorTesis ct = new ControladorTesis();
            Tesis t = ct.ObtenerTesis(idtesis);
            if (t != null)
            {
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
               "<a class='navbar-brand js-scroll-trigger' href='#page-top'><img class='rounded img - fluid' width='105px' height='85px' src='../img/logo2.jpg'></a>" +
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
     "<ul class='list-group'>" +
       "<li class='list-group-item'><a href='home.aspx'>Perfil</a></li>" +
        "<li class='list-group-item'><a href='temaforo.aspx'>Foros</a></li>" +
        "<li class='list-group-item'><a href='subirTesis.aspx'>Subir Tesis</a></li>" +
        "<li class='list-group-item'><a href='menutesis.aspx'>Menu Tesis</a></li>" +
        "<li class='list-group-item'><a href='crearForo.aspx'>Crear Foro</a></li>" +
     "</ul>" +
     "<br />" +
     "<br />" +

   "</div>" +

   "<div class='col-lg-6 w3-card'>" +
     "<div class='text-center'><h2>Tesis</h2></div>" +
     "<br />" +
     "<div style='position: relative;width: 100%'>"+
      "<div style='width: 100%;background: #8B0000;height: 45px;position: absolute;'>" +
      "</div>" +
      "<iframe src='../pdf/" + t.Nombre_archivo + "' style='width: 100%;height: 670px;'></iframe>" +
       "<br /><br /><br /><br /><br /><br />" +
     "<hr class='w3-clear' />" +
       "</div>" +
     "</div>" +
      "<div class='col-lg-3 sidenav w3-card'>" +
      "<blockquote class='blockquote'>" +
       "<p class='mb-0'>Descripcion de tesis</p>" +
       "<br />" +
       "</blockquote>" +
    "<table class='table'>" +
             "<tbody>" +
               "<tr>" +
                 "<th scope='row'></th>" +

                 "<td><asp:Label ID='Label5' runat='server' Text='Autores'></asp:Label></td>" +
                 "<td><em> Autor:  &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; " + t.Autor + "</em></td>" +
               "</tr>" +

               "<tr>" +
                 "<th scope='row'></th>" +

                 "<td><asp:Label ID='Label6' runat='server' Text='Profesor Guia:'></asp:Label></td>" +
                 "<td><em> Profesor Guia:  &nbsp;&nbsp;&nbsp;&nbsp; " + t.Profesor_guia + "</em></td>" +
               "</tr>" +

               "<tr>" +
                 "<th scope='row'></th>" +

                 "<td><asp:Label ID='Label1' runat='server' Text='Descripcion'></asp:Label></td>" +
                 "<td><b><p> " + t.Descripcion + "</p></b></td>" +
               "</tr>" +


           "</tbody>" +
           "</table>" +
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
            else
            {
                Response.Redirect("menutesis.aspx");
            }
        }
    }
}