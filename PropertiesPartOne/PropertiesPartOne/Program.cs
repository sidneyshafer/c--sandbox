using System;

namespace PropertiesPartOne
{
    class Program
    {
        static void Main(string[] args)
        {
            // Create and object/instance of a class
            Box box = new Box(8, 9, 4);

            // box.SetLength(-4); --> throw exception
            box.SetLength(6);

            // Set height by accessing member variable directly
            // box.height = 4;
            // box.width = 5;

            // Set height by accessing property
            box.Height = -4; // output = 4
            box.Width = 5;


            Console.WriteLine("Box length is: " + box.GetLength());
            Console.WriteLine("Box volume is: " + box.GetVolume());
            Console.WriteLine("Box height is: " + box.Height);
            Console.WriteLine("Box width is: " + box.Width);
            box.DisplayInfo();
            Console.WriteLine("--------------------------------------------------------");

            Box box2 = new Box(8, 9, 4);
            box2.DisplayInfo();

            Console.ReadKey();
        }
    }
}
