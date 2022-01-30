USE [PreUniversityAPP]
GO
INSERT [dbo].[AspNetRoles] ([Id], [Name], [NormalizedName], [ConcurrencyStamp]) VALUES (N'1', N'admin', N'ADMIN', NULL)
INSERT [dbo].[AspNetRoles] ([Id], [Name], [NormalizedName], [ConcurrencyStamp]) VALUES (N'2', N'profesor', N'PROFESOR', NULL)
INSERT [dbo].[AspNetRoles] ([Id], [Name], [NormalizedName], [ConcurrencyStamp]) VALUES (N'3', N'nxenes', N'NXENES', NULL)
INSERT [dbo].[AspNetRoles] ([Id], [Name], [NormalizedName], [ConcurrencyStamp]) VALUES (N'4', N'prind', N'PRIND', NULL)
GO
INSERT [dbo].[Parents] ([Id], [Name], [RoleId]) VALUES (N'572b5ade-1099-4f0c-ac2e-4c35f4eda18e', N'Filan Fisteku', N'4')
GO
INSERT [dbo].[Students] ([Id], [Name], [StudentNumber], [RoleId], [ParentId]) VALUES (N'39c4a620-3438-4f74-b18a-ed361bfa037b', N'Rinor Hyseni', N'192047818', N'3', N'572b5ade-1099-4f0c-ac2e-4c35f4eda18e')
GO
INSERT [dbo].[Teachers] ([Id], [Name], [Grade], [RoleId]) VALUES (N'88f73b16-8de2-427f-8ebc-0e046e205dc3', N'Edmond Jajaga', N'DR', N'2')
GO
INSERT [dbo].[Courses] ([Id], [Category], [TeacherId], [Title]) VALUES (N'9ece6098-db0e-444f-8917-a1a67c820c1d', N'Obligative', N'88f73b16-8de2-427f-8ebc-0e046e205dc3', N'Dizajn i softuerit')
GO
INSERT [dbo].[StudentCourses] ([Id], [StudentId], [CourseId], [Mark], [IsMarked]) VALUES (N'a89d702d-61cd-4d08-9c68-608ea7cc0837', N'39c4a620-3438-4f74-b18a-ed361bfa037b', N'9ece6098-db0e-444f-8917-a1a67c820c1d', 0, 1)
GO
INSERT [dbo].[__EFMigrationsHistory] ([MigrationId], [ProductVersion]) VALUES (N'20220130002908_InitialCreate', N'5.0.1')
GO
