CREATE FUNCTION PASO_A_PASO.saldoUsuario(@idUsuario int)
RETURNS int
AS
BEGIN
RETURN (SELECT clie_saldo FROM PASO_A_PASO.Cliente WHERE clie_userId = @idUsuario)
END