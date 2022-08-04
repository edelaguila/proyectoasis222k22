create database Ptaquilla;
use Ptaquilla;

create table cines (
Id_cines int primary key,
nombre_cine varchar(25),
direccion varchar(45),
depto int
);

create table salas(
Id_sala int primary key,
id_cine int,
tipo_sala varchar(10),
tipo_proyeccion varchar(2)
);

create table ubicaciones(
No_depto int primary key,
nombre_depto varchar(25),
Municipio varchar(25)
);

create table facturacion(
Id_fact int primary key,
nit_cliente varchar(12),
precio_uni float,
cantidad int,
precio_tot float
);

create table ventas(
Id_ventas int primary key,
id_peli int,
totventas int,
totcant int,
fecha date
);

create table boletos(
id_boletos int primary key,
cant_bol int,
descrip varchar(25),
peli int,
usuario int
);

create table peliculas(
id_peli int primary key,
nombrePeli varchar(30),
clasificacion int,
director varchar(30),
fecha_estreno date,
duracion varchar(15),
foto longblob
);

create table clasificaciones(
id_clas int primary key,
descrip varchar(45),
titulo varchar(15)
);

create table cartelera(
id_cartelera int not null,
id_pelicula int,
diapres varchar(15),
horapres varchar(15),
salas int,
fecha date,
idioma varchar(10),
subtitulado varchar(2),
descuento varchar(20)
);

create table usuarios(
id_usuario int primary key,
nombreUsu varchar(45),
apellidos varchar(45),
fecha_nac date,
sexo varchar(15),
puntos int
);

create table usuariosadmin(
	id_usuarioadmin int primary key,
    usuario varchar(50),
    contraseña varchar(50),
    permisos varchar(50)
);
/* NO CORRER DE MOMENTO TABLA DESCUENTOS */
create table descuentos(
	id_descuento int primary key,
    descripcion varchar(50),
    descuento int,
    codigo varchar(10)
);


alter table cines add constraint llave1 foreign key (Depto) references ubicaciones(No_depto);
alter table salas add constraint llave2 foreign key (id_cine) references cines(Id_cines);
alter table cartelera add constraint llave3 foreign key (id_pelicula) references peliculas(id_peli);
alter table peliculas add constraint llave4 foreign key (clasificacion) references clasificaciones(id_clas);
alter table cartelera add constraint llave5 foreign key (salas) references salas(Id_sala);
alter table ventas add constraint llave6 foreign key (id_peli) references peliculas(id_peli);
/*alter table cartelera add constraint llave6 foreign key (id_descuento) references descuentos(id_descuento);*/
-- alter table cines add constraint llave5 foreign key (Depto) references ubicaciones(No_depto);


insert into usuariosadmin values (1, "usuariouno","12345","ninguno");
insert into usuariosadmin values (2, "usuariodos","987654","gestionar");
insert into usuariosadmin values (3, "usuariotres","holamundo","gestionar");

insert into ubicaciones values (15,"Guatemala","Guatemala");
insert into ubicaciones values (10,"Quetzaltenango","Coatepeque");
insert into ubicaciones values (20,"Escuintla","Palin");

insert into cines values (100,"Rush Mall","calzada rooselveth",15);
insert into cines values (101,"Miraflores","Calzada Rooselveth",15);
insert into cines values (102,"Palincito","carretera a palin",20);
insert into cines values (103,"Interplaza Xela","dentro de cc",10);

insert into clasificaciones values (5,"Para todo publico","A");
insert into clasificaciones values (10,"Niños acompañados de un adulto","B");
insert into clasificaciones values (15,"Público de 12 años en adelante","B-12");
insert into clasificaciones values (20,"Público de 12 años en adelante","B-15");
insert into clasificaciones values (25,"Para mayores de 18 años","C");

insert into peliculas values (200,"Pocahontas",5,"Eric Goldberg","1995-01-01","1h 21m");
insert into peliculas values (201,"El hombre araña",10,"Sam Raimi","2002-05-03","2h 1m");
insert into peliculas values (202,"It (Eso)",25," Andrés Muschietti","2017-08-07","2h 15m");
insert into peliculas values (203,"En busca de la felicidad",15,"Gabriele Muccino","2006-12-06","1h 57m");

insert into salas values (300,100,"MACRO","2D");
insert into salas values (305,110,"IMAX","3D");
insert into salas values (310,120,"4DX","2D");
insert into salas values (315,120,"VIP","3D");
insert into salas values (320,130,"MACRO","2D");
insert into salas values (325,130,"MACRO","3D");
insert into salas values (330,110,"VIP","2D");
insert into salas values (335,100,"4DX","3D");

insert into cartelera values ();
insert into cartelera values ();
insert into cartelera values ();
insert into cartelera values ();
insert into cartelera values ();

insert into usuarios values (401,"Ester","Lopez","2001-05-09","Femenino","100");
insert into usuarios values (402,"Joshua","Barrios","2001-06-30","Masculino", "200");
insert into usuarios values (403,"Velvet","Samayoa","2000-05-01","Femenino","300");
insert into usuarios values (404,"Ricardo","Miranda","2001-02-26","Masculino","150");
insert into usuarios values (405,"Paola","Reyes","2002-08-15","Femenino","50");

insert into descuentos values();

insert into boletos values ();
insert into boletos values ();
insert into boletos values ();
insert into boletos values ();
insert into boletos values ();
insert into boletos values ();

insert into ventas values (301,200,1500,75000,"2022-08-03");
insert into ventas values (302,201,1000,70000,"2022-08-02");
insert into ventas values (303,202,985,65000,"2022-08-25");
insert into ventas values (304,203,1250,63000,"2022-08-26");

select * from cines;
select * from salas;
select * from ubicaciones;
select * from facturacion;
select * from boletos;
select * from ventas;
select * from usuarios;
select * from peliculas;
select * from clasificaciones;
select * from cartelera;
select * from usuariosadmin;

drop table clasificaciones;
drop table peliculas;
drop table cartelera; 
drop table descuentos;

select * from usuarios order by puntos desc;
select * from salas s INNER JOIN cines c ON c.Id_cines = s.id_cine INNER JOIN cartelera car  ON  s.id_sala= car.salas where nombre_cine= 'Rush Mall';