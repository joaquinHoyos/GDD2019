EXEC PASO_A_PASO.creacionTablas;
CREATE TYPE tablaFuncion AS TABLE (funciones varchar(20))
EXEC PASO_A_PASO.keys;
EXEC PASO_A_PASO.migracionTablas;
EXEC PASO_A_PASO.inicializacion_tablas;