using System;
using System.IO;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        // J stores all entries
        Journal j = new Journal();
        Journal test = new Journal();
        
        
        
         int getChoice()
        {
            Console.Write("What will you do?:");
            string c = Console.ReadLine();
            if (c != "1" && c != "2" && c != "3" && c != "4" && c !="4" && c!= "5")
            {
                while(c != "1" && c != "2" && c != "3" && c != "4" && c !="4" && c!= "5")
                {
                    Console.WriteLine("Invalid choice.(must be a number from 1-5)");
                    Console.Write("What will you do?:");
                    c = Console.ReadLine();
                }
            }
            // Consle.ReadLine can only take strings and we need an int
            int choice = int.Parse(c);
            return choice;
        }
        
        void displayMenu()
        {
            Console.WriteLine("1. Write");
            Console.WriteLine("2. display");
            Console.WriteLine("3. load");
            Console.WriteLine("4. save");
            Console.WriteLine("5. quit");
        }
        //choice needs to be decalred before the main loop is started.
        int choice = 0;
        
        //Main proram loop
        while (choice != 5)
        {
            //stores one entry at a time.
            journalEntry e = new journalEntry();
            
            
            displayMenu();
            choice =getChoice();
            // Write
            
            
            
            
            if (choice == 1)
            {
                // The Date and Time will be added to the string. 
                string date = DateTime.Now.ToString("M/d/yyyy");
                e._date = date;
                // The Prompt for the enetry is decided
                int prom = e.getEntryPrompt();
                string p0 = "If your day was a car what kind of car woud it be?";
                string p1 = "Did you remind anyone about their car's extended warnety to day?";
                string p2 = "What was yummiest thing you ate today?";
                string p3 = "Why are you the way that you are?";
                string p4 = "Did you get any closer to finding the man who killed your father today?";
                 if (prom == 0)
                {
                    e._prompt =p0;
                } 
                else if (prom ==1)
                {
                    e._prompt =p1;
                }
                else if (prom ==2)
                {
                    e._prompt =p2;
                }
                else if (prom ==3)
                {
                    e._prompt =p3;
                } 
                else if (prom ==4)
                {
                    e._prompt =p4;
                }
                Console.WriteLine(e._prompt);
                // The user is prompted for their entry
                Console.Write("Write your entry.: ");
                e._entry = Console.ReadLine();
                j._AllEntries.Add(e);
              

            }
   
            //Display
            else if (choice ==2)
            {
                foreach(journalEntry line in j._AllEntries)
            {
              
                Console.WriteLine(line._date);
                Console.WriteLine(line._prompt);
                Console.WriteLine(line._entry); 
            }
            }
            //Load
            else if(choice ==3)
            {
                

                // Asks the user for the file location
                Console.Write("Enter your file name:");
                string filename = Console.ReadLine();
                //The user's file is sent to a string called lines
                string [] lines = System.IO.File.ReadAllLines(filename);
                // The length of this array is need for the while loop below.
                // Each entry should be 3 lines. lines[0]= the date, lines[1]= the prompt 
                // lines[2]= user's entry and so on every lines[0-2]
                int arrLen = lines.Length;
                Console.WriteLine($"Length:{arrLen}");
                //Clears j so it can be replaced with the load file.
                Journal clear = new Journal();
                j = clear;
                
                //The loop will load the new list in to the journal class varible test.
                int count =0;
                while (count < arrLen -1)
                {
                    journalEntry load = new journalEntry();
                    load._date = lines[count];
                    load._prompt =lines[count+1];
                    load._entry =lines[count+2];
                    test._AllEntries.Add(load);
                    count +=3;
                    Console.WriteLine($"Count:{count}");
                        
                }
                j._AllEntries = test._AllEntries;
                
                
                
                
                
            
            }
            //Save
            else if (choice == 4)
            {
                
                Console.Write("Please enter filename:");
                string filelocation = Console.ReadLine();
                using (StreamWriter writer = new StreamWriter(filelocation))
                {
                    foreach(journalEntry line in j._AllEntries)
                    {
                    
                        writer.WriteLine($"Date: {line._date}");
                        writer.WriteLine($"Prompt:{line._prompt}");
                        writer.WriteLine($"Entery:{line._entry}"); 
                    }
                }
                
                



            }
            //Quit 
            
        }
    }
}


