USE GD2C2019
GO
--CREATE SCHEMA PASO_A_PASO AUTHORIZATION gdCupon2019
--GO

CREATE PROCEDURE PASO_A_PASO.migracionTablas
as

INSERT INTO PASO_A_PASO.Cliente SELECT distinct Cli_Dni, Cli_Nombre, Cli_Apellido, null, Cli_Mail, Cli_Telefono, Cli_Direccion, 0, null, Cli_Ciudad, Cli_Fecha_Nac FROM gd_esquema.Maestra;
INSERT INTO PASO_A_PASO.Rubro SELECT distinct Provee_Rubro FROM gd_esquema.Maestra;
INSERT INTO PASO_A_PASO.Proveedor SELECT distinct Provee_CUIT, Provee_RS,null,null,Provee_Telefono, Provee_Dom,null,Provee_Ciudad, rubr_id,null,1 FROM gd_esquema.Maestra JOIN PASO_A_PASO.Rubro ON (rubr_nombre=Provee_Rubro);
INSERT INTO PASO_A_PASO.Oferta SELECT distinct Oferta_Codigo, Oferta_Descripcion,Oferta_Fecha,Oferta_Fecha_Venc, Oferta_Precio, Oferta_Precio_Ficticio, prov_id, Oferta_Cantidad, Oferta_Cantidad FROM gd_esquema.Maestra JOIN PASO_A_PASO.Proveedor ON (prov_razon= Provee_RS AND  prov_cuit=Provee_CUIT);
INSERT INTO PASO_A_PASO.Credito 
			SELECT  clie_id,
					case when Tipo_Pago_Desc = 'Crédito' then 'C' when Tipo_Pago_Desc = 'Efectivo' then 'E' end,
					Carga_Fecha,
					null,
					Carga_Credito
			FROM gd_esquema.Maestra JOIN PASO_A_PASO.Cliente on (Cli_Dni = clie_dni)
			WHERE Tipo_Pago_Desc is not null and Carga_Fecha is not null and Carga_Credito is not null;
INSERT INTO PASO_A_PASO.Factura SELECT Factura_Nro,DATETIMEFROMPARTS(Year(Factura_Fecha),MONTH(Factura_Fecha),1,0,0,0,0),Factura_Fecha,sum(Oferta_Precio),prov_id from gd_esquema.Maestra join PASO_A_PASO.Proveedor on Provee_CUIT=prov_cuit and Provee_RS=prov_razon where Factura_Fecha is not null group by Factura_Nro,Factura_Fecha,prov_id
INSERT INTO PASO_A_PASO.Compra SELECT t.Oferta_Codigo,c.clie_id,count(*) as cantCupones,
(SELECT t1.Factura_Nro from gd_esquema.Maestra t1 where t1.Factura_Nro is not null and t1.Cli_Dni=t.Cli_Dni and t1.Oferta_Codigo=t.Oferta_Codigo and t1.Provee_CUIT=t.Provee_CUIT and t.Oferta_Fecha_Compra=t1.Oferta_Fecha_Compra) as Faa,
sum(t.Oferta_Precio) as precioCompra from gd_esquema.Maestra t
join PASO_A_PASO.Cliente c on t.Cli_Dni=c.clie_dni
where t.Factura_Fecha is null and t.Factura_Nro is null and t.Oferta_Entregado_Fecha is null and t.Oferta_Codigo is not null
group by t.Oferta_Codigo,c.clie_id,t.Factura_Nro,t.Cli_Dni,t.Provee_CUIT,Oferta_Fecha_Compra

