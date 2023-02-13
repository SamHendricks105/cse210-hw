
class Inventory
{
     
    List <Vehicle> MainList;
    
    public void readInInventory()
    {
        //Will Reed the InventoryList.txt file with a list vehicles
        // and send them to the MainList
    }
    
    
    
    public void addToInventory()
    {
        Console.WriteLine("What is the body style of the vehicle?");
        int c = int.Parse(Console.ReadLine());

        switch(c)
        {
            //Sedan
            case 1:
            break;

            //Coupe
            case 2:
            break;

            //Converible
            case 3:
            break;

            //Van
            case 4:
            break;
            
            //MiniVan
            case 5:
            break;

            //Truck
            case 6:
            break;

            //SUV
            case 7:
            break;

        }

    }



}
   
