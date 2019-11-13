using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FrbaOfertas.Server;
using FrbaOfertas.Modelo;
using FrbaOfertas.Repositorios;

namespace FrbaOfertas.Forms
{
    public partial class AltaProveedor : Form
    {
        public AltaProveedor()
        {
            InitializeComponent();
        }

        private void btn_AltaProveedor_Click(object sender, EventArgs e)
        {
            if (txt_Telefono.Value != 0 && txt_CP.Value != 0)
            {       
                if (txt_Ciudad.Text != "" && txt_Direccion.Text != "" && txt_Mail.Text != "" && txt_Nombre.Text != "")
                    {


                        RepoUsuario.instance().altaProveedor(txt_CUIT.Text,txt_Razon.Text,txt_Mail.Text,Convert.ToInt64(txt_Telefono.Value),txt_Direccion.Text,Convert.ToInt32(txt_CP.Value),txt_Ciudad.Text,Convert.ToInt32(comboBox1.SelectedValue),txt_Nombre.Text);
                        this.Hide();

                    }
                    else
                    {

                        MessageBox.Show("Datos de texto invalidos");

                    }

                
                
            }
            else
            {

                MessageBox.Show("Campos numericos invalidos");

            }
        }

        private void AltaProveedor_Load(object sender, EventArgs e)
        {
            txt_Telefono.Controls[0].Visible = false;
            txt_CP.Controls[0].Visible = false;
            comboBox1.DataSource = RepoRol.instance().buscarPorTodo();
            comboBox1.DisplayMember= "nombre";
            comboBox1.ValueMember = "id";
            
        }
    }
}
