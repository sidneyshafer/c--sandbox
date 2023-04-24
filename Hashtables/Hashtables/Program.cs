using System;
using System.Collections;

namespace Hashtables
{
    class Program
    {
        // Key - Value
        static void Main(string[] args)
        {
            // Uses System.Collections;
            // Initialze an empty hashtable
            Hashtable studentsTable = new Hashtable();

            // Create student objects
            Student stud1 = new Student(1, "Maria", 3.8f);
            Student stud2 = new Student(2, "Jason", 3.0f);
            Student stud3 = new Student(3, "Clara", 4.0f);
            Student stud4 = new Student(4, "Steve", 3.5f);

            // Add data
            // stud1.Id - Key
            // stud1 - Value
            studentsTable.Add(stud1.Id, stud1);
            studentsTable.Add(stud2.Id, stud2);
            studentsTable.Add(stud3.Id, stud3);
            studentsTable.Add(stud4.Id, stud4);

            // Retrieve entries - individual item with known ID
            Student storedStudent1 = (Student)studentsTable[stud1.Id];

            Console.WriteLine("Student ID: {0}\nName: {1}\nGPA: {2}", storedStudent1.Id, storedStudent1.Name, storedStudent1.GPA);
            Console.WriteLine();


            // Retrieve all values from hashtable
            foreach (DictionaryEntry entry in studentsTable)
            {
                Student temp = (Student)entry.Value;
                Console.WriteLine("Student ID: {0}", temp.Id);
                Console.WriteLine("Student Name: {0}", temp.Name);
                Console.WriteLine("Student GPA: {0}", temp.GPA);
                Console.WriteLine();
            }

            // Easier way than the code above
            foreach (Student value in studentsTable.Values)
            {
                Console.WriteLine("Student ID: {0}", value.Id);
                Console.WriteLine("Student Name: {0}", value.Name);
                Console.WriteLine("Student GPA: {0}", value.GPA);
                Console.WriteLine();
            }

            
            Console.ReadKey();
        }
    }

    // Create new class
    class Student
    {
        // Id property
        public int Id { get; set; }

        // Name property
        public string Name { get; set; }

        // GPA property
        public float GPA { get; set; }

        // Constructor
        public Student(int id, string name, float GPA)
        {
            this.Id = id;
            this.Name = name;
            this.GPA = GPA;
        }
    }
}
