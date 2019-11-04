using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using FrbaOfertas.Server;
using FrbaOfertas.Modelo;

namespace FrbaOfertas.Repositorios
{
     
    class RepoOferta
    {
        public static RepoOferta repo;

        public static RepoOferta instance()
        {
            return repo == null ? repo = new RepoOferta() : repo;
        }

        public List<Oferta> traerOfertasDisponibles() {
            SqlConnection conexion = ServerSQL.instance().levantarConexion();

            SqlCommand command = QueryFactory.instance().traerOfertasDisponibles(conexion) ;


            try
            {

                List<Oferta> listaOfertas = new List<Oferta>();
                using (SqlDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {

                        listaOfertas.Add(new Oferta((reader["ofer_id"]).ToString(), reader["ofer_descripcion"].ToString(), DateTime.Parse(reader["ofer_fechaDesde"].ToString()), DateTime.Parse(reader["ofer_fechaHasta"].ToString()), Convert.ToDouble(reader["ofer_precioOferta"]), Convert.ToDouble(reader["ofer_precioLista"]), Convert.ToInt32(reader["ofer_proveedor"]), Convert.ToInt32(reader["ofer_disponible"]),Convert.ToInt32(reader["ofer_maxDisponible"])));

                    }
                }
                conexion.Close();
                return listaOfertas;
            }
            catch (SqlException e)
            {
                throw e;
           
            }
            
        
        }



    }
}
