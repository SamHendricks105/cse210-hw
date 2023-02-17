class Inventory 
{
    //Member Varibles 
    private List <Vehicle> inventoryList;

    //Constructors 
    public Inventory(List <Vehicle> _inventoryList)
    {
            inventoryList =_inventoryList;
    }

    //Methods
    public void displayAllVehiicles()
    {
        foreach(Vehicle car in inventoryList)
        {
            car.displayVehicleAllSpecs();
            Console.WriteLine();
        }
    }
   
   //Used for displaying only the Body Styles that the user is interested in.
   public void displaySpecificBodyType(int ClassNum)
   {
        foreach(Vehicle car in inventoryList)
        {
           if(ClassNum == car.getClassNum())
           {
                car.displayVehicleAllSpecs();
                Console.WriteLine();//Space in between Vehicles 
           }
        }
   }

   public void priceRange()
   {
        Console.Write("Minimum price: ");
        int minPrice = int.Parse (Console.ReadLine());
        Console.Write("Maximum price:");
        int maxPrice = int.Parse(Console.ReadLine());
        foreach(Vehicle car in inventoryList)
        {
            if(car.getPrice() < maxPrice  && car.getPrice() > minPrice)
            {
                car.displayVehicleAllSpecs();
                 Console.WriteLine();//Space in between Vehicles
                
            }
        }


   }

    public void searhBy()
    {
        int choice; 
        Menu m =new Menu();
        m.displaySearchMenu();
        choice = m.getUserInputInt(5);
        switch(choice)
        {
            //Body Style
            case 1:
            m.displayBodyStyles();
            choice = m.getUserInputInt(7);
            Console.WriteLine();//Add's blank line to make it prettier 
            displaySpecificBodyType(choice);
            break;
            
            //price
            case 2:
            Console.WriteLine();
            priceRange();
            break;

            
        }
       

    }



}