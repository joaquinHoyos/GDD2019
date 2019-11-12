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
    public partial class Admin_Form : Form
    {
        public Admin_Form()
        {
            InitializeComponent();
        }

        private void btn_Roles_Click(object sender, EventArgs e)
        {
            Presenter.instance().cargarAbmRol(this);
        }

        private void btnClientes_Click(object sender, EventArgs e)
        {
            Presenter.instance().cargarAbmClientes(this);
        }
    }
}
