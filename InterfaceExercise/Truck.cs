namespace InterfaceExercise;

public class Truck : IVehicle, ICompany
{
    public bool IsLifted { get; set; }
    public int TruckBedSize { get; set; }
    public int NumberOfWheels { get; set; }
    public int NumberOfDoors { get; set; }
    public int Year { get; set; }
    public string Color { get; set; }
    public string Make { get; set; }
    public string Model { get; set; }
}