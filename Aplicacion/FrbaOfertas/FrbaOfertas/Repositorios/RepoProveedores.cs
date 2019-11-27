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

        public void canjearCupon(int cupon, DateTime fecha)
        {
            try
            {
                SqlConnection conexion = ServerSQL.instance().levantarConexion();
                SqlCommand command = QueryFactory.instance().canjearCupon(cupon,fecha,conexion);
                command.ExecuteNonQuery();
                MessageBox.Show("Cupon canjeado correctamente");
            }
            catch (Exception err)
            {
                MessageBox.Show("Error al canjear el cupon: " + err.Message);
            }
        }

        public DataTable getCuponesNoCanjeados(int proveedor,int cliente,DateTime fecha)
        {
            SqlConnection conexion = ServerSQL.instance().levantarConexion();
            SqlCommand command = QueryFactory.instance().traerCuponesDeProveedor(proveedor,cliente,fecha,conexion);
            SqlDataReader reader = command.ExecuteReader();

            return (reader.HasRows) ? this.cargarCuponesNoCanjeados(reader) : null;
        }

        private DataTable cargarCuponesNoCanjeados(SqlDataReader reader)
        {
            List<Cupon> listaCupones = new List<Cupon>();
            Cupon cupon = new Cupon();
            DataTable tabla = new DataTable();
            tabla.Columns.Add(new DataColumn("ID"));
            tabla.Columns.Add(new DataColumn("Fecha"));
            tabla.Columns.Add(new DataColumn("Oferta"));
            tabla.Columns.Add(new DataColumn("Cliente"));
            tabla.Columns.Add(new DataColumn("Compra"));
            while (reader.Read())
            {
                DataRow row = tabla.NewRow();

                row["ID"] = reader["cupo_id"];
                row["Fecha"] = reader["cupo_fecha"];
                row["Oferta"] = reader["cupo_oferta"];
                row["Cliente"] = reader["cupo_cliente"];
                row["Compra"] = reader["cupo_compra"];


                tabla.Rows.Add(row);


            }
            return tabla;
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

        public DataTable buscarProveedor(string razonSocial, string cuit, string mail)
        {
            SqlConnection conexion = ServerSQL.instance().levantarConexion();
            SqlCommand command = QueryFactory.instance().buscarProveedor(razonSocial, cuit, mail, conexion);
            SqlDataReader reader = command.ExecuteReader();

            DataTable tabla = new DataTable();
            tabla.Columns.Add(new DataColumn("ID"));
            tabla.Columns.Add(new DataColumn("Cuit"));
            tabla.Columns.Add(new DataColumn("Razon social"));
            tabla.Columns.Add(new DataColumn("Rubro"));
            tabla.Columns.Add(new DataColumn("Direccion"));
            tabla.Columns.Add(new DataColumn("Mail"));
            tabla.Columns.Add(new DataColumn("Telefono"));
            tabla.Columns.Add(new DataColumn("Nombre"));
            tabla.Columns.Add(new DataColumn("Ciudad"));
            tabla.Columns.Add(new DataColumn("Estado"));
            tabla.Columns.Add(new DataColumn("Codigo Postal"));
            tabla.Columns.Add(new DataColumn("Id Usuario"));

            if (!reader.HasRows)
            {
                return null;
            }

            while (reader.Read())
            {


                DataRow row = tabla.NewRow();

                row["ID"] = reader["prov_id"];
                row["Cuit"] = reader["prov_cuit"];
                row["Razon social"] = reader["prov_razon"];
                row["Id Usuario"] = reader["prov_userId"];


                row["Rubro"] = this.getRubro(reader["prov_rubro"].ToString());


                row["Direccion"] = reader["prov_direccion"];
                row["Mail"] = reader["prov_mail"];
                row["Telefono"] = reader["prov_telefono"];
                row["Nombre"] = reader["prov_nombre"];
                row["Ciudad"] = reader["prov_ciudad"];
                row["Estado"] = reader["prov_habilitado"];
                row["Codigo Postal"] = reader["prov_codigoPostal"];


                tabla.Rows.Add(row);

            }

            return tabla;

        }

        public DataTable buscarProveedoresSinUsuario()
        {
            SqlConnection conexion = ServerSQL.instance().levantarConexion();
            SqlCommand command = QueryFactory.instance().buscarProveedoresSinUsuario(conexion);
            SqlDataReader reader = command.ExecuteReader();

            DataTable tabla = new DataTable();
            tabla.Columns.Add(new DataColumn("ID"));
            tabla.Columns.Add(new DataColumn("Cuit"));
            tabla.Columns.Add(new DataColumn("Razon social"));
            tabla.Columns.Add(new DataColumn("Rubro"));
            tabla.Columns.Add(new DataColumn("Direccion"));
            tabla.Columns.Add(new DataColumn("Mail"));
            tabla.Columns.Add(new DataColumn("Telefono"));
            tabla.Columns.Add(new DataColumn("Nombre"));
            tabla.Columns.Add(new DataColumn("Ciudad"));
            tabla.Columns.Add(new DataColumn("Estado"));
            tabla.Columns.Add(new DataColumn("Codigo Postal"));
            tabla.Columns.Add(new DataColumn("Id Usuario"));

            if (!reader.HasRows)
            {
                return null;
            }

            while (reader.Read())
            {


                DataRow row = tabla.NewRow();

                row["ID"] = reader["prov_id"];
                row["Cuit"] = reader["prov_cuit"];
                row["Razon social"] = reader["prov_razon"];
                row["Id Usuario"] = reader["prov_userId"];


                row["Rubro"] = this.getRubro(reader["prov_rubro"].ToString());


                row["Direccion"] = reader["prov_direccion"];
                row["Mail"] = reader["prov_mail"];
                row["Telefono"] = reader["prov_telefono"];
                row["Nombre"] = reader["prov_nombre"];
                row["Ciudad"] = reader["prov_ciudad"];
                row["Estado"] = reader["prov_habilitado"];
                row["Codigo Postal"] = reader["prov_codigoPostal"];


                tabla.Rows.Add(row);

            }

            return tabla;

        }



        private string getRubro(string rubrId)
        {
            SqlConnection conexion = ServerSQL.instance().levantarConexion();
            SqlCommand command = QueryFactory.instance().getNombreRubro(rubrId, conexion);
            SqlDataReader reader = command.ExecuteReader();

            reader.Read();
            return reader[0].ToString();

        }

        public List<string> getRubros()
        {
            SqlConnection conexion = ServerSQL.instance().levantarConexion();
            SqlCommand command = QueryFactory.instance().traerRubros(conexion);
            SqlDataReader reader = command.ExecuteReader();
            List<string> rubros=new List<string>();
            while (reader.Read())
            {
                rubros.Add(reader[1].ToString());

            }

            return rubros;
        }

        public int getRubroPorNombre(string rubrNombre)
        {
            SqlConnection conexion = ServerSQL.instance().levantarConexion();
            SqlCommand command = QueryFactory.instance().getRubroPorNombre(rubrNombre,conexion);
            SqlDataReader reader = command.ExecuteReader();
            reader.Read();

            return Convert.ToInt32(reader[0]);

        }


        public void altaProveedor(Proveedor prov)
        {
            try
            {
                SqlConnection conexion = ServerSQL.instance().levantarConexion();
                SqlCommand command = QueryFactory.instance().altaProveedor(prov, conexion);
                command.ExecuteNonQuery();
                MessageBox.Show("Proveedor creado correctamente");
            }
            catch (Exception err)
            {
                MessageBox.Show("Error al crear proveedor: " + err.Message);
            }
        }

        public void modificarProveedor(string provId, Proveedor prov)
        {
            try
            {
                SqlConnection conexion = ServerSQL.instance().levantarConexion();
                SqlCommand command = QueryFactory.instance().modificarProveedor(provId,prov, conexion);
                command.ExecuteNonQuery();
                MessageBox.Show("Proveedor modificado correctamente");
            }
            catch (Exception err)
            {
                MessageBox.Show("Error al modificar proveedor: " + err.Message);
            }
        }

        public List<string> getRazonSocialProveedores()
        {
            SqlConnection conexion = ServerSQL.instance().levantarConexion();
            SqlCommand command = QueryFactory.instance().traerRazonSocialProveedores(conexion);
            SqlDataReader reader = command.ExecuteReader();
            List<string> proveedores = new List<string>();
            while (reader.Read())
            {
                proveedores.Add(reader[0].ToString());

            }

            return proveedores;
        }

        public DataTable filtrarOfertasPorProveedor(string prov)
        {
            throw new NotImplementedException();
        }

        public int getIdProveedor(string prov)
        {
            SqlConnection conexion = ServerSQL.instance().levantarConexion();
            SqlCommand command = QueryFactory.instance().getProvPorRazonSocial(prov, conexion);
            SqlDataReader reader = command.ExecuteReader();
            reader.Read();

            return Convert.ToInt32(reader[0]);
        }
    }
}
