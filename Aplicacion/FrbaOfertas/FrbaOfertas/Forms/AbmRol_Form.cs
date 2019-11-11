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
using FrbaOfertas.Modelo;

namespace FrbaOfertas.Forms
{
    public partial class AbmRol_Form : Form
    {
        public AbmRol_Form()
        {
            InitializeComponent();
            TopLevel = false;
            FormBorderStyle = FormBorderStyle.None;
            nud_id.Controls[0].Visible = false;
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
            PresenterAdmin.instance().hacerBusqueda(nud_id.Value, txt_Nombre.Text, seleccionados,this);
            PresenterAdmin.instance().formRol_buscar(this);
        }

        public void habilitarLists(bool estado)
        {
            this.list_Admin.Enabled=estado;
            this.list_Proveedor.Enabled=estado;
            this.list_Cliente.Enabled = estado;
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
            this.btn_Seleccionar.Enabled = false;
            this.btn_Guardar.Enabled = false;
        }

        public void habilitarBusqueda()
        {
            this.nud_id.Enabled=true;
            this.txt_Nombre.Enabled=true;
            this.btn_Buscar.Enabled = true;
            this.list_Proveedor.Enabled=true;
            this.list_Cliente.Enabled=true;
            this.list_Admin.Enabled=true;
            this.dataGridView1.Enabled=true;
                    }

        public void borrarTodo()
        {
            this.nud_id.Value = 0;
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
            foreach (string funcion in this.list_Admin.CheckedItems)
            {
                DataRow row = funciones.NewRow();
                row["funciones"] = (int) Enum.Parse(typeof(EnumFunciones), funcion);
                funciones.Rows.Add(row);
            }
            foreach (string funcion in this.list_Cliente.CheckedItems)
            {
                DataRow row = funciones.NewRow();
                row["funciones"] = (int) Enum.Parse(typeof(EnumFunciones), funcion);
                funciones.Rows.Add(row);
            }
            foreach (string funcion in this.list_Proveedor.CheckedItems)
            {
                DataRow row = funciones.NewRow();
                row["funciones"] = (int) Enum.Parse(typeof(EnumFunciones), funcion);
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
        }

        public void habilitarSeleccionar(bool estado){this.btn_Seleccionar.Enabled = estado;}
       
        public void habilitarEditar(bool estado){this.btn_Editar.Enabled=estado;}
        
        public void habilitarGuardar(bool estado){this.btn_Guardar.Enabled=estado;;}
        
        public void habilitarBuscar(bool estado){this.btn_Buscar.Enabled=estado;}
 
        public void habilitarEliminar(bool estado){}
 
        public void habilitarNombre(bool estado){ this.txt_Nombre.Enabled=false;}

        public void habilitarId(bool estado){this.nud_id.Enabled=estado;}

        public void vaciarTextsBox()
        {
            this.txt_Nombre.Text="";
            this.nud_id.Value=0;
        }

        private void btn_Editar_Click(object sender, EventArgs e)
        {
            PresenterAdmin.instance().formRol_editar(this);

        }

        private void btn_Seleccionar_Click(object sender, EventArgs e)
        {
            PresenterAdmin.instance().seleccionarRol(this);
            PresenterAdmin.instance().formRol_seleccionar(this);
        }

        public void cargarFunciones(List<structFuncion> funciones)
        {
            foreach (structFuncion func in funciones)
            {
                if (func.grupo == 'A')
                {
                    int index;
                    for (int i = 0; i < list_Admin.Items.Count; i++)
                    {
                        if(list_Admin.Items[i]==Enum.GetName(typeof(EnumFunciones),func.funcion){index = i;}
                    }

                    this.list_Admin.SetItemChecked(index, true);

                }
                else if (func.grupo == 'C')
                {
                    int index;
                    for (int i = 0; i < list_Cliente.Items.Count; i++)
                    {
                        if(list_Cliente.Items[i]==Enum.GetName(typeof(EnumFunciones),func.funcion){index = i;}
                    }

                    this.list_Cliente.SetItemChecked(index, true);

                }
                else
                {
                    int index;
                    for (int i = 0; i < list_Proveedor.Items.Count; i++)
                    {
                        if(list_Proveedor.Items[i]==Enum.GetName(typeof(EnumFunciones),func.funcion){index = i;}
                    }

                    this.list_Proveedor.SetItemChecked(index, true);

                }
            }
        }

        public void cargarNombre(string nombre)
        {
            this.txt_Nombre.Text = nombre;
        }

        public void cargarId(int id)
        {
            this.nud_id.Value = id;
        }
    }

}
