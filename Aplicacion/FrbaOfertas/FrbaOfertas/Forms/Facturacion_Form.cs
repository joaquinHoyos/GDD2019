using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FrbaOfertas.Presenters;
using FrbaOfertas.Repositorios;

namespace FrbaOfertas.Forms
{
    public partial class Facturacion_Form : Form
    {
        public Facturacion_Form()
        {
            InitializeComponent();
            TopLevel = false;
            FormBorderStyle = FormBorderStyle.None;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Facturacion_Form_Load(object sender, EventArgs e)
        {

            DataTable proveedores = PresenterAdmin.instance().getProveedores();
            dataGridView1.DataSource = proveedores;
        }

        private void btnFacturar_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows != null)
            {
                DataGridViewRow seleccionados = dataGridView1.SelectedRows[0];
                int idProv = Convert.ToInt32(seleccionados.Cells[0].Value.ToString());


                RepoFactura.instance().facturar(Convert.ToDateTime(txtFechaInicio.Text), Convert.ToDateTime(txtFechaFinal.Text), idProv);
                
            }

        }
    }
}
