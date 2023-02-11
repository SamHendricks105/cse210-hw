using System;

class Program
{
    static void Main(string[] args)
    {
        
       Menu m = new Menu();
       // The listOfSimpleGoals will be used to store all of the individual
       // simple goals that the user makes 
        SimpleGoal simpleGoalTotalPoints = new SimpleGoal();
        EternalGoal eternalGoalTotalpoints = new EternalGoal();
        int c=0;
        List <Goal> GoalList = new List<Goal>();
        int totalPoints =0;
        int goalNum=0;
        while(c !=6)
        {
           
            
            Console.WriteLine($"Total points: {totalPoints}");
            m.displayMenu();
            c = m.getChoice();
            //sg will store an indavidul simple goal. It will be reInitalized each time trough
            // the loop so to store the indavidual goal ot will need to be addded to the listofsimplegoalsthe 
            SimpleGoal individulSimpleGoal = new SimpleGoal();
            EternalGoal individualEternalGoal = new EternalGoal();
            CheckListGoal individualCheckListGoal= new CheckListGoal();
            
           
            //1.Create new Goal...............................................................................
            if(c==1)
            {
                c = m.WhatTypeOfGoal();
                switch(c)
                {
                    //Simple Goal
                    case 1:
                        individulSimpleGoal.getGoal();
                        goalNum++;
                        individulSimpleGoal.goalNumber =goalNum;
                        //Adds the individual gaol to the list. 
                        GoalList.Add(individulSimpleGoal);
                    break;

                    //Eternal Goal
                    case 2:
                        individualEternalGoal.getGoal();
                        goalNum++;
                        individualEternalGoal.goalNumber=goalNum; 
                        
                        //Goalis addded to gaol list.
                        GoalList.Add(individualEternalGoal);
                    break;

                    //Checklist Goal
                    case 3:
                        individualCheckListGoal.getGoal();
                        goalNum++;
                        individualCheckListGoal.goalNumber= goalNum;
                        //Goal is added to the list. 
                        GoalList.Add(individualCheckListGoal);
                    break;
                }
                
                
            }
            //2.List Goals....................................................................
            else if(c==2)
            {
                foreach(Goal goal in GoalList)
                {
                    goal.dispalyGoal();
                }
            }
            
            //3.Save Goals..................................................................
            else if(c==3)
            {
                Console.Write("Please enter filename:");
                string filelocation = Console.ReadLine();
                using (StreamWriter writer = new StreamWriter(filelocation))
                {
                    foreach(Goal goal in GoalList)
                    {
                        string d = goal.dispalyGoal();
                        Console.WriteLine(d);
                        writer.WriteLine(goal.dispalyGoal());
                        
                    }
                }
            
            }
            
            //4.Load Goals................................................................
            else if(c==4)
            {
                // Asks the user for the file location
                Console.Write("Enter your file name:");
                string filename = Console.ReadLine();
                //The user's file is sent to a string called lines
                string [] lines = System.IO.File.ReadAllLines(filename);
                string [] splitLines;
                
               
                    foreach(string line in lines)
                    {
                        splitLines = line.Split("|");
                    }                

                    foreach(string line in splitLines)
                    {
                    Console.WriteLine(line.Length);
                    }
                
               

                foreach(string line in )
                {
                    Console.WriteLine(line.Length);
                }
                
            }

            //5.Record Event.............................................................
            else if(c==5)
            {
                 foreach(Goal goal in GoalList)
                {
                    goal.dispalyGoal();
                }
                Console.WriteLine("Which Goal have you done?: ");
                int goalDid = int.Parse(Console.ReadLine());
                foreach(Goal goal in GoalList)
                {
                    if (goalDid == goal.goalNumber)
                    {
                        totalPoints += goal.recordEvent();
                        goal.isComplete();
                    }
                }
                

            
            }
        }



    }
}