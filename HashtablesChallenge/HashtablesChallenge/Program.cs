using System;
using System.Collections;

namespace HashtablesChallenge
{
    class Program
    {
        static void Main(string[] args)
        {
            // Array of students
            Student[] students = new Student[5];
            students[0] = new Student(1, "Denis", 88);
            students[1] = new Student(2, "Olaf", 97);
            students[2] = new Student(6, "Ragner", 65);
            students[3] = new Student(1, "Luise", 73);
            students[4] = new Student(5, "Levi", 58);

            // Create a new hashtable
            Hashtable table = new Hashtable();

            // Iterate through students array
            foreach (Student s in students)
            {
                if(!table.ContainsKey(s.Id))
                {
                    table.Add(s.Id, s);
                    Console.WriteLine("Student with ID {0} was added.", s.Id);
                }
                else
                {
                    Console.WriteLine("Sorry, A student with the same ID already exists. ID: {0}", s.Id);
                }
            }

            Console.ReadKey();
        }
    }
    class Student
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public float GPA { get; set; }

        public Student(int id, string name, float GPA)
        {
            this.Id = id;
            this.Name = name;
            this.GPA = GPA;
        }
    }
}
