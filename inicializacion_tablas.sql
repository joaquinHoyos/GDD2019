CREATE PROCEDURE PASO_A_PASO.inicializacion_tablas
AS
	--CREA FUNCIONES
	INSERT INTO PASO_A_PASO.Funcion VALUES ('CARGA_CREDITO','C')
	INSERT INTO PASO_A_PASO.Funcion VALUES ('COMPRAR','C')
	INSERT INTO PASO_A_PASO.Funcion VALUES ('VER_CUPON','C')
	INSERT INTO PASO_A_PASO.Funcion VALUES ('COMPARTIR_CUPON','C')
	INSERT INTO PASO_A_PASO.Funcion VALUES ('FACTURAR','P')
	INSERT INTO PASO_A_PASO.Funcion VALUES ('ABM_OFERTA','P')
	INSERT INTO PASO_A_PASO.Funcion VALUES ('VER_OFERTA','P')
	INSERT INTO PASO_A_PASO.Funcion VALUES ('ABM_USUARIO','A')
	INSERT INTO PASO_A_PASO.Funcion VALUES ('ABM_ROL','A')

	
	-- CREAR ROLES
	--CREA ROL ADMINISTRADOR
	DECLARE @funcAdmin AS tablaFuncion
	
	INSERT INTO @funcAdmin SELECT func_nombre 
	FROM PASO_A_PASO.Funcion WHERE func_grupo='A'
	
	EXEC PASO_A_PASO.crearRol @nombre='ADMINISTRADOR',@funciones=@funcAdmin
	
	INSERT INTO PASO_A_PASO.FuncionesxRol SELECT 1,func_id FROM PASO_A_PASO.Funcion WHERE func_grupo='A'
	--CREAR ROL CLIENTE
	DECLARE @funcCli AS tablaFuncion
	
	INSERT INTO @funcCli SELECT func_nombre 
	FROM PASO_A_PASO.Funcion WHERE func_grupo='C'
	
	EXEC PASO_A_PASO.crearRol @nombre='CLIENTE',@funciones=@funcCli
	
	INSERT INTO PASO_A_PASO.FuncionesxRol SELECT 2,func_id FROM PASO_A_PASO.Funcion WHERE func_grupo='C'
	--CREAR ROL PROVEEDOR
	DECLARE @funcProv AS tablaFuncion
	
	INSERT INTO @funcProv SELECT func_nombre 
	FROM PASO_A_PASO.Funcion WHERE func_grupo='A'
	
	EXEC PASO_A_PASO.crearRol @nombre='PROVEEDOR',@funciones=@funcProv
	
	INSERT INTO PASO_A_PASO.FuncionesxRol  SELECT 3,func_id FROM PASO_A_PASO.Funcion WHERE func_grupo='P'
	Select * from PASO_A_PASO.Funcion

	DELETE FROM PASO_A_PASO.Funcion WHERE func_id>9
	
	--CREAR USUARIO	
	EXEC PASO_A_PASO.crearUsuario @username='admin',@pass='w23e',@rol=1
	

	
