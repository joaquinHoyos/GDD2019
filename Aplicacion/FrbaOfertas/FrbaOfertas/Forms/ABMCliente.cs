using FrbaOfertas.Presenters;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FrbaOfertas.Modelo;

namespace FrbaOfertas.Forms
{
    public partial class ABMCliente : Form
    {
       
        private bool agregando;
        private String clie_id_seleccionado;

        public ABMCliente()
        {
            agregando = false;
            InitializeComponent();
            TopLevel = false;
            FormBorderStyle = FormBorderStyle.None;
           
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            string nombre, apellido, mail;
            nombre = txtNombre.Text;
            apellido = txtApellido.Text;
            mail = txtMail.Text;
           
          
           
            btnGuardar.Enabled = false;
            txtNombre.Enabled = false;
            txtApellido.Enabled = false;
            txtDni.Enabled = false;
            txtMail.Enabled = false;
            btnBuscar.Enabled = false;
            btn_Editar.Enabled = false;
            btnSeleccionar.Enabled = false;
            btnDeshabilitar.Enabled = false;
            dateTimePicker1.Enabled = false;

            txtDireccion.Enabled = false;
            txtTelefono.Enabled = false;
            txtCiudad.Enabled = false;
            txtCodigoPostal.Enabled = false;

            btnSeleccionar.Enabled = true;


            if (nombre == "")
            {
                nombre = "DEFAULT";
            }
            if (apellido == "")
            {
                apellido = "DEFAULT";
            }
            if (mail == "")
            {
                mail = "DEFAULT";
            }

            DataTable clientesFiltrados = PresenterCliente.instance().buscarClientes(this, nombre, apellido, mail, txtDni.Text);
            dataGridView1.DataSource = clientesFiltrados;
            this.limpiarTodosLosTXT();
        }

        private void btn_Nuevo_Click(object sender, EventArgs e)
        {
            btnSeleccionar.Enabled = false;
            this.limpiarTodosLosTXT();
            btnGuardar.Enabled = true;
            btnBuscar.Enabled = false;
            btn_Editar.Enabled = false;
            btnDeshabilitar.Enabled = false;


            this.agregando = true;


            txtApellido.Enabled = true;
            txtNombre.Enabled = true;
            txtDni.Enabled = true;
            dateTimePicker1.Enabled = true;
            txtMail.Enabled = true;
            txtDireccion.Enabled = true;
            txtTelefono.Enabled = true;
            txtCiudad.Enabled = true;
            txtCodigoPostal.Enabled=true;

            txtSaldo.Text = "200"; //TODOS LOS NUEVOS USUARIOS SE CARGAN CON 200 PESOS
                 
        }

        private void btn_Guardar_Click(object sender, EventArgs e)
        {
            if (this.validarTXT())
            {
                if (this.agregando)
                {
                    //FALTA VALIDAD QUE NADA SEA NULL
                    PresenterCliente.instance().crearNuevoCliente(txtNombre.Text, txtApellido.Text, txtDni.Text, txtMail.Text, txtTelefono.Text, txtSaldo.Text, txtDireccion.Text, txtCiudad.Text, txtCodigoPostal.Text, dateTimePicker1.Value.ToShortDateString());

                }
                else
                {
                    PresenterCliente.instance().modificarCliente(this.clie_id_seleccionado, txtNombre.Text, txtApellido.Text, txtDni.Text, txtMail.Text, txtTelefono.Text, txtSaldo.Text, txtDireccion.Text, txtCiudad.Text, txtCodigoPostal.Text, dateTimePicker1.Value.ToShortDateString());
                }

                this.reiniciarTodo();
            }
            else
            {
                MessageBox.Show("Porfavor no deje ningun campo en blanco, completelos antes de Guardar");

            }
        }

        private void btn_Busqueda_Click(object sender, EventArgs e)
        {
            this.limpiarTodosLosTXT();
            this.agregando = false;
            btnGuardar.Enabled = false;
            txtNombre.Enabled = true;
            txtApellido.Enabled = true;
            txtDni.Enabled = true;
            txtMail.Enabled = true;
            btnBuscar.Enabled = true;
            btn_Editar.Enabled = false;
            btnSeleccionar.Enabled = false;
            btnDeshabilitar.Enabled = false;
            dateTimePicker1.Enabled = false;

            txtDireccion.Enabled = false;
            txtTelefono.Enabled = false;
            txtCiudad.Enabled = false;
            txtCodigoPostal.Enabled = false;
        }

