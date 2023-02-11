class Menu
{
   
    
    public void displayMenu()
    {
        Console.WriteLine("1. Add A Vehicle");
        Console.WriteLine("2. Search inventory");
    }
    
    
    public void displaySearchMenu()
    {
        Console.WriteLine("What would you like to searh by?");
        Console.WriteLine(" Make        Model");
        Console.WriteLine(" Year        Color");
        Console.WriteLine(" Body Style  ");
       
    }
    public string getUserInput()
    {
        Console.Write(": ");
        string input = Console.ReadLine();
        return input;
    }


}