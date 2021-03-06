USE [master]
GO
/****** Object:  Database [DB_LIBRARY]    Script Date: 10.11.2021 14:16:33 ******/
CREATE DATABASE [DB_LIBRARY]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'DB_LIBRARY', FILENAME = N'D:\Program Files\Microsoft SQL Server\MSSQL15.MSSQLSERVER\MSSQL\DATA\DB_LIBRARY.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'DB_LIBRARY_log', FILENAME = N'D:\Program Files\Microsoft SQL Server\MSSQL15.MSSQLSERVER\MSSQL\DATA\DB_LIBRARY_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
 WITH CATALOG_COLLATION = DATABASE_DEFAULT
GO
ALTER DATABASE [DB_LIBRARY] SET COMPATIBILITY_LEVEL = 150
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [DB_LIBRARY].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [DB_LIBRARY] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [DB_LIBRARY] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [DB_LIBRARY] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [DB_LIBRARY] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [DB_LIBRARY] SET ARITHABORT OFF 
GO
ALTER DATABASE [DB_LIBRARY] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [DB_LIBRARY] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [DB_LIBRARY] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [DB_LIBRARY] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [DB_LIBRARY] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [DB_LIBRARY] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [DB_LIBRARY] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [DB_LIBRARY] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [DB_LIBRARY] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [DB_LIBRARY] SET  DISABLE_BROKER 
GO
ALTER DATABASE [DB_LIBRARY] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [DB_LIBRARY] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [DB_LIBRARY] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [DB_LIBRARY] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [DB_LIBRARY] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [DB_LIBRARY] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [DB_LIBRARY] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [DB_LIBRARY] SET RECOVERY FULL 
GO
ALTER DATABASE [DB_LIBRARY] SET  MULTI_USER 
GO
ALTER DATABASE [DB_LIBRARY] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [DB_LIBRARY] SET DB_CHAINING OFF 
GO
ALTER DATABASE [DB_LIBRARY] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [DB_LIBRARY] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [DB_LIBRARY] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [DB_LIBRARY] SET ACCELERATED_DATABASE_RECOVERY = OFF  
GO
EXEC sys.sp_db_vardecimal_storage_format N'DB_LIBRARY', N'ON'
GO
ALTER DATABASE [DB_LIBRARY] SET QUERY_STORE = OFF
GO
USE [DB_LIBRARY]
GO
/****** Object:  Table [dbo].[ACTION_TABLE]    Script Date: 10.11.2021 14:16:34 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ACTION_TABLE](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[BOOK] [int] NULL,
	[MEMBER] [int] NULL,
	[EMPLOYEE] [tinyint] NULL,
	[BORROWDATE] [smalldatetime] NULL,
	[RETURNDATE] [smalldatetime] NULL,
	[MEMBERRETURNDATE] [smalldatetime] NULL,
	[ACTIONSTATUS] [bit] NULL,
 CONSTRAINT [PK_ACTION_TABLE] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[AUTHOR_TABLE]    Script Date: 10.11.2021 14:16:34 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[AUTHOR_TABLE](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[NAME] [varchar](30) NULL,
	[SURNAME] [varchar](30) NULL,
	[DETAIL] [varchar](1000) NULL,
 CONSTRAINT [PK_AUTHOR_TABLE] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[BOOK_TABLE]    Script Date: 10.11.2021 14:16:34 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[BOOK_TABLE](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[NAME] [varchar](50) NULL,
	[CATEGORY] [tinyint] NULL,
	[AUTHOR] [int] NULL,
	[PRINTDATE] [char](4) NULL,
	[PUBLISHER] [varchar](50) NULL,
	[PAGE] [varchar](4) NOT NULL,
	[STATUS] [bit] NULL,
	[BOOKIMAGE] [varchar](250) NULL,
 CONSTRAINT [PK_BOOK_TABLE] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[CASHBOX_TABLE]    Script Date: 10.11.2021 14:16:34 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[CASHBOX_TABLE](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[MONTH] [varchar](20) NULL,
	[AMOUNT] [decimal](18, 2) NULL,
 CONSTRAINT [PK_CASHBOX_TABLE] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[CATEGORY_TABLE]    Script Date: 10.11.2021 14:16:34 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[CATEGORY_TABLE](
	[ID] [tinyint] IDENTITY(1,1) NOT NULL,
	[NAME] [varchar](25) NULL,
 CONSTRAINT [PK_CATEGORY_TABLE] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[CONTACT_TABLE]    Script Date: 10.11.2021 14:16:34 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[CONTACT_TABLE](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[NAME] [varchar](50) NULL,
	[EMAIL] [varchar](50) NULL,
	[TOPIC] [varchar](50) NULL,
	[MESSAGE] [varchar](1000) NULL,
 CONSTRAINT [PK_CONTACT_TABLE] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[EMPLOYEE_TABLE]    Script Date: 10.11.2021 14:16:34 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[EMPLOYEE_TABLE](
	[ID] [tinyint] IDENTITY(1,1) NOT NULL,
	[EMPLOYEE] [varchar](50) NULL,
 CONSTRAINT [PK_PERSONEL_TABLE] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[MEMBER_TABLE]    Script Date: 10.11.2021 14:16:34 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[MEMBER_TABLE](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[NAME] [varchar](30) NULL,
	[SURNAME] [varchar](30) NULL,
	[EMAIL] [varchar](50) NULL,
	[USERNAME] [varchar](20) NULL,
	[PASSWORD] [varchar](20) NULL,
	[PHOTO] [varchar](250) NULL,
	[TELNUMBER] [varchar](20) NULL,
	[SCHOOL] [varchar](100) NULL,
 CONSTRAINT [PK_USER_TABLE] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[MESSAGE_TABLE]    Script Date: 10.11.2021 14:16:34 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[MESSAGE_TABLE](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[SENDER] [varchar](50) NULL,
	[RECEIVER] [varchar](50) NULL,
	[TOPIC] [varchar](50) NULL,
	[MESSAGECONTENT] [varchar](500) NULL,
	[DATE] [smalldatetime] NULL,
 CONSTRAINT [PK_MESSAGE_TABLE] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[PENALTY_TABLE]    Script Date: 10.11.2021 14:16:34 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[PENALTY_TABLE](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[MEMBER] [int] NULL,
	[ACTION] [int] NULL,
	[STARTDATE] [smalldatetime] NULL,
	[ENDDATE] [smalldatetime] NULL,
	[MONEY] [decimal](18, 2) NULL,
 CONSTRAINT [PK_PENALTY_TABLE] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
ALTER TABLE [dbo].[ACTION_TABLE] ADD  CONSTRAINT [DF_ACTION_TABLE_ACTIONSTATUS]  DEFAULT ((0)) FOR [ACTIONSTATUS]
GO
ALTER TABLE [dbo].[BOOK_TABLE] ADD  CONSTRAINT [DF_BOOK_TABLE_STATUS]  DEFAULT ((1)) FOR [STATUS]
GO
ALTER TABLE [dbo].[ACTION_TABLE]  WITH CHECK ADD  CONSTRAINT [FK_ACTION_TABLE_BOOK_TABLE] FOREIGN KEY([BOOK])
REFERENCES [dbo].[BOOK_TABLE] ([ID])
GO
ALTER TABLE [dbo].[ACTION_TABLE] CHECK CONSTRAINT [FK_ACTION_TABLE_BOOK_TABLE]
GO
ALTER TABLE [dbo].[ACTION_TABLE]  WITH CHECK ADD  CONSTRAINT [FK_ACTION_TABLE_EMPLOYEE_TABLE] FOREIGN KEY([EMPLOYEE])
REFERENCES [dbo].[EMPLOYEE_TABLE] ([ID])
GO
ALTER TABLE [dbo].[ACTION_TABLE] CHECK CONSTRAINT [FK_ACTION_TABLE_EMPLOYEE_TABLE]
GO
ALTER TABLE [dbo].[ACTION_TABLE]  WITH CHECK ADD  CONSTRAINT [FK_ACTION_TABLE_MEMBER_TABLE] FOREIGN KEY([MEMBER])
REFERENCES [dbo].[MEMBER_TABLE] ([ID])
GO
ALTER TABLE [dbo].[ACTION_TABLE] CHECK CONSTRAINT [FK_ACTION_TABLE_MEMBER_TABLE]
GO
ALTER TABLE [dbo].[BOOK_TABLE]  WITH CHECK ADD  CONSTRAINT [FK_BOOK_TABLE_AUTHOR_TABLE] FOREIGN KEY([AUTHOR])
REFERENCES [dbo].[AUTHOR_TABLE] ([ID])
GO
ALTER TABLE [dbo].[BOOK_TABLE] CHECK CONSTRAINT [FK_BOOK_TABLE_AUTHOR_TABLE]
GO
ALTER TABLE [dbo].[BOOK_TABLE]  WITH CHECK ADD  CONSTRAINT [FK_BOOK_TABLE_CATEGORY_TABLE] FOREIGN KEY([CATEGORY])
REFERENCES [dbo].[CATEGORY_TABLE] ([ID])
GO
ALTER TABLE [dbo].[BOOK_TABLE] CHECK CONSTRAINT [FK_BOOK_TABLE_CATEGORY_TABLE]
GO
ALTER TABLE [dbo].[PENALTY_TABLE]  WITH CHECK ADD  CONSTRAINT [FK_PENALTY_TABLE_ACTION_TABLE] FOREIGN KEY([ACTION])
REFERENCES [dbo].[ACTION_TABLE] ([ID])
GO
ALTER TABLE [dbo].[PENALTY_TABLE] CHECK CONSTRAINT [FK_PENALTY_TABLE_ACTION_TABLE]
GO
ALTER TABLE [dbo].[PENALTY_TABLE]  WITH CHECK ADD  CONSTRAINT [FK_PENALTY_TABLE_MEMBER_TABLE] FOREIGN KEY([MEMBER])
REFERENCES [dbo].[MEMBER_TABLE] ([ID])
GO
ALTER TABLE [dbo].[PENALTY_TABLE] CHECK CONSTRAINT [FK_PENALTY_TABLE_MEMBER_TABLE]
GO
USE [master]
GO
ALTER DATABASE [DB_LIBRARY] SET  READ_WRITE 
GO
