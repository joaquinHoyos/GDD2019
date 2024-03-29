﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using FrbaOfertas.Server;
using FrbaOfertas.Modelo;
using FrbaOfertas.Forms;

namespace FrbaOfertas.Repositorios
{
    class RepoUsuario
    {
        public static RepoUsuario repo;
        public int idActual;
        public User userActual {get;private set;}
        public List<int> usuariosFiltrados { get; set; }

        public static RepoUsuario instance()
        {
            return repo==null?repo=new RepoUsuario():repo;
        }

        public void setUsuarioActual(int id)
        {
            idActual = id;
        }
        
        public List<User> listaUsuarios()
        {

            SqlConnection connection = ServerSQL.instance().levantarConexion();

            SqlCommand command = new SqlCommand("Select * from PASO_A_PASO.Usuario", connection);
            List<User> listaUsuarios = new List<User>();
            using (SqlDataReader reader = command.ExecuteReader())
            {
                while (reader.Read())
                {

                    listaUsuarios.Add(new User(Convert.ToInt32(reader["user_id"]), reader["user_username"].ToString(), reader["user_password"].ToString(), Convert.ToInt32(reader["user_intentosLogin"]), Convert.ToChar(reader["user_status"]), Convert.ToDateTime(reader["user_fechaBaja"])));

                }
            }
            connection.Close();
            //MessageBox.Show("Cantidad de usuarios listados: " + listaUsuarios.Count().ToString());
            return listaUsuarios;
        }

        public User buscarUsuarioPorClave(string usuario,string clave)
        {
            SqlConnection conexion = ServerSQL.instance().levantarConexion();
            SqlCommand command = QueryFactory.instance().logInUsuario(usuario, clave,conexion);
            SqlDataReader reader = command.ExecuteReader();
            if (reader.Read())
            {
                User user = new User(reader.GetInt32(0), reader.GetSqlString(1).ToString(), reader.GetSqlString(2).ToString(), reader.GetInt32(3), reader.GetSqlString(4).ToString().ToCharArray()[0], reader.GetDateTime(5));
                user.setRoles(this.traerFunciones(user.user_id));
                this.userActual = user; 
                return user;
            }
            return null;
        }
        private Grupo nuevoGrupo(char grupo) {
            Grupo grup = new Grupo();
            grup.funciones = new List<int>();
            grup.grupo = grupo;
            return grup;
        }
        public List<Grupo>traerFunciones (int idUsuario){
            SqlConnection conexion = ServerSQL.instance().levantarConexion();
            SqlCommand command = QueryFactory.instance().traerFunciones(idUsuario,conexion);
            SqlDataReader reader = command.ExecuteReader();
            List<Grupo> listaGrupo = new List<Grupo>();
            Grupo grupo = this.nuevoGrupo(new Char());
            while (reader.Read())
            {
                if (grupo.grupo == new Char() || grupo.grupo != reader.GetSqlString(1).ToString()[0]) {
                    listaGrupo.Add(grupo);
                    grupo = this.nuevoGrupo(reader.GetSqlString(1).ToString()[0]);
                    grupo.funciones.Add(reader.GetInt32(0));
                }else{
                    grupo.funciones.Add(reader.GetInt32(0));
                }
            }
           listaGrupo.Add(grupo);
           return listaGrupo;
        }
        public void crearUsuario(string usuario, string clave,int rol)
        {
            SqlConnection conexion = ServerSQL.instance().levantarConexion();

            SqlCommand command = QueryFactory.instance().signUpUsuario(usuario,clave,rol,conexion);
            
            
            try
            {
                
                command.ExecuteNonQuery();
            }
            catch (SqlException e)
            {
                throw e;
            }
        }


