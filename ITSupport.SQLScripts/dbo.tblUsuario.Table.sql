USE [dbITSupport]
GO
/****** Object:  Table [dbo].[tblUsuario]    Script Date: 05/27/2016 01:06:15 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[tblUsuario](
	[Nome] [varchar](100) NOT NULL,
	[Username] [varchar](50) NOT NULL,
	[Departamento] [varchar](50) NOT NULL,
	[Email] [varchar](50) NOT NULL,
	[Ramal] [int] NOT NULL,
	[Cargo] [varchar](50) NOT NULL,
	[Superior] [varchar](100) NOT NULL,
	[ScriptPath] [varchar](50) NULL,
	[Matricula] [int] NOT NULL,
	[Created] [datetime] NOT NULL,
	[AccountExpirationDate] [datetime] NOT NULL,
	[DistinguishedName] [varchar](200) NULL,
	[Enabled] [varchar](50) NOT NULL,
	[LastLogon] [datetime] NOT NULL,
	[LastPasswordSet] [datetime] NULL,
	[Domain] [varchar](50) NOT NULL
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
