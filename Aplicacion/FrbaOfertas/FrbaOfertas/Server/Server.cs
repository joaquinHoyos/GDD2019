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


namespace FrbaOfertas.Server
{
    public class ServerSQL
    {
        public ServerSQL() { 
        
        }

        public SqlConnection levantarConexion()
        {

            SqlConnection myConnection = new SqlConnection("server=localhost\\SQLSERVER2012;" +
                                           "database=GD2C2019; User ID=gdCupon2019; Password=gd2019");
            try
            {
                myConnection.Open();
                MessageBox.Show("Well done!");
                return myConnection;
            }
            catch (SqlException ex)
            {
                MessageBox.Show("You failed!" + ex.Message);
                return null;
            }

        }
    }
}
