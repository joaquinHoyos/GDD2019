using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FrbaOfertas.Modelo;
using FrbaOfertas.Forms;
using FrbaOfertas.Repositorios;
using System.Windows.Forms;
using System.Data;

namespace FrbaOfertas.Presenters
{
    class PresenterCliente
    {
        public static PresenterCliente presenter;
        private CargaCredito cargaCredito_form;
        private Comprar comprar_form;
        private Cupones cupones_form;
        private ABMCliente abmClientes;

        public static PresenterCliente instance()
        {
            return presenter == null ? new PresenterCliente() : presenter;
        }

          public void cargarAltaCarga(FormCliente form, int userID)
          {
               
              this.getAltaCarga().currentUserID = userID;
              form.splitContainer1.Panel2.Controls.Clear();
              form.splitContainer1.Panel2.Controls.Add(this.getAltaCarga());
              this.getAltaCarga().Show();
          }

          public void cargarComprar(FormCliente form, int userID)
          {
              this.getComprar().currentUserID = userID;
              form.splitContainer1.Panel2.Controls.Clear();
              form.splitContainer1.Panel2.Controls.Add(this.getComprar());
              this.getComprar().Show();
          }

        public void cargarFormCupones(FormCliente form, int userID){
        
              this.getCupones().currentUserID = userID;
              form.splitContainer1.Panel2.Controls.Clear();
              form.splitContainer1.Panel2.Controls.Add(this.getCupones());
              this.getCupones().Show();
        
        }

          private CargaCredito getAltaCarga()
          {
              return this.cargaCredito_form == null ? this.cargaCredito_form = new CargaCredito() : this.cargaCredito_form;
          }

          private Comprar getComprar()
          {
              return this.comprar_form == null ? this.comprar_form = new Comprar() : this.comprar_form;
          }

          private Cupones getCupones()
          {
          
              return this.cupones_form==null ? this.cupones_form = new Cupones():this.cupones_form;
          
          }
          public DataTable buscarClientes(ABMCliente form, String nombre, String apellido, String mail, String dni)
          {

              this.abmClientes = form;
              return RepoUsuario.instance().buscarCliente(nombre, apellido, mail, dni);
          }

          public DataTable buscarClientes(String nombre, String apellido, String mail, String dni)
          {

              return RepoUsuario.instance().buscarClienteSinUsuario(nombre, apellido, mail, dni);
          }

          public void crearNuevoCliente(String nombre, String apellido, String dni, String mail, String telefono, String saldo, String direccion, String ciudad, String codPostal, String fechaNac)
          {
              try
              {
                  Cliente nuevoCliente = new Cliente(-1, nombre, apellido, Convert.ToInt64(dni),-1,mail,telefono,direccion,Convert.ToDouble(saldo),Convert.ToInt32(codPostal),ciudad,Convert.ToDateTime(fechaNac));
                  RepoCliente.instance().crearCliente(nuevoCliente);
                  MessageBox.Show("Cliente Creado Correctamente");
              }
              catch (Exception ex)
              {
                  MessageBox.Show("Error al crear el nuevo Cliente \n" + ex.Message);
              }
          }

          public void modificarCliente(String clie_id, String nombre, String apellido, String dni, String mail, String telefono, String saldo, String direccion, String ciudad, String codPostal, String fechaNac)
          {
              try
              {
                  Cliente nuevoCliente = new Cliente(-1, nombre, apellido, Convert.ToInt64(dni), -1, mail, telefono, direccion, Convert.ToDouble(saldo), Convert.ToInt32(codPostal), ciudad, Convert.ToDateTime(fechaNac));
                  RepoCliente.instance().modificarCliente(clie_id,nuevoCliente);
                  MessageBox.Show("Cliente Modificado Correctamente");
              }
              catch (Exception ex)
              {
                  MessageBox.Show("Error al modificar Cliente \n" + ex.Message);
              }
          }

          public void deshabilitarCliente(String clie_id)
          {
              try
              {
                  
                  RepoCliente.instance().deshabilitarCliente(clie_id);
                  MessageBox.Show("Cliente Deshabilitado Correctamente");
              }
              catch (Exception ex)
              {
                  MessageBox.Show("Error al deshabilitar Cliente \n" + ex.Message);
              }
          }



    }




     
}
