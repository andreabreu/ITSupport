USE [dbITSupport]
GO
/****** Object:  Table [dbo].[tblFabricante]    Script Date: 05/27/2016 01:06:15 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[tblFabricante](
	[FabricanteID] [int] IDENTITY(1,1) NOT NULL,
	[CNPJ] [varchar](50) NOT NULL,
	[Fabricante] [varchar](50) NOT NULL,
	[Descricao] [varchar](50) NOT NULL
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
SET IDENTITY_INSERT [dbo].[tblFabricante] ON
INSERT [dbo].[tblFabricante] ([FabricanteID], [CNPJ], [Fabricante], [Descricao]) VALUES (1, N'123', N'Dell Inc.', N'Distribuidora de Computadores')
SET IDENTITY_INSERT [dbo].[tblFabricante] OFF
