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
using FrbaOfertas.Repositorios;
using FrbaOfertas.Modelo;
namespace FrbaOfertas.Forms
{
    public partial class AbmOfertasDeAdmin : Form
    {
        public AbmOfertasDeAdmin()
        {
            InitializeComponent();
            TopLevel = false;
            FormBorderStyle = FormBorderStyle.None;
            
        }
        private int agregando = 0;
        private void AmbOfertasDeAdmin_Load(object sender, EventArgs e)
        {
            List<string> proveedores = RepoProveedores.instance().getRazonSocialProveedores();

            for (int i = 0; i < proveedores.Count; i++)
            {
                cboProveedor.Items.Add(proveedores[i]);
            }
        }

        private void btn_Nuevo_Click(object sender, EventArgs e)
        {
            this.agregando = 1;
            btn_Editar.Enabled = false;
            btn_Eliminar.Enabled = false;
            btn_Buscar.Enabled = false;
            txtId.Enabled = true;
            txtDescripcion.Enabled = true;
            txtFechaInicio.Enabled = true;
            txtFechaVenc.Enabled = true;
            btn_Guardar.Enabled = true;
            txtPrecioOferta.Enabled = true;
            txtPrecioLista.Enabled = true;
            txtCantDisponible.Enabled = true;
            txtMaxCantUsuario.Enabled = true;
            cboProveedor.Enabled = true;
           
            txtFiltroProveedor.Enabled = false;

            txtId.Text = "";
            txtDescripcion.Text = "";
            txtFechaInicio.Text = "";
            txtFechaVenc.Text = "";
            txtPrecioOferta.Text = "";
            txtPrecioLista.Text = "";
            txtCantDisponible.Text = "";
            txtMaxCantUsuario.Text = "";
            btnSeleccionar.Enabled = false;
        }

        private void btn_Busqueda_Click(object sender, EventArgs e)
        {
            btn_Editar.Enabled = false;
            btn_Eliminar.Enabled = false;
            btn_Guardar.Enabled = false;
            btn_Buscar.Enabled = true;
            txtFiltroProveedor.Enabled = true;
            txtCantDisponible.Enabled = false;
            txtDescripcion.Enabled = false;
            txtId.Enabled = false;
            txtPrecioLista.Enabled = false;
            txtPrecioOferta.Enabled = false;
            txtMaxCantUsuario.Enabled = false;
            txtFechaInicio.Enabled = false;
            txtFechaVenc.Enabled = false;
            cboProveedor.Enabled = false;
        }

        private void btn_Buscar_Click(object sender, EventArgs e)
        {
            btnSeleccionar.Enabled = true;
            btn_Editar.Enabled = false;
            btn_Eliminar.Enabled = false;
            //btnSeleccionar.Enabled = true;
            DataTable ofertasFiltradas = PresenterProveedor.instance().filtrarOfertasPorProveedor(txtFiltroProveedor.Text);
            dataGridView1.DataSource = ofertasFiltradas;
        }

