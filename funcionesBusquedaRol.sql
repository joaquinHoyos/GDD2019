CREATE FUNCTION PASO_A_PASO.busquedaRol_Id(@id int)
RETURNS TABLE
AS
		RETURN
		SELECT rol_id,rol_nombre,id_funcion
		FROM PASO_A_PASO.Rol
		JOIN PASO_A_PASO.FuncionesxRol ON (rol_id = id_rol)
		WHERE rol_id=@id

CREATE FUNCTION PASO_A_PASO.busquedaRol_Nombre(@nombre varchar(20))
RETURNS TABLE
AS
	RETURN 
	SELECT rol_id,rol_nombre,id_funcion
	FROM PASO_A_PASO.Rol
	JOIN PASO_A_PASO.FuncionesxRol ON (rol_id = id_rol)
	WHERE rol_nombre=@nombre

CREATE FUNCTION PASO_A_PASO.busquedaRol_Funcion(@funcion tablaFuncion READONLY)
RETURNS TABLE
AS
	RETURN 
	SELECT rol_id,rol_nombre,id_funcion
	FROM PASO_A_PASO.Rol
	JOIN PASO_A_PASO.FuncionesxRol ON (rol_id = id_rol)
	WHERE id_funcion in (SELECT * FROM @funcion)
 
CREATE FUNCTION PASO_A_PASO.busquedaRol_IdYNombre(@id int,@nombre varchar(20))
RETURNS TABLE
AS
	RETURN 
	SELECT rol_id,rol_nombre,id_funcion
	FROM PASO_A_PASO.Rol
	JOIN PASO_A_PASO.FuncionesxRol ON (rol_id = id_rol)
	WHERE rol_nombre=@nombre AND rol_id=@id
 
CREATE FUNCTION PASO_A_PASO.busquedaRol_IdYFuncion(@id int,@funcion tablaFuncion READONLY)
RETURNS TABLE
AS
	RETURN 
	SELECT rol_id,rol_nombre,id_funcion
	FROM PASO_A_PASO.Rol
	JOIN PASO_A_PASO.FuncionesxRol ON (rol_id = id_rol)
	WHERE rol_id=@id and id_funcion IN (SELECT * FROM @funcion)
 
CREATE FUNCTION PASO_A_PASO.busquedarRol_NombreYFuncion(@nombre varchar(20),@funcion tablaFuncion READONLY)
RETURNS TABLE
AS
	RETURN 
	SELECT rol_id,rol_nombre,id_funcion
	FROM PASO_A_PASO.Rol
	JOIN PASO_A_PASO.FuncionesxRol ON (rol_id = id_rol)
	WHERE rol_nombre=@nombre AND id_funcion IN (SELECT * FROM @funcion)
 
	CREATE FUNCTION PASO_A_PASO.busquedaRol_Todo()
	RETURNS TABLE
	AS
		RETURN 
		SELECT rol_id,rol_nombre,id_funcion
		FROM PASO_A_PASO.Rol
		JOIN PASO_A_PASO.FuncionesxRol ON (rol_id = id_rol)
	