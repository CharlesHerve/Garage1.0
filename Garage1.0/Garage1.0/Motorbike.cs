using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using static System.Console;

namespace Garage1._0
{
    class Motorbike : Vehicule
    {
        //Fields:
        private string motorbikeType; //trailer, sport, road, customs, cross 
        private string motorbikeModel;
        //Properties:
        public string MotorbikeType
        {
            get
            {
                return motorbikeType;
            }
            set
            {
                motorbikeType = value;
            }
        }
        public string MotorbikeModel
        {
            get
            {
                return motorbikeModel;
            }
            set
            {
                motorbikeModel = value;
            }
        }
        //Constructors:
        public Motorbike()
        {
            WriteLine("Enter the motorbike's specifications: ");
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

            Write("MotorbikeType: ");
            string motorbikeType = ReadLine();
            Write("MotorbikeModel");
            string motorbikeModel = ReadLine();

            this.MotorbikeType = motorbikeModel;
            this.MotorbikeModel = motorbikeModel;

            base.RegistrationNumber = registrationNumber;
            base.Brand = brand;
            base.Color = color;
            base.CylinderVolume = cylinderVolume;
            base.Length = length;

        }
        public Motorbike(string motorbikeType, string motorbikeModel, string carModel, int numberOfEngines, string registrationNumber, string brand, int numberOfWheels, string color, int cylinderVolume, float length) :
            base(registrationNumber, brand, numberOfWheels, color, cylinderVolume, length)
        {
            MotorbikeType = motorbikeType;
            MotorbikeModel = motorbikeModel;
        }
    }
}
