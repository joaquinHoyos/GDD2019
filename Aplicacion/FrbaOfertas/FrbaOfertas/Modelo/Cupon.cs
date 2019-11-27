using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FrbaOfertas.Modelo
{
    class Cupon
    {

        public int cupo_id { get; set; }
        DateTime cupo_fecha { get; set; } //sin public para no mostrar en dataGridView
        public String cupo_oferta { get; set; }
        public int cupo_cliente { get; set; }
        public int cupo_compra { get; set; }
        public String descripcion { get; set; }
        

        public Cupon(int id, DateTime fecha, String oferta, int cliente, int compra,String _descripcion)
        {

            this.cupo_id = id;
            this.cupo_fecha = fecha;
            this.cupo_oferta = oferta;
            this.cupo_cliente = cliente;
            this.cupo_compra = compra;
            this.descripcion = _descripcion;


        
     
        }

        public Cupon(int id, DateTime fecha, String oferta, int cliente,String _descripcion)
        {

            this.cupo_id = id;
            this.cupo_fecha = fecha;
            this.cupo_oferta = oferta;
            this.cupo_cliente = cliente;
            this.descripcion = _descripcion;


        }
        public Cupon()
        {

        }

    }
}
