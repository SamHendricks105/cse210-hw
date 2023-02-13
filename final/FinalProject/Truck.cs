class Truck :Vehicle
{
    //Memeber Varibles 
    int towCapacity, bedLenght;

    //Constructors
    public Truck(string _make, string _model, 
    string _year, string _color, string _fuelType,
    string _driveType, int _numDoors, int _numSeats, int _towCapacity, int _bedLenght) :
    base(_make, _model, _year, _color, _fuelType, _driveType, _numSeats, _numDoors)
    {
        bedLenght = _bedLenght;
        towCapacity = _towCapacity;
    }


    //Methods 
    public override void  displayVehicleAllSpecs()
    {

    }
}