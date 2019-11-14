CREATE PROCEDURE PASO_A_PASO.deshabilitarRol(@rol int)
AS
	UPDATE PASO_A_PASO.Rol  SET rol_estado='D' WHERE rol_id=@rol
