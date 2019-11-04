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

        private void btn_Busqueda_Click(object sender, EventArgs e)
        {
            PresenterAdmin.instance().cargarNuevaBusqueda(this);
        }

        private void btn_Buscar_Click(object sender, EventArgs e)
        {
            DataTable seleccionados = this.obtenerSeleccionados();
            PresenterAdmin.instance().hacerBusqueda(Decimal.Parse(this.txt_id.Text), txt_Nombre.Text, seleccionados,this);
        }

        public void habilitarNuevo()
        {
            this.txt_Nombre.Enabled = true;
            this.btn_Guardar.Enabled = true;
            this.list_Admin.Enabled = true;
            this.list_Cliente.Enabled = true;
            this.list_Proveedor.Enabled = true;
        }

        public void deshabilitarTodo()
        {
            this.txt_Nombre.Enabled = false;
            this.btn_Guardar.Enabled = false;
            this.list_Admin.Enabled = false;
            this.list_Cliente.Enabled = false;
            this.list_Proveedor.Enabled = false;
            this.dataGridView1.Enabled=false;
            this.btn_Buscar.Enabled = false;
            this.btn_Editar.Enabled = false;
            this.btn_Eliminar.Enabled = false;
            this.btn_Guardar.Enabled = false;
        }

        public void habilitarBusqueda()
        {
            this.txt_id.Enabled=true;
            this.txt_Nombre.Enabled=true;
            this.btn_Buscar.Enabled = true;
            this.list_Proveedor.Enabled=true;
            this.list_Cliente.Enabled=true;
            this.list_Admin.Enabled=true;
            this.dataGridView1.Enabled=true;
                    }

        public void borrarTodo()
        {
            this.txt_id.Text = "";
            this.txt_Nombre.Text = "";
            vaciarListBox(this.list_Admin);
            vaciarListBox(this.list_Cliente);
            vaciarListBox(this.list_Proveedor);
            this.dataGridView1.DataSource = null;
         }
        public void vaciarListBox(CheckedListBox list)
        {
            for (int i = list.Items.Count - 1; i > -1; i--){list.Items.RemoveAt(i);}
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

        public void cargarResultadoBusqueda(DataTable tabla)
        {
            this.dataGridView1.DataSource = tabla;
            MessageBox.Show(tabla.Rows.Count.ToString());
            
        }
        
    }

}
