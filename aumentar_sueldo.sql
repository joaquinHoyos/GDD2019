CREATE TRIGGER PASO_A_PASO.aumentar_sueldo ON PASO_A_PASO.Credito AFTER INSERT
AS
DECLARE @saldoAAumentar int, @idCliente int, @saldoActual int
DECLARE C1 CURSOR FOR (SELECT cred_cliente, cred_monto FROM Inserted)
OPEN C1
FETCH NEXT FROM C1 INTO @idCliente,@saldoAAumentar
WHILE @@FETCH_STATUS =0
BEGIN
SET @saldoActual = (SELECT clie_saldo FROM PASO_A_PASO.Cliente WHERE clie_id =@idCliente)
UPDATE PASO_A_PASO.Cliente SET clie_saldo=@saldoActual+@saldoAAumentar WHERE clie_id = @idCliente
FETCH NEXT FROM C1 INTO @idCliente, @saldoAAumentar
END
CLOSE C1
DEALLOCATE C1