using System;
using System.Diagnostics;
using System.Linq;
using System.Threading;

class Breath : Activity
{
    
    // constructors................................... 
    public Breath(string _activityName, string _instruction) 
    : base(_activityName, _instruction)
    {
        
    }
    
    
    //Methods......................................
    
    // The breathIn() and breathOut() functions will be used inside of the 
    // breathActovity() to time the user's breathing
    public void breathIn()
    {
       int count =5;
       while (count >=0)
        {
            Console.WriteLine($"Breath in.....{count}");
            Thread.Sleep(1000);
            Console.SetCursorPosition(Console.CursorLeft, Console.CursorTop - 1);
            count--;
        }
        
    }
    public void breathOut()
    {
       int count =5;
       while (count >=0)
        {
            Console.WriteLine($"Breath out.....{count}");
            Thread.Sleep(1000);
            Console.SetCursorPosition(Console.CursorLeft, Console.CursorTop - 1);
            count--;
        }
        
    }
    public void breathActivity()
    {
        
        
        Console.WriteLine("Get Ready....");
        spin(3);
        
       
        // the while loop will loop though breathing in and out
        // the howLong varible obtained from the user in the prorgam 
        // using getHowLong()
        Stopwatch stopwatch = new Stopwatch();
        stopwatch.Start();
        while( stopwatch.ElapsedMilliseconds / 1000 < howLong)
        {
            breathIn();
            Console.WriteLine();
            Console.WriteLine();
            breathOut();
            Console.WriteLine();
            Console.WriteLine();
        }
        wellDone();
        
    }
        
}