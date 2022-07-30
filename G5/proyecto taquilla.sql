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
salas int,
fecha date,
idioma varchar(10),
subtitulado varchar(2),
id_descuento int
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

create table descuentos(
	id_descuento int primary key,
    descripcion varchar(50),
    descuento int,
    codigo varchar(10)
);

create table ganancias(
	id_ganancias int primary key,
    id_ventas int,
    iva decimal,
    der_autor decimal,
    ganancia decimal,
    distribuidor decimal,
    productor decimal,
    fecha date
);

create table RegVenta(
	id_reg int primary key,
    vPeli varchar(20),
    cine varchar(20),
    dia varchar(15),
	formato varchar(15),
    Horario varchar(10),
    Mpago varchar(20),
    niños varchar(20),
    adulto varchar(20),
    mayor varchar(20)
);


alter table cines add constraint llave1 foreign key (Depto) references ubicaciones(No_depto);
alter table salas add constraint llave2 foreign key (id_cine) references cines(Id_cines);
alter table salas add constraint llave3 foreign key (id_peliculas) references peliculas(id_peli);
alter table peliculas add constraint llave4 foreign key (clasificacion) references clasificaciones(id_clas);
alter table cartelera add constraint llave5 foreign key (salas) references salas(Id_sala);
alter table cartelera add constraint llave6 foreign key (id_descuento) references descuentos(id_descuento);
alter table ventas add constraint llave7 foreign key (id_peli) references peliculas(id_peli);
alter table ganancias add constraint llave8 foreign key (id_ventas) references ventas(id_ventas);

-- alter table cines add constraint llave5 foreign key (Depto) references ubicaciones(No_depto);

insert into ganancias values (600, 500, 425.00, 75.00, 1000.00, 500.00, 500.00, "2022-07-07");
insert into ganancias values (601, 501, 1275.00, 225.00, 3000.00, 1500.00, 1500.00, "2022-07-29");
insert into ganancias values (602, 502, 1190.00, 210.00, 2800.00, 1400.00, 1400.00, "2022-07-25");
insert into ganancias values (603, 503, 1020.00, 180.00, 2400.00, 1200.00, 1200.00, "2022-07-08");


insert into usuariosadmin values (1, "usuariouno","12345","ninguno");
insert into usuariosadmin values (2, "usuariodos","987654","gestionar");
insert into usuariosadmin values (3, "usuariotres","holamundo","gestionar");

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

insert into ventas values (500, 200, 50, 2500, "2022-07-07");
insert into ventas values (501, 201, 150, 7500, "2022-07-29");
insert into ventas values (502, 202, 130, 7000, "2022-07-25");
insert into ventas values (503, 203, 100, 600, "2022-07-08");

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

insert into usuarios values (401,"Ester","Lopez","2001-05-09","Femenino",320);
insert into usuarios values (402,"Joshua","Barrios","2001-06-30","Masculino",120);
insert into usuarios values (403,"Velvet","Samayoa","2000-05-01","Femenino",265);
insert into usuarios values (404,"Ricardo","Miranda","2001-02-26","Masculino",432);
insert into usuarios values (405,"Paola","Reyes","2002-08-15","Femenino",102);

insert into boletos values ();
insert into boletos values ();
insert into boletos values ();
insert into boletos values ();
insert into boletos values ();
insert into boletos values ();

insert into ventas

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
select * from RegVenta;

select * from salas s INNER JOIN cines c ON c.Id_cines = s.id_cine INNER JOIN cartelera car  ON  s.id_sala= car.salas where nombre_cine= 'Rush Mall';