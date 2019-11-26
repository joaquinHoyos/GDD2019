using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;
using System.Data;
using FrbaOfertas.Modelo;
using FrbaOfertas.Server;
using System.Configuration;

namespace FrbaOfertas.Repositorios
{
    class QueryFactory
    {
        static QueryFactory fact;

        public static QueryFactory instance()
        {
            return fact == null ? fact = new QueryFactory() : fact;
        }

        private QueryFactory() { }
        private SqlParameter nuevoParametroString(string nombre, string value)
        {
            SqlParameter parametro = new SqlParameter();
            parametro.ParameterName = nombre;
            parametro.Value = value;

            return parametro;
        }
        private SqlParameter nuevoParametroDateTime(string nombre, DateTime value)
        {
            SqlParameter parametro = new SqlParameter();
            parametro.ParameterName = nombre;
            parametro.Value = value;

            return parametro;

        }

        private SqlParameter nuevoParametroDouble(string nombre, Double value)
        {
            SqlParameter parametro = new SqlParameter();
            parametro.ParameterName = nombre;
            parametro.Value = value;

            return parametro;
        }

        private SqlParameter nuevoParametroInt(string nombre, int value)
        {
            SqlParameter parametro = this.nuevoParametroString(nombre, "");
            parametro.Value = value;
            return parametro;
        }

        private SqlParameter nuevoParametroLong(string nombre, long value)
        {
            SqlParameter parametro = this.nuevoParametroString(nombre, "");
            parametro.Value = value;
            return parametro;
        }

       public SqlCommand agregarOferta(string id,string descripcion,DateTime fechaDesde,DateTime fechaHasta,double precioOferta,double precioLista,int proveedor,int disponible,int maxDisponible,SqlConnection conexion)
    {
        SqlCommand command = new SqlCommand("EXEC PASO_A_PASO.crearOferta @id=@_id,@descripcion=@_descripcion,@fechaDesde=@_fechaDesde,@fechaHasta=@_fechaHasta,@precioOferta=@_precioOferta,@precioLista=@_precioLista,@proveedor=@_proveedor,@disponible=@_disponible,@maxDisponible=@_maxDisponible", conexion);
            SqlParameter param = this.nuevoParametroString("@_id", id);
            SqlParameter param1 = this.nuevoParametroString("@_descripcion", descripcion);
            SqlParameter param2 = this.nuevoParametroDateTime("@_fechaDesde", fechaDesde);
            SqlParameter param3 = this.nuevoParametroDateTime("@_fechaHasta", fechaHasta);
            SqlParameter param4 = this.nuevoParametroDouble("@_precioOferta", precioOferta);
            SqlParameter param5 = this.nuevoParametroDouble("@_precioLista", precioLista);
            SqlParameter param6 = this.nuevoParametroInt("@_proveedor", proveedor);
            SqlParameter param7 = this.nuevoParametroInt("@_disponible", disponible);
            SqlParameter param8 = this.nuevoParametroInt("@_maxDisponible", maxDisponible);

            command.Parameters.Add(param);
            command.Parameters.Add(param1);
            command.Parameters.Add(param2);
            command.Parameters.Add(param3);
            command.Parameters.Add(param4);
            command.Parameters.Add(param5);
            command.Parameters.Add(param6);
            command.Parameters.Add(param7);
            command.Parameters.Add(param8);

            return command;

    }

       public SqlCommand editarOferta(string id, string descripcion, DateTime fechaDesde, DateTime fechaHasta, double precioOferta, double precioLista, int proveedor, int disponible, int maxDisponible, SqlConnection conexion)
       {
           SqlCommand command = new SqlCommand("UPDATE PASO_A_PASO.Oferta SET ofer_descripcion=@_descripcion,ofer_fechaDesde=@_fechaDesde,ofer_fechaHasta=@_fechaHasta,ofer_precioOferta=@_precioOferta,ofer_precioLista=@_precioLista,ofer_proveedor=@_proveedor,ofer_disponible=@_disponible,ofer_maxDisponible=@_maxDisponible WHERE ofer_id=@_id", conexion);
           SqlParameter param = this.nuevoParametroString("@_id", id);
           SqlParameter param1 = this.nuevoParametroString("@_descripcion", descripcion);
           SqlParameter param2 = this.nuevoParametroDateTime("@_fechaDesde", fechaDesde);
           SqlParameter param3 = this.nuevoParametroDateTime("@_fechaHasta", fechaHasta);
           SqlParameter param4 = this.nuevoParametroDouble("@_precioOferta", precioOferta);
           SqlParameter param5 = this.nuevoParametroDouble("@_precioLista", precioLista);
           SqlParameter param6 = this.nuevoParametroInt("@_proveedor", proveedor);
           SqlParameter param7 = this.nuevoParametroInt("@_disponible", disponible);
           SqlParameter param8 = this.nuevoParametroInt("@_maxDisponible", maxDisponible);

           command.Parameters.Add(param);
           command.Parameters.Add(param1);
           command.Parameters.Add(param2);
           command.Parameters.Add(param3);
           command.Parameters.Add(param4);
           command.Parameters.Add(param5);
           command.Parameters.Add(param6);
           command.Parameters.Add(param7);
           command.Parameters.Add(param8);

           return command;

       }

       public SqlCommand eliminarOferta(string id, SqlConnection conexion)
       {
           SqlCommand command = new SqlCommand("UPDATE PASO_A_PASO.Oferta SET ofer_estado='D' WHERE ofer_id=@_id", conexion);//"DELETE FROM PASO_A_PASO.Oferta WHERE ofer_id=@_id", conexion);
           SqlParameter param = this.nuevoParametroString("@_id", id);
           command.Parameters.Add(param);
           return command;

       }

