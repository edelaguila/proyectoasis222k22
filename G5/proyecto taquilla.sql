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
sexo varchar(15)
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

create table sala1(
	id_asiento int primary key,
    asiento varchar(5),
    disponibilidad varchar(5)
);

create table sala2(
	id_asiento2 int primary key,
    asiento varchar(5),
    disponibilidad varchar(5)
);

create table sala3(
	id_asiento3 int primary key,
    asiento varchar(5),
    disponibilidad varchar(5)
);


alter table cines add constraint llave1 foreign key (Depto) references ubicaciones(No_depto);
alter table salas add constraint llave2 foreign key (id_cine) references cines(Id_cines);
alter table cartelera add constraint llave3 foreign key (id_pelicula) references peliculas(id_peli);
alter table peliculas add constraint llave4 foreign key (clasificacion) references clasificaciones(id_clas);
alter table cartelera add constraint llave5 foreign key (salas) references salas(Id_sala);
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

insert into usuarios values (401,"Ester","Lopez","2001-05-09","Femenino");
insert into usuarios values (402,"Joshua","Barrios","2001-06-30","Masculino");
insert into usuarios values (403,"Velvet","Samayoa","2000-05-01","Femenino");
insert into usuarios values (404,"Ricardo","Miranda","2001-02-26","Masculino");
insert into usuarios values (405,"Paola","Reyes","2002-08-15","Femenino");

insert into sala1 values (1001,"A1","si");
insert into sala1 values (1002,"A2","si");
insert into sala1 values (1003,"A3","si");
insert into sala1 values (1004,"A4","si");
insert into sala1 values (1005,"A5","si");
insert into sala1 values (1006,"A6","si");
insert into sala1 values (1007,"A7","si");
insert into sala1 values (1008,"A8","si");
insert into sala1 values (1009,"A9","si");
insert into sala1 values (1010,"A10","si");

insert into sala1 values (1011,"B1","si");
insert into sala1 values (1012,"B2","si");
insert into sala1 values (1013,"B3","si");
insert into sala1 values (1014,"B4","si");
insert into sala1 values (1015,"B5","si");
insert into sala1 values (1016,"B6","si");
insert into sala1 values (1017,"B7","si");
insert into sala1 values (1018,"B8","si");
insert into sala1 values (1019,"B9","si");
insert into sala1 values (1020,"B10","si");

insert into sala1 values (1021,"C1","si");
insert into sala1 values (1022,"C2","si");
insert into sala1 values (1023,"C3","si");
insert into sala1 values (1024,"C4","si");
insert into sala1 values (1025,"C5","si");
insert into sala1 values (1026,"C6","si");
insert into sala1 values (1027,"C7","si");
insert into sala1 values (1028,"C8","si");
insert into sala1 values (1029,"C9","si");
insert into sala1 values (1030,"C10","si");

insert into sala1 values (1031,"D1","si");
insert into sala1 values (1032,"D2","si");
insert into sala1 values (1033,"D3","si");
insert into sala1 values (1034,"D4","si");
insert into sala1 values (1035,"D5","si");
insert into sala1 values (1036,"D6","si");
insert into sala1 values (1037,"D7","si");
insert into sala1 values (1038,"D8","si");
insert into sala1 values (1039,"D9","si");
insert into sala1 values (1040,"D10","si");

insert into sala1 values (1041,"E1","si");
insert into sala1 values (1042,"E2","si");
insert into sala1 values (1043,"E3","si");
insert into sala1 values (1044,"E4","si");
insert into sala1 values (1045,"E5","si");
insert into sala1 values (1046,"E6","si");
insert into sala1 values (1047,"E7","si");
insert into sala1 values (1048,"E8","si");
insert into sala1 values (1049,"E9","si");
insert into sala1 values (1050,"E10","si");

insert into sala1 values (1051,"F1","si");
insert into sala1 values (1052,"F2","si");
insert into sala1 values (1053,"F3","si");
insert into sala1 values (1054,"F4","si");
insert into sala1 values (1055,"F5","si");
insert into sala1 values (1056,"F6","si");
insert into sala1 values (1057,"F7","si");
insert into sala1 values (1058,"F8","si");
insert into sala1 values (1059,"F9","si");
insert into sala1 values (1060,"F10","si");

insert into sala1 values (1061,"G1","si");
insert into sala1 values (1062,"G2","si");
insert into sala1 values (1063,"G3","si");
insert into sala1 values (1064,"G4","si");
insert into sala1 values (1065,"G5","si");
insert into sala1 values (1066,"G6","si");
insert into sala1 values (1067,"G7","si");
insert into sala1 values (1068,"G8","si");
insert into sala1 values (1069,"G9","si");
insert into sala1 values (1070,"G10","si");

