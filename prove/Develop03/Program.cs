using System;

class Program
{
    static void Main(string[] args)
    {
        journal j = new journal();
        
        
        int choice =6;
        while(choice !=5)
        {
        Console.WriteLine("1. Write");
        Console.WriteLine("2. display");
        Console.WriteLine("3. load");
        Console.WriteLine("4. save");
        Console.WriteLine("5. quit");
        Console.Write("enter choice: ");
        
        string c = Console.ReadLine();
        choice = int.Parse(c);
            // The Date and Time will be added to the string. 
                string date = DateTime.Now.ToString("M/d/yyyy");
                e._date = date;
            
            
            if (choice ==1)
            {
                
            }
            else if (choice ==2)
            {

            }
        
        
        }   
    }
}