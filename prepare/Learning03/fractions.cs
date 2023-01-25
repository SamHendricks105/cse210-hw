public class Fraction
{
    //Member varibles..........
    private int _top;
    private int _bottom;

    //constructors.............................. 
    public Fraction()
    {
        _top =1;
        _bottom=1;
    }

    public Fraction(int wholeNumber)
    {
        _top = wholeNumber;
        _bottom =1;
    }
    public Fraction(int top, int bottom)
    {
        _top= top;
        _bottom =bottom;
    }


    //Getters and setters...................
    public int getTop()
    {
        
        return _top;
    } 

    public void setTop(int top)
    {
        _top = top;            
    }

    public int getBottom()
    {
        return _bottom;
    } 

    public void setBottom(int bottom)
    {
        _bottom = bottom;            
    }

    // Methods......................................
    public string getFraction()
    {   
        string frac=$"{_top}/{_bottom}";
        return frac;    
    }

    public double getDecimal()
    {
        return (double)_top / (double)_bottom;
    }


}