        private SqlParameter nuevoParametroTabla(string nombre, DataTable tabla, string tipo)
        {
            SqlParameter parametro = this.nuevoParametroString(nombre, "");
            parametro.TypeName = tipo;
            parametro.Value = tabla;
            return parametro;

        }
        public SqlCommand logInUsuario(string usuario, string clave, SqlConnection conexion)
        {
            SqlCommand command = new SqlCommand("SELECT * FROM PASO_A_PASO.logInUsuario(@usuario,@clave)", conexion);
            SqlParameter userParam = this.nuevoParametroString("@usuario", usuario);
            SqlParameter passParam = this.nuevoParametroString("@clave", clave);
            command.Parameters.Add(userParam);
            command.Parameters.Add(passParam);
            return command;
        }

        public SqlCommand traerFunciones(int idUsuario, SqlConnection conexion)
        {
            SqlCommand command = new SqlCommand("SELECT * FROM PASO_A_PASO.traerFunciones(@usuario) ORDER BY func_grupo", conexion);
            SqlParameter param = this.nuevoParametroInt("@usuario", idUsuario);
            command.Parameters.Add(param);
            return command;
        }

        public SqlCommand traerFuncionesSegunGrupo(char grupo, SqlConnection conexion)
        {
            SqlCommand command = new SqlCommand("SELECT func_nombre FROM PASO_A_PASO.Funcion WHERE func_grupo=@grupo", conexion);
            SqlParameter param = this.nuevoParametroString("@grupo", grupo.ToString());
            command.Parameters.Add(param);
            return command;
        }
        public SqlCommand crearRol(string nombre, DataTable funciones, SqlConnection conexion)
        {
            SqlCommand command = new SqlCommand("EXEC PASO_A_PASO.crearRol @nombre=@_nombre ,@funciones=@tabla", conexion);
            SqlParameter paramNombre = this.nuevoParametroString("@_nombre", nombre);
            SqlParameter paramFunciones = this.nuevoParametroTabla("@tabla", funciones, "PASO_A_PASO.tablaFuncion");
            command.Parameters.Add(paramNombre);
            command.Parameters.Add(paramFunciones);
            return command;


        }


        public SqlCommand crearCliente(Cliente clie, SqlConnection conexion)
        {


            SqlCommand command = new SqlCommand("EXEC PASO_A_PASO.insertarCliente @nombre=@_nombre ,@apellido=@_ape,@user_id=@_user_id,@dni=@_dni,@mail=@_mail, @telefono=@_telefono,@direccion=@_direccion,@saldo=@_saldo,@codPostal=@_codPostal,@ciudad=@_ciudad,@fechaNac=@_fechaNac", conexion);
            SqlParameter paramNombre = this.nuevoParametroString("@_nombre", clie.nombre);
            SqlParameter paramApellido = this.nuevoParametroString("@_ape", clie.apellido);
            SqlParameter paramDni = this.nuevoParametroInt("@_dni", Convert.ToInt32(clie.clie_dni));

            SqlParameter paramTel = this.nuevoParametroInt("@_telefono", Convert.ToInt32(clie.telefono));
            SqlParameter paramMail = this.nuevoParametroString("@_mail", clie.mail);
            SqlParameter paramUserId = this.nuevoParametroInt("@_user_id", clie.user_id);
            SqlParameter paramDirec = this.nuevoParametroString("@_direccion", clie.direccion);
            SqlParameter paramSaldo = this.nuevoParametroDouble("@_saldo", clie.saldo);
            SqlParameter paramCP = this.nuevoParametroInt("@_codPostal", clie.codigoPostal);
            SqlParameter paramCiudad = this.nuevoParametroString("@_ciudad", clie.ciudad);
            SqlParameter paramFechaNac = this.nuevoParametroDateTime("@_fechaNac", clie.fechaNac);


           
            command.Parameters.Add(paramNombre);             command.Parameters.Add(paramApellido);
             command.Parameters.Add(paramDni);
             command.Parameters.Add(paramTel);
             command.Parameters.Add(paramMail);
             command.Parameters.Add(paramUserId);
             command.Parameters.Add(paramDirec);
             command.Parameters.Add(paramSaldo);
             command.Parameters.Add(paramCP);
             command.Parameters.Add(paramCiudad);
           
            command.Parameters.Add(paramFechaNac);
            return command;
        }


        public SqlCommand modificarCliente(String clie_id,Cliente clie, SqlConnection conexion)
        {


            SqlCommand command = new SqlCommand("EXEC PASO_A_PASO.modificarCliente @clie_id=@_clie_id,@nombre=@_nombre ,@apellido=@_ape,@user_id=@_user_id,@dni=@_dni,@mail=@_mail, @telefono=@_telefono,@direccion=@_direccion,@saldo=@_saldo,@codPostal=@_codPostal,@ciudad=@_ciudad,@fechaNac=@_fechaNac", conexion);

            SqlParameter paramNombre = this.nuevoParametroString("@_nombre", clie.nombre);

            SqlParameter paramApellido = this.nuevoParametroString("@_ape", clie.apellido);

            SqlParameter paramDni = this.nuevoParametroInt("@_dni", Convert.ToInt32(clie.clie_dni));

            SqlParameter paramTel = this.nuevoParametroInt("@_telefono", Convert.ToInt32(clie.telefono));
            SqlParameter paramMail = this.nuevoParametroString("@_mail", clie.mail);
            SqlParameter paramUserId = this.nuevoParametroInt("@_user_id", clie.user_id);
            SqlParameter paramDirec = this.nuevoParametroString("@_direccion", clie.direccion);
            SqlParameter paramSaldo = this.nuevoParametroDouble("@_saldo", clie.saldo);
            SqlParameter paramCP = this.nuevoParametroInt("@_codPostal", clie.codigoPostal);
            SqlParameter paramCiudad = this.nuevoParametroString("@_ciudad", clie.ciudad);
            SqlParameter paramFechaNac = this.nuevoParametroDateTime("@_fechaNac", clie.fechaNac);
            SqlParameter paramClieId = this.nuevoParametroInt("@_clie_id", Convert.ToInt32(clie_id));


            command.Parameters.Add(paramNombre);
            command.Parameters.Add(paramApellido);
            command.Parameters.Add(paramDni);
            command.Parameters.Add(paramTel);
            command.Parameters.Add(paramMail);
            command.Parameters.Add(paramUserId);
            command.Parameters.Add(paramDirec);
            command.Parameters.Add(paramSaldo);
            command.Parameters.Add(paramCP);
            command.Parameters.Add(paramCiudad);
            command.Parameters.Add(paramClieId);
            command.Parameters.Add(paramFechaNac);

            return command;


        }

