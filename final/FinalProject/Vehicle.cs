abstract class Vehicle
{
    // Member Varibles 
    protected string make, model, year, color, fuelType, driveType, numSeats, numDoors, transmision;
    protected int price, ClassNumber;

    // Consturctors

    public Vehicle(string _make, string _model, string _year, string _color, 
    string _fuelType,string _driveType, string _numDoors, string _numSeats,string _transmision, int _price)
    {
        make = _make; 
        model = _model; 
        year =_year; 
        color = _color; 
        fuelType= _fuelType;
        driveType = _driveType;
        numSeats =_numSeats;
        numDoors = _numDoors;
        transmision = _transmision;
        price =_price;
    
    } 
    //Getters and setters
    public void setClassNumber(int _classNumber)
    {
        ClassNumber = _classNumber;
    }
    public int getClassNum()
    {
        return ClassNumber;
    }
    public int getPrice()
    {
        return price;
    }

    //Methods 
    public void displayVehicleQuickView()
    {
        string info = $"Year: {year}\n"+
        $"Make: {make}\n"+
        $"Model: {model}";
        Console.WriteLine(info);
        Console.WriteLine($"Price:${price}");
    }
    public abstract void displayVehicleAllSpecs();
    



}