using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FrbaOfertas.Forms;
using FrbaOfertas.Modelo;
using FrbaOfertas.Repositorios;
using System.Data;
using System.Windows.Forms;
namespace FrbaOfertas.Presenters
{
    class PresenterAdmin
    {
        private AbmRol_Form abmrol_form;
        public static PresenterAdmin presenter;

        public static PresenterAdmin instance()
        {
            return presenter==null?  presenter = new PresenterAdmin() :  presenter;
        }

        public void cargarNuevoRol(AbmRol_Form form){
            this.cargarTodasFunciones(form);
            form.habilitarNuevo();
        }

        private void cargarTodasFunciones(AbmRol_Form form)
        {
            foreach (int func in RepoRol.instance().getFuncionesAdmin()) { form.list_Admin.Items.Add(Enum.GetName(typeof(Funciones),func)); }
            foreach (int func in RepoRol.instance().getFuncionesCliente()) { form.list_Cliente.Items.Add(Enum.GetName(typeof(Funciones), func)); } 
            foreach (int func in RepoRol.instance().getFuncionesProveedor()) { form.list_Proveedor.Items.Add(Enum.GetName(typeof(Funciones),func)); }
                
        }

        public void crearNuevoRol(string nombre,DataTable funciones) 
        {
            try
            {
                RepoRol.instance().crearRol(nombre, funciones);
                MessageBox.Show("Rol Creado Correctamente");
            }
            catch(Exception ex)
            {
                MessageBox.Show("Error al crear el nuevo rol \n"+ex.Message);
            }
        }
    }
}
