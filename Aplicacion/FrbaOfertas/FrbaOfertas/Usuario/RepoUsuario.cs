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

namespace FrbaOfertas.Usuario
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
            string query = "select * from PASO_A_PASO.Usuario where user_username ='"+usuario+"' and user_password = '"+clave+"'";
            SqlCommand command = new SqlCommand(query, conexion);
            SqlDataReader reader = command.ExecuteReader();
            if (reader.Read()) {
                return new User(reader.GetInt32(0), reader.GetSqlString(1).ToString(), reader.GetSqlString(2).ToString(), reader.GetInt32(3), reader.GetSqlString(4).ToString().ToCharArray()[0], reader.GetDateTime(5));
            }
            return null;
        }

        public void crearUsuario(string usuario, string clave)
        {
            SqlConnection conexion = ServerSQL.instance().levantarConexion();
            
            string query = "insert into PASO_A_PASO.Usuario values(@usuario,@clave,0,'1','1/1/1900')";
            
            MessageBox.Show(query);
            try
            {
                SqlCommand command = new SqlCommand(query, conexion);
                SqlParameter usuarioParam = new SqlParameter();
                usuarioParam.ParameterName = "@usuario";
                usuarioParam.Value = usuario;
                SqlParameter claveParam = new SqlParameter();
                claveParam.ParameterName = "@clave";
                claveParam.Value = clave;
                command.Parameters.Add(claveParam);
                command.Parameters.Add(usuarioParam);
                MessageBox.Show(command.CommandText);
                command.ExecuteNonQuery();
            }
            catch (SqlException e)
            {
                throw e;
            }
        }

        
    }

}