        public SqlCommand signUpUsuario(string username, string clave, int rol, SqlConnection conexion)
        {
            SqlCommand command = new SqlCommand("EXEC PASO_A_PASO.crearUsuario @username=@usuario,@pass=@clave,@rol=@_rol", conexion);
            SqlParameter paramUsername = this.nuevoParametroString("@usuario", username);
            SqlParameter paramClave = this.nuevoParametroString("@clave", clave);
            SqlParameter paramRol = this.nuevoParametroInt("@_rol", rol);
            command.Parameters.Add(paramUsername);
            command.Parameters.Add(paramClave);
            command.Parameters.Add(paramRol);
            return command;
        }

        public SqlCommand busquedaRol_Id(decimal id, SqlConnection conexion)
        {
            SqlCommand command = new SqlCommand("SELECT * FROM PASO_A_PASO.busquedaRol_Id(@id)", conexion);
            SqlParameter parametro = this.nuevoParametroInt("@id",Int32.Parse(id.ToString()));
            command.Parameters.Add(parametro);
            return command;
        }

        public SqlCommand busquedaOferta(string descripcion,DateTime fecha,int proveedor,SqlConnection conexion)
        {
            SqlCommand command = new SqlCommand("SELECT * FROM PASO_A_PASO.busquedaOferta(@descripcion,@fecha,@proveedor)", conexion);
            SqlParameter parametro1 = this.nuevoParametroString("@descripcion", descripcion);
            SqlParameter parametro2 = this.nuevoParametroDateTime("@fecha", fecha);
            SqlParameter parametro3 = this.nuevoParametroInt("@proveedor", proveedor);
            command.Parameters.Add(parametro1);
            command.Parameters.Add(parametro2);
            command.Parameters.Add(parametro3);
            return command;
        }

        public SqlCommand busquedaRol_Nombre(string nombre, SqlConnection conexion)
        {
            SqlCommand command = new SqlCommand("SELECT * FROM PASO_A_PASO.busquedaRol_Nombre(@nombre)",conexion);
            command.Parameters.Add(this.nuevoParametroString("@nombre",nombre));
            return command;
        }

        public SqlCommand busquedaRol_Funcion(DataTable funciones, SqlConnection conexion)
        {
            SqlCommand command = new SqlCommand("SELECT * FROM PASO_A_PASO.busquedaRol_Funcion(@funcion)",conexion);
            command.Parameters.Add(this.nuevoParametroTabla("@funcion",funciones,"PASO_A_PASO.tablaFuncion"));
            return command;
        }

        public SqlCommand busquedaRol_IdYNombre(decimal id,string nombre, SqlConnection conexion)
        {
            SqlCommand command = new SqlCommand("SELECT * FROM PASO_A_PASO.busquedaRol_IdYNombre(@id,@nombre)", conexion);
            command.Parameters.Add(this.nuevoParametroInt("@id", Convert.ToInt32(id)));
            command.Parameters.Add(this.nuevoParametroString("@nombre",nombre));
            return command;
        }
        public SqlCommand busquedaRol_IdYFuncion(decimal id, DataTable funciones, SqlConnection conexion)
        {
            SqlCommand command = new SqlCommand("SELECT * FROM PASO_A_PASO.busquedaRol_IdYFuncion(@id,@funcion)", conexion);
            command.Parameters.Add(this.nuevoParametroInt("@id", Convert.ToInt32(id)));
            command.Parameters.Add(this.nuevoParametroTabla("@funcion", funciones, "PASO_A_PASO.tablaFuncion"));
            return command;
        }

        public SqlCommand busquedaRol_NombreYFuncion(string nombre,DataTable funciones, SqlConnection conexion)
        {
            SqlCommand command = new SqlCommand("SELECT * FROM PASO_A_PASO.busquedarRol_NombreYFuncion(@nombre,@funcion)", conexion);
            command.Parameters.Add(this.nuevoParametroTabla("@funcion", funciones, "PASO_A_PASO.tablaFuncion"));
            command.Parameters.Add(this.nuevoParametroString("@nombre", nombre));
            return command;
        }

        public SqlCommand busquedaRol_Todo(SqlConnection conexion)
        {
            return new SqlCommand("SELECT * FROM PASO_A_PASO.busquedaRol_Todo()", conexion);
        }

        public SqlCommand traerProveedorDeUsuario(int user,SqlConnection conexion)
        {
            SqlCommand command = new SqlCommand("SELECT prov_id FROM PASO_A_PASO.Proveedor WHERE prov_userId=@_user", conexion);
            SqlParameter paramUsuario = this.nuevoParametroInt("@_user", user);
            command.Parameters.Add(paramUsuario);
            return command;
        }

