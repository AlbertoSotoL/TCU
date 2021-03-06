﻿CREATE TABLE [dbo].[FECHAS_CELOS]
(
	[PK_FK_NUMERO_TRAZABLE_VACA]	INT			NOT NULL,
	[PK_FECHA]						DATETIME	NOT NULL,

	CONSTRAINT CK_PK_FECHAS_CELOS PRIMARY KEY CLUSTERED (PK_FK_NUMERO_TRAZABLE_VACA, PK_FECHA),
	CONSTRAINT CK_PK_FK_NUMERO_TRAZABLE_VACA_FECHAS_SALTOS FOREIGN KEY(PK_FK_NUMERO_TRAZABLE_VACA)
		REFERENCES dbo.VACA(PK_NUMERO_TRAZABLE) ON UPDATE CASCADE ON DELETE CASCADE
)
