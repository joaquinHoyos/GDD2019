using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FrbaOfertas.Modelo
{
    class Proveedor
    {
        int id;
        string cuit;
        string razonSocial;
        int user;
        string mail;
        long telefono;
        string direccion;
        int codigoPostal;
        string ciudad;
        int rubro;
        string nombre;
        char habilitado;

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
