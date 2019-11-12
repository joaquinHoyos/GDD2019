CREATE PROCEDURE PASO_A_PASO.crearOferta (@id nvarchar(50),@descripcion varchar(255),@fechaDesde smalldatetime,@fechaHasta smalldatetime,@precioOferta numeric(18,2),@precioLista numeric(18,2),@proveedor int,@disponible numeric(18,0),@maxDisponible int)
AS
	INSERT INTO PASO_A_PASO.Oferta VALUES (@id,@descripcion,@fechaDesde,@fechaHasta,@precioOferta,@precioLista,@proveedor,@disponible,@maxDisponible)
	

