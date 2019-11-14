CREATE PROCEDURE PASO_A_PASO.habilitarRol(@rol int)
AS
	UPDATE PASO_A_PASO.Rol  SET rol_estado='E' WHERE rol_id=@rol

