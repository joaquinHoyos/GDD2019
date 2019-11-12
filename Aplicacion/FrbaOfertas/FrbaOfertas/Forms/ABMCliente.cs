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
        public ABMCliente()
        {
            agregando = false;
            InitializeComponent();
            TopLevel = false;
            FormBorderStyle = FormBorderStyle.None;
           
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            DataTable clientesFiltrados = PresenterCliente.instance().buscarClientes(this,txtNombre.Text,txtApellido.Text,txtMail.Text,txtDni.Text);
            dataGridView1.DataSource = clientesFiltrados;

        }

        private void btn_Nuevo_Click(object sender, EventArgs e)
        {
            btn_Guardar.Enabled = true;
            btn_Busqueda.Enabled = false;
            this.agregando = true;


            txtApellido.Enabled = true;
            txtNombre.Enabled = true;
            txtDni.Enabled = true;
            txtFechaNac.Enabled = true;
            txtMail.Enabled = true;
            txtDireccion.Enabled = true;
            txtTelefono.Enabled = true;
            txtCiudad.Enabled = true;
            txtCodigoPostal.Enabled=true;

            txtSaldo.Text = "200"; //TODOS LOS NUEVOS USUARIOS SE CARGAN CON 200 PESOS
                 
        }

        private void btn_Guardar_Click(object sender, EventArgs e)
        {
            if (this.agregando)
            {
                //FALTA VALIDAD QUE NADA SEA NULL
                PresenterCliente.instance().crearNuevoCliente(txtNombre.Text, txtApellido.Text, txtDni.Text, txtMail.Text, txtTelefono.Text, txtSaldo.Text, txtDireccion.Text, txtCiudad.Text, txtCodigoPostal.Text, txtFechaNac.Text);

            }
        }

       
    }
}
