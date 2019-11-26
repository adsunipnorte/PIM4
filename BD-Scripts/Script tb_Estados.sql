USE [efleet]
GO
/****** Object:  Table [dbo].[tb_estados]    Script Date: 10/19/2019 00:43:12 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[tb_estados]') AND type in (N'U'))
DROP TABLE [dbo].[tb_estados]
GO
/****** Object:  Table [dbo].[tb_estados]    Script Date: 10/19/2019 00:43:12 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[tb_estados]') AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[tb_estados](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[Estado] [varchar](30) NOT NULL,
	[Sigla] [char](2) NOT NULL
) ON [PRIMARY]
END
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
