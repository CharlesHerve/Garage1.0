using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using static System.Console;

namespace Garage1._0
{
    class Program
    {
        static void Main(string[] args)
        {
            var garage = new Garage<Vehicule>();
            //Vehicule voiture1 = new Vehicule();
            //Vehicule voiture2 = new Vehicule();
            //Vehicule voiture3 = new Vehicule();
            //Car voiture4 = new Car();
            var voiture1 = new Vehicule("ABC123", "CITROEN", 4, "BLUE", 2000, 4.30f);
            var voiture2 = new Car ("Diesel", "Sedan", "206", "DFG456", "PEUGEOT", 4, "WHITE", 1700, 4.70f);
            var airplane1 = new Airplane("A320", 4, "KJH79863T", "Airbus", 6, "White", 155000, 62.8f  );
            var boat1 = new Boat("Pirat", "Yacht", 4, "MX29300", "Beneteau", 0, "Blue Sky", 3000, 15.3f);
            var motorbike1 = new Motorbike("Harley Davidson", "Custom", "Street Rod", 1, "KTM666", 2, "Black", 750, 2.1f);

            //WriteLine($"Car Brand: {voiture.Brand}, model: {voiture.CarModel}");
            garage.AddVehicule(voiture1, 0);
            garage.AddVehicule(voiture2, 1);
            garage.AddVehicule(airplane1, 2);
            garage.AddVehicule(boat1, 3);
            garage.AddVehicule(motorbike1, 4);


            //garage.RemoveVehicule();
            //garage.Display();
            WriteLine($"marque: {airplane1.Brand}");

            garage.ListAllVehicules();
            //garage.DisplayVehicules(1);
            //garage.DisplayVehicules(2);
            

        }
    }
}
