USE [master]
GO
/****** Object:  Database [GlobalResearch]    Script Date: 10/2/2015 11:36:02 AM ******/
CREATE DATABASE [GlobalResearch]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'GlobalResearch', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL12.MSSQLSERVER\MSSQL\DATA\GlobalResearch.mdf' , SIZE = 3264KB , MAXSIZE = UNLIMITED, FILEGROWTH = 1024KB )
 LOG ON 
( NAME = N'GlobalResearch_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL12.MSSQLSERVER\MSSQL\DATA\GlobalResearch_log.ldf' , SIZE = 816KB , MAXSIZE = 2048GB , FILEGROWTH = 10%)
GO
ALTER DATABASE [GlobalResearch] SET COMPATIBILITY_LEVEL = 120
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [GlobalResearch].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [GlobalResearch] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [GlobalResearch] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [GlobalResearch] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [GlobalResearch] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [GlobalResearch] SET ARITHABORT OFF 
GO
ALTER DATABASE [GlobalResearch] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [GlobalResearch] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [GlobalResearch] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [GlobalResearch] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [GlobalResearch] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [GlobalResearch] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [GlobalResearch] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [GlobalResearch] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [GlobalResearch] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [GlobalResearch] SET  ENABLE_BROKER 
GO
ALTER DATABASE [GlobalResearch] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [GlobalResearch] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [GlobalResearch] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [GlobalResearch] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [GlobalResearch] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [GlobalResearch] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [GlobalResearch] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [GlobalResearch] SET RECOVERY FULL 
GO
ALTER DATABASE [GlobalResearch] SET  MULTI_USER 
GO
ALTER DATABASE [GlobalResearch] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [GlobalResearch] SET DB_CHAINING OFF 
GO
ALTER DATABASE [GlobalResearch] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [GlobalResearch] SET TARGET_RECOVERY_TIME = 0 SECONDS 
GO
ALTER DATABASE [GlobalResearch] SET DELAYED_DURABILITY = DISABLED 
GO
EXEC sys.sp_db_vardecimal_storage_format N'GlobalResearch', N'ON'
GO
USE [GlobalResearch]
GO
/****** Object:  Table [dbo].[Address]    Script Date: 10/2/2015 11:36:02 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Address](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Address] [nvarchar](255) NOT NULL,
	[TownId] [int] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Continent]    Script Date: 10/2/2015 11:36:02 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Continent](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Name] [nvarchar](100) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Country]    Script Date: 10/2/2015 11:36:02 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Country](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Name] [nvarchar](100) NOT NULL,
	[CountryId] [int] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Person]    Script Date: 10/2/2015 11:36:02 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Person](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[FullName] [nvarchar](255) NOT NULL,
	[AddressId] [int] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Town]    Script Date: 10/2/2015 11:36:02 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Town](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Name] [nvarchar](255) NOT NULL,
	[CountryId] [int] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET IDENTITY_INSERT [dbo].[Address] ON 

INSERT [dbo].[Address] ([Id], [Address], [TownId]) VALUES (1, N'6599 Amet Rd.', 6)
INSERT [dbo].[Address] ([Id], [Address], [TownId]) VALUES (2, N'5767 Vel Street', 9)
INSERT [dbo].[Address] ([Id], [Address], [TownId]) VALUES (3, N'P.O. Box 636,  7930 Vulputate,  St.', 4)
INSERT [dbo].[Address] ([Id], [Address], [TownId]) VALUES (4, N'Ap #831-4695 Nibh Av.', 9)
INSERT [dbo].[Address] ([Id], [Address], [TownId]) VALUES (5, N'184 Enim,  Av.', 7)
INSERT [dbo].[Address] ([Id], [Address], [TownId]) VALUES (6, N'310-6984 Risus. Rd.', 8)
INSERT [dbo].[Address] ([Id], [Address], [TownId]) VALUES (7, N'Ap #463-8716 Odio. Av.', 6)
INSERT [dbo].[Address] ([Id], [Address], [TownId]) VALUES (8, N'986-554 Sem St.', 6)
INSERT [dbo].[Address] ([Id], [Address], [TownId]) VALUES (9, N'1698 Faucibus Rd.', 6)
INSERT [dbo].[Address] ([Id], [Address], [TownId]) VALUES (10, N'P.O. Box 727,  4522 Mattis Rd.', 7)
INSERT [dbo].[Address] ([Id], [Address], [TownId]) VALUES (11, N'P.O. Box 100,  1188 Mollis Road', 10)
INSERT [dbo].[Address] ([Id], [Address], [TownId]) VALUES (12, N'Ap #640-7669 Auctor Street', 9)
INSERT [dbo].[Address] ([Id], [Address], [TownId]) VALUES (13, N'P.O. Box 197,  4022 Lacus. Avenue', 5)
INSERT [dbo].[Address] ([Id], [Address], [TownId]) VALUES (14, N'105-9861 Ullamcorper. Avenue', 1)
INSERT [dbo].[Address] ([Id], [Address], [TownId]) VALUES (15, N'P.O. Box 836,  6416 Nonummy Street', 10)
INSERT [dbo].[Address] ([Id], [Address], [TownId]) VALUES (16, N'116-8412 Ac Rd.', 1)
INSERT [dbo].[Address] ([Id], [Address], [TownId]) VALUES (17, N'P.O. Box 284,  4013 Pellentesque,  Rd.', 8)
INSERT [dbo].[Address] ([Id], [Address], [TownId]) VALUES (18, N'Ap #626-6594 Mi St.', 6)
INSERT [dbo].[Address] ([Id], [Address], [TownId]) VALUES (19, N'Ap #854-4606 Enim Ave', 5)
INSERT [dbo].[Address] ([Id], [Address], [TownId]) VALUES (20, N'P.O. Box 989,  2556 A Ave', 2)
INSERT [dbo].[Address] ([Id], [Address], [TownId]) VALUES (21, N'3535 Maecenas Av.', 9)
INSERT [dbo].[Address] ([Id], [Address], [TownId]) VALUES (22, N'Ap #574-544 Nibh Rd.', 1)
INSERT [dbo].[Address] ([Id], [Address], [TownId]) VALUES (23, N'Ap #688-6929 Feugiat Street', 8)
INSERT [dbo].[Address] ([Id], [Address], [TownId]) VALUES (24, N'Ap #233-7669 Vestibulum,  Rd.', 7)
INSERT [dbo].[Address] ([Id], [Address], [TownId]) VALUES (25, N'Ap #650-2426 Fermentum Rd.', 9)
INSERT [dbo].[Address] ([Id], [Address], [TownId]) VALUES (26, N'4271 Rutrum Rd.', 4)
INSERT [dbo].[Address] ([Id], [Address], [TownId]) VALUES (27, N'P.O. Box 640,  9557 Inceptos Rd.', 2)
INSERT [dbo].[Address] ([Id], [Address], [TownId]) VALUES (28, N'Ap #980-5144 Libero St.', 7)
INSERT [dbo].[Address] ([Id], [Address], [TownId]) VALUES (29, N'9511 Erat Rd.', 2)
INSERT [dbo].[Address] ([Id], [Address], [TownId]) VALUES (30, N'P.O. Box 964,  3389 In Rd.', 5)
INSERT [dbo].[Address] ([Id], [Address], [TownId]) VALUES (31, N'301-5576 In St.', 4)
INSERT [dbo].[Address] ([Id], [Address], [TownId]) VALUES (32, N'P.O. Box 404,  8137 A Street', 2)
INSERT [dbo].[Address] ([Id], [Address], [TownId]) VALUES (33, N'Ap #184-2447 Tincidunt Rd.', 6)
INSERT [dbo].[Address] ([Id], [Address], [TownId]) VALUES (34, N'6708 Nunc Av.', 7)
INSERT [dbo].[Address] ([Id], [Address], [TownId]) VALUES (35, N'Ap #791-247 Ac St.', 6)
INSERT [dbo].[Address] ([Id], [Address], [TownId]) VALUES (36, N'Ap #753-3611 Aliquet,  Avenue', 7)
INSERT [dbo].[Address] ([Id], [Address], [TownId]) VALUES (37, N'3009 Quisque Rd.', 8)
INSERT [dbo].[Address] ([Id], [Address], [TownId]) VALUES (38, N'5055 Semper Av.', 9)
INSERT [dbo].[Address] ([Id], [Address], [TownId]) VALUES (39, N'Ap #498-5663 Venenatis Ave', 6)
INSERT [dbo].[Address] ([Id], [Address], [TownId]) VALUES (40, N'344-592 Fusce Rd.', 8)
INSERT [dbo].[Address] ([Id], [Address], [TownId]) VALUES (41, N'7803 Ligula. St.', 3)
INSERT [dbo].[Address] ([Id], [Address], [TownId]) VALUES (42, N'Ap #828-512 Faucibus Street', 10)
INSERT [dbo].[Address] ([Id], [Address], [TownId]) VALUES (43, N'541-4581 Donec Rd.', 3)
INSERT [dbo].[Address] ([Id], [Address], [TownId]) VALUES (44, N'204-5454 Dui. St.', 10)
INSERT [dbo].[Address] ([Id], [Address], [TownId]) VALUES (45, N'9922 Lorem Street', 8)
INSERT [dbo].[Address] ([Id], [Address], [TownId]) VALUES (46, N'1875 Molestie Rd.', 7)
INSERT [dbo].[Address] ([Id], [Address], [TownId]) VALUES (47, N'P.O. Box 412,  2477 Egestas,  St.', 10)
INSERT [dbo].[Address] ([Id], [Address], [TownId]) VALUES (48, N'823-3764 Vivamus Ave', 2)
INSERT [dbo].[Address] ([Id], [Address], [TownId]) VALUES (49, N'384-5429 Mollis St.', 7)
INSERT [dbo].[Address] ([Id], [Address], [TownId]) VALUES (50, N'P.O. Box 212,  4987 Suspendisse Road', 1)
INSERT [dbo].[Address] ([Id], [Address], [TownId]) VALUES (51, N'848-7495 Auctor Rd.', 9)
INSERT [dbo].[Address] ([Id], [Address], [TownId]) VALUES (52, N'P.O. Box 661,  1341 Imperdiet Street', 8)
INSERT [dbo].[Address] ([Id], [Address], [TownId]) VALUES (53, N'7123 Ipsum St.', 7)
INSERT [dbo].[Address] ([Id], [Address], [TownId]) VALUES (54, N'P.O. Box 151,  2551 Ut St.', 2)
INSERT [dbo].[Address] ([Id], [Address], [TownId]) VALUES (55, N'P.O. Box 596,  744 Sodales Av.', 7)
INSERT [dbo].[Address] ([Id], [Address], [TownId]) VALUES (56, N'Ap #665-3741 Sed Street', 8)
INSERT [dbo].[Address] ([Id], [Address], [TownId]) VALUES (57, N'P.O. Box 966,  6080 Tellus. St.', 4)
INSERT [dbo].[Address] ([Id], [Address], [TownId]) VALUES (58, N'P.O. Box 652,  381 Diam Road', 4)
INSERT [dbo].[Address] ([Id], [Address], [TownId]) VALUES (59, N'252-1590 Sed Rd.', 10)
INSERT [dbo].[Address] ([Id], [Address], [TownId]) VALUES (60, N'682-4319 Quis,  Road', 7)
INSERT [dbo].[Address] ([Id], [Address], [TownId]) VALUES (61, N'5214 Vitae,  St.', 2)
INSERT [dbo].[Address] ([Id], [Address], [TownId]) VALUES (62, N'358-1528 Tellus Rd.', 6)
INSERT [dbo].[Address] ([Id], [Address], [TownId]) VALUES (63, N'138-9212 Libero. Rd.', 10)
INSERT [dbo].[Address] ([Id], [Address], [TownId]) VALUES (64, N'Ap #215-1530 Quam Rd.', 7)
INSERT [dbo].[Address] ([Id], [Address], [TownId]) VALUES (65, N'Ap #371-2902 Semper Road', 8)
INSERT [dbo].[Address] ([Id], [Address], [TownId]) VALUES (66, N'851-784 Turpis Street', 8)
INSERT [dbo].[Address] ([Id], [Address], [TownId]) VALUES (67, N'Ap #416-9389 Sodales Avenue', 1)
INSERT [dbo].[Address] ([Id], [Address], [TownId]) VALUES (68, N'Ap #285-9114 Et Street', 6)
INSERT [dbo].[Address] ([Id], [Address], [TownId]) VALUES (69, N'385-3772 Feugiat Ave', 2)
INSERT [dbo].[Address] ([Id], [Address], [TownId]) VALUES (70, N'Ap #817-1571 Nunc Ave', 7)
INSERT [dbo].[Address] ([Id], [Address], [TownId]) VALUES (71, N'5133 Ridiculus St.', 9)
INSERT [dbo].[Address] ([Id], [Address], [TownId]) VALUES (72, N'P.O. Box 254,  7546 Blandit St.', 6)
INSERT [dbo].[Address] ([Id], [Address], [TownId]) VALUES (73, N'Ap #550-9524 Non,  Street', 10)
INSERT [dbo].[Address] ([Id], [Address], [TownId]) VALUES (74, N'554-5612 Quis Rd.', 3)
INSERT [dbo].[Address] ([Id], [Address], [TownId]) VALUES (75, N'P.O. Box 424,  9015 Diam. Street', 3)
INSERT [dbo].[Address] ([Id], [Address], [TownId]) VALUES (76, N'2378 Neque Ave', 2)
INSERT [dbo].[Address] ([Id], [Address], [TownId]) VALUES (77, N'2031 Pede Road', 5)
INSERT [dbo].[Address] ([Id], [Address], [TownId]) VALUES (78, N'7588 Non St.', 2)
INSERT [dbo].[Address] ([Id], [Address], [TownId]) VALUES (79, N'9975 Molestie Road', 10)
INSERT [dbo].[Address] ([Id], [Address], [TownId]) VALUES (80, N'105-8783 Ante Road', 7)
INSERT [dbo].[Address] ([Id], [Address], [TownId]) VALUES (81, N'3035 Ut Ave', 8)
INSERT [dbo].[Address] ([Id], [Address], [TownId]) VALUES (82, N'505-2734 A St.', 3)
INSERT [dbo].[Address] ([Id], [Address], [TownId]) VALUES (83, N'P.O. Box 840,  6807 Augue Rd.', 6)
INSERT [dbo].[Address] ([Id], [Address], [TownId]) VALUES (84, N'Ap #175-5378 Interdum Rd.', 7)
INSERT [dbo].[Address] ([Id], [Address], [TownId]) VALUES (85, N'Ap #610-8388 Nonummy Rd.', 7)
INSERT [dbo].[Address] ([Id], [Address], [TownId]) VALUES (86, N'712-4695 Fermentum Ave', 8)
INSERT [dbo].[Address] ([Id], [Address], [TownId]) VALUES (87, N'P.O. Box 702,  4947 Quis Ave', 8)
INSERT [dbo].[Address] ([Id], [Address], [TownId]) VALUES (88, N'654-5848 Lectus St.', 9)
INSERT [dbo].[Address] ([Id], [Address], [TownId]) VALUES (89, N'Ap #748-448 Lacus. Street', 9)
INSERT [dbo].[Address] ([Id], [Address], [TownId]) VALUES (90, N'3630 Risus. Rd.', 7)
INSERT [dbo].[Address] ([Id], [Address], [TownId]) VALUES (91, N'696-8434 Laoreet Avenue', 2)
INSERT [dbo].[Address] ([Id], [Address], [TownId]) VALUES (92, N'111-1116 Nunc St.', 6)
INSERT [dbo].[Address] ([Id], [Address], [TownId]) VALUES (93, N'713-9645 At Rd.', 4)
INSERT [dbo].[Address] ([Id], [Address], [TownId]) VALUES (94, N'P.O. Box 421,  308 Porttitor St.', 2)
INSERT [dbo].[Address] ([Id], [Address], [TownId]) VALUES (95, N'579-8186 Enim Avenue', 1)
INSERT [dbo].[Address] ([Id], [Address], [TownId]) VALUES (96, N'8653 Dui Ave', 9)
INSERT [dbo].[Address] ([Id], [Address], [TownId]) VALUES (97, N'P.O. Box 472,  1117 Morbi Ave', 5)
INSERT [dbo].[Address] ([Id], [Address], [TownId]) VALUES (98, N'828-9378 Semper Ave', 10)
INSERT [dbo].[Address] ([Id], [Address], [TownId]) VALUES (99, N'P.O. Box 409,  1228 Euismod St.', 8)
GO
INSERT [dbo].[Address] ([Id], [Address], [TownId]) VALUES (100, N'Ap #788-5401 Ante Road', 3)
SET IDENTITY_INSERT [dbo].[Address] OFF
SET IDENTITY_INSERT [dbo].[Continent] ON 

INSERT [dbo].[Continent] ([Id], [Name]) VALUES (1, N'North America')
INSERT [dbo].[Continent] ([Id], [Name]) VALUES (2, N'South America')
INSERT [dbo].[Continent] ([Id], [Name]) VALUES (3, N'Europe')
INSERT [dbo].[Continent] ([Id], [Name]) VALUES (4, N'Africa')
INSERT [dbo].[Continent] ([Id], [Name]) VALUES (5, N'Antarctica')
INSERT [dbo].[Continent] ([Id], [Name]) VALUES (6, N'Asia')
INSERT [dbo].[Continent] ([Id], [Name]) VALUES (7, N'Australia')
SET IDENTITY_INSERT [dbo].[Continent] OFF
SET IDENTITY_INSERT [dbo].[Country] ON 

INSERT [dbo].[Country] ([Id], [Name], [CountryId]) VALUES (1, N'Ireland', 4)
INSERT [dbo].[Country] ([Id], [Name], [CountryId]) VALUES (2, N'Belarus', 4)
INSERT [dbo].[Country] ([Id], [Name], [CountryId]) VALUES (3, N'Burundi', 7)
INSERT [dbo].[Country] ([Id], [Name], [CountryId]) VALUES (4, N'Australia', 9)
INSERT [dbo].[Country] ([Id], [Name], [CountryId]) VALUES (5, N'Sint Maarten', 6)
INSERT [dbo].[Country] ([Id], [Name], [CountryId]) VALUES (6, N'Comoros', 2)
INSERT [dbo].[Country] ([Id], [Name], [CountryId]) VALUES (7, N'Panama', 1)
INSERT [dbo].[Country] ([Id], [Name], [CountryId]) VALUES (8, N'Argentina', 4)
INSERT [dbo].[Country] ([Id], [Name], [CountryId]) VALUES (9, N'Kuwait', 2)
INSERT [dbo].[Country] ([Id], [Name], [CountryId]) VALUES (10, N'Falkland Islands', 6)
INSERT [dbo].[Country] ([Id], [Name], [CountryId]) VALUES (11, N'Kenya', 4)
INSERT [dbo].[Country] ([Id], [Name], [CountryId]) VALUES (12, N'Japan', 5)
INSERT [dbo].[Country] ([Id], [Name], [CountryId]) VALUES (13, N'Qatar', 2)
INSERT [dbo].[Country] ([Id], [Name], [CountryId]) VALUES (14, N'Myanmar', 9)
INSERT [dbo].[Country] ([Id], [Name], [CountryId]) VALUES (15, N'Yemen', 5)
INSERT [dbo].[Country] ([Id], [Name], [CountryId]) VALUES (16, N'Virgin Islands,  United States', 2)
INSERT [dbo].[Country] ([Id], [Name], [CountryId]) VALUES (17, N'Norway', 2)
INSERT [dbo].[Country] ([Id], [Name], [CountryId]) VALUES (18, N'Philippines', 10)
INSERT [dbo].[Country] ([Id], [Name], [CountryId]) VALUES (19, N'Syria', 7)
INSERT [dbo].[Country] ([Id], [Name], [CountryId]) VALUES (20, N'Western Sahara', 3)
INSERT [dbo].[Country] ([Id], [Name], [CountryId]) VALUES (21, N'Tanzania', 7)
INSERT [dbo].[Country] ([Id], [Name], [CountryId]) VALUES (22, N'Seychelles', 7)
INSERT [dbo].[Country] ([Id], [Name], [CountryId]) VALUES (23, N'South Georgia and The South Sandwich Islands', 2)
INSERT [dbo].[Country] ([Id], [Name], [CountryId]) VALUES (24, N'Turks and Caicos Islands', 4)
INSERT [dbo].[Country] ([Id], [Name], [CountryId]) VALUES (25, N'Honduras', 4)
INSERT [dbo].[Country] ([Id], [Name], [CountryId]) VALUES (26, N'Saint Helena,  Ascension and Tristan da Cunha', 2)
INSERT [dbo].[Country] ([Id], [Name], [CountryId]) VALUES (27, N'Bosnia and Herzegovina', 10)
INSERT [dbo].[Country] ([Id], [Name], [CountryId]) VALUES (28, N'Dominican Republic', 6)
INSERT [dbo].[Country] ([Id], [Name], [CountryId]) VALUES (29, N'Lithuania', 5)
INSERT [dbo].[Country] ([Id], [Name], [CountryId]) VALUES (30, N'Cyprus', 5)
INSERT [dbo].[Country] ([Id], [Name], [CountryId]) VALUES (31, N'Ireland', 10)
INSERT [dbo].[Country] ([Id], [Name], [CountryId]) VALUES (32, N'Chad', 3)
INSERT [dbo].[Country] ([Id], [Name], [CountryId]) VALUES (33, N'Trinidad and Tobago', 9)
INSERT [dbo].[Country] ([Id], [Name], [CountryId]) VALUES (34, N'Benin', 8)
INSERT [dbo].[Country] ([Id], [Name], [CountryId]) VALUES (35, N'Norfolk Island', 9)
INSERT [dbo].[Country] ([Id], [Name], [CountryId]) VALUES (36, N'Greenland', 5)
INSERT [dbo].[Country] ([Id], [Name], [CountryId]) VALUES (37, N'Estonia', 1)
INSERT [dbo].[Country] ([Id], [Name], [CountryId]) VALUES (38, N'Japan', 10)
INSERT [dbo].[Country] ([Id], [Name], [CountryId]) VALUES (39, N'Slovenia', 9)
INSERT [dbo].[Country] ([Id], [Name], [CountryId]) VALUES (40, N'Saint Martin', 1)
INSERT [dbo].[Country] ([Id], [Name], [CountryId]) VALUES (41, N'French Polynesia', 2)
INSERT [dbo].[Country] ([Id], [Name], [CountryId]) VALUES (42, N'Andorra', 9)
INSERT [dbo].[Country] ([Id], [Name], [CountryId]) VALUES (43, N'Solomon Islands', 5)
INSERT [dbo].[Country] ([Id], [Name], [CountryId]) VALUES (44, N'Haiti', 1)
INSERT [dbo].[Country] ([Id], [Name], [CountryId]) VALUES (45, N'Madagascar', 9)
INSERT [dbo].[Country] ([Id], [Name], [CountryId]) VALUES (46, N'Slovakia', 2)
INSERT [dbo].[Country] ([Id], [Name], [CountryId]) VALUES (47, N'Norway', 9)
INSERT [dbo].[Country] ([Id], [Name], [CountryId]) VALUES (48, N'Marshall Islands', 5)
INSERT [dbo].[Country] ([Id], [Name], [CountryId]) VALUES (49, N'Russian Federation', 9)
INSERT [dbo].[Country] ([Id], [Name], [CountryId]) VALUES (50, N'Tanzania', 2)
INSERT [dbo].[Country] ([Id], [Name], [CountryId]) VALUES (51, N'Comoros', 7)
INSERT [dbo].[Country] ([Id], [Name], [CountryId]) VALUES (52, N'Falkland Islands', 5)
INSERT [dbo].[Country] ([Id], [Name], [CountryId]) VALUES (53, N'Costa Rica', 7)
INSERT [dbo].[Country] ([Id], [Name], [CountryId]) VALUES (54, N'Estonia', 6)
INSERT [dbo].[Country] ([Id], [Name], [CountryId]) VALUES (55, N'Albania', 2)
INSERT [dbo].[Country] ([Id], [Name], [CountryId]) VALUES (56, N'Palau', 8)
INSERT [dbo].[Country] ([Id], [Name], [CountryId]) VALUES (57, N'Slovenia', 10)
INSERT [dbo].[Country] ([Id], [Name], [CountryId]) VALUES (58, N'Romania', 7)
INSERT [dbo].[Country] ([Id], [Name], [CountryId]) VALUES (59, N'Belgium', 4)
INSERT [dbo].[Country] ([Id], [Name], [CountryId]) VALUES (60, N'New Zealand', 8)
INSERT [dbo].[Country] ([Id], [Name], [CountryId]) VALUES (61, N'Marshall Islands', 1)
INSERT [dbo].[Country] ([Id], [Name], [CountryId]) VALUES (62, N'Jordan', 10)
INSERT [dbo].[Country] ([Id], [Name], [CountryId]) VALUES (63, N'Kiribati', 5)
INSERT [dbo].[Country] ([Id], [Name], [CountryId]) VALUES (64, N'Niue', 3)
INSERT [dbo].[Country] ([Id], [Name], [CountryId]) VALUES (65, N'Cook Islands', 10)
INSERT [dbo].[Country] ([Id], [Name], [CountryId]) VALUES (66, N'India', 2)
INSERT [dbo].[Country] ([Id], [Name], [CountryId]) VALUES (67, N'Djibouti', 4)
INSERT [dbo].[Country] ([Id], [Name], [CountryId]) VALUES (68, N'Kenya', 1)
INSERT [dbo].[Country] ([Id], [Name], [CountryId]) VALUES (69, N'Trinidad and Tobago', 10)
INSERT [dbo].[Country] ([Id], [Name], [CountryId]) VALUES (70, N'Guinea', 6)
INSERT [dbo].[Country] ([Id], [Name], [CountryId]) VALUES (71, N'Costa Rica', 4)
INSERT [dbo].[Country] ([Id], [Name], [CountryId]) VALUES (72, N'Svalbard and Jan Mayen Islands', 8)
INSERT [dbo].[Country] ([Id], [Name], [CountryId]) VALUES (73, N'France', 2)
INSERT [dbo].[Country] ([Id], [Name], [CountryId]) VALUES (74, N'Korea,  North', 1)
INSERT [dbo].[Country] ([Id], [Name], [CountryId]) VALUES (75, N'Macedonia', 5)
INSERT [dbo].[Country] ([Id], [Name], [CountryId]) VALUES (76, N'Cyprus', 2)
INSERT [dbo].[Country] ([Id], [Name], [CountryId]) VALUES (77, N'Guatemala', 10)
INSERT [dbo].[Country] ([Id], [Name], [CountryId]) VALUES (78, N'Croatia', 6)
INSERT [dbo].[Country] ([Id], [Name], [CountryId]) VALUES (79, N'Sri Lanka', 6)
INSERT [dbo].[Country] ([Id], [Name], [CountryId]) VALUES (80, N'France', 6)
INSERT [dbo].[Country] ([Id], [Name], [CountryId]) VALUES (81, N'Costa Rica', 9)
INSERT [dbo].[Country] ([Id], [Name], [CountryId]) VALUES (82, N'El Salvador', 8)
INSERT [dbo].[Country] ([Id], [Name], [CountryId]) VALUES (83, N'Micronesia', 8)
INSERT [dbo].[Country] ([Id], [Name], [CountryId]) VALUES (84, N'Tuvalu', 10)
INSERT [dbo].[Country] ([Id], [Name], [CountryId]) VALUES (85, N'Nicaragua', 10)
INSERT [dbo].[Country] ([Id], [Name], [CountryId]) VALUES (86, N'Norfolk Island', 2)
INSERT [dbo].[Country] ([Id], [Name], [CountryId]) VALUES (87, N'Belize', 2)
INSERT [dbo].[Country] ([Id], [Name], [CountryId]) VALUES (88, N'Swaziland', 4)
INSERT [dbo].[Country] ([Id], [Name], [CountryId]) VALUES (89, N'Syria', 6)
INSERT [dbo].[Country] ([Id], [Name], [CountryId]) VALUES (90, N'Mayotte', 8)
INSERT [dbo].[Country] ([Id], [Name], [CountryId]) VALUES (91, N'United Arab Emirates', 2)
INSERT [dbo].[Country] ([Id], [Name], [CountryId]) VALUES (92, N'Reunion', 8)
INSERT [dbo].[Country] ([Id], [Name], [CountryId]) VALUES (93, N'Kiribati', 4)
INSERT [dbo].[Country] ([Id], [Name], [CountryId]) VALUES (94, N'Virgin Islands,  United States', 9)
INSERT [dbo].[Country] ([Id], [Name], [CountryId]) VALUES (95, N'Slovakia', 7)
INSERT [dbo].[Country] ([Id], [Name], [CountryId]) VALUES (96, N'Jersey', 3)
INSERT [dbo].[Country] ([Id], [Name], [CountryId]) VALUES (97, N'Puerto Rico', 6)
INSERT [dbo].[Country] ([Id], [Name], [CountryId]) VALUES (98, N'Trinidad and Tobago', 5)
INSERT [dbo].[Country] ([Id], [Name], [CountryId]) VALUES (99, N'Bahrain', 3)
GO
INSERT [dbo].[Country] ([Id], [Name], [CountryId]) VALUES (100, N'Singapore', 6)
SET IDENTITY_INSERT [dbo].[Country] OFF
SET IDENTITY_INSERT [dbo].[Person] ON 

INSERT [dbo].[Person] ([Id], [FullName], [AddressId]) VALUES (1, N'Kennedy Stevenson', 61)
INSERT [dbo].[Person] ([Id], [FullName], [AddressId]) VALUES (2, N'Xyla Meyers', 87)
INSERT [dbo].[Person] ([Id], [FullName], [AddressId]) VALUES (3, N'Sebastian Mcdowell', 99)
INSERT [dbo].[Person] ([Id], [FullName], [AddressId]) VALUES (4, N'Troy Stein', 61)
INSERT [dbo].[Person] ([Id], [FullName], [AddressId]) VALUES (5, N'Roth Wolf', 82)
INSERT [dbo].[Person] ([Id], [FullName], [AddressId]) VALUES (6, N'Aline Lowery', 93)
INSERT [dbo].[Person] ([Id], [FullName], [AddressId]) VALUES (7, N'Sebastian Valencia', 18)
INSERT [dbo].[Person] ([Id], [FullName], [AddressId]) VALUES (8, N'Sandra Burke', 84)
INSERT [dbo].[Person] ([Id], [FullName], [AddressId]) VALUES (9, N'Gary Barnett', 75)
INSERT [dbo].[Person] ([Id], [FullName], [AddressId]) VALUES (10, N'Hunter Macias', 28)
INSERT [dbo].[Person] ([Id], [FullName], [AddressId]) VALUES (11, N'Judah Mckenzie', 43)
INSERT [dbo].[Person] ([Id], [FullName], [AddressId]) VALUES (12, N'Shelby Castaneda', 85)
INSERT [dbo].[Person] ([Id], [FullName], [AddressId]) VALUES (13, N'Stewart Rose', 86)
INSERT [dbo].[Person] ([Id], [FullName], [AddressId]) VALUES (14, N'Scott Mckay', 4)
INSERT [dbo].[Person] ([Id], [FullName], [AddressId]) VALUES (15, N'Edan Thomas', 54)
INSERT [dbo].[Person] ([Id], [FullName], [AddressId]) VALUES (16, N'Adam Rodriguez', 39)
INSERT [dbo].[Person] ([Id], [FullName], [AddressId]) VALUES (17, N'Winter Beasley', 77)
INSERT [dbo].[Person] ([Id], [FullName], [AddressId]) VALUES (18, N'Chaim Barton', 24)
INSERT [dbo].[Person] ([Id], [FullName], [AddressId]) VALUES (19, N'Erasmus Wiggins', 19)
INSERT [dbo].[Person] ([Id], [FullName], [AddressId]) VALUES (20, N'Wylie Cobb', 46)
INSERT [dbo].[Person] ([Id], [FullName], [AddressId]) VALUES (21, N'Thomas Sutton', 53)
INSERT [dbo].[Person] ([Id], [FullName], [AddressId]) VALUES (22, N'Gay Langley', 42)
INSERT [dbo].[Person] ([Id], [FullName], [AddressId]) VALUES (23, N'Vielka Reid', 36)
INSERT [dbo].[Person] ([Id], [FullName], [AddressId]) VALUES (24, N'Wylie Oneil', 12)
INSERT [dbo].[Person] ([Id], [FullName], [AddressId]) VALUES (25, N'Tyrone Sharp', 78)
INSERT [dbo].[Person] ([Id], [FullName], [AddressId]) VALUES (26, N'Cameron Cervantes', 14)
INSERT [dbo].[Person] ([Id], [FullName], [AddressId]) VALUES (27, N'Lavinia Herman', 5)
INSERT [dbo].[Person] ([Id], [FullName], [AddressId]) VALUES (28, N'Lionel Duffy', 15)
INSERT [dbo].[Person] ([Id], [FullName], [AddressId]) VALUES (29, N'Baker Mckenzie', 43)
INSERT [dbo].[Person] ([Id], [FullName], [AddressId]) VALUES (30, N'Orson Holland', 74)
INSERT [dbo].[Person] ([Id], [FullName], [AddressId]) VALUES (31, N'Susan Walton', 29)
INSERT [dbo].[Person] ([Id], [FullName], [AddressId]) VALUES (32, N'Hasad Stevenson', 46)
INSERT [dbo].[Person] ([Id], [FullName], [AddressId]) VALUES (33, N'Ryan Hamilton', 47)
INSERT [dbo].[Person] ([Id], [FullName], [AddressId]) VALUES (34, N'Cairo Huff', 38)
INSERT [dbo].[Person] ([Id], [FullName], [AddressId]) VALUES (35, N'Libby Nicholson', 13)
INSERT [dbo].[Person] ([Id], [FullName], [AddressId]) VALUES (36, N'McKenzie Mcgee', 74)
INSERT [dbo].[Person] ([Id], [FullName], [AddressId]) VALUES (37, N'Daria Richards', 32)
INSERT [dbo].[Person] ([Id], [FullName], [AddressId]) VALUES (38, N'Keefe Cameron', 8)
INSERT [dbo].[Person] ([Id], [FullName], [AddressId]) VALUES (39, N'Martena Cannon', 47)
INSERT [dbo].[Person] ([Id], [FullName], [AddressId]) VALUES (40, N'Brielle Melendez', 81)
INSERT [dbo].[Person] ([Id], [FullName], [AddressId]) VALUES (41, N'Emerald Gross', 56)
INSERT [dbo].[Person] ([Id], [FullName], [AddressId]) VALUES (42, N'Hollee Barlow', 3)
INSERT [dbo].[Person] ([Id], [FullName], [AddressId]) VALUES (43, N'Sopoline Moss', 64)
INSERT [dbo].[Person] ([Id], [FullName], [AddressId]) VALUES (44, N'Jessica Robertson', 96)
INSERT [dbo].[Person] ([Id], [FullName], [AddressId]) VALUES (45, N'Kaitlin Kerr', 32)
INSERT [dbo].[Person] ([Id], [FullName], [AddressId]) VALUES (46, N'Bethany Hudson', 58)
INSERT [dbo].[Person] ([Id], [FullName], [AddressId]) VALUES (47, N'Buckminster Washington', 69)
INSERT [dbo].[Person] ([Id], [FullName], [AddressId]) VALUES (48, N'Jordan Tran', 61)
INSERT [dbo].[Person] ([Id], [FullName], [AddressId]) VALUES (49, N'Wilma Velasquez', 87)
INSERT [dbo].[Person] ([Id], [FullName], [AddressId]) VALUES (50, N'Aladdin Pena', 27)
INSERT [dbo].[Person] ([Id], [FullName], [AddressId]) VALUES (51, N'Anne Fitzgerald', 94)
INSERT [dbo].[Person] ([Id], [FullName], [AddressId]) VALUES (52, N'Veronica Yang', 43)
INSERT [dbo].[Person] ([Id], [FullName], [AddressId]) VALUES (53, N'Sarah Fuentes', 82)
INSERT [dbo].[Person] ([Id], [FullName], [AddressId]) VALUES (54, N'Wanda Hamilton', 57)
INSERT [dbo].[Person] ([Id], [FullName], [AddressId]) VALUES (55, N'Suki Morales', 70)
INSERT [dbo].[Person] ([Id], [FullName], [AddressId]) VALUES (56, N'Ira Burke', 17)
INSERT [dbo].[Person] ([Id], [FullName], [AddressId]) VALUES (57, N'Ashton Strickland', 79)
INSERT [dbo].[Person] ([Id], [FullName], [AddressId]) VALUES (58, N'Clayton Pacheco', 41)
INSERT [dbo].[Person] ([Id], [FullName], [AddressId]) VALUES (59, N'Lilah Boyd', 53)
INSERT [dbo].[Person] ([Id], [FullName], [AddressId]) VALUES (60, N'Kai Bright', 3)
INSERT [dbo].[Person] ([Id], [FullName], [AddressId]) VALUES (61, N'Jessica Vinson', 18)
INSERT [dbo].[Person] ([Id], [FullName], [AddressId]) VALUES (62, N'Cathleen Martin', 79)
INSERT [dbo].[Person] ([Id], [FullName], [AddressId]) VALUES (63, N'Brenden Oneil', 34)
INSERT [dbo].[Person] ([Id], [FullName], [AddressId]) VALUES (64, N'Quintessa Kane', 25)
INSERT [dbo].[Person] ([Id], [FullName], [AddressId]) VALUES (65, N'Kieran Henson', 38)
INSERT [dbo].[Person] ([Id], [FullName], [AddressId]) VALUES (66, N'Trevor Quinn', 34)
INSERT [dbo].[Person] ([Id], [FullName], [AddressId]) VALUES (67, N'Whoopi Castillo', 60)
INSERT [dbo].[Person] ([Id], [FullName], [AddressId]) VALUES (68, N'Palmer Vincent', 26)
INSERT [dbo].[Person] ([Id], [FullName], [AddressId]) VALUES (69, N'Guinevere Dominguez', 63)
INSERT [dbo].[Person] ([Id], [FullName], [AddressId]) VALUES (70, N'Sopoline Pena', 46)
INSERT [dbo].[Person] ([Id], [FullName], [AddressId]) VALUES (71, N'Nora Wooten', 97)
INSERT [dbo].[Person] ([Id], [FullName], [AddressId]) VALUES (72, N'Wallace Griffith', 33)
INSERT [dbo].[Person] ([Id], [FullName], [AddressId]) VALUES (73, N'Cora Singleton', 71)
INSERT [dbo].[Person] ([Id], [FullName], [AddressId]) VALUES (74, N'Kelly Mckenzie', 88)
INSERT [dbo].[Person] ([Id], [FullName], [AddressId]) VALUES (75, N'Jaime Hurley', 70)
INSERT [dbo].[Person] ([Id], [FullName], [AddressId]) VALUES (76, N'Georgia Huffman', 26)
INSERT [dbo].[Person] ([Id], [FullName], [AddressId]) VALUES (77, N'Arthur Dickerson', 32)
INSERT [dbo].[Person] ([Id], [FullName], [AddressId]) VALUES (78, N'Mikayla Salas', 16)
INSERT [dbo].[Person] ([Id], [FullName], [AddressId]) VALUES (79, N'Molly Baird', 51)
INSERT [dbo].[Person] ([Id], [FullName], [AddressId]) VALUES (80, N'Lucas Blake', 34)
INSERT [dbo].[Person] ([Id], [FullName], [AddressId]) VALUES (81, N'Uma Barker', 10)
INSERT [dbo].[Person] ([Id], [FullName], [AddressId]) VALUES (82, N'Rudyard Phillips', 39)
INSERT [dbo].[Person] ([Id], [FullName], [AddressId]) VALUES (83, N'Rebekah Goodman', 46)
INSERT [dbo].[Person] ([Id], [FullName], [AddressId]) VALUES (84, N'Nicole Stone', 34)
INSERT [dbo].[Person] ([Id], [FullName], [AddressId]) VALUES (85, N'Sandra Davidson', 17)
INSERT [dbo].[Person] ([Id], [FullName], [AddressId]) VALUES (86, N'Claire Roach', 89)
INSERT [dbo].[Person] ([Id], [FullName], [AddressId]) VALUES (87, N'Rama Tran', 70)
INSERT [dbo].[Person] ([Id], [FullName], [AddressId]) VALUES (88, N'Driscoll Vargas', 18)
INSERT [dbo].[Person] ([Id], [FullName], [AddressId]) VALUES (89, N'Melyssa Mclaughlin', 11)
INSERT [dbo].[Person] ([Id], [FullName], [AddressId]) VALUES (90, N'Callum Stevens', 70)
INSERT [dbo].[Person] ([Id], [FullName], [AddressId]) VALUES (91, N'Jessamine Evans', 63)
INSERT [dbo].[Person] ([Id], [FullName], [AddressId]) VALUES (92, N'Brenden Dejesus', 18)
INSERT [dbo].[Person] ([Id], [FullName], [AddressId]) VALUES (93, N'Eliana Pena', 40)
INSERT [dbo].[Person] ([Id], [FullName], [AddressId]) VALUES (94, N'Rogan Reid', 15)
INSERT [dbo].[Person] ([Id], [FullName], [AddressId]) VALUES (95, N'Gregory Rasmussen', 76)
INSERT [dbo].[Person] ([Id], [FullName], [AddressId]) VALUES (96, N'Imogene Harvey', 41)
INSERT [dbo].[Person] ([Id], [FullName], [AddressId]) VALUES (97, N'Leslie Sweeney', 15)
INSERT [dbo].[Person] ([Id], [FullName], [AddressId]) VALUES (98, N'Kiona Chen', 35)
INSERT [dbo].[Person] ([Id], [FullName], [AddressId]) VALUES (99, N'Ronan Singleton', 17)
GO
INSERT [dbo].[Person] ([Id], [FullName], [AddressId]) VALUES (100, N'Ariana Clemons', 58)
SET IDENTITY_INSERT [dbo].[Person] OFF
SET IDENTITY_INSERT [dbo].[Town] ON 

INSERT [dbo].[Town] ([Id], [Name], [CountryId]) VALUES (1, N'Carovilli', 3)
INSERT [dbo].[Town] ([Id], [Name], [CountryId]) VALUES (2, N'Wedel', 3)
INSERT [dbo].[Town] ([Id], [Name], [CountryId]) VALUES (3, N'Olinda', 8)
INSERT [dbo].[Town] ([Id], [Name], [CountryId]) VALUES (4, N'Valda', 4)
INSERT [dbo].[Town] ([Id], [Name], [CountryId]) VALUES (5, N'Hearst', 4)
INSERT [dbo].[Town] ([Id], [Name], [CountryId]) VALUES (6, N'Monte Giberto', 9)
INSERT [dbo].[Town] ([Id], [Name], [CountryId]) VALUES (7, N'Olen', 10)
INSERT [dbo].[Town] ([Id], [Name], [CountryId]) VALUES (8, N'Westmount', 7)
INSERT [dbo].[Town] ([Id], [Name], [CountryId]) VALUES (9, N'Milestone', 8)
INSERT [dbo].[Town] ([Id], [Name], [CountryId]) VALUES (10, N'Fermont', 9)
INSERT [dbo].[Town] ([Id], [Name], [CountryId]) VALUES (11, N'Jodoigne', 3)
INSERT [dbo].[Town] ([Id], [Name], [CountryId]) VALUES (12, N'Malegaon', 7)
INSERT [dbo].[Town] ([Id], [Name], [CountryId]) VALUES (13, N'Salzgitter', 6)
INSERT [dbo].[Town] ([Id], [Name], [CountryId]) VALUES (14, N'Montone', 1)
INSERT [dbo].[Town] ([Id], [Name], [CountryId]) VALUES (15, N'Morwell', 10)
INSERT [dbo].[Town] ([Id], [Name], [CountryId]) VALUES (16, N'Newport', 4)
INSERT [dbo].[Town] ([Id], [Name], [CountryId]) VALUES (17, N'Maransart', 5)
INSERT [dbo].[Town] ([Id], [Name], [CountryId]) VALUES (18, N'Aiello Calabro', 10)
INSERT [dbo].[Town] ([Id], [Name], [CountryId]) VALUES (19, N'Grand Island', 8)
INSERT [dbo].[Town] ([Id], [Name], [CountryId]) VALUES (20, N'Bleid', 10)
INSERT [dbo].[Town] ([Id], [Name], [CountryId]) VALUES (21, N'Hove', 6)
INSERT [dbo].[Town] ([Id], [Name], [CountryId]) VALUES (22, N'La Roche-sur-Yon', 6)
INSERT [dbo].[Town] ([Id], [Name], [CountryId]) VALUES (23, N'Assiniboia', 5)
INSERT [dbo].[Town] ([Id], [Name], [CountryId]) VALUES (24, N'Torno', 7)
INSERT [dbo].[Town] ([Id], [Name], [CountryId]) VALUES (25, N'Zele', 8)
INSERT [dbo].[Town] ([Id], [Name], [CountryId]) VALUES (26, N'Wardha', 7)
INSERT [dbo].[Town] ([Id], [Name], [CountryId]) VALUES (27, N'Tire', 3)
INSERT [dbo].[Town] ([Id], [Name], [CountryId]) VALUES (28, N'Damme', 10)
INSERT [dbo].[Town] ([Id], [Name], [CountryId]) VALUES (29, N'Gent', 10)
INSERT [dbo].[Town] ([Id], [Name], [CountryId]) VALUES (30, N'Tione di Trento', 2)
INSERT [dbo].[Town] ([Id], [Name], [CountryId]) VALUES (31, N'Cap-Saint-Ignace', 10)
INSERT [dbo].[Town] ([Id], [Name], [CountryId]) VALUES (32, N'Berbroek', 2)
INSERT [dbo].[Town] ([Id], [Name], [CountryId]) VALUES (33, N'Imphal', 5)
INSERT [dbo].[Town] ([Id], [Name], [CountryId]) VALUES (34, N'Waarloos', 1)
INSERT [dbo].[Town] ([Id], [Name], [CountryId]) VALUES (35, N'Louisville', 8)
INSERT [dbo].[Town] ([Id], [Name], [CountryId]) VALUES (36, N'Castor', 10)
INSERT [dbo].[Town] ([Id], [Name], [CountryId]) VALUES (37, N'San Vito al Tagliamento', 9)
INSERT [dbo].[Town] ([Id], [Name], [CountryId]) VALUES (38, N'Stavoren', 9)
INSERT [dbo].[Town] ([Id], [Name], [CountryId]) VALUES (39, N'Stranraer', 7)
INSERT [dbo].[Town] ([Id], [Name], [CountryId]) VALUES (40, N'Jasper', 4)
INSERT [dbo].[Town] ([Id], [Name], [CountryId]) VALUES (41, N'Kolhapur', 9)
INSERT [dbo].[Town] ([Id], [Name], [CountryId]) VALUES (42, N'Henderson', 7)
INSERT [dbo].[Town] ([Id], [Name], [CountryId]) VALUES (43, N'Maltignano', 10)
INSERT [dbo].[Town] ([Id], [Name], [CountryId]) VALUES (44, N'Dabgram', 1)
INSERT [dbo].[Town] ([Id], [Name], [CountryId]) VALUES (45, N'Stamford', 5)
INSERT [dbo].[Town] ([Id], [Name], [CountryId]) VALUES (46, N'Poitiers', 5)
INSERT [dbo].[Town] ([Id], [Name], [CountryId]) VALUES (47, N'Brescia', 1)
INSERT [dbo].[Town] ([Id], [Name], [CountryId]) VALUES (48, N'Kitzbühel', 8)
INSERT [dbo].[Town] ([Id], [Name], [CountryId]) VALUES (49, N'Dreieich', 2)
INSERT [dbo].[Town] ([Id], [Name], [CountryId]) VALUES (50, N'Outrijve', 10)
INSERT [dbo].[Town] ([Id], [Name], [CountryId]) VALUES (51, N'Pozanti', 2)
INSERT [dbo].[Town] ([Id], [Name], [CountryId]) VALUES (52, N'Labrecque', 5)
INSERT [dbo].[Town] ([Id], [Name], [CountryId]) VALUES (53, N'Ife', 10)
INSERT [dbo].[Town] ([Id], [Name], [CountryId]) VALUES (54, N'Loverval', 4)
INSERT [dbo].[Town] ([Id], [Name], [CountryId]) VALUES (55, N'Itapipoca', 3)
INSERT [dbo].[Town] ([Id], [Name], [CountryId]) VALUES (56, N'Pictou', 10)
INSERT [dbo].[Town] ([Id], [Name], [CountryId]) VALUES (57, N'Barbania', 7)
INSERT [dbo].[Town] ([Id], [Name], [CountryId]) VALUES (58, N'Halesowen', 2)
INSERT [dbo].[Town] ([Id], [Name], [CountryId]) VALUES (59, N'Wrigley', 8)
INSERT [dbo].[Town] ([Id], [Name], [CountryId]) VALUES (60, N'Beausejour', 5)
INSERT [dbo].[Town] ([Id], [Name], [CountryId]) VALUES (61, N'Pollena Trocchia', 4)
INSERT [dbo].[Town] ([Id], [Name], [CountryId]) VALUES (62, N'Baracaldo', 5)
INSERT [dbo].[Town] ([Id], [Name], [CountryId]) VALUES (63, N'Port Alice', 1)
INSERT [dbo].[Town] ([Id], [Name], [CountryId]) VALUES (64, N'Signeulx', 5)
INSERT [dbo].[Town] ([Id], [Name], [CountryId]) VALUES (65, N'Tain', 1)
INSERT [dbo].[Town] ([Id], [Name], [CountryId]) VALUES (66, N'Emblem', 1)
INSERT [dbo].[Town] ([Id], [Name], [CountryId]) VALUES (67, N'Caen', 7)
INSERT [dbo].[Town] ([Id], [Name], [CountryId]) VALUES (68, N'Castanhal', 1)
INSERT [dbo].[Town] ([Id], [Name], [CountryId]) VALUES (69, N'Gojra', 4)
INSERT [dbo].[Town] ([Id], [Name], [CountryId]) VALUES (70, N'Chestermere', 5)
INSERT [dbo].[Town] ([Id], [Name], [CountryId]) VALUES (71, N'Grivegnée', 1)
INSERT [dbo].[Town] ([Id], [Name], [CountryId]) VALUES (72, N'Couillet', 8)
INSERT [dbo].[Town] ([Id], [Name], [CountryId]) VALUES (73, N'Monte Santa Maria Tiberina', 1)
INSERT [dbo].[Town] ([Id], [Name], [CountryId]) VALUES (74, N'Issy-les-Moulineaux', 2)
INSERT [dbo].[Town] ([Id], [Name], [CountryId]) VALUES (75, N'Kitzbühel', 1)
INSERT [dbo].[Town] ([Id], [Name], [CountryId]) VALUES (76, N'Tillet', 7)
INSERT [dbo].[Town] ([Id], [Name], [CountryId]) VALUES (77, N'Lacombe', 5)
INSERT [dbo].[Town] ([Id], [Name], [CountryId]) VALUES (78, N'Francavilla in Sinni', 2)
INSERT [dbo].[Town] ([Id], [Name], [CountryId]) VALUES (79, N'Naro', 6)
INSERT [dbo].[Town] ([Id], [Name], [CountryId]) VALUES (80, N'Wolkrange', 4)
INSERT [dbo].[Town] ([Id], [Name], [CountryId]) VALUES (81, N'Hollabrunn', 8)
INSERT [dbo].[Town] ([Id], [Name], [CountryId]) VALUES (82, N'Bernau', 4)
INSERT [dbo].[Town] ([Id], [Name], [CountryId]) VALUES (83, N'Dunfermline', 3)
INSERT [dbo].[Town] ([Id], [Name], [CountryId]) VALUES (84, N'Warminster', 10)
INSERT [dbo].[Town] ([Id], [Name], [CountryId]) VALUES (85, N'Delft', 1)
INSERT [dbo].[Town] ([Id], [Name], [CountryId]) VALUES (86, N'Baiso', 2)
INSERT [dbo].[Town] ([Id], [Name], [CountryId]) VALUES (87, N'Pinneberg', 7)
INSERT [dbo].[Town] ([Id], [Name], [CountryId]) VALUES (88, N'Gorakhpur', 2)
INSERT [dbo].[Town] ([Id], [Name], [CountryId]) VALUES (89, N'Barddhaman', 10)
INSERT [dbo].[Town] ([Id], [Name], [CountryId]) VALUES (90, N'Eisenh?ttenstadt', 8)
INSERT [dbo].[Town] ([Id], [Name], [CountryId]) VALUES (91, N'Zelem', 8)
INSERT [dbo].[Town] ([Id], [Name], [CountryId]) VALUES (92, N'Fratta Todina', 8)
INSERT [dbo].[Town] ([Id], [Name], [CountryId]) VALUES (93, N'Freising', 10)
INSERT [dbo].[Town] ([Id], [Name], [CountryId]) VALUES (94, N'Navsari', 2)
INSERT [dbo].[Town] ([Id], [Name], [CountryId]) VALUES (95, N'Tavistock', 7)
INSERT [dbo].[Town] ([Id], [Name], [CountryId]) VALUES (96, N'Bhavnagar', 3)
INSERT [dbo].[Town] ([Id], [Name], [CountryId]) VALUES (97, N'Ebenthal in Kärnten', 7)
INSERT [dbo].[Town] ([Id], [Name], [CountryId]) VALUES (98, N'Heikruis', 6)
INSERT [dbo].[Town] ([Id], [Name], [CountryId]) VALUES (99, N'Monte San Giovanni in Sabina', 2)
GO
INSERT [dbo].[Town] ([Id], [Name], [CountryId]) VALUES (100, N'Val Rezzo', 6)
SET IDENTITY_INSERT [dbo].[Town] OFF
USE [master]
GO
ALTER DATABASE [GlobalResearch] SET  READ_WRITE 
GO
