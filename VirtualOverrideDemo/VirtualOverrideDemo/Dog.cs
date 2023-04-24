using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VirtualOverrideDemo
{
    class Dog : Animal
    {
        //bool property to check if dog is happy
        public bool IsHappy { get; set; }

        //simple constructor where we pass the name and age to our base constructor
        public Dog(string name, int age) : base(name, age)
        {
            IsHappy = true;
        }

        //simple override of the virtual Eat method
        public override void Eat()
        {
            //to call the eat method from our base class we use the keyowrd "base"
            base.Eat();
        }

        //override the virtual method MakeSound
        public override void MakeSound()
        {
            //each animal will implement their own version of MakeSound
            Console.WriteLine("Whoof! Whoof!");
        }

        //override virtual method Play
        public override void Play()
        {
            //check if dog is happy, if yes call the Play method from the base class
            if (IsHappy)
            {
                base.Play();
            }
        }
    }
}
