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
