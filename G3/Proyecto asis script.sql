-- MySQL Workbench Forward Engineering

SET @OLD_UNIQUE_CHECKS=@@UNIQUE_CHECKS, UNIQUE_CHECKS=0;
SET @OLD_FOREIGN_KEY_CHECKS=@@FOREIGN_KEY_CHECKS, FOREIGN_KEY_CHECKS=0;
SET @OLD_SQL_MODE=@@SQL_MODE, SQL_MODE='ONLY_FULL_GROUP_BY,STRICT_TRANS_TABLES,NO_ZERO_IN_DATE,NO_ZERO_DATE,ERROR_FOR_DIVISION_BY_ZERO,NO_ENGINE_SUBSTITUTION';

-- -----------------------------------------------------
-- Schema renta_videos
-- -----------------------------------------------------

-- -----------------------------------------------------
-- Schema renta_videos
-- -----------------------------------------------------
CREATE SCHEMA IF NOT EXISTS `renta_videos` DEFAULT CHARACTER SET utf8 ;
USE `renta_videos` ;

-- -----------------------------------------------------
-- Table `renta_videos`.`Clientes`
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS `renta_videos`.`Clientes` (
  `id_membresia` INT NOT NULL,
  `Nombre` VARCHAR(45) NOT NULL,
  `Direccion` VARCHAR(45) NOT NULL,
  `Telefono` INT NOT NULL,
  PRIMARY KEY (`id_membresia`))
ENGINE = InnoDB;


-- -----------------------------------------------------
-- Table `renta_videos`.`Tipo_pelicula`
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS `renta_videos`.`Tipo_pelicula` (
  `id_tipo_pelicula` INT NOT NULL AUTO_INCREMENT,
  `Nombre_pelicula` VARCHAR(30) NOT NULL,
  `Genero_pelicula` VARCHAR(30) NOT NULL,
  PRIMARY KEY (`id_tipo_pelicula`))
ENGINE = InnoDB;


-- -----------------------------------------------------
-- Table `renta_videos`.`Actor_principal`
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS `renta_videos`.`Actor_principal` (
  `id_actor_principal` INT NOT NULL AUTO_INCREMENT,
  `Nombre_actor` VARCHAR(30) NOT NULL,
  `Fecha_nacimiento` VARCHAR(30) NOT NULL,
  PRIMARY KEY (`id_actor_principal`))
ENGINE = InnoDB;


-- -----------------------------------------------------
-- Table `renta_videos`.`Registro_Peliculas`
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS `renta_videos`.`Registro_Peliculas` (
  `id_pelicula` INT NOT NULL AUTO_INCREMENT,
  `id_actor_principal` INT NOT NULL,
  `id_tipo_pelicula` INT NOT NULL,
  `Precio` FLOAT NOT NULL,
  `Disponibles` INT ZEROFILL NOT NULL,
  PRIMARY KEY (`id_pelicula`),
  INDEX `id_tipo_pelicula_idx` (`id_tipo_pelicula` ASC) VISIBLE,
  INDEX `id_actor_principal_idx` (`id_actor_principal` ASC) VISIBLE,
  CONSTRAINT `id_tipo_pelicula`
    FOREIGN KEY (`id_tipo_pelicula`)
    REFERENCES `renta_videos`.`Tipo_pelicula` (`id_tipo_pelicula`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION,
  CONSTRAINT `id_actor_principal`
    FOREIGN KEY (`id_actor_principal`)
    REFERENCES `renta_videos`.`Actor_principal` (`id_actor_principal`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION)
ENGINE = InnoDB;


-- -----------------------------------------------------
-- Table `renta_videos`.`Cassete`
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS `renta_videos`.`Cassete` (
  `id_Cassete` INT NOT NULL AUTO_INCREMENT,
  `Numero_copias` INT NOT NULL,
  `id_pelicula` INT NOT NULL,
  `Formato` VARCHAR(10) NOT NULL,
  PRIMARY KEY (`id_Cassete`),
  INDEX `id_pelicula_idx` (`id_pelicula` ASC) VISIBLE,
  CONSTRAINT `id_pelicula`
    FOREIGN KEY (`id_pelicula`)
    REFERENCES `renta_videos`.`Registro_Peliculas` (`id_pelicula`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION)
ENGINE = InnoDB;


-- -----------------------------------------------------
-- Table `renta_videos`.`Usuarios_Contraseñas`
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS `renta_videos`.`Usuarios_Contraseñas` (
  `id_empleado` INT NOT NULL,
  `Nombre` VARCHAR(30) NOT NULL,
  `Telefono` INT NOT NULL,
  `DPI` VARCHAR(45) NOT NULL,
  `Permisos` INT ZEROFILL NOT NULL,
  PRIMARY KEY (`id_empleado`))
ENGINE = InnoDB;


-- -----------------------------------------------------
-- Table `renta_videos`.`Registro_Rentas`
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS `renta_videos`.`Registro_Rentas` (
  `id_alquiler` INT NOT NULL AUTO_INCREMENT,
  `id_Cassete` INT NOT NULL,
  `id_membresia` INT NOT NULL,
  `Fecha_renta` VARCHAR(30) NOT NULL,
  `Fecha_devolucion` VARCHAR(30) NOT NULL,
  `Precio_alquiler` FLOAT NOT NULL,
  `Cantidad` INT NOT NULL,
  `id_empleado` INT NOT NULL,
  PRIMARY KEY (`id_alquiler`),
  INDEX `id_membresia_idx` (`id_membresia` ASC) VISIBLE,
  INDEX `id_Cassete_idx` (`id_Cassete` ASC) VISIBLE,
  INDEX `id_empleado_idx` (`id_empleado` ASC) VISIBLE,
  CONSTRAINT `id_membresia`
    FOREIGN KEY (`id_membresia`)
    REFERENCES `renta_videos`.`Clientes` (`id_membresia`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION,
  CONSTRAINT `id_Cassete`
    FOREIGN KEY (`id_Cassete`)
    REFERENCES `renta_videos`.`Cassete` (`id_Cassete`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION,
  CONSTRAINT `id_empleado`
    FOREIGN KEY (`id_empleado`)
    REFERENCES `renta_videos`.`Usuarios_Contraseñas` (`id_empleado`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION)
ENGINE = InnoDB;


-- -----------------------------------------------------
-- Table `renta_videos`.`Registro_Devolucion`
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS `renta_videos`.`Registro_Devolucion` (
  `id_Devolucion` INT NOT NULL,
  `id_pelicula` INT NOT NULL,
  `id_membresia` INT NOT NULL,
  `Devolucion` VARCHAR(45) NOT NULL,
  `telefono` INT NULL,
  PRIMARY KEY (`id_Devolucion`),
  INDEX `id_pelicula_idx` (`id_pelicula` ASC) VISIBLE,
  INDEX `id_membresia_idx` (`id_membresia` ASC) VISIBLE,
  CONSTRAINT `id_pelicula`
    FOREIGN KEY (`id_pelicula`)
    REFERENCES `renta_videos`.`Registro_Peliculas` (`id_pelicula`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION,
  CONSTRAINT `id_membresia`
    FOREIGN KEY (`id_membresia`)
    REFERENCES `renta_videos`.`Clientes` (`id_membresia`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION)
ENGINE = InnoDB;


SET SQL_MODE=@OLD_SQL_MODE;
SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS;
SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS;
