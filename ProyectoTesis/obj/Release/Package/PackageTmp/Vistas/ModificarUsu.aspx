<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ModificarUsu.aspx.cs" Inherits="ProyectoTesis.Vistas.ModificarUsu" %>

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
    <form runat="server">
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
        <p class="mb-0">Administrador o Usuario</p>
        <br />
        <footer class=""> <img class="rounded img-fluid" width="50px" height="50px" src="../img/menu.jpg">Menu</footer>
        </blockquote>
      <ul class="list-group">
        <li class="list-group-item"><a href="home.aspx">Perfil</a></li>
        <li class="list-group-item"><a href="menuforo.aspx">Menu Foros</a></li>
        <li class="list-group-item"><a href="temaTesis.aspx">Menu Tesis</a></li>
        <li class="list-group-item"><a href="temaTesis.aspx">Video Conferencia</a></li>
      </ul>
      <br />
      <br />
    
    </div>

    <div class="col-lg-6 w3-card">
      <div class="text-center"><h2>Modificar Perfil</h2></div>
      <h5 class="EmblemaP2">&nbsp;&nbsp;&nbsp;&nbsp;</h5>
        <div class="text-center><asp:Label ID="lblMensaje" runat="server" Text="Label"></asp:Label></div>
      <br />
       <div class="panel panel-default">
        <div class="panel-heading">
        <h4 class="panel-title">
        <h3 data-toggle="collapse" href="#ModifiCorreo"><Strong>Modificar Correo</Strong></h3>
        </h4>
        <div id="ModifiCorreo" class="panel-collapse collapse">
        <table class="table-responsive">
         <tbody>
            <tr>
              <td><h4>Correo actual : </h4></td>
              <td><h4><asp:Label ID="lblCorreoActual" runat="server" Text="Label"></asp:Label></h4></td>
            </tr>
             <tr>
              <td><h4>Nuevo Correo : </h4></td>
              <td><div class="col-xs"><input id="txtCorreoNuevo" class="form-control" runat="server" type="text" /></div></td>
             </tr>
           <tr>
            <td>
                

            </td>
               <td><asp:Button ID="btnModificarcorreo" runat="server" Text="Actualizar" class="btn btn-dark col-lg-9 col-md-6 col-sm-6" OnClick="btnModificarcorreo_Click" /></td>
           </tr>
          </tbody>
        </table>
    </div>
    </div>
  </div>
    <div class="panel-group">
        <div class="panel panel-default">
        <div class="panel-heading">
        <h4 class="panel-title">
        <h3 data-toggle="collapse" href="#ModifiNombre"><Strong>Modificar Nombre</Strong></h3>
        </h4>
        </div>
         <div id="ModifiNombre" class="panel-collapse collapse">
        <table class="table-responsive">
         <tbody>
            <tr>
              <td><h4>Nombre actual :</h4></td>
              <td><h4>
                  <asp:Label ID="lblNombreactual" runat="server" Text="Label"></asp:Label></h4></td>
            </tr>
            <tr>
              <td><h4>Nuevo Nombre :</h4></td>
              <td><div class="col-xs"><input id="txtNombreNuevo" class="form-control" runat="server"  type="text" /></div></td>
            </tr>
           <tr>
           <td>
               

           </td>
               <td>
                   <asp:Button ID="btnCambiarNombre" runat="server" Text="Actualizar" class="btn btn-dark col-lg-8 col-md-6 col-sm-6" OnClick="btnCambiarNombre_Click"/>
               </td>
           </tr>
          </tbody>
        </table>

    </div>
  </div>
        
    <div class="panel panel-default">
        <div class="panel-heading">
        <h4 class="panel-title">
        <h3 data-toggle="collapse" href="#ModifiContrase"><strong>Modificar Contraseña</strong></h3>
        </h4>
        </div>
        <div id="ModifiContrase" class="panel-collapse collapse">
        <table class="table-responsive">
         <tbody>
            <tr>
              <td><h4>Ingrese Contraseña antigua :</h4></td>
              <td><div class="col-xs"><input id="txtOldPass" class="form-control" runat="server"  type="password" /></div></td>
            </tr>
            
             <tr>
             <td><h4>Ingrese Contraseña Nueva :</h4></td>
            <td><div class="col-xs"><input id="txtNewPass" class="form-control" runat="server"  type="password" /></div> </td>
             </tr>

             <tr>
             <td><h4>Validar Contraseña Nueva :</h4></td>
             <td><div class="col-xs"><input id="txtConfirmaPass" class="form-control" runat="server"  type="password" /></div> </td>
             </tr>

             <tr>
              <td>
                  

              </td>
                 <td>
                     <asp:Button ID="btnModificarcontraseña" runat="server" Text="Actualizar" class="btn btn-dark col-lg-6 col-md-6 col-sm-6" OnClick="btnModificarcontraseña_Click" />
                 </td>
           </tr>
          </tbody>
        </table>
    </div>
  </div>
</div>
      <hr class="w3-clear" />
      </div>  
       <div class="col-lg-3 sidenav w3-card">
        <blockquote class="blockquote">
        <p class="mb-0">Soñando</p>
        <br />
        <footer class="text-center"><img src='../img/perfil.jpg'' style='width: 150px ' height:'150px' class='rounded-circle'> </footer>
        </blockquote>
      <ul class="list-group">
        <li class="list-group-item">

        <p><em>"idea es generar un espacio abierto a la reflexión, discusión, el compartir y construir diversas estrategias y acciones para y desde las Ciencias Sociales. Donde logren converger actores estratégicos como son egresad@s, alumn@s, instituciones y la propia comunidad.
        Nuestro sentido se plasma en entregar servicios digitales gratuitos, los cuales logren facilitar el constante perfeccionamiento e innovación socio-profesional, y desde allí soñar y construir en conjunto."</em></p></li>
      </ul>
      <br />
      <br />
      <br />
      <br />
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

        

    
</form>
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