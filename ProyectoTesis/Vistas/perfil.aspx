<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="perfil.aspx.cs" Inherits="ProyectoTesis.Vistas.perfil" %>
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
     <script src="https://ajax.googleapis.com/ajax/libs/jquery/3.3.1/jquery.min.js"></script>
    <script src="https://maxcdn.bootstrapcdn.com/bootstrap/3.3.7/js/bootstrap.min.js"></script>
    <style>
    .sidenav {
        background-color: #f1f1f1;
    }
    #mainNav{
      background:  #8B0000;
    }
    #MainFooter{
        background:  #8B0000;
    }
    </style>

</head>

<body id='page-top'>
    <form runat='server'>
  

        <!-- Navigation -->
        <nav class='navbar navbar-expand-lg fixed-top' id='mainNav'>
            <div class='container'>
                <a class='navbar-brand js-scroll-trigger' href='#page-top'><img class='rounded img - fluid' width="105px" height="85px" src="../img/logo2.jpg"></a>
                <button class='navbar-toggler' type='button' data-toggle='collapse' data-target='#navbarResponsive' aria-controls='navbarResponsive' aria-expanded='false' aria-label='Toggle navigation'>

                    <span class='navbar-toggler-icon'></span>
                </button>


                <div class="collapse navbar-collapse" id="navbarResponsive">
                    <input class='form-control ml-5 lg-5 mr-5 lg-5 mt-lg-3 mb-lg-3' type='search' placeholder='Busqueda' aria-label='Search'>
          <ul class="navbar-nav ml-auto">
             
            <li class="nav-item">
              <a class="nav-link js-scroll-trigger text-white" href="index.aspx">Desconectar</a>
            </li>

          </ul>
        
        </div>
      </div>
        </nav>

