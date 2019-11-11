using System.Collections.Generic;
public struct Rol
{
    public int id;
    public string nombre;
    public List<structFuncion> funciones;

   public Rol(int id,string nombre,List<structFuncion>funciones)
    {
        this.id = id;
        this.nombre = nombre;
        this.funciones = funciones;
    }
}