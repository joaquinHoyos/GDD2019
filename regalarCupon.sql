CREATE PROCEDURE PASO_A_PASO.regalarCupon(@cuponID int, @clienteID int)
AS
UPDATE PASO_A_PASO.Cupon SET cupo_cliente = @clienteID WHERE cupo_id=@cuponID