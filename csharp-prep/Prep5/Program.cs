using System;

class Program
{
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

    static double SquareNumber(int Num)
    {
        double dNum = Num;
        double Square = Math.Sqrt(dNum);
        
        
        return Square;
    }
    static void DisplayResult(double sq, string name)
    {
        Console.WriteLine($"{name}, the square of your number is {sq}");
    }
    
    static void Main(string[] args)
    {
        
        display();
        
    }