USE [dbITSupport]
GO
/****** Object:  Table [dbo].[tblEscritorio]    Script Date: 06/02/2016 06:14:34 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[tblEscritorio](
	[EscritorioID] [int] IDENTITY(1,1) NOT NULL,
	[Nome] [varchar](50) NOT NULL,
	[Endereco] [varchar](100) NOT NULL,
	[Bairro] [varchar](50) NOT NULL,
	[Cidade] [varchar](50) NOT NULL,
	[Estado] [varchar](50) NOT NULL,
	[CEP] [varchar](50) NOT NULL,
	[Telefone] [varchar](50) NOT NULL
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
SET IDENTITY_INSERT [dbo].[tblEscritorio] ON
INSERT [dbo].[tblEscritorio] ([EscritorioID], [Nome], [Endereco], [Bairro], [Cidade], [Estado], [CEP], [Telefone]) VALUES (1, N'Aon São Paulo', N'Rua Dr. Eduardo de Souza Aranha, 153 – 1º ao 10º andar', N'Itaim Bibi', N'São Paulo', N'São Paulo', N'04543-120', N'55 11 4700 4700')
INSERT [dbo].[tblEscritorio] ([EscritorioID], [Nome], [Endereco], [Bairro], [Cidade], [Estado], [CEP], [Telefone]) VALUES (4, N'Aon Campinas', N'Av. Dr. José Bonifácio Coutinho Nogueira, 150 - 3º andar', N'Torre Leste - Condomínio Galleria Plaza', N'Campinas', N'São Paulo', N'13091-611', N'55 19 3731 3250')
INSERT [dbo].[tblEscritorio] ([EscritorioID], [Nome], [Endereco], [Bairro], [Cidade], [Estado], [CEP], [Telefone]) VALUES (5, N'Aon Ribeirão Preto', N'Rua Garibaldi, 1760', N'Jardim Sumaré', N'Ribeirão Preto', N'São Paulo', N'14024-190', N'55 16 3913 0030')
INSERT [dbo].[tblEscritorio] ([EscritorioID], [Nome], [Endereco], [Bairro], [Cidade], [Estado], [CEP], [Telefone]) VALUES (6, N'Aon Rio de Janeiro', N'Rua Teófilo Otoni, 15 – 5º e 6º andares', N'Centro', N'Rio de Janeiro', N'Rio de Janeiro', N'20090-080', N'55 21 2169 7300')
INSERT [dbo].[tblEscritorio] ([EscritorioID], [Nome], [Endereco], [Bairro], [Cidade], [Estado], [CEP], [Telefone]) VALUES (7, N'Aon Curitiba', N'Rua Marechal Deodoro, 950 – 1º andar', N'Centro', N'Curitiba', N'Paraná', N'80060-010', N'55 41 3259 6100')
INSERT [dbo].[tblEscritorio] ([EscritorioID], [Nome], [Endereco], [Bairro], [Cidade], [Estado], [CEP], [Telefone]) VALUES (8, N'Aon Porto Alegre', N'Rua Félix da Cunha, 1009 – 3º andar', N'Moinho dos Ventos', N'Porto Alegre', N'Rio Grande do Sul', N'90570-001', N'55 51 3323 1200')
INSERT [dbo].[tblEscritorio] ([EscritorioID], [Nome], [Endereco], [Bairro], [Cidade], [Estado], [CEP], [Telefone]) VALUES (9, N'Aon Vitória', N'Rua José Alexandre Buaiz, 300 – Salas 712 a 718 - Edifício Work Center', N'Enseada do Suá', N'Vitória', N'Espírito Santo', N'29050-545', N'55 27 2125 0400')
INSERT [dbo].[tblEscritorio] ([EscritorioID], [Nome], [Endereco], [Bairro], [Cidade], [Estado], [CEP], [Telefone]) VALUES (10, N'Aon Salvador', N'Rua Cel. Almerindo Rehem, 82 – 9º andar – Salas 901 à 910', N'Caminho das Árvores', N'Salvador', N'Bahia', N'41820-768', N'55 71 3483 2600')
INSERT [dbo].[tblEscritorio] ([EscritorioID], [Nome], [Endereco], [Bairro], [Cidade], [Estado], [CEP], [Telefone]) VALUES (11, N'Aon Recife', N'Rua Padre Carapuceiro, 858 - Sala 601 ', N'Boa Viagem', N'Recife', N'Pernambuco', N'51020-280', N'55 81 3059-4194')
SET IDENTITY_INSERT [dbo].[tblEscritorio] OFF
