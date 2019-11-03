using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FrbaOfertas.Modelo
{
    class Oferta
    {
        public int ofer_id { get; set; }
        public string ofer_descripcion { get; set; }
        public DateTime ofer_fechaDesde { get; set; }
        public DateTime ofer_fechaHasta  { get; set; }
        public Double ofer_precioOferta { get; set; }
        public Double ofer_precioLista { get; set; }
        public int ofer_proveedor { get; set; }
        public int ofer_disponible { get; set; }
        public int ofer_maxDisponible { get; set; }

        public Oferta(int _id,string _descripcion,DateTime _desde,DateTime _hasta,double _precioOferta,double _precioLista,int _proveedor, int _disponible, int _maxDisponible) {

            this.ofer_id=_id;
            this.ofer_descripcion= _descripcion;
            this.ofer_fechaDesde=_desde;
            this.ofer_fechaHasta=_hasta;
            this.ofer_precioOferta=_precioOferta;
            this.ofer_precioLista=_precioLista;
            this.ofer_proveedor=_proveedor;
            this.ofer_disponible=_disponible;
            this.ofer_maxDisponible=_maxDisponible;
        }

        public Oferta()
        {

         }





    }
}
