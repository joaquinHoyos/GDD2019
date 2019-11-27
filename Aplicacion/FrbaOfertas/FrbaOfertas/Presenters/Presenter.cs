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
        public static Presenter presenter;
        private Admin_Form admin_form;
        private LoginUsuario login_form;
        private AbmRol_Form abmRol_form;
        private ABMCliente abmCliente;
        private AbmOfertas abmOferta;
        private FormCliente cliente_form;
        private Prov_Form prov_form;
        private Facturacion_Form fact_form;
        private ListadoEstadisitico listado_form;
        private AbmUsuario_Form usuario_form;
        private ABMProveedores abmProv_Form;
        private CanjearCupones canjearCupones;
        private User usuarioActual;
        public static Presenter instance()
        {
            return presenter == null ? presenter = new Presenter() : presenter;
        }


        public void loguearUsuario(string usuario, string clave, LoginUsuario form)
        {
            this.login_form = form;
            User user = RepoUsuario.instance().buscarUsuarioPorClave(usuario, clave);
            this.usuarioActual = user;
            if (user != null)
            {
                RepoUsuario.instance().registrarInicioValido(usuario);
                RepoUsuario.instance().setUsuarioActual(user.user_id);
                //VER SI DIRECCIONAR A altaCliente o a altaProveedor
                    this.redireccionarUsuario(user);
                    this.login_form.Hide();
                    return;
            }
            else
            {
                RepoUsuario.instance().registrarInicioFallido(usuario);
                MessageBox.Show("Error: contraseña o usuario incorrecto");
                
            }
        }

        private void redireccionarDios(User user)
        {
            DialogResult resultado = MessageBox.Show("Desea Ingresar como Administrador?", "", MessageBoxButtons.YesNo);
            if (resultado == DialogResult.No)
            {
                resultado = MessageBox.Show("Desea Ingresar como Cliente? De lo contrario ingresara como proveedor", "", MessageBoxButtons.YesNo);
                if (resultado == DialogResult.Yes)
                {
                    //ir a form cliente
                    if(this.getClienteForm(user) !=null){this.getClienteForm(user).Show();}
                }                
                else
                {
                    if (this.getProvForm(user) != null) { this.getProvForm(user).Show(); }  
                    //ir a form proveedor
                }
            }
            else
            {
                getAdminForm().Show();
            }
        }

        private void redireccionarAdminCliente(User user)
        {
            DialogResult resultado = MessageBox.Show("Desea ingresar como administrador? De lo contrario ingresara como Cliente", "", MessageBoxButtons.YesNo);
            if (resultado == DialogResult.Yes)
            {
                getAdminForm().Show();
            }
            else
            {
                //mostrar cliente 
                if (this.getClienteForm(user) != null) { this.getClienteForm(user).Show(); }
            }
        }

        private void redireccionarAdminProveedor(User user)
        {
            DialogResult resultado = MessageBox.Show("Desea ingresar como administrador? De lo contrario ingresara como Proveedor", "", MessageBoxButtons.YesNo);
            if (resultado == DialogResult.Yes)
            {
                getAdminForm().Show();
            }
            else
            {
                if (this.getProvForm(user) != null) { this.getProvForm(user).Show(); }  
            }
        }

        private void redireccionarClienteProveedor(User user)
        {
            DialogResult resultado = MessageBox.Show("Desea ingresar como Cliente? De lo contrario ingresara como Proveedor", "", MessageBoxButtons.YesNo);
            if (resultado == DialogResult.Yes)
            {
                //mostrar cliente
                if (this.getClienteForm(user) != null) { this.getClienteForm(user).Show(); }
            }
            else
            {
                if (this.getProvForm(user) != null) { this.getProvForm(user).Show(); }  
            }
        }

        public void redireccionarUsuario(User usuario)
        {
            if (usuario.esAdmin() && usuario.esCliente() && usuario.esProveedor())
            {
                this.redireccionarDios(usuario);
            }
            else if (usuario.esAdmin() && usuario.esCliente())
            {
                this.redireccionarAdminCliente(usuario);
            }
            else if (usuario.esAdmin() && usuario.esProveedor())
            {
                this.redireccionarAdminProveedor(usuario);
            }
            else if (usuario.esCliente() && usuario.esProveedor())
            {
                this.redireccionarClienteProveedor(usuario);
            }
            else if (usuario.esAdmin())
            {
                this.getAdminForm().Show();
            }
            else if (usuario.esCliente())
            {
                //mostrar cliente
                if (this.getClienteForm(usuario) != null) { this.getClienteForm(usuario).currentUserID = usuario.user_id; }
                if (this.getClienteForm(usuario) != null) { this.getClienteForm(usuario).Show(); }
            }
            else // esProveedor
            {
                if (this.getProvForm(usuario) != null) { this.getProvForm(usuario).Show(); }  
            }
        }

        public void cargarAbmRol(Admin_Form form)
        {
            form.splitContainer1.Panel2.Controls.Add(this.getAbmRolForm());
            form.mostrarForm(this.getAbmRolForm());
        }

        public void cargarFacturacion(Admin_Form form)
        {
            form.splitContainer1.Panel2.Controls.Add(this.getFacturacionForm());
            form.mostrarForm(this.getFacturacionForm());
        }

        public void cargarAbmClientes(Admin_Form form)
        {
            form.splitContainer1.Panel2.Controls.Add(this.getAbmCliente());

            form.mostrarForm(this.getAbmCliente());
        }


        public void cargarAbmOfertas(Prov_Form form)
        {
            form.splitContainer1.Panel2.Controls.Add(this.getAbmOfertaForm());
            if (this.canjearCupones != null)
            {
                this.canjearCupones.Hide();
            }
            this.getAbmOfertaForm().Show();
        }

        public void cargarListadoEstadistico(Admin_Form form)
        {
            form.splitContainer1.Panel2.Controls.Add(this.getListadoEstadisticoForm());
            form.mostrarForm(this.getListadoEstadisticoForm());
        }

        public void cargarUsuario(Admin_Form form)
        {
            form.splitContainer1.Panel2.Controls.Add(this.getUsuarioForm());
            form.mostrarForm(this.getUsuarioForm()); 
        }

        private Admin_Form getAdminForm()
        {
            return this.admin_form == null ? this.admin_form = new Admin_Form() : this.admin_form;
        }

        private ListadoEstadisitico getListadoEstadisticoForm()
        {
            return this.listado_form == null ? this.listado_form = new ListadoEstadisitico() : this.listado_form;
        }

        private AbmUsuario_Form getUsuarioForm()
        {
            return this.usuario_form == null ? this.usuario_form = new AbmUsuario_Form() : this.usuario_form;
        }

        private Facturacion_Form getFacturacionForm()
        {
            return this.fact_form == null ? this.fact_form = new Facturacion_Form() : this.fact_form;
        }

        private LoginUsuario nuevoLoginForm()
        {
            return this.login_form == null ? this.login_form = new LoginUsuario() : this.login_form;
        }

        private AbmRol_Form getAbmRolForm()
        {
            return this.abmRol_form == null ? this.abmRol_form = new AbmRol_Form() : this.abmRol_form;
        }
        private ABMCliente getAbmCliente()
        {
            return this.abmCliente == null ? this.abmCliente = new ABMCliente() : this.abmCliente;
        }

        private AbmOfertas getAbmOfertaForm()
        {
            return this.abmOferta == null ? this.abmOferta = new AbmOfertas() : this.abmOferta;
        }
        private Prov_Form getProvForm(User user)
        {
            List<Grupo> grupos = RepoUsuario.instance().traerFunciones(user.user_id);
            if (grupos.Any(x => x.grupo == 'P') && RepoUsuario.instance().tieneClienteOProveedor() == 0)
            {
                new AltaProveedor().Show();
                this.login_form.Hide();
                return null;
            }
            return this.prov_form == null ? this.prov_form = new Prov_Form() : this.prov_form;
        }
        private FormCliente getClienteForm(User user)
        {
                List<Grupo> grupos = RepoUsuario.instance().traerFunciones(user.user_id);
                if (grupos.Any(x => x.grupo == 'C') && RepoUsuario.instance().tieneClienteOProveedor()==0)
                {
                    new AltaCliente().Show();
                    this.login_form.Hide();
                    return null;
                }
                return this.cliente_form == null ? this.cliente_form = new FormCliente() : this.cliente_form;
            
        }

        public void postAltaCliente()
        {
            if (this.getClienteForm(this.usuarioActual) != null) { this.getClienteForm(this.usuarioActual).Show(); }

        }

        public void postAltaProveedor()
        {
            if (this.getProvForm(this.usuarioActual) != null) { this.getProvForm(this.usuarioActual).Show(); }

        }
        public void cargarCanjearCupones(Prov_Form form)
        {
            form.splitContainer1.Panel2.Controls.Add(this.getCanjearCuponesForm());
            if (this.abmOferta != null)
            {
                this.abmOferta.Hide();
            }
            this.getCanjearCuponesForm().Show();
        }

        private CanjearCupones getCanjearCuponesForm()
        {
            return this.canjearCupones == null ? this.canjearCupones = new CanjearCupones() : this.canjearCupones;
        }



        public void cargarAbmProveedor(Admin_Form admin_Form)
        {
            admin_Form.splitContainer1.Panel2.Controls.Add(this.getAbmProveedor());
            admin_Form.mostrarForm(this.getAbmProveedor());
        }

        private ABMProveedores getAbmProveedor()
        {
         return this.abmProv_Form == null ? this.abmProv_Form = new ABMProveedores() : this.abmProv_Form;
        }
    }
}
