CREATE PROCEDURE PASO_A_PASO.modificarCliente (@clie_id int,@nombre nvarchar(255),@apellido nvarchar(255),@dni numeric(18,0),@user_id int, @mail nvarchar(255),@telefono numeric(18,0),@direccion nvarchar(255),@saldo int,@codPostal int, @ciudad nvarchar(255),@fechaNac smalldatetime)AS

BEGIN

UPDATE PASO_A_PASO.Cliente SET clie_dni = @dni,
							   clie_nombre=@nombre,
							   clie_apellido=@apellido,
							   clie_mail=@mail,
							   clie_telefono=@telefono,
							   clie_direccion=@direccion,
							   clie_saldo=@saldo,
							   clie_codigoPostal=@codPostal,
							   clie_ciudad=@ciudad,
							   clie_fechaNacimiento=@fechaNac

							WHERE clie_id = @clie_id

END
