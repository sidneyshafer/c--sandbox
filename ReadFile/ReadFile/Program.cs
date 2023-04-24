using System;
using System.IO;
using System.Text.RegularExpressions;


namespace ReadFile
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            // Example 1 - Reading Text File
            string text = System.IO.File.ReadAllText(@"C:\Users\shafe\OneDrive\Documents\Web Development Courses and Resources\Programming for Beginners in C#\Assets\textFile.txt");

            Console.WriteLine("Text file containes : {0}", text);

            // Example 2 - Read every single line
            string[] lines = System.IO.File.ReadAllLines(@"C:\Users\shafe\OneDrive\Documents\Web Development Courses and Resources\Programming for Beginners in C#\Assets\textFile.txt");

            Console.WriteLine("Contents of text file : ");
            foreach (string line in lines)
            {
                Console.WriteLine("\t" + line);
            }
            */

            // Parsing Game Part 1 - Read from file
            /*
            string[] textLines = File.ReadAllLines(@"C:\Users\shafe\OneDrive\Documents\Web Development Courses and Resources\Programming for Beginners in C#\Assets\input.txt");
            foreach(string line in textLines)
            {
                if(line.Contains("split"))
                {
                    string[] txtSplit = line.Split();

                    using(StreamWriter file = new StreamWriter(@"C:\Users\shafe\OneDrive\Documents\Web Development Courses and Resources\Programming for Beginners in C#\Assets\output.txt", true))
                    {
                        file.WriteLine(txtSplit[4]);
                    }
                }
            }
            */

            // Parsing Game Part 2 - Read from file
            string text = File.ReadAllText(@"C:\Users\shafe\OneDrive\Documents\Web Development Courses and Resources\Programming for Beginners in C#\Assets\input2.txt");
            
            string pattern = @"\d{3}|\d{2}";
            Regex regex = new Regex(pattern);

            
            MatchCollection matchCollection = regex.Matches(text);

            foreach (Match hit in matchCollection)
            {
                GroupCollection group = hit.Groups;
                var value = int.Parse(group[0].Value);
                char cValue = (char)value;
                Console.WriteLine(cValue);
            }
            

            

            Console.ReadKey();
        }
    }
}
