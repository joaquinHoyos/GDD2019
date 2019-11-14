CREATE FUNCTION PASO_A_PASO.buscarProvSinCuit(@razonSocial nvarchar(100),@mail nvarchar(255))
RETURNS TABLE
AS

RETURN (SELECT * FROM PASO_A_PASO.Proveedor WHERE prov_razon LIKE '%'+ @razonSocial + '%' OR prov_mail LIKE '%'+ @mail + '%')




