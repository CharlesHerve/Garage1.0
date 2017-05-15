using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using static System.Console;


//A collection of vehicles; Class garage.
//Garage Functionalities:
//to park a vehicle,
//pick up a vehicle, 
//look for the vehicles there, 
//search what characteristics those vehicules have.
//
//The garage: 
//A representation of the building itself.
//The garage is a place where a lot of vehicles can be stored. 
//The garage can thus be represented as a collection of vehicles.

//A generic collection of vehicles: Class Garage<T>, where:
// ○ T should be limited to being Vehicle, ie where T: Vehicle
// ○ Possibility of foreach-loop on the garage. 
//   Thus, Garage implements the generic version of the IEnumerable interface, ie:
//   IEnumerable<T>
// ○ Garage should not inherit from any other class, or implement anything
//   other interface than IEnumerable
// ○ The collection of vehicles must be handled internally in the class as an array, ie: 
//   Vehicle[].
// ○ Possibility to list all vehicles in the garage.
// ○ Possibility to list all types of vehicles in the garage and how many
//   of those in the garage
// ○ Possibility to add and remove vehicles from the garage
// ○ A capacity required as an input parameter when installing a new arage.
// ○ Possibility to search for a specific vehicle via Reg-nr.
// ○ Ability to search for multiple vehicles on a number of optional variables
//   (ie:Brand, Model, Color?).
namespace Garage1._0
{
    class Garage<T>  where T : Vehicule
    {
        //Fields:
        private Vehicule [] vehicules;
        private int capacity;


        //Properties:
        
        public int Capacity { get; set; }
        
        //Constructors:
        public Garage()
        {
            
        }
        public Garage( int capacity)
        {
            vehicules = new Vehicule[capacity];
            this.capacity = capacity;
        }
        // Generic Collection of Vehicules:



        //ParkVehicule:
        public void AddVehicule(T vehicule)
        {
            WriteLine("Add a new vehicule to the Garage: ");

        }

        //RemoveVehicule:
        public void RemoveVehicule(T Vehicule, int registrationNumber)
        {

        }

        //SearchVehicule:   //override? => registration number
        public T SearchVehicule (int registrationNumber)
        {
            return;
        }
        //SearchVehicule:   //override? => by 2 parameters
        public T SearchVehicule(string brand, string color)
        {
            return;
        }

        //ListAllVehicules:Possibility of foreach-loop on the garage; Garage implements 
        //the generic version of the IEnumerable interface, ie: IEnumerable<T> (ICollections<T>?)
        public IEnumerable<T> ListAllVehicules()
        {
            foreach (T vehicule in vehicules)
            {
                yield return vehicule;
            }
        }


        //ListVehiculeTypes:
        public T ListVehiculeTypes( string VehiculeType)
        {

            foreach (vehicule in vehicules)
            {
                yield return vehicule;
            }
        }
        //// NewVehicule:
        public T NewVehicule()
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




        }







}
}
