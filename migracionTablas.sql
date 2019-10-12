CREATE PROCEDURE migracionTablas
as

INSERT INTO Cliente SELECT distinct Cli_Dni, Cli_Nombre, Cli_Apellido, null, Cli_Mail, Cli_Telefono, Cli_Direccion, 0, null, Cli_Ciudad, Cli_Fecha_Nac FROM gd_esquema.Maestra;
INSERT INTO Rubro SELECT distinct Provee_Rubro FROM gd_esquema.Maestra;
INSERT INTO Proveedor SELECT distinct Provee_CUIT, Provee_RS,null,null,Provee_Telefono, Provee_Dom,null,Provee_Ciudad, rubr_id,null,1 FROM gd_esquema.Maestra JOIN Rubro ON (rubr_nombre=Provee_Rubro);
INSERT INTO Oferta SELECT distinct Oferta_Codigo, Oferta_Descripcion,Oferta_Fecha,Oferta_Fecha_Venc, Oferta_Precio, Oferta_Precio_Ficticio, prov_id, Oferta_Cantidad, Oferta_Cantidad FROM gd_esquema.Maestra JOIN Proveedor ON (prov_razon= Provee_RS AND  prov_cuit=Provee_CUIT);