        public void altaCliente(String nombre, String apellido, long dni, int cp, String direccion, String ciudad, String mail,long telefono, DateTime fechaNacimiento)
        {
            SqlConnection conexion = ServerSQL.instance().levantarConexion();
            SqlCommand command = QueryFactory.instance().altaCliente(nombre, apellido, dni, cp, idActual, direccion, ciudad, mail,telefono, fechaNacimiento, conexion);
            command.ExecuteNonQuery();
            MessageBox.Show("Cliente registrado");
            //new LoginUsuario().Show();
            
        }         public void crearUsuario(String usuario, String contrasena, List<String> listaRoles)
        {
            SqlConnection conexion = ServerSQL.instance().levantarConexion();

            try
            {

                SqlCommand command = QueryFactory.instance().crearUsuario(usuario, contrasena, conexion);
                command.ExecuteNonQuery();

                int idUsuarioAgregado = this.getIdUsuario(usuario);

                for (int i = 0; i < listaRoles.Count; i++)
                {
                   SqlCommand command1 = QueryFactory.instance().agregarRolAUsuario(idUsuarioAgregado, listaRoles[i], conexion);
                   command1.ExecuteNonQuery();

                }
                
                MessageBox.Show("Usuario creado correctamente");
            }
            catch (Exception e)
            {

                MessageBox.Show("Error al crear el usuario: " + e.Message);
            }

        }


         private int getIdUsuario(string username)
         {
             SqlConnection conexion = ServerSQL.instance().levantarConexion();
             SqlCommand command = QueryFactory.instance().getUsuario(username,conexion);

             SqlDataReader reader = command.ExecuteReader();

             reader.Read();
             return Convert.ToInt32(reader[0]);

         }

        public void altaProveedor(String cuit, String razon, String mail,long telefono,String direccion,int codigoPostal,String ciudad,int rubroID,String nombre)
        {
            SqlConnection conexion = ServerSQL.instance().levantarConexion();
            SqlCommand command = QueryFactory.instance().altaProveedor(cuit, razon,idActual, mail,telefono,direccion,codigoPostal,ciudad,rubroID, nombre, conexion);
            command.ExecuteNonQuery();
            MessageBox.Show("Proveedor registrado");
            //new LoginUsuario().Show();
            
        }

        public int tieneClienteOProveedor() {

            SqlConnection conexion = ServerSQL.instance().levantarConexion();
            SqlCommand command = QueryFactory.instance().tieneClienteOProveedor(idActual,conexion);
            SqlDataReader reader = command.ExecuteReader();
            reader.Read();
            return Convert.ToInt32(reader[0]);

        }

        public int getProveedorActual()
        {
            SqlConnection conexion = ServerSQL.instance().levantarConexion();

            SqlCommand command = QueryFactory.instance().traerProveedorDeUsuario(idActual, conexion);

            SqlDataReader reader = command.ExecuteReader();

            reader.Read();

            return Convert.ToInt32(reader[0]);
        }


        public List<Rubro> traerRubros() {
            SqlConnection conexion = ServerSQL.instance().levantarConexion();
            SqlCommand command = QueryFactory.instance().traerRubros(conexion);
            List<Rubro> listaRubros = new List<Rubro>();
            using (SqlDataReader reader = command.ExecuteReader())
            {
                while (reader.Read())
                {

                    listaRubros.Add(new Rubro(Convert.ToInt32(reader["rubr_id"]) , reader["rubr_nombre"].ToString()));

                }
            }
           conexion.Close();
           return listaRubros;
        }
        
        

        public DataTable buscarClienteSinUsuario(String nombre, String apellido, String mail, String dni)
        {


            SqlConnection conexion = ServerSQL.instance().levantarConexion();
            SqlCommand command = QueryFactory.instance().buscarClientesSinUsuario(nombre, apellido, mail, dni, conexion);
            SqlDataReader reader = command.ExecuteReader();

            DataTable tabla = new DataTable();
            tabla.Columns.Add(new DataColumn("ID"));
            tabla.Columns.Add(new DataColumn("Dni"));
            tabla.Columns.Add(new DataColumn("Nombre"));
            tabla.Columns.Add(new DataColumn("Apellido"));
            tabla.Columns.Add(new DataColumn("Direccion"));
            tabla.Columns.Add(new DataColumn("Mail"));
            tabla.Columns.Add(new DataColumn("Telefono"));
            tabla.Columns.Add(new DataColumn("Saldo"));
            tabla.Columns.Add(new DataColumn("Ciudad"));
            tabla.Columns.Add(new DataColumn("Fecha Nacimiento"));
            tabla.Columns.Add(new DataColumn("Codigo Postal"));



            if (!reader.HasRows)
            {
                return null;
            }

            while (reader.Read())
            {


                DataRow row = tabla.NewRow();

                row["ID"] = reader["clie_id"];
                row["Dni"] = reader["clie_dni"];
                row["Nombre"] = reader["clie_nombre"];
                row["Apellido"] = reader["clie_apellido"];
                row["Direccion"] = reader["clie_direccion"];
                row["Mail"] = reader["clie_mail"];
                row["Telefono"] = reader["clie_telefono"];
                row["Saldo"] = reader["clie_saldo"];
                row["Ciudad"] = reader["clie_ciudad"];
                row["Fecha Nacimiento"] = reader["clie_fechaNacimiento"];
                row["Codigo Postal"] = reader["clie_codigoPostal"];


                tabla.Rows.Add(row);

            }

            return tabla;

        }

