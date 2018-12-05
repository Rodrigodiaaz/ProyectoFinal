<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="tesis.aspx.cs" Inherits="ProyectoTesis.Vistas.tesis" %>

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
    <link rel="stylesheet" type="text/css" href="/css/estilos.css">

  </head>

  <body id="page-top">

      <form id="form1" runat="server">

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
              <a class="nav-link js-scroll-trigger text-white" href="MenuTesis.aspx">Volver</a>
            </li>


          </ul>
        </div>
      </div>
    </nav>

<section id="services" >
  <div class="container text-black-50 jumbotron">
    <div class="row">
      <div class="col-lg-6 mx-auto  ">
        <h2>Descripciones de Tesis</h2>
        <div>

            <table class="table">
              <tbody>
                <tr>
                  <th scope="row"></th>
                  <td><asp:Label ID="Label5" runat="server" Text="Autores"></asp:Label></td>
                  <td>Enzo ....</td>
                </tr>

                <tr>
                  <th scope="row"></th>
                  <td><asp:Label ID="Label6" runat="server" Text="Profesor Guia:"></asp:Label></td>
                  <td>Manolete</td>
                </tr>
                
                <tr>
                  <th scope="row"></th>
                  <td><asp:Label ID="Label1" runat="server" Text="Descripcion"></asp:Label></td>
                  <td><b><p>Lorem ipsum dolor sit amet, consectetur adipisicing elit, sed do eiusmod tempor exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat.</p></b></td>
                </tr>

                <tr>
                  <th scope="row"></th>
                  <td><asp:Label ID="Label2" runat="server" Text="Comentarios"></asp:Label>></td>
                  <td><b><p>Lorem ipsum dolor sit amet, consectetur adipisicing elit, sed do eiusmod tempor exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat.</p></b></td>
                </tr>

              </tbody>
            </table>       
        </div>
        <div class="embed-responsive embed-responsive-16by9">
            
        </div>
      </div>

        <div class="col-lg-6 mx-auto embed-responsive embed-responsive-16by9">
       
            <div class="">
                <iframe src="../pdf/Tesis1.pdf" style="border:2px solid DarkRed"></iframe>
                <br />
            <iframe src="../pdf/Tesis2.pdf" " style="border:2px solid DarkRed"></iframe>
                <br />
            <iframe src="../pdf/Tesis3.pdf"  style="border:2px solid DarkRed"></iframe>
            </div> 
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

      </form>

  </body>

</html>
