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
            PresenterAdmin.instance().cargarNuevoRol(this);
        }






        public void habilitarNuevo()
        {
            this.txt_Nombre.Enabled = true;
            this.btn_Guardar.Enabled = true;
            this.list_Admin.Enabled = true;
            this.list_Cliente.Enabled = true;
            this.list_Proveedor.Enabled = true;
        }

        private void btn_Guardar_Click(object sender, EventArgs e)
        {

            DataTable funciones = this.obtenerSeleccionados();
            PresenterAdmin.instance().crearNuevoRol(txt_Nombre.Text, funciones);
        }

        private DataTable obtenerSeleccionados()
        {
            DataTable funciones = new DataTable();
            DataColumn columna = new DataColumn();
            columna.ColumnName = "funciones";
            funciones.Columns.Add(columna);
            foreach (string funcion in this.list_Admin.SelectedItems)
            {
                DataRow row = funciones.NewRow();
                row["funciones"] = funcion;
                funciones.Rows.Add(row);
            }
            foreach (string funcion in this.list_Cliente.SelectedItems)
            {
                DataRow row = funciones.NewRow();
                row["funciones"] = funcion;
                funciones.Rows.Add(row);
            }
            foreach (string funcion in this.list_Proveedor.SelectedItems)
            {
                DataRow row = funciones.NewRow();
                row["funciones"] = funcion;
                funciones.Rows.Add(row);
            }
            return funciones;
        }

        private void AbmRol_Form_Load(object sender, EventArgs e)
        {

        }
    }

}
