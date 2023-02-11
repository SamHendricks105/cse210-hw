class CheckListGoal : Goal
{
    //member varibles
     protected int timesToDo, timesDone, BonusPoints;

    // constuctors 


    // methods 
    
    public override void getGoal()
    {
        Console.Write("What is the name of your goal: ");
        name = Console.ReadLine();
       
        Console.Write("What is a short discription of this goal?: ");
        discription = Console.ReadLine();
        
        Console.Write("How any points is this goal worth: ");
        points = int.Parse(Console.ReadLine());
        
        Console.Write("How many times do you want to do this?: ");
        timesToDo= int.Parse(Console.ReadLine());

        Console.Write($"How many bounus points do you deserve if you complete your goal {timesToDo} times?: ");
        BonusPoints= int.Parse(Console.ReadLine());
       

    }

    public override void isComplete()
    {
       if(completed == true)
       {
            symbolComplete = "X";
       }
    }

    public override int recordEvent()
    {
        
        Console.WriteLine(completed);
        
        if (completed == false)
        {
            timesDone++;
        }
        if (completed == false && timesDone == timesToDo)
        {    
            Console.WriteLine($"Good Job you completed this Goal {timesDone} times!");
            completed = true;
            return points + BonusPoints;
        }
        else if(completed ==false && timesDone != timesToDo)
        {
            Console.WriteLine($"Good Job here is {points} points");
            return points;
        }
        
        else if(completed == true)
        {
            Console.WriteLine("Looks Like You have already Completed this goal! Good Job!");
            return 0;
        }
        else
        {
            Console.WriteLine("What the Heck?");
            return 0;
        }
    }

    public override string dispalyGoal()
    {
       Console.WriteLine($"{goalNumber}. [{symbolComplete}] {name} ({discription}) ---Curently completed {timesDone}/{timesToDo}");
        return $"{goalNumber}|{symbolComplete}|{name}|{discription}|{timesDone}|{timesToDo}";
    }


}