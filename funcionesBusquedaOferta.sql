CREATE FUNCTION PASO_A_PASO.busquedaOferta(@descripcion nvarchar(100), @fecha smalldatetime)
RETURNS TABLE
AS

 RETURN SELECT * FROM PASO_A_PASO.Oferta WHERE @fecha between ofer_fechaDesde and ofer_fechaHasta AND  ofer_descripcion LIKE '%'+@descripcion+'%'
		
		