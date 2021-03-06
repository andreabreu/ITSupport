USE [master]
GO
/****** Object:  Database [dbITSupport]    Script Date: 05/31/2016 00:42:44 ******/
CREATE DATABASE [dbITSupport] ON  PRIMARY 
( NAME = N'dbITSupport', FILENAME = N'c:\Program Files\Microsoft SQL Server\MSSQL10_50.SQLEXPRESS\MSSQL\DATA\dbITSupport.mdf' , SIZE = 3072KB , MAXSIZE = UNLIMITED, FILEGROWTH = 1024KB )
 LOG ON 
( NAME = N'dbITSupport_log', FILENAME = N'c:\Program Files\Microsoft SQL Server\MSSQL10_50.SQLEXPRESS\MSSQL\DATA\dbITSupport_log.ldf' , SIZE = 1024KB , MAXSIZE = 2048GB , FILEGROWTH = 10%)
GO
ALTER DATABASE [dbITSupport] SET COMPATIBILITY_LEVEL = 100
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [dbITSupport].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [dbITSupport] SET ANSI_NULL_DEFAULT OFF
GO
ALTER DATABASE [dbITSupport] SET ANSI_NULLS OFF
GO
ALTER DATABASE [dbITSupport] SET ANSI_PADDING OFF
GO
ALTER DATABASE [dbITSupport] SET ANSI_WARNINGS OFF
GO
ALTER DATABASE [dbITSupport] SET ARITHABORT OFF
GO
ALTER DATABASE [dbITSupport] SET AUTO_CLOSE OFF
GO
ALTER DATABASE [dbITSupport] SET AUTO_CREATE_STATISTICS ON
GO
ALTER DATABASE [dbITSupport] SET AUTO_SHRINK OFF
GO
ALTER DATABASE [dbITSupport] SET AUTO_UPDATE_STATISTICS ON
GO
ALTER DATABASE [dbITSupport] SET CURSOR_CLOSE_ON_COMMIT OFF
GO
ALTER DATABASE [dbITSupport] SET CURSOR_DEFAULT  GLOBAL
GO
ALTER DATABASE [dbITSupport] SET CONCAT_NULL_YIELDS_NULL OFF
GO
ALTER DATABASE [dbITSupport] SET NUMERIC_ROUNDABORT OFF
GO
ALTER DATABASE [dbITSupport] SET QUOTED_IDENTIFIER OFF
GO
ALTER DATABASE [dbITSupport] SET RECURSIVE_TRIGGERS OFF
GO
ALTER DATABASE [dbITSupport] SET  DISABLE_BROKER
GO
ALTER DATABASE [dbITSupport] SET AUTO_UPDATE_STATISTICS_ASYNC OFF
GO
ALTER DATABASE [dbITSupport] SET DATE_CORRELATION_OPTIMIZATION OFF
GO
ALTER DATABASE [dbITSupport] SET TRUSTWORTHY OFF
GO
ALTER DATABASE [dbITSupport] SET ALLOW_SNAPSHOT_ISOLATION OFF
GO
ALTER DATABASE [dbITSupport] SET PARAMETERIZATION SIMPLE
GO
ALTER DATABASE [dbITSupport] SET READ_COMMITTED_SNAPSHOT OFF
GO
ALTER DATABASE [dbITSupport] SET HONOR_BROKER_PRIORITY OFF
GO
ALTER DATABASE [dbITSupport] SET  READ_WRITE
GO
ALTER DATABASE [dbITSupport] SET RECOVERY SIMPLE
GO
ALTER DATABASE [dbITSupport] SET  MULTI_USER
GO
ALTER DATABASE [dbITSupport] SET PAGE_VERIFY CHECKSUM
GO
ALTER DATABASE [dbITSupport] SET DB_CHAINING OFF
GO
USE [dbITSupport]
GO
/****** Object:  Table [dbo].[tblUsuario]    Script Date: 05/31/2016 00:42:45 ******/
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
/****** Object:  Table [dbo].[tblSharedMailBox]    Script Date: 05/31/2016 00:42:45 ******/
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
/****** Object:  Table [dbo].[tblModelo]    Script Date: 05/31/2016 00:42:45 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[tblModelo](
	[ModeloID] [int] IDENTITY(1,1) NOT NULL,
	[FabricanteID] [int] NOT NULL,
	[ModeloNome] [varchar](50) NOT NULL
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
SET IDENTITY_INSERT [dbo].[tblModelo] ON
INSERT [dbo].[tblModelo] ([ModeloID], [FabricanteID], [ModeloNome]) VALUES (1, 1, N'Latitude D620')
INSERT [dbo].[tblModelo] ([ModeloID], [FabricanteID], [ModeloNome]) VALUES (2, 1, N'Latitude D630')
INSERT [dbo].[tblModelo] ([ModeloID], [FabricanteID], [ModeloNome]) VALUES (3, 1, N'Latitude E4200')
INSERT [dbo].[tblModelo] ([ModeloID], [FabricanteID], [ModeloNome]) VALUES (4, 1, N'Latitude E4300 ')
INSERT [dbo].[tblModelo] ([ModeloID], [FabricanteID], [ModeloNome]) VALUES (5, 1, N'Latitude E4310')
INSERT [dbo].[tblModelo] ([ModeloID], [FabricanteID], [ModeloNome]) VALUES (6, 1, N'Latitude E5410')
INSERT [dbo].[tblModelo] ([ModeloID], [FabricanteID], [ModeloNome]) VALUES (7, 1, N'Latitude E5420')
INSERT [dbo].[tblModelo] ([ModeloID], [FabricanteID], [ModeloNome]) VALUES (8, 1, N'Latitude E5470')
INSERT [dbo].[tblModelo] ([ModeloID], [FabricanteID], [ModeloNome]) VALUES (9, 1, N'Latitude E6220')
INSERT [dbo].[tblModelo] ([ModeloID], [FabricanteID], [ModeloNome]) VALUES (10, 1, N'Latitude E6230')
INSERT [dbo].[tblModelo] ([ModeloID], [FabricanteID], [ModeloNome]) VALUES (11, 1, N'Latitude E6320')
INSERT [dbo].[tblModelo] ([ModeloID], [FabricanteID], [ModeloNome]) VALUES (12, 1, N'Latitude E6330')
INSERT [dbo].[tblModelo] ([ModeloID], [FabricanteID], [ModeloNome]) VALUES (13, 1, N'Latitude E6440')
INSERT [dbo].[tblModelo] ([ModeloID], [FabricanteID], [ModeloNome]) VALUES (14, 1, N'Latitude E7240')
INSERT [dbo].[tblModelo] ([ModeloID], [FabricanteID], [ModeloNome]) VALUES (15, 1, N'Latitude E7250')
INSERT [dbo].[tblModelo] ([ModeloID], [FabricanteID], [ModeloNome]) VALUES (16, 1, N'Latitude E7440')
INSERT [dbo].[tblModelo] ([ModeloID], [FabricanteID], [ModeloNome]) VALUES (17, 1, N'Latitude E7450')
INSERT [dbo].[tblModelo] ([ModeloID], [FabricanteID], [ModeloNome]) VALUES (18, 1, N'OptiPlex 3020')
INSERT [dbo].[tblModelo] ([ModeloID], [FabricanteID], [ModeloNome]) VALUES (19, 1, N'OptiPlex 3020M')
INSERT [dbo].[tblModelo] ([ModeloID], [FabricanteID], [ModeloNome]) VALUES (20, 1, N'OptiPlex 7010')
INSERT [dbo].[tblModelo] ([ModeloID], [FabricanteID], [ModeloNome]) VALUES (21, 1, N'OptiPlex 7020')
INSERT [dbo].[tblModelo] ([ModeloID], [FabricanteID], [ModeloNome]) VALUES (22, 1, N'OptiPlex 745')
INSERT [dbo].[tblModelo] ([ModeloID], [FabricanteID], [ModeloNome]) VALUES (23, 1, N'OptiPlex 755')
INSERT [dbo].[tblModelo] ([ModeloID], [FabricanteID], [ModeloNome]) VALUES (24, 1, N'OptiPlex 760')
INSERT [dbo].[tblModelo] ([ModeloID], [FabricanteID], [ModeloNome]) VALUES (25, 1, N'OptiPlex 780')
INSERT [dbo].[tblModelo] ([ModeloID], [FabricanteID], [ModeloNome]) VALUES (26, 1, N'OptiPlex 790')
INSERT [dbo].[tblModelo] ([ModeloID], [FabricanteID], [ModeloNome]) VALUES (27, 1, N'OptiPlex 9020')
INSERT [dbo].[tblModelo] ([ModeloID], [FabricanteID], [ModeloNome]) VALUES (28, 1, N'OptiPlex 9020M')
INSERT [dbo].[tblModelo] ([ModeloID], [FabricanteID], [ModeloNome]) VALUES (29, 3, N'HP EliteBook 6930p')
INSERT [dbo].[tblModelo] ([ModeloID], [FabricanteID], [ModeloNome]) VALUES (30, 3, N'HP EliteBook 8440p')
INSERT [dbo].[tblModelo] ([ModeloID], [FabricanteID], [ModeloNome]) VALUES (31, 2, N'6234A1P')
INSERT [dbo].[tblModelo] ([ModeloID], [FabricanteID], [ModeloNome]) VALUES (32, 2, N'6234BQ7')
INSERT [dbo].[tblModelo] ([ModeloID], [FabricanteID], [ModeloNome]) VALUES (33, 2, N'6234CY8')
INSERT [dbo].[tblModelo] ([ModeloID], [FabricanteID], [ModeloNome]) VALUES (34, 2, N'6234CZ1')
INSERT [dbo].[tblModelo] ([ModeloID], [FabricanteID], [ModeloNome]) VALUES (35, 2, N'6234DF7')
INSERT [dbo].[tblModelo] ([ModeloID], [FabricanteID], [ModeloNome]) VALUES (36, 2, N'6234E27')
INSERT [dbo].[tblModelo] ([ModeloID], [FabricanteID], [ModeloNome]) VALUES (37, 2, N'6234EG1')
SET IDENTITY_INSERT [dbo].[tblModelo] OFF
/****** Object:  Table [dbo].[tblFornecedor]    Script Date: 05/31/2016 00:42:45 ******/
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
/****** Object:  Table [dbo].[tblFabricante]    Script Date: 05/31/2016 00:42:45 ******/
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
SET IDENTITY_INSERT [dbo].[tblFabricante] OFF
/****** Object:  Table [dbo].[tblComputador]    Script Date: 05/31/2016 00:42:45 ******/
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
/****** Object:  Table [dbo].[tblAdmissao]    Script Date: 05/31/2016 00:42:45 ******/
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
