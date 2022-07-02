USE [master];
GO

DROP DATABASE MemberManagerment
GO

CREATE DATABASE MemberManagerment
GO

USE MemberManagerment
GO


CREATE TABLE [MemberObject](
[MemberID]       int  not Null PRIMARY KEY,
[MemberName]           [nvarchar](1500),
[Email]       [nvarchar](50),
[Password]          [nvarchar](50),
[City]        [nvarchar](50),
[Country] [nvarchar](50)
);
INSERT [MemberObject] ([MemberID], [MemberName],[Email],[Password],[City],[Country]) VALUES (1, N'jack', '123@gmail.com','12',N'New York', N'United State')
INSERT [MemberObject] ([MemberID], [MemberName],[Email],[Password],[City],[Country])  VALUES (2, N'Thuy', 'thuy@gmail.com','12',N'San Diego', N'United State')
INSERT [MemberObject] ([MemberID], [MemberName],[Email],[Password],[City],[Country])  VALUES (3, N'Androi', 'android@gmail.com','12',N'Houston', N'United State')
INSERT [MemberObject] ([MemberID], [MemberName],[Email],[Password],[City],[Country]) VALUES (4, N'Tinin', 'tini@gmail.com','12',N'Phu Quoc', N'Viet Nam')
INSERT [MemberObject] ([MemberID], [MemberName],[Email],[Password],[City],[Country])  VALUES (5, N'quangcake', 'quangcake@gmail.com','12',N'Da Nang', N'Viet Nam')
INSERT [MemberObject] ([MemberID], [MemberName],[Email],[Password],[City],[Country])  VALUES (6, N'quickku', 'quickku@gmail.com','12',N'Sai gon', N'Viet Nam')
INSERT [MemberObject] ([MemberID], [MemberName],[Email],[Password],[City],[Country])  VALUES (7, N'hany', 'hany@gmail.com','12',N'Sai gon', N'Viet Nam')
