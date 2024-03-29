USE [efleet]
GO
/****** Object:  Table [dbo].[tb_situacao]    Script Date: 10/20/2019 15:19:35 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[tb_situacao]') AND type in (N'U'))
DROP TABLE [dbo].[tb_situacao]
GO
/****** Object:  Table [dbo].[tb_situacao]    Script Date: 10/20/2019 15:19:35 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[tb_situacao]') AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[tb_situacao](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[descricao] [varchar](20) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
END
GO
SET ANSI_PADDING OFF
GO
SET IDENTITY_INSERT [dbo].[tb_situacao] ON
INSERT [dbo].[tb_situacao] ([id], [descricao]) VALUES (1, N'ATIVO')
INSERT [dbo].[tb_situacao] ([id], [descricao]) VALUES (2, N'INATIVO')
SET IDENTITY_INSERT [dbo].[tb_situacao] OFF
