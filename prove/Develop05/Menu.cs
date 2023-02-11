class Menu
{
     
     //Methods
     public void displayMenu()
        {
            Console.WriteLine("Menu Options:");
            Console.WriteLine("1.Create new Goal");
            Console.WriteLine("2.List Goals");
            Console.WriteLine("3.Save Goals");
            Console.WriteLine("4.Load Goals");
            Console.WriteLine("5.Record Event");
            Console.WriteLine("6.Quit");
        }

        public int  getChoice()
       {
        
        string c;
            Console.Write("Select your Choice: ");
            c =Console.ReadLine();
            
            if (c != "1" && c != "2" && c != "3" && c != "3" && c != "4" && c != "5" && c != "6")
            {
                while (c != "1" && c != "2" && c != "3" && c != "3" && c != "4" && c != "5" && c != "6")
                {
                    Console.WriteLine("Invalid");
                    Console.WriteLine("Choice must be a number from 1-6");
                    Console.Write("Select your Choice: ");
                    c =Console.ReadLine();

                }
            }   
            int choice = int.Parse(c);         
        return choice;
       }

       public int getChoice3()
       {
        string c;
            Console.Write("Select your Choice: ");
            c =Console.ReadLine();
            
            if (c != "1" && c != "2" && c != "3" && c != "3")
            {
                while (c != "1" && c != "2" && c != "3" && c != "3" )
                {
                    Console.WriteLine("Invalid");
                    Console.WriteLine("Choice must be a number from 1-3");
                    Console.Write("Select your Choice: ");
                    c =Console.ReadLine();

                }
            }   
            int choice = int.Parse(c);         
        return choice;

       }


       public int  WhatTypeOfGoal()
    {
        Console.WriteLine("What Iind of Goal do you want to create?:");
        Console.WriteLine("1. Simple Goal");
        Console.WriteLine("2. Eternal Gaol");
        Console.WriteLine("3. Check List Goal");
        int c = getChoice3();
        return c;
    }

    
}