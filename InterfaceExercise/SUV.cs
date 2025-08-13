namespace InterfaceExercise;

public class SUV : IVehicle, ICompany
{
    public bool HasFourWheelDive { get; set; }
    public int InteriorSize { get; set; }
    public int NumberOfWheels { get; set; }
    public int NumberOfDoors { get; set; }
    public int Year { get; set; }
    public string Color { get; set; }
    public string Make { get; set; }
    public string Model { get; set; }
}