using System;
using System.Collections.Generic;
using System.Linq;

namespace Dictionaries
{
    class Program
    {
        // Key - Value
        static void Main(string[] args)
        {
            // Dictionaries use System.Collections.Generic

            // **Recomend use an Id as Key**

            // Dictionary< datatype Key, datatype Value>
            // key will be type int, value will be type string // initialize dictionary
            Dictionary<int, string> myDictionary = new Dictionary<int, string>()
            {
                { 1, "one" },
                { 2, "two" },
                { 3, "three" },
                { 4, "four" }
            };

            // hypothetical database of employees (aka. an array of employees)
            Employee[] employees =
            {
                new Employee("CEO", "Gwyn", 55, 200),
                new Employee("Manager", "Joe", 35, 25),
                new Employee("HR", "Lora", 32, 22),
                new Employee("Secretary", "Petra", 28, 19),
                new Employee("Lead Developer", "Artorias", 45, 35),
                new Employee("Intern", "Sidney", 22, 15),
            };

            // Key - string, Value - Employee object
            Dictionary<string, Employee> employeeDirectory = new Dictionary<string, Employee>();
            // Add employees to dictionary
            foreach (Employee emp in employees)
            {
                employeeDirectory.Add(emp.Role, emp);
            }

            // Update dictionary data
            string KeyToUpdate = "HR";
            if(employeeDirectory.ContainsKey(KeyToUpdate))
            {
                employeeDirectory[KeyToUpdate] = new Employee("HR", "Eleka", 26, 20);
                Console.WriteLine("Employee with Role/Key {0} was updated!", KeyToUpdate);
            }
            else
            {
                Console.WriteLine("No employee was found with this key {0}.", KeyToUpdate);
            }
            Console.WriteLine();


            // Remove data
            string KeyToRemove = "Secretary";
            if (employeeDirectory.Remove(KeyToRemove))
            {
                Console.WriteLine("Employee with Role/Key '{0}' was removed.", KeyToRemove);
            }
            else
            {
                Console.WriteLine("No employee was found with this key {0}.", KeyToUpdate);
            }
            Console.WriteLine();

            // Retrieve data from dictionary
            // check if key is in dictionary
            string key = "CEO";
            if(employeeDirectory.ContainsKey(key))
            {
                Employee emp1 = employeeDirectory["CEO"];
                Console.WriteLine("Employee Name: {0}\nRole: {1}\nSalary: {2}", emp1.Name, emp1.Role, emp1.Salary);
            }
            else
            {
                Console.WriteLine("Key {0} does not exist.", key);
            }
            
            Console.WriteLine("---------------------");

            // using TryGetValue() -> returns true if the operation was successful and false otherwise
            Employee result = null;
            if (employeeDirectory.TryGetValue("Intern", out result))
            {
                Console.WriteLine("Value Retrieved!");

                Console.WriteLine("Employee Name: {0}", result.Name);
                Console.WriteLine("Employee Role: {0}", result.Role);
                Console.WriteLine("Employee Age: {0}", result.Age);
                Console.WriteLine("Employee Salary: {0}", result.Salary);
            }
            else
            {
                Console.WriteLine("The key does not exist.");
            }

            Console.WriteLine("---------------------");

            // Get element using a for loop and ElementAt() method
            for (int i = 0; i < employeeDirectory.Count; i++)
            {
                //using ElementAt(i) to return key-value pair stored at index 1
                //uses System.Linq;
                KeyValuePair<string, Employee> keyValuePair = employeeDirectory.ElementAt(i);
                //print the key
                Console.WriteLine("Key: {0}\ni is: {1}", keyValuePair.Key, i);
                //storing the value in an employee object
                Employee employeeValue = keyValuePair.Value;
                //printing the properties of the employee object
                Console.WriteLine("Employee Name: {0}", employeeValue.Name);
                Console.WriteLine("Employee Role: {0}", employeeValue.Role);
                Console.WriteLine("Employee Age: {0}", employeeValue.Age);
                Console.WriteLine("Employee Salary: {0}", employeeValue.Salary);
                Console.WriteLine("---------------------");
            }

            Console.ReadKey();
        }
    }

    class Employee
    {
        // properties
        public string Role { get; set; }

        public string Name { get; set; }

        public int Age { get; set; }

        public float Rate { get; set; }

        // Salary = rate/h * numbrt of days * number of weeks * number of months
        public float Salary
        {
            get
            {
                return Rate * 8 * 5 * 4 * 12;
            }
        }

        // constructor
        public Employee(string role, string name, int age, float rate)
        {
            this.Role = role;
            this.Name = name;
            this.Age = age;
            this.Rate = rate;
        }

        /* Coding Exercise
         
            using System;
            using System.Collections.Generic;

            namespace Coding.Exercise
            {
                public class Speller
                {
                    public static string Convert(int i)
                    {
                        // TODO
                        Dictionary<int, string> dic = new Dictionary<int, string>()
                        {
                            {0, "zero"},
                            {1, "one"},
                            {2, "two"},
                            {3, "three"},
                            {4, "four"},
                            {5, "five"}
                        };
            
                        if (dic.ContainsKey(i))
                        {
                            return dic[i];
                        }
                        else
                        {
                           return "nope"; 
                        }
                    }
                }
            }

         
        */
    }
}
