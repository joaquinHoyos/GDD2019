using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FrbaOfertas.Repositorios;
using FrbaOfertas.Modelo;
using FrbaOfertas.Presenters;

namespace FrbaOfertas.Forms
{
    public partial class AbmOfertas : Form
    {
        public AbmOfertas()
        {
            InitializeComponent();
        }

        private void btn_Buscar_Click(object sender, EventArgs e)
        {
            DataTable ofertasFiltradas = PresenterProveedor.instance().filtrarOfertas(txtFiltrarDescripcion.Text);
            dataGridView1.DataSource= ofertasFiltradas;

            
        }
    }
}
