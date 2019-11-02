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
        
        public static PresenterCliente instance()
        {
            return presenter == null ? new PresenterCliente() : presenter;
        }

          public void cargarAltaCarga(FormCliente form)
          {
              form.splitContainer1.Panel2.Controls.Add(this.getAltaCarga());
              this.getAltaCarga().Show();
          }

          private CargaCredito getAltaCarga()
          {
              return this.cargaCredito_form == null ? this.cargaCredito_form = new CargaCredito() : this.cargaCredito_form;
          }




    }




     
}
