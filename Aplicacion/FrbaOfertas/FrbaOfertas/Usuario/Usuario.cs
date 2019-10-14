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
    public class User
    {
        private object p1;
        private object p2;
        private object p3;
        private object p4;
        private object p5;
        private object p6;

        public int user_id { get; set; }
        public string user_username { get; set; }
        public string user_password { get; set; }
        public int user_intentosLogin { get; set; }
        public char user_status { get; set; }
        public DateTime user_fechaBaja { get; set; }


        public User(int _id,string _username,string _password,int _intentosLogin,char _status,DateTime _fechaBaja) {

            this.user_id = _id;
            this.user_username = _username;
            this.user_password = _password;
            this.user_intentosLogin = _intentosLogin;
            this.user_status = _status;
            this.user_fechaBaja = _fechaBaja;
        }

        public User()
        {

         }

       
        public List<User> listaUsuarios() {

            ServerSQL serv = new ServerSQL();
            SqlConnection connection = serv.levantarConexion();

            SqlCommand command = new SqlCommand("Select * from PASO_A_PASO.Usuario", connection);
            List<User> listaUsuarios = new List<User>();
            using (SqlDataReader reader = command.ExecuteReader())
            {
                while(reader.Read())
                {

                    listaUsuarios.Add(new User( Convert.ToInt32(reader["user_id"]), reader["user_username"].ToString(), reader["user_password"].ToString(), Convert.ToInt32(reader["user_intentosLogin"]),Convert.ToChar(reader["user_status"]),Convert.ToDateTime(reader["user_fechaBaja"])));
                    
                }
            }
            connection.Close();
            MessageBox.Show("Cantidad de usuarios listados: "+listaUsuarios.Count().ToString());
            return listaUsuarios;
            

        }



    }
}