<header>
 <div class="container-fluid">
  <div class="row content">
    <div class="col-lg-3 sidenav w3-card">
      <blockquote class="blockquote">
        <p class="mb-0">Perfil de Usuario</p>
        <br />
        <footer class=""> <img class="rounded img-fluid" width="50px" height="50px" src="../img/menu.jpg">Menu Usuario </footer>
        </blockquote>
      <ul class="list-group">
        <li class="list-group-item"><img src='../media/images.png' alt='Pablo' style='width: 100px' height:'100px'  class='rounded-top'><br />
                            <br />
                            <p><%
                                   Usuario log = (Usuario)Session["logeado"];

                                   string id = Request.QueryString["id"];
                                   Usuario us = new Usuario();
                                   Usuario u = null;
                                   u = us.buscaUnoID(id);
                                   Response.Write(u.Nombre);

                                   %></p></li>
        <li class="list-group-item"><p>Ingenieria en informatica.</p></li>
        <li class="list-group-item"><p>Inacap Maipu</p></li>
        <li class="list-group-item"></li>
      </ul>
      <br />
      <blockquote class="blockquote">
        <p class="mb-0">Otras opciones</p>
        </blockquote>
      <ul class="list-group">
        <li class='list-group-item'><a href='home.aspx'>Perfil</a></li>
        <li class='list-group-item'><a href='temaforo.aspx'>Foros</a></li>
        <li class='list-group-item'><a href='videoconferencia.aspx'>Video Conferencia</a></li>
        <li class='list-group-item'><a href='subirTesis.aspx'>Subir Tesis</a></li>
        <li class='list-group-item'><a href='menutesis.aspx'>Menu Tesis</a></li>
        <li class='list-group-item'><a href='crearForo.aspx'>Crear Foro</a></li>
        <li class='list-group-item'><a href='modificarusu.aspx'>Modificar Usuario</a></li>
      </ul>
      <br>

    <br />

      <blockquote class="blockquote">
        <p class="mb-0">Listado</p>
        </blockquote>
      <ul class="list-group">
        <li class="list-group-item"><p data-toggle="collapse" href="#Notify" role="button" aria-expanded="false" aria-controls="Notify" ><img class="rounded img-fluid" width="30px" height="30px" src="../img/notificacion.jpg">Notificaciones</p> 
                                    <div class='collapse' id='Notify'>
                                      <div class='card card-body'>
                                        <a href='MenuTesis.aspx'>Nueva tesis</a>
                                      </div>
                                        </div>
                                        </li>
        
      </ul>
      <br>
    </div>
      
      

    <div class="col-lg-9 w3-card">
      <div class="text-center"><h2>Publicaciones</h2></div>
      <h5 class="EmblemaP2">&nbsp;&nbsp;&nbsp;&nbsp;</h5>
      <br />
      
      <div class="w3-card w3-padding">
      <h4><img class="rounded img-fluid" width="50px" height="50px" src="../img/welcome.jpg">Perfil de : <asp:Label ID="lblNombre" runat="server" Text="Label"></asp:Label> </h4>
      <span class="w3-right w3-opacity"></span>
      
      <h4>Comentarios</h4>
       <textarea id="txtPublicacion" class="form-control"  runat="server" rows="3" placeholder="Comentale algo a tu compañero!" required ></textarea>
      <br />
          <asp:Label ID="lblMensaje" runat="server" Text=""></asp:Label>
      <br />
      <input id='btnPublicar' type='button' value='Publicar' runat="server"  onserverclick="PublicarActualizacion" class='btn btn-dark col-lg-1' />
      <input id='Archivo' class="btn col-lg-8 col-md-8 col-sm-8" runat="server" type='file' onserverclick="subirarchivo" name='image_post'/>
      <br />
      <br />
      </div>  
         
        <!-- Comentario Principal -->
          <div class="mx-auto w3-card w3-round alert-secondary" id="id='contenedorcomentarios' ">
          <div class="w3-padding-large alert">
          <h4><img class="rounded img-fluid" width="50px" height="50px" src="../img/Comentario.jpg"><small>Comentarios Recientes</small></h4>
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
                                            //Response.Write("<button type='button' class='btn btn-dark col-lg-2'>Me gusta</button>");
                                            if (i == 0)
                                            {
                                                Response.Write("<input id='Comentar1' type='button' value='Comentar' runat='server' class='btn btn-dark col-lg-2' data-toggle='collapse' href='#ComentarP" + i + "' role='button' aria-expanded='false' aria-controls='ComentarP' onclick='ComentarPublicacion' />");
                                                Response.Write("<div class='collapse alert-warning' id='ComentarP" + i + "'>");
                                                Response.Write("<div class='card card-body'>");
                                                List<Comentario> listaComentariosPorPublicacion = cm.listaComentarios(Publicaciones.Idpublicacion);
                                                if (listaComentariosPorPublicacion.Count > 0)
                                                {
                                                    for (int j = 0; j < listaComentariosPorPublicacion.Count; j++)
                                                    {
                                                        Usuario u2 = new Usuario();
                                                        u2 = u2.buscaUnoID(listaComentariosPorPublicacion[j].Idemisor.ToString());

                                                        Response.Write("<h4><img class='rounded img-fluid' width='50px' height='50px' src='../img/Comentario.jpg'><small>" + "</small></h4>");
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
                                                Response.Write("<input id='Comentar1' type='button' value='Comentar' runat='server' class='btn btn-dark col-lg-2' data-toggle='collapse' href='#ComentarP" + i + "' role='button' aria-expanded='false' aria-controls='ComentarP' onclick='ComentarPublicacion' />");
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
                                                    Response.Write("<p>No hay comentarios en la publicacion, Comentale algo!</p>" );
                                                }
                                            }

                %> <textarea id="txtTextoComentario<% Response.Write(i); %>" rows="3"></textarea>&nbsp <br /><input type="button" value="responder" onclick="enviaComentario(<%Response.Write(listaPublicaciones[i].Idpublicacion + ", " + i + ", " + log.Id +", 1, "+u.Id+"" );%>)" class="btn btn-dark " /> 
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
          <hr class="w3-clear">
          </div>
               

  </div>           
  </div>
</div>
</div>
</header>
        
     




        <!-- Footer -->
        <footer class='py-5' id="mainFooter">
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
        function enviaComentario(idpost, idtxtbox, idusuario, identificador, idusuariopropietario) {
            document.location.assign("../Controlador/cComentario.aspx?idpost=" + idpost + "&texto=" + document.getElementById('txtTextoComentario' + idtxtbox).value + "&idusuario=" + idusuario + "&identificador=" + identificador + "&upropietario=" + idusuariopropietario);
           

        }

    </script>
     
</html>


