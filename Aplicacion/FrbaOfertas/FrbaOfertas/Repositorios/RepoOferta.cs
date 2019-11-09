using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using FrbaOfertas.Server;
using FrbaOfertas.Modelo;
using System.Data;

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

        public DataTable traerOfertasFiltradas(string descripcion)
        {
            SqlConnection conexion = ServerSQL.instance().levantarConexion();
            SqlCommand command = QueryFactory.instance().busquedaOferta(descripcion,conexion);
            SqlDataReader reader = command.ExecuteReader();

            return (reader.HasRows) ? this.cargarOfertaBusqueda(reader) : null;
        }



        private DataTable cargarOfertaBusqueda(SqlDataReader reader)
        {
            List<Oferta> listaOferta = new List<Oferta>();
            Oferta oferta = new Oferta();
            DataTable tabla = new DataTable();
            tabla.Columns.Add(new DataColumn("ID"));
            tabla.Columns.Add(new DataColumn("Descipcion"));
            tabla.Columns.Add(new DataColumn("FechaDesde"));
            tabla.Columns.Add(new DataColumn("FechaHasta"));
            tabla.Columns.Add(new DataColumn("precioOferta"));
            tabla.Columns.Add(new DataColumn("precioLista"));
            tabla.Columns.Add(new DataColumn("disponible"));
            tabla.Columns.Add(new DataColumn("maxDisponible"));
            while (reader.Read())
            {

                row["ID"] = rol.id;
                row["Nombre"] = rol.nombre;
                tabla.Rows.Add(row);
                if (oferta.id == -1)
                {
                    rol.id = Convert.ToInt32(reader.GetSqlInt32(0).ToString());
                    rol.nombre = reader.GetSqlString(1).ToString();
                    rol.funciones.Add(Convert.ToInt32(reader.GetSqlInt32(2).ToString()));
                    DataRow row = tabla.NewRow();
                    
                }
                else if (rol.id == Convert.ToInt32(reader.GetSqlInt32(0).ToString()))
                {
                    rol.funciones.Add(Convert.ToInt32(reader.GetSqlInt32(2).ToString()));

                }
                else
                {
                    listaRoles.Add(rol);
                    rol = new Rol(-1, "", new List<int>());
                    rol.id = Convert.ToInt32(reader.GetSqlInt32(0).ToString());
                    rol.nombre = reader.GetSqlString(1).ToString();
                    rol.funciones.Add(Convert.ToInt32(reader.GetSqlInt32(2).ToString()));
                    DataRow row = tabla.NewRow();
                    row["ID"] = rol.id;
                    row["Nombre"] = rol.nombre;
                    tabla.Rows.Add(row);

                }

            }
            this.rolesBuscados = listaRoles;
            return tabla;
        }


    }
}
