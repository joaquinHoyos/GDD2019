USE [GD2C2019]
GO

/****** Object:  Schema [PASO_A_PASO]    Script Date: 11/11/2019 12:38:50 PM ******/
CREATE SCHEMA [PASO_A_PASO]
GO

CREATE TYPE PASO_A_PASO.tablaFuncion AS TABLE (funciones varchar(20))
GO






CREATE TABLE PASO_A_PASO.Usuario (user_id int IDENTITY(1,1) NOT NULL,user_username varchar(32) UNIQUE, user_password varchar(32), user_intentosLogin int, user_status char, user_fechaBaja smalldatetime);
CREATE TABLE PASO_A_PASO.Cliente (clie_id int IDENTITY(1,1) NOT NULL, clie_dni Numeric(18,0), clie_nombre nvarchar(255),clie_apellido nvarchar(255), clie_userId int, clie_mail nvarchar(255), clie_telefono Numeric(18,0),clie_direccion nvarchar(255), clie_saldo int, clie_codigoPostal int, clie_ciudad nvarchar(255),clie_fechaNacimiento smalldatetime);
CREATE TABLE PASO_A_PASO.Proveedor (prov_id int IDENTITY(1,1) NOT NULL, prov_cuit nvarchar(20), prov_razon nvarchar(100),prov_userId int, prov_mail nvarchar(255), prov_telefono Numeric(18,0),prov_direccion nvarchar(255), prov_codigoPostal int, prov_ciudad nvarchar(255),prov_rubro int, prov_nombre nvarchar(255), prov_habilitado char);
CREATE TABLE PASO_A_PASO.Rubro (rubr_id int IDENTITY(1,1) NOT NULL, rubr_nombre nvarchar(100));
CREATE TABLE PASO_A_PASO.RolxUsuario (id_rol int NOT NULL, id_usuario int NOT NULL);
CREATE TABLE PASO_A_PASO.Rol (rol_id int IDENTITY(1,1) NOT NULL, rol_nombre varchar(20) UNIQUE ,rol_estado char(1) NOT NULL);
CREATE TABLE PASO_A_PASO.Funcion (func_id int IDENTITY(1,1) NOT NULL, func_nombre varchar(20), func_grupo char(1));
CREATE TABLE PASO_A_PASO.FuncionesxRol (id_rol int NOT NULL, id_funcion int NOT NULL);
CREATE TABLE PASO_A_PASO.Credito (cred_id int IDENTITY(1,1) NOT NULL, cred_cliente int, cred_tipoPago char(1), cred_fecha smalldatetime,  cred_tarjeta Numeric(10) , cred_monto Numeric(10));
CREATE TABLE PASO_A_PASO.Cupon (cupo_id int IDENTITY(1,1) NOT NULL, cupo_fecha smalldatetime, cupo_oferta nvarchar(50),cupo_cliente int, cupo_compra int);
CREATE TABLE PASO_A_PASO.Compra(comp_id int IDENTITY(1,1) NOT NULL,comp_oferta nvarchar(50) NOT NULL, comp_cliente int NOT NULL, comp_cantidad int,comp_factura Numeric(18,0), comp_importe int, comp_fecha smalldatetime);
CREATE TABLE PASO_A_PASO.Factura(fact_id Numeric(18,0) NOT NULL, fact_desde smalldatetime, fact_hasta smalldatetime, fact_importe int, fact_proveedor int NOT NULL);
CREATE TABLE PASO_A_PASO.Oferta(ofer_id nvarchar(50) NOT NULL, ofer_descripcion varchar(255), ofer_fechaDesde smalldatetime, ofer_fechaHasta smalldatetime, ofer_precioOferta Numeric(18,2), ofer_precioLista  Numeric(18,2), ofer_proveedor int, ofer_disponible Numeric(18,0), ofer_maxDisponible int, ofer_estado char(1))
CREATE TABLE PASO_A_PASO.TipoPago(tipoPago_id char(1) NOT NULL);




ALTER TABLE PASO_A_PASO.Usuario ADD CONSTRAINT PK_Usuario PRIMARY KEY (user_id);
ALTER TABLE PASO_A_PASO.Cliente ADD CONSTRAINT PK_Cliente PRIMARY KEY (clie_id);
ALTER TABLE PASO_A_PASO.Proveedor ADD CONSTRAINT PK_Proveedor PRIMARY KEY (prov_id);
ALTER TABLE PASO_A_PASO.Rubro ADD CONSTRAINT PK_Rubro  PRIMARY KEY (rubr_id);
ALTER TABLE PASO_A_PASO.Rol ADD CONSTRAINT PK_Rol PRIMARY KEY (rol_id);
ALTER TABLE PASO_A_PASO.RolxUsuario ADD CONSTRAINT PK_RolxUsuario PRIMARY KEY (id_rol,id_usuario);
ALTER TABLE PASO_A_PASO.Funcion ADD CONSTRAINT PK_Funcion PRIMARY KEY (func_id);
ALTER TABLE PASO_A_PASO.FuncionesxRol ADD CONSTRAINT PK_FuncionesxRol PRIMARY KEY (id_rol,id_funcion);
ALTER TABLE PASO_A_PASO.Credito ADD CONSTRAINT PK_Credito PRIMARY KEY (cred_id);
ALTER TABLE PASO_A_PASO.Cupon ADD CONSTRAINT PK_Cupon PRIMARY KEY (cupo_id);
ALTER TABLE PASO_A_PASO.Compra ADD CONSTRAINT PK_Compra PRIMARY KEY (comp_id);
ALTER TABLE PASO_A_PASO.Factura ADD CONSTRAINT PK_Factura PRIMARY KEY (fact_id);
ALTER TABLE PASO_A_PASO.Oferta ADD CONSTRAINT PK_Oferta PRIMARY KEY (ofer_id);
ALTER TABLE PASO_A_PASO.TipoPago ADD CONSTRAINT PK_TipoPago PRIMARY KEY(tipoPago_id);


