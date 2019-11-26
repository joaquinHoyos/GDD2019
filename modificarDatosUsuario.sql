CREATE PROCEDURE PASO_A_PASO.modificarDatosUsuario(@user varchar(32),@pass varchar(32),@intentos int,@id int)
AS
	IF @pass IS NULL
	BEGIN
		UPDATE PASO_A_PASO.Usuario 
		SET user_username=@user,
		user_intentosLogin=@intentos
		WHERE user_id=@id
	END
	ELSE
	BEGIN
		UPDATE PASO_A_PASO.Usuario 
		SET user_username=@user,
		user_intentosLogin=@intentos,
		user_password=HASHBYTES('SHA2_256',@pass)
		WHERE user_id=@id
	END