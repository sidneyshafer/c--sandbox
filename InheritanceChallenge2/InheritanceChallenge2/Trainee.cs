using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceChallenge2
{
    class Trainee : Employee
    {
        public int WorkingHours { get; set; }
        public int SchoolHours { get; set; }

        public Trainee(int workingHours, int schoolHours, string lastName, string firstName, int salary):base(lastName, firstName, salary)
        {
            this.WorkingHours = workingHours;
            this.SchoolHours = schoolHours;
        }

        public void Learn()
        {
            Console.WriteLine($"My name is {FirstName} {LastName} and " +
                $"I am learning for {SchoolHours} hours!");
        }

        //use 'new' keyword to override methods
        public new void Work()
        {
            Console.WriteLine($"I work for {WorkingHours}.");
        }

    }
}
