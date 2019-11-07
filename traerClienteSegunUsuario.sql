CREATE FUNCTION PASO_A_PASO.traerClienteSegunUsuario ( @userID int)
RETURNS TABLE
AS
RETURN (SELECT clie_id FROM PASO_A_PASO.Cliente WHERE clie_userID = @userID)