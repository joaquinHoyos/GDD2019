
	CREATE FUNCTION PASO_A_PASO.busquedaId (@id int)
	RETURNS TABLE
	AS
			RETURN
			SELECT rol_id,rol_nombre
			FROM PASO_A_PASO.Rol
			WHERE rol_id=@id
