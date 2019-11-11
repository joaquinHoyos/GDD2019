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
	