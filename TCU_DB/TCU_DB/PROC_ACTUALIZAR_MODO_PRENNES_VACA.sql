﻿CREATE PROCEDURE [dbo].[PROC_ACTUALIZAR_MODO_PRENNES_VACA]
	@numeroTrazable INT,
	@fkModoPrennes INT
AS
	BEGIN
		UPDATE [dbo].[VACA]
		SET [FK_ID_MODO_PRENNES] = @fkModoPrennes
		WHERE [PK_NUMERO_TRAZABLE] = @numeroTrazable
	END
