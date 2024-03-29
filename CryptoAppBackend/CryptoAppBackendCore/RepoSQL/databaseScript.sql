USE [master]
GO
/****** Object:  Database [CryptoDB]    Script Date: 07.02.2022 20:22:28 ******/
CREATE DATABASE [CryptoDB]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'CryptoDB', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.MSSQLSERVER\MSSQL\DATA\CryptoDB.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'CryptoDB_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.MSSQLSERVER\MSSQL\DATA\CryptoDB_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
 WITH CATALOG_COLLATION = DATABASE_DEFAULT
GO
ALTER DATABASE [CryptoDB] SET COMPATIBILITY_LEVEL = 150
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [CryptoDB].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [CryptoDB] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [CryptoDB] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [CryptoDB] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [CryptoDB] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [CryptoDB] SET ARITHABORT OFF 
GO
ALTER DATABASE [CryptoDB] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [CryptoDB] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [CryptoDB] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [CryptoDB] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [CryptoDB] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [CryptoDB] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [CryptoDB] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [CryptoDB] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [CryptoDB] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [CryptoDB] SET  DISABLE_BROKER 
GO
ALTER DATABASE [CryptoDB] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [CryptoDB] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [CryptoDB] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [CryptoDB] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [CryptoDB] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [CryptoDB] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [CryptoDB] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [CryptoDB] SET RECOVERY FULL 
GO
ALTER DATABASE [CryptoDB] SET  MULTI_USER 
GO
ALTER DATABASE [CryptoDB] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [CryptoDB] SET DB_CHAINING OFF 
GO
ALTER DATABASE [CryptoDB] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [CryptoDB] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [CryptoDB] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [CryptoDB] SET ACCELERATED_DATABASE_RECOVERY = OFF  
GO
EXEC sys.sp_db_vardecimal_storage_format N'CryptoDB', N'ON'
GO
ALTER DATABASE [CryptoDB] SET QUERY_STORE = OFF
GO
USE [CryptoDB]
GO
/****** Object:  Table [dbo].[EthereumFakeData]    Script Date: 07.02.2022 20:22:28 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[EthereumFakeData](
	[ID] [int] NOT NULL,
	[Price] [decimal](18, 0) NULL,
	[TransactionFees] [decimal](18, 0) NULL,
	[DateOfPriceChecking] [datetime] NULL,
PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Transactions]    Script Date: 07.02.2022 20:22:28 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Transactions](
	[TransactionID] [int] NOT NULL,
	[AdressFrom] [varchar](255) NULL,
	[AdressTo] [varchar](255) NULL,
	[LocationByIP] [varchar](255) NULL,
	[Country] [varchar](255) NULL,
	[IsFirstAdressTransaction] [bit] NULL,
	[TransactionDate] [datetime] NULL,
PRIMARY KEY CLUSTERED 
(
	[TransactionID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
USE [master]
GO
ALTER DATABASE [CryptoDB] SET  READ_WRITE 
GO
