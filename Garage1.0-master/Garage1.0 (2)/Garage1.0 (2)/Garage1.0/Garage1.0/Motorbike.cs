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
        public string ClassName { get; set; }
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
            this.ClassName = "Motorbike";
        }
        public Motorbike(string motorbikeType, string motorbikeModel, string carModel, int numberOfEngines, string registrationNumber, string brand, int numberOfWheels, string color, int cylinderVolume, float length) :
            base(registrationNumber, brand, numberOfWheels, color, cylinderVolume, length)
        {
            MotorbikeType = motorbikeType;
            MotorbikeModel = motorbikeModel;
        }
    }
}
