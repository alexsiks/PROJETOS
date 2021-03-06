USE [master]
GO

/****** Object:  Database [BD_CONTAS]    Script Date: 07/12/2020 18:30:52 ******/
CREATE DATABASE [BD_CONTAS] ON  PRIMARY 
( NAME = N'BD_CONTAS', FILENAME = N'c:\Program Files\Microsoft SQL Server\MSSQL10_50.SQLEXPRESS\MSSQL\DATA\BD_CONTAS.mdf' , SIZE = 2304KB , MAXSIZE = UNLIMITED, FILEGROWTH = 1024KB )
 LOG ON 
( NAME = N'BD_CONTAS_log', FILENAME = N'c:\Program Files\Microsoft SQL Server\MSSQL10_50.SQLEXPRESS\MSSQL\DATA\BD_CONTAS_log.LDF' , SIZE = 832KB , MAXSIZE = 2048GB , FILEGROWTH = 10%)
GO

ALTER DATABASE [BD_CONTAS] SET COMPATIBILITY_LEVEL = 100
GO

IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [BD_CONTAS].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO

ALTER DATABASE [BD_CONTAS] SET ANSI_NULL_DEFAULT OFF 
GO

ALTER DATABASE [BD_CONTAS] SET ANSI_NULLS OFF 
GO

ALTER DATABASE [BD_CONTAS] SET ANSI_PADDING OFF 
GO

ALTER DATABASE [BD_CONTAS] SET ANSI_WARNINGS OFF 
GO

ALTER DATABASE [BD_CONTAS] SET ARITHABORT OFF 
GO

ALTER DATABASE [BD_CONTAS] SET AUTO_CLOSE ON 
GO

ALTER DATABASE [BD_CONTAS] SET AUTO_CREATE_STATISTICS ON 
GO

ALTER DATABASE [BD_CONTAS] SET AUTO_SHRINK OFF 
GO

ALTER DATABASE [BD_CONTAS] SET AUTO_UPDATE_STATISTICS ON 
GO

ALTER DATABASE [BD_CONTAS] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO

ALTER DATABASE [BD_CONTAS] SET CURSOR_DEFAULT  GLOBAL 
GO

ALTER DATABASE [BD_CONTAS] SET CONCAT_NULL_YIELDS_NULL OFF 
GO

ALTER DATABASE [BD_CONTAS] SET NUMERIC_ROUNDABORT OFF 
GO

ALTER DATABASE [BD_CONTAS] SET QUOTED_IDENTIFIER OFF 
GO

ALTER DATABASE [BD_CONTAS] SET RECURSIVE_TRIGGERS OFF 
GO

ALTER DATABASE [BD_CONTAS] SET  ENABLE_BROKER 
GO

ALTER DATABASE [BD_CONTAS] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO

ALTER DATABASE [BD_CONTAS] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO

ALTER DATABASE [BD_CONTAS] SET TRUSTWORTHY OFF 
GO

ALTER DATABASE [BD_CONTAS] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO

ALTER DATABASE [BD_CONTAS] SET PARAMETERIZATION SIMPLE 
GO

ALTER DATABASE [BD_CONTAS] SET READ_COMMITTED_SNAPSHOT OFF 
GO

ALTER DATABASE [BD_CONTAS] SET HONOR_BROKER_PRIORITY OFF 
GO

ALTER DATABASE [BD_CONTAS] SET  READ_WRITE 
GO

ALTER DATABASE [BD_CONTAS] SET RECOVERY SIMPLE 
GO

ALTER DATABASE [BD_CONTAS] SET  MULTI_USER 
GO

ALTER DATABASE [BD_CONTAS] SET PAGE_VERIFY CHECKSUM  
GO

ALTER DATABASE [BD_CONTAS] SET DB_CHAINING OFF 
GO

