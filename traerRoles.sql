CREATE FUNCTION PASO_A_PASO.traerRoles(@usuario int)
RETURNS TABLE
AS
	RETURN SELECT id_rol FROM PASO_A_PASO.RolxUsuario
	WHERE id_usuario=@usuario
