using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FrbaOfertas.Modelo
{
    class Cupon
    {

        int cupo_id;
        DateTime cupo_fecha;
        String cupo_oferta;
        int cupo_cliente;
        int cupo_compra;


        public Cupon(int id, DateTime fecha, String oferta, int cliente, int compra)
        {

            this.cupo_id = id;
            this.cupo_fecha = fecha;
            this.cupo_oferta = oferta;
            this.cupo_cliente = cliente;
            this.cupo_compra = compra;

        
     
        }

    }
}
