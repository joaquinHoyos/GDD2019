CREATE FUNCTION PASO_A_PASO.busquedaOferta(@descripcion nvarchar(100), @fecha smalldatetime, @proveedor int)
RETURNS TABLE
as
 RETURN SELECT * FROM PASO_A_PASO.Oferta WHERE ofer_proveedor=@proveedor and (@fecha between ofer_fechaDesde and ofer_fechaHasta OR  (ofer_descripcion = @descripcion AND @descripcion<>''))

