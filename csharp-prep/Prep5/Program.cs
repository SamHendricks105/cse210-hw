using System;

class Program
{
    
    static void Main(string[] args)
    {
        display();
        string name =PromptUserName();
        int num = PromptUserNumber();
        int sq = SquareNumber(num);
        DisplayResult(sq, name);

        


    }
    static void display()
    {
        Console.WriteLine("Welcome!");
    }
    static string PromptUserName()
    {
        Console.Write("What is Your Name:");
        string name = Console.ReadLine();
        return name;
    }
    static int PromptUserNumber ()
    {
        Console.Write("what is Your favorite integer number: ");
        string num =Console.ReadLine();
        int Num = int.Parse(num);
        return Num;
    }

    static int SquareNumber(int Num)
    {
        int sq = Num *Num;
        
        return sq;
    }
    static void DisplayResult(double sq, string name)
    {
        Console.WriteLine($"{name}, the square of your number is {sq}");
    }
}