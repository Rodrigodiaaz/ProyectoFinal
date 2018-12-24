<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="menuForo.aspx.cs" Inherits="ProyectoTesis.Vistas.menuForo" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
  
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
             function eliminarTopic(idtopic, tema) {
                 document.location.assign("../Controlador/cForo.aspx?idtopic=" + idtopic + "&tema=" + tema);
           }
          </script>

</html>
