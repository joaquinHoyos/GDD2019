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
        public ABMCliente()
        {
            InitializeComponent();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            DataTable clientesFiltrados = PresenterCliente.instance().buscarClientes(this,txtNombre.Text,txtApellido.Text,txtMail.Text,txtDni.Text);
            dataGridView1.DataSource = clientesFiltrados;

        }

       
    }
}
