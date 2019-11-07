CREATE PROCEDURE PASO_A_PASO.inicializacion_tablas
AS
	--CREA FUNCIONES
	INSERT INTO PASO_A_PASO.Funcion VALUES ('CARGA_CREDITO','C')
	INSERT INTO PASO_A_PASO.Funcion VALUES ('COMPRAR','C')
	INSERT INTO PASO_A_PASO.Funcion VALUES ('VER_CUPON','C')
	INSERT INTO PASO_A_PASO.Funcion VALUES ('COMPARTIR_CUPON','C')
	INSERT INTO PASO_A_PASO.Funcion VALUES ('FACTURAR','A')
	INSERT INTO PASO_A_PASO.Funcion VALUES ('ABM_OFERTA','P')
	INSERT INTO PASO_A_PASO.Funcion VALUES ('VER_OFERTA','P')
	INSERT INTO PASO_A_PASO.Funcion VALUES ('ABM_USUARIO','A')
	INSERT INTO PASO_A_PASO.Funcion VALUES ('ABM_ROL','A')

	

	-- CREAR ROLES
	--CREA ROL ADMINISTRADOR
	DECLARE @funcAdmin AS PASO_A_PASO.tablaFuncion

	INSERT INTO @funcAdmin SELECT func_nombre 
	FROM PASO_A_PASO.Funcion WHERE func_grupo='A'
	
	EXEC PASO_A_PASO.crearRol @nombre='ADMINISTRADOR',@funciones=@funcAdmin
	
	--CREAR ROL CLIENTE
	DECLARE @funcCli AS PASO_A_PASO.tablaFuncion
	
	INSERT INTO @funcCli SELECT func_nombre 
	FROM PASO_A_PASO.Funcion WHERE func_grupo='C'
	
	EXEC PASO_A_PASO.crearRol @nombre='CLIENTE',@funciones=@funcCli
	
	--CREAR ROL PROVEEDOR
	DECLARE @funcProv AS PASO_A_PASO.tablaFuncion
	
	INSERT INTO @funcProv SELECT func_nombre 
	FROM PASO_A_PASO.Funcion WHERE func_grupo='A'
	
	EXEC PASO_A_PASO.crearRol @nombre='PROVEEDOR',@funciones=@funcProv
	
	


	
	--CREAR USUARIO	
	EXEC PASO_A_PASO.crearUsuario @username='admin',@pass='w23e',@rol=1