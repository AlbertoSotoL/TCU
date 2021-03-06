﻿CREATE TABLE [dbo].[USUARIO]
(
	[PK_PROPIETARIO]	NVARCHAR(50)	NOT NULL,
	[COORDENADAS]		NVARCHAR(50),
	[CONTACTO]			NVARCHAR(MAX)	NOT NULL,
	[ACTIVIDADES]		NVARCHAR(MAX)	NOT NULL,
	[PERIODO_DESTETE]	NVARCHAR(50)	NOT NULL,
	[DIRECCION]			NVARCHAR(MAX)	NOT NULL,
	[NOMBRE_FINCA]		NVARCHAR(50)	NOT NULL,

	CONSTRAINT CK_PK_PROPIETARIO PRIMARY KEY CLUSTERED (PK_PROPIETARIO)
)
