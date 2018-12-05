﻿251<%@ Page Language='C#' AutoEventWireup='true' CodeBehind='home.aspx.cs' Inherits='ProyectoTesis.Vistas.home1' %>
<%@ Import Namespace="ProyectoTesis.Modelos" %>
<%@ Import Namespace="ProyectoTesis.Controlador" %>

<!DOCTYPE html>
<html lang='en'>
<head>

    <meta charset='utf-8'>
    <meta name='viewport' content='width=device-width, initial-scale=1, shrink-to-fit=no'>
    <meta name='description' content=''>
    <meta name='author' content=''>

    <title>RSTSP</title>
    <link href='/vendor/bootstrap/css/bootstrap.min.css' rel='stylesheet'>
    <link href='/css/scrolling-nav.css' rel='stylesheet'>
    <link href='/css/estilos.css' rel='stylesheet' />
    <link rel='stylesheet' type='text/css' href='../css/w3.css'>


</head>

<body id='page-top'>
    <form runat='server'>
  

        <!-- Navigation -->
        <nav class='navbar navbar-expand-lg navbar-dark bg-dark fixed-top' id='mainNav'>
            <div class='container'>
                <a class='navbar-brand js-scroll-trigger' href='#page-top'>Quality Essentials</a>
                <button class='navbar-toggler' type='button' data-toggle='collapse' data-target='#navbarResponsive' aria-controls='navbarResponsive' aria-expanded='false' aria-label='Toggle navigation'>

                    <span class='navbar-toggler-icon'></span>
                </button>


                <div class='collapse navbar-collapse' id='navbarResponsive'>


                    <input class='form-control ml-5 lg-5 mr-5 lg-5 mt-lg-3 mb-lg-3' type='search' placeholder='Busqueda' aria-label='Search'>


                    <ul class='navbar-nav ml-auto'>

                        <li class='nav-item'>
                            <a class='nav-link js-scroll-trigger text-white' href='MenuForo.aspx'>Foros</a>
                        </li>


                        <li class='nav-item'>
                            <a class='nav-link js-scroll-trigger text-white' href='MenuTesis.aspx'>Tesis</a>
                        </li>


                        <li class='nav-item'>
                            <a class='nav-link js-scroll-trigger text-white' href='MenuVideo.aspx'>Videos</a>

                        </li>


                    </ul>
                </div>
            </div>
        </nav>


        <!-- Centro Pagina -->
        <section >
            <div class='container GG' >
                <div class='row'>


                    <!-- Perfil -->
                    <div class='col-lg-3 mx-auto jumbotron'>
                        <h5>Perfil</h5>
                        <br />
                        <div class='TarjetaP '>
                            <img src='../media/images.png' alt='Pablo' style='width: 100%' class='rounded-top'>
                            <br />
                            <br />
                            <p><%
                                    Usuario u = (Usuario)Session["logeado"];
                                   Response.Write(u.Nombre);
                                   
                                   %></p>

                            <p class='title'>Ingenieria en informatica. </p>
                            <p>Inacap Maipu</p>
                            <p>
                                <input id='Button2' type='button' value='Modificar Perfil' class='ButtonMP' />
                                <br />
                           </p>
                                <button id='Notificacion' type='button' value='Comentar' class='ButtonMP' data-toggle='collapse' href='#Notify' role='button' aria-expanded='false' aria-controls='Notify' >Notificaciones<span class='badge'>10</span></button>
                                     
                                    <div class='collapse' id='Notify'>
                                      <div class='card card-body'>
                                        <a href='MenuTesis.aspx'>Nueva tesis</a>
                                      </div>
                                    </div>

                        </div>
                    </div>
                   
                    <!-- Menu -->
                    <div class='col-lg-7 mx-auto w3-card w3-round w3-white'>


                        <div>
                            <div class='EmblemaP'><h1 >Publicaciones</h1></div>
                            <h5 class='EmblemaP2'>Bienvenido <asp:Label ID="lblNombre" runat="server" Text="Label"></asp:Label></h5>
                            <br />
                            <br />
                            
                            <div>
                                <div class=''>
                                    <div>
                                        <div>
                                            <div class='textomen w3-padding-large'>
                                                <asp:Label ID="lblMensaje" runat="server" Text=""></asp:Label> <br />
                                            <input id='txtContenidoPublicacion' type='text' placeholder='Que vas a publicar Hoy!' runat="server" class='TextoMenu' />
                                                    <br />
                                                <asp:Label ID="lblInforArchivo" runat="server" Text=""></asp:Label>
                                                    <br />
                                            </div>
                                            <input id='btnPublicar' type='button' value='Publicar' runat="server" onserverclick="PublicarActualizacion" class='ButtonMP' />
                                            <input id='Archivo' runat="server" type='file' onserverclick="subirarchivo" name='image_post'/>
                                           
                                                    <br />
                                                    <br />
                                                    <br />
                                        </div>
                                    </div>
                                </div>
                            </div>
                        </div>

                        <!-- Comentarios -->
                        <div class="mx-auto w3-card w3-round " id='contenedorcomentarios' >
                            <div class='EmblemaP'><h1 >Comentarios</h1></div>
                            <br />
                            <br />
                            <br />
                            <!-- de aca -->
                            <%
                                Publicacion p = new Publicacion();
                                List<Publicacion> listaPublicaciones = p.buscaMuro(u.Id.ToString());
                                ControladorComentario cm = new ControladorComentario();

                                if (listaPublicaciones.Count > 0)
                                {
                                    for (int i = 0; i < listaPublicaciones.Count; i++)
                                    {
                                        Publicacion Publicaciones = listaPublicaciones[i];
                                        if (Publicaciones.IdEmisor.Equals(Publicaciones.IdReceptor))
                                        {
                                            Response.Write("<div id='comentario' class='w3-padding-large'>");
                                            Response.Write("<span class='w3-right w3-opacity'>" + Publicaciones.Fecha + "</span>");
                                            Response.Write("<h4>" + u.Nombre + "</h4>");
                                            Response.Write("<hr class='w3-clear'>");
                                            Response.Write("<p>" + Publicaciones.Texto + "</p>");
                                            Response.Write("<button type='button' class='ButtonMP'>Me gusta</button>");
                                            if (i == 0)
                                            {
                                                Response.Write("<input id='Comentar1' type='button' value='Comentar' runat='server' class='ButtonMP' data-toggle='collapse' href='#ComentarP" + i + "' role='button' aria-expanded='false' aria-controls='ComentarP' onclick='ComentarPublicacion' />");
                                                Response.Write("<div class='collapse alert-warning' id='ComentarP" + i + "'>");
                                                Response.Write("<div class='card card-body'>");
                                                List<Comentario> listaComentariosPorPublicacion = cm.listaComentarios(Publicaciones.Idpublicacion);
                                                if (listaComentariosPorPublicacion.Count > 0)
                                                {
                                                    for (int j = 0; j < listaComentariosPorPublicacion.Count; j++)
                                                    {
                                                        Usuario u2 = new Usuario();
                                                        u2 = u2.buscaUnoID(listaComentariosPorPublicacion[j].Idemisor.ToString());

                                                        Response.Write("<p>Comentario de " + u2.Nombre + "</p>");
                                                        Response.Write("<span class='w3-right w3-opacity'>" + listaComentariosPorPublicacion[j].Fecha + "</span>");
                                                        Response.Write("<span><span></span><span>" + listaComentariosPorPublicacion[j].Texto + "</span></span>");
                                                        Response.Write("<br />");
                                                        Response.Write("<br />");
                                                        //Response.Write("<input id='Responder1' type='button' value='Responder' class='ButtonMP' data-toggle='collapse' href='#ResponderC" + j + "' role='button' aria-expanded='false' aria-controls='ResponderC' runat='server' onserverclick='comentarActualizacion'/>");
                                                        Response.Write("<hr class='w3-clear'>");
                                                        Response.Write("<div class='collapse alert-info' id='ResponderC" + j + "'><p>Respuesta</p>");
                                                        Response.Write("<div class='card card-body '>");
                                                        Response.Write("<span class='w3-right w3-opacity'>8 min</span>");
                                                        Response.Write("<span>Pablo Reyes <span>:</span><span>Lorem ipsum dolor sit amet, consectetur adipisicing elit, sed do eiusmod tempor exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat.</span></span>");
                                                        Response.Write("<hr class='w3-clear'>");
                                                        Response.Write("<input id='TextoRes1' type='text'' />&nbsp;<input id='BotonRes1' type='button' value='Publicar' class='ButtonMP' />");
                                                        Response.Write("<hr class='w3-clear'>");
                                                        Response.Write("</div>");
                                                        Response.Write("</div>");

                                                    }
                                                }
                                                else
                                                {

                                                    Response.Write("<p>No hay comentarios en la publicacion</p>");

                                                }
                                            }
                                            else
                                            {
                                                Response.Write("<input id='Comentar1' type='button' value='Comentar' runat='server' class='ButtonMP' data-toggle='collapse' href='#ComentarP" + i + "' role='button' aria-expanded='false' aria-controls='ComentarP' onclick='ComentarPublicacion' />");
                                                Response.Write("<div class='collapse alert-warning' id='ComentarP" + i + "'>");
                                                Response.Write("<div class='card card-body'>");
                                                List<Comentario> listaComentariosPorPublicacion = cm.listaComentarios(Publicaciones.Idpublicacion);
                                                if (listaComentariosPorPublicacion.Count > 0)
                                                {
                                                    for (int j = 0; j < listaComentariosPorPublicacion.Count; j++)
                                                    {
                                                        Usuario u2 = new Usuario();
                                                        u2 = u2.buscaUnoID(listaComentariosPorPublicacion[j].Idemisor.ToString());
                                                        Response.Write("<p>Comentario de " + u2.Nombre + "</p>");
                                                        Response.Write("<span class='w3-right w3-opacity'>" + listaComentariosPorPublicacion[j].Fecha + "</span>");
                                                        Response.Write("<span><span></span><span>" + listaComentariosPorPublicacion[j].Texto + "</span></span>");
                                                        Response.Write("<br />");
                                                        Response.Write("<br />");
                                                        //Response.Write("<input id='Responder1' type='button' value='Responder' class='ButtonMP' data-toggle='collapse' href='#ResponderC" + j + "' role='button' aria-expanded='false' aria-controls='ResponderC' runat='server' onserverclick='comentarActualizacion'/>");
                                                        Response.Write("<hr class='w3-clear'>");
                                                        Response.Write("<div class='collapse alert-info' id='ResponderC" + j + "'><p>Respuesta</p>");
                                                        Response.Write("<div class='card card-body '>");
                                                        Response.Write("<span class='w3-right w3-opacity'>8 min</span>");
                                                        Response.Write("<span>Pablo Reyes <span>:</span><span>Lorem ipsum dolor sit amet, consectetur adipisicing elit, sed do eiusmod tempor exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat.</span></span>");
                                                        Response.Write("<hr class='w3-clear'>");
                                                        Response.Write("<input id='TextoRes1' type='text'' />&nbsp;<input id='BotonRes1' type='button' value='Publicar' class='ButtonMP' />");
                                                        Response.Write("<hr class='w3-clear'>");
                                                        Response.Write("</div>");
                                                        Response.Write("</div>");
                                                    }
                                                }
                                                else
                                                {
                                                    Response.Write("<p>No hay comentarios en la publicacion</p>" + listaComentariosPorPublicacion.Count);
                                                }
                                            }
                %><input id='txtTextoComentario<% Response.Write(i); %>' type='text' />&nbsp <input type="button" value="responder" onclick="enviaComentario(<%Response.Write(listaPublicaciones[i].Idpublicacion + ", " + i + ", " + u.Id);%>)" class="ButtonMP" /> 
                <%
                                Response.Write("</div>");
                                Response.Write("</div>");
                                Response.Write("</div>");
                            }
                        }
                    }
                    else
                    {
                        Response.Write("<p>No hay actualizaciones. </p>" + listaPublicaciones.Count);
                    }






                                %>
                                
                            <!-- hasta aca -->
                                  
                        

                    </div>

                    
            </div>       
                    
                </div>
            </div>
        </section>




        <!-- Footer -->
        <footer class='py-5 bg-dark'>
            <div class='container'>
                <p class='m-0 text-center text-white'>Copyright &copy; Quality Essentials 2018</p>

            </div>
            <!-- /.container -->
        </footer>

        

    

</form>
    

</body>
 <!-- Bootstrap core JavaScript -->
    <script src='/Scripts/jQuery.min.js'></script>
    <script src='/vendor/jquery/jquery.min.js'></script>
    <script src='/vendor/bootstrap/js/bootstrap.bundle.min.js'></script>

    <!-- Plugin JavaScript -->
    <script src='/vendor/jquery-easing/jquery.easing.min.js'></script>

    
    
    <!-- Custom JavaScript for this theme -->
    <script src='/Scripts/scrolling-nav.js'></script>
    <script type="text/javascript">
        function enviaComentario(idpost, idtxtbox, idusuario) {
            document.location.assign("../Controlador/cComentario.aspx?idpost=" + idpost + "&texto=" + document.getElementById('txtTextoComentario' + idtxtbox).value + "&idusuario=" + idusuario);
           

        }

    </script>
     
</html>

