CREATE FUNCTION PASO_A_PASO.traerCuponesPropios ( @clieID int)
RETURNS TABLE
AS
--faltaria traer clieID de userID. Llega userID
RETURN (SELECT * FROM PASO_A_PASO.Cupon WHERE cupo_cliente = @clieID)