        public SqlCommand cargarCredito(string tipoDePago, long tarjeta, long monto, int idUsuario, SqlConnection conexion)
        {
            SqlCommand command = new SqlCommand("EXEC PASO_A_PASO.cargarCredito @tipoPago=@_tipoPago ,@monto=@_monto, @tarjeta=@_tarjeta, @userID=@_userID, @fecha=@_fecha", conexion);
            SqlParameter paramTipo = this.nuevoParametroString("@_tipoPago", tipoDePago);
            SqlParameter paramTarjeta= new SqlParameter();
            if (tipoDePago == "E")
            {

                paramTarjeta.ParameterName = "@_tarjeta";
                paramTarjeta.Value = DBNull.Value;

            }
            else
            {
                paramTarjeta = this.nuevoParametroLong("@_tarjeta", tarjeta);

            }
            SqlParameter paramMonto = this.nuevoParametroLong("@_monto", monto);
            SqlParameter paramUsuario = this.nuevoParametroInt("@_userID", idUsuario);
            command.Parameters.Add(paramTipo);
            command.Parameters.Add(paramTarjeta);
            command.Parameters.Add(paramMonto);
            command.Parameters.Add(paramUsuario);
            command.Parameters.Add(this.nuevoParametroDateTime("@_fecha", Convert.ToDateTime(ConfigurationManager.AppSettings["fecha"])));
            return command;


        }


        public SqlCommand traerOfertasDisponibles(SqlConnection conexion){
            SqlCommand command = new SqlCommand("SELECT * FROM PASO_A_PASO.traerOfertasDisponibles(@_fecha)", conexion);
            command.Parameters.Add(this.nuevoParametroDateTime("@_fecha", Convert.ToDateTime(ConfigurationManager.AppSettings["fecha"])));
            return command;   
        
        }

        public SqlCommand generarCompra(int idUsuario, String oferCodigo, int cantidad,DateTime fecha,SqlConnection conexion)
        {
            SqlCommand command = new SqlCommand("EXEC PASO_A_PASO.generarCompra @userID=@_userID,@oferCodigo=@_oferCodigo,@cantidad=@_cantidad,@fecha=@_fecha", conexion);
            SqlParameter paramUsuario = this.nuevoParametroInt("@_userID", idUsuario);
            SqlParameter paramOferta = this.nuevoParametroString("@_oferCodigo", oferCodigo);
            SqlParameter paramCantidad = this.nuevoParametroInt("@_cantidad", cantidad);
            SqlParameter paramFecha = this.nuevoParametroDateTime("@_fecha", Convert.ToDateTime(ConfigurationManager.AppSettings["fecha"]));
            command.Parameters.Add(paramUsuario);
            command.Parameters.Add(paramOferta);
            command.Parameters.Add(paramCantidad);
            command.Parameters.Add(paramFecha);
            return command;

        }

        public SqlCommand traerCuponesPropios(int userID,SqlConnection conexion)
        {
            SqlCommand command = new SqlCommand("SELECT cupo_id, cupo_fecha, cupo_oferta, cupo_cliente,ofer_descripcion FROM PASO_A_PASO.Cupon JOIN PASO_A_PASO.Oferta ON (ofer_id = cupo_oferta) WHERE cupo_cliente = (SELECT clie_id FROM PASO_A_PASO.Cliente WHERE @userID = clie_userId) AND cupo_fecha ='1/1/1900'", conexion);
            SqlParameter paramUserID = this.nuevoParametroInt("@userID", userID);
            command.Parameters.Add(paramUserID);
            return command;

        }

        public SqlCommand regalarCupon(int idCupon, int idCliente, SqlConnection conexion)
        {
            SqlCommand command = new SqlCommand("EXEC PASO_A_PASO.regalarCupon @cuponID = @_cuponID, @clienteID = @_clienteID ", conexion);
            SqlParameter paramCupon = this.nuevoParametroInt("@_cuponID", idCupon);
            SqlParameter paramCliente = this.nuevoParametroInt("@_clienteID", idCliente);
            command.Parameters.Add(paramCupon);
            command.Parameters.Add(paramCliente);
            return command;

        }

        public SqlCommand saldoUsuario(int userID, SqlConnection conexion)
        {
            SqlCommand command = new SqlCommand("(SELECT clie_saldo FROM PASO_A_PASO.Cliente WHERE clie_userId = @_idUsuario)", conexion);
            SqlParameter paramUserID = this.nuevoParametroInt("@_idUsuario", userID);
            command.Parameters.Add(paramUserID);
            return command;

        }

        public SqlCommand habilitarRol(int rol,SqlConnection conexion)
        {
            SqlCommand command = new SqlCommand("EXEC PASO_A_PASO.habilitarRol @rol=@rolID",conexion);
            command.Parameters.Add(this.nuevoParametroInt("@rolID", rol));
            return command;
        }

        public SqlCommand deshabilitarRol(int rol, SqlConnection conexion)
        {
            SqlCommand command = new SqlCommand("EXEC PASO_A_PASO.deshabilitarRol @rol=@rolID", conexion);
            command.Parameters.Add(this.nuevoParametroInt("@rolID", rol));
            return command;
        }

        public SqlCommand modificarRol(int id, string nombre, DataTable funciones, SqlConnection conexion)
        {
            SqlCommand command = new SqlCommand("EXEC PASO_A_PASO.modificarRol @id=@rolid, @nombre=@rolnombre, @funciones=@rolfunciones",conexion);
            command.Parameters.Add(this.nuevoParametroInt("@rolid", id));
            command.Parameters.Add(this.nuevoParametroString("@rolnombre",nombre));
            command.Parameters.Add(this.nuevoParametroTabla("@rolfunciones",funciones,"PASO_A_PASO.tablaFuncion"));
            return command;
        }

