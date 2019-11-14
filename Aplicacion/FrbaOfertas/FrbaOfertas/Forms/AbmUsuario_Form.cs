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
            TopLevel = false;
            FormBorderStyle = FormBorderStyle.None;
        }

        private void btnCrearUsuario_Click(object sender, EventArgs e)
        {
            if (this.validarTxt())
            {
                try
                {
                    if (this.agregando == 1)
                    {
                        List<String> rolesSeleccionados = this.getRolesSeleccionados();
                        RepoUsuario.instance().crearUsuario(textBox1.Text, textBox2.Text, rolesSeleccionados);
                        MessageBox.Show("Usuario dado de alta con exito");
                    }
                    else
                    {
                        List<String> rolesSeleccionados = this.getRolesSeleccionados();
                        RepoUsuario.instance().modificarUsuario(textBox1.Text, textBox2.Text, rolesSeleccionados, txtIntentosLogin.Text, this.userIdSeleccionado);
                        MessageBox.Show("Usuario modificado con exito");
                    }


                }
                catch (Exception err)
                {
                    MessageBox.Show("Error al guardar el usuario: " + err.Message);
                }

                this.volverAlIncio();
            }
            else
            {
                MessageBox.Show("Porfavor complete todos los campos con valores logicos");
            }
         }
        private bool validarTxt()
        {
            if (txtEstado.Text != "" && txtFechaBaja.Text != "" && txtIntentosLogin.Text != "" && textBox1.Text != "" && textBox2.Text != "")
            {
                if (this.IsNumeric(txtIntentosLogin.Text))
                {

                    return true;
                }
            }
            return false;
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

        public bool IsNumeric(string valor)
        {
            int result;
            return int.TryParse(valor, out result);
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

            btnSeleccionar.Enabled = true;
            

            DataTable usuariosFiltrados = RepoUsuario.instance().traerUsuariosFiltrados(textBox1.Text);
            dataGridView1.DataSource = usuariosFiltrados;
        }

        
        private void btnSeleccionar_Click(object sender, EventArgs e)
        {
            btnEditar.Enabled = true;
            btnDeshabilitar.Enabled = true;
            btnHabilitar.Enabled = true;

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
            btnCrearUsuario.Enabled = true;
            textBox1.Enabled = true;
            txtIntentosLogin.Enabled = true;
            list_Roles.Enabled = true;
            textBox2.Enabled = true;
            this.agregando = 0;
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            btnBuscar.Enabled = false;
            textBox1.Enabled = true;
            textBox2.Enabled = true;
            list_Roles.Enabled = true;
            txtEstado.Text = "E";
            txtFechaBaja.Text = "1/1/1900";
            txtIntentosLogin.Enabled = true;
            btnCrearUsuario.Enabled = true;

            this.agregando = 1;
        }

        private void btnDeshabilitar_Click(object sender, EventArgs e)
        {
            try
            {
                RepoUsuario.instance().deshabilitarUsuario(this.userIdSeleccionado);
                MessageBox.Show("Usuario deshabilitado correctamente");
            }
            catch (Exception err)
            {
                MessageBox.Show("Error al deshabilitar usuario: " + err.Message);
            }
            this.volverAlIncio();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void btnHabilitar_Click(object sender, EventArgs e)
        {
            try
            {
                RepoUsuario.instance().habilitarUsuario(this.userIdSeleccionado);
                MessageBox.Show("Usuario habilitado correctamente");
            }
            catch (Exception err)
            {
                MessageBox.Show("Error al habilitar usuario: " + err.Message);
            }
            this.volverAlIncio();
        }

        private void btnBusqueda_Click(object sender, EventArgs e)
        {
            textBox1.Enabled = true;
            list_Roles.Enabled = true;
            btnBusqueda.Enabled = true;
            btnBuscar.Enabled = true;
            btnCrearUsuario.Enabled = false;
        }


        private void volverAlIncio()
        {
            textBox1.Text = "";
            txtEstado.Text = "";
            textBox2.Text = "";
            txtIntentosLogin.Text = "";

            txtFechaBaja.Text = "";

            textBox1.Enabled = false;
            textBox2.Enabled = false;
            list_Roles.Enabled = false;
            btnSeleccionar.Enabled = false;
            btnDeshabilitar.Enabled = false;
            btnHabilitar.Enabled = false;
            btnEditar.Enabled = false;
            txtIntentosLogin.Enabled = false;
            
        }


       
    }
}
