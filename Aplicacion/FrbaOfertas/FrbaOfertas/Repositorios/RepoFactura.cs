using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FrbaOfertas.Server;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace FrbaOfertas.Repositorios
{
    class RepoFactura
    {
        public static RepoFactura repo;

        public static RepoFactura instance()
        {
            return repo == null ? repo = new RepoFactura() : repo;
        }

        public void facturar(DateTime fechaInicio, DateTime fechaFinal, int proveedor)
        {
            try
            {
                SqlConnection conexion = ServerSQL.instance().levantarConexion();
                SqlCommand command = QueryFactory.instance().crearFactura(fechaInicio, fechaFinal, proveedor, conexion);
                SqlDataReader reader = command.ExecuteReader();
                MessageBox.Show("Se facturo correctamente");
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
        }
    }
}
