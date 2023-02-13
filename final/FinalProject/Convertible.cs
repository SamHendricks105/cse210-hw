class Convertable : Vehicle
{
    //Memeber Varibles 
    string hardOrSoftTop;

    //Constructors
    public Convertable(string _make, string _model, 
    string _year, string _color, string _fuelType,
    string _driveType, int _numDoors, int _numSeats) :
    base(_make, _model, _year, _color, _fuelType, _driveType, _numSeats, _numDoors)
    {

    }


    //Methods 
    public override void  displayVehicleAllSpecs()
    {

    }
}