USE [dbITSupport]
GO
/****** Object:  Table [dbo].[tblCadeado]    Script Date: 06/02/2016 06:14:34 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[tblCadeado](
	[CadeadoID] [int] IDENTITY(1,1) NOT NULL,
	[Marca] [varchar](50) NULL,
	[SerialNumber] [varchar](50) NULL,
	[Code] [int] NOT NULL,
	[Owned] [varchar](50) NULL
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
