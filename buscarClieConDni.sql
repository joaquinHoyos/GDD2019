CREATE FUNCTION PASO_A_PASO.buscarClieConDni(@dni numeric(18,0))
RETURNS TABLE
AS

RETURN (SELECT * FROM PASO_A_PASO.Cliente WHERE clie_dni = @dni)
