/*
Navicat SQL Server Data Transfer

Source Server         : SQL Express Local
Source Server Version : 110000
Source Host           : DESKTOP-4OFAUV8\SQLEXPRESS:1433
Source Database       : SMS
Source Schema         : dbo

Target Server Type    : SQL Server
Target Server Version : 110000
File Encoding         : 65001

Date: 2019-02-23 01:10:18
*/


-- ----------------------------
-- Table structure for Admin
-- ----------------------------
DROP TABLE [dbo].[Admin]
GO
CREATE TABLE [dbo].[Admin] (
[Id] int NOT NULL IDENTITY(1,1) ,
[Username] varchar(50) NOT NULL ,
[Password] varchar(50) NOT NULL ,
[Recovery_Name] varchar(50) NOT NULL 
)


GO
DBCC CHECKIDENT(N'[dbo].[Admin]', RESEED, 7)
GO

-- ----------------------------
-- Records of Admin
-- ----------------------------
SET IDENTITY_INSERT [dbo].[Admin] ON
GO
INSERT INTO [dbo].[Admin] ([Id], [Username], [Password], [Recovery_Name]) VALUES (N'6', N'asdf', N'1234', N'asdf')
GO
GO
INSERT INTO [dbo].[Admin] ([Id], [Username], [Password], [Recovery_Name]) VALUES (N'7', N'admin', N'5154', N'admin')
GO
GO
SET IDENTITY_INSERT [dbo].[Admin] OFF
GO

-- ----------------------------
-- Table structure for HomeWork
-- ----------------------------
DROP TABLE [dbo].[HomeWork]
GO
CREATE TABLE [dbo].[HomeWork] (
[Id] int NOT NULL IDENTITY(1,1) ,
[Student_Id] int NOT NULL ,
[Monday] varchar(255) NULL ,
[Tuesday] varchar(255) NULL ,
[Wednesday] varchar(255) NULL ,
[Thursday] varchar(255) NULL ,
[Friday] varchar(255) NULL ,
[Saturday] varchar(255) NULL 
)


GO

-- ----------------------------
-- Records of HomeWork
-- ----------------------------
SET IDENTITY_INSERT [dbo].[HomeWork] ON
GO
INSERT INTO [dbo].[HomeWork] ([Id], [Student_Id], [Monday], [Tuesday], [Wednesday], [Thursday], [Friday], [Saturday]) VALUES (N'1', N'9', N'', N'Cloud Computing Paper', N'', N'', N'', N'')
GO
GO
SET IDENTITY_INSERT [dbo].[HomeWork] OFF
GO

-- ----------------------------
-- Table structure for Student
-- ----------------------------
DROP TABLE [dbo].[Student]
GO
CREATE TABLE [dbo].[Student] (
[Id] int NOT NULL IDENTITY(1,1) ,
[Name] varchar(50) NOT NULL ,
[FatherName] varchar(50) NOT NULL ,
[Gender] varchar(50) NOT NULL ,
[Phone] text NULL ,
[Address] text NULL ,
[Session] varchar(50) NULL ,
[AdminDate] datetime NULL ,
[DOB] datetime NULL ,
[Class] varchar(50) NOT NULL ,
[Email] varchar(50) NULL 
)


GO
DBCC CHECKIDENT(N'[dbo].[Student]', RESEED, 9)
GO

-- ----------------------------
-- Records of Student
-- ----------------------------
SET IDENTITY_INSERT [dbo].[Student] ON
GO
INSERT INTO [dbo].[Student] ([Id], [Name], [FatherName], [Gender], [Phone], [Address], [Session], [AdminDate], [DOB], [Class], [Email]) VALUES (N'6', N'as', N'asd', N'Male', N'123', N'dae21', N'1231', N'2019-02-06 00:00:00.000', N'2019-02-06 00:00:00.000', N'Ten', N'we1231w')
GO
GO
INSERT INTO [dbo].[Student] ([Id], [Name], [FatherName], [Gender], [Phone], [Address], [Session], [AdminDate], [DOB], [Class], [Email]) VALUES (N'7', N'a', N'sd', N'Male', N'123', N'ada123', N'1231', N'2019-02-06 00:00:00.000', N'2019-02-01 00:00:00.000', N'Ten', N'asdqw12')
GO
GO
INSERT INTO [dbo].[Student] ([Id], [Name], [FatherName], [Gender], [Phone], [Address], [Session], [AdminDate], [DOB], [Class], [Email]) VALUES (N'8', N'asd', N'asdf', N'Male', N'12124', N'asd123', N'123', N'2019-02-06 00:00:00.000', N'2019-02-06 00:00:00.000', N'Ten', N'asfas123')
GO
GO
INSERT INTO [dbo].[Student] ([Id], [Name], [FatherName], [Gender], [Phone], [Address], [Session], [AdminDate], [DOB], [Class], [Email]) VALUES (N'9', N'asd', N'fdas', N'Male', N'231234', N'sfad123', N'231', N'2019-02-06 00:00:00.000', N'1996-10-02 00:00:00.000', N'Ten', N'afasd123')
GO
GO
SET IDENTITY_INSERT [dbo].[Student] OFF
GO

