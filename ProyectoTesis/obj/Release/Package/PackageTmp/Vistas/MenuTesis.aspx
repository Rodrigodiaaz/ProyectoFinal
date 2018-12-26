<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="MenuTesis.aspx.cs" Inherits="ProyectoTesis.Vistas.MenuTesis" %>



        

    

</body>
 <!-- Bootstrap core JavaScript -->
    <script src="/Scripts/jQuery.min.js"></script>
    <script src="/vendor/jquery/jquery.min.js"></script>
    <script src="/vendor/bootstrap/js/bootstrap.bundle.min.js"></script>

    <!-- Plugin JavaScript -->
    <script src="/vendor/jquery-easing/jquery.easing.min.js"></script>

    <!-- Custom JavaScript for this theme -->
    <script src="/Scripts/scrolling-nav.js"></script>

<script type="text/javascript">
    function eliminarTesis(idtesis, tema) {
        document.location.assign("../Controlador/cTesis.aspx?idtesis=" + idtesis + "&tema=" + tema);
    }

</script>

</html>
