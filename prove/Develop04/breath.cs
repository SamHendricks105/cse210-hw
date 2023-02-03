using System;
class breath : activity
{
    
    
    
    public breath(string _activityName, string _instruction, int _howLong) 
    : base(_activityName, _instruction, _howLong)
    {
        
    }
    public void getHowLong()
    {
       Console.Write("How long in seconds would you like to do this exersise: ");
       string seconds = Console.ReadLine();
       howLong= int.Parse(seconds);
    }

    public void displaySeconds()
    {
        Console.WriteLine($"You have entered {howLong}");
    }
    public void breathActivity()
    {
        
        
    }



}