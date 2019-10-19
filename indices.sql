CREATE UNIQUE INDEX indexCliente ON PASO_A_PASO.Cliente(clie_dni)

CREATE UNIQUE INDEX indexProveedor ON PASO_A_PASO.Proveedor(prov_razon, prov_cuit)

CREATE UNIQUE INDEX indexUsuario ON PASO_A_PASO.Usuario (user_username)