        public SqlCommand buscarClientes(string nombre, string apellido,string mail,string dni,SqlConnection conexion)
        {
            SqlCommand command = new SqlCommand("SELECT * FROM PASO_A_PASO.buscarClie(@nombre, @apellido,@mail,@dni)", conexion);
            command.Parameters.Add(this.nuevoParametroString("@nombre", nombre));
            command.Parameters.Add(this.nuevoParametroString("@apellido", apellido));
            command.Parameters.Add(this.nuevoParametroString("@mail", mail));
            command.Parameters.Add(this.nuevoParametroString("@dni", dni));
            
            return command;
        }

        public SqlCommand buscarClientesSinUsuario(string nombre, string apellido, string mail, string dni, SqlConnection conexion)
        {

            SqlCommand command = new SqlCommand("SELECT * FROM PASO_A_PASO.Cliente WHERE clie_userId IS NULL", conexion);

            return command;

        }

        public SqlCommand altaCliente(String nombre, String apellido, long dni, int cp,int userID, String direccion, String ciudad, String mail,long telefono, DateTime fechaNacimiento, SqlConnection conexion)
        {
            SqlCommand command = new SqlCommand("INSERT INTO PASO_A_PASO.Cliente (clie_dni,clie_nombre,clie_apellido,clie_userID,clie_mail,clie_telefono,clie_direccion,clie_saldo,clie_codigoPostal,clie_ciudad,clie_fechaNacimiento) VALUES (@dni,@nombre,@apellido,@userID,@mail,@telefono,@direccion,0,@codpos,@ciudad,@fecha)",conexion);
            command.Parameters.Add(this.nuevoParametroLong("@dni", dni));
            command.Parameters.Add(this.nuevoParametroString("@nombre", nombre));
            command.Parameters.Add(this.nuevoParametroString("@apellido", apellido));
            command.Parameters.Add(this.nuevoParametroInt("@userID", userID));
            command.Parameters.Add(this.nuevoParametroString("@mail", mail));
            command.Parameters.Add(this.nuevoParametroLong("@telefono", telefono));
            command.Parameters.Add(this.nuevoParametroString("@direccion", direccion));
            command.Parameters.Add(this.nuevoParametroString("@ciudad", ciudad));
            command.Parameters.Add(this.nuevoParametroInt("@codpos", cp));
            command.Parameters.Add(this.nuevoParametroDateTime("@fecha", fechaNacimiento));
            return command;
        }

        public SqlCommand altaProveedor(String cuit, String razon, int userID, String mail, long telefono, String direccion, int cp, String ciudad, int rubroID, String nombre, SqlConnection conexion)
    {
                    SqlCommand command = new SqlCommand("INSERT INTO PASO_A_PASO.Proveedor (prov_cuit,prov_razon,prov_userId,prov_mail,prov_telefono,prov_direccion,prov_codigoPostal,prov_ciudad,prov_rubro,prov_nombre,prov_habilitado) VALUES (@cuit,@razon,@userID,@mail,@telefono,@direccion,@codpos,@ciudad,@rubrID,@nombre,'1')",conexion);
            
            command.Parameters.Add(this.nuevoParametroString("@razon", razon));
            command.Parameters.Add(this.nuevoParametroString("@cuit", cuit));
            command.Parameters.Add(this.nuevoParametroString("@nombre", nombre));
            command.Parameters.Add(this.nuevoParametroInt("@userID", userID));
            command.Parameters.Add(this.nuevoParametroInt("@rubrID", rubroID));
            command.Parameters.Add(this.nuevoParametroString("@mail", mail));
            command.Parameters.Add(this.nuevoParametroLong("@telefono", telefono));
            command.Parameters.Add(this.nuevoParametroString("@direccion", direccion));
            command.Parameters.Add(this.nuevoParametroInt("@codpos", cp));
            command.Parameters.Add(this.nuevoParametroString("@ciudad", ciudad));
            return command;
    
    
    
    }

        public SqlCommand tieneClienteOProveedor(int userID, SqlConnection conexion){

            SqlCommand command = new SqlCommand("SELECT CASE WHEN EXISTS(SELECT * FROM PASO_A_PASO.Cliente WHERE @userID= clie_userId) OR EXISTS(SELECT * FROM PASO_A_PASO.Proveedor WHERE @userID = prov_userId) THEN 1 ELSE 0 END ;", conexion);
            command.Parameters.Add(this.nuevoParametroInt("@userID", userID));
            return command;        


        }

        public SqlCommand traerRubros(SqlConnection conexion) {

            return new SqlCommand("SELECT rubr_id,rubr_nombre FROM PASO_A_PASO.Rubro", conexion);
        
        }




        public SqlCommand deshabilitarCliente(string id, SqlConnection conexion)
        {
            SqlCommand command = new SqlCommand("EXEC PASO_A_PASO.deshabilitarCliente @clie_id=@_id", conexion);
            SqlParameter param = this.nuevoParametroString("@_id", id);
            command.Parameters.Add(param);
            return command;

        }

        public SqlCommand asignarUsuarioACliente(string clie_id, string usuario, string contrasena, List<String> rolesDesc, SqlConnection conexion)
        {
            DataTable roles = new DataTable();
            DataColumn columna = new DataColumn();
            columna.ColumnName = "rol";
            roles.Columns.Add(columna);

            for (int i = 0; i < rolesDesc.Count; i++)
            {

                DataRow row = roles.NewRow();
                row["rol"] = rolesDesc[i];
                roles.Rows.Add(row);
            }

            SqlCommand command = new SqlCommand("EXEC PASO_A_PASO.asignarUsuarioACliente @clie_id=@_id, @username=@_usuario,@pass=@_contra,@roles=@_roles", conexion);

            SqlParameter paramRoles = this.nuevoParametroTabla("@_roles", roles, "PASO_A_PASO.tablaRoles");
            SqlParameter param = this.nuevoParametroInt("@_id", Convert.ToInt32(clie_id));
            SqlParameter param1 = this.nuevoParametroString("@_usuario", usuario);
            SqlParameter param2 = this.nuevoParametroString("@_contra", contrasena);

            command.Parameters.Add(paramRoles);
            command.Parameters.Add(param);
            command.Parameters.Add(param1);
            command.Parameters.Add(param2);

            return command;
        }

