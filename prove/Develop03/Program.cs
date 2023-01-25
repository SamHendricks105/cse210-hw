using System;

class Program
{
    static void Main(string[] args)
    {
        string i ="";
       string getInput()
        {
            string input;
           
            input = Console.ReadLine();
            while (input != "" & input !="quit" & input !="Quit")
            {
                Console.WriteLine("Invalid Choice Valid options are quit or pressing enter");
                input = Console.ReadLine();
            }
            
            return input;
        }
        
        //i = getInput();
        string text = "5  Trust in the Lord with all thine heart;";

        Reference scriptureReference = new Reference("Proverbs", "3", "5-6");
        Scripture scripture = new Scripture(scriptureReference, text); 
        Memorizer scriptureMem = new Memorizer(scripture);
        
        
        
        while (scriptureMem.hasWordsLeft()== true && i != "quit")
        {
            Console.Clear();
            Console.WriteLine(string.Format("{0} {1}", scriptureReference.toString(),scriptureMem.toString()));
            i =getInput();            
            scriptureMem.removeWordsFromList();
        }
    }
}