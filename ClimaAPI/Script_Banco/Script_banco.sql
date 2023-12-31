USE [DBClimaAPi]
GO
/****** Object:  Table [dbo].[__EFMigrationsHistory]    Script Date: 02/10/2023 16:05:26 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[__EFMigrationsHistory](
	[MigrationId] [nvarchar](150) NOT NULL,
	[ProductVersion] [nvarchar](32) NOT NULL,
 CONSTRAINT [PK___EFMigrationsHistory] PRIMARY KEY CLUSTERED 
(
	[MigrationId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Climas]    Script Date: 02/10/2023 16:05:26 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Climas](
	[codigo_icao] [nvarchar](450) NOT NULL,
	[umidade] [int] NOT NULL,
	[visibilidade] [nvarchar](max) NOT NULL,
	[pressao_atmosferica] [int] NOT NULL,
	[vento] [int] NOT NULL,
	[direcao_vento] [int] NOT NULL,
	[condicao] [nvarchar](max) NOT NULL,
	[condicao_desc] [nvarchar](max) NOT NULL,
	[temp] [int] NOT NULL,
	[atualizado_em] [datetime2](7) NOT NULL,
 CONSTRAINT [PK_Climas] PRIMARY KEY CLUSTERED 
(
	[codigo_icao] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
INSERT [dbo].[__EFMigrationsHistory] ([MigrationId], [ProductVersion]) VALUES (N'20231002175514_InitialSchoolDB', N'6.0.0')
INSERT [dbo].[__EFMigrationsHistory] ([MigrationId], [ProductVersion]) VALUES (N'20231002180156_InitialSchoolDB', N'6.0.0')
GO
INSERT [dbo].[Climas] ([codigo_icao], [umidade], [visibilidade], [pressao_atmosferica], [vento], [direcao_vento], [condicao], [condicao_desc], [temp], [atualizado_em]) VALUES (N'SBAR', 62, N'>10000', 1011, 22, 120, N'ps', N'Predomínio de Sol', 28, CAST(N'2023-10-02T14:00:00.5980000' AS DateTime2))
INSERT [dbo].[Climas] ([codigo_icao], [umidade], [visibilidade], [pressao_atmosferica], [vento], [direcao_vento], [condicao], [condicao_desc], [temp], [atualizado_em]) VALUES (N'SBBE', 71, N'>10000', 1009, 29, 340, N'ps', N'Predomínio de Sol', 31, CAST(N'2023-10-02T14:00:00.0620000' AS DateTime2))
INSERT [dbo].[Climas] ([codigo_icao], [umidade], [visibilidade], [pressao_atmosferica], [vento], [direcao_vento], [condicao], [condicao_desc], [temp], [atualizado_em]) VALUES (N'SBBR', 50, N'>10000', 1015, 11, 80, N'ps', N'Predomínio de Sol', 28, CAST(N'2023-10-02T14:00:00.9880000' AS DateTime2))
GO
