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
        //Properties:
        public override string VehiculeType { get { return "Motorbike"; } set { } }
        public string MotorbikeType { get; set; }
        public string MotorbikeModel { get; set; }

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

            MotorbikeType = motorbikeModel;
            MotorbikeModel = motorbikeModel;

            base.RegistrationNumber = registrationNumber;
            base.Brand = brand;
            base.Color = color;
            base.CylinderVolume = cylinderVolume;
            base.Length = length;

        }
        public Motorbike(string brand, string motorbikeType, string motorbikeModel, int numberOfEngines, string registrationNumber,  int numberOfWheels, string color, int cylinderVolume, float length) :
            base(registrationNumber, brand, numberOfWheels, color, cylinderVolume, length)
        {
            MotorbikeType = motorbikeType;
            MotorbikeModel = motorbikeModel;
        }

        public override void VehiculeDescription()
        {
            base.VehiculeDescription();
            WriteLine("Motorbike specifications:");
            Write($"MotorbikeType: {MotorbikeType}- ");
            Write($"MotorbikeModel: {MotorbikeModel}");
            WriteLine();
        }

    }
}
