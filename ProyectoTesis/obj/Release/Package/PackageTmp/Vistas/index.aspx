<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="index.aspx.cs" Inherits="ProyectoTesis.Vistas.index" %>

<!DOCTYPE html>
<html lang="en">
  <head>

    <meta charset="utf-8">
    <meta name="viewport" content="width=device-width, initial-scale=1, shrink-to-fit=no">
    <meta name="description" content="">
    <meta name="author" content="">

    <title>RSTSP</title>

    <link rel="stylesheet" type="text/css" href="/css/estilos.css">

    <!-- Bootstrap core CSS -->
    <link href="/vendor/bootstrap/css/bootstrap.min.css" rel="stylesheet">

    <!-- Custom styles for this template -->
    <link href="/css/scrolling-nav.css" rel="stylesheet">

  </head>

  <body id="page-top">

    <!-- Navigation -->
    <nav class="navbar navbar-expand-lg navbar-dark bg-dark fixed-top" id="mainNav">
      <div class="container">
        <a class="navbar-brand js-scroll-trigger" href="#page-top">Quality Essentials</a>
        <button class="navbar-toggler" type="button" data-toggle="collapse" data-target="#navbarResponsive" aria-controls="navbarResponsive" aria-expanded="false" aria-label="Toggle navigation">

          <span class="navbar-toggler-icon"></span>
        </button>


        <div class="collapse navbar-collapse" id="navbarResponsive">
          <ul class="navbar-nav ml-auto">
             <li class="nav-item">
              <a class="nav-link js-scroll-trigger text-white" href="http://portales.inacap.cl/" target="blank">INACAP</a>
            </li>


            <li class="nav-item">
              <a class="nav-link js-scroll-trigger text-white" href="#about">Soñando</a>
            </li>


            <li class="nav-item">
              <a class="nav-link js-scroll-trigger text-white" href="#services">Servicios</a>
            </li>


            <li class="nav-item">
              <a class="nav-link js-scroll-trigger text-white" href="#contact">Galeria</a>

            </li>


          </ul>
        </div>
      </div>
    </nav>

<form  method="post" runat="server">
    <header class="text-white">
      <div class="container text-center">
        <h1>Bienvenido a RSTSP</h1><br>
          
          
        <p class="lead">Una Herramienta que potencia tus oportunidades</p>
          <br>
          <asp:Label ID="lblMensaje" runat="server" Text=""></asp:Label>
          <br>
            <h3>
                <asp:TextBox ID="txtId" runat="server" placeholder="Correo" class="form-control mx-auto"></asp:TextBox></h3>
                    <br>
                    <br>
                      <h3>
                <asp:TextBox ID="txtPass" type="password" runat="server" placeholder="Password" class="form-control mx-auto"></asp:TextBox></h3>

                    <br>
                    <br>
                        <h4>
                            <asp:Button ID="btnLogin" runat="server" Text="Ingresar" class="btn btn-block btn-mio mx-auto" OnClick="btnLogin_Click" /></h4>
        <a href="registro.aspx" class="text-white">Deseas una cuenta?</a>
      </div>
    </header>
</form>

<section id="contact" >
  <div class="container">
    <div class="row">
      <div class="col-lg-8 mx-auto">
        <h2>Galeria de imagenes</h2>
        <p class="lead">Fotos</p>
      </div>
    </div>
  </div>
</section>




    <section id="services" >
      <div class="container">
        <div class="row">
          <div class="col-lg-8 mx-auto">
            <h2>Servicios que ofrecemos</h2>
            <p class="lead">Esta herramienta es de exclusivo uso de los alumnos del area de humanidades de la Universidad Tecnologica de Chile INACAP, aca podras encontrar un conjunto de medios que te otorgaran una mejor comunicacion con tus compañeros, profesores y actores relacionados con el area.</p>
          </div>
        </div>
      </div>
    </section>

    <section id="about">
      <div class="container">
        <div class="row">
          <div class="col-lg-8 mx-auto">
            <h2>Soñando para construir</h2>

        La idea es generar un espacio abierto a la reflexión, discusión, el compartir y construir diversas estrategias y acciones para y desde las Ciencias Sociales. Donde logren converger actores estratégicos como son egresad@s, alumn@s, instituciones y la propia comunidad.
        Nuestro sentido se plasma en entregar servicios digitales gratuitos, los cuales logren facilitar el constante perfeccionamiento e innovación socio-profesional, y desde allí soñar y construir en conjunto.
            
          </div>
        </div>
      </div>
    </section>

    <!-- Footer -->
    <footer class="py-5 bg-dark">
      <div class="container">
        <p class="m-0 text-center text-white">Copyright &copy; Quality Essentials 2018</p>

      </div>
      <!-- /.container -->
    </footer>

    <!-- Bootstrap core JavaScript -->
    <script src="js/jQuery.min.js"></script>
    <script src="vendor/jquery/jquery.min.js"></script>
    <script src="vendor/bootstrap/js/bootstrap.bundle.min.js"></script>

    <!-- Plugin JavaScript -->
    <script src="vendor/jquery-easing/jquery.easing.min.js"></script>

    <!-- Custom JavaScript for this theme -->
    <script src="js/scrolling-nav.js"></script>

  </body>

</html>