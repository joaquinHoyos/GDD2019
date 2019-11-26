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
DECLARE @oferta nvarchar(50), @cliente int, @cantidad int
DECLARE c1 CURSOR FOR  SELECT comp_oferta,comp_cliente,comp_cantidad FROM INSERTED WHERE NOT EXISTS (SELECT * FROM gd_esquema.Maestra WHERE comp_oferta=Oferta_Codigo AND Cli_Dni=(SELECT clie_dni FROM Cliente WHERE clie_id=comp_cliente) AND Oferta_Entregado_Fecha IS NOT NULL)
OPEN c1
FETCH NEXT FROM c1 INTO @oferta,@cliente,@cantidad 
WHILE(@@FETCH_STATUS=0)
BEGIN
WHILE(@cantidad > 0)
BEGIN
INSERT INTO PASO_A_PASO.Cupon (cupo_cliente,cupo_oferta,cupo_fecha) VALUES (@cliente,@oferta,'01/01/1900') 
SET @cantidad =- 1
END 
FETCH NEXT FROM c1 INTO @oferta,@cliente,@cantidad
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

INSERT INTO PASO_A_PASO.Factura SELECT Factura_Nro,DATETIMEFROMPARTS(Year(Factura_Fecha),MONTH(Factura_Fecha),1,0,0,0,0),Factura_Fecha,sum(Oferta_Precio),prov_id from gd_esquema.Maestra join PASO_A_PASO.Proveedor on Provee_CUIT=prov_cuit and Provee_RS=prov_razon where Factura_Fecha is not null group by Factura_Nro,Factura_Fecha,prov_id;

INSERT INTO PASO_A_PASO.Compra SELECT t.Oferta_Codigo,c.clie_id,count(*) as cantCupones,
(SELECT t1.Factura_Nro from gd_esquema.Maestra t1 where t1.Factura_Nro is not null and t1.Cli_Dni=t.Cli_Dni and t1.Oferta_Codigo=t.Oferta_Codigo and t1.Provee_CUIT=t.Provee_CUIT and t.Oferta_Fecha_Compra=t1.Oferta_Fecha_Compra) as Faa,
sum(t.Oferta_Precio) as precioCompra, Oferta_Fecha_Compra from gd_esquema.Maestra t
join PASO_A_PASO.Cliente c on t.Cli_Dni=c.clie_dni
where t.Factura_Fecha is null and t.Factura_Nro is null and t.Oferta_Entregado_Fecha is null and t.Oferta_Codigo is not null
group by t.Oferta_Codigo,c.clie_id,t.Factura_Nro,t.Cli_Dni,t.Provee_CUIT,Oferta_Fecha_Compra

DROP TRIGGER [PASO_A_PASO].[altaCupon]
GO