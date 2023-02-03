using System;

class Program
{
    static void Main(string[] args)
    {
        // square
        
        List <Shapes> shapeList = new List<Shapes>();

        
        Square s = new Square( "Red", 5);
        shapeList.Add(s);
        
        Rectangle r = new Rectangle("Green", 7, 8);
        shapeList.Add(r);
        
        Circle c = new Circle("Blue", 50);
        shapeList.Add(c);

        foreach(Shapes shape in shapeList)
        {
             Console.WriteLine (shape.getArea());
        }

        
    
    
    
    }



}