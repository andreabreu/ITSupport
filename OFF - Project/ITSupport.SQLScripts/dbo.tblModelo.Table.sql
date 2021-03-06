USE [dbITSupport]
GO
/****** Object:  Table [dbo].[tblModelo]    Script Date: 06/02/2016 06:14:34 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[tblModelo](
	[ModeloID] [int] IDENTITY(1,1) NOT NULL,
	[Fabricante] [varchar](50) NOT NULL,
	[ModeloNome] [varchar](50) NOT NULL
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
SET IDENTITY_INSERT [dbo].[tblModelo] ON
INSERT [dbo].[tblModelo] ([ModeloID], [Fabricante], [ModeloNome]) VALUES (1, N'Dell Inc.', N'Latitude D620')
INSERT [dbo].[tblModelo] ([ModeloID], [Fabricante], [ModeloNome]) VALUES (2, N'Dell Inc.', N'Latitude D630')
INSERT [dbo].[tblModelo] ([ModeloID], [Fabricante], [ModeloNome]) VALUES (3, N'Dell Inc.', N'Latitude E4200')
INSERT [dbo].[tblModelo] ([ModeloID], [Fabricante], [ModeloNome]) VALUES (4, N'Dell Inc.', N'Latitude E4300 ')
INSERT [dbo].[tblModelo] ([ModeloID], [Fabricante], [ModeloNome]) VALUES (5, N'Dell Inc.', N'Latitude E4310')
INSERT [dbo].[tblModelo] ([ModeloID], [Fabricante], [ModeloNome]) VALUES (6, N'Dell Inc.', N'Latitude E5410')
INSERT [dbo].[tblModelo] ([ModeloID], [Fabricante], [ModeloNome]) VALUES (7, N'Dell Inc.', N'Latitude E5420')
INSERT [dbo].[tblModelo] ([ModeloID], [Fabricante], [ModeloNome]) VALUES (8, N'Dell Inc.', N'Latitude E5470')
INSERT [dbo].[tblModelo] ([ModeloID], [Fabricante], [ModeloNome]) VALUES (9, N'Dell Inc.', N'Latitude E6220')
INSERT [dbo].[tblModelo] ([ModeloID], [Fabricante], [ModeloNome]) VALUES (10, N'Dell Inc.', N'Latitude E6230')
INSERT [dbo].[tblModelo] ([ModeloID], [Fabricante], [ModeloNome]) VALUES (11, N'Dell Inc.', N'Latitude E6320')
INSERT [dbo].[tblModelo] ([ModeloID], [Fabricante], [ModeloNome]) VALUES (12, N'Dell Inc.', N'Latitude E6330')
INSERT [dbo].[tblModelo] ([ModeloID], [Fabricante], [ModeloNome]) VALUES (13, N'Dell Inc.', N'Latitude E6440')
INSERT [dbo].[tblModelo] ([ModeloID], [Fabricante], [ModeloNome]) VALUES (14, N'Dell Inc.', N'Latitude E7240')
INSERT [dbo].[tblModelo] ([ModeloID], [Fabricante], [ModeloNome]) VALUES (15, N'Dell Inc.', N'Latitude E7250')
INSERT [dbo].[tblModelo] ([ModeloID], [Fabricante], [ModeloNome]) VALUES (16, N'Dell Inc.', N'Latitude E7440')
INSERT [dbo].[tblModelo] ([ModeloID], [Fabricante], [ModeloNome]) VALUES (17, N'Dell Inc.', N'Latitude E7450')
INSERT [dbo].[tblModelo] ([ModeloID], [Fabricante], [ModeloNome]) VALUES (18, N'Dell Inc.', N'OptiPlex 3020')
INSERT [dbo].[tblModelo] ([ModeloID], [Fabricante], [ModeloNome]) VALUES (19, N'Dell Inc.', N'OptiPlex 3020M')
INSERT [dbo].[tblModelo] ([ModeloID], [Fabricante], [ModeloNome]) VALUES (20, N'Dell Inc.', N'OptiPlex 7010')
INSERT [dbo].[tblModelo] ([ModeloID], [Fabricante], [ModeloNome]) VALUES (21, N'Dell Inc.', N'OptiPlex 7020')
INSERT [dbo].[tblModelo] ([ModeloID], [Fabricante], [ModeloNome]) VALUES (22, N'Dell Inc.', N'OptiPlex 745')
INSERT [dbo].[tblModelo] ([ModeloID], [Fabricante], [ModeloNome]) VALUES (23, N'Dell Inc.', N'OptiPlex 755')
INSERT [dbo].[tblModelo] ([ModeloID], [Fabricante], [ModeloNome]) VALUES (24, N'Dell Inc.', N'OptiPlex 760')
INSERT [dbo].[tblModelo] ([ModeloID], [Fabricante], [ModeloNome]) VALUES (25, N'Dell Inc.', N'OptiPlex 780')
INSERT [dbo].[tblModelo] ([ModeloID], [Fabricante], [ModeloNome]) VALUES (26, N'Dell Inc.', N'OptiPlex 790')
INSERT [dbo].[tblModelo] ([ModeloID], [Fabricante], [ModeloNome]) VALUES (27, N'Dell Inc.', N'OptiPlex 9020')
INSERT [dbo].[tblModelo] ([ModeloID], [Fabricante], [ModeloNome]) VALUES (28, N'Dell Inc.', N'OptiPlex 9020M')
INSERT [dbo].[tblModelo] ([ModeloID], [Fabricante], [ModeloNome]) VALUES (29, N'Hewlett-Packard', N'HP EliteBook 6930p')
INSERT [dbo].[tblModelo] ([ModeloID], [Fabricante], [ModeloNome]) VALUES (30, N'Hewlett-Packard', N'HP EliteBook 8440p')
INSERT [dbo].[tblModelo] ([ModeloID], [Fabricante], [ModeloNome]) VALUES (31, N'Lenovo', N'6234A1P')
INSERT [dbo].[tblModelo] ([ModeloID], [Fabricante], [ModeloNome]) VALUES (32, N'Lenovo', N'6234BQ7')
INSERT [dbo].[tblModelo] ([ModeloID], [Fabricante], [ModeloNome]) VALUES (33, N'Lenovo', N'6234CY8')
INSERT [dbo].[tblModelo] ([ModeloID], [Fabricante], [ModeloNome]) VALUES (34, N'Lenovo', N'6234CZ1')
INSERT [dbo].[tblModelo] ([ModeloID], [Fabricante], [ModeloNome]) VALUES (35, N'Lenovo', N'6234DF7')
INSERT [dbo].[tblModelo] ([ModeloID], [Fabricante], [ModeloNome]) VALUES (36, N'Lenovo', N'6234E27')
INSERT [dbo].[tblModelo] ([ModeloID], [Fabricante], [ModeloNome]) VALUES (37, N'Lenovo', N'6234EG1')
SET IDENTITY_INSERT [dbo].[tblModelo] OFF
