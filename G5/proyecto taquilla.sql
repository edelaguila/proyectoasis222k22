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
no_asientos int,
tipo_sala varchar(10),
id_peliculas int,
hora_presnt varchar(10)
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
id_factura int,
id_bol int
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
duracion varchar(15)
);

create table clasificaciones(
id_clas int primary key,
descrip varchar(45),
titulo varchar(15)
);

create table cartelera(
id_pelicula int,
diapres varchar(15),
horapres varchar(15),
salas int
);

create table usuarios(
id_usuario int primary key,
nombreUsu varchar(45),
apellidos varchar(45),
fecha_nac date,
sexo varchar(15)
);

alter table cines add constraint llave1 foreign key (Depto) references ubicaciones(No_depto);
alter table salas add constraint llave2 foreign key (id_cine) references cines(Id_cines);
alter table salas add constraint llave3 foreign key (id_peliculas) references peliculas(id_peli);
alter table peliculas add constraint llave4 foreign key (clasificacion) references clasificaciones(id_clas);
alter table cartelera add constraint llave5 foreign key (salas) references salas(Id_sala);
-- alter table cines add constraint llave5 foreign key (Depto) references ubicaciones(No_depto);


insert into ubicaciones values (15,"Guatemala","Guatemala");
insert into ubicaciones values (10,"Quetzaltenango","Coatepeque");
insert into ubicaciones values (20,"Escuintla","Palin");

insert into cines values (100,"Rush Mall","calzada rooselveth",15);
insert into cines values (110,"Miraflores","Calzada Rooselveth",15);
insert into cines values (120,"Palincito","carretera a palin",20);
insert into cines values (130,"Interplaza Xela","dentro de cc",10);

insert into clasificaciones values (5,"Para todo publico","A");
insert into clasificaciones values (10,"Niños acompañados de un adulto","B");
insert into clasificaciones values (15,"Público de 12 años en adelante","B-12");
insert into clasificaciones values (20,"Público de 12 años en adelante","B-15");
insert into clasificaciones values (25,"Para mayores de 18 años","C");

insert into peliculas values (200,"Pocahontas",5,"Eric Goldberg","1995-01-01","1h 21m");
insert into peliculas values (201,"El hombre araña",10,"Sam Raimi","2002-05-03","2h 1m");
insert into peliculas values (202,"It (Eso)",25," Andrés Muschietti","2017-08-07","2h 15m");
insert into peliculas values (203,"En busca de la felicidad",15,"Gabriele Muccino","2006-12-06","1h 57m");

insert into salas values (300,100,75,"Niños",200,"5:00 pm");
insert into salas values (305,110,50,"3D dob",201,"2:30 pm");
insert into salas values (310,120,75,"2D dob",200,"6:00 pm");
insert into salas values (315,120,60,"Macros",202,"9:00 pm");
insert into salas values (320,130,55,"3D",203,"5:00 pm");
insert into salas values (325,130,75,"niños",200,"2:30 pm");
insert into salas values (330,110,60,"3D",202,"6:15 pm");
insert into salas values (335,100,80,"Macros",201,"8:45 pm");

insert into cartelera values ();
insert into cartelera values ();
insert into cartelera values ();
insert into cartelera values ();
insert into cartelera values ();

insert into usuarios values (401,"Ester","Lopez","2001-05-09","Femenino");
insert into usuarios values (402,"Joshua","Barrios","2001-06-30","Masculino");
insert into usuarios values (403,"Velvet","Samayoa","2000-05-01","Femenino");
insert into usuarios values (404,"Ricardo","Miranda","2001-02-26","Masculino");
insert into usuarios values (405,"Paola","Reyes","2002-08-15","Femenino");

insert into boletos values ();
insert into boletos values ();
insert into boletos values ();
insert into boletos values ();
insert into boletos values ();
insert into boletos values ();

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

select * from salas s INNER JOIN cines c ON c.Id_cines = s.id_cine INNER JOIN cartelera car  ON  s.id_sala= car.salas where nombre_cine= 'Rush Mall';