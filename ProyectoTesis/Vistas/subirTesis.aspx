<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="subirTesis.aspx.cs" Inherits="ProyectoTesis.Vistas.subirTesis" %>

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
    <link href="../css/estilos.css" rel="stylesheet" />
    <link rel="stylesheet" type="text/css" href="../css/w3.css">
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

<body id="page-top">
     <!-- Navigation -->
        <nav class='navbar navbar-expand-lg fixed-top' id='mainNav'>
            <div class='container'>
                <a class='navbar-brand js-scroll-trigger' href='#page-top'>Quality Essentials</a>
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
        <p class="mb-0">Administrador o Usuario</p>
        <br />
        <footer class=""> <img class="rounded img-fluid" width="50px" height="50px" src="../img/menu.jpg">Menu</footer>
        </blockquote>
      <ul class="list-group">
        <li class="list-group-item"><a href="home.aspx">Perfil</a></li>
        <li class="list-group-item"><a href="menuforo.aspx">Menu Foros</a></li>
        <li class="list-group-item"><a href="MenuTesis.aspx">Video Conferencia</a></li>
      </ul>
      <br />
      <br />
    
    </div>

    <div class="col-lg-6 w3-card">
      <div class="text-center"><h2>Subir Tesis</h2></div>
      <h5 class="EmblemaP2">&nbsp;&nbsp;&nbsp;&nbsp;</h5>
       
      <div class="text-center"><h2>Formulario de tesis</h2><br />
          <asp:Label ID="lblMensaje" runat="server" Text=""></asp:Label>
      </div>
      <br />
       <form  method="post" runat="server">
       <table class="table">
              <tbody>
               <tr>
                  <th scope="row"></th>
                  <td><asp:Label ID="Label20" runat="server" Text="Titulo"></asp:Label></td>
                  <td>
                  <asp:TextBox ID="txtTitulo" runat="server" class="form-control mx-auto"></asp:TextBox>
                    

                  </td>
                </tr>
                  
               <tr>
                  <th scope="row"></th>
                  <td><asp:Label ID="Label5" runat="server" Text="Autores"></asp:Label></td>
                  <td>
                  <asp:TextBox ID="txtAutores" runat="server" class="form-control mx-auto"></asp:TextBox>
                    

                  </td>
                </tr>

                <tr>
                  <th scope="row"></th>
                  <td><asp:Label ID="Label6" runat="server" Text="Profesor Guia:"></asp:Label></td>
                  <td><asp:TextBox ID="txtProfeGuia" runat="server" class="form-control mx-auto"></asp:TextBox></td>
                </tr>
                
                <tr>
                  <th scope="row"></th>
                  <td><asp:Label ID="Label1" runat="server" Text="Descripcion"></asp:Label></td>
                  <td>
                      <textarea id="txtDescripcion" runat="server" class="form-control" rows="3" required></textarea>
                      </td>
                </tr>


                  <tr>
                  <th scope="row"></th>
                  <td>
                  </td>
                      <td>
                            <asp:FileUpload ID="fileTesis" runat="server" class="col-lg-10 col-md-6 col-sm-6" />
                      </td>
                  </tr>
                 
                  <tr>
                  <th scope="row"></th>
                  <td>
                      
                  </td>
                      <td>
                          <asp:Button ID="btnSubirTesis" runat="server" Text="Subir" class="btn btn-dark col-lg-4 col-md-4 col-sm-4" OnClick="btnSubirTesis_Click" />
                      </td>
                  </tr>

              </tbody>
            </table> 
        </form>
        <br /><br /><br /><br /><br /><br />
      <hr class="w3-clear" />
        </div>
    <div class="col-lg-3 sidenav w3-card">
      
      <br />
      <br />
       

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

