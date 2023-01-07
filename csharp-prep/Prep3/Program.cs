using System;

class Program
{
    static void Main(string[] args)
    {
        //Asks user for a magic number for the game
        Console.Write("What is the Magic Number?: ");
        string magic = Console.ReadLine();
        //Now ask for the guess
        Console.Write("What is your guess?: ");
        string guess = Console.ReadLine();
        // the win varible will keep track of wether the game is won or not.
        bool win = false;
        
        while (win == false)
        {
            if (guess == magic)
            {
                win =true;
            }
            else
            {
                Console.WriteLine("Nope not it.");
                Console.WriteLine("");
                Console.Write("What is your guess?: ");
                guess = Console.ReadLine();
            }
        }
        Console.WriteLine("");
        Console.WriteLine("Wow you just guessed your own number.");
        Console.WriteLine("I am so proud of you.");
    }
}