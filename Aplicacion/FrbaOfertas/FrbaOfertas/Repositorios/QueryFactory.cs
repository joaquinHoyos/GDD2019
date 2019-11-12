using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using System.Windows.Forms;

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
           SqlCommand command = new SqlCommand("DELETE FROM PASO_A_PASO.Oferta WHERE ofer_id=@_id", conexion);
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
            SqlCommand command = new SqlCommand("SELECT * FROM PASO_A_PASO.busquedaRol_IdYNombre(@nombre,@funcion)", conexion);
            command.Parameters.Add(this.nuevoParametroTabla("@funcion", funciones, "PASO_A_PASO.tablaFuncion"));
            command.Parameters.Add(this.nuevoParametroString("@nombre", nombre));
            return command;
        }

        public SqlCommand busquedaRol_Todo(SqlConnection conexion)
        {
            return new SqlCommand("SELECT * FROM PASO_A_PASO.busquedaRol_Todo()", conexion);
        }

        public SqlCommand cargarCredito(string tipoDePago, long tarjeta, long monto, int idUsuario, SqlConnection conexion)
        {
            SqlCommand command = new SqlCommand("EXEC PASO_A_PASO.cargarCredito @tipoPago=@_tipoPago ,@monto=@_monto, @tarjeta=@_tarjeta, @userID=@_userID", conexion);
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
            return command;


        }


        public SqlCommand traerOfertasDisponibles(SqlConnection conexion){
            SqlCommand command = new SqlCommand("SELECT * FROM PASO_A_PASO.traerOfertasDisponibles()", conexion);
            return command;   
        
        }

        public SqlCommand generarCompra(int idUsuario, String oferCodigo, int cantidad,SqlConnection conexion)
        {
            SqlCommand command = new SqlCommand("EXEC PASO_A_PASO.generarCompra @userID=@_userID,@oferCodigo=@_oferCodigo,@cantidad=@_cantidad ", conexion);
            SqlParameter paramUsuario = this.nuevoParametroInt("@_userID", idUsuario);
            SqlParameter paramOferta = this.nuevoParametroString("@_oferCodigo", oferCodigo);
            SqlParameter paramCantidad = this.nuevoParametroInt("@_cantidad", cantidad);
            command.Parameters.Add(paramUsuario);
            command.Parameters.Add(paramOferta);
            command.Parameters.Add(paramCantidad);
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

    }
}
