CREATE PROCEDURE PASO_A_PASO.insertarCliente (@nombre varchar(255),@apellido varchar(255),@dni numeric(18,0),@user_id int, @mail nvarchar(255),@telefono numeric(18,0),@direccion nvarchar(255),@saldo int,@codPostal int, @ciudad nvarchar(255),@fechaNac smalldatetime)AS

BEGIN

INSERT INTO PASO_A_PASO.Cliente VALUES (@dni,@nombre,@apellido,null,@mail,@telefono,@direccion,@saldo,@codPostal,@ciudad,@fechaNac)
END



