CREATE TRIGGER altaCupon ON PASO_A_PASO.Compra AFTER INSERT
AS
BEGIN
DECLARE @oferta nvarchar(50), @cliente int, @cantidad int, @compid int
DECLARE c1 CURSOR FOR  SELECT comp_oferta,comp_cliente,comp_cantidad,comp_id FROM INSERTED WHERE NOT EXISTS (SELECT * FROM gd_esquema.Maestra WHERE comp_oferta=Oferta_Codigo AND Cli_Dni=(SELECT clie_dni FROM Cliente WHERE clie_id=comp_cliente) AND Oferta_Entregado_Fecha IS NOT NULL)
OPEN c1
FETCH NEXT FROM c1 INTO @oferta,@cliente,@cantidad,@compid 
WHILE(@@FETCH_STATUS=0)
BEGIN
WHILE(@cantidad > 0)
BEGIN
INSERT INTO PASO_A_PASO.Cupon (cupo_cliente,cupo_oferta,cupo_compra,cupo_fecha) VALUES (@cliente,@oferta,@compid,'01/01/1900') 
SET @cantidad =- 1
END 
FETCH NEXT FROM c1 INTO @oferta,@cliente,@cantidad, @compid
END 
CLOSE c1
DEALLOCATE c1
END