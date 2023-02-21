using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Configuration;
using Linq4.CSHARPDBDataSetTableAdapters;

namespace Linq4
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        LinqToSqlDataClassesDataContext dataContext;

        public MainWindow()
        {
            InitializeComponent();

            //Establish SQL Connection
            // Right click on Reference is Solution Explorer -> Add Reference -> Click System.Configuration
            // --> add namespace to page : using System.Configuration;
            // 
            string connectionString = ConfigurationManager.ConnectionStrings["Linq4.Properties.Settings.CSHARPDBConnectionString"].ConnectionString;
            dataContext = new LinqToSqlDataClassesDataContext(connectionString);

            //InsertUniversities();

            //InsertStudents();

            //InsertLectures();

            //InsertStudentLecture();

            //GetUniOfSidney();

            //GetSidneysLectures();

            //GetAllStudentsFromYale();

            //GetAllUniWithFemale();

            //GetAllLecturesFromHTC();

            //UpdateSidney();

            DeleteBrent();
        }

        public void InsertUniversities()
        {
            dataContext.ExecuteCommand("DELETE FROM University");

            //create a new object
            University yale = new University();
            yale.Name = "Yale";
            //insert data to table
            dataContext.Universities.InsertOnSubmit(yale);

            University htc = new University();
            htc.Name = "Hennepin Tech";
            dataContext.Universities.InsertOnSubmit(htc);

            //submit data to table
            dataContext.SubmitChanges();

            //set data grid of xaml file to the data context of the universities
            MainDataGrid.ItemsSource = dataContext.Universities;
        }

        public void InsertStudents()
        {
            //lambda expression
            University yale = dataContext.Universities.First(un => un.Name.Equals("Yale"));
            University htc = dataContext.Universities.First(un => un.Name.Equals("Hennepin Tech"));

            List<Student> students = new List<Student>();

            students.Add(new Student { Name = "Sidney", Gender = "female", UniversityId = htc.Id });
            students.Add(new Student { Name = "Allie", Gender = "female", University = yale });
            students.Add(new Student { Name = "Brent", Gender = "male", University = htc });
            students.Add(new Student { Name = "Tryg", Gender = "male", University = yale });

            dataContext.Students.InsertAllOnSubmit(students);
            dataContext.SubmitChanges();

            MainDataGrid.ItemsSource = dataContext.Students;
        }

        public void InsertLectures()
        {
            dataContext.ExecuteCommand("DELETE FROM Lecture");

            dataContext.Lectures.InsertOnSubmit(new Lecture { Name = "Math" });
            dataContext.Lectures.InsertOnSubmit(new Lecture { Name = "English" });
            dataContext.Lectures.InsertOnSubmit(new Lecture { Name = "History" });

            dataContext.SubmitChanges();

            MainDataGrid.ItemsSource = dataContext.Lectures;
        }

        public void InsertStudentLecture() 
        {
            dataContext.ExecuteCommand("DELETE FROM StudentLecture");

            Student Sidney = dataContext.Students.First(st => st.Name.Equals("Sidney"));
            Student Allie = dataContext.Students.First(st => st.Name.Equals("Allie"));
            Student Brent = dataContext.Students.First(st => st.Name.Equals("Brent"));
            Student Tryg = dataContext.Students.First(st => st.Name.Equals("Tryg"));

            Lecture Math = dataContext.Lectures.First(lc => lc.Name.Equals("Math"));
            Lecture English = dataContext.Lectures.First(lc => lc.Name.Equals("English"));
            Lecture History = dataContext.Lectures.First(lc => lc.Name.Equals("History"));

            dataContext.StudentLectures.InsertOnSubmit(new StudentLecture { Student = Sidney, Lecture = Math });
            dataContext.StudentLectures.InsertOnSubmit(new StudentLecture { Student = Allie, Lecture = English });
            dataContext.StudentLectures.InsertOnSubmit(new StudentLecture { Student = Brent, Lecture = History });

            StudentLecture slTryg = new StudentLecture();
            slTryg.Student = Tryg;
            slTryg.LectureId = English.Id;
            dataContext.StudentLectures.InsertOnSubmit(slTryg);

            dataContext.SubmitChanges();

            MainDataGrid.ItemsSource = dataContext.StudentLectures;

        }

        public void GetUniOfSidney()
        {
            Student Sidney = dataContext.Students.First(st => st.Name.Equals("Sidney"));
            University SidneysUni = Sidney.University;

            List<University> universities = new List<University>();
            universities.Add(SidneysUni);

            MainDataGrid.ItemsSource = universities;
        }

        public void GetSidneysLectures()
        {
            Student Sidney = dataContext.Students.First(st => st.Name.Equals("Sidney"));

            //get specific lecture
            var SidneysLectures = from sl in Sidney.StudentLectures select sl.Lecture;

            MainDataGrid.ItemsSource = SidneysLectures;
        }

        public void GetAllStudentsFromYale()
        {
            //collection of IEnumerables
            var studentsFromYale = from student in dataContext.Students
                                   where student.University.Name == "Yale"
                                   select student;

            MainDataGrid.ItemsSource = studentsFromYale;
        }

        public void GetAllUniWithFemale()
        {
            var femaleStudents = from student in dataContext.Students
                                 join university in dataContext.Universities
                                 on student.University equals university
                                 where student.Gender == "female"
                                 select university;

            MainDataGrid.ItemsSource = femaleStudents;
        }

        public void GetAllLecturesFromHTC()
        {
            var htcLectures = from sl in dataContext.StudentLectures
                              join student in dataContext.Students on sl.StudentId equals student.Id
                              where student.University.Name == "Hennepin Tech"
                              select sl.Lecture;

            MainDataGrid.ItemsSource = htcLectures;
        }

        public void UpdateSidney()
        {
            Student Sidney = dataContext.Students.FirstOrDefault(st => st.Name == "Sidney");

            Sidney.Name = "Sid";

            dataContext.SubmitChanges();

            MainDataGrid.ItemsSource = dataContext.Students;
        }

        public void DeleteBrent()
        {
            Student Brent = dataContext.Students.FirstOrDefault(st => st.Name == "Brent");
            dataContext.Students.DeleteOnSubmit(Brent);
            dataContext.SubmitChanges();

            //if you run into error add the following code : 
            /*
            string connectionString = ConfigurationManager.ConnectionStrings["Linq4.Properties.Settings.CSHARPDBConnectionString"].ConnectionString;
            LinqToSqlDataClassesDataContext db = new LinqToSqlDataClassesDataContext(connectionString)
            */

            MainDataGrid.ItemsSource = dataContext.Students;
        }
    }
}
