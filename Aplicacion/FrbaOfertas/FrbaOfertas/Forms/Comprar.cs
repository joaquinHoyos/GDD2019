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
    public partial class Comprar : Form
    {

        public int currentUserID;
        public Comprar()
        {
            InitializeComponent();
            TopLevel = false;
            FormBorderStyle = FormBorderStyle.None;
        }

        private void Comprar_Load(object sender, EventArgs e)
        {

            var bindingList = new BindingList<Oferta>(RepoOferta.instance().traerOfertasDisponibles());
            var source = new BindingSource(bindingList, null);
            listBox1.DataSource = source;
            listBox1.DisplayMember = "ofer_descripcion";
            listBox1.ValueMember = "ofer_id";


        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            btn_comprar.Enabled = true;
            txt_cantidad.Enabled = true;
        }

        private void btn_comprar_Click(object sender, EventArgs e)
        {
            if (txt_cantidad.Value > 0)
            {
                String aa = listBox1.SelectedValue.ToString();

                RepoCliente.instance().generarCompra(currentUserID, listBox1.SelectedValue.ToString(), Convert.ToInt32(txt_cantidad.Value));

            }
            else {
                MessageBox.Show("La cantidad debe ser mayor a 0");
            
            }
        }
    }
}
