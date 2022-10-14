create database clinica;
use clinica;

create table cliente 
(id_cliente varchar(15) primary key not null, dpi int not null,
nombres varchar(50), apellidos varchar(50) not null,
telefono int not null, correo varchar(25) not null,
direccion varchar(50) not null);

create table paciente 
(id_paciente varchar(15) primary key not null, 
cliente varchar(15) not null, sexo varchar(10) not null,
tipoSangre varchar(5) not null, Enfermedad varchar(50) not null,
recomendacion varchar(50) not null,
foreign key (cliente) references cliente(id_cliente) on update
cascade on delete cascade);

create table medico
(id_medico varchar(15) primary key not null, dpi int not null,
nombres varchar(50), apellidos varchar(50) not null,
telefono int not null, correo varchar(25) not null,
direccion varchar(50) not null, especialidad varchar(50) not null);

create table laboratorio 
(id_laboratorio varchar(15) primary key not null, 
medico varchar(15) not null, nombre varchar(50) not null,
Ubicacion varchar(50) not null, telefono int not null,
foreign key (medico) references medico(id_medico) on update
cascade on delete cascade);

create table cita 
(id_cita varchar(15) primary key not null,
paciente varchar(15) not null, laboratorio varchar(15) not null,
fechaInicio date not null, horaInicio time not null,
fechaFin date not null, precio float not null,
foreign key (paciente) references paciente(id_paciente) on update
cascade on delete cascade,
foreign key (laboratorio) references laboratorio(id_laboratorio) on update
cascade on delete cascade);

create table examen
(id_examen varchar(15) primary key not null ,
paciente varchar(15) not null, nombre varchar(50) not null,
tipo varchar(50), precio float not null, 
foreign key (paciente) references paciente(id_paciente) on update
cascade on delete cascade);

create table factura
(id_factura varchar(15) primary key not null, fecha date not null,
cliente varchar(15) not null, total float not null,
foreign key (cliente) references cliente(id_cliente) on update
cascade on delete cascade
);

create table detalle
(id_detalle varchar(15) primary key not null, factura varchar(15) not null,
cita varchar(15) not null, examen varchar(15) not null,
foreign key (cita) references cita(id_cita) on update
cascade on delete cascade,
foreign key (examen) references examen(id_examen) on update
cascade on delete cascade,
foreign key (factura) references factura(id_factura) on update
cascade on delete cascade
);





/*--------------------------Parte Separada-----------------*/
create table usuario 
(usuario varchar(50) not null primary key, contraseña varchar(50) not null, 
tipousuario varchar(15)  not null);

create table empleado 
(id_empleado varchar(15) primary key not null, usuario varchar(15) not null,
nombres varchar(50), apellidos varchar(50) not null,
telefono int not null, correo varchar(25) not null,
direccion varchar(50) not null,
foreign key (usuario) references usuario(usuario) on update
cascade on delete restrict);

create table bitacora
(id_bitacora int auto_increment not null primary key, usuario varchar(50), 
fecha date not null, hora_inicio time, hora_fin time,
foreign key (usuario) references usuario(usuario) on update
cascade on delete cascade);

create table detallebitacora
(id_detalle int auto_increment not null primary key, bitacora int, modulo varchar(25),
accion varchar(25), hora time,
foreign key (bitacora) references bitacora(id_bitacora) on update
cascade on delete cascade);

