CREATE FUNCTION PASO_A_PASO.traerOfertasDisponibles(@fecha smalldatetime)
RETURNS table
AS
RETURN (SELECT * FROM PASO_A_PASO.Oferta WHERE ofer_disponible>0 AND @fecha<ofer_fechaHasta AND @fecha>ofer_fechaDesde)