insert into sala1 values (1071,"H1","si");
insert into sala1 values (1072,"H2","si");
insert into sala1 values (1073,"H3","si");
insert into sala1 values (1074,"H4","si");
insert into sala1 values (1075,"H5","si");
insert into sala1 values (1076,"H6","si");
insert into sala1 values (1077,"H7","si");
insert into sala1 values (1078,"H8","si");
insert into sala1 values (1079,"H9","si");
insert into sala1 values (1080,"H10","si");

insert into sala1 values (1081,"I1","si");
insert into sala1 values (1082,"I2","si");
insert into sala1 values (1083,"I3","si");
insert into sala1 values (1084,"I4","si");
insert into sala1 values (1085,"I5","si");
insert into sala1 values (1086,"I6","si");
insert into sala1 values (1087,"I7","si");
insert into sala1 values (1088,"I8","si");
insert into sala1 values (1089,"I9","si");
insert into sala1 values (1090,"I10","si");


insert into sala2 values (1101,"A1","si");
insert into sala2 values (1102,"A2","si");
insert into sala2 values (1103,"A3","si");
insert into sala2 values (1104,"A4","si");
insert into sala2 values (1105,"A5","si");
insert into sala2 values (1106,"A6","si");
insert into sala2 values (1107,"A7","si");
insert into sala2 values (1108,"A8","si");
insert into sala2 values (1109,"A9","si");
insert into sala2 values (1110,"A10","si");

insert into sala2 values (1111,"B1","si");
insert into sala2 values (1112,"B2","si");
insert into sala2 values (1113,"B3","si");
insert into sala2 values (1114,"B4","si");
insert into sala2 values (1115,"B5","si");
insert into sala2 values (1116,"B6","si");
insert into sala2 values (1117,"B7","si");
insert into sala2 values (1118,"B8","si");
insert into sala2 values (1119,"B9","si");
insert into sala2 values (1120,"B10","si");

insert into sala2 values (1121,"C1","si");
insert into sala2 values (1122,"C2","si");
insert into sala2 values (1123,"C3","si");
insert into sala2 values (1124,"C4","si");
insert into sala2 values (1125,"C5","si");
insert into sala2 values (1126,"C6","si");
insert into sala2 values (1127,"C7","si");
insert into sala2 values (1128,"C8","si");
insert into sala2 values (1129,"C9","si");
insert into sala2 values (1130,"C10","si");

insert into sala2 values (1131,"D1","si");
insert into sala2 values (1132,"D2","si");
insert into sala2 values (1133,"D3","si");
insert into sala2 values (1134,"D4","si");
insert into sala2 values (1135,"D5","si");
insert into sala2 values (1136,"D6","si");
insert into sala2 values (1137,"D7","si");
insert into sala2 values (1138,"D8","si");
insert into sala2 values (1139,"D9","si");
insert into sala2 values (1140,"D10","si");

insert into sala2 values (1141,"E1","si");
insert into sala2 values (1142,"E2","si");
insert into sala2 values (1143,"E3","si");
insert into sala2 values (1144,"E4","si");
insert into sala2 values (1145,"E5","si");
insert into sala2 values (1146,"E6","si");
insert into sala2 values (1147,"E7","si");
insert into sala2 values (1148,"E8","si");
insert into sala2 values (1149,"E9","si");
insert into sala2 values (1150,"E10","si");

insert into sala2 values (1151,"F1","si");
insert into sala2 values (1152,"F2","si");
insert into sala2 values (1153,"F3","si");
insert into sala2 values (1154,"F4","si");
insert into sala2 values (1155,"F5","si");
insert into sala2 values (1156,"F6","si");
insert into sala2 values (1157,"F7","si");
insert into sala2 values (1158,"F8","si");
insert into sala2 values (1159,"F9","si");
insert into sala2 values (1160,"F10","si");

insert into sala2 values (1161,"G1","si");
insert into sala2 values (1162,"G2","si");
insert into sala2 values (1163,"G3","si");
insert into sala2 values (1164,"G4","si");
insert into sala2 values (1165,"G5","si");
insert into sala2 values (1166,"G6","si");
insert into sala2 values (1167,"G7","si");
insert into sala2 values (1168,"G8","si");
insert into sala2 values (1169,"G9","si");
insert into sala2 values (1170,"G10","si");

insert into sala2 values (1171,"H1","si");
insert into sala2 values (1172,"H2","si");
insert into sala2 values (1173,"H3","si");
insert into sala2 values (1174,"H4","si");
insert into sala2 values (1175,"H5","si");
insert into sala2 values (1176,"H6","si");
insert into sala2 values (1177,"H7","si");
insert into sala2 values (1178,"H8","si");
insert into sala2 values (1179,"H9","si");
insert into sala2 values (1180,"H10","si");

insert into sala2 values (1181,"I1","si");
insert into sala2 values (1182,"I2","si");
insert into sala2 values (1183,"I3","si");
insert into sala2 values (1184,"I4","si");
insert into sala2 values (1185,"I5","si");
insert into sala2 values (1186,"I6","si");
insert into sala2 values (1187,"I7","si");
insert into sala2 values (1188,"I8","si");
insert into sala2 values (1189,"I9","si");
insert into sala2 values (1190,"I10","si");

