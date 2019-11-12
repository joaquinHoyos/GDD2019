﻿using System;
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

            return RepoUsuario.instance().idActual;
        }

        public void nuevaOferta(Oferta oferta)
        {
            try
            {
                RepoOferta.instance().agregarOferta(oferta);
                MessageBox.Show("Oferta Agregada");
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
        }

        public void editarOferta(Oferta oferta)
        {
            try{
            RepoOferta.instance().editarOferta(oferta);
               MessageBox.Show("Oferta Editada");
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
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


    }
}
