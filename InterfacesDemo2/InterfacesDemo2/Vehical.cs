using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfacesDemo2
{
    //base class for vehicles
    class Vehical
    {
        //speed of vehicle
        public float Speed { get; set; }
        //color of vehicle
        public string Color { get; set; }

        //default constructor
        public Vehical()
        {
            Speed = 120f;
            Color = "White";
        }

        //simple constructor
        public Vehical(float speed, string color)
        {
            Speed = speed;
            Color = color;
        }


    }
}
