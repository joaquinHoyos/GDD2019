using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FrbaOfertas.Repositorios;
using FrbaOfertas.Forms;
using System.Windows.Forms;
using System.Data;
using FrbaOfertas.Modelo;
using FrbaOfertas.Forms;
using System.Windows.Forms;
using System.Configuration;

namespace FrbaOfertas.Presenters
{
    class PresenterProveedor
    {
        private ABMProveedores abmProveedores;
        private AbmOfertas abmrol_form;
        public static PresenterProveedor presenter;

        public static PresenterProveedor instance()
        {
            return presenter == null ? new PresenterProveedor() : presenter;
        }

        public DataTable filtrarOfertas(string descripcion,DateTime fecha,int proveedor)
        {
            try{
            return RepoOferta.instance().traerOfertasFiltradas(descripcion,fecha,proveedor);
            
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
                return null;
            }
        
        }
        public int getProveedorActual()
        {

            return RepoUsuario.instance().getProveedorActual();
        }

        public void nuevaOferta(Oferta oferta)
        {
            
                RepoOferta.instance().agregarOferta(oferta);
                MessageBox.Show("Oferta Agregada");
        }

        public void editarOferta(Oferta oferta)
        {
            
            RepoOferta.instance().editarOferta(oferta);
               MessageBox.Show("Oferta Editada");
            
        }

        public void eliminarOferta(string idOferta)
        {
            try{
            RepoOferta.instance().eliminarOferta(idOferta);
           MessageBox.Show("Oferta Eliminada");
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
        }

        public DataTable traerCuponesNoCanjeadosDeProveedorActual(int cliente)
        {
            try
            {
                return RepoProveedores.instance().getCuponesNoCanjeados(this.getProveedorActual(), cliente);
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
                return null;
            }
        }
        public void canjearCupon(int cupon)
        {

            RepoProveedores.instance().canjearCupon(cupon, Convert.ToDateTime(ConfigurationManager.AppSettings["fecha"]));
        }

        public DataTable buscarProveedores(ABMProveedores form, string razonSocial, string cuit, string mail)
        {
           
              this.abmProveedores = form;
              return RepoProveedores.instance().buscarProveedor(razonSocial, cuit, mail);
          
        }

        public DataTable buscarProveedoresSinUsuario()
        {
            return RepoProveedores.instance().buscarProveedoresSinUsuario();
        }

        public void habilitarOferta(string idOferta)
        {
            try
            {
                RepoOferta.instance().habilitarOferta(idOferta);
                MessageBox.Show("Oferta Habilitada");
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
        }
    }
}
