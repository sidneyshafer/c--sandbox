using System;

namespace InterfacesDemo2
{
    class Program
    {
        static void Main(string[] args)
        {
            //creating two objects of type Chair
            Chair officeChair = new Chair("Brown", "Plastic");
            Chair gamingChair = new Chair("Red", "Wood");

            //creating a new object of type Car
            Car damagedCar = new Car(80f, "Blue");

            //add the two chairs to the IDestroyable list of the car
            //so that when we destroy the car the destroyable objects
            //that are near the car will get destroyed as well
            damagedCar.DestroyablesNearby.Add(officeChair);
            damagedCar.DestroyablesNearby.Add(gamingChair);

            //destroy the car
            //destroy's the car and the two chairs
            damagedCar.Destroy();

            Console.ReadKey();
        }
    }
}
