class Circle : Shapes
{
    protected double radius;


    public Circle (string _color, double _radius ) : base (_color)
    {
        radius = _radius;
    }

    public override double getArea()
    {
        double pie = Math.PI;

        return radius * pie;
    }




}