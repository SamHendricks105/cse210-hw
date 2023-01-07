using System;

// This program will tell you your grade if given a grade percentage. 
class Program
{
    static void Main(string[] args)
    {
        //The first step is to get the Grade perecntage
        //The percentage will be stored as a string not a number.  
        Console.Write("Please enter your grade percentage: ");
        string percent = Console.ReadLine();
        //The next step is to convert the string in to an int. 
        int num = int.Parse(percent);
        // Now it's time to write the if statments 
        if (num >= 70)
        {
            Console.WriteLine("Congratulations you passed!");
        }
        else
        {
            Console.WriteLine("Not good enough you failed....  :(");
        }
        Console.Write("Your grade is ");
        //A
        if (num >= 90)
        {
            Console.Write("A");
        }
        //B
        else if(num >= 80)
        {
            Console.Write("B");
        }
        //C
        else if(num >= 70)
        {
            Console.Write("C");
        }
        //D
        else if(num >=60)
        {
            Console.Write("D");
        }
        //F
        else
        {
            Console.Write("F");
        }
    
    
    
    }
}