
CREATE PROCEDURE PASO_A_PASO.inicioValido(@user varchar(32))
AS
UPDATE PASO_A_PASO.Usuario SET user_intentosLogin = 0 WHERE user_username = @user


