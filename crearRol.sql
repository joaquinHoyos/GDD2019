
CREATE PROCEDURE PASO_A_PASO.crearRol (@nombre varchar(20),@funciones tablaFuncion READONLY)
AS

	INSERT INTO PASO_A_PASO.Rol VALUES (@nombre)
	DECLARE @idRol AS int
	SET @idRol = IDENT_CURRENT('PASO_A_PASO.Rol')
	
	DECLARE @funcion as varchar(20)
		
	DECLARE c1 CURSOR FOR (select * from @funciones)
	OPEN c1
		FETCH NEXT FROM c1 INTO @funcion
		WHILE @@FETCH_STATUS=0
		BEGIN
			INSERT INTO PASO_A_PASO.FuncionesxRol
			VALUES(@idRol,(SELECT func_id FROM PASO_A_PASO.Funcion WHERE func_nombre=@funcion))
		FETCH NEXT FROM c1 INTO @funcion
		END
	CLOSE c1

