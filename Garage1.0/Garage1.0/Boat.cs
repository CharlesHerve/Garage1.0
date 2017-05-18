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
        //Fields:

        private string boatModel;
        private string boatType;

        //Properties:
        public string ClassName { get; set; }

        public string BoatModel
        {
            get
            {
                return boatModel;
            }
            set
            {
                boatModel = value;
            }
        }
        public string BoatType
        {
            get
            {
                return boatType;
            }
            set
            {
                boatType = value;
            }
        }
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

            this.ClassName = "Boat";
            this.BoatType = boatType;
            this.BoatModel = boatModel;

            base.RegistrationNumber = registrationNumber;
            base.Brand = brand;
            base.Color = color;
            base.CylinderVolume = cylinderVolume;
            base.Length = length;
        }
        public Boat(string boatModel, string boatType, int numberOfEngines, string registrationNumber, string brand, int numberOfWheels, string color, int cylinderVolume, float length) :
            base(registrationNumber, brand, numberOfWheels, color, cylinderVolume, length)
        {
            this.ClassName = "Boat";
            this.boatModel = boatModel;
            this.boatType = boatType;
        }

    }
}
