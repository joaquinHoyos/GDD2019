using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FrbaOfertas.Modelo;
using FrbaOfertas.Forms;
using FrbaOfertas.Repositorios;
using System.Windows.Forms;
namespace FrbaOfertas.Presenters
{
    public class Presenter
    {
        public static  Presenter presenter;
        private Admin_Form admin_form;
        private LoginUsuario login_form;
        private AbmRol_Form abmRol_form;

        public static Presenter instance()
        {
            return presenter == null ? new Presenter() : presenter;
        }


        public void loguearUsuario(string usuario, string clave, LoginUsuario form)
        {
            this.login_form = form;
            User user = RepoUsuario.instance().buscarUsuarioPorClave(usuario, clave);
            if (user != null)
            {

                this.redireccionarUsuario(user);
                this.login_form.Hide();
                return;
            }
            MessageBox.Show("Error: contraseña o usuario incorrecto");
         
        }
       
        private void redireccionarDios(){
            DialogResult resultado = MessageBox.Show("Desea Ingresar como Administrador?", "", MessageBoxButtons.YesNo);
            if (resultado == DialogResult.No)
            {
                resultado = MessageBox.Show("Desea Ingresar como Cliente? De lo contrario ingresara como administrador", "", MessageBoxButtons.YesNo);
                if (resultado == DialogResult.Yes)
                {
                    //ir a form cliente
                }
                else
                {
                    //ir a form proveedor
                }
            }
            else
            {
                getAdminForm().Show();
            }
        }

        private void redireccionarAdminCliente() {
            DialogResult resultado = MessageBox.Show("Desea ingresar como administrador? De lo contrario ingresara como Cliente", "", MessageBoxButtons.YesNo);
            if (resultado == DialogResult.Yes)
            {
                getAdminForm().Show();
            }
            else 
            { 
              //mostrar cliente  
            }
        }

        private void redireccionarAdminProveedor()
        { 
            DialogResult resultado = MessageBox.Show("Desea ingresar como administrador? De lo contrario ingresara como Proveedor", "", MessageBoxButtons.YesNo);
            if (resultado == DialogResult.Yes)
            {
                getAdminForm().Show();
            }
            else 
            { 
              //mostrar proveedor 
            }
        }

        private void redireccionarClienteProveedor()
        {
            DialogResult resultado = MessageBox.Show("Desea ingresar como Cliente? De lo contrario ingresara como Proveedor", "", MessageBoxButtons.YesNo);
            if (resultado == DialogResult.Yes)
            {
                //mostrar cliente
            }
            else 
            { 
              //mostrar proveedor  
            }        
        }
      
        public void redireccionarUsuario(User usuario){
            if (usuario.esAdmin()&&usuario.esCliente()&&usuario.esProveedor())
            {
                this.redireccionarDios();
            }
            else if (usuario.esAdmin() && usuario.esCliente())
            {
                this.redireccionarAdminCliente();
            }
            else if (usuario.esAdmin() && usuario.esProveedor())
            {
                this.redireccionarAdminProveedor();
            }
            else if (usuario.esCliente() && usuario.esProveedor())
            {
                this.redireccionarClienteProveedor();
            }
            else if (usuario.esAdmin())
            {
                this.getAdminForm().Show();
            }
            else if (usuario.esCliente())
            {
                //mostrar cliente
            }
            else // esProveedor
            {
                // mostrar proveedor
            }
        }

        public void cargarAbmRol(Admin_Form form)
        {
            form.splitContainer1.Panel2.Controls.Add(this.getAbmRolForm());
            this.getAbmRolForm().Show();
        }

        public void cargarTodasFunciones(AbmRol_Form form)
        {
            foreach (int func in RepoRol.instance().getFuncionesAdmin()) { form.list_Admin.Items.Add(Enum.GetName(typeof(Funciones),func)); }
            foreach (int func in RepoRol.instance().getFuncionesCliente()) { form.list_Cliente.Items.Add(Enum.GetName(typeof(Funciones), func)); } 
            foreach (int func in RepoRol.instance().getFuncionesProveedor()) { form.list_Proveedor.Items.Add(Enum.GetName(typeof(Funciones),func)); }
                
        }
        private Admin_Form getAdminForm(){
            return this.admin_form==null?this.admin_form=new Admin_Form():this.admin_form;
        }
      
        private LoginUsuario nuevoLoginForm()
        {
            return this.login_form == null ? this.login_form=new LoginUsuario() : this.login_form;
        }

        private AbmRol_Form getAbmRolForm()
        {
            return this.abmRol_form == null ? this.abmRol_form=new AbmRol_Form() : this.abmRol_form;
        }

        
            
    }
}
