using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FrbaOfertas.Modelo
{
    class Proveedor
    {
        public int id {get;set;}
        public string cuit { get; set; }
        public string razonSocial { get; set; }
        public int user { get; set; }
        public string mail { get; set; }
        public long telefono { get; set; }
        public string direccion { get; set; }
        public int codigoPostal { get; set; }
        public string ciudad { get; set; }
        public int rubro { get; set; }
        public string nombre { get; set; }
        public char habilitado { get; set; }

        public Proveedor(int _id, string _cuit, string _razonSocial, int _user, string _mail, long _telefono, string _direccion, int _codigoPostal, string _ciudad, int _rubro, string _nombre, char _habilitado)
        {

            this.id=_id;
            this.cuit= _cuit;
            this.razonSocial=_razonSocial;
            this.user=_user;
            this.mail=_mail;
            this.telefono=_telefono;
            this.direccion=_direccion;
            this.codigoPostal=_codigoPostal;
            this.ciudad=_ciudad;
            this.rubro = _rubro;
            this.nombre = _nombre;
            this.habilitado = _habilitado;
        }

        public Proveedor()
        {
        }
    }
}
