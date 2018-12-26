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
    public partial class Foro1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Usuario u = (Usuario)Session["logeado"];
            string idtopic = Request.QueryString["idtopic"];
            Response.Write("<!DOCTYPE html>" +
"<html lang='en'>" +
"<head>" +

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
       "<nav class='navbar navbar-expand-lg fixed-top' id='mainNav'>" +
           "<div class='container'>" +
               "<a class='navbar-brand js-scroll-trigger' href='#page-top'><img class='rounded img - fluid' width='105px' height='85px' src='../ img / logo2.jpg'></a>" +
               "<button class='navbar-toggler' type='button' data-toggle='collapse' data-target='#navbarResponsive' aria-controls='navbarResponsive' aria-expanded='false' aria-label='Toggle navigation'>" +

                   "<span class='navbar-toggler-icon'></span>" +
               "</button>" +


               "<div class='collapse navbar-collapse' id='navbarResponsive'>" +
                   "<input class='form-control ml-5 lg-5 mr-5 lg-5 mt-lg-3 mb-lg-3' type='search' placeholder='Busqueda' aria-label='Search'>" +
         "<ul class='navbar-nav ml-auto'>" +

           "<li class='nav-item'>" +
             "<a class='nav-link js-scroll-trigger text-white' href='cerrarsesion.aspx'>Desconectar</a>" +
           "</li>" +

         "</ul>" +

       "</div>" +
     "</div>" +
       "</nav>" +
"<header>" +
"<div class='container-fluid'>" +
 "<div class='row content'>" +
   "<div class='col-lg-2 sidenav w3-card'>" +
     "<blockquote class='blockquote'>" +
       "<p class='mb-0'>Administrador o Usuario</p>" +
       "<br />" +
       "<footer class=''> <img class='rounded img-fluid' width='50px' height='50px' src='../img/menu.jpg'>Menu Foro </footer>" +
       "</blockquote>" +
     "<ul class='list-group'>" +
       "<li class='list-group-item'><a href='menuforo.aspx'>Volver a Menu</a></li>" +
       "<li class='list-group-item'><a href=''>Crear Foro</a></li>" +
     "</ul>" +
     "<br />" +
     "<blockquote class='blockquote'>" +
       "<p class='mb-0'>Otras opciones</p>" +
       "</blockquote>" +
     "<ul class='list-group'>" +
       "<li class='list-group-item'><a href='home.aspx'>Perfil</a></li>" +
       "<li class='list-group-item'><a href='MenuTesis.aspx'>Menu Tesis</a></li>" +
       "<li class='list-group-item'><a href=''>Menu Conferencia</a></li>" +
     "</ul>" +
     "<br>" +
   "</div>" +

   "<div class='col-lg-9 w3-card'>" +
     "<div class='text-center'><h2>Foros</h2></div>" +
     "<h5 class='EmblemaP2'>&nbsp;&nbsp;&nbsp;&nbsp;</h5>" +
     "<br />");

            ControladorTopic ct = new ControladorTopic();
            Topic t = ct.ObtenerTopic(idtopic);
            if (t == null)
            {
                Response.Redirect("menuforo.aspx");
            }
            else
            {
                Usuario us = new Usuario();
                Usuario autorTopic = us.buscaUnoID(t.Id_usuario.ToString());
                Response.Write("<div class='w3-card w3-padding'>" +
     "<h4><img class='rounded img-fluid' width='50px' height='50px' src='../img/topic.jpg'>Topic Principal </h4>" +
     "<span class='w3-right w3-opacity'>"+t.Fecha+"</span>" +
     "<h4>"+autorTopic.Nombre+"</h4>" +
     "<p>"+t.Texto+"</p>" +
     "<br><br>" +
     "<br />" +
     "</div>");
            }



            Response.Write("<!-- Comentario Principal -->");
            ControladorReplica cr = new ControladorReplica();
            List<Post> listareplicaxtopic = cr.ObtenerPostxTopic(idtopic);
            if (listareplicaxtopic.Count > 0)
            {
                for (int i = 0; i < listareplicaxtopic.Count; i++)
                {
                    Usuario us = new Usuario();
                    Usuario autorReplica = us.buscaUnoID(listareplicaxtopic[i].Idusuario.ToString());
                    Response.Write("<div class='mx-auto w3-card w3-round alert-secondary' id='ComentarP'>" +
                                   "<div class='w3-padding-large alert'>" +
                                   "<h4><img class='rounded img-fluid' width='50px' height='50px' src='../img/descarga6.jpg'><small>Post Recientes</small></h4>" +
                                   "<span class='w3-right w3-opacity'>" + listareplicaxtopic[i].Fecha + "</span>" +
                                   "<h4>" + autorReplica.Nombre + "</h4>" +
                                   "<br/>"+
                                   "<p>" + listareplicaxtopic[i].Texto + "</p>" +
                                   "<br>" +
                                   "<br />" +
                                   "<hr class='w3-clear'>" +
                                   "</div>");
                }
                
            }
            else
            {
                Response.Write("<div class='mx-auto w3-card w3-round alert-secondary' id='ComentarP'>" +
         "<div class='w3-padding-large alert'>" +
         "<h4><img class='rounded img-fluid' width='50px' height='50px' src='../img/descarga6.jpg'><small>Post Recientes</small></h4>" +
         "<span class='w3-right w3-opacity'></span>" +
         "<h4>No hay replicas para esta discusion!.</h4>" +
         "<br>" +
         "<br />" +
         "<hr class='w3-clear'>" +
          "</div>");
            }
          Response.Write("<div class='w3-padding-large alert'>" +
         "<form role='form'>" +
               "<div class='form-group'>"+
                 "<textarea id='replica' class='form-control' rows='3' required></textarea>"+
               "</div>"+
                
                 "&nbsp;<input id='Comentar1' type='button' value='Publicar' onclick='ReplicaComentario("+idtopic+", "+u.Id+")' class='btn btn-dark col-lg-2' />"+
             "</form>"+
             "</div>" +




 "</div>" +
"</div>"+
"</div>"+
"</div>"+
"</header>"+
        
       "<!-- Footer -->"+
       "<footer class='py-lg-5 py-5' id='MainFooter'>"+
           "<div class='container'>"+
               "<p class='m-0 text-center text-white'>Copyright &copy; Quality Essentials 2018</p>"+

           "</div>"+
           "<!-- /.container -->"+
       "</footer>");
        }
    }
}