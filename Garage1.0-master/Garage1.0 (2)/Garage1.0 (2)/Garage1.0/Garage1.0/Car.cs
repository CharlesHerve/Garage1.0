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
        //Fields:
        
        private string fuelCategory;
        private string carType;
        private string carModel;
        //Properties:
        public string ClassName { get; set; }
        public string FuelCategory
        {
            get
            {
                return fuelCategory;
            }
            set
            {
                fuelCategory = value;
            }
        }
        public string CarType
        {
            get
            {
                return carType;
            }
            set
            {
                carType = value;
            }
        }
        public string CarModel
        {
            get
            {
                return carModel;
            }
            set
            {
                carModel = value;
            }
        }
        //Constructors:
        public Car()
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

            Write("CarType: ");
            string carType = ReadLine();
            Write("Car model: ");
            string carModel = ReadLine();
            Write("Fuel category");
            string fuelCategory = ReadLine();
                                
            this.ClassName = "Car";
            this.CarType = carType;
            this.CarModel = carModel;
            this.FuelCategory = fuelCategory;
             
            base.RegistrationNumber = registrationNumber;
            base.Brand = brand;
            base.Color = color;
            base.CylinderVolume = cylinderVolume;
            base.Length = length;
        }
        public Car(string fuelCategory, string carType, string carModel, int numberOfEngines, string registrationNumber, string brand, int numberOfWheels, string color, int cylinderVolume, float length) :
            base(registrationNumber, brand, numberOfWheels, color, cylinderVolume, length)
        {
            this.ClassName = "Car";
            this.fuelCategory = fuelCategory;
            this.carType = carType;
            this.carModel = carModel;
        }
    }
}
