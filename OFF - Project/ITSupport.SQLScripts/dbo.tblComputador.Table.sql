USE [dbITSupport]
GO
/****** Object:  Table [dbo].[tblComputador]    Script Date: 06/02/2016 06:14:34 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[tblComputador](
	[Tipo] [varchar](50) NOT NULL,
	[Fabricante] [varchar](50) NOT NULL,
	[Modelo] [varchar](50) NOT NULL,
	[ServiceTag] [varchar](50) NOT NULL,
	[Processador] [varchar](50) NOT NULL,
	[HardDrive] [varchar](50) NOT NULL,
	[Memoria] [varchar](50) NOT NULL,
	[Hostname] [varchar](50) NULL,
	[CentroCusto] [varchar](50) NULL,
	[Status] [varchar](50) NULL,
	[Ativo] [varchar](50) NOT NULL,
	[DataCadastro] [datetime] NOT NULL,
	[DataUpdate] [datetime] NULL,
 CONSTRAINT [IX_tblComputador] UNIQUE NONCLUSTERED 
(
	[ServiceTag] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
INSERT [dbo].[tblComputador] ([Tipo], [Fabricante], [Modelo], [ServiceTag], [Processador], [HardDrive], [Memoria], [Hostname], [CentroCusto], [Status], [Ativo], [DataCadastro], [DataUpdate]) VALUES (N'Notebook', N'1', N'2', N'456', N'Intel Core i5', N'80 GB', N'3 GB', N'BRSP213', N'345', N'Usad', N'012343', CAST(0x0000A6A000000000 AS DateTime), NULL)
INSERT [dbo].[tblComputador] ([Tipo], [Fabricante], [Modelo], [ServiceTag], [Processador], [HardDrive], [Memoria], [Hostname], [CentroCusto], [Status], [Ativo], [DataCadastro], [DataUpdate]) VALUES (N'Desktop', N'Dell Inc.', N'Latitude D620', N'sadsadas', N'Intel Celeron', N'80 GB', N'2 GB', N'aaaaaaaa', N'', N'Em Uso', N'sadasdsdadsdasds', CAST(0x0000A616018A02CC AS DateTime), CAST(0x0000000000000000 AS DateTime))
INSERT [dbo].[tblComputador] ([Tipo], [Fabricante], [Modelo], [ServiceTag], [Processador], [HardDrive], [Memoria], [Hostname], [CentroCusto], [Status], [Ativo], [DataCadastro], [DataUpdate]) VALUES (N'Desktop', N'Dell Inc.', N'Latitude D620', N'SADSW1', N'Intel Celeron', N'80 GB', N'2 GB', N'BRSP12312', N'', N'Em Uso', N'SDADSADSD', CAST(0x0000A6170002466C AS DateTime), CAST(0x0000000000000000 AS DateTime))
