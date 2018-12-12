<%@ Page Language='C#' AutoEventWireup='true' CodeBehind='Foro.aspx.cs' Inherits='ProyectoTesis.Vistas.Foro1' %>



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
        function ReplicaComentario(idTopic, idusuario) {
            document.location.assign("redirectReplica.aspx?idtopic=" + idTopic + "&texto=" + document.getElementById('replica').value + "&idusuario=" + idusuario);
        }

    </script>

</html>