-- ----------------------------
-- Table structure for Student_Attendance
-- ----------------------------
DROP TABLE [dbo].[Student_Attendance]
GO
CREATE TABLE [dbo].[Student_Attendance] (
[Id] int NOT NULL IDENTITY(1,1) ,
[Student_Id] int NOT NULL ,
[Total_Attendance] int NOT NULL ,
[Presence] int NOT NULL ,
[Absentees] int NOT NULL 
)


GO

-- ----------------------------
-- Records of Student_Attendance
-- ----------------------------
SET IDENTITY_INSERT [dbo].[Student_Attendance] ON
GO
INSERT INTO [dbo].[Student_Attendance] ([Id], [Student_Id], [Total_Attendance], [Presence], [Absentees]) VALUES (N'1', N'9', N'26', N'20', N'6')
GO
GO
SET IDENTITY_INSERT [dbo].[Student_Attendance] OFF
GO

-- ----------------------------
-- Table structure for Student_Fee
-- ----------------------------
DROP TABLE [dbo].[Student_Fee]
GO
CREATE TABLE [dbo].[Student_Fee] (
[Id] int NOT NULL IDENTITY(1,1) ,
[Student_Id] int NOT NULL ,
[Total_Fee] int NOT NULL ,
[Remaining_Dues] int NULL ,
[Due_Date] datetime NOT NULL ,
[Last_Date] datetime NOT NULL ,
[Fine] int NULL ,
[Transport_Dues] int NULL 
)


GO

-- ----------------------------
-- Records of Student_Fee
-- ----------------------------
SET IDENTITY_INSERT [dbo].[Student_Fee] ON
GO
INSERT INTO [dbo].[Student_Fee] ([Id], [Student_Id], [Total_Fee], [Remaining_Dues], [Due_Date], [Last_Date], [Fine], [Transport_Dues]) VALUES (N'1', N'6', N'1231', N'0', N'2019-02-07 01:05:25.000', N'2019-07-06 01:12:25.000', N'0', N'34')
GO
GO
SET IDENTITY_INSERT [dbo].[Student_Fee] OFF
GO

-- ----------------------------
-- Table structure for Student_Result
-- ----------------------------
DROP TABLE [dbo].[Student_Result]
GO
CREATE TABLE [dbo].[Student_Result] (
[Id] int NOT NULL IDENTITY(1,1) ,
[StudentId] int NOT NULL ,
[TotalMarks] int NOT NULL ,
[ObtainedMarks] int NOT NULL ,
[Percentage] varchar(255) NULL 
)


GO

-- ----------------------------
-- Records of Student_Result
-- ----------------------------
SET IDENTITY_INSERT [dbo].[Student_Result] ON
GO
INSERT INTO [dbo].[Student_Result] ([Id], [StudentId], [TotalMarks], [ObtainedMarks], [Percentage]) VALUES (N'1', N'6', N'1100', N'822', N'74.73%')
GO
GO
SET IDENTITY_INSERT [dbo].[Student_Result] OFF
GO

-- ----------------------------
-- Table structure for Teacher
-- ----------------------------
DROP TABLE [dbo].[Teacher]
GO
CREATE TABLE [dbo].[Teacher] (
[Id] int NOT NULL IDENTITY(1,1) ,
[Name] varchar(255) NOT NULL ,
[Gender] varchar(255) NOT NULL ,
[Phone] text NOT NULL ,
[Address] text NOT NULL ,
[Salary] int NOT NULL 
)


GO
DBCC CHECKIDENT(N'[dbo].[Teacher]', RESEED, 1007)
GO

