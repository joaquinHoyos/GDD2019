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

     

        private void AsignarUsuarioACliente_Form_Load(object sender, EventArgs e)
        {
            DataTable clientesFiltrados = PresenterCliente.instance().buscarClientes("", "", "", ""); //esto es para no filtrar por nada
            dataGridView1.DataSource = clientesFiltrados;

            DataTable usuariosFiltrados = RepoUsuario.instance().traerUsuariosFiltrados("");

            dataGridView2.DataSource = usuariosFiltrados;

        }

        private void btnAsignar_Click(object sender, EventArgs e)
        {
            try
            {

                if (dataGridView1.SelectedRows != null && dataGridView2.SelectedRows != null)
                {
                    DataGridViewRow cliente = this.dataGridView1.SelectedRows[0];
                    DataGridViewRow usuario = this.dataGridView2.SelectedRows[0];

                    string idUsuario = usuario.Cells[0].Value.ToString();
                    string idcliente = cliente.Cells[0].Value.ToString();

                    RepoUsuario.instance().asignarCliente(idUsuario, idcliente);
                }

                MessageBox.Show("Usuario asignado correctamente al cliente");
                this.RecargarForm();
            }
            catch (Exception err)
            {
                MessageBox.Show("Error al asignar al cliente: " + err.Message);
            }
        }

        private void RecargarForm()
        {
            DataTable clientesFiltrados = PresenterCliente.instance().buscarClientes("", "", "", ""); //esto es para no filtrar por nada
            dataGridView1.DataSource = clientesFiltrados;

            DataTable usuariosFiltrados = RepoUsuario.instance().traerUsuariosFiltrados("");

            dataGridView2.DataSource = usuariosFiltrados;
        }



    }

}
