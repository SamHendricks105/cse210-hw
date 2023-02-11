class EternalGoal : Goal
{
    // Member Varibles
   


    //consturctors



    //Methods 

    public override void getGoal()
    {
        Console.Write("What is the name of your goal: ");
        name = Console.ReadLine();
       
        Console.Write("What is a short discription of this goal?: ");
        discription = Console.ReadLine();
        
        Console.Write("How any points is this goal worth: ");
        points = int.Parse(Console.ReadLine());
    }
    
    
    public override void isComplete()
    {
       
    }

    public override int recordEvent()
    {
       Console.WriteLine($"Way to go you earned {points} points!");
       return points;
    }

    public override string dispalyGoal()
    {
        Console.WriteLine($"{goalNumber}. [:)] {name} ({discription})");
        return $"{goalNumber}|{name}|{discription}";
    }



}