CREATE FUNCTION PASO_A_PASO.buscarProvSinRazon(@mail nvarchar(255))
RETURNS TABLE
AS

RETURN (SELECT * FROM PASO_A_PASO.Proveedor WHERE prov_mail LIKE '%'+ @mail+ '%');
