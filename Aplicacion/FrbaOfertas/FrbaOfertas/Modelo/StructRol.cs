﻿using System.Collections.Generic;
public struct Rol
{
    public int id;
    public string nombre;
    public List<int> funciones;

   public Rol(int id,string nombre,List<int>funciones)
    {
        this.id = id;
        this.nombre = nombre;
        this.funciones = funciones;
    }
}