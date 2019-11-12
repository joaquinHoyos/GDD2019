CREATE PROCEDURE PASO_A_PASO.modificarRol(@id int,@nombre varchar(20), @funciones tablaFuncion READONLY)
AS
	IF @nombre NOT IN (SELECT rol_nombre FROM Rol WHERE rol_id=@id)
		UPDATE Rol SET rol_nombre = @nombre WHERE rol_id=@id
	

	DELETE FuncionesxRol WHERE id_rol=@id

	INSERT INTO FuncionesxRol
	SELECT @id,funciones FROM @funciones 
