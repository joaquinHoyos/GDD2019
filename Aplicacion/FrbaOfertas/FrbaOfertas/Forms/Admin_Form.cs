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
using FrbaOfertas.Repositorios;
namespace FrbaOfertas.Forms
{
    public partial class Admin_Form : Form
    {
        private Form formActual;
        public Admin_Form()
        {
            InitializeComponent();
            this.configurar();
        }

        private void btn_Roles_Click(object sender, EventArgs e)
        {
            Presenter.instance().cargarAbmRol(this);
        }

        private void btnClientes_Click(object sender, EventArgs e)
        {
            Presenter.instance().cargarAbmClientes(this);
        }

        private void btnEstadistica_Click(object sender, EventArgs e)
        {
            Presenter.instance().cargarListadoEstadistico(this);
        }

        private void btnFactura_Click(object sender, EventArgs e)
        {
            Presenter.instance().cargarFacturacion(this);
        }

        public void configurar()
        {
            List<int> funciones = new List<int>();
            funciones=RepoUsuario.instance().userActual.funciones();
            if(!funciones.Contains((int)Enum.Parse(typeof(EnumFunciones),"FACTURAR"))){this.btnFactura.Enabled=false;}
            if(!funciones.Contains((int)Enum.Parse(typeof(EnumFunciones),"ABM_OFERTA"))){}
            if(!funciones.Contains((int)Enum.Parse(typeof(EnumFunciones),"ABM_ROL"))){this.btn_Roles.Enabled=false;}
            if(!funciones.Contains((int)Enum.Parse(typeof(EnumFunciones),"VER_ESTADISTICAS"))){this.btnEstadistica.Enabled=false;}
            if (!funciones.Contains((int)Enum.Parse(typeof(EnumFunciones), "ABM_USUARIO"))) { this.btn_Usuarios.Enabled = false; }
            if(!funciones.Contains((int)Enum.Parse(typeof(EnumFunciones),"ABM_CLIENTES"))){this.btnClientes.Enabled=true;}
            if(!funciones.Contains((int)Enum.Parse(typeof(EnumFunciones),"ABM_PROVEEDOR"))){this.btnProveedores.Enabled=false;}
            if (!funciones.Contains((int)Enum.Parse(typeof(EnumFunciones), "ABM_OFERTAS_ADMIN"))) { this.btn_ofertas.Enabled = false; }
            
        }

        private void btnProveedores_Click(object sender, EventArgs e)
        {
            Presenter.instance().cargarAbmProveedor(this);
        }

        private void btn_Usuarios_Click(object sender, EventArgs e)
        {
            Presenter.instance().cargarUsuario(this);
        }

        public void mostrarForm(Form form)
        {
            if (this.formActual != null) 
            { 
                this.formActual.Hide(); 
            }
            this.formActual = form;
            this.formActual.Show();

        }

        private void splitContainer1_Panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btn_ofertas_Click(object sender, EventArgs e)
        {
            Presenter.instance().cargarAbmOfertasDeAdmin(this);
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
