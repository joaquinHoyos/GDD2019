using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FrbaOfertas.Usuario;
using FrbaOfertas.Server;
using System.Data.SqlClient;

namespace FrbaOfertas.LoginUsuario
{
    public partial class SignUpUsuario : Form
    {
        public SignUpUsuario()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnSignUp_Click(object sender, EventArgs e)
        {
            string clave = txtPassword.Text;
            string confirmClave = txtConfirmPassword.Text;
            string usuario = txtUsername.Text;
            if (clave == confirmClave)
            {
                try
                {
                    RepoUsuario.instance().crearUsuario(usuario, clave);
                    MessageBox.Show("sign up bien");
                }
                catch (SqlException ex)
                {
                    MessageBox.Show("loguea mal");
                }
            }
            else {
                MessageBox.Show()"Las claves ingresadas no coinciden");
            }
        }
    }
}