        private void btnSeleccionar_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows != null)
            {
                DataGridViewRow seleccionados = dataGridView1.SelectedRows[0];
                txtId.Text = seleccionados.Cells[0].Value.ToString();
                txtDescripcion.Text = seleccionados.Cells[1].Value.ToString();
                txtFechaInicio.Text = seleccionados.Cells[2].Value.ToString();
                txtFechaVenc.Text = seleccionados.Cells[3].Value.ToString();
                txtPrecioOferta.Text = seleccionados.Cells[4].Value.ToString();
                txtPrecioLista.Text = seleccionados.Cells[5].Value.ToString();
                txtCantDisponible.Text = seleccionados.Cells[6].Value.ToString();
                txtMaxCantUsuario.Text = seleccionados.Cells[7].Value.ToString();
                cboProveedor.Text = seleccionados.Cells[8].Value.ToString();

                btn_Eliminar.Enabled = true;
                btn_Editar.Enabled = true;
               
                btnHabilitar.Enabled = true;
                txtFiltroProveedor.Enabled = false;
            }
        }

        private void btn_Guardar_Click(object sender, EventArgs e)
        {
            int num;
            bool esNumero = int.TryParse(txtCantDisponible.Text, out num);
            bool esNumero1 = int.TryParse(txtMaxCantUsuario.Text, out num);

            if (esNumero && esNumero1)
            {
                try
                {
                    if (this.agregando==1)
                    {

                        int idProv = RepoProveedores.instance().getIdProveedor(cboProveedor.Text);
                        Oferta oferta = new Oferta(txtId.Text, txtDescripcion.Text, Convert.ToDateTime(txtFechaInicio.Text), Convert.ToDateTime(txtFechaVenc.Text), Convert.ToDouble(txtPrecioOferta.Text), Convert.ToDouble(txtPrecioLista.Text), idProv, Convert.ToInt32(txtCantDisponible.Text), Convert.ToInt32(txtMaxCantUsuario.Text));
                        PresenterProveedor.instance().nuevaOferta(oferta);
                        this.reiniciarTodo();
                    }
                    else
                    {
                        int idProv = RepoProveedores.instance().getIdProveedor(cboProveedor.Text);
                        Oferta oferta = new Oferta(txtId.Text, txtDescripcion.Text, Convert.ToDateTime(txtFechaInicio.Text), Convert.ToDateTime(txtFechaVenc.Text), Convert.ToDouble(txtPrecioOferta.Text), Convert.ToDouble(txtPrecioLista.Text), idProv, Convert.ToInt32(txtCantDisponible.Text), Convert.ToInt32(txtMaxCantUsuario.Text));
                        PresenterProveedor.instance().editarOferta(oferta);
                        this.reiniciarTodo();
                    }


                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                    btn_Guardar.Enabled = true;
                }
            }
            else
            {
                MessageBox.Show("Ingrese datos validos");
            }
        }

        private void btn_Editar_Click(object sender, EventArgs e)
        {
            this.agregando = 0;

            txtId.Enabled = false;
            txtDescripcion.Enabled = true;
            txtFechaInicio.Enabled = true;
            txtFechaVenc.Enabled = true;
            txtPrecioOferta.Enabled = true;
            txtPrecioLista.Enabled = true;
            txtCantDisponible.Enabled = true;
            txtMaxCantUsuario.Enabled = true;
            btn_Guardar.Enabled = true;
            cboProveedor.Enabled = true;
        }


        private void reiniciarTodo()
        {

            btn_Nuevo.Enabled = true;
            btn_Busqueda.Enabled = true;
            btnHabilitar.Enabled = false;
            btn_Buscar.Enabled = false;
            btn_Editar.Enabled = false;
            btn_Guardar.Enabled = false;
            btn_Eliminar.Enabled = false;
            txtFiltroProveedor.Enabled = false;
            cboProveedor.Enabled = false;

            txtId.Text = "";
            txtDescripcion.Text = "";
            txtFechaInicio.Text = "";
            txtFechaVenc.Text = "";
            txtPrecioOferta.Text = "";
            txtPrecioLista.Text = "";
            txtCantDisponible.Text = "";
            txtMaxCantUsuario.Text = "";
            cboProveedor.Text = "";
            txtFiltroProveedor.Text = "";

            txtCantDisponible.Enabled = false;
            txtDescripcion.Enabled = false;
            txtId.Enabled = false;
            txtPrecioLista.Enabled = false;
            txtPrecioOferta.Enabled = false;
            txtMaxCantUsuario.Enabled = false;
            txtFechaInicio.Enabled = false;
            txtFechaVenc.Enabled = false;
            btnSeleccionar.Enabled = false;
        }

        private void btn_Eliminar_Click(object sender, EventArgs e)
        {
            if (!txtId.Text.Equals(""))
            {
                PresenterProveedor.instance().eliminarOferta(txtId.Text);
            }

            this.reiniciarTodo();
        }

        private void btnHabilitar_Click(object sender, EventArgs e)
        {
            if (!txtId.Text.Equals(""))
            {
                PresenterProveedor.instance().habilitarOferta(txtId.Text);
                this.reiniciarTodo();

            }
        }
    }
}
