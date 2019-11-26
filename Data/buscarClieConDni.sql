CREATE FUNCTION PASO_A_PASO.buscarClieDni(@clie_dni numeric(18,8))
RETURNS TABLE
AS

RETURN (SELECT * FROM PASO_A_PASO.Cliente WHERE clie_dni = @clie_dni)
