CREATE PROCEDURE PASO_A_PASO.inicializacion_tablas
AS
	
	INSERT INTO PASO_A_PASO.Usuario VALUES ('admin',HASHBYTES('SHA2_256','w23e'),0,'E','1/1/1900');
	EXEC PASO_A_PASO.crearUsuario('admin','w23e',1)
	INSERT INTO PASO_A_PASO.Funcion VALUES ('CARGA_CREDITO','C')
	INSERT INTO PASO_A_PASO.Funcion VALUES ('COMPRAR','C')
	INSERT INTO PASO_A_PASO.Funcion VALUES ('VER_CUPON','C')
	INSERT INTO PASO_A_PASO.Funcion VALUES ('COMPARTIR_CUPON','C')
	INSERT INTO PASO_A_PASO.Funcion VALUES ('FACTURAR','P')
	INSERT INTO PASO_A_PASO.Funcion VALUES ('ABM_OFERTA','P')
	INSERT INTO PASO_A_PASO.Funcion VALUES ('VER_OFERTA','P')
	INSERT INTO PASO_A_PASO.Funcion VALUES ('ABM_USUARIO','A')
	INSERT INTO PASO_A_PASO.Funcion VALUES ('ABM_ROL','A')
	
	DECLARE @funcAdmin AS tablaFuncion
	INSERT INTO @funcAdmin
	SELECT func_nombre 
	FROM PASO_A_PASO.Funcion 
	WHERE func_grupo='A'
	
	--select * from PASO_A_PASO.Funcion
	--where func_nombre in (select * from @funcAdmin)
	--select * from PASO_A_PASO.Rol
	EXEC PASO_A_PASO.crearRol @nombre='ADMINISTRADOR',@funciones=@funcAdmin
	
	