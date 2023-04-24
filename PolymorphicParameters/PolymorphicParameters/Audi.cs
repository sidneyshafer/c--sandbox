using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PolymorphicParameters
{
    class Audi : Car
    {
        private string brand = "Audi";
        public string Model { get; set; }

        public Audi(int hp, string color, string model) : base(hp, color)
        {
            this.Model = model;
        }

        // This ShowDetails() method has priorty of ShowDetails() method in Car class
        public new void ShowDetails()
        {
            Console.WriteLine("Brand: " + brand + "\nHP: " + HP + "\nColor: " + Color);
        }

        
        public override void Repair()
        {
            Console.WriteLine("The Audi {0} was repaired.", Model);
        }
    }
}
