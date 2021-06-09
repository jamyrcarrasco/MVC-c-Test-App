USE [master]
GO

/****** Object:  Database [db_uepaticket]    Script Date: 6/9/2021 12:39:24 AM ******/
CREATE DATABASE [db_uepaticket]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'db_uepaticket', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.SQLEXPRESS\MSSQL\DATA\db_uepaticket.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'db_uepaticket_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.SQLEXPRESS\MSSQL\DATA\db_uepaticket_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
 WITH CATALOG_COLLATION = DATABASE_DEFAULT
GO

IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [db_uepaticket].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO

ALTER DATABASE [db_uepaticket] SET ANSI_NULL_DEFAULT OFF 
GO

ALTER DATABASE [db_uepaticket] SET ANSI_NULLS OFF 
GO

ALTER DATABASE [db_uepaticket] SET ANSI_PADDING OFF 
GO

ALTER DATABASE [db_uepaticket] SET ANSI_WARNINGS OFF 
GO

ALTER DATABASE [db_uepaticket] SET ARITHABORT OFF 
GO

ALTER DATABASE [db_uepaticket] SET AUTO_CLOSE ON 
GO

ALTER DATABASE [db_uepaticket] SET AUTO_SHRINK OFF 
GO

ALTER DATABASE [db_uepaticket] SET AUTO_UPDATE_STATISTICS ON 
GO

ALTER DATABASE [db_uepaticket] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO

ALTER DATABASE [db_uepaticket] SET CURSOR_DEFAULT  GLOBAL 
GO

ALTER DATABASE [db_uepaticket] SET CONCAT_NULL_YIELDS_NULL OFF 
GO

ALTER DATABASE [db_uepaticket] SET NUMERIC_ROUNDABORT OFF 
GO

ALTER DATABASE [db_uepaticket] SET QUOTED_IDENTIFIER OFF 
GO

ALTER DATABASE [db_uepaticket] SET RECURSIVE_TRIGGERS OFF 
GO

ALTER DATABASE [db_uepaticket] SET  ENABLE_BROKER 
GO

ALTER DATABASE [db_uepaticket] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO

ALTER DATABASE [db_uepaticket] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO

ALTER DATABASE [db_uepaticket] SET TRUSTWORTHY OFF 
GO

ALTER DATABASE [db_uepaticket] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO

ALTER DATABASE [db_uepaticket] SET PARAMETERIZATION SIMPLE 
GO

ALTER DATABASE [db_uepaticket] SET READ_COMMITTED_SNAPSHOT OFF 
GO

ALTER DATABASE [db_uepaticket] SET HONOR_BROKER_PRIORITY OFF 
GO

ALTER DATABASE [db_uepaticket] SET RECOVERY SIMPLE 
GO

ALTER DATABASE [db_uepaticket] SET  MULTI_USER 
GO

ALTER DATABASE [db_uepaticket] SET PAGE_VERIFY CHECKSUM  
GO

ALTER DATABASE [db_uepaticket] SET DB_CHAINING OFF 
GO

ALTER DATABASE [db_uepaticket] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO

ALTER DATABASE [db_uepaticket] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO

ALTER DATABASE [db_uepaticket] SET DELAYED_DURABILITY = DISABLED 
GO

ALTER DATABASE [db_uepaticket] SET QUERY_STORE = OFF
GO

ALTER DATABASE [db_uepaticket] SET  READ_WRITE 
GO
