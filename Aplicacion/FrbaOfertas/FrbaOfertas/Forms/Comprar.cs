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
            dataGridView1.DataSource= source;

        }
    }
}
