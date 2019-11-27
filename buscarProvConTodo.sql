CREATE FUNCTION PASO_A_PASO.buscarProvConTodo(@razonSocial nvarchar(100),@mail nvarchar(255),@cuit nvarchar(20))
RETURNS TABLE
AS
RETURN (SELECT * FROM PASO_A_PASO.Proveedor WHERE (prov_razon LIKE '%'+ @razonSocial + '%' AND prov_mail LIKE '%'+ @mail+ '%') AND prov_cuit = @cuit);
