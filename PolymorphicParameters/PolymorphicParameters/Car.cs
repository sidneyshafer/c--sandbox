using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PolymorphicParameters
{
    class Car
    {
        // Properties
        public int HP { get; set; }
        public string Color { get; set; }

        // has a relationship
        protected CarIDInfo carIDInfo = new CarIDInfo();

        public void SetCarIDInfo(int idNum, string owner)
        {
            carIDInfo.IDNum = idNum;
            carIDInfo.Owner = owner;
        }

        public void GetCarIDInfo()
        {
            Console.WriteLine("Car ID : {0}\nOwner : {1}", carIDInfo.IDNum, carIDInfo.Owner);
        }

        // Constructor
        public Car(int hp, string color)
        {
            this.HP = hp;
            this.Color = color;
        }

        // Show details method
        public void ShowDetails()
        {
            Console.WriteLine("HP: " + HP + "\nColor: " + Color);
        }

        // Use 'virtual' keyword to override method from other classes
        public virtual void Repair()
        {
            Console.WriteLine("Car was repaired.");
        }
    }
}
