using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Garage1._0
{
    class Car : Vehicule
    {
        //Fields:
        private string fuelCategory;
        private string carType;
        private string carModel;
        //Properties:
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

        }
        public Car(string fuelCategory, string carType, string carModel, int numberOfEngines, string registrationNumber, string brand, int numberOfWheels, string color, int cylinderVolume, float length) :
            base(registrationNumber, brand, numberOfWheels, color, cylinderVolume, length)
        {

        }
    }
}
