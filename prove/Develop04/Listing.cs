using System;
using System.Diagnostics;
using System.Linq;
using System.Threading;

class Listing : Activity
{
    //member Varibles....................................
    protected string listingPrompt;
    


    // consturcutors..................................... 
    public Listing(string _activityName, string _instruction) 
    : base(_activityName, _instruction)
    {
        
    }

    //Methods...................................

    public void getListingPropmt()
    {
        //prompts....
        string p1 = "When have you enjoyed a meal this week?";
        string p2 = "List as may decimal places of pie as possible.";
        string p3 = "When have you seen a wood chuck chuck wood this week?";
        //.........
        List <string> propmts = new List<string>();
        propmts.Add(p1);
        propmts.Add(p2);
        propmts.Add(p3);
        
        // A randrom number fro 0-3 will be gerrated to determine the prompt
        Random ran = new Random();
        int decider = ran.Next(3);
        
        
        switch(decider)
        {
            case 0:
            listingPrompt = p1;
            break;

            case 1:
            listingPrompt = p2;
            break;

            case 2:
            listingPrompt =p3;
            break;
        }
        Console.Write($"{listingPrompt}");
            
}

public void listingActivity()
{
    Console.WriteLine("Get Ready....");
        spin(3);
        
        Console.WriteLine("Considr the following prompt");
        Console.Write("---");
        getListingPropmt();
        Console.Write("---");
        Console.WriteLine();
        int count =5;
       while (count >=0)
        {
            Console.WriteLine($"You many begn in: {count}");
            Thread.Sleep(1000);
            Console.SetCursorPosition(Console.CursorLeft, Console.CursorTop - 1);
            count--;
        }
        string listing ="";
        int responses =0;
        Console.WriteLine();
        Stopwatch stopwatch = new Stopwatch();
        stopwatch.Start();
        
        while( stopwatch.ElapsedMilliseconds / 1000 < howLong)
        {
           Console.Write(">");
           listing =Console.ReadLine();
           responses++;
        }
        Console.WriteLine($"You listed {responses} items!");
        wellDone();
}


}