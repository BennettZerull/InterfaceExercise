namespace InterfaceExercise;

public interface IVehicle
{
    public int NumberOfWheels { get; set; }
    public int NumberOfDoors { get; set; }
    public int Year  { get; set; }
    public string Color { get; set; }
}