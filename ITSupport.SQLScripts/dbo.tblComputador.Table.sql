USE [dbITSupport]
GO
/****** Object:  Table [dbo].[tblComputador]    Script Date: 05/27/2016 01:06:15 ******/
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
 CONSTRAINT [IX_tblComputador] UNIQUE NONCLUSTERED 
(
	[ServiceTag] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
