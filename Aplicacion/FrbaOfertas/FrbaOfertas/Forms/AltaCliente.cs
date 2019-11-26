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
using FrbaOfertas.Presenters;

namespace FrbaOfertas
{
    public partial class AltaCliente : Form
    {
        public AltaCliente()
        {
            InitializeComponent();
        }

        private void AltaCliente_Load(object sender, EventArgs e)
        {
            txt_DNI.Controls[0].Visible = false;
            txt_Telefono.Controls[0].Visible = false;
            txt_CP.Controls[0].Visible = false;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btn_AltaCliente_Click(object sender, EventArgs e)
        {
            if (txt_DNI.Value != 0 && txt_Telefono.Value != 0 && txt_CP.Value != 0)
            {
                if (dateTimePicker1.Value != null)
                {
                    if (txt_Apellido.Text != "" && txt_Ciudad.Text != "" && txt_Direccion.Text != "" && txt_Mail.Text != "" && txt_Nombre.Text != "")
                    {


                        RepoUsuario.instance().altaCliente(txt_Nombre.Text, txt_Apellido.Text, Convert.ToInt64(txt_DNI.Value), Convert.ToInt32(txt_CP.Value), txt_Direccion.Text, txt_Ciudad.Text, txt_Mail.Text, Convert.ToInt64(txt_Telefono.Value), dateTimePicker1.Value);
                        this.Hide();
                        Presenter.instance().postAltaCliente();
                    }
                    else {

                        MessageBox.Show("Datos de texto invalidos");
                    
                    }

                }
                else {


                    MessageBox.Show("Fecha invalida");
                
                }


            }
            else {

                MessageBox.Show("Campos numericos invalidos");
            
            }
        }
    }
}
