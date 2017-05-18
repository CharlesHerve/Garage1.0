using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using static System.Console;

namespace Garage1._0
{
    class Boat : Vehicule
    {
        //Properties:
        public override string VehiculeType { get { return "Boat"; } set { } }
        public string BoatModel { get; set; }        
        public string BoatType { get; set; }

        //Constructor:
        public Boat()
        {
            WriteLine("Enter the boat's specifications: ");
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

            Write("Boat type: ");
            string boatType = ReadLine();
            Write("Boat model: ");
            string boatModel = ReadLine();

            
            BoatType = boatType;
            BoatModel = boatModel;

            base.RegistrationNumber = registrationNumber;
            base.Brand = brand;
            base.Color = color;
            base.CylinderVolume = cylinderVolume;
            base.Length = length;
        }
        public Boat(string boatModel, string boatType, int numberOfEngines, string registrationNumber, string brand, int numberOfWheels, string color, int cylinderVolume, float length) :
            base(registrationNumber, brand, numberOfWheels, color, cylinderVolume, length)
        {
            
            BoatModel = boatModel;
            BoatType = boatType;
        }

        public override void VehiculeDescription()
        {
            base.VehiculeDescription();
            WriteLine("Boat specifications:");
            Write($"Vehicule Type: {VehiculeType}- ");
            Write($"BoatModel: {BoatModel}- ");
            Write($"BoatType: {BoatType}- ");
            WriteLine();
        }

    }
}