        public SqlCommand crearUsuario(string username, string pass,SqlConnection conexion)
        {
            SqlCommand command = new SqlCommand("INSERT INTO PASO_A_PASO.Usuario VALUES (@_username,HASHBYTES('SHA2_256',convert(varchar(32),@_pass)),0,'E','1/1/1900')", conexion);
            SqlParameter param1 = this.nuevoParametroString("@_username", username);
            SqlParameter param2 = this.nuevoParametroString("@_pass", pass);

            command.Parameters.Add(param1);
            command.Parameters.Add(param2);
            return command;
        }


        public SqlCommand agregarRolAUsuario(int userId, string rolDesc, SqlConnection conexion)
        {
            SqlConnection conexion1 = ServerSQL.instance().levantarConexion();
            SqlCommand command1 = new SqlCommand("SELECT rol_id FROM PASO_A_PASO.Rol WHERE rol_nombre=@_rolDesc", conexion1);

            SqlParameter param2 = this.nuevoParametroString("@_rolDesc", rolDesc);
            command1.Parameters.Add(param2);

            SqlDataReader reader = command1.ExecuteReader();
            reader.Read();

            int idRol = Convert.ToInt32(reader[0]);

            SqlCommand command = new SqlCommand("INSERT INTO PASO_A_PASO.RolXUsuario VALUES (@_idRol,@_userId)", conexion);
            SqlParameter param1 = this.nuevoParametroInt("@_userId", userId);
            SqlParameter param3 = this.nuevoParametroInt("@_idRol", idRol);


            command.Parameters.Add(param1);
            command.Parameters.Add(param3);
            return command;


        }
        public SqlCommand traerProveedores(SqlConnection conexion)
        {
            SqlCommand command = new SqlCommand("SELECT * FROM PASO_A_PASO.Proveedor", conexion);
            return command;
        }

        public SqlCommand crearFactura(DateTime fechaInicio, DateTime fechaFinal, int proveedor, SqlConnection conexion)
        {
            SqlCommand command = new SqlCommand("EXEC PASO_A_PASO.facturarProveedor @fechaDesde=@_fechaDesde, @fechaHasta=@_fechaHasta,@prov=@_prov", conexion);
            SqlParameter param = this.nuevoParametroDateTime("@_fechaDesde", fechaInicio);
            SqlParameter param1 = this.nuevoParametroDateTime("@_fechaHasta", fechaFinal);
            SqlParameter param2 = this.nuevoParametroInt("@_prov", proveedor);

            command.Parameters.Add(param);
            command.Parameters.Add(param1);
            command.Parameters.Add(param2);

            return command;
        }

        public SqlCommand traerTodosLosRoles(SqlConnection conexion)
        {
            SqlCommand command = new SqlCommand("SELECT * FROM PASO_A_PASO.ROl WHERE rol_estado = 'E' ", conexion);
            return command;
        }

        public SqlCommand inicioValido(String username, SqlConnection conexion)
        {
            SqlCommand command = new SqlCommand("EXEC PASO_A_PASO.inicioValido @user = @username", conexion);
            command.Parameters.Add(this.nuevoParametroString("@username", username));
            return command;
        }

        public SqlCommand inicioFallido(String username, SqlConnection conexion)
        {
            SqlCommand command = new SqlCommand("EXEC PASO_A_PASO.inicioFallido @user = @username", conexion);
            command.Parameters.Add(this.nuevoParametroString("@username", username));
            return command;
        }

        public SqlCommand listadoEstadisticoDescuentos(int mesInicio,int mesFin, int anio, SqlConnection conexion)
        {

            SqlCommand command = new SqlCommand("SELECT * FROM PASO_A_PASO.proveedor_mayorDescuento(@año,@mesInicio,@mesFin)", conexion);
            command.Parameters.Add(this.nuevoParametroInt("@año",anio));
            command.Parameters.Add(this.nuevoParametroInt("@mesInicio",mesInicio));
            command.Parameters.Add(this.nuevoParametroInt("@mesFin",mesFin));
            return command;
        }

        public SqlCommand listadoEstadisticoVentas(int mesInicio, int mesFin, int anio, SqlConnection conexion)
        {

            SqlCommand command = new SqlCommand("SELECT * FROM PASO_A_PASO.proveedor_masFacturas(@año,@mesInicio,@mesFin)", conexion);
            command.Parameters.Add(this.nuevoParametroInt("@año", anio));
            command.Parameters.Add(this.nuevoParametroInt("@mesInicio", mesInicio));
            command.Parameters.Add(this.nuevoParametroInt("@mesFin", mesFin));
            return command;
        }

        public SqlCommand getUsuario(string username, SqlConnection conexion)
        {
            SqlCommand command = new SqlCommand("SELECT user_id FROM PASO_A_PASO.Usuario WHERE user_username = @_user ", conexion);
            command.Parameters.Add(this.nuevoParametroString("@_user", username));
            return command;
        }

        public SqlCommand buscarUsuarios(string p, SqlConnection conexion)
        {
            SqlCommand command;
            if (p != "")
            {
                command = new SqlCommand("SELECT * FROM PASO_A_PASO.Usuario WHERE user_username LIKE '%'+@_user+'%'", conexion);
            }
            else
            {
                command = new SqlCommand("SELECT * FROM PASO_A_PASO.Usuario", conexion);
            }

            command.Parameters.Add(this.nuevoParametroString("@_user", p));
            return command;
        }

