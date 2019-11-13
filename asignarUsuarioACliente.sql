CREATE PROCEDURE PASO_A_PASO.asignarUsuarioACliente(@clie_id int,@username varchar(32),@pass varchar(32), @roles PASO_A_PASO.tablaRoles READONLY)
AS
BEGIN


	DECLARE @id_roles_nuevo TABLE(id_rol int)
	INSERT INTO @id_roles_nuevo SELECT rol_id FROM PASO_A_PASO.Rol WHERE rol_nombre IN (SELECT rol FROM @roles)


	INSERT INTO Usuario VALUES (@username,HASHBYTES('SHA2_256',@pass),0,'E','1/1/1900')
	
	DECLARE @id_usuario_nuevo int
	SET @id_usuario_nuevo = (SELECT user_id FROM  PASO_A_PASO.Usuario WHERE user_username = @username)
	

	INSERT INTO PASO_A_PASO.RolxUsuario 
	SELECT id_rol,@id_usuario_nuevo FROM @id_roles_nuevo

	UPDATE PASO_A_PASO.Cliente SET clie_userId = @id_usuario_nuevo WHERE clie_id = @clie_id
	

END
