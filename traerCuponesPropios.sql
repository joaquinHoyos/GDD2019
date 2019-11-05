CREATE FUNCTION PASO_A_PASO.traerCuponesPropios ( @userID int)
RETURNS TABLE
AS
BEGIN
DECLARE @clieID int
SET @clieID = (SELECT clie_id FROM PASO_A_PASO.Cliente c WHERE c.clie_userId=@userID)
RETURN (SELECT * FROM PASO_A_PASO.Cupon WHERE cupo_cliente = @clieID)
END