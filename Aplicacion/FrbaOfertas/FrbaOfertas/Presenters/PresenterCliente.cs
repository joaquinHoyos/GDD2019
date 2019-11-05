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
    class PresenterCliente
    {
        public static PresenterCliente presenter;
        private CargaCredito cargaCredito_form;
        private Comprar comprar_form;
        private Cupones cupones_form;
        
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




    }




     
}
