using System;
using System.Diagnostics;
using System.Linq;

class activity 
{
    
    protected string activityName, instruction;
    
    protected int howLong;

    protected int Spin =0;

    //constructors 
    
    public activity()
    {

    }
    public activity(string _activityName, string _instruction, int _howLong)
    {
        activityName = _activityName;
        instruction =_instruction;
        howLong = _howLong;
    }

   

    //methods 

    public void displayWelcome()
    {
        Console.WriteLine($"Welcome to the {activityName} Activity,");
        Console.WriteLine(instruction);
        Console.Write("How long, in seconds, would you like for your session?: ");
    }

    public void getReady(int runTimeSeconds)
    {
        Stopwatch stopwatch = new Stopwatch();
        stopwatch.Start();
        
        while( stopwatch.ElapsedMilliseconds / 1000 < runTimeSeconds)
        {
            Spin++;
            switch(Spin % 4)
            {
                case 0: Console.Write("/"); break;
                case 1: Console.Write("-"); break;
                case 2: Console.Write("\\"); break;
                case 3: Console.Write("|"); break; 
            }
            Console.SetCursorPosition(Console.CursorLeft -1, Console.CursorTop);
            Thread.Sleep(200);
        
        
        }
    }





}