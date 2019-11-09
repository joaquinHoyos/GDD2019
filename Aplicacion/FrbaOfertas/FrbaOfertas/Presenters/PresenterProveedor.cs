using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FrbaOfertas.Repositorios;
using FrbaOfertas.Forms;
using System.Windows.Forms;
using System.Data;

namespace FrbaOfertas.Presenters
{
    class PresenterProveedor
    {
        private AbmOfertas abmrol_form;
        public static PresenterProveedor presenter;

        public static PresenterProveedor instance()
        {
            return presenter == null ? new PresenterProveedor() : presenter;
        }

        public DataTable filtrarOfertas(string descripcion)
        {
            return RepoOferta.instance().traerOfertasFiltradas(descripcion);
        }


    }
}
