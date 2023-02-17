using System;

class Program
{
    static void Main(string[] args)
    {
        //Class#,make,model,year,color,fuelType,driveType,numSeats,numDoors,price;
        List <Vehicle> MainList = new List<Vehicle>();
        
        string [] lines = System.IO.File.ReadAllLines("InventoryList.txt");
        
            foreach(string line in lines)
                {
                   string [] num = line.Split(",");
                   
                   int ClassNum = int.Parse(num[0]);
                    int price = int.Parse(num[10]);
                   string ClassSpecificTraightOne;
                   string ClassSpecificTraightTwo;
                   
                   
                   switch(ClassNum)
                  {
                    case 1:
                    Sedan newSedan = new Sedan(num[1],num[2],num[3],num[4],num[5],num[6],num[7],num[8],num[9],price);
                    newSedan.setClassNumber(1);
                    MainList.Add(newSedan);
                    break;

                    case 2:
                    Coupe newCoupe= new Coupe(num[1],num[2],num[3],num[4],num[5],num[6],num[7],num[8],num[9],price);
                    newCoupe.setClassNumber(2);
                    MainList.Add(newCoupe);
                    break;

                    case 3:
                    ClassSpecificTraightOne = num[11];
                    Convertable newConvertable = new Convertable(num[1],num[2],num[3],num[4],num[5],num[6],num[7],num[8],num[9],price,ClassSpecificTraightOne);
                    newConvertable.setClassNumber(3);
                    MainList.Add(newConvertable);
                    break;

                    case 4:
                    ClassSpecificTraightOne = num[11];
                    Van newVan = new Van(num[1],num[2],num[3],num[4],num[5],num[6],num[7],num[8],num[9],price,ClassSpecificTraightOne);
                    newVan.setClassNumber(4);
                    MainList.Add(newVan);
                    break;

                    case 5:
                    MiniVan newMiniVan = new MiniVan(num[1],num[2],num[3],num[4],num[5],num[6],num[7],num[8],num[9],price);
                    newMiniVan.setClassNumber(5);
                    MainList.Add(newMiniVan);
                    break;

                    case 6:
                    ClassSpecificTraightOne = num[11];
                    ClassSpecificTraightTwo = num[12];
                    Truck newTruck = new Truck(num[1],num[2],num[3],num[4],num[5],num[6],num[7],num[8],num[9],
                    ClassSpecificTraightOne,ClassSpecificTraightTwo,price);
                    newTruck.setClassNumber(6);
                    MainList.Add(newTruck);
                    break;

                    case 7:
                    SUV newSUV = new SUV(num[1],num[2],num[3],num[4],num[5],num[6],num[7],num[8],num[9],price);
                    MainList.Add(newSUV);
                    newSUV.setClassNumber(7);
                    break;
                    
                  
                  }
                 
                }
                Inventory i = new Inventory(MainList);
                Menu m = new Menu();
                //Becacuse c is the vaible that continues or end the loop it will only be used when displaying the main menu
                int mainMenuChoice=0;
                //AllOtherChoices will be used for anything else.
                int AllOtherChoices=0;
                while(mainMenuChoice!=3)
                {
                    m.displayMenu();
                    mainMenuChoice= m.getUserInputInt(3);
                    switch(mainMenuChoice)
                    {
                        case 1:
                        i.displayAllVehiicles();
                        break;
                        case 2:
                        i.searhBy();
                        break;
                    }


                }
                

                

    
    
    }           
    
}
    
    
    
   


