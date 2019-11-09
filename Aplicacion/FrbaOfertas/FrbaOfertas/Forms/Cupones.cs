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
            var bindingList = new BindingList<Cupon>(RepoCliente.instance().traerCuponesPropios(currentUserID));
            var source = new BindingSource(bindingList, null);
            listBox1.ValueMember = "cupo_id";
            listBox1.DisplayMember = "descripcion";
            listBox1.DataSource = source;
            
            var bindingListA = new BindingList<Cupon>(RepoCliente.instance().traerCuponesPropios(currentUserID));
            var sourceA = new BindingSource(bindingList, null);
            dataGridView1.DataSource = source;
            
           
   
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
