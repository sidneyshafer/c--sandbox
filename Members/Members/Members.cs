using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;

namespace Members
{
    class Members
    {
        // Member Fields - Private
        private string memberName;
        private string jobTitle;
        private int salary;

        // Member Fields - Public
        public int age;

        // Member - Properties
        // get/set
        // Start with a capital letter
        // type: 'prop' press Tab
        public string JobTitle
        {
            get
            {
                return jobTitle;
            }
            set
            {
                jobTitle = value;
            }
        }

        // Member Method - Public; can be called from other classes
        public void Introducing(bool isFriend)
        {
            if(isFriend)
            {
                SharingPrivateInfo();
            }
            else
            {
                Console.WriteLine("Hi, my name is {0}, and my job title is {1}." +
                    "I am {2} years old.", memberName, jobTitle, age);
            }
        }

        // Member Method - Private; can not be accessed by other classes
        private void SharingPrivateInfo()
        {
            Console.WriteLine("Hi friend, my salary is {0}.", salary);
        }

        // Member Constructor
        public Members(string memberName, string jobTitle, int salary, int age)
        {
            this.memberName = memberName;
            this.jobTitle = jobTitle;
            this.salary = salary;
            this.age = age;

            Console.WriteLine("Object created.");
        }

        // Member Finalizer/Destructor - can only be used for this specific class
        // A class can only have 1 finalizer; cannot be inherited or overloaded
        // Not always needed
        ~Members()
        {
            // cleanup statements
            Console.WriteLine("Deconstruction of Members object.");
            Debug.Write("Deconstruction of Members object.");
        }
    }
}
