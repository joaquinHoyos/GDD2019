CREATE FUNCTION PASO_A_PASO.traerOfertasDisponibles()
RETURNS table
AS
RETURN (SELECT * FROM PASO_A_PASO.Oferta WHERE ofer_disponible>0 AND GETDATE()<ofer_fechaHasta AND GETDATE()>ofer_fechaDesde)