using System;

namespace ArraysAsParameters
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] studentsGrades = new int[] { 15, 13, 8, 12, 6, 20, 14, 15 };
            double averageResult = GetAverage(studentsGrades);
            
            int[] happiness = new int[] { 1, 2, 3, 4, 5 };
            SunIsShining(happiness);

            foreach(int grade in studentsGrades)
            {
                Console.WriteLine("Grade: {0}", grade);
            }

            Console.WriteLine("The grade point average is: {0}", averageResult);

            Console.WriteLine("-------------------------------");

            foreach(int num in happiness)
            {
                Console.WriteLine("Happy Num: {0}", num);
            }
            Console.ReadKey();

        }

        static double GetAverage(int[] gradesArray)
        {
            int size = gradesArray.Length;
            double average;
            int sum = 0;

            for (int i = 0; i < size; i++)
            {
                sum += gradesArray[i];
            }

            // cast into double
            average = Math.Round((double)sum / size, 0); // rounds to whole number
            return average;
        }

        static void SunIsShining(int[] x)
        {
            for(int i = 0; i < x.Length; i++)
            {
                x[i] += 2;
            }
        }
    }
}
