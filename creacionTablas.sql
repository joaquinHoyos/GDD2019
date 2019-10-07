CREATE PROCEDURE creacionTablas
as


CREATE TABLE Usuario (user_id int NOT NULL,user_username varchar(10), user_password varchar(10), user_intentosLogin int, user_status char, user_fechaBaja smalldatetime);
CREATE TABLE Cliente (clie_id int NOT NULL, clie_dni Numeric(18,0), clie_nombre nvarchar(255),clie_apellido nvarchar(255), clie_userId int, clie_mail nvarchar(255), clie_telefono Numeric(18,0),clie_direccion nvarchar(255), clie_codigoPostal int, clie_ciudad nvarchar(255),clie_fechaNacimiento smalldatetime);
CREATE TABLE Proveedor (prov_id int NOT NULL, prov_cuit nvarchar(20), prov_razon nvarchar(100),prov_userId int, prov_mail nvarchar(255), prov_telefono Numeric(18,0),prov_direccion nvarchar(255), prov_codigoPostal int, prov_ciudad nvarchar(255),prov_rubro int, prov_nombre nvarchar(255), prov_habilitado char);
CREATE TABLE Rubro (id_rubro int NOT NULL, rubr_nombre nvarchar(100));
CREATE TABLE RolxUsuario (id_rol int, id_usuario int);
CREATE TABLE Rol (rol_id int NOT NULL, rol_nombre varchar(20));
CREATE TABLE Funcion (func_id int NOT NULL, func_nombre varchar(20));
CREATE TABLE FuncionesxRol (id_rol int, id_funcion int);
CREATE TABLE Credito (cred_id int NOT NULL, cred_cliente int, cred_tipoPago nvarchar(100), cred_fecha smalldatetime, comp_fecha smalldatetime, cred_tarjeta Numeric(10));
CREATE TABLE Cupon (cupo_id int NOT NULL, cupo_fecha smalldatetime, cupo_oferta nvarchar(50), cupo_cliente int);
CREATE TABLE Compra(comp_id int NOT NULL, comp_cupon int, comp_fecha smalldatetime, comp_factura Numeric(18,0));
CREATE TABLE Factura(fact_id Numeric(18,0) NOT NULL, fact_desde smalldatetime, fact_hasta smalldatetime, fact_importe int, fact_proveedor int);
CREATE TABLE Oferta(ofer_id nvarchar(50) NOT NULL, ofer_descripcion varchar(255), ofer_fechaDesde smalldatetime, ofer_fechaHasta smalldatetime, ofer_precioOferta Numeric(18,2), ofer_precioLista  Numeric(18,2), ofer_proveedor int, ofer_disponible Numeric(18,0));