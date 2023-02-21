namespace Linq2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            UniversityManager um = new UniversityManager();

            um.MaleStudents();
            Console.WriteLine();

            um.FemaleStudents();
            Console.WriteLine();

            um.SortStudentsByAge();
            Console.WriteLine();

            um.AllStudentsFromHennepinTech();
            Console.WriteLine();

            um.StudentAndUniNameCollection();
            Console.WriteLine();

            int[] someInts = { 2, 30, 4, 3, 12 };
            //another way of ordering integar values
            IEnumerable<int> sortedInts = from i in someInts orderby i select i;
            //reverse order
            IEnumerable<int> reversedInts = sortedInts.Reverse();

            Console.WriteLine("Sorted Ints : ");
            foreach(int i in sortedInts)
            {
                Console.WriteLine(i);
            }

            Console.WriteLine("Reversed Ints : ");
            foreach (int i in reversedInts)
            {
                Console.WriteLine(i);
            }

            //reverse and sort integers at same time
            IEnumerable<int> reversedSortedInts = from i in someInts orderby i descending select i;
            Console.WriteLine("Reversed and Sorted Ints : ");
            foreach (int i in reversedSortedInts)
            {
                Console.WriteLine(i);
            }


            /*
            Console.WriteLine("Enter a University ID : ");
            try
            {
                int id = Convert.ToInt32(Console.ReadLine());
                um.GetStudentByUniId(id);
            }
            catch (Exception)
            {
                Console.WriteLine("An error occured.");
            }
            */


            Console.ReadKey();
        }
    }

    class UniversityManager
    {
        public List<University> universities;
        public List<Student> students;

        //constructor
        public UniversityManager()
        {
            universities = new List<University>();
            students = new List<Student>();

            //add Universities
            universities.Add(new University { Id = 1, Name = "Yale" });
            universities.Add(new University { Id = 2, Name = "Hennepin Tech" });

            //add Students
            students.Add(new Student { Id = 1, Name = "Sidney", Gender = "female", Age = 18, UniversityId = 2 });
            students.Add(new Student { Id = 2, Name = "Allie", Gender = "female", Age = 18, UniversityId = 1 });
            students.Add(new Student { Id = 3, Name = "James", Gender = "male", Age = 21, UniversityId = 1 });
            students.Add(new Student { Id = 4, Name = "Kayla", Gender = "female", Age = 22, UniversityId = 2 });
            students.Add(new Student { Id = 5, Name = "Jack", Gender = "male", Age = 19, UniversityId = 2 });
        }

        public void MaleStudents()
        {
            // Linq statement
            IEnumerable<Student> maleStudents = from student in students where student.Gender == "male" select student;
            Console.WriteLine("Male Students : ");
            foreach(Student student in maleStudents)
            {
                student.Print();
            }
        }

        public void FemaleStudents()
        {
            IEnumerable<Student> femaleStudents = from student in students where student.Gender == "female" select student;
            Console.WriteLine("Female Students : ");
            foreach (Student student in femaleStudents)
            {
                student.Print();
            }
        }

        public void SortStudentsByAge()
        {
            //orderby operator
            var sortedStudents = from student in students orderby student.Age select student;

            Console.WriteLine("Students sorted by Age :");

            foreach (Student student in sortedStudents)
            {
                student.Print();
            }
        }

        public void AllStudentsFromHennepinTech()
        {
            IEnumerable<Student> htcStudents = from student in students
                                               join university in universities
                                               on student.UniversityId equals university.Id
                                               where university.Name == "Hennepin Tech"
                                               select student;

            Console.WriteLine("Students at Hennepin Tech :");

            foreach (Student student in htcStudents)
            {
                student.Print();
            }
        }

        public void GetStudentByUniId(int Id)
        {
            IEnumerable<Student> uniStudents = from student in students
                                               join university in universities
                                               on student.UniversityId equals university.Id
                                               where university.Id == Id
                                               select student;

            Console.WriteLine("Students at University {0} :", Id);

            foreach (Student student in uniStudents)
            {
                student.Print();
            }
        }

        public void StudentAndUniNameCollection()
        {
            var newCollection = from student in students
                                join university in universities on student.UniversityId equals university.Id
                                orderby student.Name
                                select new { StudentName = student.Name, UniversityName = university.Name };

            Console.WriteLine("New Collection : ");

            foreach(var col in newCollection)
            {
                Console.WriteLine("Student {0} from University {1}", col.StudentName, col.UniversityName);
            }
        }
    }

    class University
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public void Print()
        {
            Console.WriteLine("University {0} with ID #{1}", Name, Id);
        }
    }

    class Student
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Gender { get; set; }
        public int Age { get; set; }

        //Foreign Key
        public int UniversityId { get; set; }

        public void Print()
        {
            Console.WriteLine("Student {0} with ID #{1}, Gender {2}, and Age {3} from University #{4}",
                Name, Id, Gender, Age, UniversityId);
        }
    }
}