        internal SqlCommand traerRoles(string user, SqlConnection conexion)
        {
            SqlCommand command = new SqlCommand("SELECT id_rol FROM PASO_A_PASO.RolXUsuario WHERE id_usuario=@_user ", conexion);
            command.Parameters.Add(this.nuevoParametroInt("@_user", Convert.ToInt32(user)));
            return command;
        }

        

        public SqlCommand modificarDatosUsuario(string user, string pass, string intentosLogin,string userId, SqlConnection conexion)
        {
            SqlCommand command = new SqlCommand("EXEC PASO_A_PASO.modificarDatosUsuario @user=@_user,@pass=@_pass,@intentos=@_login,@id=@_userId", conexion);
            command.Parameters.Add(this.nuevoParametroString("@_user", user));
            command.Parameters.Add(this.nuevoParametroString("@_pass", pass));
            command.Parameters.Add(this.nuevoParametroInt("@_login", Convert.ToInt32(intentosLogin)));
            command.Parameters.Add(this.nuevoParametroInt("@_userId", Convert.ToInt32(userId)));

            return command;
        }

        public SqlCommand modificarRolesUsuario(string userId,int nuevoRol,SqlConnection conexion)
        {
            SqlCommand command = new SqlCommand("INSERT INTO PASO_A_PASO.RolXUsuario VALUES (@_rol,@_userId)", conexion);
            command.Parameters.Add(this.nuevoParametroInt("@_rol", Convert.ToInt32(nuevoRol)));
            command.Parameters.Add(this.nuevoParametroInt("@_userId", Convert.ToInt32(userId)));

            return command;
        }
        public SqlCommand borrarRolesUsuario(string userId, SqlConnection conexion)
        {
            SqlCommand command = new SqlCommand("DELETE PASO_A_PASO.RolXUsuario WHERE id_usuario=@_userId", conexion);
          
            command.Parameters.Add(this.nuevoParametroInt("@_userId", Convert.ToInt32(userId)));

            return command;
        }

        public SqlCommand getIdRol(string rolDesc, SqlConnection conexion)
        {
            SqlCommand command = new SqlCommand("SELECT rol_id FROM PASO_A_PASO.Rol WHERE rol_nombre=@_rolDesc", conexion);

            command.Parameters.Add(this.nuevoParametroString("@_rolDesc", rolDesc));

            return command;
        }

        public SqlCommand deshabilitarUsuario(string idUsuario, SqlConnection conexion)
        {
            SqlCommand command = new SqlCommand("UPDATE PASO_A_PASO.Usuario SET user_status='D',user_fechaBaja=@_fechaBaja WHERE user_id=@_userId", conexion);
            command.Parameters.Add(this.nuevoParametroInt("@_userId", Convert.ToInt32(idUsuario)));
            command.Parameters.Add(this.nuevoParametroDateTime("@_fechaBaja", Convert.ToDateTime(ConfigurationManager.AppSettings["fecha"])));

            return command;
        }

        public SqlCommand habilitarUsuario(string idUsuario, SqlConnection conexion)
        {
            SqlCommand command = new SqlCommand("UPDATE PASO_A_PASO.Usuario SET user_status='E',user_fechaBaja='1/1/1900' WHERE user_id=@_userId", conexion);

            command.Parameters.Add(this.nuevoParametroInt("@_userId", Convert.ToInt32(idUsuario)));
          

            return command;
        }

        public SqlCommand asignarUsuarioACliente(string idUsuario, string idcliente, SqlConnection conexion)
        {
            SqlCommand command = new SqlCommand("UPDATE PASO_A_PASO.Cliente SET clie_userId = @_userId WHERE clie_id=@_clieId", conexion);

            command.Parameters.Add(this.nuevoParametroInt("@_userId", Convert.ToInt32(idUsuario)));
            command.Parameters.Add(this.nuevoParametroInt("@_clieId", Convert.ToInt32(idcliente)));

            return command;
        }

        internal SqlCommand buscarProveedor(string razonSocial, string cuit, string mail, SqlConnection conexion)
        {
            SqlCommand command;
            if (cuit == "")
            {
                command = new SqlCommand("SELECT * FROM PASO_A_PASO.buscarProvSinCuit(@razon,@mail)", conexion);
                command.Parameters.Add(this.nuevoParametroString("@razon", cuit));
                command.Parameters.Add(this.nuevoParametroString("@mail", mail));
            }
            else
            {
                command = new SqlCommand("SELECT * FROM PASO_A_PASO.buscarProvConCuit(@cuit)", conexion);
                command.Parameters.Add(this.nuevoParametroString("@cuit", cuit));
            }

            return command;
        }

        public SqlCommand getNombreRubro(string rubrId, SqlConnection conexion)
        {
            SqlCommand command = new SqlCommand("SELECT rubr_nombre FROM PASO_A_PASO.Rubro WHERE rubr_id=@_rubrId", conexion);

            command.Parameters.Add(this.nuevoParametroInt("@_rubrId", Convert.ToInt32(rubrId)));

            return command;
        }

