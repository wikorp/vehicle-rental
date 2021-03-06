USE [master]
GO
/****** Object:  Database [Vehicle rental]    Script Date: 20.11.2021 20:12:20 ******/
CREATE DATABASE [Vehicle rental]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'Vehicle rental', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.MSSQLSERVER\MSSQL\DATA\Vehicle rental.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'Vehicle rental_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.MSSQLSERVER\MSSQL\DATA\Vehicle rental_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
 WITH CATALOG_COLLATION = DATABASE_DEFAULT
GO
ALTER DATABASE [Vehicle rental] SET COMPATIBILITY_LEVEL = 150
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [Vehicle rental].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [Vehicle rental] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [Vehicle rental] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [Vehicle rental] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [Vehicle rental] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [Vehicle rental] SET ARITHABORT OFF 
GO
ALTER DATABASE [Vehicle rental] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [Vehicle rental] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [Vehicle rental] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [Vehicle rental] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [Vehicle rental] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [Vehicle rental] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [Vehicle rental] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [Vehicle rental] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [Vehicle rental] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [Vehicle rental] SET  DISABLE_BROKER 
GO
ALTER DATABASE [Vehicle rental] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [Vehicle rental] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [Vehicle rental] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [Vehicle rental] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [Vehicle rental] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [Vehicle rental] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [Vehicle rental] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [Vehicle rental] SET RECOVERY FULL 
GO
ALTER DATABASE [Vehicle rental] SET  MULTI_USER 
GO
ALTER DATABASE [Vehicle rental] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [Vehicle rental] SET DB_CHAINING OFF 
GO
ALTER DATABASE [Vehicle rental] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [Vehicle rental] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [Vehicle rental] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [Vehicle rental] SET ACCELERATED_DATABASE_RECOVERY = OFF  
GO
EXEC sys.sp_db_vardecimal_storage_format N'Vehicle rental', N'ON'
GO
ALTER DATABASE [Vehicle rental] SET QUERY_STORE = OFF
GO
USE [Vehicle rental]
GO
/****** Object:  Table [dbo].[Vehicle]    Script Date: 20.11.2021 20:12:21 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Vehicle](
	[vehicle_id] [numeric](15, 0) NOT NULL,
	[brand] [varchar](20) NOT NULL,
	[model] [varchar](20) NOT NULL,
	[price_hour] [numeric](3, 0) NOT NULL,
	[capacity] [numeric](3, 1) NOT NULL,
	[adress_id] [numeric](30, 0) NOT NULL,
	[vehicle_type] [varchar](15) NOT NULL,
	[is_avaliable] [varchar](1) NOT NULL,
	[damage_id] [numeric](30, 0) NULL,
 CONSTRAINT [PK_Vehicle] PRIMARY KEY CLUSTERED 
(
	[vehicle_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  View [dbo].[View_vehicles_valiable]    Script Date: 20.11.2021 20:12:21 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE VIEW [dbo].[View_vehicles_valiable] AS
SELECT vehicle_id, price_hour, brand, model, capacity, vehicle_type
FROM Vehicle
WHERE is_avaliable = 'Y';
GO
/****** Object:  Table [dbo].[Client]    Script Date: 20.11.2021 20:12:21 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Client](
	[client_id] [numeric](20, 0) NOT NULL,
	[name] [varchar](20) NOT NULL,
	[surname] [varchar](30) NOT NULL,
	[adress_id] [numeric](30, 0) NOT NULL,
	[account_number] [numeric](26, 0) NOT NULL,
	[last_update] [datetime] NULL,
 CONSTRAINT [PK_Client] PRIMARY KEY CLUSTERED 
(
	[client_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  View [dbo].[View_client_data]    Script Date: 20.11.2021 20:12:21 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE VIEW [dbo].[View_client_data] AS
SELECT c.client_id, c.name, c.surname, c.account_number
FROM Client c;
GO
/****** Object:  Table [dbo].[Adress]    Script Date: 20.11.2021 20:12:21 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Adress](
	[adress_id] [numeric](30, 0) NOT NULL,
	[street] [varchar](50) NOT NULL,
	[street_number] [numeric](3, 0) NULL,
	[city] [varchar](30) NOT NULL,
	[zone] [numeric](2, 0) NULL,
 CONSTRAINT [PK_Adress] PRIMARY KEY CLUSTERED 
(
	[adress_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Ban]    Script Date: 20.11.2021 20:12:21 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Ban](
	[ban_id] [numeric](20, 0) NOT NULL,
	[client_id] [numeric](20, 0) NOT NULL,
	[ban_reason] [varchar](100) NULL,
	[ban_date] [date] NULL,
 CONSTRAINT [PK_Ban] PRIMARY KEY CLUSTERED 
(
	[ban_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Damage]    Script Date: 20.11.2021 20:12:21 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Damage](
	[damage_id] [numeric](30, 0) NOT NULL,
	[damage_type] [varchar](20) NULL,
	[damage_data] [date] NOT NULL,
	[damage_reason] [varchar](100) NULL,
 CONSTRAINT [PK_Damage] PRIMARY KEY CLUSTERED 
(
	[damage_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Rental]    Script Date: 20.11.2021 20:12:21 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Rental](
	[rent_id] [numeric](30, 0) IDENTITY(1,1) NOT NULL,
	[vehicle_id] [numeric](15, 0) NOT NULL,
	[cient_id] [numeric](20, 0) NOT NULL,
	[rent_date] [datetime] NOT NULL,
	[return_date] [datetime] NULL,
 CONSTRAINT [PK_Rental] PRIMARY KEY CLUSTERED 
(
	[rent_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
INSERT [dbo].[Adress] ([adress_id], [street], [street_number], [city], [zone]) VALUES (CAST(1 AS Numeric(30, 0)), N'KOZANOWSKA', NULL, N'WROCLAW', NULL)
GO
INSERT [dbo].[Client] ([client_id], [name], [surname], [adress_id], [account_number], [last_update]) VALUES (CAST(1 AS Numeric(20, 0)), N'TEST', N'CLIENT', CAST(1 AS Numeric(30, 0)), CAST(0 AS Numeric(26, 0)), CAST(N'2021-11-20T16:22:19.680' AS DateTime))
GO
INSERT [dbo].[Vehicle] ([vehicle_id], [brand], [model], [price_hour], [capacity], [adress_id], [vehicle_type], [is_avaliable], [damage_id]) VALUES (CAST(1 AS Numeric(15, 0)), N'FORD', N'TRANSIT', CAST(20 AS Numeric(3, 0)), CAST(20.0 AS Numeric(3, 1)), CAST(1 AS Numeric(30, 0)), N'TRACK 3,5T', N'Y', NULL)
INSERT [dbo].[Vehicle] ([vehicle_id], [brand], [model], [price_hour], [capacity], [adress_id], [vehicle_type], [is_avaliable], [damage_id]) VALUES (CAST(2 AS Numeric(15, 0)), N'FIAT', N'DUCATO', CAST(30 AS Numeric(3, 0)), CAST(30.0 AS Numeric(3, 1)), CAST(1 AS Numeric(30, 0)), N'TRACK', N'Y', NULL)
GO
ALTER TABLE [dbo].[Ban]  WITH CHECK ADD  CONSTRAINT [FK_Ban_Client] FOREIGN KEY([client_id])
REFERENCES [dbo].[Client] ([client_id])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[Ban] CHECK CONSTRAINT [FK_Ban_Client]
GO
ALTER TABLE [dbo].[Client]  WITH CHECK ADD  CONSTRAINT [FK_Client_Adress] FOREIGN KEY([adress_id])
REFERENCES [dbo].[Adress] ([adress_id])
GO
ALTER TABLE [dbo].[Client] CHECK CONSTRAINT [FK_Client_Adress]
GO
ALTER TABLE [dbo].[Rental]  WITH CHECK ADD  CONSTRAINT [FK_Rental_Client] FOREIGN KEY([cient_id])
REFERENCES [dbo].[Client] ([client_id])
GO
ALTER TABLE [dbo].[Rental] CHECK CONSTRAINT [FK_Rental_Client]
GO
ALTER TABLE [dbo].[Rental]  WITH CHECK ADD  CONSTRAINT [FK_Rental_Vehicle] FOREIGN KEY([vehicle_id])
REFERENCES [dbo].[Vehicle] ([vehicle_id])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[Rental] CHECK CONSTRAINT [FK_Rental_Vehicle]
GO
ALTER TABLE [dbo].[Vehicle]  WITH CHECK ADD  CONSTRAINT [FK_Vehicle_Adress] FOREIGN KEY([adress_id])
REFERENCES [dbo].[Adress] ([adress_id])
GO
ALTER TABLE [dbo].[Vehicle] CHECK CONSTRAINT [FK_Vehicle_Adress]
GO
ALTER TABLE [dbo].[Vehicle]  WITH CHECK ADD  CONSTRAINT [FK_Vehicle_Damage] FOREIGN KEY([damage_id])
REFERENCES [dbo].[Damage] ([damage_id])
ON DELETE SET NULL
GO
ALTER TABLE [dbo].[Vehicle] CHECK CONSTRAINT [FK_Vehicle_Damage]
GO
USE [master]
GO
ALTER DATABASE [Vehicle rental] SET  READ_WRITE 
GO
