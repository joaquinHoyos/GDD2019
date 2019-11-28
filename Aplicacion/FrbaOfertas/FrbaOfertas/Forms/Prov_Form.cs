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

namespace FrbaOfertas.Forms
{
    public partial class Prov_Form : Form
    {
        public Prov_Form()
        {
            InitializeComponent();
        }

        private void btn_Ofertas_Click(object sender, EventArgs e)
        {
            Presenter.instance().cargarAbmOfertas(this);
        }

        private void btnCanjear_Click(object sender, EventArgs e)
        {
            Presenter.instance().cargarCanjearCupones(this);
        }

      
             private void btnCerrarSesion_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("¿Seguro que desea cerrar sesion?", "Salir", MessageBoxButtons.YesNo);

            if (result == DialogResult.Yes)
            {
                this.Hide();
                Presenter.instance().logOut();

            }
        }
        

    

     

    }
}