        private void limpiarTodosLosTXT()
        {

            txtApellido.Text = "";
            txtNombre.Text = "";
            txtDni.Text = "";

            txtMail.Text = "";
            txtDireccion.Text = "";
            txtTelefono.Text = "";
            txtCiudad.Text = "";
            txtCodigoPostal.Text = "";
            txtSaldo.Text = "";
        }

        private void deshabilitarTodosLosBotones()
        {
            btnGuardar.Enabled = false;
            btn_Editar.Enabled = false;
            btnSeleccionar.Enabled = false;
            btn_Nuevo.Enabled = false;
            btn_Busqueda.Enabled = false;
            btnBuscar.Enabled = false;
            btnDeshabilitar.Enabled = false;

        }
        private void btn_Seleccionar_Click(object sender, EventArgs e)
        {


            if (dataGridView1.SelectedRows != null && dataGridView1.Rows.Count > 0)
            {
                btnBuscar.Enabled = false;
                btnGuardar.Enabled = false;
                btn_Editar.Enabled = true;
                btnDeshabilitar.Enabled = true;
                this.setearTXT(false);
                DataGridViewRow seleccionados = dataGridView1.SelectedRows[0];
                this.clie_id_seleccionado = seleccionados.Cells[0].Value.ToString();
                txtNombre.Text = seleccionados.Cells[2].Value.ToString();
                txtApellido.Text = seleccionados.Cells[3].Value.ToString();
                txtDni.Text = seleccionados.Cells[1].Value.ToString();
                txtDireccion.Text = seleccionados.Cells[4].Value.ToString();
                txtMail.Text = seleccionados.Cells[5].Value.ToString();
                txtTelefono.Text = seleccionados.Cells[6].Value.ToString();
                txtSaldo.Text = seleccionados.Cells[7].Value.ToString();
                txtCiudad.Text = seleccionados.Cells[8].Value.ToString();
                dateTimePicker1.Value = Convert.ToDateTime(seleccionados.Cells[9].Value);
                txtCodigoPostal.Text = seleccionados.Cells[10].Value.ToString();
            }
            else
            {
                MessageBox.Show("Porfavor seleccione algun registro");
            }

        }

        private void btn_Editar_Click(object sender, EventArgs e)
        {
            btnBuscar.Enabled = false;
            this.agregando = false;
            this.setearTXT(true);
            btnGuardar.Enabled = true;
        }

        private void reiniciarTodo()
        {
            this.setearTXT(false);
            this.limpiarTodosLosTXT();
            this.deshabilitarTodosLosBotones();
            btn_Busqueda.Enabled = true;
            btn_Nuevo.Enabled = true;

        }
        private void setearTXT(bool valor)
        {

            txtApellido.Enabled = valor;
            txtNombre.Enabled = valor;
            txtDni.Enabled = valor;

            txtMail.Enabled = valor;
            txtDireccion.Enabled = valor;
            txtTelefono.Enabled = valor;
            txtCiudad.Enabled = valor;
            txtCodigoPostal.Enabled = valor;
            txtSaldo.Enabled = valor;
            dateTimePicker1.Enabled = valor;
        }


        private bool validarTXT()
        {
            if (txtApellido.Text != "" && txtNombre.Text != "" && txtDni.Text != "" && txtMail.Text != "" && txtDireccion.Text != "" && txtTelefono.Text != "" && txtCiudad.Text != "" && txtCodigoPostal.Text != "" && txtSaldo.Text != "" && dateTimePicker1.Text != "")
            {
                return true;
            }

            return false;
        }

        private void btnDeshabilitar_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("¿Seguro que desea deshabilitar el cliente?", "Salir", MessageBoxButtons.YesNo);

            if (result == DialogResult.Yes)
            {
                this.reiniciarTodo();
              PresenterCliente.instance().deshabilitarCliente(this.clie_id_seleccionado);
                
            }
           
        }

        private void btnAsignarUsuario_Click(object sender, EventArgs e)
        {
            AsignarUsuarioACliente_Form form = new AsignarUsuarioACliente_Form();
            form.Show();
        }

        private void ABMCliente_Load(object sender, EventArgs e)
        {

        }

    }
}
