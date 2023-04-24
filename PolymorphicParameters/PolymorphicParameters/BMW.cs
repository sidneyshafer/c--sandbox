using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PolymorphicParameters
{
    // Class inherits from Car Class
    // can use "sealed" keyword to stop inheritance
    // Like this:
    /* sealed class BMW : Car
       {
            //code goes here
       }
    */
    class BMW : Car
    {
        private string brand = "BMW";
        public string Model { get; set; }

        public BMW(int hp, string color, string model):base(hp, color)
        {
            // Two lines below are not needed when using ':base' keyword
            //this.HP = hp;
            //this.Color = color;
            this.Model = model;
        }

        // Defualt constructor
        //public BMW()
        //{
        //
        //}

        public new void ShowDetails()
        {
            Console.WriteLine("Brand: " + brand + "\nHP: " + HP + "\nColor: " + Color);
        }

        // Use the "sealed" keyword if you do not want the method to be overriden again
        // Must use keyword before "override" keyword
        // Other classes are not longer allowed to use the method
        // Can also do it directy with classes
        public sealed override void Repair()
        {
            Console.WriteLine("The BMW {0} was repaired.", Model);
        }
    }
}
