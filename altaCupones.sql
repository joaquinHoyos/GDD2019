CREATE TRIGGER altaCupon ON PASO_A_PASO.Compra AFTER INSERT
AS
BEGIN
DECLARE @oferta nvarchar(50), @cliente int, @cantidad int
DECLARE c1 CURSOR FOR  SELECT comp_oferta,comp_cliente,comp_cantidad FROM INSERTED WHERE NOT EXISTS (SELECT * FROM gd_esquema.Maestra WHERE comp_oferta=Oferta_Codigo AND Cli_Dni=(SELECT clie_dni FROM Cliente WHERE clie_id=comp_cliente) AND Oferta_Entregado_Fecha IS NOT NULL)
OPEN c1
FETCH NEXT FROM c1 INTO @oferta,@cliente,@cantidad 
WHILE(@@FETCH_STATUS=0)
BEGIN
WHILE(@cantidad > 0)
BEGIN
INSERT INTO PASO_A_PASO.Cupon (cupo_cliente,cupo_oferta) VALUES (@cliente,@oferta) 
SET @cantidad =- 1
END 
FETCH NEXT FROM c1 INTO @oferta,@cliente,@cantidad
END 
CLOSE c1
DEALLOCATE c1
END