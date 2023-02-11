class SimpleGoal : Goal
{

    // Member Varibles
    
    //constoctors

    // Methods 
    
    public override void getGoal()
    {
        Console.Write("What is the name of your goal: ");
        name = Console.ReadLine();
       
        Console.Write("What is a short discription of this goal?: ");
        discription = Console.ReadLine();
        
        Console.Write("How any points is this goal worth: ");
        points = int.Parse(Console.ReadLine());
        
    }
    
    
    public override int recordEvent()
    {
        if (completed != true)
        {
            completed = true;
            return points;
        }
        else
        {
            Console.WriteLine("Looks Like You have already Completed this goal! Good Job!");
            return 0;
        }
    }
    
    public override void isComplete()
    {
        // The Status tell's us if the goal has been completed or not.
        // The X will indicate competion to the user when they want to
        // display goals. 
        if (completed ==true)
        {
            symbolComplete ="X";
            
        }
    }

    public override string dispalyGoal()
    {
        Console.WriteLine($"{goalNumber}. [{symbolComplete}] {name} ({discription})");
        return($"{goalNumber}|{symbolComplete}|{name}|{discription}");
    }




}