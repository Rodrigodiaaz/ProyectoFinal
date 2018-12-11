<%@ Page Language='C#' AutoEventWireup='true' CodeBehind='MenuPrincipal.aspx.cs' Inherits='ProyectoTesis.Vistas.MenuPrincipal' %>


        

    

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
        function enviaComentario(idpost, idtxtbox, idusuario, identificador) {
            document.location.assign("../Controlador/cComentario.aspx?idpost=" + idpost + "&texto=" + document.getElementById('txtTextoComentario' + idtxtbox).value + "&idusuario=" + idusuario + "&identificador=" + identificador);
        }

    </script>

</html>