using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using static System.Console;

namespace Garage1._0
{
    class Car : Vehicule
    {
        //Properties:
        public override string VehiculeType { get { return "Car"; } set { } }
        public string FuelCategory { get; set; }
        public string CarType { get; set; }
        public string CarModel { get; set; }

        //Constructors:
        public Car()
        {
            WriteLine();
            WriteLine("Enter the car's specifications: ");
            Write("Registration Number: ");
            string registrationNumber = ReadLine();
            Write("Brand: ");
            string brand = ReadLine();
            Write("Color: ");
            string color = ReadLine();
            Write("Cylinder Volume: ");
            int cylinderVolume = Int32.Parse(ReadLine());
            Write("Length: ");
            float length = float.Parse(ReadLine());


            Write("CarType: ");
            string carType = ReadLine();
            Write("Car model: ");
            string carModel = ReadLine();
            Write("Fuel category: ");
            string fuelCategory = ReadLine();

            VehiculeType = "Car";
            CarType = carType;
            CarModel = carModel;
            FuelCategory = fuelCategory;

            base.RegistrationNumber = registrationNumber;
            base.Brand = brand;
            base.Color = color;
            base.CylinderVolume = cylinderVolume;
            base.Length = length;
        }
        public Car(string fuelCategory, string carType, string carModel, string registrationNumber, string brand, int numberOfWheels, string color, int cylinderVolume, float length) :
            base(registrationNumber, brand, numberOfWheels, color, cylinderVolume, length)
        {
            FuelCategory = fuelCategory;
            CarType = carType;
            CarModel = carModel;
        }

        public override void VehiculeDescription()
        {
            base.VehiculeDescription();
            WriteLine("Motorbike specifications:");
            Write($"VehiculeType: {VehiculeType}- ");
            Write($"FuelCategory: {FuelCategory}- ");
            Write($"CarType: {CarType}- ");
            Write($"CarModel: {CarModel}- ");
            WriteLine();
        }

    }
}