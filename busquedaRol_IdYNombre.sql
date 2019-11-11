CREATE FUNCTION PASO_A_PASO.busquedaRol_IdYNombre(@id int,@nombre varchar(20))
RETURNS TABLE
AS
	RETURN 
	SELECT rol_id,rol_nombre,id_funcion
	FROM PASO_A_PASO.Rol
	JOIN PASO_A_PASO.FuncionesxRol ON (rol_id = id_rol)
	WHERE rol_nombre=@nombre AND rol_id=@id
 
