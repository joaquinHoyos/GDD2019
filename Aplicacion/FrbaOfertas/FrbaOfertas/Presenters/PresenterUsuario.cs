using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FrbaOfertas.Forms;
using FrbaOfertas.Modelo;
using FrbaOfertas.Repositorios;

namespace FrbaOfertas.Presenters
{
    class PresenterUsuario
    {

        private User rolSeleccionado = new User();
        private ABMCliente abmClientes;
        public static PresenterAdmin presenter;

        public static PresenterAdmin instance()
        {
            return presenter == null ? presenter = new PresenterAdmin() : presenter;
        }

       

    }
}
