using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using FrbaOfertas.Server;
using FrbaOfertas.Modelo;

namespace FrbaOfertas.Repositorios
{
    class RepoCliente
    {
        public static RepoCliente repo;

        public static RepoCliente instance()
        {
            return repo == null ? repo = new RepoCliente() : repo;
        }


        public void cargarCredito(string tipoDePago, long tarjeta, long monto, int idUsuario)
        {
            SqlConnection conexion = ServerSQL.instance().levantarConexion();
            
            SqlCommand command = QueryFactory.instance().cargarCredito(tipoDePago,tarjeta,monto,idUsuario,conexion);


            try
            {

                command.ExecuteNonQuery();
                MessageBox.Show("Carga exitosa");
            }
            catch (SqlException e)
            {
                throw e;
            }
            
        }

        public void generarCompra(int idUsuario, String oferCodigo, int cantidad)
        {
            SqlConnection conexion = ServerSQL.instance().levantarConexion();

            SqlCommand command = QueryFactory.instance().generarCompra(idUsuario,oferCodigo,cantidad,conexion);


            try
            {

                command.ExecuteNonQuery();
                MessageBox.Show("Compra exitosa");
            }
            catch (SqlException e)
            {
                throw e;
            }
            
        }




    }
}
