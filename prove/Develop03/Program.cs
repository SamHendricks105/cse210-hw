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
        string text = @"And he went up from thence unto Beth-el: and as he was going up by the way, there came forth little
        children out of the city, and mocked him, and said unto him, Go up, thou bald head; go up, thou bald
        head.
        And he turned back, and looked on them, and cursed them in the name of the Lord. And there came
        forth two she bears out of the wood, and tare forty and two children of them.
        And he went from thence to mount Carmel, and from thence he returned to Samaria.";
        

        Reference scriptureReference = new Reference("Proverbs", "3", "5-6");
        Scripture scripture = new Scripture(scriptureReference, text); 
        Memorizer scriptureMem = new Memorizer(scripture);
        
        
        
        while (scriptureMem.hasWordsLeft() == true && i != "quit")
        {
            Console.Clear();
            Console.WriteLine(string.Format("{0} {1}", scriptureReference.toString(),scriptureMem.toString()));
            i =getInput();            
            scriptureMem.removeWordsFromList();
            
        }
    }
}