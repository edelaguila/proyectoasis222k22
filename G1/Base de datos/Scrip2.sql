use campeanato;
create table administradores(
Id_Admin int not null primary key auto_increment,
Nombre varchar(30),
Apellido varchar(30),
Correo varchar(30),
Puesto varchar(30)	
);

insert into administradores (Nombre, Apellido, Correo, Puesto) values ("CRistian", "Jocol", "cjocol@gmail.com", "Admin Equipo");
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
select * from administradores;
create table deportes(
Id_Deporte int not null primary key, /*no tiene autoincrement*/
Descripcion varchar(20)
);

create table equipos(
Id_Equipo int not null primary key auto_increment,
Nombre varchar(30), 
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

/*hola*/
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

select *from equipos;


insert into usuarios (Usuario, Contraseña, Id_Admin) values ("yordi","789",2);





create table torneos (
Id_Torneo int not null primary key,
Cant_Equipos int,
Detalles varchar(30)
);


select * from torneos;

create table EquipoTorneo (
Id_ET int not null primary key,
Id_Torneo int not null,
Equipo1 int,
Equipo2 int,
Equipo3 int,
Equipo4 int,
Equipo5 int,
Equipo6 int,
Equipo7 int,
Equipo8 int,
Equipo9 int,
Equipo10 int,
Equipo11 int,
Equipo12 int,
Equipo13 int,
Equipo14 int,
Equipo15 int,
Equipo16 int
);

ALTER TABLE EquipoTorneo ADD FOREIGN KEY (Id_Torneo) references torneos (Id_Torneo);
/*-------------------------------LLAVES DE EQUIPOS-----------------------------------*/
ALTER TABLE EquipoTorneo ADD FOREIGN KEY (Equipo1) references equipos (Id_Equipo);
ALTER TABLE EquipoTorneo ADD FOREIGN KEY (Equipo2) references equipos (Id_Equipo);
ALTER TABLE EquipoTorneo ADD FOREIGN KEY (Equipo3) references equipos (Id_Equipo);
ALTER TABLE EquipoTorneo ADD FOREIGN KEY (Equipo4) references equipos (Id_Equipo);
ALTER TABLE EquipoTorneo ADD FOREIGN KEY (Equipo5) references equipos (Id_Equipo);
ALTER TABLE EquipoTorneo ADD FOREIGN KEY (Equipo6) references equipos (Id_Equipo);
ALTER TABLE EquipoTorneo ADD FOREIGN KEY (Equipo7) references equipos (Id_Equipo);
ALTER TABLE EquipoTorneo ADD FOREIGN KEY (Equipo8) references equipos (Id_Equipo);
ALTER TABLE EquipoTorneo ADD FOREIGN KEY (Equipo9) references equipos (Id_Equipo);
ALTER TABLE EquipoTorneo ADD FOREIGN KEY (Equipo10) references equipos (Id_Equipo);
ALTER TABLE EquipoTorneo ADD FOREIGN KEY (Equipo11) references equipos (Id_Equipo);
ALTER TABLE EquipoTorneo ADD FOREIGN KEY (Equipo12) references equipos (Id_Equipo);
ALTER TABLE EquipoTorneo ADD FOREIGN KEY (Equipo13) references equipos (Id_Equipo);
ALTER TABLE EquipoTorneo ADD FOREIGN KEY (Equipo14) references equipos (Id_Equipo);
ALTER TABLE EquipoTorneo ADD FOREIGN KEY (Equipo15) references equipos (Id_Equipo);
ALTER TABLE EquipoTorneo ADD FOREIGN KEY (Equipo16) references equipos (Id_Equipo);

CREATE TABLE partidos (
Id_Partido int not null primary key,
Id_ET int not null,
Id_EquipoLO int not null,
Gol_lo int,
Id_EquipoVI int not null,
Gol_VI int
);

SELECT * FROM partidos;
ALTER TABLE partidos ADD FOREIGN KEY (Id_ET) references EquipoTorneo (Id_ET);
ALTER TABLE partidos ADD FOREIGN KEY (Id_EquipoLO) references equipos (Id_Equipo);
ALTER TABLE partidos ADD FOREIGN KEY (Id_EquipoVI) references equipos (Id_Equipo);

CREATE TABLE goles (
Id_gol int not null primary key auto_increment,
Id_Jugador int not null,
Goles int
);
select * from goles;
DROP TABLE goles;
ALTER TABLE goles ADD foreign key (Id_Jugador) references jugador (Id_Jugador);


DELIMITER //
create PROCEDURE sumar_goles (in golessuma int, in idact int)
BEGIN

DECLARE golesnuev int;
DECLARE golestotal int;
DECLARE golesant int;

SELECT Goles INTO golesant from goles WHERE goles.Id_Jugador = idact;

SET golesnuev = golessuma;
SET golestotal = golesnuev+golesant;

UPDATE goles SET Goles=golestotal WHERE goles.Id_Jugador=idact;
SELECT * from goles;
END;//
drop procedure sumar_goles;
call sumar_goles (3,5);
select * from goles;


SELECT * FROM goles order by Goles desc;


SELECT  jugador.Nombre, goles.Goles FROM goles INNER JOIN JUGADOR USING (Id_Jugador) ORDER BY Goles DESC;

create table AdminTorneo(
Id_AdminT int not null primary key auto_increment,
Nombre varchar(30),
Contraseña varchar(30),
Id_Admin int not null 
);
ALTER TABLE AdminTorneo ADD FOREIGN KEY(Id_AdminT) REFERENCES administradores(Id_Admin);

insert into AdminTorneo (Nombre, Contraseña, Id_Admin) values ("afedo","456",3);


create table AdminEquipo(
Id_AdminE int not null primary key auto_increment,
Nombre varchar(30),
Contraseña varchar(30),
Id_Admin int not null
);
ALTER TABLE AdminEquipo ADD FOREIGN KEY(Id_AdminE) REFERENCES administradores(Id_Admin);

insert into AdminEquipo (Nombre, Contraseña, Id_Admin) values ("jocol","pepian",4);
