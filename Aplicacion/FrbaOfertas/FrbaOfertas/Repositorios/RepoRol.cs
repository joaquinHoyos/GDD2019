using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FrbaOfertas.Modelo;
using System.Data.SqlClient;
using FrbaOfertas.Server;

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
            return repo == null ? new RepoRol() : repo;
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
