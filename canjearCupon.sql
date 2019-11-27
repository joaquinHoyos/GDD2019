CREATE PROCEDURE PASO_A_PASO.canjearCupon(@cupon int, @fecha smalldatetime)
AS
UPDATE PASO_A_PASO.Cupon SET cupo_fecha = @fecha WHERE cupo_id=@cupon