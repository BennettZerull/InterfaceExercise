using System;
using System.Collections.Generic;

namespace InterfaceExercise
{
    class Program
    {
        static void Main(string[] args)
        {
            //TODO Be sure to follow BEST PRACTICES when creating classes and interfaces

            //##Create 2 Interfaces called IVehicle & ICompany

            //##Create 3 classes called Car , Truck , & SUV

            //##In your IVehicle:
            
                /* Create 4 members that Car, Truck, & SUV all have in common.
                 * Example: public int NumberOfWheels { get; set; }
                 */
            

            //##In ICompany: 
            
                /* Create 2 members that are specific to each every company
                 * regardless of vehicle type.
                 * Example: public string Logo { get; set; }
                 */

            //##In each of your Car, Truck, and SUV classes

                /* Create 2 members that are specific to each class
                 * Example for Car: public bool HasTrunk { get; set; }
                 * Example for SUV: public int NumberOfSeats { get; set; }
                 *
                 * Then, Set each class to inherit from both IVehicle and ICompany and implement their members.
                 */

            //##Now, create objects of your 3 classes and give their members values.
            //##Creatively display and organize their values
            
            var carOne = new Car();
            carOne.NumberOfWheels = 4;
            carOne.NumberOfDoors = 4;
            carOne.Year = 2020;
            carOne.Color = "Red";
            carOne.Make = "Ford";
            carOne.Model = "Fusion";
            carOne.HasTrunk = true;
            carOne.TrunkSize = 16;
            var truckOne = new Truck();
            truckOne.NumberOfWheels = 6;
            truckOne.NumberOfDoors = 2;
            truckOne.Year = 2016;
            truckOne.Color = "White";
            truckOne.Make = "Toyota";
            truckOne.Model = "Tacoma";
            truckOne.IsLifted = false;
            truckOne.TruckBedSize = 28;
            var SUVOne = new SUV();
            SUVOne.NumberOfWheels = 4;
            SUVOne.NumberOfDoors = 4;
            SUVOne.Year = 2012;
            SUVOne.Color = "Blue";
            SUVOne.Make = "Jeep";
            SUVOne.Model = "Grand Cherokee";
            SUVOne.HasFourWheelDive = true;
            SUVOne.InteriorSize = 106;

            var carLot = new List<IVehicle>() { carOne, truckOne, SUVOne };

            foreach (var auto in carLot)
            {
                Console.WriteLine($"I am looking for a {auto.NumberOfWheels} wheeled, {auto.NumberOfDoors} doored, {auto.Color} vehicle made in the year {auto.Year}.\n");
            }

            //Option for displaying values: 
            //Create a stubbed out method called DisplayDetails in your IVehicle interface.
            //Implement the stubbed out method in the derived classes.
            //In the scope of them method, use string interpolation to display property values.
            //In order to also interpolate values from ICompany, research how to extend interfaces.

        }
    }
}
