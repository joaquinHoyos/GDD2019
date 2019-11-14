using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;


namespace FrbaOfertas.Server
{
    public class ServerSQL
    {
        private static ServerSQL server;
        private ServerSQL() { 
        }

        public static ServerSQL instance(){
            return server==null?server=new ServerSQL():server;
        }
        public SqlConnection levantarConexion()
        {
            Properties.Settings set = new Properties.Settings();
            SqlConnection myConnection = new SqlConnection(set.Server);
            try
            {
                myConnection.Open();
               // MessageBox.Show("Well done!");
                return myConnection;
            }
            catch (SqlException ex)
            {
                //MessageBox.Show("You failed!" + ex.Message);
                return null;
            }

        }

        
    }
}
