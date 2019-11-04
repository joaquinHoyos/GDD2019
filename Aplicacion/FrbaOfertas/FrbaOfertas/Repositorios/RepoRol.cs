using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FrbaOfertas.Modelo;
using System.Data.SqlClient;
using FrbaOfertas.Server;
using System.Data;
namespace FrbaOfertas.Repositorios
{
    class RepoRol
    {
        public static RepoRol repo;
        public List<int> funcionesAdmin;
        public List<int> funcionesCliente;
        public List<int> funcionesProveedor;

        public static RepoRol instance()
        {
            return repo == null ? repo=new RepoRol() : repo;
        }

        public void crearRol(string nombre, DataTable funciones)
        {
            SqlConnection conexion = ServerSQL.instance().levantarConexion();
            SqlCommand command = QueryFactory.instance().crearRol(nombre, funciones, conexion);
            command.ExecuteNonQuery();
        }

        public List<int> getFuncionesAdmin()
        {
            if (this.funcionesAdmin == null)
            {
                SqlConnection conexion = ServerSQL.instance().levantarConexion();
                SqlCommand command = QueryFactory.instance().traerFuncionesSegunGrupo('A',conexion);
                SqlDataReader reader = command.ExecuteReader();
                this.funcionesAdmin = new List<int>();
                while (reader.Read())
                {
                    this.funcionesAdmin.Add((int)Enum.Parse(typeof(Funciones), reader.GetSqlString(0).ToString()));
                }
                return this.funcionesAdmin;
            }
            else
            {
                return this.funcionesAdmin;            
            }

        }


        public List<int> getFuncionesCliente()
        {
            if (this.funcionesCliente == null)
            {
                SqlConnection conexion = ServerSQL.instance().levantarConexion();
                SqlCommand command = QueryFactory.instance().traerFuncionesSegunGrupo('C', conexion);
                SqlDataReader reader = command.ExecuteReader();
                this.funcionesCliente = new List<int>();
                while (reader.Read())
                {
                    this.funcionesCliente.Add((int)Enum.Parse(typeof(Funciones), reader.GetSqlString(0).ToString()));
                }
                return this.funcionesCliente;
            }
            else
            {
                return this.funcionesCliente;
            }

        }

        public DataTable buscarPorId(decimal id)
        {
            SqlConnection conexion = ServerSQL.instance().levantarConexion();
            SqlCommand command = QueryFactory.instance().busquedaId(id, conexion);
            SqlDataReader reader = command.ExecuteReader();
            DataTable tabla;
            if (reader.HasRows)
            {
                tabla = new DataTable();
                tabla.Columns.Add(new DataColumn("ID"));
                tabla.Columns.Add(new DataColumn("Nombre"));
                while (reader.Read())
                {
                    DataRow row = tabla.NewRow();
                    row["ID"] = reader.GetSqlInt32(0);
                    row["Nombre"] = reader.GetSqlString(1).ToString();
                    tabla.Rows.Add(row);
                }
                return tabla;
            }
            else { return null; }
        }
        public List<int> getFuncionesProveedor()
        {
            if (this.funcionesProveedor == null)
            {
                SqlConnection conexion = ServerSQL.instance().levantarConexion();
                SqlCommand command = QueryFactory.instance().traerFuncionesSegunGrupo('P', conexion);
                SqlDataReader reader = command.ExecuteReader();
                this.funcionesProveedor = new List<int>();
                while (reader.Read())
                {
                    this.funcionesProveedor.Add((int)Enum.Parse(typeof(Funciones), reader.GetSqlString(0).ToString()));
                }
                return this.funcionesProveedor;
            }
            else
            {
                return this.funcionesProveedor;
            }

        }

    }
}