ALTER TABLE PASO_A_PASO.Cliente ADD CONSTRAINT FK_Cliente_Usuario FOREIGN KEY (clie_userId) REFERENCES PASO_A_PASO.Usuario(user_id);
ALTER TABLE PASO_A_PASO.Proveedor ADD CONSTRAINT FK_Proveedor_Usuario FOREIGN KEY (prov_userId) REFERENCES PASO_A_PASO.Usuario(user_id);
ALTER TABLE PASO_A_PASO.Proveedor ADD CONSTRAINT FK_Proveedor_Rubro FOREIGN KEY (prov_rubro) REFERENCES PASO_A_PASO.Rubro(rubr_id);
ALTER TABLE PASO_A_PASO.RolxUsuario ADD CONSTRAINT FK_RolxUsuario_Usuario FOREIGN KEY (id_usuario) REFERENCES PASO_A_PASO.Usuario(user_id);
ALTER TABLE PASO_A_PASO.RolxUsuario ADD CONSTRAINT FK_RolxUsuario_Rol FOREIGN KEY (id_rol) REFERENCES PASO_A_PASO.Rol(rol_id);
ALTER TABLE PASO_A_PASO.FuncionesxRol ADD CONSTRAINT FK_FuncionesxRol_Funcion FOREIGN KEY (id_funcion) REFERENCES PASO_A_PASO.Funcion(func_id);
ALTER TABLE PASO_A_PASO.FuncionesxRol ADD CONSTRAINT FK_FuncionesxRol_Rol FOREIGN KEY (id_rol) REFERENCES PASO_A_PASO.Rol(rol_id);
ALTER TABLE PASO_A_PASO.Credito ADD CONSTRAINT FK_Credito_Cliente FOREIGN KEY (cred_cliente) REFERENCES PASO_A_PASO.Cliente(clie_id); 
ALTER TABLE PASO_A_PASO.Cupon ADD CONSTRAINT FK_Cupon_Cliente FOREIGN KEY (cupo_cliente) REFERENCES PASO_A_PASO.Cliente(clie_id);
ALTER TABLE PASO_A_PASO.Cupon ADD CONSTRAINT FK_Cupon_Oferta FOREIGN KEY (cupo_oferta) REFERENCES PASO_A_PASO.Oferta(ofer_id);
ALTER TABLE PASO_A_PASO.Cupon ADD CONSTRAINT FK_Cupon_Compra FOREIGN KEY (cupo_compra) REFERENCES PASO_A_PASO.Compra(comp_id);
ALTER TABLE PASO_A_PASO.Compra ADD CONSTRAINT FK_Compra_Factura FOREIGN KEY (comp_factura) REFERENCES PASO_A_PASO.Factura(fact_id);
ALTER TABLE PASO_A_PASO.Compra ADD CONSTRAINT FK_Compra_Cliente FOREIGN KEY (comp_cliente) REFERENCES PASO_A_PASO.Cliente(clie_id);
ALTER TABLE PASO_A_PASO.Compra ADD CONSTRAINT FK_Compra_Oferta FOREIGN KEY (comp_oferta) REFERENCES PASO_A_PASO.Oferta(ofer_id);
ALTER TABLE PASO_A_PASO.Factura ADD CONSTRAINT FK_Factura_Proveedor FOREIGN KEY (fact_proveedor) REFERENCES PASO_A_PASO.Proveedor(prov_id);
ALTER TABLE PASO_A_PASO.Oferta ADD CONSTRAINT FK_Oferta_Proveedor FOREIGN KEY (ofer_proveedor) REFERENCES PASO_A_PASO.Proveedor(prov_id);
ALTER TABLE PASO_A_PASO.Credito ADD CONSTRAINT FK_Credito_TipoPago FOREIGN KEY (cred_tipoPago) REFERENCES PASO_A_PASO.TipoPago(tipoPago_id);


CREATE UNIQUE INDEX indexCliente ON PASO_A_PASO.Cliente(clie_dni)
CREATE UNIQUE INDEX indexProveedor ON PASO_A_PASO.Proveedor(prov_razon, prov_cuit)
CREATE UNIQUE INDEX indexUsuario ON PASO_A_PASO.Usuario (user_username)




	--CREA FUNCIONES
	INSERT INTO PASO_A_PASO.Funcion VALUES ('CARGA_CREDITO','C')
	INSERT INTO PASO_A_PASO.Funcion VALUES ('COMPRAR','C')
	INSERT INTO PASO_A_PASO.Funcion VALUES ('VER_CUPON','C')
	INSERT INTO PASO_A_PASO.Funcion VALUES ('COMPARTIR_CUPON','C')
	INSERT INTO PASO_A_PASO.Funcion VALUES ('FACTURAR','A')
	INSERT INTO PASO_A_PASO.Funcion VALUES ('ABM_OFERTA','P')
	INSERT INTO PASO_A_PASO.Funcion VALUES ('VER_OFERTA','P')
	INSERT INTO PASO_A_PASO.Funcion VALUES ('ABM_USUARIO','A')
	INSERT INTO PASO_A_PASO.Funcion VALUES ('ABM_ROL','A')
	INSERT INTO PASO_A_PASO.Funcion VALUES ('ABM_CLIENTES','A')
	INSERT INTO PASO_A_PASO.Funcion VALUES ('ABM_PROVEEDOR','A')
	INSERT INTO PASO_A_PASO.Funcion VALUES ('VER_ESTADISTICAS','A')
	


	USE [GD2C2019]
GO

