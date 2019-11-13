using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FrbaOfertas.Modelo
{
    class Cliente
    {
        public int clie_id { get; set; }
        public long clie_dni { get; set; }
        public String nombreYApellido { get; set; }
        public int user_id { get; set; }
        public String mail { get; set; }
        public String telefono { get; set; }
        public String direccion { get; set; }
        public double saldo { get; set; }
        public int codigoPostal { get; set; }
        public String ciudad { get; set; }
        public DateTime fechaNac { get; set; }
        public String nombre { get; set; }
        public String apellido { get; set; }
        /* public String clie_nombre { get; set; }
        public String clie_apellido { get; set; }
        */

        

        public Cliente(int id,String nombre, String apellido,long dni,int user_id,String mail, String telefono,String direccion,double saldo,int codPostal,String ciudad,DateTime fechaNac) {

            this.clie_id = id;
            this.clie_dni = dni;
            this.mail = mail;
            this.nombre = nombre;
            this.apellido = apellido;
            this.ciudad = ciudad;
            this.codigoPostal = codPostal;
            this.direccion = direccion;
            this.fechaNac = fechaNac;
            this.saldo = saldo;
            this.user_id = user_id;
            this.telefono = telefono;
           
        }

        public Cliente(int id, long dni, String nombre, String apellido)
        {

            this.clie_id = id;
            this.clie_dni = dni;
            this.nombreYApellido = apellido + ", " + nombre;
            /*
            this.clie_nombre = nombre;
            this.clie_apellido = apellido;
        */
        }
        

    }
}
