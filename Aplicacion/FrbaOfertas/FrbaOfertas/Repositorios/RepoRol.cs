﻿using System;
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
        public List<Rol> rolesBuscados;
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
                    this.funcionesAdmin.Add((int)Enum.Parse(typeof(EnumFunciones), reader.GetSqlString(0).ToString()));
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
                    this.funcionesCliente.Add((int)Enum.Parse(typeof(EnumFunciones), reader.GetSqlString(0).ToString()));
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
            SqlCommand command = QueryFactory.instance().busquedaRol_Id(id, conexion);
            SqlDataReader reader = command.ExecuteReader();

            return (reader.HasRows) ? this.cargarRolesBusqueda(reader) : new DataTable();
        }

        public DataTable buscarPorNombre(string nombre)
        {
            SqlConnection conexion = ServerSQL.instance().levantarConexion();
            SqlCommand command = QueryFactory.instance().busquedaRol_Nombre(nombre,conexion);
            SqlDataReader reader = command.ExecuteReader();
            return (reader.HasRows) ? this.cargarRolesBusqueda(reader) : new DataTable();
        }

        public DataTable buscarPorFunciones(DataTable funcion)
        {
            SqlConnection conexion = ServerSQL.instance().levantarConexion();
            SqlCommand command = QueryFactory.instance().busquedaRol_Funcion(funcion, conexion);
            SqlDataReader reader = command.ExecuteReader();
            return (reader.HasRows) ? this.cargarRolesBusqueda(reader) : new DataTable();
        }

        public DataTable buscarPorIdYNombre(decimal id,string nombre)
        {
            SqlConnection conexion = ServerSQL.instance().levantarConexion();
            SqlCommand command = QueryFactory.instance().busquedaRol_IdYNombre(id,nombre,conexion);
            SqlDataReader reader = command.ExecuteReader();
            return (reader.HasRows) ? this.cargarRolesBusqueda(reader) : new DataTable();
        }

        public DataTable buscarPorIdYFuncion(decimal id, DataTable funcion)
        {
            SqlConnection conexion = ServerSQL.instance().levantarConexion();
            SqlCommand command = QueryFactory.instance().busquedaRol_IdYFuncion(id,funcion, conexion);
            SqlDataReader reader = command.ExecuteReader();
            return (reader.HasRows) ? this.cargarRolesBusqueda(reader) : new DataTable();
        }

        public DataTable buscarPorNombreYFuncion(string nombre,DataTable funcion)
        {
            SqlConnection conexion = ServerSQL.instance().levantarConexion();
            SqlCommand command = QueryFactory.instance().busquedaRol_NombreYFuncion(nombre, funcion,conexion);
            SqlDataReader reader = command.ExecuteReader();
            return (reader.HasRows) ? this.cargarRolesBusqueda(reader) : new DataTable();
        }

        public DataTable buscarPorTodo()
        {
            SqlConnection conexion = ServerSQL.instance().levantarConexion();
            SqlCommand command = QueryFactory.instance().busquedaRol_Todo(conexion);
            SqlDataReader reader = command.ExecuteReader();
            return (reader.HasRows) ? this.cargarRolesBusqueda(reader) : new DataTable();
        }

        private DataTable cargarRolesBusqueda(SqlDataReader reader)
        {
            List<Rol> listaRoles = new List<Rol>();
            Rol rol = new Rol(-1, "", new List<structFuncion>(), new Char());
            DataTable tabla = new DataTable();
            tabla.Columns.Add(new DataColumn("ID"));
            tabla.Columns.Add(new DataColumn("Nombre"));
            while (reader.Read())
            {
                if (rol.id == -1)
                {
                    rol.id = Convert.ToInt32(reader.GetSqlInt32(0).ToString());
                    rol.nombre = reader.GetSqlString(1).ToString();
                    rol.estado = reader.GetSqlString(4).ToString().ToCharArray()[0];
                    structFuncion structFunc= new structFuncion();
                    structFunc.funcion = Convert.ToInt32(reader.GetSqlInt32(2).ToString());
                    structFunc.grupo = reader.GetSqlString(3).ToString().ToCharArray()[0];
                    rol.funciones.Add(structFunc);
                    DataRow row = tabla.NewRow();
                    row["ID"] = rol.id;
                    row["Nombre"] = rol.nombre;
                    tabla.Rows.Add(row);
                }
                else if (rol.id == Convert.ToInt32(reader.GetSqlInt32(0).ToString()))
                {
                    structFuncion structFunc = new structFuncion();
                    structFunc.funcion = Convert.ToInt32(reader.GetSqlInt32(2).ToString());
                    structFunc.grupo = reader.GetSqlString(3).ToString().ToCharArray()[0];
                    rol.funciones.Add(structFunc);
                 
                }
                else
                {
                    listaRoles.Add(rol);
                    rol = new Rol(-1,"",new List<structFuncion>(),new Char());
                    rol.id = Convert.ToInt32(reader.GetSqlInt32(0).ToString());
                    rol.nombre = reader.GetSqlString(1).ToString();
                    rol.estado = reader.GetSqlString(4).ToString().ToCharArray()[0];
                    structFuncion structFunc = new structFuncion();
                    structFunc.funcion = Convert.ToInt32(reader.GetSqlInt32(2).ToString());
                    structFunc.grupo = reader.GetSqlString(3).ToString().ToCharArray()[0];
                    rol.funciones.Add(structFunc); 
                    DataRow row = tabla.NewRow();
                    row["ID"] = rol.id;
                    row["Nombre"] = rol.nombre;
                    tabla.Rows.Add(row);
                    listaRoles.Add(rol);
                }
                
            }
            
            this.rolesBuscados=listaRoles;
            return tabla;
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
                    this.funcionesProveedor.Add((int)Enum.Parse(typeof(EnumFunciones), reader.GetSqlString(0).ToString()));
                }
                return this.funcionesProveedor;
            }
            else
            {
                return this.funcionesProveedor;
            }

        }

        public Rol obtenerSeleccionado(string seleccionado)
        {
            for (int i = 0; i < this.rolesBuscados.Count; i++)
            {
                Rol rol = rolesBuscados[i];
                if (rol.nombre == seleccionado) { return rol; }
            }
            return new Rol(-1,"",new List<structFuncion>(),new Char());
        }

        public void habilitarRol(int rol)
        {
            SqlConnection conexion = ServerSQL.instance().levantarConexion();
            SqlCommand command = QueryFactory.instance().habilitarRol(rol, conexion);
            command.ExecuteNonQuery();
        }
        public void deshabilitarRol(int rol)
        {
            SqlConnection conexion = ServerSQL.instance().levantarConexion();
            SqlCommand command = QueryFactory.instance().deshabilitarRol(rol, conexion);
            command.ExecuteNonQuery();
        }

        public void modificarRol(int rol, string nombre, DataTable funciones)
        {
            SqlConnection conexion = ServerSQL.instance().levantarConexion();
            SqlCommand command = QueryFactory.instance().modificarRol(rol, nombre, funciones, conexion);
            command.ExecuteNonQuery();
        }

        public List<Rol> traerTodosLosRoles()
        {
             SqlConnection conexion = ServerSQL.instance().levantarConexion();
            List<Rol> devolver = new List<Rol>();
            SqlCommand command = QueryFactory.instance().traerTodosLosRoles(conexion);
            SqlDataReader reader = command.ExecuteReader();


            while (reader.Read())
            {
                Rol rolAux = new Rol(Convert.ToInt32(reader["rol_id"]), reader["rol_nombre"].ToString(),null,'E');
                devolver.Add(rolAux);

            }

            return devolver;
        }

        public int getIdRol(string rolNombre)
        {
            SqlConnection conexion = ServerSQL.instance().levantarConexion();
            SqlCommand command = QueryFactory.instance().getIdRol(rolNombre,conexion);
            SqlDataReader reader = command.ExecuteReader();
            reader.Read();
            return Convert.ToInt32(reader["rol_id"]);

        }
    }
}
