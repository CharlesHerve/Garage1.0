using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using static System.Console;

namespace Garage1._0
{
    class Airplane : Vehicule
    {
        //
        private string airplaneModel;
        private int numberOfEngines;
        //properties:
        public string ClassName { get; set; }
        public string AirplaneModel
        {
            get
            {
                return airplaneModel;
            }
            set
            {
                airplaneModel = value;
            }
        }
        public  int NumberOfEngines
        {
            get
            {
                return numberOfEngines;
            }
            set
            {
                numberOfEngines = value;
            }
        }
        //Constructors:
        public Airplane()
        {
            WriteLine("Enter the airplane's specifications: ");
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

            Write("AirplaneModel: ");
            string airplaneModel = ReadLine();
            Write("numberOfEngines: ");
            int numberOfEngines = Int32.Parse(ReadLine());

            this.ClassName = "Airplane";
            this.AirplaneModel = airplaneModel;
            this.NumberOfEngines = numberOfEngines;

            base.RegistrationNumber = registrationNumber;
            base.Brand = brand;
            base.Color = color;
            base.CylinderVolume = cylinderVolume;
            base.Length = length;
        }

        public Airplane(string airplaneModel, int numberOfEngines, string registrationNumber, string brand, int numberOfWheels, string color, int cylinderVolume, float length) :
            base (registrationNumber, brand, numberOfWheels, color, cylinderVolume, length )
        {
            this.ClassName = "Airplane";
            this.airplaneModel = airplaneModel;
            this.numberOfEngines = numberOfEngines;

        }
    }
}
