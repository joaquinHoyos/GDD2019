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
using FrbaOfertas.Usuario;

namespace FrbaOfertas.LoginUsuario
{
    public partial class LoginUsuario : Form
    {
        public LoginUsuario()
        {
            InitializeComponent();
        }

        private void btnIngresar_Click(object sender, EventArgs e)
        {
            string usuario=txtUsername.Text;
            string clave=txtPassword.Text;
            User user = RepoUsuario.instance().buscarUsuarioPorClave(usuario,clave);
            if (user!=  null) { 
                MessageBox.Show("todo ok, habria que redireccionar");
                    return;
            }
            MessageBox.Show("Error: contraseña o usuario incorrecto");
           
        }

        private void linkLabel3_LinkClicked(object sender, System.Windows.Forms.LinkLabelLinkClickedEventArgs e)
        {
            SignUpUsuario signup =new SignUpUsuario();
            signup.Show();
        }
    }
}
