create database proyecto;
use proyecto;

delete from post where idemisor='5';
delete from post where idemisor=1;
delete from comentario where idemisor=1;
SELECT * FROM publicacion ORDER BY idpublicacion DESC;
select * from comentario;
select * from usuario;
select * from post;
select * from publicacion;
SELECT * FROM publicacion WHERE idreceptor=1 ORDER BY idpublicacion DESC;

SELECT * FROM comentario xampWHERE idpost=1 ORDER BY idcomentario DESC;

INSERT INTO post (texto,idemisor,idreceptor,tipopost,estado,fecha) VALUES ('esta es una prueba', '1','1','1','1','28-11-2018 1:08:52');
drop database proyecto;

insert into comentario (idpost, idemisor, texto, fecha, estado) values (1,1,'prueba','asd',0);
insert into comentario (idpost, idemisor, texto, fecha, estado) values (2,1,'prueba','asd',0);


create table usuario(
id_usuario int auto_increment primary key,
rut_usuario varchar(50),
primerNombre varchar(50),
segundoNombre varchar(50),
apellidoPaterno varchar(50),
apellidoMaterno varchar(50),
correo varchar (100),
fecha_nacimiento varchar(100),
contrasenia varchar(100),
cargo varchar(100),
tipo_perfil varchar(30),
estado tinyint
);

create table tesis(
id_tesis int auto_increment primary key,
Autor varchar(200),
descripcion varchar(1000),
profesor_guia varchar(1000),
nombre_archivo varchar(1000)
);

create table publicacion(
idpublicacion int auto_increment primary key,
texto varchar(1000),
idemisor int,
idreceptor int,
estado tinyint,
fecha varchar(30),
foreign key (idreceptor) references usuario(id_usuario),
foreign key (idemisor) references usuario(id_usuario)
);


create table topic(
id_topic int auto_increment primary key,
id_usuario int,
titulo varchar(200),
fecha varchar(30),
texto varchar(2000),
foreign key (id_usuario) references usuario(id_usuario)
);

create table respuesta_topic(
id_respuesta int auto_increment primary key,
id_usuario int,
id_topic int,
fecha varchar(30),
texto varchar(2000),
foreign key (id_usuario) references usuario(id_usuario),
foreign key (id_topic) references topic(id_topic)
);



create table comentario(
idcomentario int auto_increment primary key,
idpublicacion int,
idemisor int,
texto varchar(1000),
fecha varchar(30),
estado tinyint,
foreign key (idemisor) references usuario(id_usuario),
foreign key (idpublicacion) references publicacion(idpublicacion)
);

create table archivo(
idarchivo int auto_increment primary key,
nombre_archivo varchar(200),
idusuario int,
idpublicacion int,
foreign key (idpublicacion) references publicacion(idpublicacion),
foreign key (idusuario) references usuario(id_usuario)
);


create table videoconferencia(
id_videoconferencia int auto_increment primary key,
titulo varchar(400),
descripcion varchar(1000),
fecha varchar(100),
id_usuario int,
roomId int,
foreign key (id_usuario) references usuario(id_usuario)
);

  
create table notificacion(
idnotificacion int auto_increment primary key,
estadado tinyint,
idpublicacion int,
idusuario int,
foreign key (idpublicacion) references publicacion(idpublicacion),
foreign key (idusuario) references usuario(id_usuario)
);