class Menu
{
   
    
    public void displayMenu()
    {
        Console.WriteLine("1.See Full Inventory");
        Console.WriteLine("2.Filter Search");
        Console.WriteLine("3.Quit");
    }
    
     public void displaySearchMenu()
    {
        Console.WriteLine("What would you like to searh by?");
        Console.WriteLine("1.Body Style\n2.Price");
       
    }

    public void displayBodyStyles()
    {
        Console.WriteLine("Which of the following Body types would you like to include in your Search?");
        Console.WriteLine ("1.Sedan\n2.Coupe\n3.Convertable\n4.Van\n5.MiniVan\n6.Truck\n7.SUV");
    }
    
    
    public int getUserInputInt(int amountOfChoices)
    {
        //Passes in amountOfChoices becasue I might acount for wrong user input in the future.
        Console.Write("Enter Choice: ");
        int c = int.Parse(Console.ReadLine());
        return c;
       
    }


}