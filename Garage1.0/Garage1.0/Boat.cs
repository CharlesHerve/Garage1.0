using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Garage1._0
{
    class Boat : Vehicule
    {
        //Fields:
        private string boatModel;
        private string boatType;
        
        //Properties:
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

        }
        public Boat(string boatModel, string boatType, int numberOfEngines, string registrationNumber, string brand, int numberOfWheels, string color, int cylinderVolume, float length) :
            base(registrationNumber, brand, numberOfWheels, color, cylinderVolume, length)
        {
            BoatModel = boatModel;
            BoatType = boatType;
        }

    }
}
