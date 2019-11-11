	CREATE FUNCTION PASO_A_PASO.busquedaRol_Todo()
	RETURNS TABLE
	AS
		RETURN 
		SELECT rol_id,rol_nombre,id_funcion
		FROM PASO_A_PASO.Rol
		JOIN PASO_A_PASO.FuncionesxRol ON (rol_id = id_rol)
	