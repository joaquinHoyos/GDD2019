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
        private Rol rolSeleccionado = new Rol();
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
            if(form.list_Admin.Items.Count==0)
            {        
                foreach (int func in RepoRol.instance().getFuncionesAdmin()) { form.list_Admin.Items.Add(Enum.GetName(typeof(EnumFunciones),func)); }
                foreach (int func in RepoRol.instance().getFuncionesCliente()) { form.list_Cliente.Items.Add(Enum.GetName(typeof(EnumFunciones), func)); }
                foreach (int func in RepoRol.instance().getFuncionesProveedor()) { form.list_Proveedor.Items.Add(Enum.GetName(typeof(EnumFunciones), func)); }
            }        
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
                    
                    roles = RepoRol.instance().buscarPorId(id);
                    break;
                case (int)EnumTipoBusqueda.Nombre:
                    roles = RepoRol.instance().buscarPorNombre(nombre);
                    break;
                case (int)EnumTipoBusqueda.Funciones:
                    roles = RepoRol.instance().buscarPorFunciones(funciones);
                    break;
                case (int)EnumTipoBusqueda.ID_Nombre:
                    roles = RepoRol.instance().buscarPorIdYNombre(id,nombre);
                    break;
                case (int)EnumTipoBusqueda.ID_Funciones:
                    roles = RepoRol.instance().buscarPorIdYFuncion(id,funciones);
                    break;
                case (int)EnumTipoBusqueda.Nombre_Funciones:
                    roles = RepoRol.instance().buscarPorNombreYFuncion(nombre,funciones);
                    break;
                case (int)EnumTipoBusqueda.Todo:
                    roles = RepoRol.instance().buscarPorTodo();
                    break;
                default:
                    roles = new DataTable();
                    break;
            }
            if (roles.Rows.Count > 0) { form.cargarResultadoBusqueda(roles); }
            else { MessageBox.Show("No se encontro ningun resultado"); }
            
        }

        private int tipoBusqueda(decimal id, string nombre, DataTable funciones)
        {
            if (id==0 && nombre == "" && funciones.Rows.Count == 0){ return (int) EnumTipoBusqueda.Todo; }
            else if (id==0 && nombre != "" && funciones.Rows.Count == 0) { return (int)EnumTipoBusqueda.Nombre; }
            else if (id==0 && nombre == "" && funciones.Rows.Count > 0) { return (int)EnumTipoBusqueda.Funciones; }
            else if (id > 0 && nombre == "" && funciones.Rows.Count == 0) { return (int)EnumTipoBusqueda.ID; }
            else if (id > 0 && nombre!= "" && funciones.Rows.Count == 0) { return (int)EnumTipoBusqueda.ID_Nombre; }
            else if (id==0 && nombre != "" && funciones.Rows.Count>0) { return (int)EnumTipoBusqueda.Nombre_Funciones; }
            else if (id > 0 && nombre == "" && funciones.Rows.Count > 0) { return (int)EnumTipoBusqueda.ID_Funciones; }
            return -1;
        }

        public void formRol_busqueda(AbmRol_Form form)
        {
        }
        public void formRol_nuevo(AbmRol_Form form)
        {
        }
        public void formRol_editar(AbmRol_Form form)
        {
            form.deshabilitarTodo();
            form.habilitarGuardar(true);
            if (rolSeleccionado.estado == 'E') { form.habilitarDeshabilitar(true); }
            else { form.habilitarHabilitar(true); }
            form.habilitarNombre(true);
            form.habilitarLists(true);
        }
        public void formRol_seleccionar(AbmRol_Form form)
        {
            form.deshabilitarTodo();
            form.habilitarEditar(true);
            form.borrarTodo();
            
            
        }
        public void formRol_guardar(AbmRol_Form form)
        {
            form.borrarTodo();
            form.deshabilitarTodo();

        }
        public void formRol_buscar(AbmRol_Form form)
        {

            form.deshabilitarTodo();
            form.habilitarLists(true);
            form.habilitarSeleccionar(true);
            form.habilitarNombre(false);
            form.habilitarId(false);
            form.habilitarBuscar(true);
        }

        public void seleccionarRol(string seleccionado,AbmRol_Form form)
        {
            Rol rol = RepoRol.instance().obtenerSeleccionado(seleccionado);
            this.rolSeleccionado = rol;
            form.cargarNombre(rol.nombre);
            form.cargarId(rol.id);
            form.cargarFunciones(rol.funciones);
        }

        public void deshabilitarRol(int rol, AbmRol_Form form)
        {
            try
            {
                RepoRol.instance().deshabilitarRol(rol);
                form.habilitarDeshabilitar(true);
                form.habilitarHabilitar(false);
                MessageBox.Show("Rol deshabilitado correctamente");
                
            }
            catch
            {
                MessageBox.Show("Error al deshabilitar el rol");
            }

        }

        public void habilitarRol(int rol, AbmRol_Form form)
        {
            try
            {
                RepoRol.instance().habilitarRol(rol);
                form.habilitarDeshabilitar(false);
                form.habilitarHabilitar(true);
                MessageBox.Show("Rol habilitado correctamente");
            }
            catch
            {
                MessageBox.Show("Error al habilitar el rol");
            }

        }

        public void modificarRol(int id, string nombre, DataTable funciones,AbmRol_Form form)
        {
            try
            {
                RepoRol.instance().modificarRol(id, nombre, funciones);
                this.cargarNuevoRol(form);
                MessageBox.Show("rol modificado correctamente");
            }
            catch
            {
                MessageBox.Show("Error al modificar el rol");
            }
        }
    }
}
