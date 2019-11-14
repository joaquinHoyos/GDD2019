CREATE FUNCTION PASO_A_PASO.buscarProvConCuit(@cuit nvarchar(100))
RETURNS TABLE
AS

RETURN (SELECT * FROM PASO_A_PASO.Proveedor WHERE prov_cuit = @cuit)
