CREATE FUNCTION PASO_A_PASO.busquedaOferta(@descripcion nvarchar(100), @descuento int)
RETURNS TABLE
AS

 RETURN SELECT * FROM PASO_A_PASO.Oferta WHERE 
 (CASE   WHEN @descripcion IS NULL THEN  (ofer_precioOferta * 100) / ofer_PrecioLista > @descuento
		WHEN @descuento IS NULL THEN ofer_descripcion LIKE '%'+@descripcion+'%'
		ELSE ofer_precioOferta * 100 / ofer_PrecioLista > @descuento AND  ofer_descripcion LIKE '%'+@descripcion+'%'

		END