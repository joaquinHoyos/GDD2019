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
            form.deshabilitarTodo();
            form.borrarTodo();
            this.cargarTodasFunciones(form);
            form.habilitarNuevo();
        }

        public void cargarNuevaBusqueda(AbmRol_Form form)
        {
            form.deshabilitarTodo();
            form.borrarTodo();
            form.habilitarBusqueda();
            this.cargarTodasFunciones(form);
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

        public void hacerBusqueda(decimal id, string nombre, DataTable funciones, AbmRol_Form form)
        {
            DataTable roles;
            
            switch (this.tipoBusqueda(id, nombre, funciones))
            {
                case (int) EnumTipoBusqueda.ID:
                    MessageBox.Show("id");
                    roles = RepoRol.instance().buscarPorId(id);
                    break;
                case (int)EnumTipoBusqueda.Nombre:
                    roles = RepoRol.instance().buscarPorId(id);
                    break;
                case (int)EnumTipoBusqueda.Funciones:
                    roles = RepoRol.instance().buscarPorId(id);
                    break;
                case (int)EnumTipoBusqueda.ID_Nombre:
                    roles = RepoRol.instance().buscarPorId(id);
                    break;
                case (int)EnumTipoBusqueda.ID_Funciones:
                    roles = RepoRol.instance().buscarPorId(id);
                    break;
                case (int)EnumTipoBusqueda.Nombre_Funciones:
                    roles = RepoRol.instance().buscarPorId(id);
                    break;
                case (int)EnumTipoBusqueda.Todo:
                    roles = RepoRol.instance().buscarPorId(id);
                    break;
                default:
                    roles = new DataTable();
                    break;
            }
            form.cargarResultadoBusqueda(roles);
        }

        private int tipoBusqueda(decimal id, string nombre, DataTable funciones)
        {
            if (id>0 && nombre != "" && funciones.Rows.Count > 0){ return (int) EnumTipoBusqueda.Todo; }
            else if (id==0 && nombre != "" && funciones.Rows.Count == 0) { return (int)EnumTipoBusqueda.Nombre; }
            else if (id==0 && nombre == "" && funciones.Rows.Count > 0) { return (int)EnumTipoBusqueda.Funciones; }
            else if (id > 0 && nombre == "" && funciones.Rows.Count == 0) { return (int)EnumTipoBusqueda.ID; }
            else if (id > 0 && nombre!= "" && funciones.Rows.Count == 0) { return (int)EnumTipoBusqueda.ID_Nombre; }
            else if (id==0 && nombre != "" && funciones.Rows.Count>0) { return (int)EnumTipoBusqueda.Nombre_Funciones; }
            else if (id > 0 && nombre == "" && funciones.Rows.Count > 0) { return (int)EnumTipoBusqueda.ID_Funciones; }
            return -1;
        }
    }
}
