using FrbaOfertas.Modelo;
using FrbaOfertas.Presenters;
using FrbaOfertas.Repositorios;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FrbaOfertas.Forms
{
    public partial class ABMProveedores : Form
    {
        public ABMProveedores()
        {
            InitializeComponent();
            TopLevel = false;
            FormBorderStyle = FormBorderStyle.None;
        }
        private bool agregando;
        private string idUsuarioDelSeleccionado;

        private void btn_Busqueda_Click(object sender, EventArgs e)
        {
            this.limpiarTodosLosTXT();
            this.agregando = false;
            btnGuardar.Enabled = false;
            txtNombre.Enabled = true;
            txtRazonSocial.Enabled = true;
            txtEstado.Enabled = false;
            txtMail.Enabled = true;
            btnBuscar.Enabled = true;
            btn_Editar.Enabled = false;
            btnSeleccionar.Enabled = false;
            btnDeshabilitar.Enabled = false;
            cboRubro.Enabled = false;
            txtNombre.Enabled = false;
            txtDireccion.Enabled = false;
            txtTelefono.Enabled = false;
            txtCiudad.Enabled = false;
            txtCodigoPostal.Enabled = false;
            txtCuit.Enabled = true;
        }

        private void limpiarTodosLosTXT()
        {
            txtCuit.Text = "";
            txtRazonSocial.Text = "";
            txtNombre.Text = "";
            txtEstado.Text = "";

            txtMail.Text = "";
            txtDireccion.Text = "";
            txtTelefono.Text = "";
            txtCiudad.Text = "";
            txtCodigoPostal.Text = "";
            cboRubro.Text = "";
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            btnSeleccionar.Enabled = true;
            string razonSocial;
            string cuit;
            string mail;
            razonSocial = txtRazonSocial.Text;
            cuit = txtCuit.Text;
            mail = txtMail.Text;

            if (razonSocial == "")
            {
                razonSocial = "DEFAULT";
            }
            if (cuit == "")
            {
                cuit = "DEFAULT";
            }
            if (mail == "")
            {
                mail = "DEFAULT";
            }


            DataTable proveedoresFiltrados = PresenterProveedor.instance().buscarProveedores(this, razonSocial, cuit, mail);
            dataGridView1.DataSource = proveedoresFiltrados;
        }


        private void btnSeleccionar_Click(object sender, EventArgs e)
        {

            if (dataGridView1.SelectedRows != null && dataGridView1.Rows.Count > 0)
            {
                button1.Enabled = true;
                btnBuscar.Enabled = false;
                btnGuardar.Enabled = false;
                btn_Editar.Enabled = true;
                btnDeshabilitar.Enabled = true;
                this.setearTXT(false);
                DataGridViewRow seleccionados = dataGridView1.SelectedRows[0];
                this.prov_id_seleccionado = seleccionados.Cells[0].Value.ToString();

                txtNombre.Text = seleccionados.Cells[7].Value.ToString();
                txtRazonSocial.Text = seleccionados.Cells[2].Value.ToString();
                txtCuit.Text = seleccionados.Cells[1].Value.ToString();
                txtDireccion.Text = seleccionados.Cells[4].Value.ToString();
                txtMail.Text = seleccionados.Cells[5].Value.ToString();
                txtTelefono.Text = seleccionados.Cells[6].Value.ToString();



                cboRubro.Text = seleccionados.Cells[3].Value.ToString();

                this.idUsuarioDelSeleccionado = seleccionados.Cells[11].Value.ToString();
                txtCiudad.Text = seleccionados.Cells[8].Value.ToString();
                txtEstado.Text = seleccionados.Cells[9].Value.ToString();
                txtCodigoPostal.Text = seleccionados.Cells[10].Value.ToString();
            }
            else
            {
                MessageBox.Show("Porfavor seleccione algun registro");
            }
        }

        private void setearTXT(bool valor)
        {

            txtRazonSocial.Enabled = valor;
            txtNombre.Enabled = valor;
            txtCuit.Enabled = valor;

            txtMail.Enabled = valor;
            txtDireccion.Enabled = valor;
            txtTelefono.Enabled = valor;
            txtCiudad.Enabled = valor;
            txtCodigoPostal.Enabled = valor;
            cboRubro.Enabled = valor;
            txtEstado.Enabled = valor;
        }


        public string prov_id_seleccionado { get; set; }

        private void ABMProveedores_Load(object sender, EventArgs e)
        {
            List<string> rubros = RepoProveedores.instance().getRubros();

            for (int i = 0; i < rubros.Count; i++)
            {
                cboRubro.Items.Add(rubros[i]);
            }
        }
        private void reiniciarTodo()
        {

            this.limpiarTodosLosTXT();
            this.deshabilitarTodosLosBotones();
            this.setearTXT(false);

            txtCuit.Text = "";
            btn_Busqueda.Enabled = true;
            btn_Nuevo.Enabled = true;

        }

        private void deshabilitarTodosLosBotones()
        {
            button1.Enabled = false;
            btnGuardar.Enabled = false;
            btn_Editar.Enabled = false;
            btnSeleccionar.Enabled = false;
            btn_Nuevo.Enabled = false;
            btn_Busqueda.Enabled = false;
            btnBuscar.Enabled = false;
            btnDeshabilitar.Enabled = false;

        }
        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (this.validarTxt())
            {
                if (this.agregando)
                {


                    int idRubro = RepoProveedores.instance().getRubroPorNombre(cboRubro.Text);
                    Proveedor prov = new Proveedor(
                        -1,
                        txtCuit.Text, txtRazonSocial.Text,
                        -1, txtMail.Text, Convert.ToInt64(txtTelefono.Text),
                        txtDireccion.Text
                        , Convert.ToInt32(txtCodigoPostal.Text),
                        txtCiudad.Text,
                        idRubro, txtNombre.Text,
                        Convert.ToChar(txtEstado.Text));

                    RepoProveedores.instance().altaProveedor(prov);
                    this.reiniciarTodo();
                }
                else
                {

                    
                    Proveedor prov;
                    if (this.idUsuarioDelSeleccionado == "")
                    {
                        int idRubro = RepoProveedores.instance().getRubroPorNombre(cboRubro.Text);
                         prov = new Proveedor(
                         Convert.ToInt32(this.prov_id_seleccionado),
                            txtCuit.Text, txtRazonSocial.Text,
                            -1, txtMail.Text, Convert.ToInt64(txtTelefono.Text),
                            txtDireccion.Text
                            , Convert.ToInt32(txtCodigoPostal.Text),
                            txtCiudad.Text,
                            idRubro, txtNombre.Text,
                            Convert.ToChar(txtEstado.Text));
                         this.reiniciarTodo();
                    }
                    else
                    {
                        int idRubro = RepoProveedores.instance().getRubroPorNombre(cboRubro.Text);
                         prov = new Proveedor(
                         Convert.ToInt32(this.prov_id_seleccionado),
                            txtCuit.Text, txtRazonSocial.Text,
                             Convert.ToInt32(this.idUsuarioDelSeleccionado)
                             , txtMail.Text, Convert.ToInt64(txtTelefono.Text),
                            txtDireccion.Text
                            , Convert.ToInt32(txtCodigoPostal.Text),
                            txtCiudad.Text,
                            idRubro, txtNombre.Text,
                            Convert.ToChar(txtEstado.Text));
                         this.reiniciarTodo();
                    }

                   

                    RepoProveedores.instance().modificarProveedor(this.prov_id_seleccionado, prov);
                }
            }
            else
            {
                MessageBox.Show("Porfavor, complete todos los campos");
            }

            


        }
        private bool validarTxt()
        {
            if (txtRazonSocial.Text != "" && txtNombre.Text != "" && txtCuit.Text != "" && txtMail.Text != "" && txtDireccion.Text != "" && txtTelefono.Text != "" && txtCiudad.Text != "" && txtCodigoPostal.Text != "" && cboRubro.Text != "" && txtEstado.Text != "")
            {
                if(IsNumeric(txtCodigoPostal.Text) && IsNumeric(txtTelefono.Text))
                {

                return true;
                }

            }

            return false;
        }

        public bool IsNumeric(string valor)
        {
            int result;
            return int.TryParse(valor, out result);
        }
        
        private void btn_Nuevo_Click(object sender, EventArgs e)
        {

            btnGuardar.Enabled = true;
            this.agregando = true;
            this.setearTXT(true);
            txtEstado.Enabled = false;
            txtEstado.Text = "E";
        }

        private void btn_Editar_Click(object sender, EventArgs e)
        {
            this.agregando = false;
            btnGuardar.Enabled = true;
            this.setearTXT(true);
        }

        private void btnDeshabilitar_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("¿Seguro que desea deshabilitar el proveedor?", "Salir", MessageBoxButtons.YesNo);

            if (result == DialogResult.Yes)
            {

                PresenterCliente.instance().deshabilitarProveedor(this.prov_id_seleccionado);
                this.reiniciarTodo();
            }
           
        }

        private void btnAsignarUsuario_Click(object sender, EventArgs e)
        {
            AsginarUsuarioAProveedor form = new AsginarUsuarioAProveedor();
            form.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("¿Seguro que desea habilitar el proveedor?", "Salir", MessageBoxButtons.YesNo);

            if (result == DialogResult.Yes)
            {

                PresenterCliente.instance().habilitarProveedor(this.prov_id_seleccionado);
                this.reiniciarTodo();
            }
        }
    }
}
