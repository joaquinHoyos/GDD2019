CREATE TRIGGER PASO_A_PASO.saldoInicial ON PASO_A_PASO.Cliente AFTER INSERT
AS
INSERT INTO PASO_A_PASO.Credito (cred_cliente,cred_monto,cred_fecha,cred_tarjeta,cred_tipoPago) VALUES ((SELECT clie_id FROM inserted),200,GETDATE(), null,null)