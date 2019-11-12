using System.Collections.Generic;
public struct Rol
{
    public int id;
    public string nombre;
    public List<structFuncion> funciones;
    public char estado;
   public Rol(int id,string nombre,List<structFuncion>funciones,char estado)
    {
        this.id = id;
        this.nombre = nombre;
        this.estado = estado;
        this.funciones = funciones;
    }
}