-- ----------------------------
-- Records of Teacher
-- ----------------------------
SET IDENTITY_INSERT [dbo].[Teacher] ON
GO
INSERT INTO [dbo].[Teacher] ([Id], [Name], [Gender], [Phone], [Address], [Salary]) VALUES (N'1004', N'Abdullah Farooq', N'Male', N'606', N'aqwe123', N'231341')
GO
GO
INSERT INTO [dbo].[Teacher] ([Id], [Name], [Gender], [Phone], [Address], [Salary]) VALUES (N'1005', N'asd', N'Male', N'123', N'asd', N'1231')
GO
GO
INSERT INTO [dbo].[Teacher] ([Id], [Name], [Gender], [Phone], [Address], [Salary]) VALUES (N'1006', N'sdfasdf', N'Male', N'asd', N'asdas', N'31')
GO
GO
SET IDENTITY_INSERT [dbo].[Teacher] OFF
GO

-- ----------------------------
-- Table structure for Teacher_Attendance
-- ----------------------------
DROP TABLE [dbo].[Teacher_Attendance]
GO
CREATE TABLE [dbo].[Teacher_Attendance] (
[Id] int NOT NULL IDENTITY(1,1) ,
[Teacher_Id] int NOT NULL ,
[Total_Attendance] int NOT NULL ,
[Presence] int NOT NULL ,
[Absentees] int NOT NULL 
)


GO
DBCC CHECKIDENT(N'[dbo].[Teacher_Attendance]', RESEED, 2)
GO

-- ----------------------------
-- Records of Teacher_Attendance
-- ----------------------------
SET IDENTITY_INSERT [dbo].[Teacher_Attendance] ON
GO
INSERT INTO [dbo].[Teacher_Attendance] ([Id], [Teacher_Id], [Total_Attendance], [Presence], [Absentees]) VALUES (N'2', N'1004', N'26', N'24', N'2')
GO
GO
SET IDENTITY_INSERT [dbo].[Teacher_Attendance] OFF
GO

-- ----------------------------
-- Table structure for Time_Table
-- ----------------------------
DROP TABLE [dbo].[Time_Table]
GO
CREATE TABLE [dbo].[Time_Table] (
[Id] int NOT NULL IDENTITY(1,1) ,
[Teacher_Id] int NOT NULL ,
[Monday] varchar(MAX) NULL ,
[Tuesday] varchar(MAX) NULL ,
[Wednesday] varchar(MAX) NULL ,
[Thursday] varchar(MAX) NULL ,
[Friday] varchar(MAX) NULL ,
[Saturday] varchar(MAX) NULL 
)


GO
DBCC CHECKIDENT(N'[dbo].[Time_Table]', RESEED, 3)
GO

-- ----------------------------
-- Records of Time_Table
-- ----------------------------
SET IDENTITY_INSERT [dbo].[Time_Table] ON
GO
INSERT INTO [dbo].[Time_Table] ([Id], [Teacher_Id], [Monday], [Tuesday], [Wednesday], [Thursday], [Friday], [Saturday]) VALUES (N'2', N'1004', N'asda', N'', N'', N'ssdf', N'', N'')
GO
GO
SET IDENTITY_INSERT [dbo].[Time_Table] OFF
GO

-- ----------------------------
-- Indexes structure for table Admin
-- ----------------------------

-- ----------------------------
-- Primary Key structure for table Admin
-- ----------------------------
ALTER TABLE [dbo].[Admin] ADD PRIMARY KEY ([Id])
GO

-- ----------------------------
-- Indexes structure for table HomeWork
-- ----------------------------
CREATE UNIQUE INDEX [IX_Student_HomeWork] ON [dbo].[HomeWork]
([Student_Id] ASC) 
WITH (IGNORE_DUP_KEY = ON)
GO

-- ----------------------------
-- Primary Key structure for table HomeWork
-- ----------------------------
ALTER TABLE [dbo].[HomeWork] ADD PRIMARY KEY ([Id])
GO

-- ----------------------------
-- Indexes structure for table Student
-- ----------------------------

-- ----------------------------
-- Primary Key structure for table Student
-- ----------------------------
ALTER TABLE [dbo].[Student] ADD PRIMARY KEY ([Id])
GO

-- ----------------------------
-- Indexes structure for table Student_Attendance
-- ----------------------------
CREATE UNIQUE INDEX [IX_StudentAttendance_Student] ON [dbo].[Student_Attendance]
([Student_Id] ASC) 
WITH (IGNORE_DUP_KEY = ON)
GO

-- ----------------------------
-- Primary Key structure for table Student_Attendance
-- ----------------------------
ALTER TABLE [dbo].[Student_Attendance] ADD PRIMARY KEY ([Id])
GO

