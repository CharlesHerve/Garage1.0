using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using static System.Console;

//Vehicles:
//Cars, motorcycles, wheelchairs or whatever type of vehicle you want to set up in
//garage.
//A number of subclasses for vehicles: each vehicle type is its own subclass.


namespace Garage1._0
{
    abstract class Vehicule
    {
        //Properties:
        abstract public string VehiculeType { get; set; }

        public string RegistrationNumber { get; set; }
        public string Brand { get; set; }
        public int NumberOfWheels { get; set; }
        public string Color { get; set; }
        public int CylinderVolume { get; set; }
        public float Length { get; set; }
        //Constructors:
        public Vehicule()
        {

        }
        public Vehicule(string registrationNumber, string brand, int numberOfWheels, string color, int cylinderVolume, float length)
        {
            RegistrationNumber = registrationNumber;
            Brand = brand;
            NumberOfWheels = numberOfWheels;
            Color = color;
            CylinderVolume = cylinderVolume;
            Length = length;
        }
        public virtual void VehiculeDescription()
        {
                WriteLine("Vehicule specifications:");
                Write($"Reg.Number: {RegistrationNumber}- ");
                Write($"Brand: {Brand}- ");
                Write($"Color: {Color}- ");
                Write($"Length: {Length}- ");
                Write($"Wheels: {NumberOfWheels}- ");
                Write($"Cylinder: {CylinderVolume} cm³");
                WriteLine();
            
        }


       








    }    
}
