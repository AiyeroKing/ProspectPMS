USE [master]
GO
/****** Object:  Database [ProspectPMS_DataBase]    Script Date: 2018/5/3 17:55:23 ******/
CREATE DATABASE [ProspectPMS_DataBase]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'ProspectPMS_DataBase', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL12.MSSQLSERVER\MSSQL\DATA\ProspectPMS_DataBase.mdf' , SIZE = 5120KB , MAXSIZE = UNLIMITED, FILEGROWTH = 1024KB )
 LOG ON 
( NAME = N'ProspectPMS_DataBase_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL12.MSSQLSERVER\MSSQL\DATA\ProspectPMS_DataBase_log.ldf' , SIZE = 1024KB , MAXSIZE = 2048GB , FILEGROWTH = 10%)
GO
ALTER DATABASE [ProspectPMS_DataBase] SET COMPATIBILITY_LEVEL = 120
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [ProspectPMS_DataBase].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [ProspectPMS_DataBase] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [ProspectPMS_DataBase] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [ProspectPMS_DataBase] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [ProspectPMS_DataBase] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [ProspectPMS_DataBase] SET ARITHABORT OFF 
GO
ALTER DATABASE [ProspectPMS_DataBase] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [ProspectPMS_DataBase] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [ProspectPMS_DataBase] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [ProspectPMS_DataBase] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [ProspectPMS_DataBase] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [ProspectPMS_DataBase] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [ProspectPMS_DataBase] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [ProspectPMS_DataBase] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [ProspectPMS_DataBase] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [ProspectPMS_DataBase] SET  DISABLE_BROKER 
GO
ALTER DATABASE [ProspectPMS_DataBase] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [ProspectPMS_DataBase] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [ProspectPMS_DataBase] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [ProspectPMS_DataBase] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [ProspectPMS_DataBase] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [ProspectPMS_DataBase] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [ProspectPMS_DataBase] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [ProspectPMS_DataBase] SET RECOVERY FULL 
GO
ALTER DATABASE [ProspectPMS_DataBase] SET  MULTI_USER 
GO
ALTER DATABASE [ProspectPMS_DataBase] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [ProspectPMS_DataBase] SET DB_CHAINING OFF 
GO
ALTER DATABASE [ProspectPMS_DataBase] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [ProspectPMS_DataBase] SET TARGET_RECOVERY_TIME = 0 SECONDS 
GO
ALTER DATABASE [ProspectPMS_DataBase] SET DELAYED_DURABILITY = DISABLED 
GO
EXEC sys.sp_db_vardecimal_storage_format N'ProspectPMS_DataBase', N'ON'
GO
USE [ProspectPMS_DataBase]
GO
/****** Object:  Table [dbo].[List_Login_UserMessage]    Script Date: 2018/5/3 17:55:23 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[List_Login_UserMessage](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[Login_UserID] [int] NULL,
	[Login_UserName] [nvarchar](50) NULL,
	[Login_UserPassword] [nvarchar](50) NULL,
	[Login_UserNickname] [nvarchar](50) NULL,
	[Login_UserVia] [nvarchar](max) NULL,
	[Login_UserTruename] [nvarchar](50) NULL,
	[Login_UserIdcard] [nvarchar](50) NULL,
	[Login_UserEmail] [nvarchar](20) NULL,
	[Login_UserPhone] [nvarchar](15) NULL,
	[Login_Userquestion] [nvarchar](100) NULL,
	[Login_UserAnswer] [nvarchar](100) NULL,
	[Login_UserSignatures] [nvarchar](300) NULL,
	[Login_UserSex] [nvarchar](5) NULL,
	[Login_UserBirthday] [date] NULL,
 CONSTRAINT [PK_List_Login_UserMessage] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
USE [master]
GO
ALTER DATABASE [ProspectPMS_DataBase] SET  READ_WRITE 
GO
