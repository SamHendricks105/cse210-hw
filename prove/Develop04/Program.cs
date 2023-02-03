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
            Console.Write("Select your Choice: ");
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
        
        //Breathing Activity
        string breathInstruction = 
        "This activity will help you relax by walking you through breathing in and out slowly."+ 
        "Clear your mind and focus on your breathing"; 
       
       //Reflect Activity
       string reflectInstrction = 
       "This activty will help you reflect on time in your life"+ 
       "when you have shown strength and resilince.";

       //Listing Activity 
       string listingInstruction = " This Activity will help you reflect on the good things in your life by"+
       "having you list as may things as you can";

      
       while (c !=4)
       {
           
            menu();
            c=getChoice();
            //breathing activity
            if (c ==1)
            {
                Breath b = new Breath("Breathing", breathInstruction);
                b.displayWelcome();
                b.getHowLong();
                b.breathActivity();
                
            }

            else if(c==2)
            {
                Reflect r = new Reflect("Reflection", reflectInstrction);
                r.displayWelcome();
                r.getHowLong();
                r.reflectActivity();

            }

            else if(c==3)
            {
                Listing l = new Listing("Listing", listingInstruction);
                l.displayWelcome();
                l.getHowLong();
                l.listingActivity();
                
            } 
       }




    }
}