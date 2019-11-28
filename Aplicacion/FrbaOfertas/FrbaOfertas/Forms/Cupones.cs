using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FrbaOfertas.Server;
using FrbaOfertas.Modelo;
using FrbaOfertas.Repositorios;

namespace FrbaOfertas.Forms
{
    public partial class Cupones : Form
    {
        public int currentUserID;
        public Cupones()
        {
            InitializeComponent();
            TopLevel = false;
            FormBorderStyle = FormBorderStyle.None;
        }

        private void Cupones_Load(object sender, EventArgs e)
        {
            this.dataGridView1.SelectionMode =
            DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.MultiSelect = false;
            var bindingList = new BindingList<Cupon>(RepoCliente.instance().traerCuponesPropios(currentUserID));
            var source = new BindingSource(bindingList, null);            
            dataGridView1.DataSource = source;

            var listaBind = new BindingList<Cliente>(RepoCliente.instance().traerClientes());
            var sourceClientes = new BindingSource(listaBind, null);            
            cmb_Clientes.DataSource = sourceClientes;
            cmb_Clientes.DisplayMember = "nombreYApellido";
            cmb_Clientes.ValueMember = "clie_id";
            
           
   
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            btn_Regalar.Enabled = true;
            cmb_Clientes.Enabled = true;
        }

        private void btn_Regalar_Click(object sender, EventArgs e)
        {
            if (cmb_Clientes.Text != "")
            {
                int selectedrowindex = dataGridView1.SelectedCells[0].RowIndex;
                DataGridViewRow selectedRow = dataGridView1.Rows[selectedrowindex];
                int idCupon = Convert.ToInt32(selectedRow.Cells["cupo_id"].Value);


                RepoCliente.instance().regalarCupon(idCupon, Convert.ToInt32(cmb_Clientes.SelectedValue));
                var bindingList = new BindingList<Cupon>(RepoCliente.instance().traerCuponesPropios(currentUserID));
                var source = new BindingSource(bindingList, null);
                dataGridView1.DataSource = source;
            }
            else
            {
                MessageBox.Show("Debe ingresar un cliente");
            }

        }

       
    }
}
