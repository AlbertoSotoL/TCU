﻿CREATE TABLE [dbo].[MODO_PRENNES]
(
	[PK_ID_MODO_PRENNES]	INT				NOT NULL	IDENTITY (1, 1),
	[MODO_PRENNES]			NVARCHAR(50)	NOT NULL,

	CONSTRAINT CK_PK_ID_MODO_PRENNES PRIMARY KEY CLUSTERED ([PK_ID_MODO_PRENNES] ASC)
)
