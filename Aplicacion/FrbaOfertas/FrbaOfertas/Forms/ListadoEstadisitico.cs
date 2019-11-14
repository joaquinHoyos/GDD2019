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
    public partial class ListadoEstadisitico : Form
    {
        public ListadoEstadisitico()
        {
            InitializeComponent();
            TopLevel = false;
            FormBorderStyle = FormBorderStyle.None;
        }

        private void btn_descuentos_Click(object sender, EventArgs e)
        {
            if (combo_descuentos.SelectedItem == null) { MessageBox.Show("Error: Elija un semestre"); }
            else
            {
                int semestre = Convert.ToInt32(this.combo_descuentos.SelectedItem);
                DataTable resultado = PresenterAdmin.instance().listadoEstadisticoDescuentos(semestre, this.nud_anioDescuentos.Value, this);
                this.cargarResultado(resultado, grid_descuentos);
            }
        }

        private void btn_ventas_Click(object sender, EventArgs e)
        {
            if (combo_ventas.SelectedItem == null) { MessageBox.Show("Error: Elija un semestre"); }
            else
            {
                int semestre = Convert.ToInt32(this.combo_ventas.SelectedItem);
                DataTable resultado = PresenterAdmin.instance().listadoEstadisticoVentas(semestre, this.nud_anioDescuentos.Value, this);
                this.cargarResultado(resultado, grid_ventas);
            }

        }

        private void cargarResultado(DataTable resultado, DataGridView grid)
        {
            grid.DataSource = resultado;
        }
    }
}
