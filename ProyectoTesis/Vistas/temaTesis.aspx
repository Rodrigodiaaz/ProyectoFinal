<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="temaTesis.aspx.cs" Inherits="ProyectoTesis.Vistas.temaTesis" %>
<%@ Import Namespace="ProyectoTesis.Modelos" %>

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
                <a class="navbar-brand js-scroll-trigger" href="#page-top"><img class='rounded img - fluid' width="105px" height="85px" src="../img/logo2.jpg"></a>
                <button class='navbar-toggler' type='button' data-toggle='collapse' data-target='#navbarResponsive' aria-controls='navbarResponsive' aria-expanded='false' aria-label='Toggle navigation'>

                    <span class='navbar-toggler-icon'></span>
                </button>


                <div class="collapse navbar-collapse" id="navbarResponsive">
                    <input class='form-control ml-5 lg-5 mr-5 lg-5 mt-lg-3 mb-lg-3' type='search' placeholder='Busqueda' aria-label='Search'>
          <ul class="navbar-nav ml-auto">
             
            <li class="nav-item">
              <a class="nav-link js-scroll-trigger text-white" href="cerrarsesion.aspx">Desconectar</a>
            </li>

          </ul>
        
        </div>
      </div>
        </nav>
<header>
 <div class="container-fluid">
  <div class="row content">
    <div class="col-lg-3 sidenav w3-card">

        <%
            Usuario u = (Usuario)Session["logeado"];
            if (u.Tipoperfil.Equals("Alumno"))
            {
                %>
        <blockquote class="blockquote">
        <p class="mb-0"></p>
        <br />
        <footer class=""> <img class="rounded img-fluid" width="50px" height="50px" src="../img/menu.jpg">Menu Alumno </footer>
        </blockquote>
     <ul class="list-group">
         <li class='list-group-item'><a href="MenuPrincipal.aspx">Menu Principal</a></li>
        <li class="list-group-item"><a href="home.aspx">Perfil</a></li>
        <li class="list-group-item"><a href="temaForo.aspx">Menu Foros</a></li>
        <li class="list-group-item"><a href="videoconferencia.aspx">Video Conferencia</a></li>
      </ul>
        
        <%

            }
            else
            {
                %>
        <blockquote class="blockquote">
        <p class="mb-0"></p>
        <br />
        <footer class=""> <img class="rounded img-fluid" width="50px" height="50px" src="../img/menu.jpg">Menu Adminstrador </footer>
        </blockquote>
     <ul class="list-group">
         <li class='list-group-item'><a href='home.aspx'>Perfil</a></li>
        <li class='list-group-item'><a href='temaforo.aspx'>Menu Foros</a></li>
        <li class='list-group-item'><a href='videoconferencia.aspx'>Video Conferencia</a></li>
        <li class='list-group-item'><a href='subirTesis.aspx'>Subir Tesis</a></li>
        <li class='list-group-item'><a href='tematesis.aspx'>Menu Tesis</a></li>
        <li class='list-group-item'><a href='crearForo.aspx'>Crear Foro</a></li>
        <li class='list-group-item'><a href='modificarusu.aspx'>Modificar Usuario</a></li>
      </ul>
        
        <%
            }

            %>
      
      <br />
      <br />
    
      <br />
     <br />
     <br />
    </div>
     

    <div class="col-lg-6 w3-card">
         
      <div class='text-center'><h2>Menu Categorias de Tesis</h2></div>
      <br />
      
                            
                        <div id='accordion'>
                     <div class='card'>
                       <div class='card-header' id='TopicU'>
                         <p class='mb-0'>
                            <a href="MenuTesis.aspx?tema=p">Carrera de Psicopedagogia</a> 
                           <br />
                         </p>
          
                       </div>
                 
                     </div>
                     <div class="card">
                       <div class="card-header" id="TopicD">
                         <p class="mb-0">
                         <a href="MenuTesis.aspx?tema=ts">Carrera de Trabajo Social</a>
                           
                           <br />
                         </p>
          
                      </div>
                   
                     </div>
                     <div class="card">
                       <div class="card-header" id="TopicT">
                         <p class="mb-0">
                         <a href="MenuTesis.aspx?tema=t">Carrera de Traduccion</a>
                           <br />
                         </p>
          
        
                       </div>
                     
                     </div>
                   </div>
                                        <hr class="w3-clear" />
                         </div>  
      <div class="col-lg-3 sidenav w3-card">
       
            <blockquote class="blockquote">
        <p class="mb-0">Soñando</p>
        <br />
        <footer class="text-center"><img src='../img/Perfil.jpg'' style='width: 150px ' height:'150px' class='rounded-circle'> </footer>
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
