class Convertable : Vehicle
{
    //Memeber Varibles 
    string hardOrSoftTop;

    //Constructors
    public Convertable(string _make, string _model, 
    string _year, string _color, string _fuelType,
    string _driveType, string _numDoors, string _numSeats,string _transmision,int _price, string _hardOrSoftTop) :
    base(_make, _model, _year, _color, _fuelType, _driveType, _numSeats, _numDoors,_transmision, _price)
    {
        hardOrSoftTop = _hardOrSoftTop;
    }


    //Methods 
    public override void  displayVehicleAllSpecs()
    {
        displayVehicleQuickView();
        
        Console.WriteLine($"Color:{color}\nFuelType:{fuelType}");
        Console.WriteLine($"DriveType:{driveType}\nDoors:{numDoors}");
        Console.WriteLine($"Seats:{numSeats}\nTop:{hardOrSoftTop}");
    }
}