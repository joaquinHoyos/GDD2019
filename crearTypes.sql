CREATE TYPE PASO_A_PASO.tablaFuncion AS TABLE (funciones varchar(20))

CREATE TYPE PASO_A_PASO.tablaCliente AS TABLE (clie_dni Numeric(18,0), clie_nombre nvarchar(255),clie_apellido nvarchar(255), clie_userId int, clie_mail nvarchar(255), clie_telefono Numeric(18,0),clie_direccion nvarchar(255), clie_saldo int, clie_codigoPostal int, clie_ciudad nvarchar(255),clie_fechaNacimiento smalldatetime)

CREATE TYPE PASO_A_PASO.tablaOferta AS TABLE (ofer_id nvarchar(50), ofer_descripcion varchar(255),ofer_fechaDesde smalldatetime, ofer_fechaHasta smalldatetime, ofer_precioOferta Numeric(18,2),ofer_precioLista Numeric(18,2), ofer_proveedor int, ofer_disponible Numeric(18,0),ofer_maxDisponible int)

CREATE TYPE PASO_A_PASO.tablaProveedor AS TABLE (prov_cuit nvarchar(20), prov_razon nvarchar(100),prov_userId int, prov_mail nvarchar(255), prov_telefono Numeric(18,0),prov_direccion nvarchar(255), prov_codigoPostal int, prov_ciudad nvarchar(255),prov_rubro int, prov_nombre nvarchar(255), prov_habilitado char)