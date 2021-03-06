USE [dbITSupport]
GO
/****** Object:  Table [dbo].[tblFabricante]    Script Date: 06/02/2016 06:14:34 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[tblFabricante](
	[FabricanteID] [int] IDENTITY(1,1) NOT NULL,
	[FabricanteNome] [varchar](50) NOT NULL,
	[CNPJ] [varchar](50) NOT NULL,
	[WebSite] [varchar](50) NULL
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
SET IDENTITY_INSERT [dbo].[tblFabricante] ON
INSERT [dbo].[tblFabricante] ([FabricanteID], [FabricanteNome], [CNPJ], [WebSite]) VALUES (1, N'Dell Inc.', N'72.381.189/0001-10', N'www.dell.com')
INSERT [dbo].[tblFabricante] ([FabricanteID], [FabricanteNome], [CNPJ], [WebSite]) VALUES (2, N'Lenovo', N'07.275.920/0001-61', N'www.lenovo.com.br')
INSERT [dbo].[tblFabricante] ([FabricanteID], [FabricanteNome], [CNPJ], [WebSite]) VALUES (3, N'Hewlett-Packard', N'61.797.924/0028-75', N'www.hp.com.br')
INSERT [dbo].[tblFabricante] ([FabricanteID], [FabricanteNome], [CNPJ], [WebSite]) VALUES (4, N'Apple', N'00.623.904/0001-73', N'www.apple.com')
INSERT [dbo].[tblFabricante] ([FabricanteID], [FabricanteNome], [CNPJ], [WebSite]) VALUES (5, N'Microsoft', N'60.316.817/0004-48', N'www.microsoft.com')
INSERT [dbo].[tblFabricante] ([FabricanteID], [FabricanteNome], [CNPJ], [WebSite]) VALUES (6, N'Cisco Systems', N'00.028.666/0003-10', N'www.cisco.com')
SET IDENTITY_INSERT [dbo].[tblFabricante] OFF
