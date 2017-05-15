using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Garage1._0
{
    class Airplane : Vehicule
    {
        //
        private string airplaneModel;
        private int numberOfEngines;
        //properties:
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

        }
        public Airplane(string airplaneModel, int numberOfEngines, string registrationNumber, string brand, int numberOfWheels, string color, int cylinderVolume, float length) :
            base (registrationNumber, brand, numberOfWheels, color, cylinderVolume, length )
        {
            AirplaneModel = airplaneModel;
            NumberOfEngines = numberOfEngines;

        }
    }
}
