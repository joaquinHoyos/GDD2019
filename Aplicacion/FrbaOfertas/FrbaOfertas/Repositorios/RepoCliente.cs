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
                //throw e;
                MessageBox.Show(e.Message);
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
               // throw e;
                MessageBox.Show(e.Message);
            }
            
        }
        
        public List<Cupon> traerCuponesPropios(int userID)
        {
            SqlConnection conexion = ServerSQL.instance().levantarConexion();

            SqlCommand command = QueryFactory.instance().traerCuponesPropios(userID,conexion);

            List<Cupon> listaCupones = new List<Cupon>();
            try
            {
                
                
                using (SqlDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {

                        listaCupones.Add(new Cupon(Convert.ToInt32(reader["cupo_id"].ToString()), DateTime.Parse(reader["cupo_fecha"].ToString()), reader["cupo_oferta"].ToString(), Convert.ToInt32(reader["cupo_cliente"]), reader["ofer_descripcion"].ToString()));//,Convert.ToInt32(reader["cupo_compra"].ToString())));

                    }
                }
                conexion.Close();
                return listaCupones;
                
            }
            catch (SqlException e)
            {
               // throw e;
                MessageBox.Show(e.Message);
                return listaCupones;
            }


        }


        public List<Cliente> traerClientes()
        {
            SqlConnection conexion = ServerSQL.instance().levantarConexion();

            SqlCommand command = new SqlCommand("SELECT * FROM PASO_A_PASO.Cliente",conexion);

            List<Cliente> listaClientes = new List<Cliente>();
            try
            {

                
                using (SqlDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {

                        listaClientes.Add(new Cliente(Convert.ToInt32(reader["clie_id"].ToString()), Convert.ToInt64(reader["clie_dni"].ToString()), reader["clie_nombre"].ToString(), reader["clie_apellido"].ToString()));//,Convert.ToInt32(reader["cupo_compra"].ToString())));

                    }
                }
                conexion.Close();
                return listaClientes;

            }
            catch (SqlException e)
            {
               // throw e;
                MessageBox.Show(e.Message);
                return listaClientes;

            }


        }

        public void regalarCupon(int idCupon, int idCliente){
            SqlConnection conexion = ServerSQL.instance().levantarConexion();

            SqlCommand command = QueryFactory.instance().regalarCupon(idCupon,idCliente,conexion);


            try
            {

                command.ExecuteNonQuery();
                MessageBox.Show("Regalo exitoso");
            }
            catch (SqlException e)
            {
                //throw e;
                MessageBox.Show(e.Message);
            }
            
        
        
        }

        public int traerSaldo(int userId) {

            SqlConnection conexion = ServerSQL.instance().levantarConexion();

            SqlCommand command = QueryFactory.instance().saldoUsuario(userId, conexion);


            try
            {
               SqlDataReader reader = command.ExecuteReader();
                {
                    if (reader.Read())
                    {
                        return Convert.ToInt32(reader["clie_saldo"]);
                    }
               }
            }
            catch (SqlException e)
            {
                //throw e;
                MessageBox.Show(e.Message);
            }

            return 0;
        }


        public void crearCliente(Cliente cli)
        {
            SqlConnection conexion = ServerSQL.instance().levantarConexion();
            SqlCommand command = QueryFactory.instance().crearCliente(cli, conexion);
            command.ExecuteNonQuery();
        }

        public void modificarCliente(String clie_id, Cliente cli)
        {
            SqlConnection conexion = ServerSQL.instance().levantarConexion();
            SqlCommand command = QueryFactory.instance().modificarCliente(clie_id,cli, conexion);
            command.ExecuteNonQuery();
        }

        public void deshabilitarCliente(String clie_id)
        {
            SqlConnection conexion = ServerSQL.instance().levantarConexion();
            SqlCommand command = QueryFactory.instance().deshabilitarCliente(clie_id, conexion);
            command.ExecuteNonQuery();
        }

        public void asignarUsuario(String clie_id, String usuario, String contrasena, List<String> listaRoles)
        {
            SqlConnection conexion = ServerSQL.instance().levantarConexion();

            try
            {

                SqlCommand command = QueryFactory.instance().asignarUsuarioACliente(clie_id, usuario, contrasena, listaRoles, conexion);
                command.ExecuteNonQuery();
                MessageBox.Show("Usuario asginado correctamente");
            }
            catch (Exception e)
            {

                MessageBox.Show("Error al asginar el usuario al cliente" + e.Message);
            }

        }

       
    }
}

