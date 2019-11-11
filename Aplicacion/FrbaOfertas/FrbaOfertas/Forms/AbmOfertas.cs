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
            btn_Editar.Enabled = false;
            btn_Eliminar.Enabled = false;
            DataTable ofertasFiltradas = PresenterProveedor.instance().filtrarOfertas(txtFiltrarDescripcion.Text,Convert.ToDateTime(txtFiltroFecha.Text));
            dataGridView1.DataSource= ofertasFiltradas;

            
        }

        private void btn_Busqueda_Click(object sender, EventArgs e)
        {
            btn_Editar.Enabled = false;
            btn_Eliminar.Enabled = false;
            btn_Guardar.Enabled = false;
            btn_Buscar.Enabled = true;
            txtFiltroFecha.Enabled = true;
            txtFiltrarDescripcion.Enabled = true;
            txtCantDisponible.Enabled = false;
            txtDescripcion.Enabled = false;
            txtId.Enabled = false;
            txtPrecioLista.Enabled = false;
            txtPrecioOferta.Enabled = false;
            txtMaxCantUsuario.Enabled = false;
            txtFechaInicio.Enabled = false;
            txtFechaVenc.Enabled = false;
            dataGridView1.Rows.Clear();

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewSelectedColumnCollection seleccionados = dataGridView1.SelectedColumns;
            txtId.Text = seleccionados[0].ToString();
            txtDescripcion.Text = seleccionados[1].ToString();
            txtFechaInicio.Text = seleccionados[2].ToString();
            txtFechaVenc.Text = seleccionados[3].ToString();
            txtPrecioOferta.Text = seleccionados[4].ToString();
            txtPrecioLista.Text = seleccionados[5].ToString();
            txtCantDisponible.Text = seleccionados[6].ToString();
            txtMaxCantUsuario.Text = seleccionados[7].ToString();
           
            txtId.Enabled = false;
            txtDescripcion.Enabled = true;
            txtFechaInicio.Enabled = true;
            txtFechaVenc.Enabled = true;
            txtPrecioOferta.Enabled = true;
            txtPrecioLista.Enabled = true;
            txtCantDisponible.Enabled = true;
            txtMaxCantUsuario.Enabled = true;
            btn_Eliminar.Enabled = true;
            btn_Editar.Enabled = true;

            txtFiltroFecha.Enabled = false;
            txtFiltrarDescripcion.Enabled = false;
        }


        private void btn_Guardar_Click(object sender, EventArgs e)
        {
            int num;
            bool esNumero = int.TryParse(txtCantDisponible.Text, out num);
            bool esNumero1 = int.TryParse(txtMaxCantUsuario.Text, out num);

            if (esNumero && esNumero1)
            {

                if (txtId.Enabled)
                {
                    Oferta oferta = new Oferta(txtId.Text, txtDescripcion.Text, Convert.ToDateTime(txtFechaInicio.Text), Convert.ToDateTime(txtFechaVenc.Text), Convert.ToDouble(txtPrecioOferta.Text), Convert.ToDouble(txtPrecioLista.Text), PresenterProveedor.instance().getProveedorActual(), Convert.ToInt32(txtCantDisponible.Text), Convert.ToInt32(txtMaxCantUsuario.Text));
                    PresenterProveedor.instance().nuevaOferta(oferta);
                }
                else
                {
                    Oferta oferta = new Oferta(txtId.Text, txtDescripcion.Text, Convert.ToDateTime(txtFechaInicio.Text), Convert.ToDateTime(txtFechaVenc.Text), Convert.ToDouble(txtPrecioOferta.Text), Convert.ToDouble(txtPrecioLista.Text), PresenterProveedor.instance().getProveedorActual(), Convert.ToInt32(txtCantDisponible.Text), Convert.ToInt32(txtMaxCantUsuario.Text));
                    PresenterProveedor.instance().editarOferta(oferta);
                }


                btn_Guardar.Enabled = false;
                dataGridView1.Rows.Clear();
                btn_Editar.Enabled = false;
                btn_Eliminar.Enabled = false;
                btn_Buscar.Enabled = false;

                txtFiltroFecha.Enabled = false;
                txtFiltrarDescripcion.Enabled = false;
            }
            else
            {
                MessageBox.Show("Ingrese datos validos");
            }
        }

        private void btn_Nuevo_Click(object sender, EventArgs e)
        {
            btn_Editar.Enabled = false;
            btn_Eliminar.Enabled = false;
            btn_Buscar.Enabled = false;
            txtId.Enabled = true;
            txtDescripcion.Enabled = true;
            txtFechaInicio.Enabled = true;
            txtFechaVenc.Enabled = true;
            txtPrecioOferta.Enabled = true;
            txtPrecioLista.Enabled = true;
            txtCantDisponible.Enabled = true;
            txtMaxCantUsuario.Enabled = true;

            txtFiltroFecha.Enabled = false;
            txtFiltrarDescripcion.Enabled = false;

            txtId.Text = "";
            txtDescripcion.Text = "";
            txtFechaInicio.Text = "";
            txtFechaVenc.Text = "";
            txtPrecioOferta.Text = "";
            txtPrecioLista.Text = "";
            txtCantDisponible.Text = "";
            txtMaxCantUsuario.Text = "";
        }

        private void btn_Eliminar_Click(object sender, EventArgs e)
        {
            DataGridViewSelectedColumnCollection seleccionados = dataGridView1.SelectedColumns;
            PresenterProveedor.instance().eliminarOferta(seleccionados[0].ToString());
            dataGridView1.Rows.Clear();
            btn_Buscar.Enabled = false;
            btn_Editar.Enabled = false;
            btn_Guardar.Enabled = false;
            btn_Eliminar.Enabled = false;
            txtFiltroFecha.Enabled = false;
            txtFiltrarDescripcion.Enabled = false;

            txtId.Text = "";
            txtDescripcion.Text = "";
            txtFechaInicio.Text = "";
            txtFechaVenc.Text = "";
            txtPrecioOferta.Text = "";
            txtPrecioLista.Text = "";
            txtCantDisponible.Text = "";
            txtMaxCantUsuario.Text = "";

            txtCantDisponible.Enabled = false;
            txtDescripcion.Enabled = false;
            txtId.Enabled = false;
            txtPrecioLista.Enabled = false;
            txtPrecioOferta.Enabled = false;
            txtMaxCantUsuario.Enabled = false;
            txtFechaInicio.Enabled = false;
            txtFechaVenc.Enabled = false;


        }
    }
}
