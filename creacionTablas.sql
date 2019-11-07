CREATE PROCEDURE PASO_A_PASO.creacionTablas
as

CREATE TABLE PASO_A_PASO.Usuario (user_id int IDENTITY(1,1) NOT NULL,user_username varchar(32) UNIQUE, user_password varchar(32), user_intentosLogin int, user_status char, user_fechaBaja smalldatetime);
CREATE TABLE PASO_A_PASO.Cliente (clie_id int IDENTITY(1,1) NOT NULL, clie_dni Numeric(18,0), clie_nombre nvarchar(255),clie_apellido nvarchar(255), clie_userId int, clie_mail nvarchar(255), clie_telefono Numeric(18,0),clie_direccion nvarchar(255), clie_saldo int, clie_codigoPostal int, clie_ciudad nvarchar(255),clie_fechaNacimiento smalldatetime);
CREATE TABLE PASO_A_PASO.Proveedor (prov_id int IDENTITY(1,1) NOT NULL, prov_cuit nvarchar(20), prov_razon nvarchar(100),prov_userId int, prov_mail nvarchar(255), prov_telefono Numeric(18,0),prov_direccion nvarchar(255), prov_codigoPostal int, prov_ciudad nvarchar(255),prov_rubro int, prov_nombre nvarchar(255), prov_habilitado char);
CREATE TABLE PASO_A_PASO.Rubro (rubr_id int IDENTITY(1,1) NOT NULL, rubr_nombre nvarchar(100));
CREATE TABLE PASO_A_PASO.RolxUsuario (id_rol int NOT NULL, id_usuario int NOT NULL);
CREATE TABLE PASO_A_PASO.Rol (rol_id int IDENTITY(1,1) NOT NULL, rol_nombre varchar(20));
CREATE TABLE PASO_A_PASO.Funcion (func_id int IDENTITY(1,1) NOT NULL, func_nombre varchar(20), func_grupo char(1));
CREATE TABLE PASO_A_PASO.FuncionesxRol (id_rol int NOT NULL, id_funcion int NOT NULL);
CREATE TABLE PASO_A_PASO.Credito (cred_id int IDENTITY(1,1) NOT NULL, cred_cliente int, cred_tipoPago char(1), cred_fecha smalldatetime,  cred_tarjeta Numeric(10) , cred_monto Numeric(10));
CREATE TABLE PASO_A_PASO.Cupon (cupo_id int IDENTITY(1,1) NOT NULL, cupo_fecha smalldatetime, cupo_oferta nvarchar(50),cupo_cliente int, cupo_compra int);
CREATE TABLE PASO_A_PASO.Compra(comp_id int IDENTITY(1,1) NOT NULL,comp_oferta nvarchar(50) NOT NULL, comp_cliente int NOT NULL, comp_cantidad int,comp_factura Numeric(18,0), comp_importe int);
CREATE TABLE PASO_A_PASO.Factura(fact_id Numeric(18,0) NOT NULL, fact_desde smalldatetime, fact_hasta smalldatetime, fact_importe int, fact_proveedor int NOT NULL);
CREATE TABLE PASO_A_PASO.Oferta(ofer_id nvarchar(50) NOT NULL, ofer_descripcion varchar(255), ofer_fechaDesde smalldatetime, ofer_fechaHasta smalldatetime, ofer_precioOferta Numeric(18,2), ofer_precioLista  Numeric(18,2), ofer_proveedor int, ofer_disponible Numeric(18,0), ofer_maxDisponible int)
CREATE TABLE PASO_A_PASO.TipoPago(tipoPago_id char(1) NOT NULL);