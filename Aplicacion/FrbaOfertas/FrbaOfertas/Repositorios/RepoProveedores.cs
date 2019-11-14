using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FrbaOfertas.Forms;
using System.Windows.Forms;
using System.Data;
using FrbaOfertas.Modelo;
using System.Data.SqlClient;
using FrbaOfertas.Server;

namespace FrbaOfertas.Repositorios
{
    class RepoProveedores
    {
        public static RepoProveedores repo;
        List<Proveedor> proveedores;
        

        public static RepoProveedores instance()
        {
            return repo == null ? repo = new RepoProveedores() : repo;
        }

        public DataTable getProveedores()
        {
            SqlConnection conexion = ServerSQL.instance().levantarConexion();
            SqlCommand command = QueryFactory.instance().traerProveedores(conexion);
            SqlDataReader reader = command.ExecuteReader();

            return (reader.HasRows) ? this.cargarProveedores(reader) : null;

        }

        public DataTable listadoEstadisticoDescuentos(int semestre, int anio)
        {
            SqlConnection conexion = ServerSQL.instance().levantarConexion();
            int mesInicio, mesFin;
            if (semestre == 1)
            {
                mesInicio = 1;
                mesFin = 6;
            }
            else
            {
                mesInicio = 7;
                mesFin = 12;
            }
            
            SqlCommand command = QueryFactory.instance().listadoEstadisticoDescuentos(mesInicio,mesFin,anio,conexion);
            SqlDataReader reader = command.ExecuteReader();
            return this.tablaListadoDescuentos(reader);
        }

        public DataTable listadoEstadisticoVentas(int semestre, int anio)
        {
            SqlConnection conexion = ServerSQL.instance().levantarConexion();
            int mesInicio, mesFin;
            if (semestre == 1)
            {
                mesInicio = 1;
                mesFin = 6;
            }
            else
            {
                mesInicio = 7;
                mesFin = 12;
            }
            SqlCommand command = QueryFactory.instance().listadoEstadisticoVentas(mesInicio,mesFin, anio, conexion);
            SqlDataReader reader = command.ExecuteReader();
            return this.tablaListadoVentas(reader);
        }

        private DataTable tablaListadoDescuentos(SqlDataReader reader)
        {
            DataTable tabla = new DataTable();
            tabla.Columns.Add(new DataColumn("ID"));
            tabla.Columns.Add(new DataColumn("Razon Social"));
            tabla.Columns.Add(new DataColumn("CUIT"));
            tabla.Columns.Add(new DataColumn("Rubro"));
            tabla.Columns.Add(new DataColumn("Descuento Promedio"));
            tabla.Columns.Add(new DataColumn("Año"));
            tabla.Columns.Add(new DataColumn("Semestre"));

            while (reader.Read())
            {
                DataRow row = tabla.NewRow();
                row["ID"] = Convert.ToInt32(reader.GetSqlInt32(0).ToString());
                row["Razon Social"] = reader.GetSqlString(1).ToString();
                row["CUIT"] = reader.GetSqlString(2).ToString();
                row["Rubro"] = reader.GetSqlString(3).ToString();
                row["Descuento Promedio"] = Convert.ToDecimal(reader.GetSqlDecimal(4).ToString());
                row["Año"] = Convert.ToInt32(reader.GetSqlInt32(5).ToString());
                row["Semestre"] = Convert.ToInt32(reader.GetSqlInt32(6).ToString());
                tabla.Rows.Add(row);
            }
            return tabla;
        }

        private DataTable tablaListadoVentas(SqlDataReader reader)
        {   
            DataTable tabla = new DataTable();
            tabla.Columns.Add(new DataColumn("ID"));
            tabla.Columns.Add(new DataColumn("Razon Social"));
            tabla.Columns.Add(new DataColumn("CUIT"));
            tabla.Columns.Add(new DataColumn("Rubro"));
            tabla.Columns.Add(new DataColumn("Cantidad de Compras"));
            tabla.Columns.Add(new DataColumn("Año"));
            tabla.Columns.Add(new DataColumn("Semestre"));

            while (reader.Read())
            {
                DataRow row = tabla.NewRow();
                row["ID"] = Convert.ToInt32(reader.GetSqlInt32(0).ToString());
                row["Razon Social"] = reader.GetSqlString(1).ToString();
                row["CUIT"] = reader.GetSqlString(2).ToString();
                row["Rubro"] = reader.GetSqlString(3).ToString();
                row["Cantidad de Compras"] = Convert.ToInt32(reader.GetSqlInt32(4).ToString());
                row["Año"] = Convert.ToInt32(reader.GetSqlInt32(5).ToString());
                row["Semestre"] = Convert.ToInt32(reader.GetSqlInt32(6).ToString());
                tabla.Rows.Add(row);
            }
            return tabla;
        }




        private DataTable cargarProveedores(SqlDataReader reader)
        {
            List<Proveedor> listaProveedores = new List<Proveedor>();
            Proveedor proveedor = new Proveedor();
            DataTable tabla = new DataTable();
            tabla.Columns.Add(new DataColumn("ID"));
            tabla.Columns.Add(new DataColumn("Cuit"));
            tabla.Columns.Add(new DataColumn("RazonSocial"));
            tabla.Columns.Add(new DataColumn("User"));
            tabla.Columns.Add(new DataColumn("Mail"));
            tabla.Columns.Add(new DataColumn("Telefono"));
            tabla.Columns.Add(new DataColumn("Direccion"));
            tabla.Columns.Add(new DataColumn("CodigoPostal"));
            tabla.Columns.Add(new DataColumn("Ciudad"));
            tabla.Columns.Add(new DataColumn("Rubro"));
            tabla.Columns.Add(new DataColumn("Nombre"));
            tabla.Columns.Add(new DataColumn("Habilitado"));
            while (reader.Read())
            {
                DataRow row = tabla.NewRow();

                row["ID"] = reader["prov_id"];
                row["Cuit"] = reader["prov_cuit"];
                row["RazonSocial"] = reader["prov_razon"];
                row["User"] = reader["prov_userId"];
                row["Mail"] = reader["prov_mail"];
                row["Telefono"] = reader["prov_telefono"];
                row["Direccion"] = reader["prov_direccion"];
                row["CodigoPostal"] = reader["prov_codigoPostal"];
                row["Ciudad"] = reader["prov_ciudad"];
                row["Rubro"] = reader["prov_rubro"];
                row["Nombre"] = reader["prov_nombre"];
                row["Habilitado"] = reader["prov_habilitado"];


                tabla.Rows.Add(row);


            }
            this.proveedores = listaProveedores;
            return tabla;
        }
    }
}
