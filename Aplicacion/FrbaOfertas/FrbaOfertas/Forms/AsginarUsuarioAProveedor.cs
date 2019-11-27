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
    public partial class AsginarUsuarioAProveedor : Form
    {
        public AsginarUsuarioAProveedor()
        {
            InitializeComponent();
        }

        private void AsginarUsuarioAProveedor_Load(object sender, EventArgs e)
        {
            DataTable provFitrados = PresenterProveedor.instance().buscarProveedoresSinUsuario(); 
            dataGridView1.DataSource = provFitrados;

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
                    string idProv = cliente.Cells[0].Value.ToString();

                    RepoUsuario.instance().asignarProv(idUsuario, idProv);

                  //  string idUsuarioDelProv =  RepoUsuario.instance().getUsuario(
                  //  List<int> idRolesUsuario = RepoUsuario.instance().traerRoles(idUsuarioDelProv);

                }

                MessageBox.Show("Usuario asignado correctamente al proveedor");
                this.RecargarForm();
            }
            catch (Exception err)
            {
                MessageBox.Show("Error al asignar al proveedor: " + err.Message);
            }
        }

        private void RecargarForm()
        {

            DataTable provFitrados = PresenterProveedor.instance().buscarProveedoresSinUsuario(); //esto es para no filtrar por nada
            dataGridView1.DataSource = provFitrados;

            DataTable usuariosFiltrados = RepoUsuario.instance().traerUsuariosFiltrados("");

            dataGridView2.DataSource = usuariosFiltrados;
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }

      

}
