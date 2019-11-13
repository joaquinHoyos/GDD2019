CREATE PROCEDURE PASO_A_PASO.asignarUsuarioACliente(@clie_id int,@usuarioNuevo varchar(32), @contraNuevo varchar(32))AS
BEGIN


EXEC PASO_A_PASO.crearUsuario @username=@usuarioNuevo,@pass=@contraNuevo,@rol=2
UPDATE PASO_A_PASO.Cliente SET clie_userId =(SELECT user_id FROM PASO_A_PASO.Usuario WHERE user_username = @usuarioNuevo) WHERE clie_id = @clie_id


END
