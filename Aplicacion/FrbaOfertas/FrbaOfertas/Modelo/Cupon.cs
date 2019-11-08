using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FrbaOfertas.Modelo
{
    class Cupon
    {

        int cupo_id { get; set; }
        DateTime cupo_fecha { get; set; }
        String cupo_oferta { get; set; }
        int cupo_cliente { get; set; }
        int cupo_compra { get; set; }


        public Cupon(int id, DateTime fecha, String oferta, int cliente, int compra)
        {

            this.cupo_id = id;
            this.cupo_fecha = fecha;
            this.cupo_oferta = oferta;
            this.cupo_cliente = cliente;
            this.cupo_compra = compra;

        
     
        }

        public Cupon(int id, DateTime fecha, String oferta, int cliente)
        {

            this.cupo_id = id;
            this.cupo_fecha = fecha;
            this.cupo_oferta = oferta;
            this.cupo_cliente = cliente;



        }

    }
}
