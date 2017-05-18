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
            var voiture2 = new Vehicule("DFG456", "PEUGEOT", 4, "WHITE", 1700, 4.70f);
            var voiture3 = new Vehicule("XYZ789", "RENAULT", 4, "RED", 2200, 4.80f);


            //WriteLine($"Car Brand: {voiture.Brand}, model: {voiture.CarModel}");
            garage.AddVehicule(voiture1, 0);
            garage.AddVehicule(voiture2, 1);
            garage.AddVehicule(voiture3, 2);
            //garage.AddVehicule(voiture4);

            //garage.RemoveVehicule();
            //garage.Display();
            WriteLine($"marque: {voiture3.Brand}");

            garage.DisplayVehicules();
            //garage.DisplayVehicules(1);
            //garage.DisplayVehicules(2);


        }
    }
}
