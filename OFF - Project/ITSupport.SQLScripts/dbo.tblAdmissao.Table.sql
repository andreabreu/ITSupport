USE [dbITSupport]
GO
/****** Object:  Table [dbo].[tblAdmissao]    Script Date: 06/02/2016 06:14:34 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[tblAdmissao](
	[DataInicio] [datetime] NOT NULL,
	[Nome] [varchar](100) NOT NULL,
	[DataNascimento] [datetime] NOT NULL,
	[Rg] [varchar](50) NOT NULL,
	[Cpf] [varchar](50) NOT NULL,
	[TelefoneResidencial] [varchar](50) NULL,
	[TelefoneCelular] [varchar](50) NOT NULL,
	[EmailPessoal] [varchar](100) NOT NULL,
	[Endereco] [varchar](200) NOT NULL,
	[Cep] [varchar](50) NOT NULL,
	[Cidade] [varchar](50) NOT NULL,
	[NomeMae] [varchar](100) NULL,
	[Cargo] [varchar](100) NOT NULL,
	[JobLeveling] [int] NOT NULL,
	[VinculoEmpregaticio] [varchar](50) NOT NULL,
	[Matricula] [int] NOT NULL,
	[IdPeopleSoft] [int] NOT NULL,
	[CentroDeCusto] [int] NOT NULL,
	[Area] [varchar](100) NOT NULL,
	[UnidadeDeNegocio] [varchar](50) NOT NULL,
	[Gestor] [varchar](100) NOT NULL,
	[MatriculaGestor] [int] NOT NULL,
	[LocalDeTrabalho] [varchar](50) NOT NULL,
	[Cliente] [varchar](50) NULL,
	[MotivoVaga] [varchar](100) NULL,
	[Efetivacao] [varchar](50) NULL,
	[VinculoAnterior] [varchar](50) NULL,
	[AlteracaoLayout] [varchar](50) NOT NULL,
	[NovaEstacao] [varchar](50) NOT NULL,
	[NovoEquipamento] [varchar](50) NOT NULL,
	[NovoRamal] [varchar](50) NOT NULL,
	[NumeroRamal] [varchar](50) NOT NULL,
	[TipoEquipamento] [varchar](50) NULL,
	[GrupoDeEmail] [varchar](200) NULL,
	[SugestaoDeEmail] [varchar](100) NULL,
	[AcessoRede] [varchar](100) NULL,
	[AcessoSalesForce] [varchar](50) NULL,
	[AcessoAonAccess] [varchar](50) NULL,
	[AcessoGams] [varchar](50) NULL,
	[AcessoRelatoriosWeb] [varchar](50) NULL,
	[AcessoMicrosiga] [varchar](50) NULL,
	[AcessoCol] [varchar](50) NULL,
	[AcessoInfraClient] [varchar](50) NULL,
	[AcessoInfraManut] [varchar](50) NULL,
	[OutrosAcessos] [varchar](max) NULL,
	[DataSolicitacao] [datetime] NOT NULL
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
