CREATE PROCEDURE PASO_A_PASO.generarCompra(@userID int, @oferCodigo nvarchar(50) ,@cantidad int)
AS 
DECLARE @clieID int
SET @clieID = (SELECT clie_id FROM PASO_A_PASO.Cliente c WHERE c.clie_userId=@userID)
DECLARE @precioOferta numeric(18,2)
SET @precioOferta = (SELECT ofer_precioOferta FROM PASO_A_PASO.Oferta o WHERE o.ofer_id=@oferCodigo)
INSERT INTO PASO_A_PASO.Compra (comp_oferta,comp_cliente,comp_cantidad,comp_factura,comp_importe) VALUES (@oferCodigo,@clieID,@cantidad,null,@cantidad * @precioOferta)
UPDATE PASO_A_PASO.Cliente SET clie_saldo-=@cantidad * @precioOferta WHERE clie_id=@clieID;
UPDATE PASO_A_PASO.Oferta SET ofer_disponible-=@cantidad WHERE ofer_id=@oferCodigo;
