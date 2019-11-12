CREATE FUNCTION PASO_A_PASO.busquedaRol_Id(@id int)
RETURNS TABLE
AS
	RETURN
	SELECT rol_id,rol_nombre,id_funcion,func_grupo,rol_estado
	FROM PASO_A_PASO.Rol
	JOIN PASO_A_PASO.FuncionesxRol ON (rol_id = id_rol)
	JOIN PASO_A_PASO.Funcion ON (id_funcion=func_id)
	WHERE rol_id=@id


