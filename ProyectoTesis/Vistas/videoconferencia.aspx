<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="videoconferencia.aspx.cs" Inherits="ProyectoTesis.Vistas.videoconferencia" %>
<%@ Import Namespace="ProyectoTesis.Modelos" %>

<!DOCTYPE html>
<html lang="en">
  
  <head>
    <style type="text/css"></style>
    <meta charset="utf-8">
    <meta name="viewport" content="width=device-width, initial-scale=1, shrink-to-fit=no">
    <meta name="description" content="">
    <meta name="author" content="">

    <title>Humanidades INACAP</title>

    <link href="/vendor/bootstrap/css/bootstrap.min.css" rel="stylesheet">
    <link href="/css/scrolling-nav.css" rel="stylesheet">
    <link href="../css/estilos.css" rel="stylesheet" />
    <link rel="stylesheet" type="text/css" href="../css/w3.css">

    <script src="https://ajax.googleapis.com/ajax/libs/jquery/3.3.1/jquery.min.js"></script>
    <script src="https://maxcdn.bootstrapcdn.com/bootstrap/3.3.7/js/bootstrap.min.js"></script>
      <script src="https://192.168.100.7:9001/demos/menu.js"></script>
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
            <div class='container'><a class="navbar-brand js-scroll-trigger" href="#page-top">
                <img class='rounded img - fluid' width="105px" height="85px" src="../img/logo2.jpg"></a>
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
    
      <form id='form1' runat='server'>
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
        <br />
        <br />
    </div>

    <div class="col-lg-6 w3-card">
      <div class='text-center'><h2>Menu Video Conferencia</h2></div>
      <br />
      <div class='container text-center'>
        
          
        <div>
        <section class='make-center'>
            <input type='text' id='room-id' value='abcdef' autocorrect=off autocapitalize=off size=20 class="col-lg-4 col-md-4 "/>
            <button id='open-room' class="col-lg-3 col-md-3">Crear Transmision</button>
            <button id='join-room' class="col-lg-3 col-md-3">Entrar a Video</button>
            <button id="open-or-join-room" class="col-lg-3 col-md-3" style="color: transparent; background-color: transparent; border-color: transparent; cursor: default;">Auto Open Or Join Room</button>
            

    <div id='videos-container' style='margin: 20px 0;'></div>
    <div id='room-urls' style='text-align: center;display: none;background: #F1EDED;margin: 15px -10px;border: 1px solid rgb(189, 189, 189);border-left: 0;border-right: 0;'></div>
        </section>
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
          
    </form>
      <script src='https://192.168.100.7:9001/dist/RTCMultiConnection.js'></script>
    <script src='https://192.168.100.7:9001/node_modules/webrtc-adapter/out/adapter.js'></script>
    <script src='https://192.168.100.7:9001/socket.io/socket.io.js'></script>
    <script src='https://192.168.100.7:9001/dev/getHTMLMediaElement.js'></script>
    <link rel='stylesheet' href='https://192.168.100.7:9001/dev/getHTMLMediaElement.css'>
    <script>
// ......................................................
// .......................UI Code........................
// ......................................................
document.getElementById('open-room').onclick = function() {
    disableInputButtons();
    connection.open(document.getElementById('room-id').value, function() {
        showRoomURL(connection.sessionid);
    });
};

document.getElementById('join-room').onclick = function() {
    disableInputButtons();

    connection.sdpConstraints.mandatory = {
        OfferToReceiveAudio: true,
        OfferToReceiveVideo: true
    };
    connection.join(document.getElementById('room-id').value);
};

document.getElementById('open-or-join-room').onclick = function() {
    disableInputButtons();
    connection.openOrJoin(document.getElementById('room-id').value, function(isRoomExist, roomid) {
        if (isRoomExist === false && connection.isInitiator === true) {
            // if room doesn't exist, it means that current user will create the room
            showRoomURL(roomid);
        }

        if(isRoomExist) {
          connection.sdpConstraints.mandatory = {
              OfferToReceiveAudio: true,
              OfferToReceiveVideo: true
          };
        }
    });
};

// ......................................................
// ..................RTCMultiConnection Code.............
// ......................................................

var connection = new RTCMultiConnection();

// by default, socket.io server is assumed to be deployed on your own URL
connection.socketURL = 'https://192.168.100.7:9001/';

// comment-out below line if you do not have your own socket.io server
// connection.socketURL = 'https://rtcmulticonnection.herokuapp.com:443/';

connection.socketMessageEvent = 'video-broadcast-demo';

connection.session = {
    audio: true,
    video: true,
    oneway: true
};

connection.sdpConstraints.mandatory = {
    OfferToReceiveAudio: false,
    OfferToReceiveVideo: false
};

