use campeanato;
create table administradores(
Id_Admin int not null primary key auto_increment,
Nombre varchar(30),
Apellido varchar(30),
Correo varchar(30),
Puesto varchar(30)	
);

create table puestos(
id_puesto int not null primary key, /*no tiene autoincrement*/
Descripcion varchar(20)
);

create table usuarios(
id_usuario int not null primary key auto_increment,
Nombre varchar(30),
Contraseña varchar(30),
Id_Admin int not null /*se conecta a administradores para obtener los datos personales*/
);
/* llave foranea */
ALTER TABLE usuarios ADD FOREIGN KEY(Id_Admin) REFERENCES administradores(Id_Admin);

create table deportes(
Id_Deporte int not null primary key, /*no tiene autoincrement*/
Descripcion varchar(20)
);

create table equipos(
Id_Equipo int not null primary key auto_increment,
Nombre varchar(30), 
Categoria varchar(30),
Id_Deporte int not null  /*Conexion con deportes para ver a que deporte pertenece*/
); 
/*llave foranea*/
ALTER TABLE equipos ADD foreign key(Id_Deporte) REFERENCES deportes(Id_Deporte);

create table jugador(
Id_Jugador int not null primary key auto_increment,
Nombre varchar(30),
Apellido varchar(30),
Año_Nacimiento int,
Numero_Camisola int,
Id_Equipo int not null /*Verificar a que equipo pertenece el jugador*/
);
/*llave foranea*/
ALTER TABLE jugador ADD foreign key(Id_Equipo) references equipos(Id_Equipo);

create table clasificacion (
Id_Clasificacion int not null primary key auto_increment,
Id_Equipo int not null, /*Verifica el equipo*/
Posicion int,
Puntos int, /*total de puntos*/
PG int, /*puntos a sumar*/
PE int,
PP int,
GF int,
GC int,
PJ int
);
/*llave foranea*/
ALTER TABLE clasificacion ADD foreign key(Id_Equipo) references equipos(Id_Equipo);

create table pichichi (
Id_Pichichi int not null primary key auto_increment,
Id_Jugador int not null,
Anotaciones int
);
/*llave foranea*/
ALTER TABLE pichichi ADD foreign key(Id_Jugador) references jugador(Id_Jugador);


create table jornada ( 
Id_Jornada int not null primary key auto_increment,
NO_Jornada int,
Id_Equipo_LO int not null,
Id_Equipo_VIS int not null,
Resultado_LO int,
Resultado_VIS int
);
/*llave foranea*/
ALTER TABLE jornada ADD foreign key(Id_Equipo_LO) references equipos(Id_Equipo);
ALTER TABLE jornada ADD foreign key(Id_Equipo_VIS) references equipos(Id_Equipo);

create table resultados (
Id_Resultado int not null primary key auto_increment,
Id_Jornada int not null,
Id_Jugador int not null,
Gol_Local int,
Gol_Visitante int
);
 /*llave foranea*/
ALTER TABLE resultados ADD foreign key(Id_Jornada) references equipos(Id_Jornada);
ALTER TABLE resultados ADD foreign key(Id_Jugador) references jugador(Id_Jugador);



SELECT Descripcion from deportes D JOIN equipos E ON D.Id_Deporte = E.Id_Equipo