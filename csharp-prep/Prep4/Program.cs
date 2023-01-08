using System;

class Program
{
    static void Main(string[] args)
    {
        List<int> numbers;
        Console.WriteLine("Enter a list of numbers, type 0 when finished.");
        int num =5;
        while (num !=0)
        {
        Console.Write("Enter a number:");
        string sNum = Console.ReadLine();
        num = int.Parse(sNum);
        }

    }
}