insert into sala3 values (1201,"A1","si");
insert into sala3 values (1202,"A2","si");
insert into sala3 values (1203,"A3","si");
insert into sala3 values (1204,"A4","si");
insert into sala3 values (1205,"A5","si");
insert into sala3 values (1206,"A6","si");
insert into sala3 values (1207,"A7","si");
insert into sala3 values (1208,"A8","si");
insert into sala3 values (1209,"A9","si");
insert into sala3 values (1210,"A10","si");

insert into sala3 values (1211,"B1","si");
insert into sala3 values (1212,"B2","si");
insert into sala3 values (1213,"B3","si");
insert into sala3 values (1214,"B4","si");
insert into sala3 values (1215,"B5","si");
insert into sala3 values (1216,"B6","si");
insert into sala3 values (1217,"B7","si");
insert into sala3 values (1218,"B8","si");
insert into sala3 values (1219,"B9","si");
insert into sala3 values (1220,"B10","si");

insert into sala3 values (1221,"C1","si");
insert into sala3 values (1222,"C2","si");
insert into sala3 values (1223,"C3","si");
insert into sala3 values (1224,"C4","si");
insert into sala3 values (1225,"C5","si");
insert into sala3 values (1226,"C6","si");
insert into sala3 values (1227,"C7","si");
insert into sala3 values (1228,"C8","si");
insert into sala3 values (1229,"C9","si");
insert into sala3 values (1230,"C10","si");

insert into sala3 values (1231,"D1","si");
insert into sala3 values (1232,"D2","si");
insert into sala3 values (1233,"D3","si");
insert into sala3 values (1234,"D4","si");
insert into sala3 values (1235,"D5","si");
insert into sala3 values (1236,"D6","si");
insert into sala3 values (1237,"D7","si");
insert into sala3 values (1238,"D8","si");
insert into sala3 values (1239,"D9","si");
insert into sala3 values (1240,"D10","si");

insert into sala3 values (1241,"E1","si");
insert into sala3 values (1242,"E2","si");
insert into sala3 values (1243,"E3","si");
insert into sala3 values (1244,"E4","si");
insert into sala3 values (1245,"E5","si");
insert into sala3 values (1246,"E6","si");
insert into sala3 values (1247,"E7","si");
insert into sala3 values (1248,"E8","si");
insert into sala3 values (1249,"E9","si");
insert into sala3 values (1250,"E10","si");

insert into sala3 values (1251,"F1","si");
insert into sala3 values (1252,"F2","si");
insert into sala3 values (1253,"F3","si");
insert into sala3 values (1254,"F4","si");
insert into sala3 values (1255,"F5","si");
insert into sala3 values (1256,"F6","si");
insert into sala3 values (1257,"F7","si");
insert into sala3 values (1258,"F8","si");
insert into sala3 values (1259,"F9","si");
insert into sala3 values (1260,"F10","si");

insert into sala3 values (1261,"G1","si");
insert into sala3 values (1262,"G2","si");
insert into sala3 values (1263,"G3","si");
insert into sala3 values (1264,"G4","si");
insert into sala3 values (1265,"G5","si");
insert into sala3 values (1266,"G6","si");
insert into sala3 values (1267,"G7","si");
insert into sala3 values (1268,"G8","si");
insert into sala3 values (1269,"G9","si");
insert into sala3 values (1270,"G10","si");

insert into sala3 values (1271,"H1","si");
insert into sala3 values (1272,"H2","si");
insert into sala3 values (1273,"H3","si");
insert into sala3 values (1274,"H4","si");
insert into sala3 values (1275,"H5","si");
insert into sala3 values (1276,"H6","si");
insert into sala3 values (1277,"H7","si");
insert into sala3 values (1278,"H8","si");
insert into sala3 values (1279,"H9","si");
insert into sala3 values (1280,"H10","si");

insert into sala3 values (1281,"I1","si");
insert into sala3 values (1282,"I2","si");
insert into sala3 values (1283,"I3","si");
insert into sala3 values (1284,"I4","si");
insert into sala3 values (1285,"I5","si");
insert into sala3 values (1286,"I6","si");
insert into sala3 values (1287,"I7","si");
insert into sala3 values (1288,"I8","si");
insert into sala3 values (1289,"I9","si");
insert into sala3 values (1290,"I10","si");

select * from sala1;
select * from sala2;
select * from sala3;

insert into descuentos values();

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
select * from usuariosadmin;

drop table clasificaciones;
drop table peliculas;
drop table cartelera; 
drop table descuentos;
select * from salas s INNER JOIN cines c ON c.Id_cines = s.id_cine INNER JOIN cartelera car  ON  s.id_sala= car.salas where nombre_cine= 'Rush Mall';