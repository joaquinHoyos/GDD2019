CREATE FUNCTION PASO_A_PASO.buscarClieSinDni(@nombre nvarchar(100), @apellido nvarchar(100),@mail nvarchar(100))
RETURNS TABLE
AS

 RETURN SELECT * FROM PASO_A_PASO.Cliente WHERE clie_nombre LIKE '%'+ @nombre + '%' OR clie_apellido LIKE '%'+ @apellido + '%' OR clie_mail LIKE '%'+ @mail + '%'



