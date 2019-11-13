CREATE PROCEDURE PASO_A_PASO.inicioFallido(@user varchar(32))
AS
BEGIN
IF(EXISTS(SELECT * FROM PASO_A_PASO.Usuario WHERE user_username = @user AND user_status='E'))
BEGIN
IF((SELECT user_intentosLogin FROM PASO_A_PASO.Usuario WHERE user_username = @user)<2)
UPDATE PASO_A_PASO.Usuario SET user_intentosLogin += 1 WHERE user_username = @user
ELSE
UPDATE PASO_A_PASO.Usuario SET user_status='D' WHERE (user_username = @user)
END
END