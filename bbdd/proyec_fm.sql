# Carlos Teran 

CREATE DATABASE eventos_ecologicos character set utf8;
USE eventos_ecologicos;


create table  if not exists categoria (
id int auto_increment primary key,
nombre varchar(50) not null,
descrip text
);

create table if not exists ubicacion (
id int auto_increment,
tipo enum('Online','Presencial') not null,
direccion varchar(255),
enlace varchar(255),
primary key (id)
); 


create table if not exists organizador (
id int auto_increment,
nombre varchar(100) not null,
email varchar(100) not null,
telefono varchar(20),
primary key (id)
);


create table if not exists usuario (
id int auto_increment,
nombre varchar(100) not null,
email varchar(100) not null, 
contrasenya varchar(100) not null, 
primary key (id)
);


create table if not exists evento (
id int auto_increment,
nombre varchar(100) not null,
fecha date not null,
duracion int not null,
descrip text,
organizador_id int not null,
categoria_id int not null,
ubicacion_id int not null,
estado enum('Activo','Cancelado'),
primary key (id),
foreign key (organizador_id) references organizador (id),
foreign key (categoria_id) references categoria (id),
foreign key (ubicacion_id) references ubicacion (id)
);

create table if not exists inscripcion (
id int auto_increment,
usuario_id int not null,
evento_id int not null,
fecha_inscripcion date not null,
primary key (id),
foreign key (usuario_id) references usuario (id),
foreign key (evento_id) references evento (id)
); 











