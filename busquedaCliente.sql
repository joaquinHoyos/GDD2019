CREATE FUNCTION PASO_A_PASO.buscarClie(@nombre nvarchar(100), @apellido nvarchar(100),@dni nvarchar(100),@mail nvarchar(100))
RETURNS TABLE
AS

 RETURN SELECT * FROM PASO_A_PASO.Cliente LEFT JOIN PASO_A_PASO.Usuario ON user_id = clie_userId WHERE clie_nombre LIKE '%'+ 'ELENA' + '%'



