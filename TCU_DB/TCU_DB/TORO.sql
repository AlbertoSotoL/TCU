﻿CREATE TABLE [dbo].[TORO]
(
	[PK_NUMERO_TRAZABLE]	INT				NOT NULL,
	[FK_ID_RAZA]			INT				NULL,
	[CARACTERISTICAS]		NVARCHAR(MAX)	NOT NULL,
	[NOMBRE]				NVARCHAR(20)	NULL,
	[ACTIVA]				BIT				NOT NULL,
	[CAUSA_DE_BAJA]			NVARCHAR(MAX)	NULL,

	CONSTRAINT CK_PK_NUMERO_TRAZABLE_TORO PRIMARY KEY CLUSTERED (PK_NUMERO_TRAZABLE),
	CONSTRAINT CK_FK_TORO_RAZA FOREIGN KEY (FK_ID_RAZA)
		REFERENCES dbo.[RAZA](PK_ID_RAZA)
)
