USE [dbITSupport]
GO
/****** Object:  Table [dbo].[tblFornecedor]    Script Date: 06/02/2016 06:14:34 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[tblFornecedor](
	[FornecedorID] [int] IDENTITY(1,1) NOT NULL,
	[Nome] [varchar](100) NOT NULL,
	[Descricao] [varchar](200) NULL,
	[Endereco] [varchar](50) NULL,
	[CEP] [varchar](50) NULL,
	[Cidade] [varchar](50) NULL,
	[Estado] [varchar](50) NULL,
	[Telefone] [varchar](50) NOT NULL,
	[Email] [varchar](50) NOT NULL,
	[Website] [varchar](50) NULL
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
