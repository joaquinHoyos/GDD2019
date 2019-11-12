CREATE PROCEDURE PASO_A_PASO.insertarCliente (@nombre varchar(255),@apellido varchar(255),@dni numeric(18,0))AS

BEGIN

INSERT INTO PASO_A_PASO.Cliente VALUES (@dni,@nombre,@apellido,null,null,null,null,null,null,null,null)
END

SELECT * FROM  PASO_A_PASO.Cliente WHERE clie_dni = '41710122'