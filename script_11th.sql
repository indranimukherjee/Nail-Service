USE [master]
GO
/****** Object:  Database [nail_service]    Script Date: 12/11/2015 8:25:20 PM ******/
CREATE DATABASE [nail_service]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'nail_service', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL12.SQL2014\MSSQL\DATA\nail_service.mdf' , SIZE = 4096KB , MAXSIZE = UNLIMITED, FILEGROWTH = 1024KB )
 LOG ON 
( NAME = N'nail_service_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL12.SQL2014\MSSQL\DATA\nail_service_log.ldf' , SIZE = 1536KB , MAXSIZE = 2048GB , FILEGROWTH = 10%)
GO
ALTER DATABASE [nail_service] SET COMPATIBILITY_LEVEL = 120
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [nail_service].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [nail_service] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [nail_service] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [nail_service] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [nail_service] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [nail_service] SET ARITHABORT OFF 
GO
ALTER DATABASE [nail_service] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [nail_service] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [nail_service] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [nail_service] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [nail_service] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [nail_service] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [nail_service] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [nail_service] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [nail_service] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [nail_service] SET  DISABLE_BROKER 
GO
ALTER DATABASE [nail_service] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [nail_service] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [nail_service] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [nail_service] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [nail_service] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [nail_service] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [nail_service] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [nail_service] SET RECOVERY FULL 
GO
ALTER DATABASE [nail_service] SET  MULTI_USER 
GO
ALTER DATABASE [nail_service] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [nail_service] SET DB_CHAINING OFF 
GO
ALTER DATABASE [nail_service] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [nail_service] SET TARGET_RECOVERY_TIME = 0 SECONDS 
GO
ALTER DATABASE [nail_service] SET DELAYED_DURABILITY = DISABLED 
GO
EXEC sys.sp_db_vardecimal_storage_format N'nail_service', N'ON'
GO
USE [nail_service]
GO
/****** Object:  Table [dbo].[BillDesk]    Script Date: 12/11/2015 8:25:22 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[BillDesk](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[ServiceBilldeskId] [int] NOT NULL,
	[ServiceID] [int] NOT NULL,
	[ServiceDurationId] [int] NOT NULL,
	[ServiceTotalAmount] [nvarchar](max) NOT NULL,
	[NoOfPerson] [int] NOT NULL,
 CONSTRAINT [PK_BillDesk] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
/****** Object:  Table [dbo].[booking]    Script Date: 12/11/2015 8:25:22 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[booking](
	[booking_id] [int] IDENTITY(1,1) NOT NULL,
	[consumer_first_name] [varchar](50) NOT NULL,
	[consumer_last_name] [varchar](50) NOT NULL,
	[consumer__mobileno] [nvarchar](15) NOT NULL,
	[consumer_email] [varchar](50) NOT NULL,
	[booking_date] [date] NOT NULL,
	[SlotID] [int] NOT NULL,
	[BillDeskID] [int] NOT NULL,
	[TotalAmount] [nvarchar](max) NOT NULL,
	[TotalQuantity] [int] NOT NULL,
 CONSTRAINT [PK_booking] PRIMARY KEY CLUSTERED 
(
	[booking_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[ServiceBillDesk]    Script Date: 12/11/2015 8:25:22 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ServiceBillDesk](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[ServiceID] [int] NOT NULL,
	[ServiceDurationID] [int] NOT NULL,
	[ServicePriceID] [int] NOT NULL,
	[ServiceVeriationID] [int] NOT NULL,
	[ServiceAmount] [nvarchar](max) NOT NULL,
	[ServiceQuantity] [int] NOT NULL,
 CONSTRAINT [PK_ServiceMaster] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
/****** Object:  Table [dbo].[ServiceDuration]    Script Date: 12/11/2015 8:25:22 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ServiceDuration](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[ServiceDuration] [nvarchar](max) NOT NULL,
 CONSTRAINT [PK_ServiceDuration] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
/****** Object:  Table [dbo].[ServiceMaster]    Script Date: 12/11/2015 8:25:22 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ServiceMaster](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[ServiceType] [nvarchar](max) NOT NULL,
	[ServiceDesc] [nvarchar](max) NULL,
	[ParentServiceId] [int] NULL,
 CONSTRAINT [PK_Service] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
/****** Object:  Table [dbo].[ServicePrice]    Script Date: 12/11/2015 8:25:22 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ServicePrice](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[ServicePrice] [nvarchar](50) NOT NULL,
 CONSTRAINT [PK_ServicePrice] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[ServiceVeriation]    Script Date: 12/11/2015 8:25:22 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ServiceVeriation](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[ServiceVariation] [nvarchar](50) NOT NULL,
 CONSTRAINT [PK_ServiceVeriation] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Slot]    Script Date: 12/11/2015 8:25:22 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Slot](
	[SlotID] [int] IDENTITY(1,1) NOT NULL,
	[SlotType] [nvarchar](max) NOT NULL,
 CONSTRAINT [PK_Slot] PRIMARY KEY CLUSTERED 
(
	[SlotID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
/****** Object:  Table [dbo].[visitor]    Script Date: 12/11/2015 8:25:22 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[visitor](
	[vstr_id] [int] IDENTITY(1,1) NOT NULL,
	[visitor_name] [varchar](50) NOT NULL,
	[visitor_location] [varchar](200) NOT NULL,
	[visitor_phoneno] [nvarchar](15) NOT NULL,
	[visitor_email] [nvarchar](50) NOT NULL,
	[testimonials] [nvarchar](max) NULL,
	[enquiry] [nvarchar](max) NULL,
 CONSTRAINT [PK_visitor] PRIMARY KEY CLUSTERED 
(
	[vstr_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
SET IDENTITY_INSERT [dbo].[ServiceBillDesk] ON 

INSERT [dbo].[ServiceBillDesk] ([ID], [ServiceID], [ServiceDurationID], [ServicePriceID], [ServiceVeriationID], [ServiceAmount], [ServiceQuantity]) VALUES (1, 1, 1, 1, 1, N'£10', 1)
INSERT [dbo].[ServiceBillDesk] ([ID], [ServiceID], [ServiceDurationID], [ServicePriceID], [ServiceVeriationID], [ServiceAmount], [ServiceQuantity]) VALUES (2, 1, 2, 3, 2, N'£20', 1)
INSERT [dbo].[ServiceBillDesk] ([ID], [ServiceID], [ServiceDurationID], [ServicePriceID], [ServiceVeriationID], [ServiceAmount], [ServiceQuantity]) VALUES (3, 1, 3, 5, 3, N'£25', 1)
INSERT [dbo].[ServiceBillDesk] ([ID], [ServiceID], [ServiceDurationID], [ServicePriceID], [ServiceVeriationID], [ServiceAmount], [ServiceQuantity]) VALUES (4, 2, 1, 2, 1, N'£15', 1)
INSERT [dbo].[ServiceBillDesk] ([ID], [ServiceID], [ServiceDurationID], [ServicePriceID], [ServiceVeriationID], [ServiceAmount], [ServiceQuantity]) VALUES (5, 2, 2, 3, 2, N'£20', 1)
INSERT [dbo].[ServiceBillDesk] ([ID], [ServiceID], [ServiceDurationID], [ServicePriceID], [ServiceVeriationID], [ServiceAmount], [ServiceQuantity]) VALUES (6, 2, 3, 7, 3, N'£30', 1)
INSERT [dbo].[ServiceBillDesk] ([ID], [ServiceID], [ServiceDurationID], [ServicePriceID], [ServiceVeriationID], [ServiceAmount], [ServiceQuantity]) VALUES (7, 3, 1, 3, 1, N'£20', 1)
INSERT [dbo].[ServiceBillDesk] ([ID], [ServiceID], [ServiceDurationID], [ServicePriceID], [ServiceVeriationID], [ServiceAmount], [ServiceQuantity]) VALUES (8, 3, 4, 5, 2, N'£25', 1)
INSERT [dbo].[ServiceBillDesk] ([ID], [ServiceID], [ServiceDurationID], [ServicePriceID], [ServiceVeriationID], [ServiceAmount], [ServiceQuantity]) VALUES (9, 3, 5, 7, 3, N'£30', 1)
INSERT [dbo].[ServiceBillDesk] ([ID], [ServiceID], [ServiceDurationID], [ServicePriceID], [ServiceVeriationID], [ServiceAmount], [ServiceQuantity]) VALUES (10, 4, 7, 7, 1, N'£30', 1)
INSERT [dbo].[ServiceBillDesk] ([ID], [ServiceID], [ServiceDurationID], [ServicePriceID], [ServiceVeriationID], [ServiceAmount], [ServiceQuantity]) VALUES (11, 4, 7, 8, 2, N'£45', 1)
INSERT [dbo].[ServiceBillDesk] ([ID], [ServiceID], [ServiceDurationID], [ServicePriceID], [ServiceVeriationID], [ServiceAmount], [ServiceQuantity]) VALUES (12, 4, 7, 10, 3, N'£64', 1)
INSERT [dbo].[ServiceBillDesk] ([ID], [ServiceID], [ServiceDurationID], [ServicePriceID], [ServiceVeriationID], [ServiceAmount], [ServiceQuantity]) VALUES (13, 5, 5, 7, 1, N'£30', 1)
INSERT [dbo].[ServiceBillDesk] ([ID], [ServiceID], [ServiceDurationID], [ServicePriceID], [ServiceVeriationID], [ServiceAmount], [ServiceQuantity]) VALUES (14, 5, 6, 9, 2, N'£46', 1)
INSERT [dbo].[ServiceBillDesk] ([ID], [ServiceID], [ServiceDurationID], [ServicePriceID], [ServiceVeriationID], [ServiceAmount], [ServiceQuantity]) VALUES (15, 5, 7, 10, 3, N'£64', 1)
INSERT [dbo].[ServiceBillDesk] ([ID], [ServiceID], [ServiceDurationID], [ServicePriceID], [ServiceVeriationID], [ServiceAmount], [ServiceQuantity]) VALUES (16, 6, 5, 4, 1, N'£22', 1)
INSERT [dbo].[ServiceBillDesk] ([ID], [ServiceID], [ServiceDurationID], [ServicePriceID], [ServiceVeriationID], [ServiceAmount], [ServiceQuantity]) VALUES (17, 6, 6, 6, 2, N'£27', 1)
INSERT [dbo].[ServiceBillDesk] ([ID], [ServiceID], [ServiceDurationID], [ServicePriceID], [ServiceVeriationID], [ServiceAmount], [ServiceQuantity]) VALUES (18, 6, 7, 7, 3, N'£30', 1)
INSERT [dbo].[ServiceBillDesk] ([ID], [ServiceID], [ServiceDurationID], [ServicePriceID], [ServiceVeriationID], [ServiceAmount], [ServiceQuantity]) VALUES (19, 7, 2, 1, 1, N'£10', 1)
INSERT [dbo].[ServiceBillDesk] ([ID], [ServiceID], [ServiceDurationID], [ServicePriceID], [ServiceVeriationID], [ServiceAmount], [ServiceQuantity]) VALUES (20, 7, 3, 2, 2, N'£15', 1)
INSERT [dbo].[ServiceBillDesk] ([ID], [ServiceID], [ServiceDurationID], [ServicePriceID], [ServiceVeriationID], [ServiceAmount], [ServiceQuantity]) VALUES (21, 7, 4, 5, 3, N'£25', 1)
INSERT [dbo].[ServiceBillDesk] ([ID], [ServiceID], [ServiceDurationID], [ServicePriceID], [ServiceVeriationID], [ServiceAmount], [ServiceQuantity]) VALUES (22, 9, 5, 5, 1, N'£25', 1)
INSERT [dbo].[ServiceBillDesk] ([ID], [ServiceID], [ServiceDurationID], [ServicePriceID], [ServiceVeriationID], [ServiceAmount], [ServiceQuantity]) VALUES (23, 9, 6, 7, 2, N'£30', 1)
INSERT [dbo].[ServiceBillDesk] ([ID], [ServiceID], [ServiceDurationID], [ServicePriceID], [ServiceVeriationID], [ServiceAmount], [ServiceQuantity]) VALUES (24, 9, 7, 8, 3, N'£45', 1)
INSERT [dbo].[ServiceBillDesk] ([ID], [ServiceID], [ServiceDurationID], [ServicePriceID], [ServiceVeriationID], [ServiceAmount], [ServiceQuantity]) VALUES (25, 10, 1, 1, 1, N'£10', 1)
INSERT [dbo].[ServiceBillDesk] ([ID], [ServiceID], [ServiceDurationID], [ServicePriceID], [ServiceVeriationID], [ServiceAmount], [ServiceQuantity]) VALUES (26, 10, 2, 3, 2, N'£20', 1)
INSERT [dbo].[ServiceBillDesk] ([ID], [ServiceID], [ServiceDurationID], [ServicePriceID], [ServiceVeriationID], [ServiceAmount], [ServiceQuantity]) VALUES (27, 10, 3, 7, 3, N'£30', 1)
INSERT [dbo].[ServiceBillDesk] ([ID], [ServiceID], [ServiceDurationID], [ServicePriceID], [ServiceVeriationID], [ServiceAmount], [ServiceQuantity]) VALUES (28, 12, 1, 1, 1, N'£10', 1)
INSERT [dbo].[ServiceBillDesk] ([ID], [ServiceID], [ServiceDurationID], [ServicePriceID], [ServiceVeriationID], [ServiceAmount], [ServiceQuantity]) VALUES (29, 12, 2, 3, 2, N'£20', 1)
INSERT [dbo].[ServiceBillDesk] ([ID], [ServiceID], [ServiceDurationID], [ServicePriceID], [ServiceVeriationID], [ServiceAmount], [ServiceQuantity]) VALUES (30, 12, 3, 7, 3, N'£30', 1)
INSERT [dbo].[ServiceBillDesk] ([ID], [ServiceID], [ServiceDurationID], [ServicePriceID], [ServiceVeriationID], [ServiceAmount], [ServiceQuantity]) VALUES (31, 13, 1, 1, 1, N'£10', 1)
INSERT [dbo].[ServiceBillDesk] ([ID], [ServiceID], [ServiceDurationID], [ServicePriceID], [ServiceVeriationID], [ServiceAmount], [ServiceQuantity]) VALUES (32, 13, 2, 3, 2, N'£20', 1)
INSERT [dbo].[ServiceBillDesk] ([ID], [ServiceID], [ServiceDurationID], [ServicePriceID], [ServiceVeriationID], [ServiceAmount], [ServiceQuantity]) VALUES (33, 13, 3, 7, 3, N'£30', 1)
INSERT [dbo].[ServiceBillDesk] ([ID], [ServiceID], [ServiceDurationID], [ServicePriceID], [ServiceVeriationID], [ServiceAmount], [ServiceQuantity]) VALUES (34, 15, 1, 1, 1, N'£10', 1)
INSERT [dbo].[ServiceBillDesk] ([ID], [ServiceID], [ServiceDurationID], [ServicePriceID], [ServiceVeriationID], [ServiceAmount], [ServiceQuantity]) VALUES (35, 15, 2, 3, 2, N'£20', 1)
INSERT [dbo].[ServiceBillDesk] ([ID], [ServiceID], [ServiceDurationID], [ServicePriceID], [ServiceVeriationID], [ServiceAmount], [ServiceQuantity]) VALUES (36, 15, 3, 7, 3, N'£30', 1)
INSERT [dbo].[ServiceBillDesk] ([ID], [ServiceID], [ServiceDurationID], [ServicePriceID], [ServiceVeriationID], [ServiceAmount], [ServiceQuantity]) VALUES (37, 16, 1, 1, 1, N'£10', 1)
INSERT [dbo].[ServiceBillDesk] ([ID], [ServiceID], [ServiceDurationID], [ServicePriceID], [ServiceVeriationID], [ServiceAmount], [ServiceQuantity]) VALUES (38, 16, 2, 3, 2, N'£20', 1)
INSERT [dbo].[ServiceBillDesk] ([ID], [ServiceID], [ServiceDurationID], [ServicePriceID], [ServiceVeriationID], [ServiceAmount], [ServiceQuantity]) VALUES (39, 16, 3, 7, 3, N'£30', 1)
INSERT [dbo].[ServiceBillDesk] ([ID], [ServiceID], [ServiceDurationID], [ServicePriceID], [ServiceVeriationID], [ServiceAmount], [ServiceQuantity]) VALUES (40, 17, 1, 1, 1, N'£10', 1)
INSERT [dbo].[ServiceBillDesk] ([ID], [ServiceID], [ServiceDurationID], [ServicePriceID], [ServiceVeriationID], [ServiceAmount], [ServiceQuantity]) VALUES (41, 17, 2, 3, 2, N'£20', 1)
INSERT [dbo].[ServiceBillDesk] ([ID], [ServiceID], [ServiceDurationID], [ServicePriceID], [ServiceVeriationID], [ServiceAmount], [ServiceQuantity]) VALUES (42, 17, 3, 7, 3, N'£30', 1)
INSERT [dbo].[ServiceBillDesk] ([ID], [ServiceID], [ServiceDurationID], [ServicePriceID], [ServiceVeriationID], [ServiceAmount], [ServiceQuantity]) VALUES (43, 18, 1, 1, 1, N'£10', 1)
INSERT [dbo].[ServiceBillDesk] ([ID], [ServiceID], [ServiceDurationID], [ServicePriceID], [ServiceVeriationID], [ServiceAmount], [ServiceQuantity]) VALUES (44, 18, 2, 2, 3, N'£20', 1)
INSERT [dbo].[ServiceBillDesk] ([ID], [ServiceID], [ServiceDurationID], [ServicePriceID], [ServiceVeriationID], [ServiceAmount], [ServiceQuantity]) VALUES (45, 18, 3, 3, 2, N'£30', 1)
INSERT [dbo].[ServiceBillDesk] ([ID], [ServiceID], [ServiceDurationID], [ServicePriceID], [ServiceVeriationID], [ServiceAmount], [ServiceQuantity]) VALUES (46, 19, 3, 7, 1, N'£30', 1)
INSERT [dbo].[ServiceBillDesk] ([ID], [ServiceID], [ServiceDurationID], [ServicePriceID], [ServiceVeriationID], [ServiceAmount], [ServiceQuantity]) VALUES (47, 19, 4, 8, 2, N'£45', 1)
INSERT [dbo].[ServiceBillDesk] ([ID], [ServiceID], [ServiceDurationID], [ServicePriceID], [ServiceVeriationID], [ServiceAmount], [ServiceQuantity]) VALUES (48, 19, 5, 10, 3, N'£64', 1)
INSERT [dbo].[ServiceBillDesk] ([ID], [ServiceID], [ServiceDurationID], [ServicePriceID], [ServiceVeriationID], [ServiceAmount], [ServiceQuantity]) VALUES (49, 23, 5, 10, 1, N'£64', 1)
INSERT [dbo].[ServiceBillDesk] ([ID], [ServiceID], [ServiceDurationID], [ServicePriceID], [ServiceVeriationID], [ServiceAmount], [ServiceQuantity]) VALUES (50, 23, 6, 11, 2, N'£120', 1)
INSERT [dbo].[ServiceBillDesk] ([ID], [ServiceID], [ServiceDurationID], [ServicePriceID], [ServiceVeriationID], [ServiceAmount], [ServiceQuantity]) VALUES (51, 23, 7, 12, 3, N'£250', 1)
INSERT [dbo].[ServiceBillDesk] ([ID], [ServiceID], [ServiceDurationID], [ServicePriceID], [ServiceVeriationID], [ServiceAmount], [ServiceQuantity]) VALUES (52, 24, 4, 7, 1, N'£30', 1)
INSERT [dbo].[ServiceBillDesk] ([ID], [ServiceID], [ServiceDurationID], [ServicePriceID], [ServiceVeriationID], [ServiceAmount], [ServiceQuantity]) VALUES (53, 24, 6, 8, 2, N'£45', 1)
INSERT [dbo].[ServiceBillDesk] ([ID], [ServiceID], [ServiceDurationID], [ServicePriceID], [ServiceVeriationID], [ServiceAmount], [ServiceQuantity]) VALUES (54, 24, 7, 10, 3, N'£64', 1)
INSERT [dbo].[ServiceBillDesk] ([ID], [ServiceID], [ServiceDurationID], [ServicePriceID], [ServiceVeriationID], [ServiceAmount], [ServiceQuantity]) VALUES (55, 26, 5, 9, 1, N'£46', 1)
INSERT [dbo].[ServiceBillDesk] ([ID], [ServiceID], [ServiceDurationID], [ServicePriceID], [ServiceVeriationID], [ServiceAmount], [ServiceQuantity]) VALUES (56, 26, 6, 10, 2, N'£64', 1)
INSERT [dbo].[ServiceBillDesk] ([ID], [ServiceID], [ServiceDurationID], [ServicePriceID], [ServiceVeriationID], [ServiceAmount], [ServiceQuantity]) VALUES (57, 26, 7, 11, 3, N'£120', 1)
INSERT [dbo].[ServiceBillDesk] ([ID], [ServiceID], [ServiceDurationID], [ServicePriceID], [ServiceVeriationID], [ServiceAmount], [ServiceQuantity]) VALUES (58, 28, 5, 9, 1, N'£46', 1)
INSERT [dbo].[ServiceBillDesk] ([ID], [ServiceID], [ServiceDurationID], [ServicePriceID], [ServiceVeriationID], [ServiceAmount], [ServiceQuantity]) VALUES (59, 28, 6, 10, 2, N'£64', 1)
INSERT [dbo].[ServiceBillDesk] ([ID], [ServiceID], [ServiceDurationID], [ServicePriceID], [ServiceVeriationID], [ServiceAmount], [ServiceQuantity]) VALUES (60, 28, 7, 11, 3, N'£120', 1)
INSERT [dbo].[ServiceBillDesk] ([ID], [ServiceID], [ServiceDurationID], [ServicePriceID], [ServiceVeriationID], [ServiceAmount], [ServiceQuantity]) VALUES (61, 29, 5, 9, 1, N'£46', 1)
INSERT [dbo].[ServiceBillDesk] ([ID], [ServiceID], [ServiceDurationID], [ServicePriceID], [ServiceVeriationID], [ServiceAmount], [ServiceQuantity]) VALUES (62, 29, 6, 10, 2, N'£64', 1)
INSERT [dbo].[ServiceBillDesk] ([ID], [ServiceID], [ServiceDurationID], [ServicePriceID], [ServiceVeriationID], [ServiceAmount], [ServiceQuantity]) VALUES (63, 29, 7, 11, 3, N'£120', 1)
INSERT [dbo].[ServiceBillDesk] ([ID], [ServiceID], [ServiceDurationID], [ServicePriceID], [ServiceVeriationID], [ServiceAmount], [ServiceQuantity]) VALUES (64, 31, 5, 9, 1, N'£46', 1)
INSERT [dbo].[ServiceBillDesk] ([ID], [ServiceID], [ServiceDurationID], [ServicePriceID], [ServiceVeriationID], [ServiceAmount], [ServiceQuantity]) VALUES (65, 31, 6, 10, 2, N'£64', 1)
INSERT [dbo].[ServiceBillDesk] ([ID], [ServiceID], [ServiceDurationID], [ServicePriceID], [ServiceVeriationID], [ServiceAmount], [ServiceQuantity]) VALUES (66, 31, 7, 11, 3, N'£120', 1)
INSERT [dbo].[ServiceBillDesk] ([ID], [ServiceID], [ServiceDurationID], [ServicePriceID], [ServiceVeriationID], [ServiceAmount], [ServiceQuantity]) VALUES (67, 32, 5, 9, 1, N'£46', 1)
INSERT [dbo].[ServiceBillDesk] ([ID], [ServiceID], [ServiceDurationID], [ServicePriceID], [ServiceVeriationID], [ServiceAmount], [ServiceQuantity]) VALUES (68, 32, 6, 10, 2, N'£64', 1)
INSERT [dbo].[ServiceBillDesk] ([ID], [ServiceID], [ServiceDurationID], [ServicePriceID], [ServiceVeriationID], [ServiceAmount], [ServiceQuantity]) VALUES (69, 32, 7, 11, 3, N'£120', 1)
INSERT [dbo].[ServiceBillDesk] ([ID], [ServiceID], [ServiceDurationID], [ServicePriceID], [ServiceVeriationID], [ServiceAmount], [ServiceQuantity]) VALUES (70, 1014, 1, 2, 1, N'£15', 1)
INSERT [dbo].[ServiceBillDesk] ([ID], [ServiceID], [ServiceDurationID], [ServicePriceID], [ServiceVeriationID], [ServiceAmount], [ServiceQuantity]) VALUES (71, 1014, 2, 3, 2, N'£20', 1)
INSERT [dbo].[ServiceBillDesk] ([ID], [ServiceID], [ServiceDurationID], [ServicePriceID], [ServiceVeriationID], [ServiceAmount], [ServiceQuantity]) VALUES (72, 1014, 3, 5, 3, N'£30', 1)
INSERT [dbo].[ServiceBillDesk] ([ID], [ServiceID], [ServiceDurationID], [ServicePriceID], [ServiceVeriationID], [ServiceAmount], [ServiceQuantity]) VALUES (73, 1015, 4, 6, 1, N'£27', 1)
INSERT [dbo].[ServiceBillDesk] ([ID], [ServiceID], [ServiceDurationID], [ServicePriceID], [ServiceVeriationID], [ServiceAmount], [ServiceQuantity]) VALUES (74, 1015, 5, 8, 2, N'£45', 1)
INSERT [dbo].[ServiceBillDesk] ([ID], [ServiceID], [ServiceDurationID], [ServicePriceID], [ServiceVeriationID], [ServiceAmount], [ServiceQuantity]) VALUES (75, 1015, 6, 10, 3, N'£64', 1)
INSERT [dbo].[ServiceBillDesk] ([ID], [ServiceID], [ServiceDurationID], [ServicePriceID], [ServiceVeriationID], [ServiceAmount], [ServiceQuantity]) VALUES (76, 1016, 6, 10, 1, N'£64', 1)
INSERT [dbo].[ServiceBillDesk] ([ID], [ServiceID], [ServiceDurationID], [ServicePriceID], [ServiceVeriationID], [ServiceAmount], [ServiceQuantity]) VALUES (77, 1016, 7, 11, 2, N'£120', 1)
INSERT [dbo].[ServiceBillDesk] ([ID], [ServiceID], [ServiceDurationID], [ServicePriceID], [ServiceVeriationID], [ServiceAmount], [ServiceQuantity]) VALUES (78, 1016, 8, 12, 3, N'£250', 1)
SET IDENTITY_INSERT [dbo].[ServiceBillDesk] OFF
SET IDENTITY_INSERT [dbo].[ServiceDuration] ON 

INSERT [dbo].[ServiceDuration] ([ID], [ServiceDuration]) VALUES (1, N'15mins')
INSERT [dbo].[ServiceDuration] ([ID], [ServiceDuration]) VALUES (2, N'20mins')
INSERT [dbo].[ServiceDuration] ([ID], [ServiceDuration]) VALUES (3, N'25mins')
INSERT [dbo].[ServiceDuration] ([ID], [ServiceDuration]) VALUES (4, N'45mins')
INSERT [dbo].[ServiceDuration] ([ID], [ServiceDuration]) VALUES (5, N'55mins')
INSERT [dbo].[ServiceDuration] ([ID], [ServiceDuration]) VALUES (6, N'60mins')
INSERT [dbo].[ServiceDuration] ([ID], [ServiceDuration]) VALUES (7, N'85mins')
INSERT [dbo].[ServiceDuration] ([ID], [ServiceDuration]) VALUES (8, N'120mins')
SET IDENTITY_INSERT [dbo].[ServiceDuration] OFF
SET IDENTITY_INSERT [dbo].[ServiceMaster] ON 

INSERT [dbo].[ServiceMaster] ([ID], [ServiceType], [ServiceDesc], [ParentServiceId]) VALUES (1, N'Nail Art', N'Colourful Nail Art', NULL)
INSERT [dbo].[ServiceMaster] ([ID], [ServiceType], [ServiceDesc], [ParentServiceId]) VALUES (2, N'Paraffin Hand Treatment', N'Paraffin treatment', 2)
INSERT [dbo].[ServiceMaster] ([ID], [ServiceType], [ServiceDesc], [ParentServiceId]) VALUES (3, N'Paraffin Foot Treatment', N'Paraffin treatment', 3)
INSERT [dbo].[ServiceMaster] ([ID], [ServiceType], [ServiceDesc], [ParentServiceId]) VALUES (4, N'Gel Overlays', N'Gel nails', 1014)
INSERT [dbo].[ServiceMaster] ([ID], [ServiceType], [ServiceDesc], [ParentServiceId]) VALUES (5, N'Acrylic Overlays', N'Acrylic Nails', 1014)
INSERT [dbo].[ServiceMaster] ([ID], [ServiceType], [ServiceDesc], [ParentServiceId]) VALUES (6, N'Infills', N'Nail Infills', 6)
INSERT [dbo].[ServiceMaster] ([ID], [ServiceType], [ServiceDesc], [ParentServiceId]) VALUES (7, N'Soak off', N'Nail Soak_off', 7)
INSERT [dbo].[ServiceMaster] ([ID], [ServiceType], [ServiceDesc], [ParentServiceId]) VALUES (9, N'French Infill', N'Pink/White or any colors Infills', 6)
INSERT [dbo].[ServiceMaster] ([ID], [ServiceType], [ServiceDesc], [ParentServiceId]) VALUES (10, N'Velvet NailArt', N'nailartvalvet', 1)
INSERT [dbo].[ServiceMaster] ([ID], [ServiceType], [ServiceDesc], [ParentServiceId]) VALUES (12, N'Cavier NailArt', N'CavierNailArt', 1)
INSERT [dbo].[ServiceMaster] ([ID], [ServiceType], [ServiceDesc], [ParentServiceId]) VALUES (13, N'Crackle NailArt', N'CrackleNailArt', 1)
INSERT [dbo].[ServiceMaster] ([ID], [ServiceType], [ServiceDesc], [ParentServiceId]) VALUES (15, N'Neon NailArt', N'Nailart-neon', 1)
INSERT [dbo].[ServiceMaster] ([ID], [ServiceType], [ServiceDesc], [ParentServiceId]) VALUES (16, N'Glitter NailArt', N'Nailart-glitter', 1)
INSERT [dbo].[ServiceMaster] ([ID], [ServiceType], [ServiceDesc], [ParentServiceId]) VALUES (17, N'Mountain NailArt', N'Nailart-mountain', 1)
INSERT [dbo].[ServiceMaster] ([ID], [ServiceType], [ServiceDesc], [ParentServiceId]) VALUES (18, N'Beads NailArt', N'Nailart-beads', 1)
INSERT [dbo].[ServiceMaster] ([ID], [ServiceType], [ServiceDesc], [ParentServiceId]) VALUES (19, N'Wedding NailArt', N'Nailart-wedding', 1)
INSERT [dbo].[ServiceMaster] ([ID], [ServiceType], [ServiceDesc], [ParentServiceId]) VALUES (23, N'Paraffin Hand And Foot Treatment', N'Paraffin treatment', 23)
INSERT [dbo].[ServiceMaster] ([ID], [ServiceType], [ServiceDesc], [ParentServiceId]) VALUES (24, N'Manicure (Basic)', N'BasicManicure', 24)
INSERT [dbo].[ServiceMaster] ([ID], [ServiceType], [ServiceDesc], [ParentServiceId]) VALUES (26, N'French Manicure', N'Manicure', 24)
INSERT [dbo].[ServiceMaster] ([ID], [ServiceType], [ServiceDesc], [ParentServiceId]) VALUES (28, N'Reverse French Manicure', N'Manicure', 24)
INSERT [dbo].[ServiceMaster] ([ID], [ServiceType], [ServiceDesc], [ParentServiceId]) VALUES (29, N'Hotstone Manicure', N'Manicure', 24)
INSERT [dbo].[ServiceMaster] ([ID], [ServiceType], [ServiceDesc], [ParentServiceId]) VALUES (31, N'American Manicure', N'Manicure', 24)
INSERT [dbo].[ServiceMaster] ([ID], [ServiceType], [ServiceDesc], [ParentServiceId]) VALUES (32, N'Gel Manicure', N'Manicure', 24)
INSERT [dbo].[ServiceMaster] ([ID], [ServiceType], [ServiceDesc], [ParentServiceId]) VALUES (1014, N'Nail Overlays Regular', N'Overlays', 1014)
INSERT [dbo].[ServiceMaster] ([ID], [ServiceType], [ServiceDesc], [ParentServiceId]) VALUES (1015, N'Pedicure', N'Pedicure', 1015)
INSERT [dbo].[ServiceMaster] ([ID], [ServiceType], [ServiceDesc], [ParentServiceId]) VALUES (1016, N'Manicure And Pedicure', N'ManicureandPedicure', 1016)
SET IDENTITY_INSERT [dbo].[ServiceMaster] OFF
SET IDENTITY_INSERT [dbo].[ServicePrice] ON 

INSERT [dbo].[ServicePrice] ([ID], [ServicePrice]) VALUES (1, N'£10')
INSERT [dbo].[ServicePrice] ([ID], [ServicePrice]) VALUES (2, N'£15')
INSERT [dbo].[ServicePrice] ([ID], [ServicePrice]) VALUES (3, N'£20')
INSERT [dbo].[ServicePrice] ([ID], [ServicePrice]) VALUES (4, N'£22')
INSERT [dbo].[ServicePrice] ([ID], [ServicePrice]) VALUES (5, N'£25')
INSERT [dbo].[ServicePrice] ([ID], [ServicePrice]) VALUES (6, N'£27')
INSERT [dbo].[ServicePrice] ([ID], [ServicePrice]) VALUES (7, N'£30')
INSERT [dbo].[ServicePrice] ([ID], [ServicePrice]) VALUES (8, N'£45')
INSERT [dbo].[ServicePrice] ([ID], [ServicePrice]) VALUES (9, N'£46')
INSERT [dbo].[ServicePrice] ([ID], [ServicePrice]) VALUES (10, N'£64')
INSERT [dbo].[ServicePrice] ([ID], [ServicePrice]) VALUES (11, N'£120')
INSERT [dbo].[ServicePrice] ([ID], [ServicePrice]) VALUES (12, N'£250')
SET IDENTITY_INSERT [dbo].[ServicePrice] OFF
SET IDENTITY_INSERT [dbo].[ServiceVeriation] ON 

INSERT [dbo].[ServiceVeriation] ([ID], [ServiceVariation]) VALUES (1, N'Regular')
INSERT [dbo].[ServiceVeriation] ([ID], [ServiceVariation]) VALUES (2, N'Luxury')
INSERT [dbo].[ServiceVeriation] ([ID], [ServiceVariation]) VALUES (3, N'Express')
SET IDENTITY_INSERT [dbo].[ServiceVeriation] OFF
SET IDENTITY_INSERT [dbo].[Slot] ON 

INSERT [dbo].[Slot] ([SlotID], [SlotType]) VALUES (1, N'Morning :           9:00  AM  -  10:00  AM')
INSERT [dbo].[Slot] ([SlotID], [SlotType]) VALUES (2, N'Morning :          10:00  AM -  11:00 AM')
INSERT [dbo].[Slot] ([SlotID], [SlotType]) VALUES (3, N'Morning :          11:00  AM -  12:00  PM')
INSERT [dbo].[Slot] ([SlotID], [SlotType]) VALUES (4, N'Afternoon :      12:00  PM -  01:00  PM')
INSERT [dbo].[Slot] ([SlotID], [SlotType]) VALUES (5, N'Afternoon :      01:00 PM  -  02:00  PM')
INSERT [dbo].[Slot] ([SlotID], [SlotType]) VALUES (6, N'Afternoon :      02:00  PM - 03:00  PM')
INSERT [dbo].[Slot] ([SlotID], [SlotType]) VALUES (7, N'Afternoon :      03:00 PM  -  04:00 PM')
INSERT [dbo].[Slot] ([SlotID], [SlotType]) VALUES (8, N'Evening :           04:00 PM  -  05:00 PM')
INSERT [dbo].[Slot] ([SlotID], [SlotType]) VALUES (9, N'Evening :           05:00 PM -  06:00  PM')
INSERT [dbo].[Slot] ([SlotID], [SlotType]) VALUES (10, N'Evening :            06:00 PM  - 07:00 PM')
INSERT [dbo].[Slot] ([SlotID], [SlotType]) VALUES (11, N'Evening :            07:00 PM  - 08:00  PM')
INSERT [dbo].[Slot] ([SlotID], [SlotType]) VALUES (12, N'Evening:08:00PM-09:00PM')
SET IDENTITY_INSERT [dbo].[Slot] OFF
SET IDENTITY_INSERT [dbo].[visitor] ON 

INSERT [dbo].[visitor] ([vstr_id], [visitor_name], [visitor_location], [visitor_phoneno], [visitor_email], [testimonials], [enquiry]) VALUES (1, N'test', N'test', N'987456321456', N'test@test.co.in', NULL, NULL)
INSERT [dbo].[visitor] ([vstr_id], [visitor_name], [visitor_location], [visitor_phoneno], [visitor_email], [testimonials], [enquiry]) VALUES (2, N'test', N'test', N'987456321456', N'test@test.co.in', NULL, NULL)
INSERT [dbo].[visitor] ([vstr_id], [visitor_name], [visitor_location], [visitor_phoneno], [visitor_email], [testimonials], [enquiry]) VALUES (3, N'abc', N'JHJH', N'78754545', N'JKJLLKOKL', NULL, NULL)
INSERT [dbo].[visitor] ([vstr_id], [visitor_name], [visitor_location], [visitor_phoneno], [visitor_email], [testimonials], [enquiry]) VALUES (4, N'test', N'test', N'987456321455', N'test@test.co.in', N'jkjkjkkkkkjk', NULL)
INSERT [dbo].[visitor] ([vstr_id], [visitor_name], [visitor_location], [visitor_phoneno], [visitor_email], [testimonials], [enquiry]) VALUES (5, N'swagata', N'london', N'785442121364', N'test@test.co.in', N'kldjkfjsdkfjksdjfkjk', NULL)
INSERT [dbo].[visitor] ([vstr_id], [visitor_name], [visitor_location], [visitor_phoneno], [visitor_email], [testimonials], [enquiry]) VALUES (6, N'indrani', N'nottingham', N'5412587456', N'test@test.co.in', N'cadfjlkjflsdfjl', NULL)
SET IDENTITY_INSERT [dbo].[visitor] OFF
ALTER TABLE [dbo].[BillDesk]  WITH CHECK ADD  CONSTRAINT [FK_BillDesk_ServiceBillDesk] FOREIGN KEY([ServiceBilldeskId])
REFERENCES [dbo].[ServiceBillDesk] ([ID])
GO
ALTER TABLE [dbo].[BillDesk] CHECK CONSTRAINT [FK_BillDesk_ServiceBillDesk]
GO
ALTER TABLE [dbo].[BillDesk]  WITH CHECK ADD  CONSTRAINT [FK_BillDesk_ServiceDuration] FOREIGN KEY([ServiceDurationId])
REFERENCES [dbo].[ServiceDuration] ([ID])
GO
ALTER TABLE [dbo].[BillDesk] CHECK CONSTRAINT [FK_BillDesk_ServiceDuration]
GO
ALTER TABLE [dbo].[BillDesk]  WITH CHECK ADD  CONSTRAINT [FK_BillDesk_ServiceMaster] FOREIGN KEY([ServiceID])
REFERENCES [dbo].[ServiceMaster] ([ID])
GO
ALTER TABLE [dbo].[BillDesk] CHECK CONSTRAINT [FK_BillDesk_ServiceMaster]
GO
ALTER TABLE [dbo].[booking]  WITH CHECK ADD  CONSTRAINT [FK_booking_ServiceMaster] FOREIGN KEY([BillDeskID])
REFERENCES [dbo].[BillDesk] ([ID])
GO
ALTER TABLE [dbo].[booking] CHECK CONSTRAINT [FK_booking_ServiceMaster]
GO
ALTER TABLE [dbo].[booking]  WITH CHECK ADD  CONSTRAINT [FK_booking_Slot] FOREIGN KEY([SlotID])
REFERENCES [dbo].[Slot] ([SlotID])
GO
ALTER TABLE [dbo].[booking] CHECK CONSTRAINT [FK_booking_Slot]
GO
ALTER TABLE [dbo].[ServiceBillDesk]  WITH CHECK ADD  CONSTRAINT [FK_ServiceBillDesk_ServiceBillDesk] FOREIGN KEY([ServiceID])
REFERENCES [dbo].[ServiceMaster] ([ID])
GO
ALTER TABLE [dbo].[ServiceBillDesk] CHECK CONSTRAINT [FK_ServiceBillDesk_ServiceBillDesk]
GO
ALTER TABLE [dbo].[ServiceBillDesk]  WITH CHECK ADD  CONSTRAINT [FK_ServiceMaster_ServiceDuration] FOREIGN KEY([ServiceDurationID])
REFERENCES [dbo].[ServiceDuration] ([ID])
GO
ALTER TABLE [dbo].[ServiceBillDesk] CHECK CONSTRAINT [FK_ServiceMaster_ServiceDuration]
GO
ALTER TABLE [dbo].[ServiceBillDesk]  WITH CHECK ADD  CONSTRAINT [FK_ServiceMaster_ServicePrice] FOREIGN KEY([ServicePriceID])
REFERENCES [dbo].[ServicePrice] ([ID])
GO
ALTER TABLE [dbo].[ServiceBillDesk] CHECK CONSTRAINT [FK_ServiceMaster_ServicePrice]
GO
ALTER TABLE [dbo].[ServiceBillDesk]  WITH CHECK ADD  CONSTRAINT [FK_ServiceMaster_ServiceVeriation] FOREIGN KEY([ServiceVeriationID])
REFERENCES [dbo].[ServiceVeriation] ([ID])
GO
ALTER TABLE [dbo].[ServiceBillDesk] CHECK CONSTRAINT [FK_ServiceMaster_ServiceVeriation]
GO
USE [master]
GO
ALTER DATABASE [nail_service] SET  READ_WRITE 
GO
