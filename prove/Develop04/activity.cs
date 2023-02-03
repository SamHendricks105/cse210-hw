using System;
using System.Diagnostics;
using System.Linq;
using System.Threading;
class Activity 
{
    
    protected string activityName, instruction;
    
    protected int howLong;

    protected int Spin =0;

    //constructors 
    
    public Activity()
    {

    }
    public Activity(string _activityName, string _instruction)
    {
        activityName = _activityName;
        instruction =_instruction;
        
    }

    public void getHowLong()
    {
       Console.Write("How long in seconds would you like to do this exersise: ");
       string seconds = Console.ReadLine();
       howLong= int.Parse(seconds);
    }

   

    //methods 

    public void displayWelcome()
    {
        Console.WriteLine($"Welcome to the {activityName} Activity,");
        Console.WriteLine(instruction);
    }

    public void wellDone()
    {
        Console.WriteLine("Well Done!");
        spin(4);
        
        // clears the spiner animation
        Console.SetCursorPosition(Console.CursorLeft, Console.CursorTop - 1);
        Console.WriteLine();
        
        Console.WriteLine($"You have completed another {howLong} seconds of the {activityName} Activity!");
        spin(4);
        
        // clears the spiner animation
        Console.SetCursorPosition(Console.CursorLeft, Console.CursorTop - 1);
        Console.WriteLine();
    }
    
    
    public void spin(int runTimeSeconds)
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
            Thread.Sleep(300);
        
        
        }
    }





}