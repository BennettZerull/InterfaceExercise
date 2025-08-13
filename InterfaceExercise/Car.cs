namespace InterfaceExercise;

public class Car : IVehicle, ICompany
{
    public bool HasTrunk { get; set; }
    public int TrunkSize { get; set; }
    public int NumberOfWheels { get; set; }
    public int NumberOfDoors { get; set; }
    public int Year { get; set; }
    public string Color { get; set; }
    public string Make { get; set; }
    public string Model { get; set; }
}