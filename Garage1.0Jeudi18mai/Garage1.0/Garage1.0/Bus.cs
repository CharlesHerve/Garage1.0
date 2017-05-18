using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using static System.Console;

namespace Garage1._0
{
    class Bus : Vehicule
    {
        //Properties:
        public override string VehiculeType { get { return "Bus"; } set { } }
        public int NumberOfSeats { get; set; }
        public string BusModel { get; set; }

        //Constructor:
        public Bus()
        {
            WriteLine("Enter the bus specifications: ");
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

            Write("Bus model: ");
            string busModel = ReadLine();
            Write("Number of seats");
            int numberOfSeats = Int32.Parse(ReadLine());

            VehiculeType = "Bus";
            BusModel = busModel;
            NumberOfSeats = numberOfSeats;

            base.RegistrationNumber = registrationNumber;
            base.Brand = brand;
            base.Color = color;
            base.CylinderVolume = cylinderVolume;
            base.Length = length;
        }
        public Bus(int numberOfSeats, string busModel, int numberOfEngines, string registrationNumber, string brand, int numberOfWheels, string color, int cylinderVolume, float length) :
            base(registrationNumber, brand, numberOfWheels, color, cylinderVolume, length)
        {
            NumberOfSeats = numberOfSeats;
            BusModel = busModel;
        }

        public override void VehiculeDescription()
        {
            base.VehiculeDescription();
            WriteLine("Bus specifications:");
            Write($"Vehicule Type: {VehiculeType}- ");
            Write($"NumberOfSeats: {NumberOfSeats}- ");
            Write($"BusModel: {BusModel}- ");
            WriteLine();
        }

    }
}
