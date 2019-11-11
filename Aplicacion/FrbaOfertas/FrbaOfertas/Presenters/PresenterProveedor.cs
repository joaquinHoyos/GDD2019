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

        public DataTable filtrarOfertas(string descripcion,DateTime fecha)
        {
            return RepoOferta.instance().traerOfertasFiltradas(descripcion,fecha);
        }
        public int getProveedorActual()
        {
            return RepoUsuario.instance().idActual;
        }

        public void nuevaOferta(Oferta oferta)
        {
            RepoOferta.instance().agregarOferta(oferta);
        }

        public void editarOferta(Oferta oferta)
        {
            RepoOferta.instance().editarOferta(oferta);
        }

        public void eliminarOferta(string idOferta)
        {
            RepoOferta.instance().eliminarOferta(idOferta);
        }


    }
}
