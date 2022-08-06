create database asignacioncursos;
use asignacioncursos;

CREATE TABLE tipo_usuario (
  `id` INT NOT NULL AUTO_INCREMENT,
  `nombre` VARCHAR(45) NOT NULL,
  PRIMARY KEY (`id`))ENGINE=InnoDB DEFAULT CHARSET=latin1;
  
  create table usuarios(
 `id` INT NOT NULL AUTO_INCREMENT,
  `usuario` VARCHAR(45) NOT NULL,
  `password` VARCHAR(45) NOT NULL,
  `nombre` VARCHAR(45) NOT NULL,
  `correo` VARCHAR(45) NOT NULL,
  `last_session` VARCHAR(45) NULL DEFAULT '0000-00-00 00:00:00',
  `id_tipo` VARCHAR(45) NULL DEFAULT NULL,
  PRIMARY KEY (`id`))ENGINE=InnoDB DEFAULT CHARSET=latin1;
  
DROP TABLE IF EXISTS `direcciones`;
CREATE TABLE `direcciones` (
  `idDir` varchar(50) NOT NULL,
  `Direccion` varchar(50) DEFAULT NULL,
  `Departamento` varchar(15) DEFAULT NULL,
  `Municipio` varchar(15) DEFAULT NULL,
  `codPostal` int DEFAULT NULL,
  PRIMARY KEY (`idDir`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

CREATE TABLE `correos` (
  `idCorreo` int NOT NULL,
  `Correo` varchar(20) DEFAULT NULL,
  PRIMARY KEY (`idCorreo`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;


CREATE TABLE `telefonos` (
  `idTelefono` int NOT NULL,
  `Telefono` varchar(15) DEFAULT NULL,
  PRIMARY KEY (`idTelefono`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

CREATE TABLE `alumno` (
  `idAlumno` int NOT NULL,
  `nombres` varchar(20) DEFAULT NULL,
  `Apellidos` varchar(20) DEFAULT NULL,
  `dpi` int DEFAULT NULL,
  `idDir` int DEFAULT NULL,
  `idCorreos` int DEFAULT NULL,
  `idTel` int DEFAULT NULL,
  PRIMARY KEY (`idAlumno`),
  KEY `idDir` (`idDir`),
  KEY `idCorreos` (`idCorreos`),
  KEY `idTel` (`idTel`),
  CONSTRAINT `alumno_ibfk_1` FOREIGN KEY (`idDir`) REFERENCES `direcciones` (`idDir`),
  CONSTRAINT `alumno_ibfk_2` FOREIGN KEY (`idCorreos`) REFERENCES `correos` (`idCorreo`),
  CONSTRAINT `alumno_ibfk_3` FOREIGN KEY (`idTel`) REFERENCES `telefonos` (`idTelefono`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

CREATE TABLE `edificio` (
  `idEdificio` int NOT NULL,
  `nombreEdificio` varchar(20) DEFAULT NULL,
  PRIMARY KEY (`idEdificio`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;



CREATE TABLE `aulas` (
  `idAula` int NOT NULL,
  `nombreAula` varchar(20) DEFAULT NULL,
  `idEdificio` int DEFAULT NULL,
  PRIMARY KEY (`idAula`),
  KEY `idEdificio` (`idEdificio`),
  CONSTRAINT `aulas_ibfk_1` FOREIGN KEY (`idEdificio`) REFERENCES `edificio` (`idEdificio`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;


CREATE TABLE `pensum` (
  `idPensum` int NOT NULL,
  `año` int DEFAULT NULL,
  PRIMARY KEY (`idPensum`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;


CREATE TABLE `jornada` (
  `idJornada` int NOT NULL,
  `jornada` varchar(20) DEFAULT NULL,
  PRIMARY KEY (`idJornada`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

CREATE TABLE `horarios` (
  `idHorario` int NOT NULL,
  `idJornada` int DEFAULT NULL,
  `dia` varchar(10) DEFAULT NULL,
  `hora` time DEFAULT NULL,
  PRIMARY KEY (`idHorario`),
  KEY `idJornada` (`idJornada`),
  CONSTRAINT `horarios_ibfk_1` FOREIGN KEY (`idJornada`) REFERENCES `jornada` (`idJornada`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

CREATE TABLE `cursos` (
  `idCurso` int NOT NULL,
  `nombre` varchar(20) DEFAULT NULL,
  `seccion` varchar(20) DEFAULT NULL,
  `idAula` int DEFAULT NULL,
  `prerequisito` int DEFAULT NULL,
  `idPensum` int DEFAULT NULL,
  `idHorario` int DEFAULT NULL,
  PRIMARY KEY (`idCurso`),
  KEY `idAula` (`idAula`),
  KEY `idPensum` (`idPensum`),
  KEY `idHorario` (`idHorario`),
  CONSTRAINT `cursos_ibfk_1` FOREIGN KEY (`idAula`) REFERENCES `aulas` (`idAula`),
  CONSTRAINT `cursos_ibfk_2` FOREIGN KEY (`idPensum`) REFERENCES `pensum` (`idPensum`),
  CONSTRAINT `cursos_ibfk_3` FOREIGN KEY (`idHorario`) REFERENCES `horarios` (`idHorario`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

CREATE TABLE `asignacionalumno` (
  `idAsignacion` int NOT NULL,
  `idAlumno` int DEFAULT NULL,
  `idCurso` int DEFAULT NULL,
  `fecha` date DEFAULT NULL,
  PRIMARY KEY (`idAsignacion`),
  KEY `idAlumno` (`idAlumno`),
  KEY `idCurso` (`idCurso`),
  CONSTRAINT `asignacionalumno_ibfk_1` FOREIGN KEY (`idAlumno`) REFERENCES `alumno` (`idAlumno`),
  CONSTRAINT `asignacionalumno_ibfk_2` FOREIGN KEY (`idCurso`) REFERENCES `cursos` (`idCurso`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

CREATE TABLE `catedratico` (
  `idCat` int NOT NULL,
  `nombres` varchar(50) NOT NULL,
  `apellidos` varchar(50) NOT NULL,
  `dpi`  varchar(50) NOT NULL,
  `idDir` varchar(50) NOT NULL,
  `idCorreo` varchar(50) NOT NULL,
  `idTel` varchar(50) NOT NULL,
  PRIMARY KEY (`idCat`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;



CREATE TABLE `asignacioncat` (
  `idAsignacion` int NOT NULL,
  `idCat` int DEFAULT NULL,
  `idCurso` int DEFAULT NULL,
  PRIMARY KEY (`idAsignacion`),
  KEY `idCat` (`idCat`),
  KEY `idCurso` (`idCurso`),
  CONSTRAINT `asignacioncat_ibfk_1` FOREIGN KEY (`idCat`) REFERENCES `catedratico` (`idCat`),
  CONSTRAINT `asignacioncat_ibfk_2` FOREIGN KEY (`idCurso`) REFERENCES `cursos` (`idCurso`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

CREATE TABLE `carrera` (
  `idCarrera` int NOT NULL,
  `idJornada` int DEFAULT NULL,
  `nombre` varchar(20) DEFAULT NULL,
  `idPensum` int DEFAULT NULL,
  PRIMARY KEY (`idCarrera`),
  KEY `idJornada` (`idJornada`),
  KEY `idPensum` (`idPensum`),
  CONSTRAINT `carrera_ibfk_1` FOREIGN KEY (`idJornada`) REFERENCES `jornada` (`idJornada`),
  CONSTRAINT `carrera_ibfk_2` FOREIGN KEY (`idPensum`) REFERENCES `pensum` (`idPensum`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;








CREATE TABLE `facultades` (
  `idfacultad` int NOT NULL,
  `nombre` varchar(20) DEFAULT NULL,
  `idJornada` int DEFAULT NULL,
  `idCarrera` int DEFAULT NULL,
  `idPensum` int DEFAULT NULL,
  PRIMARY KEY (`idfacultad`),
  KEY `idJornada` (`idJornada`),
  KEY `idCarrera` (`idCarrera`),
  KEY `idPensum` (`idPensum`),
  CONSTRAINT `facultades_ibfk_1` FOREIGN KEY (`idJornada`) REFERENCES `jornada` (`idJornada`),
  CONSTRAINT `facultades_ibfk_2` FOREIGN KEY (`idCarrera`) REFERENCES `carrera` (`idCarrera`),
  CONSTRAINT `facultades_ibfk_3` FOREIGN KEY (`idPensum`) REFERENCES `pensum` (`idPensum`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;





CREATE TABLE `laboratorios` (
  `idLab` int NOT NULL,
  `nombre` varchar(20) DEFAULT NULL,
  `idEdificio` int DEFAULT NULL,
  `idAula` int DEFAULT NULL,
  PRIMARY KEY (`idLab`),
  KEY `idEdificio` (`idEdificio`),
  KEY `idAula` (`idAula`),
  CONSTRAINT `laboratorios_ibfk_1` FOREIGN KEY (`idEdificio`) REFERENCES `edificio` (`idEdificio`),
  CONSTRAINT `laboratorios_ibfk_2` FOREIGN KEY (`idAula`) REFERENCES `aulas` (`idAula`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;




CREATE TABLE `sede` (
  `idSede` int NOT NULL,
  `nombre` varchar(15) DEFAULT NULL,
  `idEdificio` int DEFAULT NULL,
  PRIMARY KEY (`idSede`),
  KEY `idEdificio` (`idEdificio`),
  CONSTRAINT `sede_ibfk_1` FOREIGN KEY (`idEdificio`) REFERENCES `edificio` (`idEdificio`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;


CREATE TABLE `tesoreia` (
  `numBoleta` int NOT NULL AUTO_INCREMENT,
  `numtransaccion` int DEFAULT NULL,
  `codMovimiento` int NOT NULL,
  `total` int NOT NULL,
  `idEstudiante` int NOT NULL,
  PRIMARY KEY (`numBoleta`),
  KEY `idEstudiante` (`idEstudiante`),
  CONSTRAINT `tesoreia_ibfk_1` FOREIGN KEY (`idEstudiante`) REFERENCES `alumno` (`idAlumno`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;


CREATE TABLE `Listadoalumnoscurso` (
  `idlistado` int NOT NULL,
  `idAlumno` int NOT NULL,
  `nombres` varchar(20) NOT NULL,
  `apellidos` varchar(20) NOT NULL,
  `carnet` int NOT NULL,
  `semestre` int NOT NULL,
  `año` int NOT NULL,
  `idcarrera` int NOT NULL,
  `idfacultad` int NOT NULL,
  PRIMARY KEY (`idlistado`),
  KEY `idAlumno` (`idAlumno`),
  KEY `idcarrera` (`idcarrera`),
  KEY `idfacultades` (`idfacultad`),
  CONSTRAINT `Listadoalumnoscurso_ibfk_1` FOREIGN KEY (`idAlumno`) REFERENCES `alumno` (`idAlumno`),
  CONSTRAINT `Listadoalumnoscurso_ibfk_2` FOREIGN KEY (`idcarrera`) REFERENCES `Carrera` (`idcarrera`),
  CONSTRAINT `Listadoalumnoscurso_ibfk_3` FOREIGN KEY (`idfacultad`) REFERENCES `facultades` (`idfacultad`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

CREATE TABLE `Certificacion` (
  `idcertificacion` int NOT NULL,
  `idAlumno` int NOT NULL,
  `carnet` int NOT NULL,
  `semestre` int NOT NULL,
  `año` int NOT NULL,
  `idfacultad` int NOT NULL,
  PRIMARY KEY (`idfacultad`),
  KEY `idAlumno` (`idAlumno`),
  KEY `idCurso` (`idfacultad`),
  CONSTRAINT `Certificacion_ibfk_1` FOREIGN KEY (`idAlumno`) REFERENCES `alumno` (`idAlumno`),
  CONSTRAINT `Certificacion_ibfk_2` FOREIGN KEY (`idfacultad`) REFERENCES `facultades` (`idfacultad`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;


CREATE TABLE CursosAsignados (
	carnet int not null PRIMARY KEY,
    Nombres varchar(20) not null,
    Apellidos varchar(20) not null,
    Boleta_Pago_Numero int not null,
    Semestre_Trimestre int not null,
    Año int not null,
    Curso_1 varchar(40),
    Curso_2 varchar(40),
    Curso_3 varchar(40),
    Curso_4 varchar(40),
    Curso_5 varchar(40),
    Curso_Extraordinario_1 varchar(40),
    Curso_Extraordinario_2 varchar(40),
	Curso_Extraordinario_3 varchar(40)
)ENGINE=InnoDB DEFAULT CHARSET=latin1;


CREATE TABLE CursosDisponibles (
	IdAlumno INT NOT NULL PRIMARY KEY,
    Id_Curso1 varchar(5),
    Curso_1 varchar(40),
    Id_Curso2 varchar(5),
    Curso_2 varchar(40),
    Id_Curso3 varchar(5),
    Curso_3 varchar(40),
    Id_Curso4 varchar(5),
    Curso_4 varchar(40),
    Id_Curso5 varchar(5),
    Curso_5 varchar(40),
    Id_Curso_Ext1 varchar(5),
    Curso_Extraordinario_1 varchar(40),
    Id_Curso_Ext2 varchar(5),
    Curso_Extraordinario_2 varchar(40),
    Id_Curso_Ext3 varchar(5),
	Curso_Extraordinario_3 varchar(40)
)ENGINE=InnoDB DEFAULT CHARSET=latin1;


CREATE TABLE SecYHor (
	IdCurso int NOT NULL PRIMARY KEY,
    Curso varchar(20),
    Seccion_A varchar(30),
    Seccion_B varchar(30),
    Seccion_C varchar(30),
    Seccion_D varchar(30)
)ENGINE=InnoDB DEFAULT CHARSET=latin1;

CREATE TABLE IF NOT EXISTS `tbl_bitacora` (
  `PK_id_bitacora` INT NOT NULL AUTO_INCREMENT,
  `id` VARCHAR(25) NOT NULL,
  `fecha` VARCHAR(25)   NOT NULL,
  `hora` VARCHAR(25)  NOT NULL,
  `host1` VARCHAR(45)  NOT NULL,
  `ip` VARCHAR(25)  NOT NULL,
  `accion` VARCHAR(50)  NOT NULL,
  `tabla` VARCHAR(45)  NOT NULL,

PRIMARY KEY (`PK_id_bitacora`,`id`),

CONSTRAINT `bitacora_ibfk_1` FOREIGN KEY (`PK_id_bitacora`) REFERENCES `usuario` (`id`)

)ENGINE = InnoDB
DEFAULT CHARACTER SET = utf8;