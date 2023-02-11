using System;

class Program
{
    static void Main(string[] args)
    {
        List<Vehicle> Inventory =new List<Vehicle>();
        Menu m = new Menu();
        string input ="";
        while(input != "exit")
        {
            m.displayMenu();
            input = m.getUserInput();
        }
    }
}