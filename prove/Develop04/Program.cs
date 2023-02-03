using System;
using System.Diagnostics;
using System.Linq;

class Program
{
    static void Main(string[] args)
    {
       // funtions 
       
       void menu()
       {
            Console.WriteLine("Menu Otions:");
            Console.WriteLine("1. Start Breathing activity");
            Console.WriteLine("2. Start Reflection activuty");
            Console.WriteLine("3. Start listing activity");
            Console.WriteLine("4. Quit");
       }
       
       int  getChoice()
       {
        
        string c;
            Console.WriteLine("Select your Choice: ");
            c =Console.ReadLine();
            
            if (c != "1" && c != "2" && c != "3" && c != "3" && c != "4")
            {
                while (c != "1" && c != "2" && c != "3" && c != "3" && c != "4")
                {
                    Console.WriteLine("Invalid");
                    Console.WriteLine("Choice must be a number from 1-4");
                    Console.Write("Select your Choice: ");
                    c =Console.ReadLine();

                }
            }   
            int choice = int.Parse(c);         
        return choice;
       }
       
       int c =0;
        // instructions................ 
        
        //breathing activity
        string breathInstruction = @"This activity will help you relax by walking you through breathing in 
        and out slowly. Clear your mind and focus on your breathing"; 
       
       
       
       while (c !=4)
       {
            menu();
            c=getChoice();
            
            //breathing activity
            if (c ==1)
            {
                breath b = new breath("Breathing", breathInstruction, 2);
                b.getHowLong();
                b.displaySeconds();
                
            }
       }




    }
}