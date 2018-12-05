create database proyecto;
use proyecto;

delete from post where idemisor='5';
delete from post where idemisor=1;
delete from comentario where idemisor=1;

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

create table archivo_usuario();

create table archivo_publicacion(
idarchivo int auto_increment primary key,
nombre_archivo varchar(200),
idusuario int,
idpublicacion int,
foreign key (idpublicacion) references publicacion(idpublicacion),
foreign key (idusuario) references usuari(id_usuario)
);
create table notificacion(
idnotificacion int auto_increment primary key,
estadado tinyint,
idpost int,
idusuario int,
foreign key (idpost) references post(idpost),
foreign key (idusuario) references usuario(id_usuario)
);