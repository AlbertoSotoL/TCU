﻿CREATE PROCEDURE [dbo].[PROC_ELIMINAR_VACA]
	@numeroTrazable INT
AS
	BEGIN
		DELETE FROM [dbo].[VACA] WHERE [PK_NUMERO_TRAZABLE] = @numeroTrazable
	END