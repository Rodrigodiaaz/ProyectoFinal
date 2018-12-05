<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="home2.aspx.cs" Inherits="ProyectoTesis.Vistas.home" %>

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


</head>

<body id="page-top">
  
    <form runat="server">
        <!-- Navigation -->
        <nav class="navbar navbar-expand-lg navbar-dark bg-dark fixed-top" id="mainNav">
            <div class="container">
                <a class="navbar-brand js-scroll-trigger" href="#page-top">Quality Essentials</a>
                <button class="navbar-toggler" type="button" data-toggle="collapse" data-target="#navbarResponsive" aria-controls="navbarResponsive" aria-expanded="false" aria-label="Toggle navigation">

                    <span class="navbar-toggler-icon"></span>
                </button>


                <div class="collapse navbar-collapse" id="navbarResponsive">


                    <asp:TextBox ID="txtBuscar" runat="server" OnTextChanged="mostrarUsuarios" AutoPostBack="true" TextMode="Search"></asp:TextBox><asp:DropDownList ID="listaBusqueda" runat="server" AutoPostBack="True" OnSelectedIndexChanged="listaBusqueda_SelectedIndexChanged" DataTextField="true" OnTextChanged="listaBusqueda_TextChanged"></asp:DropDownList>
                    

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


        <!-- Centro Pagina -->
        <section >
            <div class="container" >
                <div class="row">


                    <!-- Perfil -->
                    <div class="col-lg-3 mx-auto jumbotron">
                        <h5>Perfil</h5>
                        <br />
                        <div class="TarjetaP">
                            <img src="https://scontent.fscl7-1.fna.fbcdn.net/v/t1.0-9/25550169_424792881274063_4266450031386810619_n.jpg?_nc_cat=107&_nc_ht=scontent.fscl7-1.fna&oh=9734b2a557f3e7412851ff75dda87cb6&oe=5C75F5DE" alt="Pablo" style="width: 100%" class="rounded-top">
                            <br />
                            <br />
                            <p>Enzo Castillo. </p>

                            <p class="title">Ingenieria en informatica. </p>
                            <p>Inacap Maipu</p>
                            <p>
                                <input id="Button2" type="button" value="Modificar Perfil" class="ButtonMP" />
                                <br />
                                <br />
                                <br />

                        </div>
                    </div>

                    <!-- Menu -->
                    <div class="col-lg-7 mx-auto w3-card w3-round w3-white">


                        <div>
                            <div class="EmblemaP"><h1 >Publicaciones</h1></div>
                            <h5 class="EmblemaP2">Bienvenido + Nombre</h5>
                            <br />
                            <br />
                            
                            <div>
                                <div class="">
                                    <div>
                                        <div>
                                            <div class="textomen w3-padding-large">
                                            <input id="TextAr" type="text" placeholder="Que vas a publicar Hoy!" class="TextoMenu" />
                                                    <br />
                                                    <br />
                                            </div>
                                            <input id="Button3" type="button" value="Publicar" class="ButtonMP" />
                                            <input id="Archivo" type="file" name="image_post"/>
                                           
                                                    <br />
                                                    <br />
                                                    <br />
                                        </div>
                                    </div>
                                </div>
                            </div>
                        </div>

                        <!-- Comentarios -->
                        <div class="mx-auto w3-card w3-round w3-white">
                            <div class="EmblemaP"><h1 >Comentarios</h1></div>
                            <br />
                            <br />
                            <br />
                                <div class="w3-padding-large">
                                    <span class="w3-right w3-opacity">16 min</span>
                                    <h4>Rodrigo Diaz</h4>
                                    <hr class="w3-clear">
                                    <p>Lorem ipsum dolor sit amet, consectetur adipisicing elit, sed do eiusmod tempor exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat.</p>
                                    <button type="button" class="ButtonMP">Me gusta</button>
                                    <button type="button" class="ButtonMP">Comentar</button>
                                        <br />
                                        <br />
                                        <input id="Text1" type="text" />
                                  
                                </div>
                                   <div class="mx-auto w3-card w3-round w3-white w3-padding-large">
                                        <div>
                                    
                                </div>
                                  </div>     
                            </div>
                        

                    </div>

                    <!-- Etiquetas -->
                    
                    <div class="col-lg-2 mx-auto jumbotron">
                        <p>Etiquetas o Notificaciones</p>
                        <br />

                    <button type="button" class="NotifiPer">Notificaciones <span class="badge">10</span></button>
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

        

    
        </form>
</body>
<!-- Bootstrap core JavaScript -->
        <script src="js/jQuery.min.js"></script>
        <script src="vendor/jquery/jquery.min.js"></script>
        <script src="vendor/bootstrap/js/bootstrap.bundle.min.js"></script>

        <!-- Plugin JavaScript -->
        <script src="vendor/jquery-easing/jquery.easing.min.js"></script>

        <!-- Custom JavaScript for this theme -->
        <script src="js/scrolling-nav.js"></script>
</html>
