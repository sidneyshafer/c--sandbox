using System;

namespace PolymorphicParameters
{
    class Program
    {
        static void Main(string[] args)
        {
            // Polymorphism
            var cars = new List<Car>
            {
                new Audi(200, "blue", "A4"),
                new BMW(250, "red", "M3")
            };

            foreach(var car in cars)
            {
                car.Repair();
            }

            Car bmwZ3 = new BMW(200, "black", "Z3");
            Car audiA3 = new Audi(100, "silver", "A3");

            // ShowDetials() method is called from the Car class
            // Not individual BMW or Audi class
            bmwZ3.ShowDetails();
            audiA3.ShowDetails();

            bmwZ3.SetCarIDInfo(1234, "Sidney Shafer");
            audiA3.SetCarIDInfo(5678, "Allie Shafer");

            Console.WriteLine("-----------------");

            bmwZ3.GetCarIDInfo();
            audiA3.GetCarIDInfo();

            Console.WriteLine("-----------------");

            BMW bmwM5 = new BMW(330, "white", "M5");
            // ShowDetails() method is called from the BMW class
            // Not Car class
            bmwM5.ShowDetails();

            Console.WriteLine("-----------------");

            // Cast BMW object to Car object
            Car carB = (Car)bmwM5;
            carB.ShowDetails(); // Is called from base class (Car class)

            Console.WriteLine("-----------------");

            M3 myM3 = new M3(260, "red", "M3 Super Turbo");
            myM3.Repair();

            Console.ReadKey();
        }
    }
}