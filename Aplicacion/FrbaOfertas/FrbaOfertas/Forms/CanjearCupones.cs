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
using FrbaOfertas.Modelo;

namespace FrbaOfertas.Forms
{
    public partial class CanjearCupones : Form
    {
        public CanjearCupones()
        {
            InitializeComponent();
            TopLevel = false;
            FormBorderStyle = FormBorderStyle.None;
        }

        private void CanjearCupones_Load(object sender, EventArgs e)
        {

        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            int num;
            bool esNumero = int.TryParse(txtDni.Text, out num);
            if (esNumero)
            {
                int cliente = Convert.ToInt32(txtDni.Text);
                DataTable cupones = PresenterProveedor.instance().traerCuponesNoCanjeadosDeProveedorActual(cliente);
                dataGridView1.DataSource = cupones;
            }
            else
            {
                MessageBox.Show("Ingrese un DNI correcto");
            }
        }

        private void btnCanjear_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows != null)
            {
                DataGridViewRow seleccionados = dataGridView1.SelectedRows[0];
                int cupon = Convert.ToInt32(seleccionados.Cells[0].Value);
                PresenterProveedor.instance().canjearCupon(cupon);
            }
            else
            {
                MessageBox.Show("Seleccione un cupon");
            }
        }
    }
}


