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
    public partial class AbmUsuario_Form : Form
    {
        public int agregando { get; set; }

        public string userIdSeleccionado { get; set; }
        public AbmUsuario_Form()
        {
            InitializeComponent();
        }

        private void btnCrearUsuario_Click(object sender, EventArgs e)
        {
            if (this.agregando == 1)
            {
                List<String> rolesSeleccionados = this.getRolesSeleccionados();
                RepoUsuario.instance().crearUsuario(textBox1.Text, textBox2.Text, rolesSeleccionados);
            }
            else
            {
                List<String> rolesSeleccionados = this.getRolesSeleccionados();
                RepoUsuario.instance().modificarUsuario(textBox1.Text, textBox2.Text, rolesSeleccionados,txtIntentosLogin.Text,this.userIdSeleccionado);

            }

         }

        private List<String> getRolesSeleccionados()
        {

            List<String> rolesSelec = new List<String>();

            foreach (String rolDesc in list_Roles.CheckedItems)
            {

                rolesSelec.Add(rolDesc);
            }
            return rolesSelec;

        }

        private void AbmUsuario_Form_Load(object sender, EventArgs e)
        {
            List<Rol> listaRoles = RepoRol.instance().traerTodosLosRoles();

            for (int i = 0; i < listaRoles.Count; i++)
            {
                list_Roles.Items.Add(listaRoles[i].nombre);
            }
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            DataTable usuariosFiltrados = RepoUsuario.instance().traerUsuariosFiltrados(textBox1.Text);
            dataGridView1.DataSource = usuariosFiltrados;
        }

        
        private void btnSeleccionar_Click(object sender, EventArgs e)
        {
           
            if (dataGridView1.SelectedRows != null)
            {
                DataGridViewRow seleccionados = dataGridView1.SelectedRows[0];
                textBox1.Text = seleccionados.Cells[1].Value.ToString();
                this.userIdSeleccionado = seleccionados.Cells[0].Value.ToString();
                txtFechaBaja.Text = seleccionados.Cells[4].Value.ToString();
                txtIntentosLogin.Text = seleccionados.Cells[3].Value.ToString();
                txtEstado.Text = seleccionados.Cells[2].Value.ToString();

                List<int> rolesUsuario = RepoUsuario.instance().traerRoles(seleccionados.Cells[0].Value.ToString());

                for (int i = 0; i < rolesUsuario.Count; i++)
                {
                    list_Roles.SetItemChecked(rolesUsuario[i]-1, true);
                }

            }
            else
            {
                MessageBox.Show("Porfavor seleccione algun registro");
            }
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            this.agregando = 0;
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            this.agregando = 1;
        }




       
    }
}
