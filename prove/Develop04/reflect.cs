using System;
using System.Diagnostics;
using System.Linq;
using System.Threading;

class Reflect : Activity
{
    // Member varibles 
    protected string activittyPrompt; 
    
    //Constuctors..............................
    public Reflect(string _activityName, string _instruction) 
    : base(_activityName, _instruction)
    {
        
    }


    // Methods.....................................

    // This method will choose a prompt at random for the activity. 
    public void getPropmt()
    {
        //prompts....
        string p1 = "Think of a time when you had to do somting really dificult.";
        string p2 = "Think about the last time you went to vist your in laws....";
        string p3 = "Think about the a time where you had to eat something gross... like peas.";
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
            activittyPrompt = p1;
            break;

            case 1:
            activittyPrompt = p2;
            break;

            case 2:
            activittyPrompt =p3;
            break;
        }
        Console.Write($"{activittyPrompt}");
            
}

// This method will run the activity

public void reflectActivity()
{
    Console.WriteLine("Get Ready....");
        spin(3);
        
        Console.WriteLine("Considr the following prompt");
        Console.Write("---");
        getPropmt();
        Console.Write("---");
        Console.WriteLine();
        Console.WriteLine("When you have something in mind press Enter to continue.");
        Console.ReadLine();
        
        Stopwatch stopwatch = new Stopwatch();
        stopwatch.Start();
        
        while( stopwatch.ElapsedMilliseconds / 1000 < howLong)
        {
            // Prompt 1
            if(activittyPrompt =="Think of a time when you had to do somting really dificult. ")
            {
                Console.Write("> Was it really that hard or, are you just weak? ");
                spin(6);
                
                Console.WriteLine();
                Console.Write("> I'm Pretty sure your're jsut weak. ");
                spin(6);
            
                Console.WriteLine();
                Console.Write("> Im Pretty sure my Grandma could bench more than you. ");
                spin(6);
               
                Console.WriteLine();
                
            }
            
            // Prompt 2
            else if(activittyPrompt =="Think about the last time you went to vist your in laws....")
            {
                Console.Write("> Good job putting up with your stupid brother in law Jim");
                spin(6);
                
                Console.WriteLine();
                Console.Write("> And don't even get me started about Barbra");
                spin(6);
            
                Console.WriteLine();
                Console.Write("> Honestly if my in Laws were as bad as your's I'd probly never visit them");
                spin(6);

                Console.WriteLine();
                Console.Write("> I don't know how you do it but you better get brownie points with the you spouse for doing it");
                spin(6);
               
                Console.WriteLine();
                
            }
            
            //Prompt 3
            else if(activittyPrompt =="Think about the a time where you had to eat something gross... like peas.")
            {
                Console.Write("> Did You throw up?");
                spin(6);
                
                Console.WriteLine();
                Console.Write("> I probably would have");
                spin(6);
            
                Console.WriteLine();
                Console.Write("> Im sorry if you like pea's. That okay if you do.");
                spin(6);

                Console.WriteLine();
                Console.Write("> Who am I kidding? I'm not sorry. Peas's are gross. No one should like peas.");
                spin(6);
               
                Console.WriteLine();
                
            }
        }
        wellDone();
}





}