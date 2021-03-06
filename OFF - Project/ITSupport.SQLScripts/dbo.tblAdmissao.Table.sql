USE [dbITSupport]
GO
/****** Object:  Table [dbo].[tblAdmissao]    Script Date: 06/06/2016 05:56:52 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[tblAdmissao](
	[AdmissaoID] [int] IDENTITY(1,1) NOT NULL,
	[DataInicio] [datetime] NULL,
	[Nome] [varchar](100) NULL,
	[DataNascimento] [datetime] NULL,
	[Rg] [varchar](50) NULL,
	[Cpf] [varchar](50) NULL,
	[TelefoneResidencial] [varchar](50) NULL,
	[TelefoneCelular] [varchar](50) NULL,
	[EmailPessoal] [varchar](100) NULL,
	[Endereco] [varchar](200) NULL,
	[Cep] [varchar](50) NULL,
	[Cidade] [varchar](50) NULL,
	[NomeMae] [varchar](100) NULL,
	[Cargo] [varchar](100) NULL,
	[JobLeveling] [int] NULL,
	[VinculoEmpregaticio] [varchar](50) NULL,
	[Matricula] [int] NULL,
	[IdPeopleSoft] [int] NULL,
	[CentroDeCusto] [varchar](100) NULL,
	[UnidadeDeNegocio] [varchar](50) NULL,
	[Gestor] [varchar](100) NULL,
	[MatriculaGestor] [int] NULL,
	[LocalDeTrabalho] [varchar](50) NULL,
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
	[DataSolicitacao] [datetime] NULL,
	[RequestBy] [varchar](50) NULL,
	[SupportedBy] [varchar](50) NULL,
	[ApprovedBy] [varchar](50) NULL,
	[Status] [varchar](50) NULL
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
SET IDENTITY_INSERT [dbo].[tblAdmissao] ON
INSERT [dbo].[tblAdmissao] ([AdmissaoID], [DataInicio], [Nome], [DataNascimento], [Rg], [Cpf], [TelefoneResidencial], [TelefoneCelular], [EmailPessoal], [Endereco], [Cep], [Cidade], [NomeMae], [Cargo], [JobLeveling], [VinculoEmpregaticio], [Matricula], [IdPeopleSoft], [CentroDeCusto], [UnidadeDeNegocio], [Gestor], [MatriculaGestor], [LocalDeTrabalho], [Cliente], [MotivoVaga], [Efetivacao], [VinculoAnterior], [AlteracaoLayout], [NovaEstacao], [NovoEquipamento], [NovoRamal], [NumeroRamal], [TipoEquipamento], [GrupoDeEmail], [SugestaoDeEmail], [AcessoRede], [AcessoSalesForce], [AcessoAonAccess], [AcessoGams], [AcessoRelatoriosWeb], [AcessoMicrosiga], [AcessoCol], [AcessoInfraClient], [AcessoInfraManut], [OutrosAcessos], [DataSolicitacao], [RequestBy], [SupportedBy], [ApprovedBy], [Status]) VALUES (2, CAST(0x0000A61D00000000 AS DateTime), N'Andre Camilo de abreu', CAST(0x0000873C00000000 AS DateTime), N'38.089.339-7', N'437.508.378-64', N'(11) 3105-7383', N'(11) 98214-9143', N'andre.abreu@live.com', N'Rua Genebra', N'01316010', N'São Paulo', N'Josina Cailo', N'Analista de Suporte', 6, N'Terceiro', 131232, 0, N'92761 - Finance Systems Corp Latam BR', N'Aon Holdings', N'Patricia Aparecida Dias da Mata', 999999, N'Salvador', N'Sim', N'Aumento de Quadro', N'', N'', N'Nao', N'Sim', N'Sim', N'Sim', N'', N'Notebook', N'BR-ARS-RHTI', N'andreabreu.tpr@aon.com', N'Felipe Abreu', N'Patrick Luz', N'', N'', N'', N'', N'Erick Fonseca', N'', N'', N'', CAST(0x0000A61C010B9E28 AS DateTime), N'lucileia_lima', N'erick_fonsceca', N'Danilo_paula_trp', N'Concluido')
SET IDENTITY_INSERT [dbo].[tblAdmissao] OFF
