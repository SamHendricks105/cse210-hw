abstract class Goal
{
    // Member Varibles 
    protected int points;
    public int goalNumber;
    protected string name, discription, symbolComplete;

    public List <SimpleGoal> simpleGoalsList;

    protected bool completed = false;
    
    // constructors 
    public Goal ()
    {

    }
    // Methods 
    public void setPoints(int _points)
    {
        points = _points;
    }

    public int givepoints()
    {
        return points;
    } 

    public void getName(string  _name)
    {
        name = _name;
    }

    public string giveName()
    {
        return name; 
    }

     public void getDiscription(string  _discription)
    {
        discription = _discription;        
    }

    public string giveDiscription()
    {
        return discription;
    }
    public void setCompletedToFalse()
    {
        completed = false;
    }
    public void setCompletedToTrue()
    {
        completed = true;
    }

    public abstract string dispalyGoal();
    public abstract void getGoal();    
    public abstract void isComplete();
    public abstract int recordEvent();







}