CREATE TABLE [dbo].[Personas](
	[IdPersona] [int] IDENTITY(1,1) NOT NULL,
	[Nombres] [nvarchar](60) NOT NULL,
	[Apellidos] [nvarchar](60) NOT NULL,
	[NumeroIdentificacion] [nvarchar](12) NOT NULL,
	[Email] [nvarchar](50) NOT NULL,
	[TipoIdentificacion] [nvarchar](4) NOT NULL,
	[FechaCreacion] [date] NOT NULL,
	[TipoNumeroIdentificacion] [nvarchar](15) NOT NULL,
	[NombreCompleto] [nvarchar](50) NOT NULL
) ON [PRIMARY]
CREATE TABLE [dbo].[Usuario](
	[IdUsuario] [int] IDENTITY(1,1) NOT NULL,
	[NombreUsuario] [varchar](30) NOT NULL,
	[Password] [varchar](20) NOT NULL,
	[FechaCreacion] [date] NOT NULL
) ON [PRIMARY]
