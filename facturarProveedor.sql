CREATE PROCEDURE facturarProveedor (@fechaDesde smalldatetime, @fechaHasta smalldatetime,@prov int)
as
if (SELECT sum(c1.comp_importe) FROM PASO_A_PASO.Compra c1 WHERE c1.comp_fecha between @fechaDesde and @fechaHasta AND c1.comp_factura is null) is not null
begin
INSERT INTO PASO_A_PASO.Factura VALUES (@fechaDesde,@fechaHasta,(SELECT sum(c1.comp_importe) FROM PASO_A_PASO.Compra c1 WHERE c1.comp_fecha between @fechaDesde and @fechaHasta AND c1.comp_factura is null),@prov)
UPDATE PASO_A_PASO.Compra SET comp_factura=(SELECT TOP 1 fact_id FROM PASO_A_PASO.Factura ORDER BY 1 desc) WHERE comp_fecha between @fechaDesde and @fechaHasta AND comp_factura is null
end
else
 RAISERROR('No hay compras sin facturar entre estas fechas',16,1);