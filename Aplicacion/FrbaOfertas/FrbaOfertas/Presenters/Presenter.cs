﻿using System;
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

        public static Presenter instance()
        {
            return presenter == null ? presenter = new Presenter() : presenter;
        }


        public void loguearUsuario(string usuario, string clave, LoginUsuario form)
        {
            this.login_form = form;
            User user = RepoUsuario.instance().buscarUsuarioPorClave(usuario, clave);
            if (user != null)
            {
                RepoUsuario.instance().registrarInicioValido(usuario);
                RepoUsuario.instance().setUsuarioActual(user.user_id);
                //VER SI DIRECCIONAR A altaCliente o a altaProveedor

                if (RepoUsuario.instance().tieneClienteOProveedor() == 0)
                {
                    List<Grupo> grupos = RepoUsuario.instance().traerFunciones(user.user_id);
                    //List<int> funciones = grupos.Any(x => x.grupo == 'C');
                    if (grupos.Any(x => x.grupo == 'C'))
                    {
                        
                        new AltaCliente().Show();
                        this.login_form.Hide();
                    }
                    else if (grupos.Any(x => x.grupo == 'P'))
                    {
                        new AltaProveedor().Show();
                        this.login_form.Hide();

                    }
                    else {
                        this.redireccionarUsuario(user);
                        this.login_form.Hide();
                        return;
                    
                    }
                }
                else
                {
                    this.redireccionarUsuario(user);
                    this.login_form.Hide();
                    return;
                }
            }
            else
            {
                RepoUsuario.instance().registrarInicioFallido(usuario);
                MessageBox.Show("Error: contraseña o usuario incorrecto");
                
            }
        }

        private void redireccionarDios()
        {
            DialogResult resultado = MessageBox.Show("Desea Ingresar como Administrador?", "", MessageBoxButtons.YesNo);
            if (resultado == DialogResult.No)
            {
                resultado = MessageBox.Show("Desea Ingresar como Cliente? De lo contrario ingresara como administrador", "", MessageBoxButtons.YesNo);
                if (resultado == DialogResult.Yes)
                {
                    //ir a form cliente
                    this.getClienteForm().Show();
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

        private void redireccionarAdminCliente()
        {
            DialogResult resultado = MessageBox.Show("Desea ingresar como administrador? De lo contrario ingresara como Cliente", "", MessageBoxButtons.YesNo);
            if (resultado == DialogResult.Yes)
            {
                getAdminForm().Show();
            }
            else
            {
                //mostrar cliente 
                this.getClienteForm().Show();
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
                prov_form.Show();
            }
        }

        private void redireccionarClienteProveedor()
        {
            DialogResult resultado = MessageBox.Show("Desea ingresar como Cliente? De lo contrario ingresara como Proveedor", "", MessageBoxButtons.YesNo);
            if (resultado == DialogResult.Yes)
            {
                //mostrar cliente
                this.getClienteForm().Show();
            }
            else
            {
                prov_form.Show();
            }
        }

        public void redireccionarUsuario(User usuario)
        {
            if (usuario.esAdmin() && usuario.esCliente() && usuario.esProveedor())
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
                this.getClienteForm().currentUserID = usuario.user_id;
                this.getClienteForm().Show();
            }
            else // esProveedor
            {
                this.getProvForm().Show();
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
            this.getAbmOfertaForm().Show();
        }

        public void cargarListadoEstadistico(Admin_Form form)
        {
            form.splitContainer1.Panel2.Controls.Add(this.getListadoEstadisticoForm());
            form.mostrarForm(this.getListadoEstadisticoForm());
        }

        private Admin_Form getAdminForm()
        {
            return this.admin_form == null ? this.admin_form = new Admin_Form() : this.admin_form;
        }

        private ListadoEstadisitico getListadoEstadisticoForm()
        {
            return this.listado_form == null ? this.listado_form = new ListadoEstadisitico() : this.listado_form;
        }

        private Facturacion_Form getFacturacionForm()
        {
            return this.fact_form == null ? this.fact_form = new Facturacion_Form() : this.fact_form;
        }

        private Prov_Form getProvForm()
        {
            return this.prov_form == null ? this.prov_form = new Prov_Form() : this.prov_form;
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

        private FormCliente getClienteForm()
        {
            return this.cliente_form == null ? this.cliente_form = new FormCliente() : this.cliente_form;
        }




    }
}
