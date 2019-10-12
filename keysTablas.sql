CREATE PROCEDURE keysTablas
as


ALTER TABLE Usuario ADD CONSTRAINT PK_Usuario PRIMARY KEY (user_id);
ALTER TABLE Cliente ADD CONSTRAINT PK_Cliente PRIMARY KEY (clie_id);
ALTER TABLE Proveedor ADD CONSTRAINT PK_Proveedor PRIMARY KEY (prov_id);
ALTER TABLE Rubro ADD CONSTRAINT PK_Rubro  PRIMARY KEY (rubr_id);
ALTER TABLE Rol ADD CONSTRAINT PK_Rol PRIMARY KEY (rol_id);
ALTER TABLE RolxUsuario ADD CONSTRAINT PK_RolxUsuario PRIMARY KEY (id_rol,id_usuario);
ALTER TABLE Funcion ADD CONSTRAINT PK_Funcion PRIMARY KEY (func_id);
ALTER TABLE FuncionesxRol ADD CONSTRAINT PK_FuncionesxRol PRIMARY KEY (id_rol,id_funcion);
ALTER TABLE Credito ADD CONSTRAINT PK_Credito PRIMARY KEY (cred_id);
ALTER TABLE Cupon ADD CONSTRAINT PK_Cupon PRIMARY KEY (cupo_id);
ALTER TABLE Compra ADD CONSTRAINT PK_Compra PRIMARY KEY (comp_id);
ALTER TABLE Factura ADD CONSTRAINT PK_Factura PRIMARY KEY (fact_id);
ALTER TABLE Oferta ADD CONSTRAINT PK_Oferta PRIMARY KEY (ofer_id);



ALTER TABLE Cliente ADD CONSTRAINT FK_Cliente_Usuario FOREIGN KEY (clie_userId) REFERENCES Usuario(user_id);
ALTER TABLE Proveedor ADD CONSTRAINT FK_Proveedor_Usuario FOREIGN KEY (prov_userId) REFERENCES Usuario(user_id);
ALTER TABLE Proveedor ADD CONSTRAINT FK_Proveedor_Rubro FOREIGN KEY (prov_rubro) REFERENCES Rubro(rubr_id);
ALTER TABLE RolxUsuario ADD CONSTRAINT FK_RolxUsuario_Usuario FOREIGN KEY (id_usuario) REFERENCES Usuario(user_id);
ALTER TABLE RolxUsuario ADD CONSTRAINT FK_RolxUsuario_Rol FOREIGN KEY (id_rol) REFERENCES Rol(rol_id);
ALTER TABLE FuncionesxRol ADD CONSTRAINT FK_FuncionesxRol_Funcion FOREIGN KEY (id_funcion) REFERENCES Funcion(func_id);
ALTER TABLE FuncionesxRol ADD CONSTRAINT FK_FuncionesxRol_Rol FOREIGN KEY (id_rol) REFERENCES Rol(rol_id);
ALTER TABLE Credito ADD CONSTRAINT FK_Credito_Cliente FOREIGN KEY (cred_cliente) REFERENCES Cliente(clie_id); 
ALTER TABLE Cupon ADD CONSTRAINT FK_Cupon_Cliente FOREIGN KEY (cupo_cliente) REFERENCES Cliente(clie_id);
ALTER TABLE Cupon ADD CONSTRAINT FK_Cupon_Oferta FOREIGN KEY (cupo_oferta) REFERENCES Oferta(ofer_id);
ALTER TABLE Cupon ADD CONSTRAINT FK_Cupon_Compra FOREIGN KEY (cupo_compra) REFERENCES Compra(comp_id);
ALTER TABLE Compra ADD CONSTRAINT FK_Compra_Factura FOREIGN KEY (comp_factura) REFERENCES Factura(fact_id);
ALTER TABLE Compra ADD CONSTRAINT FK_Compra_Cliente FOREIGN KEY (comp_cliente) REFERENCES Cliente(clie_id);
ALTER TABLE Compra ADD CONSTRAINT FK_Compra_Oferta FOREIGN KEY (comp_oferta) REFERENCES Oferta(ofer_id);
ALTER TABLE Factura ADD CONSTRAINT FK_Factura_Proveedor FOREIGN KEY (fact_proveedor) REFERENCES Proveedor(prov_id);
ALTER TABLE Oferta ADD CONSTRAINT FK_Oferta_Proveedor FOREIGN KEY (ofer_proveedor) REFERENCES Proveedor(prov_id);