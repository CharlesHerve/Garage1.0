using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using static System.Console;

//Vehicles:
//Cars, motorcycles, wheelchairs or whatever type of vehicle you want to set up in
//garage.
//A number of subclasses for vehicles: each vehicle type is its own subclass.


namespace Garage1._0
{
    class Vehicule
    {
       //Fields: 
       private string registrationNumber;
       private string brand;
       private int numberOfWheels;
       private string color;
       private int cylinderVolume;
       private float length;

        //Properties:
       
        public string RegistrationNumber
        {
            get
            {
                return registrationNumber;
            }
            set
            {
                registrationNumber = value;
            }
        }
        public string Brand
        {
            get
            {
                return brand;
            }
            set
            {
                brand = value;
            }
        }
        public int NumberOfWheels
        {
            get
            {
                return numberOfWheels;
            }
            set
            {
                numberOfWheels = value;
            }
        }
        public string Color
        {
            get
            {
                return color;
            }
            set
            {
                color = value;
            }
        }
        public int CylinderVolume
        {
            get
            {
                return cylinderVolume;

            }
            set
            {
                cylinderVolume = value;
            }
        }
        public float Length
        {
            get
            {
                return length;

            }
            set
            {
                length = value;
            }
        }
        //Constructors:
        public Vehicule()
        {
            WriteLine("Enter the vehicule's specifications: ");
            Write("Registration Number: ");
            string registrationNumber = ReadLine();
            Write("Brand: ");
            string brand = ReadLine();
            Write("Color: ");
            string color = ReadLine();
            Write("Cylinder Volume:");
            int cylinderVolume = Int32.Parse(ReadLine());
            Write("Length: ");
            float length = float.Parse(ReadLine());

            this.RegistrationNumber = registrationNumber;
            this.Brand = brand;
            this.Color = color;
            this.CylinderVolume = cylinderVolume;
            this.Length = length;
        }
        public Vehicule(string registrationNumber, string brand, int numberOfWheels, string color, int cylinderVolume, float length)
        {
            
            RegistrationNumber = registrationNumber;
            Brand = brand;
            NumberOfWheels = numberOfWheels;
            Color = color;
            CylinderVolume = cylinderVolume;
            Length = length;
        }



       








    }    
}
