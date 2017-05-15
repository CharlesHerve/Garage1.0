using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Garage1._0
{
    class Bus : Vehicule
    {
        //Fields:
        private int numberOfSeats;
        private string busModel;
        //Properties:
        public int NumberOfSeats
        {
            get
            {
                return numberOfSeats;
            }
            set
            {
                numberOfSeats = value;
            }
        }
        public string BusModel
        {
            get
            {
                return busModel;
            }
            set
            {
                busModel = value;
            }
        }
        //Constructor:
        public Bus()
        {

        }
        public Bus(int numberOfSeats, string busModel, int numberOfEngines, string registrationNumber, string brand, int numberOfWheels, string color, int cylinderVolume, float length) :
            base(registrationNumber, brand, numberOfWheels, color, cylinderVolume, length)
        {
            NumberOfSeats = numberOfSeats;
            BusModel = busModel;
        }

    }
}
