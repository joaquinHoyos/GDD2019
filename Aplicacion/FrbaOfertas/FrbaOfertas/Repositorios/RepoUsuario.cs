using System;
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

namespace FrbaOfertas.Repositorios
{
    class RepoUsuario
    {
        public static RepoUsuario repo;

        public static RepoUsuario instance()
        {
            return repo==null?new RepoUsuario():repo;
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
            MessageBox.Show("Cantidad de usuarios listados: " + listaUsuarios.Count().ToString());
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

        
    }

}
