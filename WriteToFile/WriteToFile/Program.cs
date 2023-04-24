using System;
using System.IO;

namespace WriteToFile
{
    class Program
    {
        static void Main(string[] args)
        {
            // Method 1
            string[] lines = { "First : 250", "Second : 242", "Third : 240" };
            File.WriteAllLines(@"C:\Users\shafe\OneDrive\Documents\Web Development Courses and Resources\Programming for Beginners in C#\Assets\highscores.txt", lines);

            // Method 3
            /*
            Console.WriteLine("Enter file name : ");
            string fileName = Console.ReadLine();

            Console.WriteLine("Enter file contents : ");
            string input = Console.ReadLine();
            */

            // File.WriteAllText(@"C:\Users\shafe\OneDrive\Documents\Web Development Courses and Resources\Programming for Beginners in C#\Assets\" + fileName + ".txt", input);

            // Method 3
            using(StreamWriter file = new StreamWriter(@"C:\Users\shafe\OneDrive\Documents\Web Development Courses and Resources\Programming for Beginners in C#\Assets\myText.txt"))
            {
                foreach(string line in lines)
                {
                    if (line.Contains("Third"))
                    {
                        file.WriteLine(line);
                    }
                }
            }

            using(StreamWriter file = new StreamWriter(@"C:\Users\shafe\OneDrive\Documents\Web Development Courses and Resources\Programming for Beginners in C#\Assets\myText.txt", true))
            {
                file.WriteLine("Additional line!!!");
            }


            Console.ReadKey();
        }
    }
}
