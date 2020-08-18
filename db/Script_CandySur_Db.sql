USE [master]
GO

CREATE DATABASE [CandySur]
GO

CREATE TABLE [dbo].[Bitacora](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Fecha] [datetime] NOT NULL,
	[Id_Criticidad] [int] NOT NULL,
	[Descripcion] [varchar](200) NULL,
	[Id_Usuario] [int] NOT NULL,
	[DVH] [varchar](200) NULL,
 CONSTRAINT [PK_Bitacora] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO


CREATE TABLE [dbo].[Criticidad](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Descripcion] [varchar](200) NOT NULL,
 CONSTRAINT [PK_Criticidad] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO

CREATE TABLE [dbo].[DVV](
	[Nombre_Tabla] [varchar](50) NOT NULL,
	[DVV] [varchar](200) NULL,
 CONSTRAINT [PK_DVV] PRIMARY KEY CLUSTERED 
(
	[Nombre_Tabla] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO

CREATE TABLE [dbo].[Familia](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Nombre] [varchar](200) NOT NULL,
	[DVH] [varchar](200) NOT NULL,
	[Eliminado] [bit] NULL,
 CONSTRAINT [PK_Familia] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO

CREATE TABLE [dbo].[Familia_Patente](
	[Id_Familia] [int] NULL,
	[Id_Patente] [int] NULL
) ON [PRIMARY]
GO

CREATE TABLE [dbo].[Usuario](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Nombre] [varchar](200) NOT NULL,
	[Apellido] [varchar](200) NOT NULL,
	[DNI] [int] NOT NULL,
	[Nombre_Usuario] [varchar](200) NOT NULL,
	[Contraseña] [varchar](200) NOT NULL,
	[Direccion] [varchar](200) NULL,
	[Telefono] [int] NOT NULL,
	[Reintentos] [int] NULL,
	[Mail] [varchar](200) NOT NULL,
	[Fecha_Nac] [datetime] NULL,
	[Eliminado] [bit] NULL,
	[Bloqueado] [bit] NULL,
	[DVH] [varchar](200) NULL,
 CONSTRAINT [PK_Usuario] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO

CREATE TABLE [dbo].[Usuario_Familia](
	[Id_Usuario] [int] NOT NULL,
	[d_Familia] [int] NOT NULL
) ON [PRIMARY]
GO

CREATE TABLE [dbo].[Usuario_Patente](
	[Id_Usuario] [int] NOT NULL,
	[Id_Patente] [int] NOT NULL
) ON [PRIMARY]
GO











