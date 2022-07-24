SET @OLD_UNIQUE_CHECKS=@@UNIQUE_CHECKS, UNIQUE_CHECKS=0;
SET @OLD_FOREIGN_KEY_CHECKS=@@FOREIGN_KEY_CHECKS, FOREIGN_KEY_CHECKS=0;
SET @OLD_SQL_MODE=@@SQL_MODE, SQL_MODE='ONLY_FULL_GROUP_BY,STRICT_TRANS_TABLES,NO_ZERO_IN_DATE,NO_ZERO_DATE,ERROR_FOR_DIVISION_BY_ZERO,NO_ENGINE_SUBSTITUTION';

DROP SCHEMA IF EXISTS `RepartoBD`;
CREATE SCHEMA IF NOT EXISTS `RepartoBD` DEFAULT CHARACTER SET utf8 ;
USE `RepartoBD` ;

-- AREA ADMINISTRATIVA
-- -----------------------------------------------------
-- Table `RepartoBD`.`Modulos`
-- -----------------------------------------------------
DROP TABLE IF EXISTS `RepartoBD`.`Modulos`;
CREATE TABLE IF NOT EXISTS `RepartoBD`.`Modulos` (
  `pkidmodulos` INT NOT NULL,
  `Nommod` VARCHAR(45) NULL DEFAULT NULL,
  `Descmod` VARCHAR(200) NULL DEFAULT NULL,
  `Estmod` TINYINT NULL DEFAULT NULL,
  PRIMARY KEY (`pkidmodulos`)
) ENGINE = InnoDB DEFAULT CHARACTER SET = utf8;
INSERT INTO `RepartoBD`.`Modulos` VALUES 
('0000', 'administracion', 'modulo relacionado a la administración', '1'),('1000', 'repartos', 'modulo relacionado a ayuda de información de los repartidores', '1'),('2000', 'clientes', 'modulo relacionado a la información del pedido sobre el cliente', '1');
-- -----------------------------------------------------
-- Table `RepartoBD`.`Aplicaciones`
-- -----------------------------------------------------
DROP TABLE IF EXISTS `RepartoBD`.`Aplicaciones`;
CREATE TABLE IF NOT EXISTS `RepartoBD`.`Aplicaciones` (
  `pkidaplicaciones` INT AUTO_INCREMENT NOT NULL,
  `Nomapp` VARCHAR(50) NOT NULL,
  `Descapp` VARCHAR(100) NOT NULL,
  `Estapp` TINYINT DEFAULT 0 NOT NULL,
  PRIMARY KEY (`pkidaplicaciones`)
) ENGINE = InnoDB DEFAULT CHARACTER SET = utf8;
INSERT INTO `Aplicaciones` VALUES 
('0001', 'CONTENEDOR ADMINISTRACIÓN', 'MDI área de administración', '1'),
('0002', 'CONTENEDOR CLIENTES', 'MDI área de clientes', '1'),
('0003', 'CONTENEDOR TRABAJADORES', 'MDI área de trabajadores', '1'),
('0004', 'Mantenimiento de modulos', 'Mantenimiento para el área de administración', '1'),
('0005', 'Mantenimiento de aplicaciones', 'Mantenimiento para el área de administración', '1'),
('0006', 'Mantenimiento de usuarios', 'Mantenimiento para el área de administración', '1'),
('0007', 'Mantenimiento de trabajadores', 'Mantenimiento para el área de administración', '1'),
('0008', 'Mantenimiento de puestos de trabajo', 'Mantenimiento para el área de administración', '1'),
('0009', 'Mantenimiento de vehiculos', 'Mantenimiento para el área de administración', '1'),
('0010', 'Mantenimiento de bodega', 'Mantenimiento para el área de administración', '1'),
('0011', 'Mantenimiento de clientes', 'Mantenimiento para el área de clientes', '1'),
('0030', 'Asignacion de usuarios a aplicacion', 'Proceso para el área de administración', '1'),
('0031', 'Asignacion de trabajadores a aplicacion', 'Proceso para el área de administración', '1');
-- -----------------------------------------------------
-- Table `RepartoBD`.`Asignacion_Modulo_Aplicacion`
-- -----------------------------------------------------
DROP TABLE IF EXISTS `RepartoBD`.`Asignacion_Modulo_Aplicacion`;
CREATE TABLE IF NOT EXISTS `RepartoBD`.`Asignacion_Modulo_Aplicacion` (
  `pkidasignacion` INT AUTO_INCREMENT NOT NULL,
  `fpkidmodulo` INT NOT NULL,
  `fpkidaplicacion` INT NOT NULL, 
  PRIMARY KEY (`pkidasignacion`),
  FOREIGN KEY (`fpkidmodulo`) REFERENCES `RepartoBD`.`Modulos` (`pkidmodulos`),
  FOREIGN KEY (`fpkidaplicacion`) REFERENCES `RepartoBD`.`Aplicaciones` (`pkidaplicaciones`)
) ENGINE = InnoDB DEFAULT CHARACTER SET = utf8;
-- -----------------------------------------------------
-- Table `RepartoBD`.`Usuarios`
-- -----------------------------------------------------
DROP TABLE IF EXISTS `RepartoBD`.`Usuarios`;
CREATE TABLE IF NOT EXISTS `RepartoBD`.`Usuarios` (
  `pkidusuarios` INT AUTO_INCREMENT NOT NULL,
  `Nomuser` VARCHAR(50) NOT NULL,
  `Apelluser` VARCHAR(50) NOT NULL,
  `Username` VARCHAR(20) NOT NULL,
  `Password` VARCHAR(50) NOT NULL,
  `Emailuser` VARCHAR(50) NOT NULL,
  `Ultimacuser` DATETIME NULL DEFAULT NULL,
  `Estuser` TINYINT DEFAULT 0 NOT NULL,
  PRIMARY KEY (`pkidusuarios`)
) ENGINE = InnoDB DEFAULT CHARACTER SET = utf8;
INSERT INTO `Usuarios` VALUES 
('1', 'admin', 'admin', 'admin', 'MTIzNDU=', 'esduardo@gmail.com', '2022-07-02 21:00:48', '1'),('2', 'leonel', 'dominguez', 'laionel', 'MTIzNDU=', 'leonel@gmail.com', '2022-07-02 21:00:48', '1'),('3', 'luis', 'lee', 'luisk', 'MTIzNDU=', 'luisg@gmail.com', '2022-07-02 21:00:48', '1');
-- -----------------------------------------------------
-- Table `RepartoBD`.`Usuario_aplicacion`
-- -----------------------------------------------------
DROP TABLE IF EXISTS `RepartoBD`.`Asignacion_Usuario_aplicacion`;
CREATE TABLE IF NOT EXISTS `RepartoBD`.`Asignacion_Usuario_aplicacion` (
  `fpkidusuario` INT NOT NULL,
  `fpkidaplicacion` INT NOT NULL,
  `Ingresarua` TINYINT DEFAULT 0 NOT NULL,
  `Consultarua` TINYINT DEFAULT 0 NOT NULL,
  `Modificarua` TINYINT DEFAULT 0 NOT NULL,
  `Eliminarua` TINYINT DEFAULT 0 NOT NULL,
  PRIMARY KEY (`fpkidusuario`, `fpkidaplicacion`),
  FOREIGN KEY (`fpkidaplicacion`) REFERENCES `RepartoBD`.`Aplicaciones` (`pkidaplicaciones`),
  FOREIGN KEY (`fpkidusuario`) REFERENCES `RepartoBD`.`Usuarios` (`pkidusuarios`)
) ENGINE = InnoDB DEFAULT CHARACTER SET = utf8;
INSERT INTO `Asignacion_Usuario_aplicacion` VALUES 
('1', '0001', '1', '1', '1', '1'),('1', '0002', '1', '1', '1', '1'),('1', '0003', '1', '1', '1', '1'),('1', '0030', '1', '1', '1', '1'),
('2', '0001', '0', '0', '0', '0'),('2', '0002', '0', '0', '0', '0'),('2', '0003', '0', '0', '0', '0'),('2', '0004', '0', '0', '0', '0'),('2', '0005', '0', '0', '0', '0'),('2', '0006', '0', '0', '0', '0'),('2', '0007', '0', '0', '0', '0'),('2', '0008', '0', '0', '0', '0'),('2', '0009', '0', '0', '0', '0'),('2', '0010', '0', '0', '0', '0'),('2', '0011', '0', '0', '0', '0'),('2', '0030', '0', '0', '0', '0'),('2', '0031', '0', '0', '0', '0'),
('3', '0001', '1', '1', '0', '0'),('3', '0002', '0', '1', '1', '0'),('3', '0003', '0', '1', '0', '1'),('3', '0004', '1', '1', '1', '1'),('3', '0005', '0', '0', '0', '0'),('3', '0006', '0', '0', '0', '0');
-- -----------------------------------------------------
-- Table `RepartoBD`.`Puestos_trabajo`
-- -----------------------------------------------------
DROP TABLE IF EXISTS `RepartoBD`.`Puestos_trabajo`;
CREATE TABLE IF NOT EXISTS `RepartoBD`.`Puestos_trabajo` (
  `pkidpuestotrabajo` INT AUTO_INCREMENT NOT NULL,
  `Nompt` VARCHAR(50) NOT NULL,
  `Descpt` VARCHAR(100) NOT NULL,
  `Estpt` TINYINT DEFAULT 0 NOT NULL,
  PRIMARY KEY (`pkidpuestotrabajo`)
) ENGINE = InnoDB DEFAULT CHARACTER SET = utf8;
INSERT INTO `puestos_trabajo` VALUES 
('1', 'Piloto', 'Conductor de Vehiculos', '1'), ('2', 'Repartidor', 'Repartidor de pedidos', '1'), ('3', 'Encargado de bodega', 'Administra los pedidos que salen', '1'), ('4', 'Encargado de vehiculos', 'Asigna trabajadores a vehiculos y crea rutas', '1');
-- -----------------------------------------------------
-- Table `RepartoBD`.`Trabajadores`
-- -----------------------------------------------------
DROP TABLE IF EXISTS `RepartoBD`.`Trabajadores`;
CREATE TABLE IF NOT EXISTS `RepartoBD`.`Trabajadores` (
  `pkidtrabajador` INT AUTO_INCREMENT NOT NULL,
  `fkidpuestotrabajo` INT NOT NULL,
  `Nomtbd` VARCHAR(50) NOT NULL,
  `Apelltbd` VARCHAR(50) NOT NULL,
  `Usernametbd` VARCHAR(20) NOT NULL,
  `Passwordtbd` VARCHAR(50) NOT NULL,
  `Emailtbd` VARCHAR(50) NOT NULL,
  `Ultimactbd` DATETIME NULL DEFAULT NULL,
  `Esttbd` TINYINT DEFAULT 0 NOT NULL,
  PRIMARY KEY (`pkidtrabajador`),
  FOREIGN KEY (`fkidpuestotrabajo`) REFERENCES `RepartoBD`.`Puestos_trabajo` (`pkidpuestotrabajo`)
) ENGINE = InnoDB DEFAULT CHARACTER SET = utf8;
INSERT INTO `trabajadores` VALUES 
('1', '1', 'Juan', 'Perez', 'iamjp', 'MTIzNDU=', 'jp@gmail.com', '2022-07-22 20:26:01.000000', '1'), 
('2', '2', 'Jose', 'Carlos', 'JoseCa', 'MTIzNDU=', 'jc@hotmail.com', '2022-07-22 20:26:01.000000', '1'), 
('3', '3', 'Sandra', 'Tores', 'jandrita', 'MTIzNDU=', 'st@hotmail.com', '2022-07-22 20:26:01.000000', '1'), 
('4', '4', 'Sury', 'Rios', 'suryrios1', 'MTIzNDU=', 'sr@hotmail.com', '2022-07-22 20:26:01.000000', '1'); 
-- -----------------------------------------------------
-- Table `RepartoBD`.`Vehiculos`
-- -----------------------------------------------------
DROP TABLE IF EXISTS `RepartoBD`.`Vehiculos`;
CREATE TABLE IF NOT EXISTS `RepartoBD`.`Vehiculos` (
  `pkidvehiculo` INT AUTO_INCREMENT NOT NULL,
  `Placavhc` VARCHAR(10) NOT NULL,
  `Marcavhc` VARCHAR(20) NOT NULL,
  `Modelovhc` VARCHAR(20) NOT NULL,
  `Añovhc` INT NOT NULL,
  `Colorvhc` VARCHAR(20) NOT NULL,
  `CapaMaxvhc` FLOAT NOT NULL,
  `Estvhc` TINYINT DEFAULT 0 NOT NULL,
  PRIMARY KEY (`pkidvehiculo`)
) ENGINE = InnoDB DEFAULT CHARACTER SET = utf8;
-- -----------------------------------------------------
-- Table `RepartoBD`.`Bodegas`
-- -----------------------------------------------------
DROP TABLE IF EXISTS `RepartoBD`.`Bodegas`;
CREATE TABLE IF NOT EXISTS `RepartoBD`.`Bodegas` (
  `pkidbodega` INT AUTO_INCREMENT NOT NULL,
  `fkidencargado` INT NOT NULL, 
  `Direcbdg` VARCHAR(100) NOT NULL,
  `Capabdg` FLOAT NOT NULL,
  `CapaMaxbdg` FLOAT NOT NULL,
  `Estbdg` TINYINT DEFAULT 0 NOT NULL,
  PRIMARY KEY (`pkidbodega`),
  FOREIGN KEY (`fkidencargado`) REFERENCES `RepartoBD`.`Trabajadores` (`pkidtrabajador`)
) ENGINE = InnoDB DEFAULT CHARACTER SET = utf8;
-- -----------------------------------------------------
-- Table `RepartoBD`.`Asignacion_Chofer_Vehiculo`
-- -----------------------------------------------------
DROP TABLE IF EXISTS `RepartoBD`.`Asignacion_Chofer_Vehiculo`;
CREATE TABLE IF NOT EXISTS `RepartoBD`.`Asignacion_Chofer_Vehiculo` (
  `fpkidchofer` INT NOT NULL,
  `fpkidvehiculo` INT NOT NULL, 
  PRIMARY KEY (`fpkidchofer`, `fpkidvehiculo`),
  FOREIGN KEY (`fpkidchofer`) REFERENCES `RepartoBD`.`Trabajadores` (`pkidtrabajador`),
  FOREIGN KEY (`fpkidvehiculo`) REFERENCES `RepartoBD`.`Vehiculos` (`pkidvehiculo`)
) ENGINE = InnoDB DEFAULT CHARACTER SET = utf8;
-- -----------------------------------------------------
-- Table `RepartoBD`.`Trabajadores_Aplicacion`
-- -----------------------------------------------------
DROP TABLE IF EXISTS `RepartoBD`.`Asignacion_Trabajador_Apliacion`;
CREATE TABLE IF NOT EXISTS `RepartoBD`.`Asignacion_Trabajador_Apliacion` (
  `fpkidtrabajador` INT NOT NULL,
  `fpkidaplicacion` INT NOT NULL,
  `Ingresarca` TINYINT DEFAULT 0 NOT NULL,
  `Consultarca` TINYINT DEFAULT 0 NOT NULL,
  `Modificarca` TINYINT DEFAULT 0 NOT NULL,
  `Eliminarca` TINYINT DEFAULT 0 NOT NULL,
  PRIMARY KEY (`fpkidtrabajador`, `fpkidaplicacion`),
  FOREIGN KEY (`fpkidaplicacion`) REFERENCES `RepartoBD`.`Aplicaciones` (`pkidaplicaciones`),
  FOREIGN KEY (`fpkidtrabajador`) REFERENCES `RepartoBD`.`Trabajadores` (`pkidtrabajador`)
) ENGINE = InnoDB DEFAULT CHARACTER SET = utf8;
-- -----------------------------------------------------
-- Table `RepartoBD`.`Clientes`
-- -----------------------------------------------------
DROP TABLE IF EXISTS `RepartoBD`.`Clientes`;
CREATE TABLE IF NOT EXISTS `RepartoBD`.`Clientes` (
  `pkidcliente` INT AUTO_INCREMENT NOT NULL,
  `Nomcte` VARCHAR(50) NOT NULL,
  `Passwordcte` VARCHAR(50) NOT NULL,
  `Emailcte` VARCHAR(50) NOT NULL,
  `Telcte` INT NOT NULL,
  `Estcte` TINYINT DEFAULT 0 NOT NULL,
  PRIMARY KEY (`pkidcliente`)
) ENGINE = InnoDB DEFAULT CHARACTER SET = utf8;
-- -----------------------------------------------------
-- Table `RepartoBD`.`Pedidos`
-- -----------------------------------------------------
DROP TABLE IF EXISTS `RepartoBD`.`Pedidos`;
CREATE TABLE IF NOT EXISTS `RepartoBD`.`Pedidos` (
  `pkidpedido` INT AUTO_INCREMENT NOT NULL,
  `fpkidcliente` INT NOT NULL,
  `fechapdd` DATETIME NOT NULL,
  `Rempdd` VARCHAR(100) NOT NULL,
  `Destpdd` VARCHAR(100) NOT NULL,
  `Zonapdd` INT NOT NULL,
  `Nompdd` VARCHAR(100) NOT NULL,
  `Telpdd` INT NOT NULL,
  `Tampdd` INT NOT NULL,
  `Estpdd` TINYINT DEFAULT 0 NOT NULL,
  PRIMARY KEY (`pkidpedido`),
  FOREIGN KEY (`fpkidcliente`) REFERENCES `RepartoBD`.`Clientes` (`pkidcliente`)
) ENGINE = InnoDB DEFAULT CHARACTER SET = utf8;
-- -----------------------------------------------------
-- Table `RepartoBD`.`Rutas_Remitente`
-- -----------------------------------------------------
DROP TABLE IF EXISTS `RepartoBD`.`Rutas_Remitente`;
CREATE TABLE IF NOT EXISTS `RepartoBD`.`Rutas_Remitente` (
  `pkidruta` INT AUTO_INCREMENT NULL,
  `fkvehiculo` INT NOT NULL,
  `Estrr` TINYINT DEFAULT 0 NOT NULL,
  PRIMARY KEY (`pkidruta`),
  FOREIGN KEY (`fkvehiculo`) REFERENCES `RepartoBD`.`Vehiculos` (`pkidvehiculo`)
) ENGINE = InnoDB DEFAULT CHARACTER SET = utf8;
-- -----------------------------------------------------
-- Table `RepartoBD`.`Asignacion_Ruta_Pedido`
-- -----------------------------------------------------
DROP TABLE IF EXISTS `RepartoBD`.`Asignacion_Ruta_Pedido`;
CREATE TABLE IF NOT EXISTS `RepartoBD`.`Asignacion_Ruta_Pedido` (
  `pkidasignacion` INT AUTO_INCREMENT NOT NULL,
  `fpkidruta` INT NOT NULL,
  `fpkidpedido` INT NOT NULL,
  PRIMARY KEY (`pkidasignacion`),
  FOREIGN KEY (`fpkidruta`) REFERENCES `RepartoBD`.`Rutas_Remitente` (`pkidruta`),
  FOREIGN KEY (`fpkidpedido`) REFERENCES `RepartoBD`.`Pedidos` (`pkidpedido`)
) ENGINE = InnoDB DEFAULT CHARACTER SET = utf8;
-- -----------------------------------------------------
-- Table `RepartoBD`.`Almacenamiento_Pedidos`
-- -----------------------------------------------------
DROP TABLE IF EXISTS `RepartoBD`.`Almacenamiento_Pedidos`;
CREATE TABLE IF NOT EXISTS `RepartoBD`.`Almacenamiento_Pedidos` (
  `pkidalmacenamiento` INT AUTO_INCREMENT NOT NULL,
  `fkidasignacion` INT NOT NULL,
  `fkidbodega` INT NOT NULL,
  `Estalm` TINYINT DEFAULT 0 NOT NULL,
  PRIMARY KEY (`pkidalmacenamiento`),
  FOREIGN KEY (`fkidasignacion`) REFERENCES `RepartoBD`.`Asignacion_Ruta_Pedido` (`pkidasignacion`),
  FOREIGN KEY (`fkidbodega`) REFERENCES `RepartoBD`.`Bodegas` (`pkidbodega`)
) ENGINE = InnoDB DEFAULT CHARACTER SET = utf8;
-- -----------------------------------------------------
-- Table `RepartoBD`.`Rutas_Destinatario`
-- -----------------------------------------------------
DROP TABLE IF EXISTS `RepartoBD`.`Rutas_Destinatario`;
CREATE TABLE IF NOT EXISTS `RepartoBD`.`Rutas_Destinatario` (
  `pkidruta` INT AUTO_INCREMENT NULL,
  `fkvehiculo` INT NOT NULL,
  `Estrd` TINYINT DEFAULT 0 NOT NULL,
  PRIMARY KEY (`pkidruta`),
  FOREIGN KEY (`fkvehiculo`) REFERENCES `RepartoBD`.`Vehiculos` (`pkidvehiculo`)
) ENGINE = InnoDB DEFAULT CHARACTER SET = utf8;
-- -----------------------------------------------------
-- Table `RepartoBD`.`Asignacion_Ruta_Entrega`
-- -----------------------------------------------------
DROP TABLE IF EXISTS `RepartoBD`.`Asignacion_Ruta_Entrega`;
CREATE TABLE IF NOT EXISTS `RepartoBD`.`Asignacion_Ruta_Entrega` (
  `pkidasignacion` INT AUTO_INCREMENT NOT NULL,
  `fpkidruta` INT NOT NULL,
  `fpkidalmacenamiento` INT NOT NULL,
  PRIMARY KEY (`pkidasignacion`),
  FOREIGN KEY (`fpkidruta`) REFERENCES `RepartoBD`.`Rutas_Destinatario` (`pkidruta`),
  FOREIGN KEY (`fpkidalmacenamiento`) REFERENCES `RepartoBD`.`Almacenamiento_Pedidos` (`pkidalmacenamiento`)
) ENGINE = InnoDB DEFAULT CHARACTER SET = utf8;
-- -----------------------------------------------------
-- Table `RepartoBD`.`Entregas`
-- -----------------------------------------------------
DROP TABLE IF EXISTS `RepartoBD`.`Entregas`;
CREATE TABLE IF NOT EXISTS `RepartoBD`.`Entregas` (
  `pkidasignacion` INT NOT NULL,
  `Estent` INT NOT NULL,
  PRIMARY KEY (`pkidasignacion`),
  FOREIGN KEY (`pkidasignacion`) REFERENCES `RepartoBD`.`Asignacion_Ruta_Entrega` (`pkidasignacion`)
) ENGINE = InnoDB DEFAULT CHARACTER SET = utf8;
-- -----------------------------------------------------
-- Table `RepartoBD`.`Bitacora`
-- -----------------------------------------------------
DROP TABLE IF EXISTS `RepartoBD`.`Bitacora`;
CREATE TABLE IF NOT EXISTS `RepartoBD`.`Bitacora` (
  `pkidbitacora` INT AUTO_INCREMENT NOT NULL,
  `fkidusuario` INT NOT NULL,
  `Fechabtc` DATE NOT NULL,
  `Horabtc` TIME NOT NULL,
  `Hostbtc` VARCHAR(45) NOT NULL,
  `Ipbtc` VARCHAR(25) NOT NULL,
  `Accionbtc` VARCHAR(10) NOT NULL,
  `fkappbtc` INT NOT NULL,
  PRIMARY KEY (`pkidbitacora`),
  FOREIGN KEY (`fkidusuario`) REFERENCES `RepartoBD`.`Usuarios` (`pkidusuarios`),
  FOREIGN KEY (`fkappbtc`) REFERENCES `RepartoBD`.`Aplicaciones` (`pkidaplicaciones`)
)ENGINE = InnoDB DEFAULT CHARACTER SET = utf8;