-- ----------------------------
-- Indexes structure for table Student_Fee
-- ----------------------------
CREATE UNIQUE INDEX [IX_StudentFee_Student] ON [dbo].[Student_Fee]
([Student_Id] ASC) 
WITH (IGNORE_DUP_KEY = ON)
GO

-- ----------------------------
-- Primary Key structure for table Student_Fee
-- ----------------------------
ALTER TABLE [dbo].[Student_Fee] ADD PRIMARY KEY ([Id])
GO

-- ----------------------------
-- Indexes structure for table Student_Result
-- ----------------------------
CREATE UNIQUE INDEX [IX_Student_StudentResult] ON [dbo].[Student_Result]
([StudentId] ASC) 
WITH (IGNORE_DUP_KEY = ON)
GO

-- ----------------------------
-- Primary Key structure for table Student_Result
-- ----------------------------
ALTER TABLE [dbo].[Student_Result] ADD PRIMARY KEY ([Id])
GO

-- ----------------------------
-- Indexes structure for table Teacher
-- ----------------------------

-- ----------------------------
-- Primary Key structure for table Teacher
-- ----------------------------
ALTER TABLE [dbo].[Teacher] ADD PRIMARY KEY ([Id])
GO

-- ----------------------------
-- Indexes structure for table Teacher_Attendance
-- ----------------------------
CREATE UNIQUE INDEX [IX_TeacherAttendance_Teacher] ON [dbo].[Teacher_Attendance]
([Teacher_Id] ASC) 
WITH (IGNORE_DUP_KEY = ON)
GO

-- ----------------------------
-- Primary Key structure for table Teacher_Attendance
-- ----------------------------
ALTER TABLE [dbo].[Teacher_Attendance] ADD PRIMARY KEY ([Id])
GO

-- ----------------------------
-- Indexes structure for table Time_Table
-- ----------------------------
CREATE UNIQUE INDEX [IX_Teacher_TimeTable] ON [dbo].[Time_Table]
([Teacher_Id] ASC) 
WITH (IGNORE_DUP_KEY = ON)
GO

-- ----------------------------
-- Primary Key structure for table Time_Table
-- ----------------------------
ALTER TABLE [dbo].[Time_Table] ADD PRIMARY KEY ([Id])
GO

-- ----------------------------
-- Foreign Key structure for table [dbo].[HomeWork]
-- ----------------------------
ALTER TABLE [dbo].[HomeWork] ADD FOREIGN KEY ([Student_Id]) REFERENCES [dbo].[Student] ([Id]) ON DELETE CASCADE ON UPDATE CASCADE NOT FOR REPLICATION
GO

-- ----------------------------
-- Foreign Key structure for table [dbo].[Student_Attendance]
-- ----------------------------
ALTER TABLE [dbo].[Student_Attendance] ADD FOREIGN KEY ([Student_Id]) REFERENCES [dbo].[Student] ([Id]) ON DELETE CASCADE ON UPDATE CASCADE NOT FOR REPLICATION
GO

-- ----------------------------
-- Foreign Key structure for table [dbo].[Student_Fee]
-- ----------------------------
ALTER TABLE [dbo].[Student_Fee] ADD FOREIGN KEY ([Student_Id]) REFERENCES [dbo].[Student] ([Id]) ON DELETE CASCADE ON UPDATE CASCADE NOT FOR REPLICATION
GO

-- ----------------------------
-- Foreign Key structure for table [dbo].[Student_Result]
-- ----------------------------
ALTER TABLE [dbo].[Student_Result] ADD FOREIGN KEY ([StudentId]) REFERENCES [dbo].[Student] ([Id]) ON DELETE CASCADE ON UPDATE CASCADE NOT FOR REPLICATION
GO

-- ----------------------------
-- Foreign Key structure for table [dbo].[Teacher_Attendance]
-- ----------------------------
ALTER TABLE [dbo].[Teacher_Attendance] ADD FOREIGN KEY ([Teacher_Id]) REFERENCES [dbo].[Teacher] ([Id]) ON DELETE CASCADE ON UPDATE CASCADE NOT FOR REPLICATION
GO

-- ----------------------------
-- Foreign Key structure for table [dbo].[Time_Table]
-- ----------------------------
ALTER TABLE [dbo].[Time_Table] ADD FOREIGN KEY ([Teacher_Id]) REFERENCES [dbo].[Teacher] ([Id]) ON DELETE CASCADE ON UPDATE CASCADE NOT FOR REPLICATION
GO
