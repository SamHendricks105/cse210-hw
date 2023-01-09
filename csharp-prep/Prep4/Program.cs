using System;
using System.Collections.Generic;
class Program
{
    static void Main(string[] args)
    {
        List<int> numbers= new List<int>();
        Console.WriteLine("Enter a list of numbers, type 0 when finished.");
        int num =5;
        while (num !=0)
        {
        Console.Write("Enter a number:");
        string sNum = Console.ReadLine();
        num = int.Parse(sNum);
        numbers.Add(num);
        }
        int sum =0;
        int great=0;
        foreach (int n in numbers)
        {
            sum += n;
            if (great < n)
            {
                great =n;
            }
            
        }
        Console.WriteLine($"The sum total is:{sum}");
        Console.WriteLine($"The Average is:{sum/numbers.Count}");
        Console.WriteLine($"The largest number is:{great}");
    }
}