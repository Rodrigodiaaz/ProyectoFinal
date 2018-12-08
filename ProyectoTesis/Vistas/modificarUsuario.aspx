<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="modificarUsuario.aspx.cs" Inherits="ProyectoTesis.Vistas.modificarUsuario" %>

<!DOCTYPE html>
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
              <a class="nav-link js-scroll-trigger text-white" href="perfil.aspx">Volver</a>
            </li>


          </ul>
        </div>
      </div>
    </nav>

    

   
    <header class="text-white">
      <div class="container text-center">
          <h2>Modificar Perfil</h2>
        <div class="jumbotron text-black-50">
            <p id="lblMensaje" runat="server"></p>
            <table class="table">
              <tbody>
                <tr>
                  <th scope="row"></th>
                  <td><p>Nombre Completo.</p></td>
                  <td><b><p>:</p></b></td>
                  <td><input id="txtNombre" type="text" runat="server" /></td>
                </tr>

                <tr>
                  <th scope="row"></th>
                  <td><p>Correo.</p></td>
                  <td><b><p>:</p></b></td>
                  <td><input id="txtCorreo" type="text" runat="server" /></td>
                </tr>

                <tr>
                  <th scope="row"></th>
                  <td><p>Contraseña. </p></td>
                  <td><b><p>:</p></b></td>
                  <td><input id="txtContraseña" type="text" runat="server" /></td>
                </tr>
                  <tr>
                  <th scope="row"></th>
                  <td><p>Repita Contraseña. </p></td>
                  <td><b><p>:</p></b></td>
                  <td><input id="txtRepetirContraseña" type="text" runat="server"  /></td>
                </tr>
                  
                  <tr>
                  <th scope="row"></th>
                  <td></td>
                  <td></td>
                  <td>
                      <asp:Button ID="btnModificar" runat="server" Text="Modificar" class="btn btn-block btn-mio mx-auto" OnClick="btnModificar_Click" /></td>
                </tr>
              </tbody>
            </table>
            

        </div>

      </div>
    </header>


          </form>

  </body>
  <footer class="py-5 bg-dark">
      <div class="container">
        <p class="m-0 text-center text-white">Copyright &copy; Quality Essentials 2018</p>

      </div>
      <!-- /.container -->
    </footer>
    <!-- Footer -->
    
    <!-- Bootstrap core JavaScript -->
    <script src="/Scripts/jQuery.min.js"></script>
    <script src="/vendor/jquery/jquery.min.js"></script>
    <script src="/vendor/bootstrap/js/bootstrap.bundle.min.js"></script>

    <!-- Plugin JavaScript -->
    <script src="/vendor/jquery-easing/jquery.easing.min.js"></script>

    <!-- Custom JavaScript for this theme -->
    <script src="/Scripts/scrolling-nav.js"></script>
      

</html>

