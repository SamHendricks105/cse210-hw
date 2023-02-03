using System;

abstract class Shapes
{
    //Member Varibles
    protected string color;
    

    //constuctors 
    public Shapes (string _color)
    {
        
        color = _color;
        
    }

    //methods 
     public abstract double getArea();
     public string StoreColor()
     {
        return color;
     }





}