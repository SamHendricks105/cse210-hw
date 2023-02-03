class Square : Shapes
{
    protected double side;
    


    //Constuctors 
   public Square(string _color, double _side) : base(_color)
   {
        side = _side;
        
   }
    
    //Methonds 
    
    public override double  getArea() 
    {
      return side *side;
    }
    



}