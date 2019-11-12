CREATE FUNCTION PASO_A_PASO.logInUsuario (@username varchar(32),@password varchar(32))
RETURNS TABLE
AS
	RETURN SELECT * FROM PASO_A_PASO.Usuario
	WHERE user_username = @username AND user_password=HASHBYTES('SHA2_256',@password)