        public DataTable buscarCliente(String nombre, String apellido, String mail, String dni)
        {

            
            SqlConnection conexion = ServerSQL.instance().levantarConexion();
            SqlCommand command = QueryFactory.instance().buscarClientes(nombre, apellido,mail ,dni,conexion);
            SqlDataReader reader = command.ExecuteReader();

            DataTable tabla = new DataTable();
            tabla.Columns.Add(new DataColumn("ID"));
            tabla.Columns.Add(new DataColumn("Dni"));
            tabla.Columns.Add(new DataColumn("Nombre"));
            tabla.Columns.Add(new DataColumn("Apellido"));
            tabla.Columns.Add(new DataColumn("Direccion"));
            tabla.Columns.Add(new DataColumn("Mail"));
            tabla.Columns.Add(new DataColumn("Telefono"));
            tabla.Columns.Add(new DataColumn("Saldo"));
            tabla.Columns.Add(new DataColumn("Ciudad"));
            tabla.Columns.Add(new DataColumn("Fecha Nacimiento"));
            tabla.Columns.Add(new DataColumn("Codigo Postal"));
            


            if (!reader.HasRows)
            {
                return null;
            }

            while (reader.Read())
            {
           
               
            DataRow row = tabla.NewRow();

            row["ID"] = reader["clie_id"];
            row["Dni"] = reader["clie_dni"];
            row["Nombre"] = reader["clie_nombre"];
            row["Apellido"] = reader["clie_apellido"];
            row["Direccion"] = reader["clie_direccion"];
            row["Mail"] = reader["clie_mail"];
            row["Telefono"] = reader["clie_telefono"];
            row["Saldo"] = reader["clie_saldo"];
            row["Ciudad"] = reader["clie_ciudad"];
            row["Fecha Nacimiento"] = reader["clie_fechaNacimiento"];
            row["Codigo Postal"] = reader["clie_codigoPostal"];
            
     
             tabla.Rows.Add(row);

            }

            return tabla;

        }

        public void registrarInicioFallido(String username)
        {


            SqlConnection conexion = ServerSQL.instance().levantarConexion();

            SqlCommand command = QueryFactory.instance().inicioFallido(username, conexion);


            try
            {

                command.ExecuteNonQuery();
            }
            catch (SqlException e)
            {
                throw e;
            }


        }

        public void registrarInicioValido(String username)
        {

            if (idActual != null)
            {
                SqlConnection conexion = ServerSQL.instance().levantarConexion();

                SqlCommand command = QueryFactory.instance().inicioValido(username, conexion);


                try
                {

                    command.ExecuteNonQuery();
                }
                catch (SqlException e)
                {
                    throw e;
                }

            }
        }



