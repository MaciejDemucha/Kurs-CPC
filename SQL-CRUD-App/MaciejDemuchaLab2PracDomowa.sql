USE [master]
GO
/****** Object:  Database [SportShop]    Script Date: 19.11.2021 18:44:38 ******/
CREATE DATABASE [SportShop]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'SportShop', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.DEMUCHASQL\MSSQL\DATA\SportShop.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'SportShop_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.DEMUCHASQL\MSSQL\DATA\SportShop_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
 WITH CATALOG_COLLATION = DATABASE_DEFAULT
GO
ALTER DATABASE [SportShop] SET COMPATIBILITY_LEVEL = 150
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [SportShop].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [SportShop] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [SportShop] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [SportShop] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [SportShop] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [SportShop] SET ARITHABORT OFF 
GO
ALTER DATABASE [SportShop] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [SportShop] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [SportShop] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [SportShop] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [SportShop] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [SportShop] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [SportShop] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [SportShop] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [SportShop] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [SportShop] SET  DISABLE_BROKER 
GO
ALTER DATABASE [SportShop] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [SportShop] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [SportShop] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [SportShop] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [SportShop] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [SportShop] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [SportShop] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [SportShop] SET RECOVERY FULL 
GO
ALTER DATABASE [SportShop] SET  MULTI_USER 
GO
ALTER DATABASE [SportShop] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [SportShop] SET DB_CHAINING OFF 
GO
ALTER DATABASE [SportShop] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [SportShop] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [SportShop] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [SportShop] SET ACCELERATED_DATABASE_RECOVERY = OFF  
GO
EXEC sys.sp_db_vardecimal_storage_format N'SportShop', N'ON'
GO
ALTER DATABASE [SportShop] SET QUERY_STORE = OFF
GO
USE [SportShop]
GO
/****** Object:  Table [dbo].[Clients]    Script Date: 19.11.2021 18:44:38 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Clients](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[ProductId] [int] NULL,
	[FirstName] [nvarchar](50) NOT NULL,
	[LastName] [nvarchar](50) NOT NULL,
	[Adress] [nvarchar](50) NOT NULL,
	[Payed] [bit] NOT NULL,
 CONSTRAINT [PK_ClientList] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Colors]    Script Date: 19.11.2021 18:44:38 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Colors](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Name] [nvarchar](50) NOT NULL,
 CONSTRAINT [PK_Colors] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Employees]    Script Date: 19.11.2021 18:44:38 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Employees](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[FirstName] [nvarchar](50) NOT NULL,
	[LastName] [nvarchar](50) NOT NULL,
	[Salary] [int] NOT NULL,
 CONSTRAINT [PK_Employees] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Producers]    Script Date: 19.11.2021 18:44:38 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Producers](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Name] [nvarchar](50) NOT NULL,
	[Country] [nvarchar](50) NOT NULL,
 CONSTRAINT [PK_Producers] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Products]    Script Date: 19.11.2021 18:44:38 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Products](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[ProducerId] [int] NOT NULL,
	[SexId] [int] NOT NULL,
	[ColorId] [int] NOT NULL,
	[SportId] [int] NOT NULL,
	[TypeId] [int] NOT NULL,
	[Name] [nvarchar](50) NOT NULL,
	[Size] [nvarchar](50) NOT NULL,
 CONSTRAINT [PK_Product] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[ProductTypes]    Script Date: 19.11.2021 18:44:38 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ProductTypes](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Name] [nvarchar](50) NOT NULL,
 CONSTRAINT [PK_ProductTypes] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Sex]    Script Date: 19.11.2021 18:44:38 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Sex](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Name] [nvarchar](50) NOT NULL,
 CONSTRAINT [PK_Materials] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Sports]    Script Date: 19.11.2021 18:44:38 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Sports](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Name] [nvarchar](50) NOT NULL,
 CONSTRAINT [PK_Sports] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[Clients] ON 

INSERT [dbo].[Clients] ([Id], [ProductId], [FirstName], [LastName], [Adress], [Payed]) VALUES (2, 2, N'Adam ', N'Nowak', N'ul. Polna 23 23-400 Biłgoraj', 1)
INSERT [dbo].[Clients] ([Id], [ProductId], [FirstName], [LastName], [Adress], [Payed]) VALUES (4, 4, N'Jan', N'Kowalski', N'ul. Nowowiejska 50-315 Wrocław', 0)
INSERT [dbo].[Clients] ([Id], [ProductId], [FirstName], [LastName], [Adress], [Payed]) VALUES (5, 3, N'Anna', N'Blicharz', N'ul. Wittiga 12 51-628 Wrocław', 1)
SET IDENTITY_INSERT [dbo].[Clients] OFF
GO
SET IDENTITY_INSERT [dbo].[Colors] ON 

INSERT [dbo].[Colors] ([Id], [Name]) VALUES (1, N'Niebieski')
INSERT [dbo].[Colors] ([Id], [Name]) VALUES (2, N'Zielony')
INSERT [dbo].[Colors] ([Id], [Name]) VALUES (3, N'Czarny')
INSERT [dbo].[Colors] ([Id], [Name]) VALUES (4, N'Czerwony')
INSERT [dbo].[Colors] ([Id], [Name]) VALUES (5, N'Biały')
SET IDENTITY_INSERT [dbo].[Colors] OFF
GO
SET IDENTITY_INSERT [dbo].[Employees] ON 

INSERT [dbo].[Employees] ([Id], [FirstName], [LastName], [Salary]) VALUES (1, N'Aleksandra', N'Nowak', 2900)
INSERT [dbo].[Employees] ([Id], [FirstName], [LastName], [Salary]) VALUES (2, N'Marcin', N'Iwański', 3100)
INSERT [dbo].[Employees] ([Id], [FirstName], [LastName], [Salary]) VALUES (3, N'Marian', N'Bednarz', 2800)
SET IDENTITY_INSERT [dbo].[Employees] OFF
GO
SET IDENTITY_INSERT [dbo].[Producers] ON 

INSERT [dbo].[Producers] ([Id], [Name], [Country]) VALUES (1, N'Asics', N'Japonia')
INSERT [dbo].[Producers] ([Id], [Name], [Country]) VALUES (2, N'Adidas', N'Niemcy')
INSERT [dbo].[Producers] ([Id], [Name], [Country]) VALUES (3, N'Nike', N'USA')
INSERT [dbo].[Producers] ([Id], [Name], [Country]) VALUES (4, N'New Balance', N'USA')
SET IDENTITY_INSERT [dbo].[Producers] OFF
GO
SET IDENTITY_INSERT [dbo].[Products] ON 

INSERT [dbo].[Products] ([Id], [ProducerId], [SexId], [ColorId], [SportId], [TypeId], [Name], [Size]) VALUES (2, 1, 1, 2, 1, 1, N'Run Shirt 2019', N'M')
INSERT [dbo].[Products] ([Id], [ProducerId], [SexId], [ColorId], [SportId], [TypeId], [Name], [Size]) VALUES (3, 2, 2, 3, 8, 2, N'Kurtka przeciwwiatrowa Bike everywhere 2020', N'S')
INSERT [dbo].[Products] ([Id], [ProducerId], [SexId], [ColorId], [SportId], [TypeId], [Name], [Size]) VALUES (4, 3, 1, 4, 1, 3, N'Run shorts', N'M')
SET IDENTITY_INSERT [dbo].[Products] OFF
GO
SET IDENTITY_INSERT [dbo].[ProductTypes] ON 

INSERT [dbo].[ProductTypes] ([Id], [Name]) VALUES (1, N'Koszulka')
INSERT [dbo].[ProductTypes] ([Id], [Name]) VALUES (2, N'Kurtka')
INSERT [dbo].[ProductTypes] ([Id], [Name]) VALUES (3, N'Spodenki')
INSERT [dbo].[ProductTypes] ([Id], [Name]) VALUES (4, N'Dresy')
INSERT [dbo].[ProductTypes] ([Id], [Name]) VALUES (5, N'Legginsy')
INSERT [dbo].[ProductTypes] ([Id], [Name]) VALUES (6, N'Czapka')
INSERT [dbo].[ProductTypes] ([Id], [Name]) VALUES (7, N'Buty')
SET IDENTITY_INSERT [dbo].[ProductTypes] OFF
GO
SET IDENTITY_INSERT [dbo].[Sex] ON 

INSERT [dbo].[Sex] ([Id], [Name]) VALUES (1, N'Męski')
INSERT [dbo].[Sex] ([Id], [Name]) VALUES (2, N'Żeński')
INSERT [dbo].[Sex] ([Id], [Name]) VALUES (3, N'Unisex')
SET IDENTITY_INSERT [dbo].[Sex] OFF
GO
SET IDENTITY_INSERT [dbo].[Sports] ON 

INSERT [dbo].[Sports] ([Id], [Name]) VALUES (1, N'Bieganie')
INSERT [dbo].[Sports] ([Id], [Name]) VALUES (8, N'Rower')
INSERT [dbo].[Sports] ([Id], [Name]) VALUES (9, N'Piłka nożna')
INSERT [dbo].[Sports] ([Id], [Name]) VALUES (10, N'Koszykówka')
SET IDENTITY_INSERT [dbo].[Sports] OFF
GO
ALTER TABLE [dbo].[Clients]  WITH CHECK ADD  CONSTRAINT [FK_Clients_Products] FOREIGN KEY([ProductId])
REFERENCES [dbo].[Products] ([Id])
GO
ALTER TABLE [dbo].[Clients] CHECK CONSTRAINT [FK_Clients_Products]
GO
ALTER TABLE [dbo].[Products]  WITH CHECK ADD  CONSTRAINT [FK_Products_Colors] FOREIGN KEY([ColorId])
REFERENCES [dbo].[Colors] ([Id])
GO
ALTER TABLE [dbo].[Products] CHECK CONSTRAINT [FK_Products_Colors]
GO
ALTER TABLE [dbo].[Products]  WITH CHECK ADD  CONSTRAINT [FK_Products_Materials] FOREIGN KEY([SexId])
REFERENCES [dbo].[Sex] ([Id])
GO
ALTER TABLE [dbo].[Products] CHECK CONSTRAINT [FK_Products_Materials]
GO
ALTER TABLE [dbo].[Products]  WITH CHECK ADD  CONSTRAINT [FK_Products_Producers] FOREIGN KEY([ProducerId])
REFERENCES [dbo].[Producers] ([Id])
GO
ALTER TABLE [dbo].[Products] CHECK CONSTRAINT [FK_Products_Producers]
GO
ALTER TABLE [dbo].[Products]  WITH CHECK ADD  CONSTRAINT [FK_Products_ProductTypes] FOREIGN KEY([TypeId])
REFERENCES [dbo].[ProductTypes] ([Id])
GO
ALTER TABLE [dbo].[Products] CHECK CONSTRAINT [FK_Products_ProductTypes]
GO
ALTER TABLE [dbo].[Products]  WITH CHECK ADD  CONSTRAINT [FK_Products_Sex] FOREIGN KEY([SexId])
REFERENCES [dbo].[Sex] ([Id])
GO
ALTER TABLE [dbo].[Products] CHECK CONSTRAINT [FK_Products_Sex]
GO
ALTER TABLE [dbo].[Products]  WITH CHECK ADD  CONSTRAINT [FK_Products_Sports] FOREIGN KEY([SportId])
REFERENCES [dbo].[Sports] ([Id])
GO
ALTER TABLE [dbo].[Products] CHECK CONSTRAINT [FK_Products_Sports]
GO
USE [master]
GO
ALTER DATABASE [SportShop] SET  READ_WRITE 
GO
