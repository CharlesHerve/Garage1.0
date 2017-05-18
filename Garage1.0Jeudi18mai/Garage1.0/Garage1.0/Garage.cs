﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using static System.Console;



namespace Garage1._0
{
    //A generic collection of vehicles: Class Garage<T>, where: T should be limited to being Vehicle, ie where T: Vehicle
    // ○ Garage should not inherit from any other class, or implement anything other interface than IEnumerable
    class Garage<T> where T : Vehicule
    {
        //Fields:
        // ○ The collection of vehicles must be handled internally in the class as an array, ie: Vehicle[].
        private T[] vehicules;
        //private int capacity;

        
        //Properties:
        // ○ A capacity required as an input parameter when installing a new Garage:
        public int Capacity { get; set; }
        

        //Constructors:
        public Garage()
        {
            Write("New garage, define its capacity: ");
            int capacity = Int32.Parse(ReadLine());
            Capacity = capacity;
            
            vehicules = new T[Capacity];
            WriteLine($"A garage with a capacity of {Capacity} vehicules is now open.");
            WriteLine();

        }
               
        // ○ Possibility to add (Park) vehicules: OK
        public void AddVehicule(T vehicule, int position)
        {
            //int indexForNewVehicule = 0;
            //if (vehicules.Length > 0) indexForNewVehicule = vehicules.Length +1;
            //vehicules[indexForNewVehicule] = vehicule;
            vehicules[position] = vehicule;
            WriteLine($"{vehicules[position].RegistrationNumber} is added to the Garage: ");
        }

        // Possibility to list all vehicles in the garage:
        public void ListAllVehicules()
        {
            WriteLine();
            WriteLine("List of all the  vehicules in the garage:");
            WriteLine();
            foreach(T vehicule in vehicules)
            {
                vehicule.VehiculeDescription();
                WriteLine();
            }              
        }
        // Possibility to list all types of vehicles in the garage and how many of those in the garage
        public void ListAndCountVehiculesTypes()
        {
            WriteLine();
            WriteLine("List all types of vehicles in the garage and how many of those in the garage");
            WriteLine();
            foreach(T vehicule in vehicules)
            {
                switch (vehicule.)
                {

                }
            }
        }


    }//Class garage
}//Namespace