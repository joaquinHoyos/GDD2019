sqlcmd -S localhost\SQLSERVER2012 -U gdCupon2019 -P gd2019 -i crearSchema.sql,creacionTablas.sql,keysTablas.sql,crearTypes.sql,crearRol.sql,crearUsuario.sql,inicializacion_tablas.sql,migracionTablas.sql,execProcedures.sql,indices.sql,cargaCredito.sql,crearCliente.sql,crearOferta.sql, crearProveedor.sql,generarCompra.sql,regalarCupon.sql,resetIndexes.sql,saldoUsuario.sql,selectMaestras.sql,funcionesBusquedaOferta.sql,funcionesBusquedaRol.sql,funcionLogInsql.sql,traerClienteSegunUsuario.sql,traerCuponesPropios.sql,traerOfertasDisponibles.sql,traerRoles.sql,traerFunciones.sql,busquedaId.sql,busquedaRol_Todo.sql,busquedaRol_NombreYFuncion.sql,busquedaRol_IdYFuncion.sql,busquedaRol_IdYNombre.sql,busquedaRol_Funcion.sql,busquedaRol_Nombre.sql,aumentar_sueldo.sql,facturarProveedor.sql,proveedor_masCompras.sql,proveedor_mayorDescuento.sql,insertarNuevoCliente.sql,busquedaCliente.sql,saldoInicial.sql,modificarCliente.sql,deshabilitarCliente.sql,asignarUsuarioACliente.sql,inicioFallido.sql,inicioValido.sql,buscarProvSinCuit.sql,buscarProvConCuit.sql,buscarClieConDni.sql  -a 32767 -o resultado_output.txt