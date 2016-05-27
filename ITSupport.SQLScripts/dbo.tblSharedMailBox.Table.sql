USE [dbITSupport]
GO
/****** Object:  Table [dbo].[tblSharedMailBox]    Script Date: 05/27/2016 01:06:15 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[tblSharedMailBox](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[Email] [varchar](100) NOT NULL,
	[Alias] [varchar](50) NOT NULL,
	[Manager] [varchar](100) NULL
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
