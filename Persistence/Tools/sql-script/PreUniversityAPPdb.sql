USE [master]
GO

/****** Object:  Database [PreUniversityAPP]    Script Date: 1/31/2022 11:11:44 PM ******/
CREATE DATABASE [PreUniversityAPP]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'PreUniversityAPP', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.MSSQLSERVER\MSSQL\DATA\PreUniversityAPP.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'PreUniversityAPP_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.MSSQLSERVER\MSSQL\DATA\PreUniversityAPP_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
 WITH CATALOG_COLLATION = DATABASE_DEFAULT
GO

IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [PreUniversityAPP].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO

ALTER DATABASE [PreUniversityAPP] SET ANSI_NULL_DEFAULT OFF 
GO

ALTER DATABASE [PreUniversityAPP] SET ANSI_NULLS OFF 
GO

ALTER DATABASE [PreUniversityAPP] SET ANSI_PADDING OFF 
GO

ALTER DATABASE [PreUniversityAPP] SET ANSI_WARNINGS OFF 
GO

ALTER DATABASE [PreUniversityAPP] SET ARITHABORT OFF 
GO

ALTER DATABASE [PreUniversityAPP] SET AUTO_CLOSE OFF 
GO

ALTER DATABASE [PreUniversityAPP] SET AUTO_SHRINK OFF 
GO

ALTER DATABASE [PreUniversityAPP] SET AUTO_UPDATE_STATISTICS ON 
GO

ALTER DATABASE [PreUniversityAPP] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO

ALTER DATABASE [PreUniversityAPP] SET CURSOR_DEFAULT  GLOBAL 
GO

ALTER DATABASE [PreUniversityAPP] SET CONCAT_NULL_YIELDS_NULL OFF 
GO

ALTER DATABASE [PreUniversityAPP] SET NUMERIC_ROUNDABORT OFF 
GO

ALTER DATABASE [PreUniversityAPP] SET QUOTED_IDENTIFIER OFF 
GO

ALTER DATABASE [PreUniversityAPP] SET RECURSIVE_TRIGGERS OFF 
GO

ALTER DATABASE [PreUniversityAPP] SET  ENABLE_BROKER 
GO

ALTER DATABASE [PreUniversityAPP] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO

ALTER DATABASE [PreUniversityAPP] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO

ALTER DATABASE [PreUniversityAPP] SET TRUSTWORTHY OFF 
GO

ALTER DATABASE [PreUniversityAPP] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO

ALTER DATABASE [PreUniversityAPP] SET PARAMETERIZATION SIMPLE 
GO

ALTER DATABASE [PreUniversityAPP] SET READ_COMMITTED_SNAPSHOT ON 
GO

ALTER DATABASE [PreUniversityAPP] SET HONOR_BROKER_PRIORITY OFF 
GO

ALTER DATABASE [PreUniversityAPP] SET RECOVERY FULL 
GO

ALTER DATABASE [PreUniversityAPP] SET  MULTI_USER 
GO

ALTER DATABASE [PreUniversityAPP] SET PAGE_VERIFY CHECKSUM  
GO

ALTER DATABASE [PreUniversityAPP] SET DB_CHAINING OFF 
GO

ALTER DATABASE [PreUniversityAPP] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO

ALTER DATABASE [PreUniversityAPP] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO

ALTER DATABASE [PreUniversityAPP] SET DELAYED_DURABILITY = DISABLED 
GO

ALTER DATABASE [PreUniversityAPP] SET QUERY_STORE = OFF
GO

ALTER DATABASE [PreUniversityAPP] SET  READ_WRITE 
GO

