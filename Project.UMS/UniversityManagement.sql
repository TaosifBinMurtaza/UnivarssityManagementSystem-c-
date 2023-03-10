USE [master]
GO
/****** Object:  Database [UniversityManagementSystem]    Script Date: 8/25/2021 9:02:06 AM ******/
CREATE DATABASE [UniversityManagementSystem]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'University Management System', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.SQLEXPRESS\MSSQL\DATA\University Management System.mdf' , SIZE = 25600KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'University Management System_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.SQLEXPRESS\MSSQL\DATA\University Management System_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
 WITH CATALOG_COLLATION = DATABASE_DEFAULT
GO
ALTER DATABASE [UniversityManagementSystem] SET COMPATIBILITY_LEVEL = 150
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [UniversityManagementSystem].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [UniversityManagementSystem] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [UniversityManagementSystem] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [UniversityManagementSystem] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [UniversityManagementSystem] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [UniversityManagementSystem] SET ARITHABORT OFF 
GO
ALTER DATABASE [UniversityManagementSystem] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [UniversityManagementSystem] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [UniversityManagementSystem] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [UniversityManagementSystem] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [UniversityManagementSystem] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [UniversityManagementSystem] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [UniversityManagementSystem] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [UniversityManagementSystem] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [UniversityManagementSystem] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [UniversityManagementSystem] SET  DISABLE_BROKER 
GO
ALTER DATABASE [UniversityManagementSystem] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [UniversityManagementSystem] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [UniversityManagementSystem] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [UniversityManagementSystem] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [UniversityManagementSystem] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [UniversityManagementSystem] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [UniversityManagementSystem] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [UniversityManagementSystem] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [UniversityManagementSystem] SET  MULTI_USER 
GO
ALTER DATABASE [UniversityManagementSystem] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [UniversityManagementSystem] SET DB_CHAINING OFF 
GO
ALTER DATABASE [UniversityManagementSystem] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [UniversityManagementSystem] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [UniversityManagementSystem] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [UniversityManagementSystem] SET ACCELERATED_DATABASE_RECOVERY = OFF  
GO
ALTER DATABASE [UniversityManagementSystem] SET QUERY_STORE = OFF
GO
USE [UniversityManagementSystem]
GO
/****** Object:  Table [dbo].[BookInfo]    Script Date: 8/25/2021 9:02:06 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[BookInfo](
	[BookID] [int] NOT NULL,
	[BookName] [nvarchar](100) NULL,
	[AutherName] [nvarchar](100) NULL,
	[Copies] [int] NULL,
	[Date] [date] NULL,
	[Bookself] [nvarchar](20) NULL,
 CONSTRAINT [PK_BookInfo] PRIMARY KEY CLUSTERED 
(
	[BookID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[ClubInfo]    Script Date: 8/25/2021 9:02:06 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ClubInfo](
	[ClubName] [nvarchar](100) NOT NULL,
	[ClubPresident] [nvarchar](50) NULL,
	[Establishment] [date] NULL,
	[RoomNo] [nvarchar](20) NULL,
 CONSTRAINT [PK_ClubInfo] PRIMARY KEY CLUSTERED 
(
	[ClubName] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[CourseInfo]    Script Date: 8/25/2021 9:02:06 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[CourseInfo](
	[CourseID] [nvarchar](50) NOT NULL,
	[CourseName] [nvarchar](100) NULL,
	[Department] [nvarchar](50) NULL,
 CONSTRAINT [PK_CourseInfo] PRIMARY KEY CLUSTERED 
(
	[CourseID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[EmpInfo]    Script Date: 8/25/2021 9:02:06 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[EmpInfo](
	[ID] [nvarchar](30) NOT NULL,
	[EmpName] [nvarchar](100) NULL,
	[FatherName] [nvarchar](100) NULL,
	[BirthDate] [date] NULL,
	[JoiningDate] [date] NULL,
	[Gender] [nvarchar](30) NULL,
	[Position] [nvarchar](80) NULL,
	[Salary] [float] NULL,
	[Password] [nvarchar](50) NULL,
 CONSTRAINT [PK_EmpInfo] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[ExpensesInfo]    Script Date: 8/25/2021 9:02:06 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ExpensesInfo](
	[SerialNo] [int] NOT NULL,
	[Year] [int] NULL,
	[Month] [nvarchar](50) NULL,
	[Income] [float] NULL,
	[Expenditure] [float] NULL,
 CONSTRAINT [PK_ExpensesInfo] PRIMARY KEY CLUSTERED 
(
	[SerialNo] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[FacultyInfo]    Script Date: 8/25/2021 9:02:06 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[FacultyInfo](
	[ID] [nvarchar](30) NOT NULL,
	[FacultyName] [nvarchar](100) NOT NULL,
	[FatherName] [nvarchar](100) NULL,
	[BirthDate] [date] NULL,
	[JoiningDate] [date] NULL,
	[Gender] [nvarchar](30) NULL,
	[Department] [nvarchar](80) NULL,
	[Position] [nvarchar](80) NULL,
	[Salary] [float] NULL,
	[Password] [nvarchar](50) NULL,
 CONSTRAINT [PK_FacultyInfo] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[ResultInfo]    Script Date: 8/25/2021 9:02:06 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ResultInfo](
	[StudentID] [nvarchar](50) NULL,
	[CourseName] [nvarchar](50) NULL,
	[Result] [nvarchar](20) NULL,
	[Semister] [nvarchar](50) NULL,
	[Year] [int] NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[StudentInfo]    Script Date: 8/25/2021 9:02:06 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[StudentInfo](
	[ID] [nvarchar](50) NOT NULL,
	[StudentName] [nvarchar](100) NOT NULL,
	[FatherName] [nvarchar](100) NOT NULL,
	[MotherName] [nvarchar](100) NOT NULL,
	[Gender] [nvarchar](30) NOT NULL,
	[BirthDate] [date] NOT NULL,
	[Program] [nvarchar](80) NOT NULL,
	[Department] [nvarchar](80) NOT NULL,
	[Password] [nvarchar](50) NOT NULL,
 CONSTRAINT [PK__StudentI__3214EC27A4C8B4CE] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
INSERT [dbo].[BookInfo] ([BookID], [BookName], [AutherName], [Copies], [Date], [Bookself]) VALUES (1, N'My Journey', N'Dr. A.P.J. Abdul Kalam', 11, CAST(N'2016-04-13' AS Date), N'3A')
INSERT [dbo].[BookInfo] ([BookID], [BookName], [AutherName], [Copies], [Date], [Bookself]) VALUES (2, N'Celestial Bodies', N'Jokha Alharthi', 9, CAST(N'2018-10-20' AS Date), N'2B')
INSERT [dbo].[BookInfo] ([BookID], [BookName], [AutherName], [Copies], [Date], [Bookself]) VALUES (3, N'Cheque book', N'Vasdev Mohi', 5, CAST(N'2021-08-22' AS Date), N'2A')
INSERT [dbo].[BookInfo] ([BookID], [BookName], [AutherName], [Copies], [Date], [Bookself]) VALUES (4, N'The Overstory', N'Richard Powers', 6, CAST(N'2021-08-22' AS Date), N'2A')
INSERT [dbo].[BookInfo] ([BookID], [BookName], [AutherName], [Copies], [Date], [Bookself]) VALUES (5, N'	Pather Panchali: Song of the Road', N'Bibhutibhushan Bandyopadhyay', 9, CAST(N'2019-03-18' AS Date), N'5A')
GO
INSERT [dbo].[ClubInfo] ([ClubName], [ClubPresident], [Establishment], [RoomNo]) VALUES (N'Arts Club', N'Alif Mohammad', CAST(N'2016-04-19' AS Date), N'4002')
INSERT [dbo].[ClubInfo] ([ClubName], [ClubPresident], [Establishment], [RoomNo]) VALUES (N'Comers Club', N'Iftekhar Ahmed', CAST(N'2016-10-19' AS Date), N'4200')
INSERT [dbo].[ClubInfo] ([ClubName], [ClubPresident], [Establishment], [RoomNo]) VALUES (N'Science Club', N'Taosif Bin ', CAST(N'2015-06-16' AS Date), N'2113')
GO
INSERT [dbo].[CourseInfo] ([CourseID], [CourseName], [Department]) VALUES (N'BAS 2101 ', N'Business Communications', N'English')
INSERT [dbo].[CourseInfo] ([CourseID], [CourseName], [Department]) VALUES (N'CSC 1103', N'Introduction to Computer Studies', N'CSE')
INSERT [dbo].[CourseInfo] ([CourseID], [CourseName], [Department]) VALUES (N'CSC 1204', N'Introduction to Database', N'CSE')
INSERT [dbo].[CourseInfo] ([CourseID], [CourseName], [Department]) VALUES (N'MAT 1102', N'Diff Calculus & Co-ordinate Geometry', N'Math')
INSERT [dbo].[CourseInfo] ([CourseID], [CourseName], [Department]) VALUES (N'MAT 2101', N'Integral Calculus & Ord. Diff Equation', N'Math')
INSERT [dbo].[CourseInfo] ([CourseID], [CourseName], [Department]) VALUES (N'MAT 3101', N' Matrices, Vectors, Fourier analysis', N'Math')
INSERT [dbo].[CourseInfo] ([CourseID], [CourseName], [Department]) VALUES (N'MGT 3202', N'Engineering Management', N'EEE')
GO
INSERT [dbo].[EmpInfo] ([ID], [EmpName], [FatherName], [BirthDate], [JoiningDate], [Gender], [Position], [Salary], [Password]) VALUES (N'e-0001', N'Mohammad Motaleb', N'Abdur Roug', CAST(N'1980-02-06' AS Date), CAST(N'2015-04-19' AS Date), N'Male', N'Admin', 55000, N'123')
INSERT [dbo].[EmpInfo] ([ID], [EmpName], [FatherName], [BirthDate], [JoiningDate], [Gender], [Position], [Salary], [Password]) VALUES (N'e-0002', N'Eliyas', N'Kanchon', CAST(N'1968-02-21' AS Date), CAST(N'2016-05-03' AS Date), N'Male', N'Office Staff', 50000, N'436021')
INSERT [dbo].[EmpInfo] ([ID], [EmpName], [FatherName], [BirthDate], [JoiningDate], [Gender], [Position], [Salary], [Password]) VALUES (N'e-0003', N'Sadiya Mehjabin', N'Abdur gaffar', CAST(N'1973-01-18' AS Date), CAST(N'2015-04-24' AS Date), N'Female', N'Office Staff', 30000, N'426538')
INSERT [dbo].[EmpInfo] ([ID], [EmpName], [FatherName], [BirthDate], [JoiningDate], [Gender], [Position], [Salary], [Password]) VALUES (N'e-0004', N'Nusrat Jahan', N'Shaheen Alom', CAST(N'1984-12-21' AS Date), CAST(N'2016-03-17' AS Date), N'Female', N'Admin', 45000, N'272300')
GO
INSERT [dbo].[ExpensesInfo] ([SerialNo], [Year], [Month], [Income], [Expenditure]) VALUES (1, 2021, N'January', 330333, 2023333)
INSERT [dbo].[ExpensesInfo] ([SerialNo], [Year], [Month], [Income], [Expenditure]) VALUES (2, 2021, N'February', 2030125, 16790264)
INSERT [dbo].[ExpensesInfo] ([SerialNo], [Year], [Month], [Income], [Expenditure]) VALUES (3, 2021, N'May', 21321152, 256123485)
INSERT [dbo].[ExpensesInfo] ([SerialNo], [Year], [Month], [Income], [Expenditure]) VALUES (4, 2021, N'August', 90123654, 12485201)
GO
INSERT [dbo].[FacultyInfo] ([ID], [FacultyName], [FatherName], [BirthDate], [JoiningDate], [Gender], [Department], [Position], [Salary], [Password]) VALUES (N'f-0001', N'Abdur Razzak', N'Abdur rahman', CAST(N'1972-05-06' AS Date), CAST(N'2015-05-07' AS Date), N'Male', N'FASS', N'Lecturer', 75010, N'1234')
INSERT [dbo].[FacultyInfo] ([ID], [FacultyName], [FatherName], [BirthDate], [JoiningDate], [Gender], [Department], [Position], [Salary], [Password]) VALUES (N'f-0002', N'Razib Hayat', N'Jabbar hayat', CAST(N'1975-11-18' AS Date), CAST(N'2014-05-25' AS Date), N'Male', N'FASS', N'Professor', 110000, N'438834')
INSERT [dbo].[FacultyInfo] ([ID], [FacultyName], [FatherName], [BirthDate], [JoiningDate], [Gender], [Department], [Position], [Salary], [Password]) VALUES (N'f-0003', N'Hasibur Rahman', N'Mahbubur Rahman', CAST(N'1982-10-18' AS Date), CAST(N'2017-12-18' AS Date), N'Male', N'FST', N'Associate Professor', 70000, N'296136')
INSERT [dbo].[FacultyInfo] ([ID], [FacultyName], [FatherName], [BirthDate], [JoiningDate], [Gender], [Department], [Position], [Salary], [Password]) VALUES (N'f-0004', N'Tohedul Islam', N'ismail Islam', CAST(N'1979-01-18' AS Date), CAST(N'2011-05-20' AS Date), N'Male', N'FST', N'Associate Professor', 65000, N'682731')
INSERT [dbo].[FacultyInfo] ([ID], [FacultyName], [FatherName], [BirthDate], [JoiningDate], [Gender], [Department], [Position], [Salary], [Password]) VALUES (N'f-0005', N'Mitu Islam', N'Akram Islam', CAST(N'1983-02-17' AS Date), CAST(N'2016-04-18' AS Date), N'Female', N'FE', N'Assistant Professor', 70000, N'513669')
GO
INSERT [dbo].[ResultInfo] ([StudentID], [CourseName], [Result], [Semister], [Year]) VALUES (N's-00001', N'Bangla', N'B+', N'B+', 2021)
INSERT [dbo].[ResultInfo] ([StudentID], [CourseName], [Result], [Semister], [Year]) VALUES (N'', N'', N'<<Select>>', N'<<Select>>', 2021)
INSERT [dbo].[ResultInfo] ([StudentID], [CourseName], [Result], [Semister], [Year]) VALUES (N'rtytry', N'trytr', N'A', N'A', 1234)
GO
INSERT [dbo].[StudentInfo] ([ID], [StudentName], [FatherName], [MotherName], [Gender], [BirthDate], [Program], [Department], [Password]) VALUES (N's-00001', N'Taosif Bin', N'Murtaza', N'Hasna', N'Male', CAST(N'2011-01-03' AS Date), N'FST', N'CSE', N'1111')
INSERT [dbo].[StudentInfo] ([ID], [StudentName], [FatherName], [MotherName], [Gender], [BirthDate], [Program], [Department], [Password]) VALUES (N's-00003', N'Anik Rahman', N'Abdur Rahman', N'Jannatul Ferdous', N'Male', CAST(N'2021-12-08' AS Date), N'B.Sc', N'CSE', N'3333')
INSERT [dbo].[StudentInfo] ([ID], [StudentName], [FatherName], [MotherName], [Gender], [BirthDate], [Program], [Department], [Password]) VALUES (N's-00004', N'Safayet saron', N'Hossain khan', N'Fatima begum', N'Male', CAST(N'1996-05-17' AS Date), N'B.Sc', N'EEE', N'977030')
INSERT [dbo].[StudentInfo] ([ID], [StudentName], [FatherName], [MotherName], [Gender], [BirthDate], [Program], [Department], [Password]) VALUES (N's-00005', N'Nahid Hasan', N'Riaz hasan', N'Raisa Hasan', N'Male', CAST(N'1997-06-20' AS Date), N'M.Sc', N'CSE', N'977272')
INSERT [dbo].[StudentInfo] ([ID], [StudentName], [FatherName], [MotherName], [Gender], [BirthDate], [Program], [Department], [Password]) VALUES (N's-00006', N'Anamika Poul', N'Rana Poul', N'Rinika Poul', N'Female', CAST(N'2021-08-22' AS Date), N'BBA', N'Finanse', N'599490')
GO
USE [master]
GO
ALTER DATABASE [UniversityManagementSystem] SET  READ_WRITE 
GO
