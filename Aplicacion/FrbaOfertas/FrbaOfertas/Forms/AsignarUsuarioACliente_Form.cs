using FrbaOfertas.Presenters;
using FrbaOfertas.Repositorios;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FrbaOfertas.Forms
{
    public partial class AsignarUsuarioACliente_Form : Form
    {
        private String clie_id_seleccionado; 
        public AsignarUsuarioACliente_Form()
        {
            InitializeComponent();
        }

        private void btnCargarClientes_Click(object sender, EventArgs e)
        {

            DataTable clientesFiltrados = PresenterCliente.instance().buscarClientes("", "", "", ""); //esto es para no filtrar por nada
            dataGridView1.DataSource = clientesFiltrados;
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void btnCrearUsuario_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows != null)
            {
               
                DataGridViewRow seleccionados = dataGridView1.SelectedRows[0];
                this.clie_id_seleccionado = seleccionados.Cells[0].Value.ToString();


                DialogResult result = MessageBox.Show("¿Seguro que desea asginar este usuario al cliente: "+this.clie_id_seleccionado.ToString(), "Salir", MessageBoxButtons.YesNo);

                if (result == DialogResult.Yes)
                {

                    RepoCliente.instance().asignarUsuario(this.clie_id_seleccionado, textBox1.Text, textBox2.Text);

                }
               


            }
            else
            {
                MessageBox.Show("Porfavor seleccione algun registro");
            }
        }


    }

}
