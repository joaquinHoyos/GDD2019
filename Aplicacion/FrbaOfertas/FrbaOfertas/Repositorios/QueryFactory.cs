using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
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

    }
}
