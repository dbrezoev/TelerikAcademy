USE [master]
GO
/****** Object:  Database [MyUniversitySystem]    Script Date: 22.8.2014 г. 18:06:21 ч. ******/
CREATE DATABASE [MyUniversitySystem]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'MyUniversitySystem', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL11.MSSQLSERVER\MSSQL\DATA\MyUniversitySystem.mdf' , SIZE = 4160KB , MAXSIZE = UNLIMITED, FILEGROWTH = 1024KB )
 LOG ON 
( NAME = N'MyUniversitySystem_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL11.MSSQLSERVER\MSSQL\DATA\MyUniversitySystem_log.ldf' , SIZE = 1040KB , MAXSIZE = 2048GB , FILEGROWTH = 10%)
GO
ALTER DATABASE [MyUniversitySystem] SET COMPATIBILITY_LEVEL = 110
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [MyUniversitySystem].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [MyUniversitySystem] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [MyUniversitySystem] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [MyUniversitySystem] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [MyUniversitySystem] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [MyUniversitySystem] SET ARITHABORT OFF 
GO
ALTER DATABASE [MyUniversitySystem] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [MyUniversitySystem] SET AUTO_CREATE_STATISTICS ON 
GO
ALTER DATABASE [MyUniversitySystem] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [MyUniversitySystem] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [MyUniversitySystem] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [MyUniversitySystem] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [MyUniversitySystem] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [MyUniversitySystem] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [MyUniversitySystem] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [MyUniversitySystem] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [MyUniversitySystem] SET  DISABLE_BROKER 
GO
ALTER DATABASE [MyUniversitySystem] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [MyUniversitySystem] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [MyUniversitySystem] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [MyUniversitySystem] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [MyUniversitySystem] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [MyUniversitySystem] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [MyUniversitySystem] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [MyUniversitySystem] SET RECOVERY FULL 
GO
ALTER DATABASE [MyUniversitySystem] SET  MULTI_USER 
GO
ALTER DATABASE [MyUniversitySystem] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [MyUniversitySystem] SET DB_CHAINING OFF 
GO
ALTER DATABASE [MyUniversitySystem] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [MyUniversitySystem] SET TARGET_RECOVERY_TIME = 0 SECONDS 
GO
EXEC sys.sp_db_vardecimal_storage_format N'MyUniversitySystem', N'ON'
GO
USE [MyUniversitySystem]
GO
/****** Object:  Table [dbo].[Courses]    Script Date: 22.8.2014 г. 18:06:22 ч. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Courses](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Name] [nvarchar](50) NOT NULL,
	[Department_Id] [int] NOT NULL,
 CONSTRAINT [PK_Courses] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Departments]    Script Date: 22.8.2014 г. 18:06:22 ч. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Departments](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Name] [varchar](50) NOT NULL,
	[FacultyId] [int] NOT NULL,
 CONSTRAINT [PK_Departments] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Faculties]    Script Date: 22.8.2014 г. 18:06:22 ч. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Faculties](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Name] [varchar](50) NOT NULL,
 CONSTRAINT [PK_Faculties] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Professor_Courses]    Script Date: 22.8.2014 г. 18:06:22 ч. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Professor_Courses](
	[CourseId] [int] NOT NULL,
	[ProfessorId] [int] NOT NULL,
 CONSTRAINT [PK_Professor_Courses] PRIMARY KEY CLUSTERED 
(
	[CourseId] ASC,
	[ProfessorId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Professor_Title]    Script Date: 22.8.2014 г. 18:06:22 ч. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Professor_Title](
	[ProfessorId] [int] NOT NULL,
	[TitleId] [int] NOT NULL,
 CONSTRAINT [PK_Professor_Title] PRIMARY KEY CLUSTERED 
(
	[ProfessorId] ASC,
	[TitleId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Professors]    Script Date: 22.8.2014 г. 18:06:22 ч. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Professors](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Name] [varchar](50) NOT NULL,
	[DepartmentId] [int] NOT NULL,
 CONSTRAINT [PK_Professors] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Student_Courses]    Script Date: 22.8.2014 г. 18:06:22 ч. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Student_Courses](
	[StudentId] [int] NOT NULL,
	[CoursesId] [int] NOT NULL,
 CONSTRAINT [PK_Student_Courses] PRIMARY KEY CLUSTERED 
(
	[StudentId] ASC,
	[CoursesId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Students]    Script Date: 22.8.2014 г. 18:06:22 ч. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Students](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Name] [varchar](50) NOT NULL,
	[FacultiesID] [int] NOT NULL,
 CONSTRAINT [PK_Students] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Titles]    Script Date: 22.8.2014 г. 18:06:22 ч. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Titles](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Name] [varchar](50) NOT NULL,
 CONSTRAINT [PK_Titles] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
SET IDENTITY_INSERT [dbo].[Courses] ON 

INSERT [dbo].[Courses] ([Id], [Name], [Department_Id]) VALUES (1, N'JS', 4)
INSERT [dbo].[Courses] ([Id], [Name], [Department_Id]) VALUES (2, N'CSharp', 4)
INSERT [dbo].[Courses] ([Id], [Name], [Department_Id]) VALUES (3, N'Mathematics', 1)
SET IDENTITY_INSERT [dbo].[Courses] OFF
SET IDENTITY_INSERT [dbo].[Departments] ON 

INSERT [dbo].[Departments] ([Id], [Name], [FacultyId]) VALUES (1, N'Math', 1)
INSERT [dbo].[Departments] ([Id], [Name], [FacultyId]) VALUES (2, N'Drawing', 2)
INSERT [dbo].[Departments] ([Id], [Name], [FacultyId]) VALUES (4, N'IT', 1)
SET IDENTITY_INSERT [dbo].[Departments] OFF
SET IDENTITY_INSERT [dbo].[Faculties] ON 

INSERT [dbo].[Faculties] ([Id], [Name]) VALUES (1, N'Science')
INSERT [dbo].[Faculties] ([Id], [Name]) VALUES (2, N'Art')
SET IDENTITY_INSERT [dbo].[Faculties] OFF
INSERT [dbo].[Professor_Courses] ([CourseId], [ProfessorId]) VALUES (2, 2)
INSERT [dbo].[Professor_Courses] ([CourseId], [ProfessorId]) VALUES (3, 3)
INSERT [dbo].[Professor_Title] ([ProfessorId], [TitleId]) VALUES (2, 1)
INSERT [dbo].[Professor_Title] ([ProfessorId], [TitleId]) VALUES (3, 1)
INSERT [dbo].[Professor_Title] ([ProfessorId], [TitleId]) VALUES (4, 2)
SET IDENTITY_INSERT [dbo].[Professors] ON 

INSERT [dbo].[Professors] ([Id], [Name], [DepartmentId]) VALUES (2, N'Yordanova', 1)
INSERT [dbo].[Professors] ([Id], [Name], [DepartmentId]) VALUES (3, N'Peceva', 1)
INSERT [dbo].[Professors] ([Id], [Name], [DepartmentId]) VALUES (4, N'Kenov', 4)
SET IDENTITY_INSERT [dbo].[Professors] OFF
INSERT [dbo].[Student_Courses] ([StudentId], [CoursesId]) VALUES (1, 1)
INSERT [dbo].[Student_Courses] ([StudentId], [CoursesId]) VALUES (2, 1)
INSERT [dbo].[Student_Courses] ([StudentId], [CoursesId]) VALUES (3, 2)
SET IDENTITY_INSERT [dbo].[Students] ON 

INSERT [dbo].[Students] ([Id], [Name], [FacultiesID]) VALUES (1, N'Pesho', 1)
INSERT [dbo].[Students] ([Id], [Name], [FacultiesID]) VALUES (2, N'Gosho', 1)
INSERT [dbo].[Students] ([Id], [Name], [FacultiesID]) VALUES (3, N'Tisho', 2)
SET IDENTITY_INSERT [dbo].[Students] OFF
SET IDENTITY_INSERT [dbo].[Titles] ON 

INSERT [dbo].[Titles] ([Id], [Name]) VALUES (1, N'Academician')
INSERT [dbo].[Titles] ([Id], [Name]) VALUES (2, N'Senior Assistant')
SET IDENTITY_INSERT [dbo].[Titles] OFF
ALTER TABLE [dbo].[Courses]  WITH CHECK ADD  CONSTRAINT [FK_Courses_Departments] FOREIGN KEY([Department_Id])
REFERENCES [dbo].[Departments] ([Id])
GO
ALTER TABLE [dbo].[Courses] CHECK CONSTRAINT [FK_Courses_Departments]
GO
ALTER TABLE [dbo].[Departments]  WITH CHECK ADD  CONSTRAINT [FK_Departments_Faculties] FOREIGN KEY([FacultyId])
REFERENCES [dbo].[Faculties] ([Id])
GO
ALTER TABLE [dbo].[Departments] CHECK CONSTRAINT [FK_Departments_Faculties]
GO
ALTER TABLE [dbo].[Professor_Courses]  WITH CHECK ADD  CONSTRAINT [FK_Professor_Courses_Courses] FOREIGN KEY([ProfessorId])
REFERENCES [dbo].[Courses] ([Id])
GO
ALTER TABLE [dbo].[Professor_Courses] CHECK CONSTRAINT [FK_Professor_Courses_Courses]
GO
ALTER TABLE [dbo].[Professor_Courses]  WITH CHECK ADD  CONSTRAINT [FK_Professor_Courses_Professors] FOREIGN KEY([ProfessorId])
REFERENCES [dbo].[Professors] ([Id])
GO
ALTER TABLE [dbo].[Professor_Courses] CHECK CONSTRAINT [FK_Professor_Courses_Professors]
GO
ALTER TABLE [dbo].[Professor_Title]  WITH CHECK ADD  CONSTRAINT [FK_Professor_Title_Professors1] FOREIGN KEY([ProfessorId])
REFERENCES [dbo].[Professors] ([Id])
GO
ALTER TABLE [dbo].[Professor_Title] CHECK CONSTRAINT [FK_Professor_Title_Professors1]
GO
ALTER TABLE [dbo].[Professor_Title]  WITH CHECK ADD  CONSTRAINT [FK_Professor_Title_Titles1] FOREIGN KEY([TitleId])
REFERENCES [dbo].[Titles] ([Id])
GO
ALTER TABLE [dbo].[Professor_Title] CHECK CONSTRAINT [FK_Professor_Title_Titles1]
GO
ALTER TABLE [dbo].[Professors]  WITH CHECK ADD  CONSTRAINT [FK_Professors_Departments] FOREIGN KEY([DepartmentId])
REFERENCES [dbo].[Departments] ([Id])
GO
ALTER TABLE [dbo].[Professors] CHECK CONSTRAINT [FK_Professors_Departments]
GO
ALTER TABLE [dbo].[Student_Courses]  WITH CHECK ADD  CONSTRAINT [FK_Student_Courses_Courses] FOREIGN KEY([CoursesId])
REFERENCES [dbo].[Courses] ([Id])
GO
ALTER TABLE [dbo].[Student_Courses] CHECK CONSTRAINT [FK_Student_Courses_Courses]
GO
ALTER TABLE [dbo].[Student_Courses]  WITH CHECK ADD  CONSTRAINT [FK_Student_Courses_Students] FOREIGN KEY([StudentId])
REFERENCES [dbo].[Students] ([Id])
GO
ALTER TABLE [dbo].[Student_Courses] CHECK CONSTRAINT [FK_Student_Courses_Students]
GO
ALTER TABLE [dbo].[Students]  WITH CHECK ADD  CONSTRAINT [FK_Students_Faculties] FOREIGN KEY([FacultiesID])
REFERENCES [dbo].[Faculties] ([Id])
GO
ALTER TABLE [dbo].[Students] CHECK CONSTRAINT [FK_Students_Faculties]
GO
USE [master]
GO
ALTER DATABASE [MyUniversitySystem] SET  READ_WRITE 
GO
