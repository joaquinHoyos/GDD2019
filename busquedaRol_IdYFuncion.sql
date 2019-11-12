CREATE FUNCTION PASO_A_PASO.busquedaRol_IdYFuncion(@id int,@funcion tablaFuncion READONLY)
RETURNS TABLE
AS
	RETURN 
	SELECT rol_id,rol_nombre,id_funcion
	FROM PASO_A_PASO.Rol
	JOIN PASO_A_PASO.FuncionesxRol ON (rol_id = id_rol)
	WHERE rol_id=@id and id_funcion IN (SELECT * FROM @funcion)
 
