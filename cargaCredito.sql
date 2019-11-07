CREATE PROCEDURE PASO_A_PASO.cargarCredito(@tipoPago nvarchar(10), @tarjeta numeric(10,0) , @monto numeric(10,0), @userID int)
AS 
DECLARE @clieID int
SET @clieID = (SELECT clie_id FROM PASO_A_PASO.Cliente c WHERE c.clie_userId=@userID)
INSERT INTO PASO_A_PASO.Credito (cred_cliente,cred_tipoPago,cred_fecha,cred_tarjeta,cred_monto) VALUES (@clieID,@tipoPago,GETDATE(),@tarjeta,@monto)