        public DataTable traerUsuariosFiltrados(string p)
        {

            SqlConnection conexion = ServerSQL.instance().levantarConexion();
            SqlCommand command = QueryFactory.instance().buscarUsuarios(p,conexion);
            SqlDataReader reader = command.ExecuteReader();


            List<int> filtrados = new List<int>();
            DataTable tabla = new DataTable();
            tabla.Columns.Add(new DataColumn("ID"));
            tabla.Columns.Add(new DataColumn("Username"));
            tabla.Columns.Add(new DataColumn("Estado"));
            tabla.Columns.Add(new DataColumn("Intentos login"));
            tabla.Columns.Add(new DataColumn("Fecha Baja"));


            if (!reader.HasRows)
            {
                return null;
            }

            while (reader.Read())
            {
                
                DataRow row = tabla.NewRow();

                row["ID"] = reader["user_id"];
                row["Username"] = reader["user_username"];
                row["Estado"] = reader["user_status"];
                row["Intentos login"] = reader["user_intentosLogin"];
                row["Fecha Baja"] = reader["user_fechaBaja"];


               
                tabla.Rows.Add(row);
                filtrados.Add(Convert.ToInt32(reader["user_id"]));

            }
            this.usuariosFiltrados = filtrados;
            return tabla;

        }

        public List<int> traerRoles(string user)
        {
            SqlConnection conexion = ServerSQL.instance().levantarConexion();
            SqlCommand command = QueryFactory.instance().traerRoles(user,conexion);
            SqlDataReader reader = command.ExecuteReader();

            List<int> roles = new List<int>();

            while (reader.Read())
            {
                roles.Add(Convert.ToInt32(reader["id_rol"]));

            }


            return roles;

        }

        public void modificarUsuario(string user, string pass,List<string> rolesSeleccionados, string intentosLogin,string userId)
        {
            SqlConnection conexion = ServerSQL.instance().levantarConexion();
            SqlCommand command = QueryFactory.instance().modificarDatosUsuario(user, pass,intentosLogin,userId,conexion);
            command.ExecuteNonQuery();

            SqlCommand command1 = QueryFactory.instance().borrarRolesUsuario(userId, conexion);
            command1.ExecuteNonQuery();

            for (int i = 0; i < rolesSeleccionados.Count; i++)
            {
                int idRol = RepoRol.instance().getIdRol(rolesSeleccionados[i]);
                SqlCommand command2 = QueryFactory.instance().modificarRolesUsuario(userId, idRol, conexion);
                command2.ExecuteNonQuery();
            }
        }

        public void deshabilitarUsuario(string idUsuario)
        {
            SqlConnection conexion = ServerSQL.instance().levantarConexion();
            SqlCommand command = QueryFactory.instance().deshabilitarUsuario(idUsuario, conexion);

            command.ExecuteNonQuery();
        }

        public void habilitarUsuario(string idUsuario)
        {
            SqlConnection conexion = ServerSQL.instance().levantarConexion();
            SqlCommand command = QueryFactory.instance().habilitarUsuario(idUsuario, conexion);

            command.ExecuteNonQuery();
        }

        public void asignarCliente(string idUsuario, string idcliente)
        {

            SqlConnection conexion = ServerSQL.instance().levantarConexion();
            SqlCommand command = QueryFactory.instance().asignarUsuarioACliente(idUsuario, idcliente,conexion);

            command.ExecuteNonQuery();
            SqlCommand command1 = QueryFactory.instance().asigarRolNuevoAUsuario(idUsuario, 2, conexion);


            command1.ExecuteNonQuery();
        }

        public void asignarProv(string idUsuario, string idProv)
        {
            SqlConnection conexion = ServerSQL.instance().levantarConexion();
            SqlCommand command = QueryFactory.instance().asignarUsuarioAProveedor(idUsuario, idProv, conexion);


            command.ExecuteNonQuery();

            SqlCommand command1 = QueryFactory.instance().asigarRolNuevoAUsuario(idUsuario,3,conexion);


            command1.ExecuteNonQuery();
        }





        public int tieneCliente()
        {
            SqlConnection conexion = ServerSQL.instance().levantarConexion();

            SqlCommand command = QueryFactory.instance().tieneCliente(idActual, conexion);

            SqlDataReader reader = command.ExecuteReader();

            reader.Read();

            return Convert.ToInt32(reader[0]);
        }

        public int tieneProveedor()
        {
            SqlConnection conexion = ServerSQL.instance().levantarConexion();

            SqlCommand command = QueryFactory.instance().tieneProveedor(idActual, conexion);

            SqlDataReader reader = command.ExecuteReader();

            reader.Read();

            return Convert.ToInt32(reader[0]);
        }
    }


  
}
