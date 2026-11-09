-- =============================================
-- Script de base de datos: Parcial#2
-- Autor: Ian Nieto
-- Ejecutar completo en SQL Server Management Studio
-- =============================================

-- 1. Base de datos
IF DB_ID(N'Parcial#2') IS NULL
    CREATE DATABASE [Parcial#2];
GO

USE [Parcial#2];
GO

-- 2. Tabla de usuarios (Contra_U guarda el hash, nunca la contraseña)
CREATE TABLE usuario
(
    id         INT IDENTITY(1,1) PRIMARY KEY,
    Nombre_U   VARCHAR(50)  NOT NULL,
    Correo_U   VARCHAR(100) NOT NULL,
    Contra_U   VARCHAR(500) NOT NULL,
    Fecha_Crea DATETIME     NOT NULL DEFAULT GETDATE()
);
GO

-- 3. Procedimiento: registrar usuario
CREATE PROCEDURE sp_RegistroUsuario
    @Nombre_U VARCHAR(50),
    @Correo_U VARCHAR(100),
    @Contra_U VARCHAR(500)
AS
BEGIN
    SET NOCOUNT ON;
    IF EXISTS (SELECT 1 FROM usuario WHERE Nombre_U = @Nombre_U)
    BEGIN
        RAISERROR('Este nombre de usuario ya existe', 16, 1);
        RETURN;
    END
    INSERT INTO usuario (Nombre_U, Correo_U, Contra_U)
    VALUES (@Nombre_U, @Correo_U, @Contra_U);
END
GO

-- 4. Procedimiento: buscar usuario (para el login)
CREATE PROCEDURE sp_BusquedaUsuario
    @Nombre_U VARCHAR(50)
AS
BEGIN
    SET NOCOUNT ON;
    SELECT id, Nombre_U, Correo_U, Contra_U
    FROM usuario
    WHERE Nombre_U = @Nombre_U;
END
GO

-- 5. Procedimiento: cambiar contraseña
CREATE PROCEDURE sp_CambiarContrasena
    @Nombre_U VARCHAR(50),
    @Contra_U VARCHAR(500)
AS
BEGIN
    SET NOCOUNT ON;
    UPDATE usuario
    SET Contra_U = @Contra_U
    WHERE Nombre_U = @Nombre_U;
END
GO

-- 6. Login a nivel de servidor (cambia la contraseña por una tuya)
USE master;
GO
IF NOT EXISTS (SELECT 1 FROM sys.server_principals WHERE name = 'aplicacion')
    CREATE LOGIN aplicacion WITH PASSWORD = '1234';
GO

-- 7. Usuario de la base de datos con privilegios mínimos
USE [Parcial#2];
GO
CREATE USER aplicacion_parcial2 FOR LOGIN aplicacion;
GO
GRANT EXECUTE ON OBJECT::sp_RegistroUsuario   TO aplicacion_parcial2;
GRANT EXECUTE ON OBJECT::sp_BusquedaUsuario   TO aplicacion_parcial2;
GRANT EXECUTE ON OBJECT::sp_CambiarContrasena TO aplicacion_parcial2;
GO