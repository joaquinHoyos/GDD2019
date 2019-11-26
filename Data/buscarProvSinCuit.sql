CREATE FUNCTION PASO_A_PASO.buscarProvSinMail(@razonSocial nvarchar(100))
RETURNS TABLE
AS

RETURN (SELECT * FROM PASO_A_PASO.Proveedor WHERE prov_razon LIKE '%'+ @razonSocial+'%');



