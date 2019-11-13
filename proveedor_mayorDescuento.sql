CREATE FUNCTION PASO_A_PASO.proveedor_mayorDescuento(@año int,@mesInicio int,@mesFin int)
RETURNS TABLE
AS
		RETURN 
		SELECT TOP 5 
		prov_id AS 'ID'
		,prov_razon AS 'Razon Social'
		,prov_cuit AS 'CUIT'
		,rubr_nombre AS 'Rubro'
		,CONVERT(DECIMAL(12,2),SUM(100*ofer_precioOferta/ofer_precioLista)/COUNT(*)) AS 'Descuento Promedio'
		,@año AS 'año'
		,CASE WHEN @mesInicio<6 THEN 1 ELSE 2 END AS 'Semestre'
		FROM PASO_A_PASO.Proveedor
		JOIN PASO_A_PASO.Oferta ON (prov_id=ofer_proveedor)
		JOIN Rubro ON (rubr_id=prov_rubro)
		WHERE YEAR(ofer_fechaDesde)=@año and MONTH(ofer_fechaDesde) BETWEEN @mesInicio AND @mesFin
		GROUP BY prov_id,prov_razon,prov_nombre,prov_cuit,rubr_nombre
		ORDER BY 'Descuento Promedio' DESC
		



						 
						  