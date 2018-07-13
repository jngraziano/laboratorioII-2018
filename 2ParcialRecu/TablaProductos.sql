USE [final-20180712]
GO

/****** Object:  Table [dbo].[Productos]    Script Date: 10/7/2018 2:19:45 a. m. ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[Productos](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[descripcion] [varchar](50) NULL,
	[tipo] [char](1) NULL,
	[diametro] [int] NULL,
	[material] [varchar](50) NULL,
	[largo] [int] NULL,
	[alto] [int] NULL,
	[ancho] [int] NULL
) ON [PRIMARY]
GO