        public SqlCommand getRubroPorNombre(string rubrNombre, SqlConnection conexion)
        {
            SqlCommand command = new SqlCommand("SELECT rubr_id FROM PASO_A_PASO.Rubro WHERE rubr_nombre=@_rubrNombre", conexion);

            command.Parameters.Add(this.nuevoParametroString("@_rubrNombre", rubrNombre));

            return command;
        }

       
        public SqlCommand altaProveedor(Proveedor prov, SqlConnection conexion)
        {   
            
            SqlCommand command = new SqlCommand("INSERT INTO PASO_A_PASO.Proveedor (prov_cuit,prov_razon,prov_userId,prov_mail,prov_telefono,prov_direccion,prov_codigoPostal,prov_ciudad,prov_rubro,prov_nombre,prov_habilitado) VALUES (@cuit,@razon,null,@mail,@telefono,@direccion,@codpos,@ciudad,@rubrID,@nombre,'1')", conexion);

            command.Parameters.Add(this.nuevoParametroString("@razon", prov.razonSocial));
            command.Parameters.Add(this.nuevoParametroString("@cuit", prov.cuit));
            command.Parameters.Add(this.nuevoParametroString("@nombre", prov.nombre));
            ;
            command.Parameters.Add(this.nuevoParametroInt("@rubrID", prov.rubro));
            command.Parameters.Add(this.nuevoParametroString("@mail", prov.mail));
            command.Parameters.Add(this.nuevoParametroLong("@telefono", prov.telefono));
            command.Parameters.Add(this.nuevoParametroString("@direccion", prov.direccion));
            command.Parameters.Add(this.nuevoParametroInt("@codpos", prov.codigoPostal));
            command.Parameters.Add(this.nuevoParametroString("@ciudad", prov.ciudad));
            return command;
        }

        public SqlCommand modificarProveedor(string provId, Proveedor prov, SqlConnection conexion)
        {
            SqlCommand command;
            if(prov.user==-1){

            command = new SqlCommand("UPDATE PASO_A_PASO.Proveedor SET prov_cuit=@cuit,prov_razon=@razon,prov_userId=null,prov_mail=@mail,prov_telefono=@telefono,prov_direccion=@direccion,prov_codigoPostal=@codpos,prov_ciudad=@ciudad,prov_rubro=@rubrID,prov_nombre=@nombre,prov_habilitado=@estado WHERE prov_id=@_provId", conexion);

            command.Parameters.Add(this.nuevoParametroString("@razon", prov.razonSocial));
            command.Parameters.Add(this.nuevoParametroString("@cuit", prov.cuit));
            command.Parameters.Add(this.nuevoParametroString("@nombre", prov.nombre));
            command.Parameters.Add(this.nuevoParametroString("@estado", prov.habilitado.ToString()));
           
            command.Parameters.Add(this.nuevoParametroInt("@rubrID", prov.rubro));
            command.Parameters.Add(this.nuevoParametroString("@mail", prov.mail));
            command.Parameters.Add(this.nuevoParametroLong("@telefono", prov.telefono));
            command.Parameters.Add(this.nuevoParametroString("@direccion", prov.direccion));
            command.Parameters.Add(this.nuevoParametroInt("@codpos", prov.codigoPostal));
            command.Parameters.Add(this.nuevoParametroString("@ciudad", prov.ciudad));
            command.Parameters.Add(this.nuevoParametroInt("@_provId", Convert.ToInt32(provId)));
          }
            else
            {
                command = new SqlCommand("UPDATE PASO_A_PASO.Proveedor SET prov_cuit=@cuit,prov_razon=@razon,prov_userId=@userId,prov_mail=@mail,prov_telefono=@telefono,prov_direccion=@direccion,prov_codigoPostal=@codpos,prov_ciudad=@ciudad,prov_rubro=@rubrID,prov_nombre=@nombre,prov_habilitado=@estado WHERE prov_id=@_provId", conexion);

                command.Parameters.Add(this.nuevoParametroString("@razon", prov.razonSocial));
                command.Parameters.Add(this.nuevoParametroString("@cuit", prov.cuit));
                command.Parameters.Add(this.nuevoParametroString("@nombre", prov.nombre));
                command.Parameters.Add(this.nuevoParametroString("@estado", prov.habilitado.ToString()));
                command.Parameters.Add(this.nuevoParametroInt("@userId", prov.user));
                command.Parameters.Add(this.nuevoParametroInt("@rubrID", prov.rubro));
                command.Parameters.Add(this.nuevoParametroString("@mail", prov.mail));
                command.Parameters.Add(this.nuevoParametroLong("@telefono", prov.telefono));
                command.Parameters.Add(this.nuevoParametroString("@direccion", prov.direccion));
                command.Parameters.Add(this.nuevoParametroInt("@codpos", prov.codigoPostal));
                command.Parameters.Add(this.nuevoParametroString("@ciudad", prov.ciudad));
                command.Parameters.Add(this.nuevoParametroInt("@_provId", Convert.ToInt32(provId)));
            }



            return command;
        }

        public SqlCommand deshabilitarProveedor(string p, SqlConnection conexion)
        {
            SqlCommand command = new SqlCommand("EXEC PASO_A_PASO.deshabilitarProveedor @prov_id=@_id", conexion);
            SqlParameter param = this.nuevoParametroString("@_id", p);
            command.Parameters.Add(param);
            return command;
        }

        public SqlCommand buscarProveedoresSinUsuario(SqlConnection conexion)
        {
            SqlCommand command = new SqlCommand("SELECT * FROM PASO_A_PASO.Proveedor WHERE prov_userId IS null", conexion);
            return command;
        }

        public SqlCommand asignarUsuarioAProveedor(string idUsuario, string idProv, SqlConnection conexion)
        {
            SqlCommand command = new SqlCommand("UPDATE PASO_A_PASO.Proveedor SET prov_userId = @_userId WHERE prov_id=@_provId", conexion);

            command.Parameters.Add(this.nuevoParametroInt("@_userId", Convert.ToInt32(idUsuario)));
            command.Parameters.Add(this.nuevoParametroInt("@_provId", Convert.ToInt32(idProv)));

            return command;
        }
    }
}
