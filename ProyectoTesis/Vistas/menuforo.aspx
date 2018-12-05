<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="menuforo.aspx.cs" Inherits="ProyectoTesis.Vistas.menuforo" %>

<html lang="en">
  
  <head>
    <style type="text/css"></style>
    <meta charset="utf-8">
    <meta name="viewport" content="width=device-width, initial-scale=1, shrink-to-fit=no">
    <meta name="description" content="">
    <meta name="author" content="">

    <title>RSTSP</title>

    <link href="/vendor/bootstrap/css/bootstrap.min.css" rel="stylesheet">
    <link href="/css/scrolling-nav.css" rel="stylesheet">
    <link rel="stylesheet" type="text/css" href="/css/estilos.css">

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
          <input class="form-control ml-5 lg-5 mr-5 lg-5 mt-lg-3 mb-lg-3" type="search" placeholder="Busqueda" aria-label="Search">
            <ul class="navbar-nav ml-auto">
             
            <li class="nav-item">
              <a class="nav-link js-scroll-trigger text-white" href="perfil.aspx">Perfil</a>
            </li>

             <li class="nav-item">
              <a class="nav-link js-scroll-trigger text-white" href="MenuTesis.aspx">Tesis</a>
            </li>


          </ul>
        </div>
      </div>
    </nav>

    

   
    <header class="text-white">
      <div class="container text-center">
          <h2>Menu Foros</h2>
        <div class="jumbotron text-black-50">
            <table class="table">
              <thead class="thead-dark">
                 
                  <tr>
                  
                  <td colspan="1"></td>
                  <td colspan="2"><input id="crearD" type="button" value="Crear Discusion" class="BotonD" />&nbsp;<input id="discuM" type="button" value="Mis Discusiones" class="BotonD" /></td>
                </tr>
                  
                  <tr>
                    
                    <th scope="col">Nombre</th>
                    <th scope="col">Autor</th>
                    <th scope="col">Fecha</th>
                    </tr>
                </thead>
                <tbody>
                
                    
                <tr>
                  <td><a href="foro.aspx"><p>Caso de Estudio</p></a></td>
                  <td><p>Pablo Reyes</p></td>
                  <td><p >26-11-2018</p></td>
                </tr>


                <tr>
                  
                  <td><a href="foro.aspx"><p>Caso de Estudio</p></a></td>
                  <td><p>Rodrigo Diaz</p></td>
                  <td><p>26-11-2018</p></td>
                </tr>

                <tr>
                  
                  <td><a href="foro.aspx"><p>Caso de Estudio</p></td>
                  <td><p>Enzo Castillo</p></td>
                  <td><p>26-11-2018</p></td>
                </tr>

                  

               

                 
              </tbody>
            </table>
            

        </div>

      </div>
    </header>


    <!-- Footer -->
    <footer class="py-5 bg-dark">
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