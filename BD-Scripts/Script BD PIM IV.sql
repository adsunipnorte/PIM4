USE [master]
--GO
--/****** Object:  Database [efleet]    Script Date: 11/25/2019 21:33:16 ******/
--CREATE DATABASE [efleet] ON  PRIMARY 
--( NAME = N'efleet', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL10.MSSQLSERVER\MSSQL\DATA\efleet.mdf' , SIZE = 2304KB , MAXSIZE = UNLIMITED, FILEGROWTH = 1024KB )
-- LOG ON 
--( NAME = N'efleet_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL10.MSSQLSERVER\MSSQL\DATA\efleet_log.LDF' , SIZE = 2624KB , MAXSIZE = 2048GB , FILEGROWTH = 10%)
--GO
--ALTER DATABASE [efleet] SET COMPATIBILITY_LEVEL = 100
--GO
--IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
--begin
--EXEC [efleet].[dbo].[sp_fulltext_database] @action = 'enable'
--end
--GO
--ALTER DATABASE [efleet] SET ANSI_NULL_DEFAULT OFF
--GO
--ALTER DATABASE [efleet] SET ANSI_NULLS OFF
--GO
--ALTER DATABASE [efleet] SET ANSI_PADDING OFF
--GO
--ALTER DATABASE [efleet] SET ANSI_WARNINGS OFF
--GO
--ALTER DATABASE [efleet] SET ARITHABORT OFF
--GO
--ALTER DATABASE [efleet] SET AUTO_CLOSE OFF
--GO
--ALTER DATABASE [efleet] SET AUTO_CREATE_STATISTICS ON
--GO
--ALTER DATABASE [efleet] SET AUTO_SHRINK OFF
--GO
--ALTER DATABASE [efleet] SET AUTO_UPDATE_STATISTICS ON
--GO
--ALTER DATABASE [efleet] SET CURSOR_CLOSE_ON_COMMIT OFF
--GO
--ALTER DATABASE [efleet] SET CURSOR_DEFAULT  GLOBAL
--GO
--ALTER DATABASE [efleet] SET CONCAT_NULL_YIELDS_NULL OFF
--GO
--ALTER DATABASE [efleet] SET NUMERIC_ROUNDABORT OFF
--GO
--ALTER DATABASE [efleet] SET QUOTED_IDENTIFIER OFF
--GO
--ALTER DATABASE [efleet] SET RECURSIVE_TRIGGERS OFF
--GO
--ALTER DATABASE [efleet] SET  ENABLE_BROKER
--GO
--ALTER DATABASE [efleet] SET AUTO_UPDATE_STATISTICS_ASYNC OFF
--GO
--ALTER DATABASE [efleet] SET DATE_CORRELATION_OPTIMIZATION OFF
--GO
--ALTER DATABASE [efleet] SET TRUSTWORTHY OFF
--GO
--ALTER DATABASE [efleet] SET ALLOW_SNAPSHOT_ISOLATION OFF
--GO
--ALTER DATABASE [efleet] SET PARAMETERIZATION SIMPLE
--GO
--ALTER DATABASE [efleet] SET READ_COMMITTED_SNAPSHOT OFF
--GO
--ALTER DATABASE [efleet] SET HONOR_BROKER_PRIORITY OFF
--GO
--ALTER DATABASE [efleet] SET  READ_WRITE
--GO
--ALTER DATABASE [efleet] SET RECOVERY FULL
--GO
--ALTER DATABASE [efleet] SET  MULTI_USER
--GO
--ALTER DATABASE [efleet] SET PAGE_VERIFY CHECKSUM
--GO
--ALTER DATABASE [efleet] SET DB_CHAINING OFF
--GO
--EXEC sys.sp_db_vardecimal_storage_format N'efleet', N'ON'
--GO

CREATE DATABASE [efleet]

USE [efleet]
GO
/****** Object:  Table [dbo].[tb_tipoveiculo]    Script Date: 11/25/2019 21:33:18 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[tb_tipoveiculo](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Descricao] [varchar](20) NOT NULL,
	[Situacao] [char](1) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
SET IDENTITY_INSERT [dbo].[tb_tipoveiculo] ON
INSERT [dbo].[tb_tipoveiculo] ([Id], [Descricao], [Situacao]) VALUES (1, N'INTERNO', N'1')
INSERT [dbo].[tb_tipoveiculo] ([Id], [Descricao], [Situacao]) VALUES (2, N'EXTERNO', N'1')
INSERT [dbo].[tb_tipoveiculo] ([Id], [Descricao], [Situacao]) VALUES (3, N'AVULSO', N'2')
SET IDENTITY_INSERT [dbo].[tb_tipoveiculo] OFF
/****** Object:  Table [dbo].[tb_tipomanutencao]    Script Date: 11/25/2019 21:33:18 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[tb_tipomanutencao](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Descricao] [varchar](45) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
SET IDENTITY_INSERT [dbo].[tb_tipomanutencao] ON
INSERT [dbo].[tb_tipomanutencao] ([Id], [Descricao]) VALUES (1, N'Preventiva')
INSERT [dbo].[tb_tipomanutencao] ([Id], [Descricao]) VALUES (2, N'CORRETIVA')
SET IDENTITY_INSERT [dbo].[tb_tipomanutencao] OFF
/****** Object:  Table [dbo].[tb_tipocliente]    Script Date: 11/25/2019 21:33:18 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[tb_tipocliente](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Descricao] [varchar](50) NOT NULL,
	[Situacao] [int] NULL,
PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
SET IDENTITY_INSERT [dbo].[tb_tipocliente] ON
INSERT [dbo].[tb_tipocliente] ([Id], [Descricao], [Situacao]) VALUES (11, N'INTERNO', 1)
INSERT [dbo].[tb_tipocliente] ([Id], [Descricao], [Situacao]) VALUES (12, N'EXTERNO', 2)
INSERT [dbo].[tb_tipocliente] ([Id], [Descricao], [Situacao]) VALUES (13, N'PESSOA FISICA', 1)
SET IDENTITY_INSERT [dbo].[tb_tipocliente] OFF
/****** Object:  Table [dbo].[tb_situacao]    Script Date: 11/25/2019 21:33:18 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[tb_situacao](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[descricao] [varchar](20) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
SET IDENTITY_INSERT [dbo].[tb_situacao] ON
INSERT [dbo].[tb_situacao] ([id], [descricao]) VALUES (1, N'ATIVO')
INSERT [dbo].[tb_situacao] ([id], [descricao]) VALUES (2, N'INATIVO')
SET IDENTITY_INSERT [dbo].[tb_situacao] OFF
/****** Object:  Table [dbo].[tb_seguros]    Script Date: 11/25/2019 21:33:18 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[tb_seguros](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Descricao] [varchar](45) NOT NULL,
	[Observacao] [varchar](100) NULL,
PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
SET IDENTITY_INSERT [dbo].[tb_seguros] ON
INSERT [dbo].[tb_seguros] ([Id], [Descricao], [Observacao]) VALUES (1, N'TERCEIROS', NULL)
INSERT [dbo].[tb_seguros] ([Id], [Descricao], [Observacao]) VALUES (2, N'PARCIAL', NULL)
INSERT [dbo].[tb_seguros] ([Id], [Descricao], [Observacao]) VALUES (3, N'FURTO/ROUBO', NULL)
INSERT [dbo].[tb_seguros] ([Id], [Descricao], [Observacao]) VALUES (4, N'COBERTURA BASICA', N'')
INSERT [dbo].[tb_seguros] ([Id], [Descricao], [Observacao]) VALUES (5, N'SEGURO COMPREENSIVO', N'OBS')
INSERT [dbo].[tb_seguros] ([Id], [Descricao], [Observacao]) VALUES (6, N'ACIDENTE DE PASSAGEIROS', N'')
INSERT [dbo].[tb_seguros] ([Id], [Descricao], [Observacao]) VALUES (7, N'COBERTURA ADICIONAL', N'')
SET IDENTITY_INSERT [dbo].[tb_seguros] OFF
/****** Object:  Table [dbo].[tb_estoque]    Script Date: 11/25/2019 21:33:18 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[tb_estoque](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Descricao] [varchar](45) NOT NULL,
	[EstoqueMin] [int] NULL,
	[EstoqueMax] [int] NULL,
	[Quantidade] [int] NOT NULL,
	[Custo] [decimal](10, 4) NOT NULL,
	[CustoAnt] [int] NULL,
PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
SET IDENTITY_INSERT [dbo].[tb_estoque] ON
INSERT [dbo].[tb_estoque] ([Id], [Descricao], [EstoqueMin], [EstoqueMax], [Quantidade], [Custo], [CustoAnt]) VALUES (1, N'FILTRO DE AR', 1, 3, 2, CAST(15.0000 AS Decimal(10, 4)), 14)
INSERT [dbo].[tb_estoque] ([Id], [Descricao], [EstoqueMin], [EstoqueMax], [Quantidade], [Custo], [CustoAnt]) VALUES (2, N'OLEO 20w50', 3, 10, 0, CAST(9.9900 AS Decimal(10, 4)), 9)
SET IDENTITY_INSERT [dbo].[tb_estoque] OFF
/****** Object:  Table [dbo].[tb_estados]    Script Date: 11/25/2019 21:33:18 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[tb_estados](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[Estado] [varchar](30) NOT NULL,
	[Sigla] [char](2) NOT NULL
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
SET IDENTITY_INSERT [dbo].[tb_estados] ON
INSERT [dbo].[tb_estados] ([ID], [Estado], [Sigla]) VALUES (11, N'RONDÔNIA', N'RO')
INSERT [dbo].[tb_estados] ([ID], [Estado], [Sigla]) VALUES (12, N'ACRE', N'AC')
INSERT [dbo].[tb_estados] ([ID], [Estado], [Sigla]) VALUES (13, N'AMAZONAS', N'AM')
INSERT [dbo].[tb_estados] ([ID], [Estado], [Sigla]) VALUES (14, N'RORAIMA', N'RR')
INSERT [dbo].[tb_estados] ([ID], [Estado], [Sigla]) VALUES (15, N'PARÁ', N'PA')
INSERT [dbo].[tb_estados] ([ID], [Estado], [Sigla]) VALUES (16, N'AMAPÁ', N'AP')
INSERT [dbo].[tb_estados] ([ID], [Estado], [Sigla]) VALUES (17, N'TOCANTINS', N'TO')
INSERT [dbo].[tb_estados] ([ID], [Estado], [Sigla]) VALUES (21, N'MARANHÃO', N'MA')
INSERT [dbo].[tb_estados] ([ID], [Estado], [Sigla]) VALUES (22, N'PIAUÍ', N'PI')
INSERT [dbo].[tb_estados] ([ID], [Estado], [Sigla]) VALUES (23, N'CEARÁ', N'CE')
INSERT [dbo].[tb_estados] ([ID], [Estado], [Sigla]) VALUES (24, N'RIO GRANDE DO NORTE', N'RN')
INSERT [dbo].[tb_estados] ([ID], [Estado], [Sigla]) VALUES (25, N'PARAÍBA', N'PR')
INSERT [dbo].[tb_estados] ([ID], [Estado], [Sigla]) VALUES (26, N'PERNAMBUCO', N'PE')
INSERT [dbo].[tb_estados] ([ID], [Estado], [Sigla]) VALUES (27, N'ALAGOAS', N'AL')
INSERT [dbo].[tb_estados] ([ID], [Estado], [Sigla]) VALUES (28, N'SERGIPE', N'SE')
INSERT [dbo].[tb_estados] ([ID], [Estado], [Sigla]) VALUES (29, N'BAHIA', N'BA')
INSERT [dbo].[tb_estados] ([ID], [Estado], [Sigla]) VALUES (31, N'MINAS GERAIS', N'MG')
INSERT [dbo].[tb_estados] ([ID], [Estado], [Sigla]) VALUES (32, N'ESPÍRITO SANTO', N'ES')
INSERT [dbo].[tb_estados] ([ID], [Estado], [Sigla]) VALUES (33, N'RIO DE JANEIRO', N'RJ')
INSERT [dbo].[tb_estados] ([ID], [Estado], [Sigla]) VALUES (35, N'SÃO PAULO', N'SP')
INSERT [dbo].[tb_estados] ([ID], [Estado], [Sigla]) VALUES (41, N'PARANÁ', N'PR')
INSERT [dbo].[tb_estados] ([ID], [Estado], [Sigla]) VALUES (42, N'SANTA CATARINA', N'SC')
INSERT [dbo].[tb_estados] ([ID], [Estado], [Sigla]) VALUES (43, N'RIO GRANDE DO SUL', N'RS')
INSERT [dbo].[tb_estados] ([ID], [Estado], [Sigla]) VALUES (50, N'MATO GROSSO DO SUL', N'MS')
INSERT [dbo].[tb_estados] ([ID], [Estado], [Sigla]) VALUES (51, N'MATO GROSSO', N'MT')
INSERT [dbo].[tb_estados] ([ID], [Estado], [Sigla]) VALUES (52, N'GOIÁS', N'GO')
INSERT [dbo].[tb_estados] ([ID], [Estado], [Sigla]) VALUES (53, N'DISTRITO FEDERAL', N'DF')
SET IDENTITY_INSERT [dbo].[tb_estados] OFF
/****** Object:  Table [dbo].[tb_planocontas]    Script Date: 11/25/2019 21:33:18 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[tb_planocontas](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Descricao] [varchar](50) NOT NULL,
	[Situacao] [char](1) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
SET IDENTITY_INSERT [dbo].[tb_planocontas] ON
INSERT [dbo].[tb_planocontas] ([Id], [Descricao], [Situacao]) VALUES (1, N'CONTAS A RECEBER', N'1')
INSERT [dbo].[tb_planocontas] ([Id], [Descricao], [Situacao]) VALUES (2, N'CONTAS A PAGAR', N'2')
INSERT [dbo].[tb_planocontas] ([Id], [Descricao], [Situacao]) VALUES (3, N'CUSTOS FIXOS', N'1')
INSERT [dbo].[tb_planocontas] ([Id], [Descricao], [Situacao]) VALUES (4, N'CUSTOS VARIAVEIS', N'2')
INSERT [dbo].[tb_planocontas] ([Id], [Descricao], [Situacao]) VALUES (5, N'DESPESAS FIXAS', N'1')
INSERT [dbo].[tb_planocontas] ([Id], [Descricao], [Situacao]) VALUES (6, N'DESPESAS VARIAVEIS', N'2')
SET IDENTITY_INSERT [dbo].[tb_planocontas] OFF
/****** Object:  Table [dbo].[tb_perfilusuarios]    Script Date: 11/25/2019 21:33:18 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[tb_perfilusuarios](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Descricao] [varchar](50) NOT NULL,
	[Situacao] [char](1) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
SET IDENTITY_INSERT [dbo].[tb_perfilusuarios] ON
INSERT [dbo].[tb_perfilusuarios] ([Id], [Descricao], [Situacao]) VALUES (3, N'ADMINISTRADOR', N'1')
INSERT [dbo].[tb_perfilusuarios] ([Id], [Descricao], [Situacao]) VALUES (4, N'USUARIO PADRAO', N'1')
SET IDENTITY_INSERT [dbo].[tb_perfilusuarios] OFF
/****** Object:  Table [dbo].[tb_montadoras]    Script Date: 11/25/2019 21:33:18 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[tb_montadoras](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Descricao] [varchar](45) NOT NULL,
	[Situacao] [char](1) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
SET IDENTITY_INSERT [dbo].[tb_montadoras] ON
INSERT [dbo].[tb_montadoras] ([Id], [Descricao], [Situacao]) VALUES (1, N'FORD', N'2')
INSERT [dbo].[tb_montadoras] ([Id], [Descricao], [Situacao]) VALUES (2, N'VOLKSWAGEM', N'1')
INSERT [dbo].[tb_montadoras] ([Id], [Descricao], [Situacao]) VALUES (4, N'TOYOTA', N'1')
INSERT [dbo].[tb_montadoras] ([Id], [Descricao], [Situacao]) VALUES (5, N'HONDA', N'1')
INSERT [dbo].[tb_montadoras] ([Id], [Descricao], [Situacao]) VALUES (6, N'NISSAN', N'1')
INSERT [dbo].[tb_montadoras] ([Id], [Descricao], [Situacao]) VALUES (7, N'BMW', N'1')
INSERT [dbo].[tb_montadoras] ([Id], [Descricao], [Situacao]) VALUES (8, N'HYUNDAI', N'1')
INSERT [dbo].[tb_montadoras] ([Id], [Descricao], [Situacao]) VALUES (9, N'FIAT', N'2')
INSERT [dbo].[tb_montadoras] ([Id], [Descricao], [Situacao]) VALUES (10, N'JEEP', N'1')
INSERT [dbo].[tb_montadoras] ([Id], [Descricao], [Situacao]) VALUES (11, N'JAC MOTORS', N'2')
INSERT [dbo].[tb_montadoras] ([Id], [Descricao], [Situacao]) VALUES (12, N'KIA', N'2')
INSERT [dbo].[tb_montadoras] ([Id], [Descricao], [Situacao]) VALUES (13, N'PEUGEOT', N'1')
INSERT [dbo].[tb_montadoras] ([Id], [Descricao], [Situacao]) VALUES (14, N'CHEVROLET', N'1')
INSERT [dbo].[tb_montadoras] ([Id], [Descricao], [Situacao]) VALUES (15, N'LAND ROVER', N'1')
INSERT [dbo].[tb_montadoras] ([Id], [Descricao], [Situacao]) VALUES (16, N'SUBARU', N'1')
SET IDENTITY_INSERT [dbo].[tb_montadoras] OFF
/****** Object:  Table [dbo].[tb_cidades]    Script Date: 11/25/2019 21:33:18 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[tb_cidades](
	[CodCidade] [int] NOT NULL,
	[Nome] [varchar](100) NOT NULL,
	[IdEstados] [int] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[CodCidade] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
INSERT [dbo].[tb_cidades] ([CodCidade], [Nome], [IdEstados]) VALUES (2800308, N'ARACAJU', 28)
INSERT [dbo].[tb_cidades] ([CodCidade], [Nome], [IdEstados]) VALUES (3170909, N'VARZELANDIA', 31)
INSERT [dbo].[tb_cidades] ([CodCidade], [Nome], [IdEstados]) VALUES (3519055, N'HOLAMBRA', 35)
INSERT [dbo].[tb_cidades] ([CodCidade], [Nome], [IdEstados]) VALUES (3550308, N'SAO PAULO', 35)
/****** Object:  Table [dbo].[tb_centrocustos]    Script Date: 11/25/2019 21:33:18 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[tb_centrocustos](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Descricao] [varchar](50) NOT NULL,
	[Situacao] [char](1) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
SET IDENTITY_INSERT [dbo].[tb_centrocustos] ON
INSERT [dbo].[tb_centrocustos] ([Id], [Descricao], [Situacao]) VALUES (1, N'MARKETING', N'1')
INSERT [dbo].[tb_centrocustos] ([Id], [Descricao], [Situacao]) VALUES (2, N'VENDAS', N'1')
INSERT [dbo].[tb_centrocustos] ([Id], [Descricao], [Situacao]) VALUES (3, N'ADMINISTRATIVO', N'1')
INSERT [dbo].[tb_centrocustos] ([Id], [Descricao], [Situacao]) VALUES (4, N'SUPORTE', N'1')
INSERT [dbo].[tb_centrocustos] ([Id], [Descricao], [Situacao]) VALUES (5, N'CUSTOMER SUCESS', N'1')
INSERT [dbo].[tb_centrocustos] ([Id], [Descricao], [Situacao]) VALUES (8, N'COMPRA', N'1')
SET IDENTITY_INSERT [dbo].[tb_centrocustos] OFF
/****** Object:  Table [dbo].[tb_condutores]    Script Date: 11/25/2019 21:33:18 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[tb_condutores](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Nome] [varchar](50) NOT NULL,
	[RG] [varchar](20) NULL,
	[CPF] [varchar](11) NOT NULL,
	[DataNasc] [date] NULL,
	[Email] [varchar](30) NOT NULL,
	[Telefone] [varchar](15) NULL,
	[Celular] [varchar](15) NOT NULL,
	[Endereco] [varchar](50) NOT NULL,
	[Numero] [int] NOT NULL,
	[Complemento] [varchar](30) NULL,
	[Bairro] [varchar](30) NOT NULL,
	[CEP] [varchar](10) NULL,
	[Cidade] [varchar](45) NOT NULL,
	[CNH] [varchar](15) NOT NULL,
	[CategoriaCNH] [char](1) NOT NULL,
	[Validade] [date] NOT NULL,
	[Observacao] [varchar](100) NULL,
PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
SET IDENTITY_INSERT [dbo].[tb_condutores] ON
INSERT [dbo].[tb_condutores] ([Id], [Nome], [RG], [CPF], [DataNasc], [Email], [Telefone], [Celular], [Endereco], [Numero], [Complemento], [Bairro], [CEP], [Cidade], [CNH], [CategoriaCNH], [Validade], [Observacao]) VALUES (1, N'Bryan Guilherme Lorenzo das Neves', N'349502389', N'97584362877', CAST(0x3F0D0B00 AS Date), N'bryan@nine9.com.br', N'9827005917', N'986498786', N'Rua Bom Jesus', 866, N'CASA 1', N'Divinéia', N'65067872', N'São Luís', N'88838481837', N'B', CAST(0xE2400B00 AS Date), N'NENHUM')
INSERT [dbo].[tb_condutores] ([Id], [Nome], [RG], [CPF], [DataNasc], [Email], [Telefone], [Celular], [Endereco], [Numero], [Complemento], [Bairro], [CEP], [Cidade], [CNH], [CategoriaCNH], [Validade], [Observacao]) VALUES (14, N'Pedro Theo Filipe Ferreira', N'479075463', N'38084599488', NULL, N'pedrolho@adv.br', N'3906-6475', N'988455004', N'Rua Doutor Plínio Bacelar da Silva', 143, N'conjunto 141', N'Parque Novo Mundo', N'28083726', N'Campos dos Goytacazes', N'34878235924', N'd', CAST(0x87110B00 AS Date), NULL)
SET IDENTITY_INSERT [dbo].[tb_condutores] OFF
/****** Object:  Table [dbo].[tb_clientes]    Script Date: 11/25/2019 21:33:18 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[tb_clientes](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[RazaoSocial] [varchar](50) NOT NULL,
	[Fantasia] [varchar](50) NULL,
	[CNPJ] [varchar](14) NULL,
	[CPF] [varchar](11) NULL,
	[InscricaoEstadual] [varchar](20) NULL,
	[InscricaoMunicipal] [varchar](20) NULL,
	[Telefone] [varchar](15) NULL,
	[Celular] [varchar](15) NULL,
	[Endereco] [varchar](50) NOT NULL,
	[Numero] [int] NOT NULL,
	[Complemento] [varchar](45) NULL,
	[Bairro] [varchar](40) NOT NULL,
	[IdCodCidade] [int] NOT NULL,
	[CEP] [varchar](10) NOT NULL,
	[Email] [varchar](50) NULL,
	[Site] [varchar](50) NULL,
	[Observacao] [varchar](100) NULL,
	[IdTipoCliente] [int] NOT NULL,
	[Situacao] [char](1) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
SET IDENTITY_INSERT [dbo].[tb_clientes] ON
INSERT [dbo].[tb_clientes] ([Id], [RazaoSocial], [Fantasia], [CNPJ], [CPF], [InscricaoEstadual], [InscricaoMunicipal], [Telefone], [Celular], [Endereco], [Numero], [Complemento], [Bairro], [IdCodCidade], [CEP], [Email], [Site], [Observacao], [IdTipoCliente], [Situacao]) VALUES (21, N'Giovanna Rosa Alves', N'Giovanna Rosa Alves', N'8257814000118', N'67989704005', N'230411678396', N'230411678777', N'28025907', N'999401027', N'Rua Margarida Maria Alves', 700, NULL, N'Padre Gabriel', 3550308, N'29141857', N'giovanna@uol.com.br', N'www.giovanna.com.br', NULL, 11, N'1')
INSERT [dbo].[tb_clientes] ([Id], [RazaoSocial], [Fantasia], [CNPJ], [CPF], [InscricaoEstadual], [InscricaoMunicipal], [Telefone], [Celular], [Endereco], [Numero], [Complemento], [Bairro], [IdCodCidade], [CEP], [Email], [Site], [Observacao], [IdTipoCliente], [Situacao]) VALUES (22, N'Erick Matheus da Silva', N'Erick Matheus da Silva', N'1289925000167', N'32487083875', N'66689703', N'230418777', N'28025907', N'999401027', N'Travessa São Carlos', 732, NULL, N'Vila Mauro Fecury I', 3170909, N'65082661', N'erick@bol.com.br', N'www.erick.com.br', NULL, 11, N'1')
SET IDENTITY_INSERT [dbo].[tb_clientes] OFF
/****** Object:  Table [dbo].[tb_manutencao]    Script Date: 11/25/2019 21:33:18 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[tb_manutencao](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Descricao] [varchar](45) NOT NULL,
	[IdTipoManutencao] [int] NOT NULL,
	[IdVeiculo] [int] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
SET IDENTITY_INSERT [dbo].[tb_manutencao] ON
INSERT [dbo].[tb_manutencao] ([Id], [Descricao], [IdTipoManutencao], [IdVeiculo]) VALUES (8, N'TROCA DE OLEO', 1, 6)
INSERT [dbo].[tb_manutencao] ([Id], [Descricao], [IdTipoManutencao], [IdVeiculo]) VALUES (9, N'PASTILHA', 2, 9)
INSERT [dbo].[tb_manutencao] ([Id], [Descricao], [IdTipoManutencao], [IdVeiculo]) VALUES (10, N'PNEU', 2, 9)
INSERT [dbo].[tb_manutencao] ([Id], [Descricao], [IdTipoManutencao], [IdVeiculo]) VALUES (11, N'LAVAGEM', 1, 6)
SET IDENTITY_INSERT [dbo].[tb_manutencao] OFF
/****** Object:  Table [dbo].[tb_veiculos]    Script Date: 11/25/2019 21:33:18 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[tb_veiculos](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Placa] [varchar](7) NOT NULL,
	[Renavam] [varchar](45) NOT NULL,
	[Modelo] [varchar](50) NOT NULL,
	[AnoFabricacao] [int] NOT NULL,
	[AnoModelo] [int] NOT NULL,
	[Cor] [varchar](50) NOT NULL,
	[Porta] [int] NOT NULL,
	[Motor] [varchar](3) NOT NULL,
	[Cambio] [varchar](20) NOT NULL,
	[Combustivel] [varchar](25) NOT NULL,
	[Observacao] [varchar](100) NULL,
	[Lugares] [int] NOT NULL,
	[IdTipoVeiculo] [int] NOT NULL,
	[IdMontadoras] [int] NOT NULL,
	[IPVA] [decimal](10, 2) NULL,
	[Licenciamento] [decimal](10, 2) NULL,
	[VencimentoIPVA] [date] NULL,
	[VencimentoLicenc] [date] NULL,
	[DataAquisicao] [date] NULL,
	[OdometroCompra] [int] NULL,
	[Garantia] [date] NULL,
	[TipoPagCompra] [varchar](20) NULL,
	[ValorAquisicao] [decimal](18, 0) NULL,
	[DataVenda] [date] NULL,
	[ValorVenda] [decimal](10, 2) NULL,
	[OdometroVenda] [int] NULL,
	[TipoPagVenda] [varchar](20) NULL,
PRIMARY KEY CLUSTERED 
(
	[Id] ASC,
	[Placa] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
SET IDENTITY_INSERT [dbo].[tb_veiculos] ON
INSERT [dbo].[tb_veiculos] ([Id], [Placa], [Renavam], [Modelo], [AnoFabricacao], [AnoModelo], [Cor], [Porta], [Motor], [Cambio], [Combustivel], [Observacao], [Lugares], [IdTipoVeiculo], [IdMontadoras], [IPVA], [Licenciamento], [VencimentoIPVA], [VencimentoLicenc], [DataAquisicao], [OdometroCompra], [Garantia], [TipoPagCompra], [ValorAquisicao], [DataVenda], [ValorVenda], [OdometroVenda], [TipoPagVenda]) VALUES (9, N'ILB7973', N'37321141210', N'Land Rover', 1999, 1999, N'Verde', 4, N'2', N'MANUAL', N'FLEX', NULL, 5, 2, 15, CAST(2000.00 AS Decimal(10, 2)), CAST(189.00 AS Decimal(10, 2)), CAST(0xCB410B00 AS Date), NULL, CAST(0xF1390B00 AS Date), 20000, NULL, NULL, CAST(8500 AS Decimal(18, 0)), NULL, NULL, NULL, NULL)
INSERT [dbo].[tb_veiculos] ([Id], [Placa], [Renavam], [Modelo], [AnoFabricacao], [AnoModelo], [Cor], [Porta], [Motor], [Cambio], [Combustivel], [Observacao], [Lugares], [IdTipoVeiculo], [IdMontadoras], [IPVA], [Licenciamento], [VencimentoIPVA], [VencimentoLicenc], [DataAquisicao], [OdometroCompra], [Garantia], [TipoPagCompra], [ValorAquisicao], [DataVenda], [ValorVenda], [OdometroVenda], [TipoPagVenda]) VALUES (11, N'ARY8948', N'43552955756', N'Subaru', 2001, 2001, N'Prata', 2, N'1.3', N'MANUAL', N'GASOLINA', NULL, 5, 1, 16, CAST(0.00 AS Decimal(10, 2)), CAST(0.00 AS Decimal(10, 2)), CAST(0x07240B00 AS Date), CAST(0x07240B00 AS Date), NULL, 0, NULL, NULL, CAST(0 AS Decimal(18, 0)), NULL, NULL, NULL, NULL)
INSERT [dbo].[tb_veiculos] ([Id], [Placa], [Renavam], [Modelo], [AnoFabricacao], [AnoModelo], [Cor], [Porta], [Motor], [Cambio], [Combustivel], [Observacao], [Lugares], [IdTipoVeiculo], [IdMontadoras], [IPVA], [Licenciamento], [VencimentoIPVA], [VencimentoLicenc], [DataAquisicao], [OdometroCompra], [Garantia], [TipoPagCompra], [ValorAquisicao], [DataVenda], [ValorVenda], [OdometroVenda], [TipoPagVenda]) VALUES (12, N'HPR3714', N'15176976670', N'Polo Next', 2003, 2003, N'Dourado', 4, N'1.0', N'MANUAL', N'GASOLINA', NULL, 5, 2, 2, CAST(0.00 AS Decimal(10, 2)), CAST(0.00 AS Decimal(10, 2)), CAST(0x07240B00 AS Date), CAST(0x07240B00 AS Date), NULL, 0, NULL, NULL, CAST(0 AS Decimal(18, 0)), NULL, NULL, NULL, NULL)
INSERT [dbo].[tb_veiculos] ([Id], [Placa], [Renavam], [Modelo], [AnoFabricacao], [AnoModelo], [Cor], [Porta], [Motor], [Cambio], [Combustivel], [Observacao], [Lugares], [IdTipoVeiculo], [IdMontadoras], [IPVA], [Licenciamento], [VencimentoIPVA], [VencimentoLicenc], [DataAquisicao], [OdometroCompra], [Garantia], [TipoPagCompra], [ValorAquisicao], [DataVenda], [ValorVenda], [OdometroVenda], [TipoPagVenda]) VALUES (13, N'HRO5367', N'21663926486', N'Vectra Elite', 2005, 2006, N'Marrom', 4, N'2.2', N'AUTOMÁTICO', N'GASOLINA', NULL, 5, 3, 14, CAST(0.00 AS Decimal(10, 2)), CAST(0.00 AS Decimal(10, 2)), CAST(0x07240B00 AS Date), CAST(0x07240B00 AS Date), NULL, 0, NULL, NULL, CAST(0 AS Decimal(18, 0)), NULL, NULL, NULL, NULL)
SET IDENTITY_INSERT [dbo].[tb_veiculos] OFF
/****** Object:  Table [dbo].[tb_usuarios]    Script Date: 11/25/2019 21:33:18 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[tb_usuarios](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Login] [varchar](30) NOT NULL,
	[Nome] [varchar](50) NULL,
	[Senha] [varchar](50) NOT NULL,
	[Situacao] [char](1) NOT NULL,
	[Email] [varchar](50) NULL,
	[IdPerfilUsuarios] [int] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
SET IDENTITY_INSERT [dbo].[tb_usuarios] ON
INSERT [dbo].[tb_usuarios] ([Id], [Login], [Nome], [Senha], [Situacao], [Email], [IdPerfilUsuarios]) VALUES (4, N'Lucas', N'LUCAS', N'123', N'1', N'LUCAS@UNIP.BR', 3)
INSERT [dbo].[tb_usuarios] ([Id], [Login], [Nome], [Senha], [Situacao], [Email], [IdPerfilUsuarios]) VALUES (5, N'sa', N'SA', N'sa', N'2', N'sa@sa.com', 3)
INSERT [dbo].[tb_usuarios] ([Id], [Login], [Nome], [Senha], [Situacao], [Email], [IdPerfilUsuarios]) VALUES (9, N'Cassiano', N'CASSIANO', N'123', N'1', N'CASSIANO@UNIP.BR', 3)
INSERT [dbo].[tb_usuarios] ([Id], [Login], [Nome], [Senha], [Situacao], [Email], [IdPerfilUsuarios]) VALUES (10, N'Rafael', N'RAFAEL', N'123', N'2', N'RAFAEL@UNIP.BR', 3)
INSERT [dbo].[tb_usuarios] ([Id], [Login], [Nome], [Senha], [Situacao], [Email], [IdPerfilUsuarios]) VALUES (11, N'Angel', N'ANGEL', N'123', N'1', N'ANGEL@UNIP.BR', 3)
INSERT [dbo].[tb_usuarios] ([Id], [Login], [Nome], [Senha], [Situacao], [Email], [IdPerfilUsuarios]) VALUES (13, N'Artur', N'ARTUR', N'123', N'1', N'ARTUR@UNIP.BR', 3)
INSERT [dbo].[tb_usuarios] ([Id], [Login], [Nome], [Senha], [Situacao], [Email], [IdPerfilUsuarios]) VALUES (14, N'Vanessa', N'VANESSA', N'123', N'1', N'VANESSA@UNIP.BR', 3)
INSERT [dbo].[tb_usuarios] ([Id], [Login], [Nome], [Senha], [Situacao], [Email], [IdPerfilUsuarios]) VALUES (15, N'Vladimir', N'VLADIMIR', N'123', N'2', N'VLADIMIR@UNIP.BR', 3)
INSERT [dbo].[tb_usuarios] ([Id], [Login], [Nome], [Senha], [Situacao], [Email], [IdPerfilUsuarios]) VALUES (16, N'Salatiel', N'SALATIEL', N'123', N'2', N'SALATIEL@UNIP.BR', 3)
INSERT [dbo].[tb_usuarios] ([Id], [Login], [Nome], [Senha], [Situacao], [Email], [IdPerfilUsuarios]) VALUES (17, N'Luis', N'LUIS', N'123', N'1', N'LUIS@UNIP.BR', 3)
INSERT [dbo].[tb_usuarios] ([Id], [Login], [Nome], [Senha], [Situacao], [Email], [IdPerfilUsuarios]) VALUES (18, N'Cristiane', N'CRISTIANE', N'123', N'1', N'CRISTIANE@UNIP.BR', 3)
INSERT [dbo].[tb_usuarios] ([Id], [Login], [Nome], [Senha], [Situacao], [Email], [IdPerfilUsuarios]) VALUES (19, N'Marco', N'MARCO ANTONIO', N'123', N'1', N'MARCO@UNIP.BR', 3)
SET IDENTITY_INSERT [dbo].[tb_usuarios] OFF
/****** Object:  Table [dbo].[tb_contatos]    Script Date: 11/25/2019 21:33:18 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[tb_contatos](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Nome] [varchar](50) NOT NULL,
	[Endereco] [varchar](50) NULL,
	[Numero] [int] NULL,
	[Complemento] [varchar](30) NULL,
	[Bairro] [varchar](30) NULL,
	[CEP] [varchar](10) NULL,
	[Telefone] [varchar](15) NULL,
	[Celular] [varchar](15) NULL,
	[Email] [varchar](50) NULL,
	[IdClientes] [int] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
SET IDENTITY_INSERT [dbo].[tb_contatos] ON
INSERT [dbo].[tb_contatos] ([Id], [Nome], [Endereco], [Numero], [Complemento], [Bairro], [CEP], [Telefone], [Celular], [Email], [IdClientes]) VALUES (21, N'BENTO GUSTAVO EDUARDO ALVES', N'RUA GUAÍBA', 847, N'', N'JARDIM ALTOS DA GLÓRIA', N'', N'6737644730', N'67989673101', N'bentogustavoeduardoalves.com.br', 21)
SET IDENTITY_INSERT [dbo].[tb_contatos] OFF
/****** Object:  Table [dbo].[tb_pneus]    Script Date: 11/25/2019 21:33:18 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[tb_pneus](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Perfil] [varchar](15) NOT NULL,
	[DataCompra] [date] NOT NULL,
	[Valor] [decimal](10, 2) NOT NULL,
	[IdVeiculo] [int] NOT NULL,
	[PlacaVeiculo] [varchar](7) NOT NULL,
	[Km] [int] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[tb_multas]    Script Date: 11/25/2019 21:33:18 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[tb_multas](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Descricao] [varchar](45) NOT NULL,
	[IdVeiculo] [int] NOT NULL,
	[PlacaVeiculo] [varchar](7) NOT NULL,
	[IdCondutores] [int] NOT NULL,
	[Pontos] [int] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[tb_logs]    Script Date: 11/25/2019 21:33:18 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[tb_logs](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Descricao] [varchar](50) NOT NULL,
	[Data] [datetime] NOT NULL,
	[IdUsuario] [int] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[tb_locacoes]    Script Date: 11/25/2019 21:33:18 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[tb_locacoes](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[IdVeiculo] [int] NOT NULL,
	[PlacaVeiculo] [varchar](7) NOT NULL,
	[DataLocacao] [datetime] NOT NULL,
	[DataDevolucao] [datetime] NOT NULL,
	[ValorDiaria] [decimal](10, 2) NOT NULL,
	[QuantDias] [int] NOT NULL,
	[KMInicial] [varchar](6) NOT NULL,
	[KMFinal] [varchar](6) NULL,
	[IdCliente] [int] NOT NULL,
	[IdSeguro] [int] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[tb_financeiro]    Script Date: 11/25/2019 21:33:18 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[tb_financeiro](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Descricao] [varchar](50) NOT NULL,
	[ValorOrig] [decimal](10, 2) NOT NULL,
	[Vencimento] [date] NOT NULL,
	[Desconto] [decimal](10, 2) NULL,
	[Juros] [decimal](10, 2) NULL,
	[ValorPago] [decimal](10, 2) NOT NULL,
	[IdClientes] [int] NOT NULL,
	[IdCentroCusto] [int] NOT NULL,
	[IdPlanoContas] [int] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[Id] ASC,
	[IdPlanoContas] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Default [DF_tb_tipoveiculo_Situacao]    Script Date: 11/25/2019 21:33:18 ******/
ALTER TABLE [dbo].[tb_tipoveiculo] ADD  CONSTRAINT [DF_tb_tipoveiculo_Situacao]  DEFAULT ((1)) FOR [Situacao]
GO
/****** Object:  Default [DF_tb_tipocliente_Situacao]    Script Date: 11/25/2019 21:33:18 ******/
ALTER TABLE [dbo].[tb_tipocliente] ADD  CONSTRAINT [DF_tb_tipocliente_Situacao]  DEFAULT ((1)) FOR [Situacao]
GO
/****** Object:  Default [DF_tb_seguros_Observacao]    Script Date: 11/25/2019 21:33:18 ******/
ALTER TABLE [dbo].[tb_seguros] ADD  CONSTRAINT [DF_tb_seguros_Observacao]  DEFAULT (NULL) FOR [Observacao]
GO
/****** Object:  Default [DF__tb_estoqu__Estoq__1920BF5C]    Script Date: 11/25/2019 21:33:18 ******/
ALTER TABLE [dbo].[tb_estoque] ADD  DEFAULT ((0)) FOR [EstoqueMin]
GO
/****** Object:  Default [DF__tb_estoqu__Estoq__1A14E395]    Script Date: 11/25/2019 21:33:18 ******/
ALTER TABLE [dbo].[tb_estoque] ADD  DEFAULT ((0)) FOR [EstoqueMax]
GO
/****** Object:  Default [DF__tb_estoqu__Quant__1B0907CE]    Script Date: 11/25/2019 21:33:18 ******/
ALTER TABLE [dbo].[tb_estoque] ADD  DEFAULT ((0)) FOR [Quantidade]
GO
/****** Object:  Default [DF__tb_estoqu__Custo__17F790F9]    Script Date: 11/25/2019 21:33:18 ******/
ALTER TABLE [dbo].[tb_estoque] ADD  DEFAULT ((0.00)) FOR [CustoAnt]
GO
/****** Object:  Default [DF_tb_perfilusuarios_Situacao]    Script Date: 11/25/2019 21:33:18 ******/
ALTER TABLE [dbo].[tb_perfilusuarios] ADD  CONSTRAINT [DF_tb_perfilusuarios_Situacao]  DEFAULT ((1)) FOR [Situacao]
GO
/****** Object:  Default [DF_tb_montadoras_Situacao]    Script Date: 11/25/2019 21:33:18 ******/
ALTER TABLE [dbo].[tb_montadoras] ADD  CONSTRAINT [DF_tb_montadoras_Situacao]  DEFAULT ((1)) FOR [Situacao]
GO
/****** Object:  Default [DF_tb_centrocustos_Situacao]    Script Date: 11/25/2019 21:33:18 ******/
ALTER TABLE [dbo].[tb_centrocustos] ADD  CONSTRAINT [DF_tb_centrocustos_Situacao]  DEFAULT ((1)) FOR [Situacao]
GO
/****** Object:  Default [DF__tb_client__Situa__08EA5793]    Script Date: 11/25/2019 21:33:18 ******/
ALTER TABLE [dbo].[tb_clientes] ADD  DEFAULT ('1') FOR [Situacao]
GO
/****** Object:  Default [DF__tb_veicul__Porta__571DF1D5]    Script Date: 11/25/2019 21:33:18 ******/
ALTER TABLE [dbo].[tb_veiculos] ADD  DEFAULT ((2)) FOR [Porta]
GO
/****** Object:  Default [DF__tb_veicul__Motor__151B244E]    Script Date: 11/25/2019 21:33:18 ******/
ALTER TABLE [dbo].[tb_veiculos] ADD  DEFAULT ((1.0)) FOR [Motor]
GO
/****** Object:  Default [DF__tb_veicul__Lugar__59063A47]    Script Date: 11/25/2019 21:33:18 ******/
ALTER TABLE [dbo].[tb_veiculos] ADD  DEFAULT ((5)) FOR [Lugares]
GO
/****** Object:  Default [DF__tb_veiculo__IPVA__10566F31]    Script Date: 11/25/2019 21:33:18 ******/
ALTER TABLE [dbo].[tb_veiculos] ADD  DEFAULT ((0.00)) FOR [IPVA]
GO
/****** Object:  Default [DF__tb_veicul__Licen__0E6E26BF]    Script Date: 11/25/2019 21:33:18 ******/
ALTER TABLE [dbo].[tb_veiculos] ADD  DEFAULT ((0.00)) FOR [Licenciamento]
GO
/****** Object:  Default [DF__tb_veicul__Venci__114A936A]    Script Date: 11/25/2019 21:33:18 ******/
ALTER TABLE [dbo].[tb_veiculos] ADD  DEFAULT ('01-01-2000') FOR [VencimentoIPVA]
GO
/****** Object:  Default [DF__tb_veicul__Venci__123EB7A3]    Script Date: 11/25/2019 21:33:18 ******/
ALTER TABLE [dbo].[tb_veiculos] ADD  DEFAULT ('01-01-2000') FOR [VencimentoLicenc]
GO
/****** Object:  Default [DF__tb_veicul__Odome__1332DBDC]    Script Date: 11/25/2019 21:33:18 ******/
ALTER TABLE [dbo].[tb_veiculos] ADD  DEFAULT ((0)) FOR [OdometroCompra]
GO
/****** Object:  Default [DF__tb_veicul__Valor__14270015]    Script Date: 11/25/2019 21:33:18 ******/
ALTER TABLE [dbo].[tb_veiculos] ADD  DEFAULT ((0)) FOR [ValorAquisicao]
GO
/****** Object:  Default [DF__tb_usuari__Situa__52593CB8]    Script Date: 11/25/2019 21:33:18 ******/
ALTER TABLE [dbo].[tb_usuarios] ADD  DEFAULT ('1') FOR [Situacao]
GO
/****** Object:  Default [DF__tb_multas__Ponto__32E0915F]    Script Date: 11/25/2019 21:33:18 ******/
ALTER TABLE [dbo].[tb_multas] ADD  DEFAULT ((0)) FOR [Pontos]
GO
/****** Object:  Default [DF_tb_financeiro_Desconto]    Script Date: 11/25/2019 21:33:18 ******/
ALTER TABLE [dbo].[tb_financeiro] ADD  CONSTRAINT [DF_tb_financeiro_Desconto]  DEFAULT ((0.00)) FOR [Desconto]
GO
/****** Object:  ForeignKey [FK__tb_client__IdCod__5AEE82B9]    Script Date: 11/25/2019 21:33:18 ******/
ALTER TABLE [dbo].[tb_clientes]  WITH CHECK ADD FOREIGN KEY([IdCodCidade])
REFERENCES [dbo].[tb_cidades] ([CodCidade])
GO
/****** Object:  ForeignKey [FK__tb_client__IdTip__5BE2A6F2]    Script Date: 11/25/2019 21:33:18 ******/
ALTER TABLE [dbo].[tb_clientes]  WITH CHECK ADD FOREIGN KEY([IdTipoCliente])
REFERENCES [dbo].[tb_tipocliente] ([Id])
GO
/****** Object:  ForeignKey [FK__tb_manute__IdTip__6477ECF3]    Script Date: 11/25/2019 21:33:18 ******/
ALTER TABLE [dbo].[tb_manutencao]  WITH CHECK ADD FOREIGN KEY([IdTipoManutencao])
REFERENCES [dbo].[tb_tipomanutencao] ([Id])
GO
/****** Object:  ForeignKey [FK__tb_veicul__IdMon__6A30C649]    Script Date: 11/25/2019 21:33:18 ******/
ALTER TABLE [dbo].[tb_veiculos]  WITH CHECK ADD FOREIGN KEY([IdMontadoras])
REFERENCES [dbo].[tb_montadoras] ([Id])
GO
/****** Object:  ForeignKey [FK__tb_veicul__IdTip__6B24EA82]    Script Date: 11/25/2019 21:33:18 ******/
ALTER TABLE [dbo].[tb_veiculos]  WITH CHECK ADD FOREIGN KEY([IdTipoVeiculo])
REFERENCES [dbo].[tb_tipoveiculo] ([Id])
GO
/****** Object:  ForeignKey [FK__tb_usuari__IdPer__693CA210]    Script Date: 11/25/2019 21:33:18 ******/
ALTER TABLE [dbo].[tb_usuarios]  WITH CHECK ADD FOREIGN KEY([IdPerfilUsuarios])
REFERENCES [dbo].[tb_perfilusuarios] ([Id])
GO
/****** Object:  ForeignKey [FK__tb_contat__IdCli__5CD6CB2B]    Script Date: 11/25/2019 21:33:18 ******/
ALTER TABLE [dbo].[tb_contatos]  WITH NOCHECK ADD  CONSTRAINT [FK__tb_contat__IdCli__5CD6CB2B] FOREIGN KEY([IdClientes])
REFERENCES [dbo].[tb_clientes] ([Id])
NOT FOR REPLICATION
GO
ALTER TABLE [dbo].[tb_contatos] CHECK CONSTRAINT [FK__tb_contat__IdCli__5CD6CB2B]
GO
/****** Object:  ForeignKey [FK__tb_pneus__68487DD7]    Script Date: 11/25/2019 21:33:18 ******/
ALTER TABLE [dbo].[tb_pneus]  WITH CHECK ADD FOREIGN KEY([IdVeiculo], [PlacaVeiculo])
REFERENCES [dbo].[tb_veiculos] ([Id], [Placa])
GO
/****** Object:  ForeignKey [FK__tb_multas__6754599E]    Script Date: 11/25/2019 21:33:18 ******/
ALTER TABLE [dbo].[tb_multas]  WITH CHECK ADD FOREIGN KEY([IdVeiculo], [PlacaVeiculo])
REFERENCES [dbo].[tb_veiculos] ([Id], [Placa])
GO
/****** Object:  ForeignKey [FK__tb_multas__IdCon__66603565]    Script Date: 11/25/2019 21:33:18 ******/
ALTER TABLE [dbo].[tb_multas]  WITH CHECK ADD FOREIGN KEY([IdCondutores])
REFERENCES [dbo].[tb_condutores] ([Id])
GO
/****** Object:  ForeignKey [FK__tb_logs__IdUsuar__6383C8BA]    Script Date: 11/25/2019 21:33:18 ******/
ALTER TABLE [dbo].[tb_logs]  WITH CHECK ADD FOREIGN KEY([IdUsuario])
REFERENCES [dbo].[tb_usuarios] ([Id])
GO
/****** Object:  ForeignKey [FK__tb_locaco__IdCli__60A75C0F]    Script Date: 11/25/2019 21:33:18 ******/
ALTER TABLE [dbo].[tb_locacoes]  WITH CHECK ADD FOREIGN KEY([IdCliente])
REFERENCES [dbo].[tb_clientes] ([Id])
GO
/****** Object:  ForeignKey [FK__tb_locaco__IdSeg__619B8048]    Script Date: 11/25/2019 21:33:18 ******/
ALTER TABLE [dbo].[tb_locacoes]  WITH CHECK ADD FOREIGN KEY([IdSeguro])
REFERENCES [dbo].[tb_seguros] ([Id])
GO
/****** Object:  ForeignKey [FK__tb_locacoes__628FA481]    Script Date: 11/25/2019 21:33:18 ******/
ALTER TABLE [dbo].[tb_locacoes]  WITH CHECK ADD FOREIGN KEY([IdVeiculo], [PlacaVeiculo])
REFERENCES [dbo].[tb_veiculos] ([Id], [Placa])
GO
/****** Object:  ForeignKey [FK__tb_financ__IdCen__5DCAEF64]    Script Date: 11/25/2019 21:33:18 ******/
ALTER TABLE [dbo].[tb_financeiro]  WITH CHECK ADD FOREIGN KEY([IdCentroCusto])
REFERENCES [dbo].[tb_centrocustos] ([Id])
GO
/****** Object:  ForeignKey [FK__tb_financ__IdCli__5EBF139D]    Script Date: 11/25/2019 21:33:18 ******/
ALTER TABLE [dbo].[tb_financeiro]  WITH CHECK ADD FOREIGN KEY([IdClientes])
REFERENCES [dbo].[tb_clientes] ([Id])
GO
/****** Object:  ForeignKey [FK__tb_financ__IdPla__5FB337D6]    Script Date: 11/25/2019 21:33:18 ******/
ALTER TABLE [dbo].[tb_financeiro]  WITH CHECK ADD FOREIGN KEY([IdPlanoContas])
REFERENCES [dbo].[tb_planocontas] ([Id])
GO
