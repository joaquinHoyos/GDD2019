using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FrbaOfertas.Modelo
{
    class Rubro
    {
        public int rubr_id { get; set; }
        public String rubr_nombre { get; set; }


        public Rubro(int _id, String _nombre) {

            this.rubr_id = _id;
            this.rubr_nombre = _nombre;
        
        }
    }
}
