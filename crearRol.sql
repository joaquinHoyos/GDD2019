CREATE PROCEDURE PASO_A_PASO.crearRol (@nombre varchar(20),@funciones tablaFuncion READONLY)
AS

	INSERT INTO PASO_A_PASO.Rol VALUES (@nombre,'E')
	DECLARE @idRol AS int
	SET @idRol = IDENT_CURRENT('PASO_A_PASO.Rol')
	
	INSERT INTO PASO_A_PASO.FuncionesxRol
	SELECT @idRol,func_id
	FROM @funciones
	JOIN PASO_A_PASO.Funcion ON (func_id = funciones)
	