/****** Object:  Trigger [PASO_A_PASO].[altaCupon]    Script Date: 25/11/2019 19:16:31 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TRIGGER [PASO_A_PASO].[altaCupon] ON [PASO_A_PASO].[Compra] AFTER INSERT
AS
BEGIN
DECLARE @oferta nvarchar(50), @cliente int, @cantidad int, @compid int
DECLARE c1 CURSOR FOR  SELECT comp_oferta,comp_cliente,comp_cantidad,comp_id FROM INSERTED WHERE NOT EXISTS (SELECT * FROM gd_esquema.Maestra WHERE comp_oferta=Oferta_Codigo AND Cli_Dni=(SELECT clie_dni FROM Cliente WHERE clie_id=comp_cliente) AND Oferta_Entregado_Fecha IS NOT NULL)
OPEN c1
FETCH NEXT FROM c1 INTO @oferta,@cliente,@cantidad,@compid 
WHILE(@@FETCH_STATUS=0)
BEGIN
WHILE(@cantidad > 0)
BEGIN
INSERT INTO PASO_A_PASO.Cupon (cupo_cliente,cupo_oferta,cupo_compra,cupo_fecha) VALUES (@cliente,@oferta,@compid,'01/01/1900') 
SET @cantidad =- 1
END 
FETCH NEXT FROM c1 INTO @oferta,@cliente,@cantidad, @compid
END 
CLOSE c1
DEALLOCATE c1
END
GO



	-- CREAR ROLES
	--CREA ROL ADMINISTRADOR
	DECLARE @funcAdmin AS PASO_A_PASO.tablaFuncion
	INSERT INTO @funcAdmin SELECT func_id 
	FROM PASO_A_PASO.Funcion WHERE func_grupo='A'
	--EXEC PASO_A_PASO.crearRol @nombre='ADMINISTRADOR',@funciones=@funcAdmin
	INSERT INTO PASO_A_PASO.Rol VALUES ('ADMINISTRADOR','E')
	DECLARE @idRol AS int
	SET @idRol = IDENT_CURRENT('PASO_A_PASO.Rol')
	
	INSERT INTO PASO_A_PASO.FuncionesxRol
	SELECT @idRol,func_id
	FROM @funcAdmin
	JOIN PASO_A_PASO.Funcion ON (func_id = funciones)
	

	
	
	--CREAR ROL CLIENTE
	DECLARE @funcCli AS PASO_A_PASO.tablaFuncion
	INSERT INTO @funcCli SELECT func_id
	FROM PASO_A_PASO.Funcion WHERE func_grupo='C'
	--EXEC PASO_A_PASO.crearRol @nombre='CLIENTE',@funciones=@funcCli
	INSERT INTO PASO_A_PASO.Rol VALUES ('CLIENTE','E')
	--DECLARE @idRol AS int
	SET @idRol = IDENT_CURRENT('PASO_A_PASO.Rol')
	
	INSERT INTO PASO_A_PASO.FuncionesxRol
	SELECT @idRol,func_id
	FROM @funcCli
	JOIN PASO_A_PASO.Funcion ON (func_id = funciones)
	



	--CREAR ROL PROVEEDOR
	DECLARE @funcProv AS PASO_A_PASO.tablaFuncion
	INSERT INTO @funcProv SELECT func_id
	FROM PASO_A_PASO.Funcion WHERE func_grupo='P'
	--EXEC PASO_A_PASO.crearRol @nombre='PROVEEDOR',@funciones=@funcProv
	INSERT INTO PASO_A_PASO.Rol VALUES ('PROVEEDOR','E')
	--DECLARE @idRol AS int
	SET @idRol = IDENT_CURRENT('PASO_A_PASO.Rol')
	
	INSERT INTO PASO_A_PASO.FuncionesxRol
	SELECT @idRol,func_id
	FROM @funcProv
	JOIN PASO_A_PASO.Funcion ON (func_id = funciones)
	



	--CREAR USUARIO
	--EXEC PASO_A_PASO.crearUsuario @username='admin',@pass='w23e',@rol=1
	INSERT INTO PASO_A_PASO.Usuario VALUES ('admin',HASHBYTES('SHA2_256','w23e'),0,'E','1/1/1900')
	INSERT INTO PASO_A_PASO.RolxUsuario VALUES(1,IDENT_CURRENT('PASO_A_PASO.Usuario'))



INSERT INTO PASO_A_PASO.TipoPago VALUES ('E')
	INSERT INTO PASO_A_PASO.TipoPago VALUES ('C')
	INSERT INTO PASO_A_PASO.TipoPago VALUES ('D')


INSERT INTO PASO_A_PASO.Cliente SELECT distinct Cli_Dni, Cli_Nombre, Cli_Apellido, null, Cli_Mail, Cli_Telefono, Cli_Direccion, 0, null, Cli_Ciudad, Cli_Fecha_Nac FROM gd_esquema.Maestra;
INSERT INTO PASO_A_PASO.Rubro SELECT distinct Provee_Rubro FROM gd_esquema.Maestra;
INSERT INTO PASO_A_PASO.Proveedor SELECT distinct Provee_CUIT, Provee_RS,null,null,Provee_Telefono, Provee_Dom,null,Provee_Ciudad, rubr_id,null,'E' FROM gd_esquema.Maestra JOIN PASO_A_PASO.Rubro ON (rubr_nombre=Provee_Rubro);
INSERT INTO PASO_A_PASO.Oferta SELECT distinct Oferta_Codigo, Oferta_Descripcion,Oferta_Fecha,Oferta_Fecha_Venc, Oferta_Precio, Oferta_Precio_Ficticio, prov_id, Oferta_Cantidad, Oferta_Cantidad, 'E' FROM gd_esquema.Maestra JOIN PASO_A_PASO.Proveedor ON (prov_razon= Provee_RS AND  prov_cuit=Provee_CUIT);
INSERT INTO PASO_A_PASO.Credito 
			SELECT  clie_id,
					case when Tipo_Pago_Desc = 'Crédito' then 'C' when Tipo_Pago_Desc = 'Efectivo' then 'E' end,
					Carga_Fecha,
					null,
					Carga_Credito
			FROM gd_esquema.Maestra JOIN PASO_A_PASO.Cliente on (Cli_Dni = clie_dni)
			WHERE Tipo_Pago_Desc is not null and Carga_Fecha is not null and Carga_Credito is not null;

INSERT INTO PASO_A_PASO.Factura SELECT Factura_Nro,DATETIMEFROMPARTS(Year(Factura_Fecha),MONTH(Factura_Fecha),1,0,0,0,0),Factura_Fecha,sum(Oferta_Precio),prov_id from gd_esquema.Maestra join PASO_A_PASO.Proveedor on Provee_CUIT=prov_cuit and Provee_RS=prov_razon where Factura_Fecha is not null group by Factura_Nro,Factura_Fecha,prov_id;

INSERT INTO PASO_A_PASO.Compra SELECT t.Oferta_Codigo,c.clie_id,count(*) as cantCupones,
(SELECT t1.Factura_Nro from gd_esquema.Maestra t1 where t1.Factura_Nro is not null and t1.Cli_Dni=t.Cli_Dni and t1.Oferta_Codigo=t.Oferta_Codigo and t1.Provee_CUIT=t.Provee_CUIT and t.Oferta_Fecha_Compra=t1.Oferta_Fecha_Compra) as Faa,
sum(t.Oferta_Precio) as precioCompra, Oferta_Fecha_Compra from gd_esquema.Maestra t
join PASO_A_PASO.Cliente c on t.Cli_Dni=c.clie_dni
where t.Factura_Fecha is null and t.Factura_Nro is null and t.Oferta_Entregado_Fecha is null and t.Oferta_Codigo is not null
group by t.Oferta_Codigo,c.clie_id,t.Factura_Nro,t.Cli_Dni,t.Provee_CUIT,Oferta_Fecha_Compra

DROP TRIGGER [PASO_A_PASO].[altaCupon]
GO




CREATE TYPE PASO_A_PASO.tablaRoles AS TABLE (rol varchar(20))
GO

CREATE TYPE PASO_A_PASO.tablaCliente AS TABLE (clie_dni Numeric(18,0), clie_nombre nvarchar(255),clie_apellido nvarchar(255), clie_userId int, clie_mail nvarchar(255), clie_telefono Numeric(18,0),clie_direccion nvarchar(255), clie_saldo int, clie_codigoPostal int, clie_ciudad nvarchar(255),clie_fechaNacimiento smalldatetime)
GO

CREATE TYPE PASO_A_PASO.tablaOferta AS TABLE (ofer_id nvarchar(50), ofer_descripcion varchar(255),ofer_fechaDesde smalldatetime, ofer_fechaHasta smalldatetime, ofer_precioOferta Numeric(18,2),ofer_precioLista Numeric(18,2), ofer_proveedor int, ofer_disponible Numeric(18,0),ofer_maxDisponible int)
GO

CREATE TYPE PASO_A_PASO.tablaProveedor AS TABLE (prov_cuit nvarchar(20), prov_razon nvarchar(100),prov_userId int, prov_mail nvarchar(255), prov_telefono Numeric(18,0),prov_direccion nvarchar(255), prov_codigoPostal int, prov_ciudad nvarchar(255),prov_rubro int, prov_nombre nvarchar(255), prov_habilitado char)
GO


USE [GD2C2019]
GO

/****** Object:  StoredProcedure [PASO_A_PASO].[crearRol]    Script Date: 26/11/2019 19:16:02 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [PASO_A_PASO].[crearRol] (@nombre varchar(20),@funciones PASO_A_PASO.tablaFuncion READONLY)
AS

	INSERT INTO PASO_A_PASO.Rol VALUES (@nombre,'E')
	DECLARE @idRol AS int
	SET @idRol = IDENT_CURRENT('PASO_A_PASO.Rol')
	
	INSERT INTO PASO_A_PASO.FuncionesxRol
	SELECT @idRol,func_id
	FROM @funciones
	JOIN PASO_A_PASO.Funcion ON (func_id = funciones)
	


GO





USE [GD2C2019]
GO

/****** Object:  StoredProcedure [PASO_A_PASO].[crearUsuario]    Script Date: 26/11/2019 18:30:26 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [PASO_A_PASO].[crearUsuario] (@username varchar(32),@pass varchar(32),@rol int)
AS

	INSERT INTO Usuario VALUES (@username,HASHBYTES('SHA2_256',@pass),0,'E','1/1/1900')
	INSERT INTO RolxUsuario VALUES(@rol,IDENT_CURRENT('PASO_A_PASO.Usuario'))
	


GO


USE [GD2C2019]
GO

/****** Object:  StoredProcedure [PASO_A_PASO].[cargarCredito]    Script Date: 26/11/2019 18:32:10 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [PASO_A_PASO].[cargarCredito](@tipoPago nvarchar(10), @tarjeta numeric(10,0) , @monto numeric(10,0), @userID int, @fecha smalldatetime)
AS 
DECLARE @clieID int
SET @clieID = (SELECT clie_id FROM PASO_A_PASO.Cliente c WHERE c.clie_userId=@userID)
INSERT INTO PASO_A_PASO.Credito (cred_cliente,cred_tipoPago,cred_fecha,cred_tarjeta,cred_monto) VALUES (@clieID,@tipoPago,@fecha,@tarjeta,@monto)
GO

USE [GD2C2019]
GO

/****** Object:  StoredProcedure [PASO_A_PASO].[crearCliente]    Script Date: 26/11/2019 18:33:25 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [PASO_A_PASO].[crearCliente] (@datos PASO_A_PASO.tablaCliente READONLY)
AS
	INSERT INTO PASO_A_PASO.Cliente SELECT * FROM @datos
	


GO

USE [GD2C2019]
GO

/****** Object:  StoredProcedure [PASO_A_PASO].[crearOferta]    Script Date: 26/11/2019 18:33:59 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [PASO_A_PASO].[crearOferta] (@id nvarchar(50),@descripcion varchar(255),@fechaDesde smalldatetime,@fechaHasta smalldatetime,@precioOferta numeric(18,2),@precioLista numeric(18,2),@proveedor int,@disponible numeric(18,0),@maxDisponible int)
AS
	INSERT INTO PASO_A_PASO.Oferta VALUES (@id,@descripcion,@fechaDesde,@fechaHasta,@precioOferta,@precioLista,@proveedor,@disponible,@maxDisponible,'E')
	

GO

USE [GD2C2019]
GO

/****** Object:  StoredProcedure [PASO_A_PASO].[crearProveedor]    Script Date: 26/11/2019 18:34:17 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [PASO_A_PASO].[crearProveedor] (@datos PASO_A_PASO.tablaProveedor READONLY)
AS
	INSERT INTO PASO_A_PASO.Cliente SELECT * FROM @datos

GO

USE [GD2C2019]
GO

/****** Object:  StoredProcedure [PASO_A_PASO].[generarCompra]    Script Date: 26/11/2019 18:35:17 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [PASO_A_PASO].[generarCompra](@userID int, @oferCodigo nvarchar(50) ,@cantidad int,@fecha smalldatetime)
AS 
DECLARE @clieID int
SET @clieID = (SELECT clie_id FROM PASO_A_PASO.Cliente c WHERE c.clie_userId=@userID)
DECLARE @precioOferta numeric(18,2)
SET @precioOferta = (SELECT ofer_precioOferta FROM PASO_A_PASO.Oferta o WHERE o.ofer_id=@oferCodigo)
INSERT INTO PASO_A_PASO.Compra (comp_oferta,comp_cliente,comp_cantidad,comp_factura,comp_importe,comp_fecha) VALUES (@oferCodigo,@clieID,@cantidad,null,@cantidad * @precioOferta,@fecha)
UPDATE PASO_A_PASO.Cliente SET clie_saldo-=@cantidad * @precioOferta WHERE clie_id=@clieID;
UPDATE PASO_A_PASO.Oferta SET ofer_disponible-=@cantidad WHERE ofer_id=@oferCodigo;
DECLARE @index int = 0
WHILE @index < @cantidad
BEGIN
INSERT INTO PASO_A_PASO.Cupon (cupo_oferta, cupo_cliente,cupo_compra,cupo_fecha) VALUES (  @oferCodigo, @clieID,IDENT_CURRENT('PASO_A_PASO.Compra'), '1/1/1900')
SET @index = @index + 1
END  
GO

USE [GD2C2019]
GO

/****** Object:  StoredProcedure [PASO_A_PASO].[regalarCupon]    Script Date: 26/11/2019 18:35:36 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [PASO_A_PASO].[regalarCupon](@cuponID int, @clienteID int)
AS
UPDATE PASO_A_PASO.Cupon SET cupo_cliente = @clienteID WHERE cupo_id=@cuponID
GO


USE [GD2C2019]
GO

/****** Object:  UserDefinedFunction [PASO_A_PASO].[saldoUsuario]    Script Date: 26/11/2019 18:37:39 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE FUNCTION [PASO_A_PASO].[saldoUsuario](@idUsuario int)
RETURNS int
AS
BEGIN
RETURN (SELECT clie_saldo FROM PASO_A_PASO.Cliente WHERE clie_userId = @idUsuario)
END
GO

USE [GD2C2019]
GO

/****** Object:  UserDefinedFunction [PASO_A_PASO].[busquedaOferta]    Script Date: 27/11/2019 13:51:37 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE FUNCTION [PASO_A_PASO].[busquedaOferta](@descripcion nvarchar(100), @fecha smalldatetime, @proveedor int)
RETURNS TABLE
as
 RETURN SELECT * FROM PASO_A_PASO.Oferta WHERE ofer_proveedor=@proveedor and (@fecha between ofer_fechaDesde and ofer_fechaHasta OR  (ofer_descripcion = @descripcion AND @descripcion<>''))


GO





USE [GD2C2019]
GO

/****** Object:  UserDefinedFunction [PASO_A_PASO].[busquedaRol_Id]    Script Date: 26/11/2019 18:39:36 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE FUNCTION [PASO_A_PASO].[busquedaRol_Id](@id int)
RETURNS TABLE
AS
	RETURN
	SELECT rol_id,rol_nombre,id_funcion,func_grupo,rol_estado
	FROM PASO_A_PASO.Rol
	JOIN PASO_A_PASO.FuncionesxRol ON (rol_id = id_rol)
	JOIN PASO_A_PASO.Funcion ON (id_funcion=func_id)
	WHERE rol_id=@id



GO


USE [GD2C2019]
GO

/****** Object:  UserDefinedFunction [PASO_A_PASO].[logInUsuario]    Script Date: 26/11/2019 18:40:20 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE FUNCTION [PASO_A_PASO].[logInUsuario] (@username varchar(32),@password varchar(32))
RETURNS TABLE
AS
	RETURN SELECT * FROM PASO_A_PASO.Usuario
	WHERE user_username = @username AND user_password=HASHBYTES('SHA2_256',@password) AND user_status = 'E'


GO

USE [GD2C2019]
GO

/****** Object:  UserDefinedFunction [PASO_A_PASO].[traerClienteSegunUsuario]    Script Date: 26/11/2019 18:40:47 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE FUNCTION [PASO_A_PASO].[traerClienteSegunUsuario] ( @userID int)
RETURNS TABLE
AS
RETURN (SELECT clie_id FROM PASO_A_PASO.Cliente WHERE clie_userID = @userID)
GO


USE [GD2C2019]
GO

/****** Object:  UserDefinedFunction [PASO_A_PASO].[traerCuponesPropios]    Script Date: 26/11/2019 18:41:04 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE FUNCTION [PASO_A_PASO].[traerCuponesPropios] ( @clieID int)
RETURNS TABLE
AS
RETURN (SELECT * FROM PASO_A_PASO.Cupon WHERE cupo_cliente = @clieID)
GO


USE [GD2C2019]
GO

/****** Object:  UserDefinedFunction [PASO_A_PASO].[traerOfertasDisponibles]    Script Date: 26/11/2019 18:41:41 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE FUNCTION [PASO_A_PASO].[traerOfertasDisponibles](@fecha smalldatetime)
RETURNS table
AS
RETURN (SELECT * FROM PASO_A_PASO.Oferta WHERE ofer_disponible>0 AND @fecha<ofer_fechaHasta AND @fecha>ofer_fechaDesde AND ofer_estado = 'E')
GO


USE [GD2C2019]
GO

/****** Object:  UserDefinedFunction [PASO_A_PASO].[traerRoles]    Script Date: 26/11/2019 18:42:08 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE FUNCTION [PASO_A_PASO].[traerRoles](@usuario int)
RETURNS TABLE
AS
	RETURN SELECT id_rol FROM PASO_A_PASO.RolxUsuario
	WHERE id_usuario=@usuario

GO

USE [GD2C2019]
GO

/****** Object:  UserDefinedFunction [PASO_A_PASO].[traerFunciones]    Script Date: 26/11/2019 18:42:31 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE FUNCTION [PASO_A_PASO].[traerFunciones](@usuario int)
RETURNS TABLE
AS
	RETURN
	SELECT func_id,func_grupo 
	FROM PASO_A_PASO.Usuario us
	JOIN PASO_A_PASO.RolxUsuario ru ON (user_id=id_usuario)
	JOIN PASO_A_PASO.FuncionesxRol rf ON (ru.id_rol=rf.id_rol)
	JOIN PASO_A_PASO.Funcion ON (func_id=rf.id_funcion)
	WHERE user_id=@usuario
GO


USE [GD2C2019]
GO

/****** Object:  UserDefinedFunction [PASO_A_PASO].[busquedaRol_Todo]    Script Date: 26/11/2019 18:44:59 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE FUNCTION [PASO_A_PASO].[busquedaRol_Todo]()
RETURNS TABLE
AS
	RETURN 
	SELECT rol_id,rol_nombre,id_funcion,func_grupo,rol_estado
	FROM PASO_A_PASO.Rol
	JOIN PASO_A_PASO.FuncionesxRol ON (rol_id = id_rol)
	JOIN PASO_A_PASO.Funcion ON (id_funcion=func_id)
	
GO

USE [GD2C2019]
GO

/****** Object:  UserDefinedFunction [PASO_A_PASO].[busquedaId]    Script Date: 26/11/2019 18:46:18 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO


	CREATE FUNCTION [PASO_A_PASO].[busquedaId] (@id int)
	RETURNS TABLE
	AS
			RETURN
			SELECT rol_id,rol_nombre
			FROM PASO_A_PASO.Rol
			WHERE rol_id=@id

GO

USE [GD2C2019]
GO

/****** Object:  UserDefinedFunction [PASO_A_PASO].[busquedaRol_Nombre]    Script Date: 26/11/2019 18:46:31 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE FUNCTION [PASO_A_PASO].[busquedaRol_Nombre](@nombre varchar(20))
RETURNS TABLE
AS
	RETURN 
	SELECT rol_id,rol_nombre,id_funcion,func_grupo,rol_estado
	FROM PASO_A_PASO.Rol
	JOIN PASO_A_PASO.FuncionesxRol ON (rol_id = id_rol)
	JOIN PASO_A_PASO.Funcion ON (id_funcion=func_id)
	WHERE rol_nombre=@nombre

GO


USE [GD2C2019]
GO

/****** Object:  UserDefinedFunction [PASO_A_PASO].[busquedarRol_NombreYFuncion]    Script Date: 26/11/2019 18:46:52 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE FUNCTION [PASO_A_PASO].[busquedarRol_NombreYFuncion](@nombre varchar(20),@funcion tablaFuncion READONLY)
RETURNS TABLE
AS
	RETURN 
	SELECT rol_id,rol_nombre,id_funcion,func_grupo,rol_estado
	FROM PASO_A_PASO.Rol
	JOIN PASO_A_PASO.FuncionesxRol ON (rol_id = id_rol)
	JOIN PASO_A_PASO.Funcion ON (id_funcion=func_id)
	WHERE rol_nombre=@nombre AND id_funcion IN (SELECT * FROM @funcion)
 
GO

USE [GD2C2019]
GO

/****** Object:  UserDefinedFunction [PASO_A_PASO].[busquedaRol_Funcion]    Script Date: 26/11/2019 18:47:55 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE FUNCTION [PASO_A_PASO].[busquedaRol_Funcion](@funcion tablaFuncion READONLY)
RETURNS TABLE
AS
	RETURN 
	SELECT rol_id,rol_nombre,id_funcion,func_grupo,rol_estado
	FROM PASO_A_PASO.Rol
	JOIN PASO_A_PASO.FuncionesxRol ON (rol_id = id_rol)
	JOIN PASO_A_PASO.Funcion ON (id_funcion=func_id)
	WHERE id_funcion in (SELECT * FROM @funcion)
 



GO

USE [GD2C2019]
GO

/****** Object:  UserDefinedFunction [PASO_A_PASO].[busquedaRol_IdYFuncion]    Script Date: 26/11/2019 18:48:24 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE FUNCTION [PASO_A_PASO].[busquedaRol_IdYFuncion](@id int,@funcion tablaFuncion READONLY)
RETURNS TABLE
AS
	RETURN 
	SELECT rol_id,rol_nombre,id_funcion,func_grupo,rol_estado
	FROM PASO_A_PASO.Rol
	JOIN PASO_A_PASO.FuncionesxRol ON (rol_id = id_rol)
	JOIN PASO_A_PASO.Funcion ON (id_funcion=func_id)
	WHERE rol_id=@id and id_funcion IN (SELECT * FROM @funcion)
 
GO

USE [GD2C2019]
GO

/****** Object:  UserDefinedFunction [PASO_A_PASO].[busquedaRol_IdYNombre]    Script Date: 26/11/2019 18:48:41 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE FUNCTION [PASO_A_PASO].[busquedaRol_IdYNombre](@id int,@nombre varchar(20))
RETURNS TABLE
AS
	RETURN 
	SELECT rol_id,rol_nombre,id_funcion,func_grupo,rol_estado
	FROM PASO_A_PASO.Rol
	JOIN PASO_A_PASO.FuncionesxRol ON (rol_id = id_rol)
	JOIN PASO_A_PASO.Funcion ON (id_funcion=func_id)
	WHERE rol_nombre=@nombre AND rol_id=@id
 
GO


USE [GD2C2019]
GO

/****** Object:  Trigger [PASO_A_PASO].[aumentar_sueldo]    Script Date: 26/11/2019 18:36:42 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TRIGGER [PASO_A_PASO].[aumentar_sueldo] ON [PASO_A_PASO].[Credito] AFTER INSERT
AS
DECLARE @saldoAAumentar int, @idCliente int, @saldoActual int
DECLARE C1 CURSOR FOR (SELECT cred_cliente, cred_monto FROM Inserted)
OPEN C1
FETCH NEXT FROM C1 INTO @idCliente,@saldoAAumentar
WHILE @@FETCH_STATUS =0
BEGIN
SET @saldoActual = (SELECT clie_saldo FROM PASO_A_PASO.Cliente WHERE clie_id =@idCliente)
UPDATE PASO_A_PASO.Cliente SET clie_saldo=@saldoActual+@saldoAAumentar WHERE clie_id = @idCliente
FETCH NEXT FROM C1 INTO @idCliente, @saldoAAumentar
END
CLOSE C1
DEALLOCATE C1
GO


USE [GD2C2019]
GO

/****** Object:  StoredProcedure [PASO_A_PASO].[facturarProveedor]    Script Date: 26/11/2019 18:52:58 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [PASO_A_PASO].[facturarProveedor] (@fechaDesde smalldatetime, @fechaHasta smalldatetime,@prov int)
as
if (SELECT sum(c1.comp_importe) FROM PASO_A_PASO.Compra c1 WHERE c1.comp_fecha between @fechaDesde and @fechaHasta AND c1.comp_factura is null) is not null
begin
INSERT INTO PASO_A_PASO.Factura (fact_desde,fact_hasta,fact_importe,fact_proveedor) VALUES (@fechaDesde,@fechaHasta,(SELECT sum(c1.comp_importe) FROM PASO_A_PASO.Compra c1 WHERE c1.comp_fecha between @fechaDesde and @fechaHasta AND c1.comp_factura is null),@prov)
UPDATE PASO_A_PASO.Compra SET comp_factura=(SELECT TOP 1 fact_id FROM PASO_A_PASO.Factura ORDER BY 1 desc) WHERE comp_fecha between @fechaDesde and @fechaHasta AND comp_factura is null
end
else
 RAISERROR('No hay compras sin facturar entre estas fechas',16,1);
GO


USE [GD2C2019]
GO

/****** Object:  UserDefinedFunction [PASO_A_PASO].[proveedor_masFacturas]    Script Date: 26/11/2019 18:53:31 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE FUNCTION [PASO_A_PASO].[proveedor_masFacturas](@año int,@mesInicio int,@mesFin int)
RETURNS TABLE
AS
	RETURN
	SELECT TOP 5 
	prov_id AS 'ID'
	,prov_razon AS 'Razon Social'
	,prov_cuit AS 'CUIT'
	,rubr_nombre AS 'Rubro'
	,SUM(comp_cantidad) AS 'Cantidad de Compras'
	,@año AS 'año'
	,CASE WHEN @mesInicio<6 THEN 1 ELSE 2 END AS 'Semestre'
	FROM PASO_A_PASO.Proveedor
	JOIN PASO_A_PASO.Rubro ON (rubr_id=prov_rubro)
	JOIN PASO_A_PASO.Oferta ON (prov_id=ofer_proveedor)
	JOIN PASO_A_PASO.Compra ON (comp_oferta=ofer_id)
	WHERE YEAR(ofer_fechaDesde)=@año and MONTH(ofer_fechaDesde) BETWEEN @mesInicio AND @mesFin
	GROUP BY prov_id,prov_razon,prov_cuit,rubr_nombre
	ORDER BY 'Cantidad de Compras' DESC
		
--select prov_razon from PASO_A_PASO.Proveedor
GO


USE [GD2C2019]
GO

/****** Object:  UserDefinedFunction [PASO_A_PASO].[proveedor_mayorDescuento]    Script Date: 26/11/2019 18:53:52 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE FUNCTION [PASO_A_PASO].[proveedor_mayorDescuento](@año int,@mesInicio int,@mesFin int)
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
		



						 
						  
GO


USE [GD2C2019]
GO

/****** Object:  StoredProcedure [PASO_A_PASO].[insertarCliente]    Script Date: 26/11/2019 18:56:38 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [PASO_A_PASO].[insertarCliente] (@nombre varchar(255),@apellido varchar(255),@dni numeric(18,0),@user_id int, @mail nvarchar(255),@telefono numeric(18,0),@direccion nvarchar(255),@saldo int,@codPostal int, @ciudad nvarchar(255),@fechaNac smalldatetime)AS

BEGIN

INSERT INTO PASO_A_PASO.Cliente VALUES (@dni,@nombre,@apellido,null,@mail,@telefono,@direccion,@saldo,@codPostal,@ciudad,@fechaNac)
END




GO


USE [GD2C2019]
GO

/****** Object:  UserDefinedFunction [PASO_A_PASO].[buscarClieSinDni]    Script Date: 26/11/2019 18:57:09 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE FUNCTION [PASO_A_PASO].[buscarClieSinDni](@nombre nvarchar(100), @apellido nvarchar(100),@mail nvarchar(100))
RETURNS TABLE
AS

 RETURN SELECT * FROM PASO_A_PASO.Cliente WHERE clie_nombre LIKE '%'+ @nombre + '%' OR clie_apellido LIKE '%'+ @apellido + '%' OR clie_mail LIKE '%'+ @mail + '%'




GO


USE [GD2C2019]
GO

/****** Object:  Trigger [PASO_A_PASO].[saldoInicial]    Script Date: 26/11/2019 18:57:41 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TRIGGER [PASO_A_PASO].[saldoInicial] ON [PASO_A_PASO].[Cliente] AFTER INSERT
AS
INSERT INTO PASO_A_PASO.Credito (cred_cliente,cred_monto,cred_fecha,cred_tarjeta,cred_tipoPago) VALUES ((SELECT clie_id FROM inserted),200,GETDATE(), null,null)
GO


USE [GD2C2019]
GO

/****** Object:  StoredProcedure [PASO_A_PASO].[modificarCliente]    Script Date: 26/11/2019 18:59:23 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [PASO_A_PASO].[modificarCliente] (@clie_id int,@nombre nvarchar(255),@apellido nvarchar(255),@dni numeric(18,0),@user_id int, @mail nvarchar(255),@telefono numeric(18,0),@direccion nvarchar(255),@saldo int,@codPostal int, @ciudad nvarchar(255),@fechaNac smalldatetime)AS

BEGIN

UPDATE PASO_A_PASO.Cliente SET clie_dni = @dni,
							   clie_nombre=@nombre,
							   clie_apellido=@apellido,
							   clie_mail=@mail,
							   clie_telefono=@telefono,
							   clie_direccion=@direccion,
							   clie_saldo=@saldo,
							   clie_codigoPostal=@codPostal,
							   clie_ciudad=@ciudad,
							   clie_fechaNacimiento=@fechaNac

							WHERE clie_id = @clie_id

END

GO


USE [GD2C2019]
GO

/****** Object:  StoredProcedure [PASO_A_PASO].[deshabilitarCliente]    Script Date: 26/11/2019 18:59:38 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [PASO_A_PASO].[deshabilitarCliente](@clie_id int) AS
BEGIN

DECLARE @user_id_del_cliente int

SET @user_id_del_cliente = (SELECT user_id FROM PASO_A_PASO.Cliente JOIN PASO_A_PASO.Usuario ON user_id = clie_userId WHERE clie_id=@clie_id)

UPDATE PASO_A_PASO.Usuario SET user_status = 'D' WHERE user_id=@user_id_del_cliente

END
GO


USE [GD2C2019]
GO

/****** Object:  StoredProcedure [PASO_A_PASO].[asignarUsuarioACliente]    Script Date: 26/11/2019 18:59:57 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [PASO_A_PASO].[asignarUsuarioACliente](@clie_id int,@username varchar(32),@pass varchar(32), @roles PASO_A_PASO.tablaRoles READONLY)
AS
BEGIN


	DECLARE @id_roles_nuevo TABLE(id_rol int)
	INSERT INTO @id_roles_nuevo SELECT rol_id FROM PASO_A_PASO.Rol WHERE rol_nombre IN (SELECT rol FROM @roles)


	INSERT INTO Usuario VALUES (@username,HASHBYTES('SHA2_256',@pass),0,'E','1/1/1900')
	
	DECLARE @id_usuario_nuevo int
	SET @id_usuario_nuevo = (SELECT user_id FROM  PASO_A_PASO.Usuario WHERE user_username = @username)
	

	INSERT INTO PASO_A_PASO.RolxUsuario 
	SELECT id_rol,@id_usuario_nuevo FROM @id_roles_nuevo

	UPDATE PASO_A_PASO.Cliente SET clie_userId = @id_usuario_nuevo WHERE clie_id = @clie_id
	

END

GO


USE [GD2C2019]
GO

/****** Object:  StoredProcedure [PASO_A_PASO].[inicioFallido]    Script Date: 26/11/2019 19:00:46 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [PASO_A_PASO].[inicioFallido](@user varchar(32))
AS
BEGIN
IF(EXISTS(SELECT * FROM PASO_A_PASO.Usuario WHERE user_username = @user AND user_status='E'))
BEGIN
IF((SELECT user_intentosLogin FROM PASO_A_PASO.Usuario WHERE user_username = @user)<2)
UPDATE PASO_A_PASO.Usuario SET user_intentosLogin += 1 WHERE user_username = @user
ELSE
UPDATE PASO_A_PASO.Usuario SET user_status='D' WHERE (user_username = @user)
END
END
GO


USE [GD2C2019]
GO

/****** Object:  StoredProcedure [PASO_A_PASO].[inicioValido]    Script Date: 26/11/2019 19:01:03 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO


CREATE PROCEDURE [PASO_A_PASO].[inicioValido](@user varchar(32))
AS
UPDATE PASO_A_PASO.Usuario SET user_intentosLogin = 0 WHERE user_username = @user



GO


USE [GD2C2019]
GO

/****** Object:  UserDefinedFunction [PASO_A_PASO].[buscarProvSinCuit]    Script Date: 26/11/2019 19:03:06 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE FUNCTION [PASO_A_PASO].[buscarProvSinCuit](@razonSocial nvarchar(100),@mail nvarchar(255))
RETURNS TABLE
AS

RETURN (SELECT * FROM PASO_A_PASO.Proveedor WHERE prov_razon LIKE '%'+ @razonSocial + '%' OR prov_mail LIKE '%'+ @mail + '%')





GO


USE [GD2C2019]
GO

/****** Object:  UserDefinedFunction [PASO_A_PASO].[buscarProvConCuit]    Script Date: 26/11/2019 19:03:23 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE FUNCTION [PASO_A_PASO].[buscarProvConCuit](@cuit nvarchar(100))
RETURNS TABLE
AS

RETURN (SELECT * FROM PASO_A_PASO.Proveedor WHERE prov_cuit = @cuit)

GO




USE [GD2C2019]
GO

/****** Object:  UserDefinedFunction [PASO_A_PASO].[buscarClieConDni]    Script Date: 26/11/2019 19:04:12 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE FUNCTION [PASO_A_PASO].[buscarClieConDni](@dni numeric(18,0))
RETURNS TABLE
AS

RETURN (SELECT * FROM PASO_A_PASO.Cliente WHERE clie_dni = @dni)

GO




USE [GD2C2019]
GO

/****** Object:  StoredProcedure [PASO_A_PASO].[deshabilitarProveedor]    Script Date: 27/11/2019 13:50:44 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [PASO_A_PASO].[deshabilitarProveedor](@prov_id int) AS
BEGIN

DECLARE @user_id_prov int

SET @user_id_prov = (SELECT user_id FROM PASO_A_PASO.Proveedor JOIN PASO_A_PASO.Usuario ON user_id = prov_userId WHERE prov_id=@prov_id)

UPDATE PASO_A_PASO.Usuario SET user_status = 'D' WHERE user_id=@user_id_prov

END
GO




USE [GD2C2019]
GO

/****** Object:  StoredProcedure [PASO_A_PASO].[deshabilitarRol]    Script Date: 26/11/2019 19:08:52 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [PASO_A_PASO].[deshabilitarRol](@rol int)
AS
	UPDATE PASO_A_PASO.Rol  SET rol_estado='D' WHERE rol_id=@rol

GO


USE [GD2C2019]
GO

/****** Object:  StoredProcedure [PASO_A_PASO].[modificarDatosUsuario]    Script Date: 27/11/2019 13:40:45 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [PASO_A_PASO].[modificarDatosUsuario](@user varchar(32),@pass varchar(32),@intentos int,@id int)
AS
	IF @pass IS NULL
	BEGIN
		UPDATE PASO_A_PASO.Usuario 
		SET user_username=@user,
		user_intentosLogin=@intentos
		WHERE user_id=@id
	END
	ELSE
	BEGIN
		UPDATE PASO_A_PASO.Usuario 
		SET user_username=@user,
		user_intentosLogin=@intentos,
		user_password=HASHBYTES('SHA2_256',@pass)
		WHERE user_id=@id
	END
GO


USE [GD2C2019]
GO

/****** Object:  UserDefinedFunction [PASO_A_PASO].[buscarClieConTodo]    Script Date: 27/11/2019 13:45:38 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE FUNCTION [PASO_A_PASO].[buscarClieConTodo](@nombre nvarchar(100), @apellido nvarchar(100),@mail nvarchar(100),@clie_dni numeric(18,8))
RETURNS TABLE
AS

 RETURN SELECT * FROM PASO_A_PASO.Cliente WHERE (clie_nombre LIKE '%'+ @nombre + '%' OR clie_apellido LIKE '%'+ @apellido + '%' OR clie_mail LIKE '%'+ @mail + '%')
 AND clie_dni = @clie_dni
GO


USE [GD2C2019]
GO

/****** Object:  UserDefinedFunction [PASO_A_PASO].[buscarProvConTodo]    Script Date: 27/11/2019 13:46:19 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE FUNCTION [PASO_A_PASO].[buscarProvConTodo](@razonSocial nvarchar(100),@mail nvarchar(255),@cuit nvarchar(20))
RETURNS TABLE
AS
RETURN (SELECT * FROM PASO_A_PASO.Proveedor WHERE (prov_razon LIKE '%'+ @razonSocial + '%' AND prov_mail LIKE '%'+ @mail+ '%') AND prov_cuit = @cuit);

GO


USE [GD2C2019]
GO

/****** Object:  StoredProcedure [PASO_A_PASO].[canjearCupon]    Script Date: 27/11/2019 13:48:50 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [PASO_A_PASO].[canjearCupon](@cupon int, @fecha smalldatetime)
AS
UPDATE PASO_A_PASO.Cupon SET cupo_fecha = @fecha WHERE cupo_id=@cupon
GO


USE [GD2C2019]
GO

/****** Object:  StoredProcedure [PASO_A_PASO].[habilitarProveedor]    Script Date: 27/11/2019 13:49:11 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [PASO_A_PASO].[habilitarProveedor](@prov_id int) AS
BEGIN

DECLARE @user_id_prov int

SET @user_id_prov = (SELECT user_id FROM PASO_A_PASO.Proveedor JOIN PASO_A_PASO.Usuario ON user_id = prov_userId WHERE prov_id=@prov_id)

UPDATE PASO_A_PASO.Usuario SET user_status = 'E' WHERE user_id=@user_id_prov
UPDATE PASO_A_PASO.Proveedor SET prov_habilitado = 'E' WHERE prov_id=@prov_id
END
GO




