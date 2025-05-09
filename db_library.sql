USE [master]
GO
/****** Object:  Database [Db_Library]    Script Date: 12/7/2024 2:09:46 AM ******/
CREATE DATABASE [Db_Library]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'Db_Library', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL16.MSSQLSERVER\MSSQL\DATA\Db_Library.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'Db_Library_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL16.MSSQLSERVER\MSSQL\DATA\Db_Library_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
 WITH CATALOG_COLLATION = DATABASE_DEFAULT, LEDGER = OFF
GO
ALTER DATABASE [Db_Library] SET COMPATIBILITY_LEVEL = 160
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [Db_Library].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [Db_Library] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [Db_Library] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [Db_Library] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [Db_Library] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [Db_Library] SET ARITHABORT OFF 
GO
ALTER DATABASE [Db_Library] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [Db_Library] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [Db_Library] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [Db_Library] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [Db_Library] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [Db_Library] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [Db_Library] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [Db_Library] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [Db_Library] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [Db_Library] SET  DISABLE_BROKER 
GO
ALTER DATABASE [Db_Library] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [Db_Library] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [Db_Library] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [Db_Library] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [Db_Library] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [Db_Library] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [Db_Library] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [Db_Library] SET RECOVERY FULL 
GO
ALTER DATABASE [Db_Library] SET  MULTI_USER 
GO
ALTER DATABASE [Db_Library] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [Db_Library] SET DB_CHAINING OFF 
GO
ALTER DATABASE [Db_Library] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [Db_Library] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [Db_Library] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [Db_Library] SET ACCELERATED_DATABASE_RECOVERY = OFF  
GO
EXEC sys.sp_db_vardecimal_storage_format N'Db_Library', N'ON'
GO
ALTER DATABASE [Db_Library] SET QUERY_STORE = ON
GO
ALTER DATABASE [Db_Library] SET QUERY_STORE (OPERATION_MODE = READ_WRITE, CLEANUP_POLICY = (STALE_QUERY_THRESHOLD_DAYS = 30), DATA_FLUSH_INTERVAL_SECONDS = 900, INTERVAL_LENGTH_MINUTES = 60, MAX_STORAGE_SIZE_MB = 1000, QUERY_CAPTURE_MODE = AUTO, SIZE_BASED_CLEANUP_MODE = AUTO, MAX_PLANS_PER_QUERY = 200, WAIT_STATS_CAPTURE_MODE = ON)
GO
USE [Db_Library]
GO
/****** Object:  Table [dbo].[TblAbout]    Script Date: 12/7/2024 2:09:46 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TblAbout](
	[abloutid] [int] IDENTITY(1,1) NOT NULL,
	[abloutTitle] [varchar](50) NULL,
	[aboutContent] [varchar](max) NULL,
 CONSTRAINT [PK_TblAbout] PRIMARY KEY CLUSTERED 
(
	[abloutid] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[TblAdmin]    Script Date: 12/7/2024 2:09:46 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TblAdmin](
	[adminId] [int] IDENTITY(1,1) NOT NULL,
	[adminUsername] [varchar](50) NULL,
	[adminPassword] [varchar](50) NULL,
	[Authority] [char](1) NULL,
 CONSTRAINT [PK_TblAdmin] PRIMARY KEY CLUSTERED 
(
	[adminId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[TblAnnouncement]    Script Date: 12/7/2024 2:09:46 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TblAnnouncement](
	[announcementId] [int] IDENTITY(1,1) NOT NULL,
	[announcementCategory] [varchar](50) NULL,
	[announcementContext] [varchar](max) NULL,
 CONSTRAINT [PK_TblAnnouncement] PRIMARY KEY CLUSTERED 
(
	[announcementId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[TblAuthor]    Script Date: 12/7/2024 2:09:46 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TblAuthor](
	[authorId] [int] IDENTITY(1,1) NOT NULL,
	[authorName] [varchar](30) NULL,
	[authorSurname] [varchar](20) NULL,
	[authorDetails] [varchar](max) NULL,
 CONSTRAINT [PK_TblAuthor] PRIMARY KEY CLUSTERED 
(
	[authorId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[TblBook]    Script Date: 12/7/2024 2:09:46 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TblBook](
	[bookId] [int] IDENTITY(1,1) NOT NULL,
	[bookName] [varchar](50) NULL,
	[bookCategory] [tinyint] NULL,
	[bookAuthor] [int] NULL,
	[bookRelase] [char](4) NULL,
	[bookPublisher] [varchar](50) NULL,
	[bookPages] [varchar](5) NULL,
	[bookImage] [varchar](max) NULL,
	[bookStatus] [bit] NULL,
 CONSTRAINT [PK_TblBook] PRIMARY KEY CLUSTERED 
(
	[bookId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[TblCashregister]    Script Date: 12/7/2024 2:09:46 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TblCashregister](
	[cashregisterId] [int] IDENTITY(1,1) NOT NULL,
	[cashregisterMonth] [varchar](50) NULL,
	[cashregisterAmount] [decimal](18, 2) NULL,
 CONSTRAINT [PK_TblCashregisterI] PRIMARY KEY CLUSTERED 
(
	[cashregisterId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[TblCategory]    Script Date: 12/7/2024 2:09:46 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TblCategory](
	[categoryId] [tinyint] IDENTITY(1,1) NOT NULL,
	[categoryName] [varchar](20) NULL,
 CONSTRAINT [PK_TblCategory] PRIMARY KEY CLUSTERED 
(
	[categoryId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[TblContact]    Script Date: 12/7/2024 2:09:46 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TblContact](
	[contactId] [int] IDENTITY(1,1) NOT NULL,
	[contactName] [varchar](50) NULL,
	[contactMail] [varchar](50) NULL,
	[contactNumber] [varchar](50) NULL,
	[contactContaxt] [varchar](max) NULL,
 CONSTRAINT [PK_TblContact] PRIMARY KEY CLUSTERED 
(
	[contactId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[TblEmployee]    Script Date: 12/7/2024 2:09:46 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TblEmployee](
	[employeeId] [int] IDENTITY(1,1) NOT NULL,
	[employeeNameSurname] [varchar](50) NULL,
 CONSTRAINT [PK_TblEmployee] PRIMARY KEY CLUSTERED 
(
	[employeeId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[TblMember]    Script Date: 12/7/2024 2:09:46 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TblMember](
	[memberId] [int] IDENTITY(1,1) NOT NULL,
	[memberName] [varchar](50) NULL,
	[memberSurname] [varchar](50) NULL,
	[memberMail] [varchar](50) NULL,
	[memberPhone] [varchar](20) NULL,
	[memberUsername] [varchar](50) NULL,
	[memberPassword] [varchar](50) NULL,
	[memberPhoto] [varchar](max) NULL,
	[memberSchool] [varchar](100) NULL,
 CONSTRAINT [PK_TblMember] PRIMARY KEY CLUSTERED 
(
	[memberId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[TblMessage]    Script Date: 12/7/2024 2:09:46 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TblMessage](
	[messageId] [int] IDENTITY(1,1) NOT NULL,
	[messageReceiver] [varchar](50) NULL,
	[messageSender] [varchar](50) NULL,
	[messageSubject] [varchar](50) NULL,
	[messageContaext] [varchar](max) NULL,
	[messageDate] [smalldatetime] NULL,
 CONSTRAINT [PK_TblMessage] PRIMARY KEY CLUSTERED 
(
	[messageId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[TblOperation]    Script Date: 12/7/2024 2:09:46 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TblOperation](
	[operationId] [int] IDENTITY(1,1) NOT NULL,
	[operationBook] [int] NULL,
	[operationMember] [int] NULL,
	[operationEmployee] [int] NULL,
	[operationGetDate] [smalldatetime] NULL,
	[operationBackDate] [smalldatetime] NULL,
 CONSTRAINT [PK_TblOperation] PRIMARY KEY CLUSTERED 
(
	[operationId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[TblPunishment]    Script Date: 12/7/2024 2:09:46 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TblPunishment](
	[punishmentId] [int] IDENTITY(1,1) NOT NULL,
	[punishmentMember] [int] NULL,
	[punishmentOperation] [int] NULL,
	[punishmentStartDate] [smalldatetime] NULL,
	[punishmentEndDate] [smalldatetime] NULL,
	[punishmentFine] [decimal](18, 2) NULL,
 CONSTRAINT [PK_TblPunishment] PRIMARY KEY CLUSTERED 
(
	[punishmentId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
ALTER TABLE [dbo].[TblBook]  WITH CHECK ADD  CONSTRAINT [FK_TblBook_TblAuthor] FOREIGN KEY([bookAuthor])
REFERENCES [dbo].[TblAuthor] ([authorId])
GO
ALTER TABLE [dbo].[TblBook] CHECK CONSTRAINT [FK_TblBook_TblAuthor]
GO
ALTER TABLE [dbo].[TblBook]  WITH CHECK ADD  CONSTRAINT [FK_TblBook_TblCategory] FOREIGN KEY([bookCategory])
REFERENCES [dbo].[TblCategory] ([categoryId])
GO
ALTER TABLE [dbo].[TblBook] CHECK CONSTRAINT [FK_TblBook_TblCategory]
GO
ALTER TABLE [dbo].[TblOperation]  WITH CHECK ADD  CONSTRAINT [FK_TblOperation_TblBook] FOREIGN KEY([operationBook])
REFERENCES [dbo].[TblBook] ([bookId])
GO
ALTER TABLE [dbo].[TblOperation] CHECK CONSTRAINT [FK_TblOperation_TblBook]
GO
ALTER TABLE [dbo].[TblOperation]  WITH CHECK ADD  CONSTRAINT [FK_TblOperation_TblEmployee] FOREIGN KEY([operationEmployee])
REFERENCES [dbo].[TblEmployee] ([employeeId])
GO
ALTER TABLE [dbo].[TblOperation] CHECK CONSTRAINT [FK_TblOperation_TblEmployee]
GO
ALTER TABLE [dbo].[TblOperation]  WITH CHECK ADD  CONSTRAINT [FK_TblOperation_TblMember] FOREIGN KEY([operationMember])
REFERENCES [dbo].[TblMember] ([memberId])
GO
ALTER TABLE [dbo].[TblOperation] CHECK CONSTRAINT [FK_TblOperation_TblMember]
GO
ALTER TABLE [dbo].[TblPunishment]  WITH CHECK ADD  CONSTRAINT [FK_TblPunishment_TblMember] FOREIGN KEY([punishmentMember])
REFERENCES [dbo].[TblMember] ([memberId])
GO
ALTER TABLE [dbo].[TblPunishment] CHECK CONSTRAINT [FK_TblPunishment_TblMember]
GO
ALTER TABLE [dbo].[TblPunishment]  WITH CHECK ADD  CONSTRAINT [FK_TblPunishment_TblOperation] FOREIGN KEY([punishmentOperation])
REFERENCES [dbo].[TblOperation] ([operationId])
GO
ALTER TABLE [dbo].[TblPunishment] CHECK CONSTRAINT [FK_TblPunishment_TblOperation]
GO
USE [master]
GO
ALTER DATABASE [Db_Library] SET  READ_WRITE 
GO
