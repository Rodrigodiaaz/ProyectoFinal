<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="MenuPrincipal.aspx.cs" Inherits="ProyectoTesis.Vistas.MenuPrincipal" %>

<!DOCTYPE html>
<html lang="en">
<head>

    <meta charset="utf-8">
    <meta name="viewport" content="width=device-width, initial-scale=1, shrink-to-fit=no">
    <meta name="description" content="">
    <meta name="author" content="">

    <title>RSTSP</title>
    <link href="/vendor/bootstrap/css/bootstrap.min.css" rel="stylesheet">
    <link href="/css/scrolling-nav.css" rel="stylesheet">
    <link href="../css/estilos.css" rel="stylesheet" />
    <link rel="stylesheet" type="text/css" href="../css/w3.css">
    <script src="https://ajax.googleapis.com/ajax/libs/jquery/3.3.1/jquery.min.js"></script>
    <script src="https://maxcdn.bootstrapcdn.com/bootstrap/3.3.7/js/bootstrap.min.js"></script>
    <style>
    .sidenav {
    }
    #mainNav{
      background:  #8B0000;
    }
    #MainFooter{
        background:  #8B0000;
    }
  </style>

</head>

<body id="page-top">
     <!-- Navigation -->
        <nav class="navbar navbar-expand-lg  fixed-top" id="mainNav">
            <div class="container">
                <a class="navbar-brand js-scroll-trigger" href="#page-top">Quality Essentials</a>
                <button class="navbar-toggler" type="button" data-toggle="collapse" data-target="#navbarResponsive" aria-controls="navbarResponsive" aria-expanded="false" aria-label="Toggle navigation">

                    <span class="navbar-toggler-icon"></span>
                </button>


                <div class="collapse navbar-collapse" id="navbarResponsive">


                    <input class="form-control ml-5 lg-5 mr-5 lg-5 mt-lg-3 mb-lg-3" type="search" placeholder="Busqueda" aria-label="Search">


                    <ul class="navbar-nav ml-auto">

                        <li class="nav-item">
                            <a class="nav-link js-scroll-trigger text-white" href="#Foros">Foros</a>
                        </li>


                        <li class="nav-item">
                            <a class="nav-link js-scroll-trigger text-white" href="MenuTesis.aspx">Tesis</a>
                        </li>


                        <li class="nav-item">
                            <a class="nav-link js-scroll-trigger text-white" href="MenuVideo.aspx">Videos</a>

                        </li>


                    </ul>
                </div>
            </div>
        </nav>
<header>
 <div class="container-fluid">
  <div class="row content">
    <div class="col-lg-2 sidenav w3-card">
      <blockquote class="blockquote">
        <p class="mb-0">Administrador</p>
        <footer class="blockquote-footer">Menu Principal <cite title="Source Title"></cite></footer>
        </blockquote>
      <ul class="list-group">
        <li class="list-group-item"><a href="">Subir Tesi</a>s</li>
        <li class="list-group-item"><a href="modificarUsuario.aspx">Modificar Usuario</a></li>
        <li class="list-group-item"><a href="Menu">Crear video Conferencia</a></li>
        <li class="list-group-item"><a href="#section3">Modificar Tesis</a></li>
      </ul>
      <br>
    </div>

    <div class="col-lg-9 w3-card">
      <h4><Strong>Publicaciones Recientes</Strong></h4>
      <h5 class="EmblemaP2">&nbsp;&nbsp;&nbsp;&nbsp;</h5>
      <hr>
      <span class="w3-right w3-opacity">16 min</span>
      <h4>Rodrigo Diaz</h4>
      <p>pichula is my passion. Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat. Excepteur sint occaecat cupidatat non proident, sunt in culpa qui officia deserunt mollit anim id est laborum consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat.</p>
      <br><br>
      <div ><h3 data-toggle="collapse" href="#ComentarP" role="button" aria-expanded="false" aria-controls="ComentarP" ><Strong>Comentar</Strong></h3></div>
      <br />
        
         
        <!-- Comentario Principal -->
          <div class="mx-auto w3-card w3-round  collapse alert-secondary" id="ComentarP">
          <div class="w3-padding-large alert"><h4><strong>Comentarios</strong></h4>
          <span class="w3-right w3-opacity">10 min</span>
          <span>Pablo Reyes <span>:</span><span>Lorem ipsum dolor sit amet, consectetur adipisicing elit, sed do eiusmod tempor exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat.</span></span>
              <br />
              <br />
          <hr class="w3-clear">
          
          <form role="form">
                <div class="form-group">
                  <textarea class="form-control" rows="3" required></textarea>
                </div>
                
                 &nbsp;<input id="Comentar1" type="button" value="Publicar" class="btn btn-dark col-lg-2" />
              </form>
          </div>
               

             
  </div>
</div>
</div>
</div>

</header>
        
        <!-- Footer -->
        <footer class="py-lg-5 py-5" id="MainFooter">
            <div class="container">
                <p class="m-0 text-center text-white">Copyright &copy; Quality Essentials 2018</p>

            </div>
            <!-- /.container -->
        </footer>

        

    

</body>
 <!-- Bootstrap core JavaScript -->
    <script src="/Scripts/jQuery.min.js"></script>
    <script src="/vendor/jquery/jquery.min.js"></script>
    <script src="/vendor/bootstrap/js/bootstrap.bundle.min.js"></script>

    <!-- Plugin JavaScript -->
    <script src="/vendor/jquery-easing/jquery.easing.min.js"></script>

    <!-- Custom JavaScript for this theme -->
    <script src="/Scripts/scrolling-nav.js"></script>

</html>