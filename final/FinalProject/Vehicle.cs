abstract class Vehicle
{
    // Member Varibles 
    protected string make, model, year, color, fuelType, driveType;
    protected int numSeats, numDoors;

    // Consturctors

    public Vehicle(string _make, string _model, string _year, string _color, string _fuelType,string _driveType, int _numDoors, int _numSeats)
    {
        make = _make; 
        model = _model; 
        year =_year; 
        color = _color; 
        fuelType= _fuelType;
        driveType = _driveType;
        numSeats =_numSeats;
        numDoors = _numDoors;
    } 

    //Methods 

    public void displayVehicleQuickView()
    {
        string info = $"Year: {year}\n"+
        $"Make: {make}\n"+
        $"Model: {model}";
        Console.WriteLine(info);
    }
    public abstract void displayVehicleAllSpecs();
    



}