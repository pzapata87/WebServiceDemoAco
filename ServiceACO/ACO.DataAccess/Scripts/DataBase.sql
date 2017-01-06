CREATE DATABASE ServiceTestACO;

GO

USE ServiceTestACO;

GO

CREATE TABLE [dbo].[Cliente](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Dni] [nvarchar](8) NOT NULL,
	[Nombre] [nvarchar](100) NOT NULL,
	[Apellido] [nvarchar](100) NOT NULL,
	[FechaNacimiento] [datetime] NULL,
	[Direccion] [nvarchar](50) NULL,
	[Email] [nvarchar](50) NULL,
	[Telefono] [nvarchar](10) NULL,
	[Celular] [nvarchar](15) NULL,
 CONSTRAINT [PK_dbo.Persona] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)
) ON [PRIMARY]