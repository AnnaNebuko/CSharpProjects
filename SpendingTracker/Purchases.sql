USE [master]
GO
/****** Object:  Database [Purchases]    Script Date: 08.02.2021 18:56:08 ******/
CREATE DATABASE [Purchases]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'Purchases', FILENAME = N'D:\MS SQL\MSSQL15.SQLEXPRESS\MSSQL\DATA\Purchases.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'Purchases_log', FILENAME = N'D:\MS SQL\MSSQL15.SQLEXPRESS\MSSQL\DATA\Purchases_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
 WITH CATALOG_COLLATION = DATABASE_DEFAULT
GO
ALTER DATABASE [Purchases] SET COMPATIBILITY_LEVEL = 150
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [Purchases].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [Purchases] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [Purchases] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [Purchases] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [Purchases] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [Purchases] SET ARITHABORT OFF 
GO
ALTER DATABASE [Purchases] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [Purchases] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [Purchases] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [Purchases] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [Purchases] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [Purchases] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [Purchases] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [Purchases] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [Purchases] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [Purchases] SET  DISABLE_BROKER 
GO
ALTER DATABASE [Purchases] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [Purchases] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [Purchases] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [Purchases] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [Purchases] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [Purchases] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [Purchases] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [Purchases] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [Purchases] SET  MULTI_USER 
GO
ALTER DATABASE [Purchases] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [Purchases] SET DB_CHAINING OFF 
GO
ALTER DATABASE [Purchases] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [Purchases] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [Purchases] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [Purchases] SET ACCELERATED_DATABASE_RECOVERY = OFF  
GO
ALTER DATABASE [Purchases] SET QUERY_STORE = OFF
GO
USE [Purchases]
GO
/****** Object:  Table [dbo].[Categories]    Script Date: 08.02.2021 18:56:08 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Categories](
	[categoryID] [int] NOT NULL,
	[categoryName] [nvarchar](30) NOT NULL,
 CONSTRAINT [PK_Categories] PRIMARY KEY CLUSTERED 
(
	[categoryID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[ItemsOfCategory]    Script Date: 08.02.2021 18:56:08 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ItemsOfCategory](
	[itemID] [int] NOT NULL,
	[itemcategoryID] [int] NOT NULL,
	[itemName] [varchar](30) NOT NULL
) ON [PRIMARY]
GO
INSERT [dbo].[Categories] ([categoryID], [categoryName]) VALUES (1, N'Ordinary Life')
INSERT [dbo].[Categories] ([categoryID], [categoryName]) VALUES (2, N'Happy Life')
INSERT [dbo].[Categories] ([categoryID], [categoryName]) VALUES (3, N'Meal')
GO
INSERT [dbo].[ItemsOfCategory] ([itemID], [itemcategoryID], [itemName]) VALUES (1, 1, N'not selected')
INSERT [dbo].[ItemsOfCategory] ([itemID], [itemcategoryID], [itemName]) VALUES (2, 2, N'not selected')
INSERT [dbo].[ItemsOfCategory] ([itemID], [itemcategoryID], [itemName]) VALUES (3, 3, N'not selected')
INSERT [dbo].[ItemsOfCategory] ([itemID], [itemcategoryID], [itemName]) VALUES (4, 1, N'Body care')
INSERT [dbo].[ItemsOfCategory] ([itemID], [itemcategoryID], [itemName]) VALUES (5, 1, N'Communal payments')
INSERT [dbo].[ItemsOfCategory] ([itemID], [itemcategoryID], [itemName]) VALUES (6, 1, N'Clothes')
INSERT [dbo].[ItemsOfCategory] ([itemID], [itemcategoryID], [itemName]) VALUES (7, 2, N'Gym')
INSERT [dbo].[ItemsOfCategory] ([itemID], [itemcategoryID], [itemName]) VALUES (8, 2, N'Education')
INSERT [dbo].[ItemsOfCategory] ([itemID], [itemcategoryID], [itemName]) VALUES (9, 2, N'Friends')
INSERT [dbo].[ItemsOfCategory] ([itemID], [itemcategoryID], [itemName]) VALUES (10, 3, N'Milk')
INSERT [dbo].[ItemsOfCategory] ([itemID], [itemcategoryID], [itemName]) VALUES (11, 3, N'Apples')
INSERT [dbo].[ItemsOfCategory] ([itemID], [itemcategoryID], [itemName]) VALUES (12, 3, N'Bananas')
INSERT [dbo].[ItemsOfCategory] ([itemID], [itemcategoryID], [itemName]) VALUES (13, 3, N'Buckwheat')
INSERT [dbo].[ItemsOfCategory] ([itemID], [itemcategoryID], [itemName]) VALUES (14, 3, N'Tea')
INSERT [dbo].[ItemsOfCategory] ([itemID], [itemcategoryID], [itemName]) VALUES (15, 3, N'Coffee')
GO
USE [master]
GO
ALTER DATABASE [Purchases] SET  READ_WRITE 
GO
