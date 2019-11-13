using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms;
using FrbaOfertas.Presenters;
using FrbaOfertas.Repositorios;
using FrbaOfertas.Modelo;

namespace FrbaOfertas.Forms
{
    public partial class FormCliente : Form
    {

        public int currentUserID;
        
        public FormCliente()
        {
            InitializeComponent();
            this.configurar();
        }

        
        private void FormCliente_Load(object sender, EventArgs e)
        {
            // habilitacion y deshabilitacion de botones

            currentUserID = RepoUsuario.instance().idActual;
            List<Grupo> grupos = RepoUsuario.instance().traerFunciones(currentUserID);
            List<int> funciones = grupos.Find(x => x.grupo == 'C').funciones;
            if (funciones.Contains(1)) {
                btn_cargaCredito.Enabled = true;
            }
            if (funciones.Contains(2))
            {
                btn_comprar.Enabled = true;
            }
            if (funciones.Contains(3) && funciones.Contains(4))
            {
                btn_verCupones.Enabled = true;
            }

            
        }

        private void btn_cargaCredito_Click(object sender, EventArgs e)
        {

            

        }

        private void btn_cargaCredito_Click_1(object sender, EventArgs e)
        {
            PresenterCliente.instance().cargarAltaCarga(this,currentUserID);
        }

        private void btn_comprar_Click(object sender, EventArgs e)
        {
            PresenterCliente.instance().cargarComprar(this, currentUserID);
        }

        private void btn_verCupones_Click(object sender, EventArgs e)
        {
            PresenterCliente.instance().cargarFormCupones(this, currentUserID);
        }

        public void configurar()
        {
            List<int> funciones = RepoUsuario.instance().userActual.funciones();
            if(!funciones.Contains((int)Enum.Parse(typeof(EnumFunciones),"COMPRAR"))){this.btn_comprar.Enabled=false;}
            if(!funciones.Contains((int)Enum.Parse(typeof(EnumFunciones),"VER_CUPON"))){this.btn_verCupones.Enabled=false;}
            if(!funciones.Contains((int)Enum.Parse(typeof(EnumFunciones),"COMPARTIR_CUPON"))){}
            if(!funciones.Contains((int)Enum.Parse(typeof(EnumFunciones),"CARGA_CREDITO"))){this.btn_cargaCredito.Enabled=false;}
        }
    }
}
