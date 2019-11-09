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
        /* public String clie_nombre { get; set; }
        public String clie_apellido { get; set; }
        */


        public Cliente(int id, long dni, String nombre, String apellido) {

            this.clie_id = id;
            this.clie_dni = dni;
            this.nombreYApellido = apellido + ", " + nombre;
            /*
            this.clie_nombre = nombre;
            this.clie_apellido = apellido;
        */}

    }
}
