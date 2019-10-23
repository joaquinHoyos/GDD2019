CREATE PROCEDURE PASO_A_PASO.crearUsuario (@username varchar(32),@pass varchar(32),@rol int)
AS

	INSERT INTO Usuario VALUES (@username,HASHBYTES('SHA2_256',@pass),0,'E','1/1/1900')
	INSERT INTO RolxUsuario VALUES(@rol,IDENT_CURRENT('PASO_A_PASO.Usuario'))

