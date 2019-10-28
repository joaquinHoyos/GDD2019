CREATE FUNCTION PASO_A_PASO.logInUsuario (@username varchar(32),@password varchar(32))
RETURNS TABLE
AS
	RETURN SELECT * FROM PASO_A_PASO.Usuario
	WHERE user_username = @username AND user_password=HASHBYTES('SHA2_256',@password)

CREATE FUNCTION PASO_A_PASO.traerRoles(@usuario int)
RETURNS TABLE
AS
	RETURN SELECT id_rol FROM PASO_A_PASO.RolxUsuario
	WHERE id_usuario=@usuario

CREATE FUNCTION PASO_A_PASO.traerFunciones(@usuario int)
RETURNS TABLE
AS
	RETURN
	SELECT func_id,func_grupo 
	FROM PASO_A_PASO.Usuario us
	JOIN PASO_A_PASO.RolxUsuario ru ON (user_id=id_usuario)
	JOIN PASO_A_PASO.FuncionesxRol rf ON (ru.id_rol=rf.id_rol)
	JOIN PASO_A_PASO.Funcion ON (func_id=rf.id_funcion)
	WHERE user_id=@usuario
	