connection.videosContainer = document.getElementById('videos-container');
connection.onstream = function(event) {
    var existing = document.getElementById(event.streamid);
    if(existing && existing.parentNode) {
      existing.parentNode.removeChild(existing);
    }

    event.mediaElement.removeAttribute('src');
    event.mediaElement.removeAttribute('srcObject');
    event.mediaElement.muted = true;
    event.mediaElement.volume = 0;

    var video = document.createElement('video');

    try {
        video.setAttributeNode(document.createAttribute('autoplay'));
        video.setAttributeNode(document.createAttribute('playsinline'));
    } catch (e) {
        video.setAttribute('autoplay', true);
        video.setAttribute('playsinline', true);
    }

    if(event.type === 'local') {
      video.volume = 0;
      try {
          video.setAttributeNode(document.createAttribute('muted'));
      } catch (e) {
          video.setAttribute('muted', true);
      }
    }
    video.srcObject = event.stream;

    var width = parseInt(connection.videosContainer.clientWidth / 3) - 20;
    var mediaElement = getHTMLMediaElement(video, {
        buttons: ['full-screen'],
        width: 500,
        showOnMouseEnter: false
    });

    connection.videosContainer.appendChild(mediaElement);

    setTimeout(function() {
        mediaElement.media.play();
    }, 5000);

    mediaElement.id = event.streamid;
};

connection.onstreamended = function(event) {
    var mediaElement = document.getElementById(event.streamid);
    if (mediaElement) {
        mediaElement.parentNode.removeChild(mediaElement);

        if(event.userid === connection.sessionid && !connection.isInitiator) {
          alert('Broadcast is ended. We will reload this page to clear the cache.');
          location.reload();
        }
    }
};

connection.onMediaError = function(e) {
    if (e.message === 'Concurrent mic process limit.') {
        if (DetectRTC.audioInputDevices.length <= 1) {
            alert('Please select external microphone. Check github issue number 483.');
            return;
        }

        var secondaryMic = DetectRTC.audioInputDevices[1].deviceId;
        connection.mediaConstraints.audio = {
            deviceId: secondaryMic
        };

        connection.join(connection.sessionid);
    }
};

// ..................................
// ALL below scripts are redundant!!!
// ..................................

function disableInputButtons() {
    document.getElementById('room-id').onkeyup();

    document.getElementById('open-or-join-room').disabled = true;
    document.getElementById('open-room').disabled = true;
    document.getElementById('join-room').disabled = true;
    document.getElementById('room-id').disabled = true;
}

// ......................................................
// ......................Handling Room-ID................
// ......................................................

function showRoomURL(roomid) {
    var roomHashURL = '#' + roomid;
    var roomQueryStringURL = '?roomid=' + roomid;

    var html = '<h2>url de sala de videoconferencia</h2><br>';

    html += ' URL: <a href="' + roomHashURL + '" target="_blank">' + roomHashURL + '</a>';
    html += '<br>';
    html += 'URL: <a href="' + roomQueryStringURL + '" target="_blank">' + roomQueryStringURL + '</a>';

    var roomURLsDiv = document.getElementById('room-urls');
    roomURLsDiv.innerHTML = html;

    roomURLsDiv.style.display = 'block';
}

(function() {
    var params = {},
        r = /([^&=]+)=?([^&]*)/g;

    function d(s) {
        return decodeURIComponent(s.replace(/\+/g, ' '));
    }
    var match, search = window.location.search;
    while (match = r.exec(search.substring(1)))
        params[d(match[1])] = d(match[2]);
    window.params = params;
})();

var roomid = '';
if (localStorage.getItem(connection.socketMessageEvent)) {
    roomid = localStorage.getItem(connection.socketMessageEvent);
} else {
    roomid = connection.token();
}
document.getElementById('room-id').value = roomid;
document.getElementById('room-id').onkeyup = function() {
    localStorage.setItem(connection.socketMessageEvent, document.getElementById('room-id').value);
};

var hashString = location.hash.replace('#', '');
if (hashString.length && hashString.indexOf('comment-') == 0) {
    hashString = '';
}

var roomid = params.roomid;
if (!roomid && hashString.length) {
    roomid = hashString;
}

if (roomid && roomid.length) {
    document.getElementById('room-id').value = roomid;
    localStorage.setItem(connection.socketMessageEvent, roomid);

    // auto-join-room
    (function reCheckRoomPresence() {
        connection.checkPresence(roomid, function(isRoomExist) {
            if (isRoomExist) {
                connection.join(roomid);
                return;
            }

            setTimeout(reCheckRoomPresence, 5000);
        });
    })();

    disableInputButtons();
}

// detect 2G
if(navigator.connection &&
   navigator.connection.type === 'cellular' &&
   navigator.connection.downlinkMax <= 0.115) {
  alert('2G is not supported. Please use a better internet service.');
}
</script>
    <script src='https://cdn.webrtc-experiment.com/common.js'></script>

   <!-- Footer -->
        <footer class="py-lg-5 py-5" id="MainFooter">
            <div class="container">
                <p class="m-0 text-center text-white">Copyright &copy; Quality Essentials 2018</p>

            </div>
            <!-- /.container -->
        </footer>
</body>
</html>
