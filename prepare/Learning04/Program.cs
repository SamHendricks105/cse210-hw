using System;

class Program
{
    static void Main(string[] args)
    {
        //Assignment 
        Assignment a1 = new Assignment("Bill", "Geology");
        Console.WriteLine(a1.getSumary());
        
        Console.WriteLine();
        //MathAssignment
        MathAssignment m1 = new MathAssignment("Bob", "Math", "8.7","1-18");
        Console.WriteLine(m1.getSumary());
        Console.WriteLine(m1.getHomeworkList());
        
        Console.WriteLine();

        //Writing Assignment
        WritingAssignment w1 = new WritingAssignment("Jane", "Writing", "W1 essay");
        Console.WriteLine(w1.getSumary());
        Console.WriteLine(w1.getWritingInfo());
    }
}