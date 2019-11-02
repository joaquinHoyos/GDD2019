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
    public partial class AbmRol_Form : Form
    {
        public AbmRol_Form()
        {
            InitializeComponent();
            TopLevel = false;
            FormBorderStyle = FormBorderStyle.None;
        }

        private void btn_Nuevo_Click(object sender, EventArgs e)
        {
            Presenter.instance().cargarTodasFunciones(this);
        }

        private void AbmRol_Form_Load(object sender, EventArgs e)
        {

        }
    }
}
